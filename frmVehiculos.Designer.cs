namespace PryLedoEtapa4
{
    partial class frmVehiculos
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
            this.BtnVehiculos = new System.Windows.Forms.Button();
            this.lstMostrarVehiculos = new System.Windows.Forms.ListBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnVehiculos
            // 
            this.BtnVehiculos.BackColor = System.Drawing.Color.LightBlue;
            this.BtnVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVehiculos.Location = new System.Drawing.Point(69, 349);
            this.BtnVehiculos.Name = "BtnVehiculos";
            this.BtnVehiculos.Size = new System.Drawing.Size(441, 52);
            this.BtnVehiculos.TabIndex = 0;
            this.BtnVehiculos.Text = "Listar Vehiculos";
            this.BtnVehiculos.UseVisualStyleBackColor = false;
            this.BtnVehiculos.Click += new System.EventHandler(this.BtnVehiculos_Click);
            // 
            // lstMostrarVehiculos
            // 
            this.lstMostrarVehiculos.FormattingEnabled = true;
            this.lstMostrarVehiculos.Location = new System.Drawing.Point(69, 248);
            this.lstMostrarVehiculos.Name = "lstMostrarVehiculos";
            this.lstMostrarVehiculos.Size = new System.Drawing.Size(441, 95);
            this.lstMostrarVehiculos.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PryLedoEtapa4.Properties.Resources.barco_removebg_preview;
            this.pictureBox3.Location = new System.Drawing.Point(381, 56);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(129, 133);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PryLedoEtapa4.Properties.Resources.avion_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(227, 56);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(129, 133);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PryLedoEtapa4.Properties.Resources.auto;
            this.pictureBox1.Location = new System.Drawing.Point(69, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(581, 429);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lstMostrarVehiculos);
            this.Controls.Add(this.BtnVehiculos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVehiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generacion de Vehiculos en una Lista ";
            this.Load += new System.EventHandler(this.frmVehiculos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmVehiculos_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnVehiculos;
        private System.Windows.Forms.ListBox lstMostrarVehiculos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

