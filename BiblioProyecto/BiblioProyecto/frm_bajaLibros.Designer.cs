namespace DataInterface
{
    partial class frm_bajaLibros
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
            this.lbl_idBajaLib = new System.Windows.Forms.Label();
            this.txt_idBajaLib = new System.Windows.Forms.TextBox();
            this.btn_guardarBajaLib = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.lbl_idBajaLib);
            this.groupBox1.Controls.Add(this.txt_idBajaLib);
            this.groupBox1.Controls.Add(this.btn_guardarBajaLib);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 174);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese el ID a eliminar";
            // 
            // lbl_idBajaLib
            // 
            this.lbl_idBajaLib.AutoSize = true;
            this.lbl_idBajaLib.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_idBajaLib.ForeColor = System.Drawing.Color.Black;
            this.lbl_idBajaLib.Location = new System.Drawing.Point(16, 42);
            this.lbl_idBajaLib.Name = "lbl_idBajaLib";
            this.lbl_idBajaLib.Size = new System.Drawing.Size(23, 16);
            this.lbl_idBajaLib.TabIndex = 5;
            this.lbl_idBajaLib.Text = "ID:";
            // 
            // txt_idBajaLib
            // 
            this.txt_idBajaLib.Location = new System.Drawing.Point(122, 39);
            this.txt_idBajaLib.Name = "txt_idBajaLib";
            this.txt_idBajaLib.Size = new System.Drawing.Size(100, 22);
            this.txt_idBajaLib.TabIndex = 1;
            // 
            // btn_guardarBajaLib
            // 
            this.btn_guardarBajaLib.BackColor = System.Drawing.Color.Beige;
            this.btn_guardarBajaLib.Location = new System.Drawing.Point(64, 103);
            this.btn_guardarBajaLib.Name = "btn_guardarBajaLib";
            this.btn_guardarBajaLib.Size = new System.Drawing.Size(128, 41);
            this.btn_guardarBajaLib.TabIndex = 0;
            this.btn_guardarBajaLib.Text = "Guardar Cambios";
            this.btn_guardarBajaLib.UseVisualStyleBackColor = false;
            this.btn_guardarBajaLib.Click += new System.EventHandler(this.btn_guardarBajaLib_Click);
            // 
            // frm_bajaLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(308, 219);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_bajaLibros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hola";
            this.Load += new System.EventHandler(this.frm_bajaLibros_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_idBajaLib;
        private System.Windows.Forms.TextBox txt_idBajaLib;
        private System.Windows.Forms.Button btn_guardarBajaLib;
    }
}