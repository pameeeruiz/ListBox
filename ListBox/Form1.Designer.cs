namespace ListBox
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
            this.ListBoxAnimales = new System.Windows.Forms.ListBox();
            this.PictureBoxAnimales = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAnimales)).BeginInit();
            this.SuspendLayout();
            // 
            // ListBoxAnimales
            // 
            this.ListBoxAnimales.FormattingEnabled = true;
            this.ListBoxAnimales.Location = new System.Drawing.Point(116, 61);
            this.ListBoxAnimales.Name = "ListBoxAnimales";
            this.ListBoxAnimales.Size = new System.Drawing.Size(156, 95);
            this.ListBoxAnimales.TabIndex = 0;
            this.ListBoxAnimales.SelectedIndexChanged += new System.EventHandler(this.ListBoxAnimales_SelectedIndexChanged);
            // 
            // PictureBoxAnimales
            // 
            this.PictureBoxAnimales.Location = new System.Drawing.Point(116, 201);
            this.PictureBoxAnimales.Name = "PictureBoxAnimales";
            this.PictureBoxAnimales.Size = new System.Drawing.Size(156, 140);
            this.PictureBoxAnimales.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxAnimales.TabIndex = 1;
            this.PictureBoxAnimales.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 420);
            this.Controls.Add(this.PictureBoxAnimales);
            this.Controls.Add(this.ListBoxAnimales);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAnimales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxAnimales;
        private System.Windows.Forms.PictureBox PictureBoxAnimales;
    }
}

