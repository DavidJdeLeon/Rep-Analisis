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

namespace EnviarDatosCorreo
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
     


            try
            {
                
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("pruebas.com");
                mail.To.Add(new MailAddress("pruebas.com"));
                mail.Subject = "Prueba de correo";
                mail.Body = "Hola...";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.EnableSsl = false;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("pruebass@hotmail.com", "pruebas");
                smtp.EnableSsl = true;


                smtp.Send(mail);
                MessageBox.Show("Mail has been sent successfully!", "Email Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);


                

            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }

        }
    }
}
