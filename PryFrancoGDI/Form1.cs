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
    public partial class Form1 : Form
    {
        Pen lapiz = new Pen(Color.Red);
        Graphics lienzo;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //btnDibujar.Hide();
            lienzo = contenedor.CreateGraphics();
           // lienzo.DrawRectangle(lapiz, 50, 50, 50, 50);
            tempo.Enabled = true;
        }
        int ejex, ejey;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

         Random aleatoriox = new Random();

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

         Random aleatorioy = new Random();

        private void tempo_Tick(object sender, EventArgs e)
        {
            ejex = aleatoriox.Next(0, 600);
            ejey = aleatorioy.Next(0, 600);
            // lienzo.DrawRectangle(lapiz, ejex, ejey, 50, 50);
            picNave.Location = new Point(ejex, 600);
            picBola.Location = new Point(548 ,ejey);
        }

        
    }
}

