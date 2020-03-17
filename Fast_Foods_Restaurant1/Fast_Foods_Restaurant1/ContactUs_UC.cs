using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fast_Foods_Restaurant1
{
    public partial class ContactUs_UC : UserControl
    {
        public ContactUs_UC()
        {
            InitializeComponent();
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {

            string strFolderPath = Application.StartupPath + "/myFile/";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image,Pdf Only|*.jpg;*.jpeg;*.png;*.ico|Pdf Only|*.pdf";
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                
                lblUpload.Text = ofd.SafeFileName;
            }
            
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            String name, CallNumberPhone, Email,Message;
            name = txtName.Text;
            CallNumberPhone = txtCallNumber.Text;
            Email = txtEmail.Text;
            Message = txtMessnger.Text;

            MessageBox.Show("name"+name+"\ncallNumber"+CallNumberPhone+"\nEmail"+Email+"\nMessage"+Message, "Contact us");
        }

        private void ContactUs_UC_Load(object sender, EventArgs e)
        {
            cmbTheContact.Items.Add(" ");
            cmbTheContact.Items.Add("Contact");
            cmbTheContact.Items.Add("Complain");
            cmbTheContact.Items.Add("recommend");
            cmbTheContact.Items.Add("query");
        }
    }
}
