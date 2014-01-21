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
    
//ideas for this application from youtube user Andrew Mays
namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //gmail smtp settings
            SmtpClient client = new SmtpClient();
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.EnableSsl = true;

            //generate the mail from user inputs
            MailMessage Message = new MailMessage();
            Message.From = new MailAddress("bfeigert@gmail.com");
            string MailBox = textBoxEmail.Text.Trim();
            Message.To.Add(MailBox);
            Message.Body = "Welcome to the Ice Cream Delivery Service. We're so glad you're here." + 
                "\n\n Your username is:" +textBoxUsername.Text + 
                "\n\n Your Password is:" + textBoxPwd.Text + 
                "\n\n Your favorite ice cream is:" + textBoxIceCream.Text + 
                "\n\n Thanks for signing up.";
            Message.Subject = "Account Details: Ice Cream Delivery.";

            //manage sending credentials. I've hidden my personal password inside a field in the form.
            string Magic = textBoxMagic.Text.Trim();
            client.Credentials = new System.Net.NetworkCredential("bfeigert@gmail.com", Magic);
            client.Send(Message);

            MessageBox.Show("Message Sent! Check your email for account information.");
            
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelMagic_Click(object sender, EventArgs e)
        {

        }
    }
}
