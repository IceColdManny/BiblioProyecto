namespace BiblioProyecto
{
    partial class frm_altaAut
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
            this.btn_guardarAltaAut = new System.Windows.Forms.Button();
            this.txt_idAltaAut = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_nacionAltaAut = new System.Windows.Forms.Label();
            this.lbl_apellidoAltaAut = new System.Windows.Forms.Label();
            this.lbl_nombreAltaAut = new System.Windows.Forms.Label();
            this.lbl_idAltaAut = new System.Windows.Forms.Label();
            this.txt_nacionAltaAut = new System.Windows.Forms.TextBox();
            this.txt_apellidoAltaAut = new System.Windows.Forms.TextBox();
            this.txt_nombreAltaAut = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_guardarAltaAut
            // 
            this.btn_guardarAltaAut.BackColor = System.Drawing.Color.Beige;
            this.btn_guardarAltaAut.Location = new System.Drawing.Point(138, 182);
            this.btn_guardarAltaAut.Name = "btn_guardarAltaAut";
            this.btn_guardarAltaAut.Size = new System.Drawing.Size(128, 41);
            this.btn_guardarAltaAut.TabIndex = 0;
            this.btn_guardarAltaAut.Text = "Guardar Cambios";
            this.btn_guardarAltaAut.UseVisualStyleBackColor = false;
            this.btn_guardarAltaAut.Click += new System.EventHandler(this.btn_guardarAltaAut_Click);
            // 
            // txt_idAltaAut
            // 
            this.txt_idAltaAut.Location = new System.Drawing.Point(122, 39);
            this.txt_idAltaAut.Name = "txt_idAltaAut";
            this.txt_idAltaAut.Size = new System.Drawing.Size(100, 22);
            this.txt_idAltaAut.TabIndex = 1;
            this.txt_idAltaAut.TextChanged += new System.EventHandler(this.txt_idAltaAut_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.lbl_nacionAltaAut);
            this.groupBox1.Controls.Add(this.lbl_apellidoAltaAut);
            this.groupBox1.Controls.Add(this.lbl_nombreAltaAut);
            this.groupBox1.Controls.Add(this.lbl_idAltaAut);
            this.groupBox1.Controls.Add(this.txt_nacionAltaAut);
            this.groupBox1.Controls.Add(this.txt_apellidoAltaAut);
            this.groupBox1.Controls.Add(this.txt_nombreAltaAut);
            this.groupBox1.Controls.Add(this.txt_idAltaAut);
            this.groupBox1.Controls.Add(this.btn_guardarAltaAut);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 251);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese los datos a cambiar o insertar";
            // 
            // lbl_nacionAltaAut
            // 
            this.lbl_nacionAltaAut.AutoSize = true;
            this.lbl_nacionAltaAut.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_nacionAltaAut.ForeColor = System.Drawing.Color.Black;
            this.lbl_nacionAltaAut.Location = new System.Drawing.Point(15, 126);
            this.lbl_nacionAltaAut.Name = "lbl_nacionAltaAut";
            this.lbl_nacionAltaAut.Size = new System.Drawing.Size(91, 16);
            this.lbl_nacionAltaAut.TabIndex = 8;
            this.lbl_nacionAltaAut.Text = "Nacionalidad:";
            // 
            // lbl_apellidoAltaAut
            // 
            this.lbl_apellidoAltaAut.AutoSize = true;
            this.lbl_apellidoAltaAut.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_apellidoAltaAut.ForeColor = System.Drawing.Color.Black;
            this.lbl_apellidoAltaAut.Location = new System.Drawing.Point(15, 95);
            this.lbl_apellidoAltaAut.Name = "lbl_apellidoAltaAut";
            this.lbl_apellidoAltaAut.Size = new System.Drawing.Size(60, 16);
            this.lbl_apellidoAltaAut.TabIndex = 7;
            this.lbl_apellidoAltaAut.Text = "Apellido:";
            this.lbl_apellidoAltaAut.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_nombreAltaAut
            // 
            this.lbl_nombreAltaAut.AutoSize = true;
            this.lbl_nombreAltaAut.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_nombreAltaAut.ForeColor = System.Drawing.Color.Black;
            this.lbl_nombreAltaAut.Location = new System.Drawing.Point(16, 70);
            this.lbl_nombreAltaAut.Name = "lbl_nombreAltaAut";
            this.lbl_nombreAltaAut.Size = new System.Drawing.Size(59, 16);
            this.lbl_nombreAltaAut.TabIndex = 6;
            this.lbl_nombreAltaAut.Text = "Nombre:";
            // 
            // lbl_idAltaAut
            // 
            this.lbl_idAltaAut.AutoSize = true;
            this.lbl_idAltaAut.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_idAltaAut.ForeColor = System.Drawing.Color.Black;
            this.lbl_idAltaAut.Location = new System.Drawing.Point(16, 42);
            this.lbl_idAltaAut.Name = "lbl_idAltaAut";
            this.lbl_idAltaAut.Size = new System.Drawing.Size(23, 16);
            this.lbl_idAltaAut.TabIndex = 5;
            this.lbl_idAltaAut.Text = "ID:";
            // 
            // txt_nacionAltaAut
            // 
            this.txt_nacionAltaAut.Location = new System.Drawing.Point(122, 123);
            this.txt_nacionAltaAut.Name = "txt_nacionAltaAut";
            this.txt_nacionAltaAut.Size = new System.Drawing.Size(199, 22);
            this.txt_nacionAltaAut.TabIndex = 4;
            // 
            // txt_apellidoAltaAut
            // 
            this.txt_apellidoAltaAut.Location = new System.Drawing.Point(122, 95);
            this.txt_apellidoAltaAut.Name = "txt_apellidoAltaAut";
            this.txt_apellidoAltaAut.Size = new System.Drawing.Size(276, 22);
            this.txt_apellidoAltaAut.TabIndex = 3;
            // 
            // txt_nombreAltaAut
            // 
            this.txt_nombreAltaAut.Location = new System.Drawing.Point(122, 67);
            this.txt_nombreAltaAut.Name = "txt_nombreAltaAut";
            this.txt_nombreAltaAut.Size = new System.Drawing.Size(276, 22);
            this.txt_nombreAltaAut.TabIndex = 2;
            // 
            // frm_altaAut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(471, 303);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "frm_altaAut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido";
            this.Load += new System.EventHandler(this.frm_altaAut_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_guardarAltaAut;
        private System.Windows.Forms.TextBox txt_idAltaAut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_nacionAltaAut;
        private System.Windows.Forms.TextBox txt_apellidoAltaAut;
        private System.Windows.Forms.TextBox txt_nombreAltaAut;
        private System.Windows.Forms.Label lbl_idAltaAut;
        private System.Windows.Forms.Label lbl_apellidoAltaAut;
        private System.Windows.Forms.Label lbl_nombreAltaAut;
        private System.Windows.Forms.Label lbl_nacionAltaAut;
    }
}