using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STUEnrollmentSystem
{
    public partial class frmSystemLogs : Form
    {
        private LogsRepository _logsRepository;

        public frmSystemLogs()
        {
            InitializeComponent();
            _logsRepository = new LogsRepository(ConnectionFactory.GetConnectionString());
            this.tableAdapterManager.Connection.ConnectionString = ConnectionFactory.GetConnectionString();
        }

        private void logsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.logsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sTU_DBDataSet);

        }

        private void frmSystemLogs_Load(object sender, EventArgs e)
        {
            this.logsTableAdapter.Fill(this.sTU_DBDataSet.Logs);
        }

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            this.logsTableAdapter.Update(this.sTU_DBDataSet);
            this.logsTableAdapter.Fill(this.sTU_DBDataSet.Logs);
        }

        private void searchToolStripButton_Click(object sender, EventArgs e)
        {
            if (downloadButton.Enabled == true)
            {
                downloadButton.Enabled = false;
            }

            if (Regex.IsMatch(yearTextBox.Text+monthTextBox.Text+dayTextBox.Text, ".*[a-zA-Z].*"))
            {
                MessageBox.Show("Alphabet characters are invalid.", "Error", MessageBoxButtons.OK);
                return;
            }
            
            if (yearTextBox.Text.Equals(string.Empty) || monthTextBox.Text.Equals(string.Empty) || dayTextBox.Text.Equals(string.Empty))
            {
                MessageBox.Show("Missing details, unable to search.", "Error", MessageBoxButtons.OK);
                return;
            }

            if (Convert.ToInt32(monthTextBox.Text) > 12)
            {
                MessageBox.Show("Month can't be greater than 12.", "Error", MessageBoxButtons.OK);
                return;
            }

            downloadButton.Enabled = true;

            try
            {
                this.logsTableAdapter.Search(this.sTU_DBDataSet.Logs, timeStampToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return;
            }
        }

        private void searchJoinDateTimeStamp_TextChanged(object sender, EventArgs e)
        {
            if (sender == yearTextBox || sender == monthTextBox || sender == dayTextBox)
            {
                timeStampToolStripTextBox.Text = $"{yearTextBox.Text}-{monthTextBox.Text}-{dayTextBox.Text}";
            }
        }

        private void ExportLogsToTextFile()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                string[] dateTimeStampParts = timeStampToolStripTextBox.Text.Split('-');
                string dateTimeStampJoin = dateTimeStampParts[0] + dateTimeStampParts[1] + dateTimeStampParts[2];

                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.DefaultExt = "txt"; 
                saveFileDialog.FileName = $"logs{dateTimeStampJoin}.txt"; 

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = saveFileDialog.FileName;
                    var logs = _logsRepository.GetLogsFromDatabase(yearTextBox.Text, monthTextBox.Text, dayTextBox.Text);

                    using (var writer = new StreamWriter(selectedFilePath))
                    {
                        foreach (var log in logs)
                        {
                            writer.WriteLine($"{log["TimeStamp"]} [{log["Level"]}] {log["Message"]}");

                            // If an exception exists, write it to the log file
                            if (!string.IsNullOrEmpty(log["Exception"]))
                            {
                                writer.WriteLine($"Exception: {log["Exception"]}");
                            }

                            // Add a separator for readability
                            writer.WriteLine(new string('-', 50));
                        }
                    }

                    MessageBox.Show("Logs exported successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            ExportLogsToTextFile();
        }
    }
}
