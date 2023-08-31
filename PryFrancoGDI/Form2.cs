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
        public int velocidad = 5;
        private void btnJugar_Click(object sender, EventArgs e)
        {

        }

        private void tempo_Tick(object sender, EventArgs e)
        {

        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            this.Focus();
            if(e.KeyCode == Keys.Left)
            {
                
                if (picNave.Left > 0)
                {
                    picNave.Left -= velocidad;
                }
            }
            else if (e.KeyCode == Keys.Right)
            {
                if(picNave.Right < ClientSize.Width)
                {
                    picNave.Left += velocidad;
                }
            }
          
        }

        private void picNave_Click(object sender, EventArgs e)
        {

        }
        //PictureBox bola = new PictureBox();
        private void btnJugar_Click_1(object sender, EventArgs e)
        {
            btnJugar.Location = new Point(1000, 0);
            Enabled = false;
            timer.Enabled = true;
        }
        //PictureBox bola = new PictureBox();
        private void timer_Tick(object sender, EventArgs e)
        {
            PictureBox bola = new PictureBox();
            bola.Location = picNave.Location;
            bola.Width = 20;
            bola.Height = 20;
            bola.BackColor = Color.Black;
            bola.TabIndex = picNave.TabIndex;
            bola.TabStop = false;

            Controls.Add(bola);

            
        }
    }
}
