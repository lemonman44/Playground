using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SmtpClient smtpClient = new SmtpClient();
            NetworkCredential basicCredential = new NetworkCredential("AdamLehman2018@gmail.com", "lemonman44");
            MailMessage message = new MailMessage();
            MailAddress fromAddress = new MailAddress("AdamLehman2018@gmail.com");
            smtpClient.EnableSsl = true;

            smtpClient.Host = "smtp.gmail.com";
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = basicCredential;

            message.From = fromAddress;

            message.Subject = "yo";
            //Set IsBodyHtml to true means you can send HTML email.
            message.IsBodyHtml = true;
            message.Body = "<h1>your message body</h1>";

            Attachment salesReport = new Attachment("");
            //message.Attachments.Add();

            message.To.Add("michael.day0621@gmail.com");


            try
            {
                for (int i = 0; i < 100; i++)
                {
                    smtpClient.Send(message);
                }
            }
            catch (Exception ex)
            {
                //Error, could not send the message
                Console.Write(ex);
            }
        }
    }
}
