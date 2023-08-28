namespace PryFrancoGDI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnDibujar = new System.Windows.Forms.Button();
            this.tempo = new System.Windows.Forms.Timer(this.components);
            this.contenedor = new System.Windows.Forms.PictureBox();
            this.picNave = new System.Windows.Forms.PictureBox();
            this.picBola = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.contenedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBola)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDibujar
            // 
            this.btnDibujar.Location = new System.Drawing.Point(12, 12);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(75, 23);
            this.btnDibujar.TabIndex = 1;
            this.btnDibujar.Text = "dibujar";
            this.btnDibujar.UseVisualStyleBackColor = true;
            this.btnDibujar.Click += new System.EventHandler(this.button1_Click);
            // 
            // tempo
            // 
            this.tempo.Tick += new System.EventHandler(this.tempo_Tick);
            // 
            // contenedor
            // 
            this.contenedor.BackColor = System.Drawing.Color.Transparent;
            this.contenedor.Location = new System.Drawing.Point(12, 81);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(776, 540);
            this.contenedor.TabIndex = 3;
            this.contenedor.TabStop = false;
            this.contenedor.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // picNave
            // 
            this.picNave.BackColor = System.Drawing.SystemColors.ControlDark;
            this.picNave.Location = new System.Drawing.Point(12, 571);
            this.picNave.Name = "picNave";
            this.picNave.Size = new System.Drawing.Size(100, 50);
            this.picNave.TabIndex = 4;
            this.picNave.TabStop = false;
            // 
            // picBola
            // 
            this.picBola.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picBola.Image = ((System.Drawing.Image)(resources.GetObject("picBola.Image")));
            this.picBola.ImageLocation = "";
            this.picBola.Location = new System.Drawing.Point(39, 548);
            this.picBola.Name = "picBola";
            this.picBola.Size = new System.Drawing.Size(23, 17);
            this.picBola.TabIndex = 5;
            this.picBola.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 633);
            this.Controls.Add(this.picBola);
            this.Controls.Add(this.picNave);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.btnDibujar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contenedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBola)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDibujar;
        private System.Windows.Forms.Timer tempo;
        private System.Windows.Forms.PictureBox contenedor;
        private System.Windows.Forms.PictureBox picNave;
        private System.Windows.Forms.PictureBox picBola;
    }
}

