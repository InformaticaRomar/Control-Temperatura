namespace controltemperatura
{
    partial class Form_ct
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ct));
            this.textBox_sscc = new System.Windows.Forms.TextBox();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.label_sscc = new System.Windows.Forms.Label();
            this.label_temp = new System.Windows.Forms.Label();
            this.textBox_temp = new System.Windows.Forms.TextBox();
            this.msg_insert = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_sscc
            // 
            this.textBox_sscc.Location = new System.Drawing.Point(69, 12);
            this.textBox_sscc.Name = "textBox_sscc";
            this.textBox_sscc.Size = new System.Drawing.Size(136, 20);
            this.textBox_sscc.TabIndex = 0;
            this.textBox_sscc.TextChanged += new System.EventHandler(this.textBox_sscc_TextChanged);
            this.textBox_sscc.Enter += new System.EventHandler(this.textBox_sscc_Enter);
            this.textBox_sscc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_sscc_KeyDown);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Location = new System.Drawing.Point(257, 46);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Guardar.TabIndex = 4;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // label_sscc
            // 
            this.label_sscc.AutoSize = true;
            this.label_sscc.Location = new System.Drawing.Point(7, 15);
            this.label_sscc.Name = "label_sscc";
            this.label_sscc.Size = new System.Drawing.Size(56, 13);
            this.label_sscc.TabIndex = 6;
            this.label_sscc.Text = "Matricula: ";
            // 
            // label_temp
            // 
            this.label_temp.AutoSize = true;
            this.label_temp.Location = new System.Drawing.Point(211, 19);
            this.label_temp.Name = "label_temp";
            this.label_temp.Size = new System.Drawing.Size(70, 13);
            this.label_temp.TabIndex = 3;
            this.label_temp.Text = "Temperatura:";
            // 
            // textBox_temp
            // 
            this.textBox_temp.Location = new System.Drawing.Point(287, 15);
            this.textBox_temp.Name = "textBox_temp";
            this.textBox_temp.Size = new System.Drawing.Size(45, 20);
            this.textBox_temp.TabIndex = 1;
            this.textBox_temp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_temp_KeyPress);
            // 
            // msg_insert
            // 
            this.msg_insert.AutoSize = true;
            this.msg_insert.Location = new System.Drawing.Point(15, 80);
            this.msg_insert.Name = "msg_insert";
            this.msg_insert.Size = new System.Drawing.Size(0, 13);
            this.msg_insert.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(165, 52);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(64, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Muestra";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            // 
            // Form_ct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 83);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.msg_insert);
            this.Controls.Add(this.textBox_temp);
            this.Controls.Add(this.label_temp);
            this.Controls.Add(this.label_sscc);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.textBox_sscc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_ct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Temperatura";
            this.Load += new System.EventHandler(this.Form_ct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_sscc;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Label label_sscc;
        private System.Windows.Forms.Label label_temp;
        private System.Windows.Forms.TextBox textBox_temp;
        private System.Windows.Forms.Label msg_insert;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
    }
}

