namespace EmployeeManagementSystem
{
    partial class PontoForm
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PontoForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSaidaHorario = new System.Windows.Forms.Button();
            this.btnEntradaHorario = new System.Windows.Forms.Button();
            this.labelNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCodFunc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnReajuste = new System.Windows.Forms.Button();
            this.labelHoraEntrada = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelHoraSaida = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.squareEntrada = new System.Windows.Forms.Panel();
            this.squareSaida = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.squareSaida);
            this.panel2.Controls.Add(this.squareEntrada);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.labelHoraSaida);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.labelHoraEntrada);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnSalvar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnReajuste);
            this.panel2.Location = new System.Drawing.Point(311, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(547, 517);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de Ponto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnSaidaHorario);
            this.panel1.Controls.Add(this.btnEntradaHorario);
            this.panel1.Controls.Add(this.labelNome);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.labelCodFunc);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(16, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 517);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(91, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 88);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnSaidaHorario
            // 
            this.btnSaidaHorario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSaidaHorario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnSaidaHorario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaidaHorario.FlatAppearance.BorderSize = 0;
            this.btnSaidaHorario.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnSaidaHorario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnSaidaHorario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnSaidaHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaidaHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaidaHorario.ForeColor = System.Drawing.Color.White;
            this.btnSaidaHorario.Location = new System.Drawing.Point(162, 385);
            this.btnSaidaHorario.Name = "btnSaidaHorario";
            this.btnSaidaHorario.Size = new System.Drawing.Size(96, 37);
            this.btnSaidaHorario.TabIndex = 16;
            this.btnSaidaHorario.Text = "Saída";
            this.btnSaidaHorario.UseVisualStyleBackColor = false;
            this.btnSaidaHorario.Click += new System.EventHandler(this.btnSaidaHorario_Click);
            // 
            // btnEntradaHorario
            // 
            this.btnEntradaHorario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnEntradaHorario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnEntradaHorario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntradaHorario.FlatAppearance.BorderSize = 0;
            this.btnEntradaHorario.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnEntradaHorario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnEntradaHorario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnEntradaHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntradaHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntradaHorario.ForeColor = System.Drawing.Color.White;
            this.btnEntradaHorario.Location = new System.Drawing.Point(20, 385);
            this.btnEntradaHorario.Name = "btnEntradaHorario";
            this.btnEntradaHorario.Size = new System.Drawing.Size(96, 37);
            this.btnEntradaHorario.TabIndex = 15;
            this.btnEntradaHorario.Text = "Entrada";
            this.btnEntradaHorario.UseVisualStyleBackColor = false;
            this.btnEntradaHorario.Click += new System.EventHandler(this.btnEntradaHorario_Click);
            // 
            // labelNome
            // 
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(19, 289);
            this.labelNome.Multiline = true;
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(239, 25);
            this.labelNome.TabIndex = 3;
            this.labelNome.TextChanged += new System.EventHandler(this.labelNome_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome do Funcionário:";
            // 
            // labelCodFunc
            // 
            this.labelCodFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodFunc.Location = new System.Drawing.Point(19, 227);
            this.labelCodFunc.Multiline = true;
            this.labelCodFunc.Name = "labelCodFunc";
            this.labelCodFunc.Size = new System.Drawing.Size(239, 25);
            this.labelCodFunc.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código do Funcionário:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(235, 385);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(96, 37);
            this.btnSalvar.TabIndex = 18;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Visible = false;
            // 
            // btnReajuste
            // 
            this.btnReajuste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnReajuste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReajuste.FlatAppearance.BorderSize = 0;
            this.btnReajuste.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnReajuste.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnReajuste.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnReajuste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReajuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReajuste.ForeColor = System.Drawing.Color.White;
            this.btnReajuste.Location = new System.Drawing.Point(53, 385);
            this.btnReajuste.Name = "btnReajuste";
            this.btnReajuste.Size = new System.Drawing.Size(96, 37);
            this.btnReajuste.TabIndex = 17;
            this.btnReajuste.Text = "Reajuste";
            this.btnReajuste.UseVisualStyleBackColor = false;
            this.btnReajuste.Visible = false;
            // 
            // labelHoraEntrada
            // 
            this.labelHoraEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoraEntrada.Location = new System.Drawing.Point(53, 289);
            this.labelHoraEntrada.Multiline = true;
            this.labelHoraEntrada.Name = "labelHoraEntrada";
            this.labelHoraEntrada.ReadOnly = true;
            this.labelHoraEntrada.Size = new System.Drawing.Size(127, 25);
            this.labelHoraEntrada.TabIndex = 22;
            this.labelHoraEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.labelHoraEntrada.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Hora de Entrada:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(53, 227);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(239, 25);
            this.textBox2.TabIndex = 20;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Funcionário:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(231, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 19);
            this.label6.TabIndex = 24;
            this.label6.Text = "Hora de Saída:";
            // 
            // labelHoraSaida
            // 
            this.labelHoraSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoraSaida.Location = new System.Drawing.Point(235, 292);
            this.labelHoraSaida.Multiline = true;
            this.labelHoraSaida.Name = "labelHoraSaida";
            this.labelHoraSaida.ReadOnly = true;
            this.labelHoraSaida.Size = new System.Drawing.Size(127, 25);
            this.labelHoraSaida.TabIndex = 25;
            this.labelHoraSaida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(393, 208);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 109);
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // squareEntrada
            // 
            this.squareEntrada.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.squareEntrada.Location = new System.Drawing.Point(30, 289);
            this.squareEntrada.Name = "squareEntrada";
            this.squareEntrada.Size = new System.Drawing.Size(17, 18);
            this.squareEntrada.TabIndex = 27;
            // 
            // squareSaida
            // 
            this.squareSaida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.squareSaida.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.squareSaida.Location = new System.Drawing.Point(212, 292);
            this.squareSaida.Name = "squareSaida";
            this.squareSaida.Size = new System.Drawing.Size(17, 18);
            this.squareSaida.TabIndex = 28;
            // 
            // PontoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(3)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PontoForm";
            this.Size = new System.Drawing.Size(875, 565);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSaidaHorario;
        private System.Windows.Forms.Button btnEntradaHorario;
        private System.Windows.Forms.TextBox labelNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox labelCodFunc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnReajuste;
        private System.Windows.Forms.TextBox labelHoraEntrada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox labelHoraSaida;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel squareSaida;
        private System.Windows.Forms.Panel squareEntrada;
    }
}
