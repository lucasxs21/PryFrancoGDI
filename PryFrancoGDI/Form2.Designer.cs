namespace PryFrancoGDI
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picBase = new System.Windows.Forms.PictureBox();
            this.picNave = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNave)).BeginInit();
            this.SuspendLayout();
            // 
            // picBase
            // 
            this.picBase.Location = new System.Drawing.Point(1, 2);
            this.picBase.Name = "picBase";
            this.picBase.Size = new System.Drawing.Size(797, 446);
            this.picBase.TabIndex = 0;
            this.picBase.TabStop = false;
            // 
            // picNave
            // 
            this.picNave.BackColor = System.Drawing.SystemColors.ControlDark;
            this.picNave.Location = new System.Drawing.Point(13, 388);
            this.picNave.Name = "picNave";
            this.picNave.Size = new System.Drawing.Size(100, 50);
            this.picNave.TabIndex = 2;
            this.picNave.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picNave);
            this.Controls.Add(this.picBase);
            this.Name = "Form2";
            this.Text = "jugar";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNave)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBase;
        private System.Windows.Forms.PictureBox picNave;
    }
}