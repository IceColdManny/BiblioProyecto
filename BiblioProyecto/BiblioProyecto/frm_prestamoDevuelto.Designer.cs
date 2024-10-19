namespace BiblioProyecto
{
    partial class frm_prestamoDevuelto
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_idDevPres = new System.Windows.Forms.Label();
            this.txt_idDevPres = new System.Windows.Forms.TextBox();
            this.btn_guardarDevPres = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Pink;
            this.groupBox1.Controls.Add(this.lbl_idDevPres);
            this.groupBox1.Controls.Add(this.txt_idDevPres);
            this.groupBox1.Controls.Add(this.btn_guardarDevPres);
            this.groupBox1.Location = new System.Drawing.Point(28, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 174);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese el ID de prestamo para marcarlo como devuelto";
            // 
            // lbl_idDevPres
            // 
            this.lbl_idDevPres.AutoSize = true;
            this.lbl_idDevPres.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_idDevPres.ForeColor = System.Drawing.Color.Black;
            this.lbl_idDevPres.Location = new System.Drawing.Point(16, 42);
            this.lbl_idDevPres.Name = "lbl_idDevPres";
            this.lbl_idDevPres.Size = new System.Drawing.Size(23, 16);
            this.lbl_idDevPres.TabIndex = 5;
            this.lbl_idDevPres.Text = "ID:";
            // 
            // txt_idDevPres
            // 
            this.txt_idDevPres.Location = new System.Drawing.Point(121, 38);
            this.txt_idDevPres.Name = "txt_idDevPres";
            this.txt_idDevPres.Size = new System.Drawing.Size(100, 22);
            this.txt_idDevPres.TabIndex = 1;
            // 
            // btn_guardarDevPres
            // 
            this.btn_guardarDevPres.BackColor = System.Drawing.Color.Beige;
            this.btn_guardarDevPres.Location = new System.Drawing.Point(68, 98);
            this.btn_guardarDevPres.Name = "btn_guardarDevPres";
            this.btn_guardarDevPres.Size = new System.Drawing.Size(128, 41);
            this.btn_guardarDevPres.TabIndex = 0;
            this.btn_guardarDevPres.Text = "Guardar Cambios";
            this.btn_guardarDevPres.UseVisualStyleBackColor = false;
            this.btn_guardarDevPres.Click += new System.EventHandler(this.btn_guardarDevPres_Click);
            // 
            // frm_prestamoDevuelto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(331, 220);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_prestamoDevuelto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_idDevPres;
        private System.Windows.Forms.TextBox txt_idDevPres;
        private System.Windows.Forms.Button btn_guardarDevPres;
    }
}