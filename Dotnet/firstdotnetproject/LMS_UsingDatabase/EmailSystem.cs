using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS_UsingDatabase
{
    public partial class EmailSystem : Form
    {
        public EmailSystem()
        {
            InitializeComponent();
        }

        private void EmailSystem_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Server");
            dt.Columns.Add("Port");
            dt.Rows.Add("smtp.gmail.com-SSL", "465");
            dt.Rows.Add("smtp.gmail.com-StartTLS", "587");
            dt.Rows.Add("smtp.mail.yahoo.com-SSL", "465");
            dt.Rows.Add("smtp.live.com-StartTLS", "587");

            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Server";
            comboBox1.ValueMember = "Port";
            comboBox1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                using (SmtpClient client = new SmtpClient())
                {
                    client.Port = int.Parse(comboBox1.SelectedValue.ToString());//465 OR 587
                    var servernamearray = comboBox1.Text.Split('-');
                    client.Host = servernamearray[0];//smtp.gmail.com
                    client.EnableSsl = true;
                    client.Timeout = 100000;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;

                    client.Credentials = new System.Net.NetworkCredential(txtUserName.Text, txtPassword.Text);//gmail userid and password

                    using (MailMessage objeto_mail = new MailMessage(txtFrom.Text, txtTo.Text))
                    {
                        objeto_mail.Subject = txtSubject.Text;
                        if (txtBody.Text.Trim() != "")
                        {
                            objeto_mail.Body = txtBody.Text.Trim();
                        }

                        if (txtCC.Text.Trim() != "")
                        {
                            objeto_mail.CC.Add(txtCC.Text.Trim());
                        }

                        if (txtBCC.Text.Trim() != "")
                        {
                            objeto_mail.Bcc.Add(txtBCC.Text.Trim());
                        }
                        objeto_mail.Priority = MailPriority.High;
                        objeto_mail.BodyEncoding = UTF8Encoding.UTF8;
                        objeto_mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

                        client.Send(objeto_mail);
                        lblErrorMessage.Text = "Mail Sent Successfully";
                    }
                }
            }
            catch (Exception ex)
            {
                lblErrorMessage.Text = ex.Message;
            }
        }
    }
}
