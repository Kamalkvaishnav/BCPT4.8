using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsolFromApp
{
    public partial class homeView1 : UserControl
    {

        public static homeView1 instance;
        public Label lb1;
        public homeView1()
        {
            InitializeComponent();
            instance = this;
            lb1 = nameLbl;

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nameLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
