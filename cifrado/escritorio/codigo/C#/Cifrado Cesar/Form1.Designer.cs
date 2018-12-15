namespace Cifrado_Cesar
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
            this.lblTextoPlano = new System.Windows.Forms.Label();
            this.lblDesplazamiento = new System.Windows.Forms.Label();
            this.txtTextoPlano = new System.Windows.Forms.TextBox();
            this.txtCifrado = new System.Windows.Forms.TextBox();
            this.numDesplazamiento = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTI = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txtGrupos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numDesplazamiento)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTextoPlano
            // 
            this.lblTextoPlano.AutoSize = true;
            this.lblTextoPlano.Location = new System.Drawing.Point(12, 39);
            this.lblTextoPlano.Name = "lblTextoPlano";
            this.lblTextoPlano.Size = new System.Drawing.Size(63, 13);
            this.lblTextoPlano.TabIndex = 0;
            this.lblTextoPlano.Text = "Texto plano";
            // 
            // lblDesplazamiento
            // 
            this.lblDesplazamiento.AutoSize = true;
            this.lblDesplazamiento.Location = new System.Drawing.Point(50, 152);
            this.lblDesplazamiento.Name = "lblDesplazamiento";
            this.lblDesplazamiento.Size = new System.Drawing.Size(82, 13);
            this.lblDesplazamiento.TabIndex = 1;
            this.lblDesplazamiento.Text = "Desplazamiento";
            // 
            // txtTextoPlano
            // 
            this.txtTextoPlano.Location = new System.Drawing.Point(81, 21);
            this.txtTextoPlano.Multiline = true;
            this.txtTextoPlano.Name = "txtTextoPlano";
            this.txtTextoPlano.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTextoPlano.Size = new System.Drawing.Size(744, 53);
            this.txtTextoPlano.TabIndex = 3;
            this.txtTextoPlano.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTextoPlano_KeyDown);
            this.txtTextoPlano.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTextoPlano_KeyPress);
            // 
            // txtCifrado
            // 
            this.txtCifrado.Location = new System.Drawing.Point(53, 195);
            this.txtCifrado.Multiline = true;
            this.txtCifrado.Name = "txtCifrado";
            this.txtCifrado.ReadOnly = true;
            this.txtCifrado.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCifrado.Size = new System.Drawing.Size(205, 208);
            this.txtCifrado.TabIndex = 4;
            // 
            // numDesplazamiento
            // 
            this.numDesplazamiento.Location = new System.Drawing.Point(138, 150);
            this.numDesplazamiento.Name = "numDesplazamiento";
            this.numDesplazamiento.ReadOnly = true;
            this.numDesplazamiento.Size = new System.Drawing.Size(120, 20);
            this.numDesplazamiento.TabIndex = 5;
            this.numDesplazamiento.ValueChanged += new System.EventHandler(this.numDesplazamiento_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(30, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 319);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cesar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtTI);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(304, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 319);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.numericUpDown1);
            this.panel3.Controls.Add(this.txtGrupos);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(594, 108);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(246, 319);
            this.panel3.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "T.I";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(111, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "T.I.A";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTI
            // 
            this.txtTI.Location = new System.Drawing.Point(21, 86);
            this.txtTI.Multiline = true;
            this.txtTI.Name = "txtTI";
            this.txtTI.ReadOnly = true;
            this.txtTI.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTI.Size = new System.Drawing.Size(205, 208);
            this.txtTI.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(25, 86);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(205, 208);
            this.textBox2.TabIndex = 9;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(84, 43);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(146, 20);
            this.numericUpDown1.TabIndex = 11;
            // 
            // txtGrupos
            // 
            this.txtGrupos.AutoSize = true;
            this.txtGrupos.Location = new System.Drawing.Point(22, 45);
            this.txtGrupos.Name = "txtGrupos";
            this.txtGrupos.Size = new System.Drawing.Size(41, 13);
            this.txtGrupos.TabIndex = 10;
            this.txtGrupos.Text = "Grupos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(871, 447);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.numDesplazamiento);
            this.Controls.Add(this.txtCifrado);
            this.Controls.Add(this.txtTextoPlano);
            this.Controls.Add(this.lblDesplazamiento);
            this.Controls.Add(this.lblTextoPlano);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numDesplazamiento)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTextoPlano;
        private System.Windows.Forms.Label lblDesplazamiento;
        private System.Windows.Forms.TextBox txtTextoPlano;
        private System.Windows.Forms.TextBox txtCifrado;
        private System.Windows.Forms.NumericUpDown numDesplazamiento;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label txtGrupos;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
    }
}

