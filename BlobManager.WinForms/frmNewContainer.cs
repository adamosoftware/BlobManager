using BlobManager.WinForms.Models;
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
    }
}
