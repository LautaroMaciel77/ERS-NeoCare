using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERS_NeoCare.Design
{
    public partial class administrativo : UserControl
    {
        private menu MainForm { get; set; }

        public administrativo()
        {
            InitializeComponent();
        }

        public void SetMainForm(menu mainForm)
        {
            MainForm = mainForm;
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
       
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

        }
    }
}

