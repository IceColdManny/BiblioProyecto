namespace BiblioProyecto
{
    partial class frm_bajaAut
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
            this.lbl_idBajaAut = new System.Windows.Forms.Label();
            this.txt_idBajaAut = new System.Windows.Forms.TextBox();
            this.btn_guardarBajaAut = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.lbl_idBajaAut);
            this.groupBox1.Controls.Add(this.txt_idBajaAut);
            this.groupBox1.Controls.Add(this.btn_guardarBajaAut);
            this.groupBox1.Location = new System.Drawing.Point(23, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 174);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese el ID a eliminar";
            // 
            // lbl_idBajaAut
            // 
            this.lbl_idBajaAut.AutoSize = true;
            this.lbl_idBajaAut.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_idBajaAut.ForeColor = System.Drawing.Color.Black;
            this.lbl_idBajaAut.Location = new System.Drawing.Point(16, 42);
            this.lbl_idBajaAut.Name = "lbl_idBajaAut";
            this.lbl_idBajaAut.Size = new System.Drawing.Size(23, 16);
            this.lbl_idBajaAut.TabIndex = 5;
            this.lbl_idBajaAut.Text = "ID:";
            // 
            // txt_idBajaAut
            // 
            this.txt_idBajaAut.Location = new System.Drawing.Point(122, 39);
            this.txt_idBajaAut.Name = "txt_idBajaAut";
            this.txt_idBajaAut.Size = new System.Drawing.Size(100, 22);
            this.txt_idBajaAut.TabIndex = 1;
            // 
            // btn_guardarBajaAut
            // 
            this.btn_guardarBajaAut.BackColor = System.Drawing.Color.Beige;
            this.btn_guardarBajaAut.Location = new System.Drawing.Point(94, 101);
            this.btn_guardarBajaAut.Name = "btn_guardarBajaAut";
            this.btn_guardarBajaAut.Size = new System.Drawing.Size(128, 41);
            this.btn_guardarBajaAut.TabIndex = 0;
            this.btn_guardarBajaAut.Text = "Guardar Cambios";
            this.btn_guardarBajaAut.UseVisualStyleBackColor = false;
            this.btn_guardarBajaAut.Click += new System.EventHandler(this.btn_guardarAltaAut_Click);
            // 
            // frm_bajaAut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(351, 227);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_bajaAut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido";
            this.Load += new System.EventHandler(this.frm_bajaAut_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_idBajaAut;
        private System.Windows.Forms.TextBox txt_idBajaAut;
        private System.Windows.Forms.Button btn_guardarBajaAut;
    }
}