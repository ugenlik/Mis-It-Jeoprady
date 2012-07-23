using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mis_It_Jeoprady
{
    public partial class chap4_200 : Form
    {
        public chap4_200(String question,String answer)
        {
            InitializeComponent();
            label1.Text = question;
            label2.Text = answer;
        }

        private void answer_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            label1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
