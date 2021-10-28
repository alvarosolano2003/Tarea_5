namespace Presentacion
{
    partial class FrmDepreciacion
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
            this.rtbMostrar = new System.Windows.Forms.RichTextBox();
            this.btnActivo = new System.Windows.Forms.Button();
            this.btnDepreciacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbMostrar
            // 
            this.rtbMostrar.Location = new System.Drawing.Point(13, 13);
            this.rtbMostrar.Name = "rtbMostrar";
            this.rtbMostrar.Size = new System.Drawing.Size(775, 279);
            this.rtbMostrar.TabIndex = 0;
            this.rtbMostrar.Text = "";
            // 
            // btnActivo
            // 
            this.btnActivo.Location = new System.Drawing.Point(704, 298);
            this.btnActivo.Name = "btnActivo";
            this.btnActivo.Size = new System.Drawing.Size(84, 23);
            this.btnActivo.TabIndex = 1;
            this.btnActivo.Text = "Crear Activo";
            this.btnActivo.UseVisualStyleBackColor = true;
            this.btnActivo.Click += new System.EventHandler(this.BtnActivo_Click);
            // 
            // btnDepreciacion
            // 
            this.btnDepreciacion.Location = new System.Drawing.Point(13, 298);
            this.btnDepreciacion.Name = "btnDepreciacion";
            this.btnDepreciacion.Size = new System.Drawing.Size(75, 23);
            this.btnDepreciacion.TabIndex = 2;
            this.btnDepreciacion.Text = "Ejecutar Metodo";
            this.btnDepreciacion.UseVisualStyleBackColor = true;
            // 
            // FrmDepreciacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 372);
            this.Controls.Add(this.btnDepreciacion);
            this.Controls.Add(this.btnActivo);
            this.Controls.Add(this.rtbMostrar);
            this.Name = "FrmDepreciacion";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbMostrar;
        private System.Windows.Forms.Button btnActivo;
        private System.Windows.Forms.Button btnDepreciacion;
    }
}

