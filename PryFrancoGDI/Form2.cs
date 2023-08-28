using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryFrancoGDI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public int pictureboxspeed = 5;
        private void btnJugar_Click(object sender, EventArgs e)
        {

        }

        private void tempo_Tick(object sender, EventArgs e)
        {

        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                
                if (picNave.Left > 0)
                {
                    picNave.Left -= pictureboxspeed;
                }
            }
            else if (e.KeyCode == Keys.Right)
            {
                if(picNave.Right < ClientSize.Width)
                {
                    picNave.Left += pictureboxspeed;
                }
            }
        }
    }
}
