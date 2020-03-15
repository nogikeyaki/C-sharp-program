using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_Model_20200315.Form_Dir
{
    public partial class Login_Fm : Form
    {
        public Login_Fm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
