namespace Cliente_Api_Rest
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Agregar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxApellidos = new System.Windows.Forms.TextBox();
            this.textBoxNombres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelRespuesta = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_Consultar = new System.Windows.Forms.Button();
            this.labelApellidos = new System.Windows.Forms.Label();
            this.labelNombres = new System.Windows.Forms.Label();
            this.textBoxUsuario_Id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.textBoxUsuario_idA = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxApellidosA = new System.Windows.Forms.TextBox();
            this.textBoxNombresA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button_Eliminar = new System.Windows.Forms.Button();
            this.textBoxEliminar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button_ConsultarTodo = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button_Agregar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxApellidos);
            this.panel1.Controls.Add(this.textBoxNombres);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(8, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 155);
            this.panel1.TabIndex = 0;
            // 
            // button_Agregar
            // 
            this.button_Agregar.Location = new System.Drawing.Point(73, 113);
            this.button_Agregar.Name = "button_Agregar";
            this.button_Agregar.Size = new System.Drawing.Size(75, 23);
            this.button_Agregar.TabIndex = 11;
            this.button_Agregar.Text = "Agregar";
            this.button_Agregar.UseVisualStyleBackColor = true;
            this.button_Agregar.Click += new System.EventHandler(this.button_Agregar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellidos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombres:";
            // 
            // textBoxApellidos
            // 
            this.textBoxApellidos.Location = new System.Drawing.Point(64, 65);
            this.textBoxApellidos.MaxLength = 25;
            this.textBoxApellidos.Name = "textBoxApellidos";
            this.textBoxApellidos.Size = new System.Drawing.Size(178, 20);
            this.textBoxApellidos.TabIndex = 1;
            // 
            // textBoxNombres
            // 
            this.textBoxNombres.Location = new System.Drawing.Point(64, 28);
            this.textBoxNombres.MaxLength = 25;
            this.textBoxNombres.Name = "textBoxNombres";
            this.textBoxNombres.Size = new System.Drawing.Size(178, 20);
            this.textBoxNombres.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Post: Agregar Usuario";
            // 
            // labelRespuesta
            // 
            this.labelRespuesta.AutoSize = true;
            this.labelRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRespuesta.ForeColor = System.Drawing.Color.Red;
            this.labelRespuesta.Location = new System.Drawing.Point(190, 9);
            this.labelRespuesta.Name = "labelRespuesta";
            this.labelRespuesta.Size = new System.Drawing.Size(11, 13);
            this.labelRespuesta.TabIndex = 1;
            this.labelRespuesta.Text = ".";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button_Consultar);
            this.panel2.Controls.Add(this.labelApellidos);
            this.panel2.Controls.Add(this.labelNombres);
            this.panel2.Controls.Add(this.textBoxUsuario_Id);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(8, 186);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(247, 155);
            this.panel2.TabIndex = 2;
            // 
            // button_Consultar
            // 
            this.button_Consultar.Location = new System.Drawing.Point(73, 127);
            this.button_Consultar.Name = "button_Consultar";
            this.button_Consultar.Size = new System.Drawing.Size(75, 23);
            this.button_Consultar.TabIndex = 4;
            this.button_Consultar.Text = "Consultar";
            this.button_Consultar.UseVisualStyleBackColor = true;
            this.button_Consultar.Click += new System.EventHandler(this.button_Consultar_Click);
            // 
            // labelApellidos
            // 
            this.labelApellidos.AutoSize = true;
            this.labelApellidos.Location = new System.Drawing.Point(10, 92);
            this.labelApellidos.Name = "labelApellidos";
            this.labelApellidos.Size = new System.Drawing.Size(52, 13);
            this.labelApellidos.TabIndex = 5;
            this.labelApellidos.Text = "Apellidos:";
            // 
            // labelNombres
            // 
            this.labelNombres.AutoSize = true;
            this.labelNombres.Location = new System.Drawing.Point(10, 66);
            this.labelNombres.Name = "labelNombres";
            this.labelNombres.Size = new System.Drawing.Size(52, 13);
            this.labelNombres.TabIndex = 4;
            this.labelNombres.Text = "Nombres:";
            // 
            // textBoxUsuario_Id
            // 
            this.textBoxUsuario_Id.Location = new System.Drawing.Point(73, 28);
            this.textBoxUsuario_Id.Name = "textBoxUsuario_Id";
            this.textBoxUsuario_Id.Size = new System.Drawing.Size(100, 20);
            this.textBoxUsuario_Id.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Usuario_Id:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Get: Consultar Usuario";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.buttonActualizar);
            this.panel3.Controls.Add(this.textBoxUsuario_idA);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.textBoxApellidosA);
            this.panel3.Controls.Add(this.textBoxNombresA);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(314, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(247, 154);
            this.panel3.TabIndex = 3;
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Location = new System.Drawing.Point(89, 126);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(75, 23);
            this.buttonActualizar.TabIndex = 4;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // textBoxUsuario_idA
            // 
            this.textBoxUsuario_idA.Location = new System.Drawing.Point(64, 23);
            this.textBoxUsuario_idA.Name = "textBoxUsuario_idA";
            this.textBoxUsuario_idA.Size = new System.Drawing.Size(100, 20);
            this.textBoxUsuario_idA.TabIndex = 10;
            this.textBoxUsuario_idA.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Usuario_Id:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Apellidos:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Nombres:";
            // 
            // textBoxApellidosA
            // 
            this.textBoxApellidosA.Location = new System.Drawing.Point(64, 90);
            this.textBoxApellidosA.MaxLength = 25;
            this.textBoxApellidosA.Name = "textBoxApellidosA";
            this.textBoxApellidosA.Size = new System.Drawing.Size(178, 20);
            this.textBoxApellidosA.TabIndex = 5;
            // 
            // textBoxNombresA
            // 
            this.textBoxNombresA.Location = new System.Drawing.Point(64, 55);
            this.textBoxNombresA.MaxLength = 25;
            this.textBoxNombresA.Name = "textBoxNombresA";
            this.textBoxNombresA.Size = new System.Drawing.Size(178, 20);
            this.textBoxNombresA.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Put: Actualizar Usuario";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.button_Eliminar);
            this.panel4.Controls.Add(this.textBoxEliminar);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label13);
            this.panel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(314, 187);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(247, 155);
            this.panel4.TabIndex = 6;
            // 
            // button_Eliminar
            // 
            this.button_Eliminar.Location = new System.Drawing.Point(73, 91);
            this.button_Eliminar.Name = "button_Eliminar";
            this.button_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.button_Eliminar.TabIndex = 4;
            this.button_Eliminar.Text = "Eliminar";
            this.button_Eliminar.UseVisualStyleBackColor = true;
            this.button_Eliminar.Click += new System.EventHandler(this.button_Eliminar_Click);
            // 
            // textBoxEliminar
            // 
            this.textBoxEliminar.Location = new System.Drawing.Point(73, 38);
            this.textBoxEliminar.Name = "textBoxEliminar";
            this.textBoxEliminar.Size = new System.Drawing.Size(100, 20);
            this.textBoxEliminar.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Usuario_Id:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(143, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Delete: Eliminar Usuario";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel5.Controls.Add(this.button_ConsultarTodo);
            this.panel5.Controls.Add(this.listBox1);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(154, 348);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(299, 166);
            this.panel5.TabIndex = 7;
            // 
            // button_ConsultarTodo
            // 
            this.button_ConsultarTodo.Location = new System.Drawing.Point(97, 129);
            this.button_ConsultarTodo.Name = "button_ConsultarTodo";
            this.button_ConsultarTodo.Size = new System.Drawing.Size(110, 23);
            this.button_ConsultarTodo.TabIndex = 6;
            this.button_ConsultarTodo.Text = "Consultar Todos";
            this.button_ConsultarTodo.UseVisualStyleBackColor = true;
            this.button_ConsultarTodo.Click += new System.EventHandler(this.button_ConsultarTodo_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(30, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(236, 95);
            this.listBox1.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(204, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Get: Consultar Todos Los Usuarios";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 526);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelRespuesta);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consumir API Rest";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxApellidos;
        private System.Windows.Forms.TextBox textBoxNombres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelRespuesta;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxUsuario_Id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelApellidos;
        private System.Windows.Forms.Label labelNombres;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxUsuario_idA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxApellidosA;
        private System.Windows.Forms.TextBox textBoxNombresA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_Agregar;
        private System.Windows.Forms.Button button_Consultar;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button_Eliminar;
        private System.Windows.Forms.TextBox textBoxEliminar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button_ConsultarTodo;
        private System.Windows.Forms.ListBox listBox1;
    }
}

