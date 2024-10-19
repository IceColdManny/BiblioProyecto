namespace BiblioProyecto
{
    partial class frm_bajaPrestamos
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
            this.lbl_idBajaPres = new System.Windows.Forms.Label();
            this.txt_idBajaPres = new System.Windows.Forms.TextBox();
            this.btn_guardarBajaPres = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Pink;
            this.groupBox1.Controls.Add(this.lbl_idBajaPres);
            this.groupBox1.Controls.Add(this.txt_idBajaPres);
            this.groupBox1.Controls.Add(this.btn_guardarBajaPres);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 174);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese el ID a eliminar";
            // 
            // lbl_idBajaPres
            // 
            this.lbl_idBajaPres.AutoSize = true;
            this.lbl_idBajaPres.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_idBajaPres.ForeColor = System.Drawing.Color.Black;
            this.lbl_idBajaPres.Location = new System.Drawing.Point(16, 42);
            this.lbl_idBajaPres.Name = "lbl_idBajaPres";
            this.lbl_idBajaPres.Size = new System.Drawing.Size(23, 16);
            this.lbl_idBajaPres.TabIndex = 5;
            this.lbl_idBajaPres.Text = "ID:";
            // 
            // txt_idBajaPres
            // 
            this.txt_idBajaPres.Location = new System.Drawing.Point(122, 39);
            this.txt_idBajaPres.Name = "txt_idBajaPres";
            this.txt_idBajaPres.Size = new System.Drawing.Size(100, 22);
            this.txt_idBajaPres.TabIndex = 1;
            // 
            // btn_guardarBajaPres
            // 
            this.btn_guardarBajaPres.BackColor = System.Drawing.Color.Beige;
            this.btn_guardarBajaPres.Location = new System.Drawing.Point(70, 101);
            this.btn_guardarBajaPres.Name = "btn_guardarBajaPres";
            this.btn_guardarBajaPres.Size = new System.Drawing.Size(128, 41);
            this.btn_guardarBajaPres.TabIndex = 0;
            this.btn_guardarBajaPres.Text = "Guardar Cambios";
            this.btn_guardarBajaPres.UseVisualStyleBackColor = false;
            this.btn_guardarBajaPres.Click += new System.EventHandler(this.btn_guardarBajaPres_Click);
            // 
            // frm_bajaPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(305, 203);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_bajaPrestamos";
            this.Text = "Bienvenido";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_idBajaPres;
        private System.Windows.Forms.TextBox txt_idBajaPres;
        private System.Windows.Forms.Button btn_guardarBajaPres;
    }
}