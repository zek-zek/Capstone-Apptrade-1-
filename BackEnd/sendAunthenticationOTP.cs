using Microsoft.VisualBasic.Devices;
using System;
using System.Net;
using System.Net.Mail;
using System.Windows;

namespace Capstone_Apptrade.BackEnd
{
    public class sendAunthenticationOTP
    {
        string from, pass, messasgeBody;
        public string randomCode;
        public static string to;
        accountInformation accountInformation;


        


        public void authenticationOTP()
        {

            Random random = new Random();
            randomCode = (random.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = (accountInformation.Email).ToString();
            from = "apptrade22@gmail.com";
            pass = "pimijgjtvfvuqupm";
            messasgeBody = "Your reset code is " + randomCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messasgeBody;
            message.Subject = "Password Reseting Code";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);


            try
            {
                smtp.Send(message);
                MessageBox.Show("OTP sent successfuly");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
