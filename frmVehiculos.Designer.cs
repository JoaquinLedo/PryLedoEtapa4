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
            this.SuspendLayout();
            // 
            // BtnVehiculos
            // 
            this.BtnVehiculos.BackColor = System.Drawing.Color.LightBlue;
            this.BtnVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVehiculos.Location = new System.Drawing.Point(265, 451);
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
            this.lstMostrarVehiculos.Location = new System.Drawing.Point(265, 350);
            this.lstMostrarVehiculos.Name = "lstMostrarVehiculos";
            this.lstMostrarVehiculos.Size = new System.Drawing.Size(441, 95);
            this.lstMostrarVehiculos.TabIndex = 1;
            // 
            // frmVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 515);
            this.Controls.Add(this.lstMostrarVehiculos);
            this.Controls.Add(this.BtnVehiculos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVehiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generacion de Vehiculos en una Lista ";
            this.Load += new System.EventHandler(this.frmVehiculos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmVehiculos_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnVehiculos;
        private System.Windows.Forms.ListBox lstMostrarVehiculos;
    }
}

