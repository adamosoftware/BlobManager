using BlobManager.WinForms.Models;
using System;
using System.Windows.Forms;

namespace BlobManager.WinForms
{
    public partial class frmNewContainer : Form
    {
        public frmNewContainer()
        {
            InitializeComponent();
        }

        public StorageAccount StorageAccount { get; set; }

        public string ContainerName {  get { return tbName.Text; } }

        private void BtnOK_Click(object sender, System.EventArgs e)
        {
            try
            {
                var storage = new BlobStorage(StorageAccount);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
