namespace GestionVehiculos
{
    partial class Registro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNumeroID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRO DEL USUARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(758, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "¡Asegurese de llenar correctamente los siguientes campos!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(85, 227);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(276, 27);
            this.TxtNombre.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(435, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Apellidos";
            // 
            // TxtNumeroID
            // 
            this.TxtNumeroID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumeroID.Location = new System.Drawing.Point(85, 341);
            this.TxtNumeroID.Name = "TxtNumeroID";
            this.TxtNumeroID.Size = new System.Drawing.Size(276, 27);
            this.TxtNumeroID.TabIndex = 7;
            this.TxtNumeroID.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(80, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(281, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "Número de Identificación";
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellidos.Location = new System.Drawing.Point(440, 227);
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.Size = new System.Drawing.Size(276, 27);
            this.TxtApellidos.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(435, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(253, 29);
            this.label7.TabIndex = 11;
            this.label7.Text = "Naturaleza del usuario\r\n";
            // 
            // CbTipoUsuario
            // 
            this.CbTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbTipoUsuario.FormattingEnabled = true;
            this.CbTipoUsuario.Items.AddRange(new object[] {
            "Administrador",
            "Cliente"});
            this.CbTipoUsuario.Location = new System.Drawing.Point(440, 340);
            this.CbTipoUsuario.Name = "CbTipoUsuario";
            this.CbTipoUsuario.Size = new System.Drawing.Size(276, 28);
            this.CbTipoUsuario.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(317, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 66);
            this.button1.TabIndex = 13;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(813, 651);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CbTipoUsuario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtApellidos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtNumeroID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Registro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtNumeroID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtApellidos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CbTipoUsuario;
        private System.Windows.Forms.Button button1;
    }
}