﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace STUEnrollmentSystem
{
    internal class EmailSender
    {
        public void SendEmail(string recipientEmail, string subject, string body)
        {
            if (recipientEmail.Equals(string.Empty))
            {
                throw new Exception("No email is found.");
            }

            string senderEmail = "stuofficialschool@gmail.com"; 
            string senderPassword = "hibz zouo afaw nwzl";     

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(senderEmail, senderPassword),
                EnableSsl = true,
            };

            MailMessage mail = new MailMessage
            {
                From = new MailAddress(senderEmail),
                Subject = subject,
                Body = body,
                IsBodyHtml = false 
            };

            mail.To.Add(recipientEmail);

            try
            {
                smtpClient.Send(mail);
                Console.WriteLine("Email sent successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to send email: {ex.Message}");
                return;
            }
        }
    }
}