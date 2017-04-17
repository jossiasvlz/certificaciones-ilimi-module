using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Printing : Form
    {
        public Printing()
        {
            InitializeComponent();
            
        }

        private void progress_ProgressChanged(object sender, EventArgs e)
        {

        }

        private void Printing_Load(object sender, EventArgs e)
        {
            logoAnimator.ShowSync(logo);
        }
    }
}
