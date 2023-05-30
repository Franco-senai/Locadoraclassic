namespace LocadoraClassic.View
{
    partial class FrnTelaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrnTelaCliente));
            this.textNome = new System.Windows.Forms.TextBox();
            this.textEndereco = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textRG = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextTelefone = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextCPF = new System.Windows.Forms.MaskedTextBox();
            this.gridCliente = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // textNome
            // 
            this.textNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNome.Location = new System.Drawing.Point(61, 99);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(396, 31);
            this.textNome.TabIndex = 0;
            this.textNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textEndereco
            // 
            this.textEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEndereco.Location = new System.Drawing.Point(61, 176);
            this.textEndereco.Name = "textEndereco";
            this.textEndereco.Size = new System.Drawing.Size(396, 31);
            this.textEndereco.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(63, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cadastro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textRG
            // 
            this.textRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRG.Location = new System.Drawing.Point(63, 383);
            this.textRG.Name = "textRG";
            this.textRG.Size = new System.Drawing.Size(396, 31);
            this.textRG.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome Do Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Endereço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "CPF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "RG";
            // 
            // maskedTextTelefone
            // 
            this.maskedTextTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextTelefone.Location = new System.Drawing.Point(63, 238);
            this.maskedTextTelefone.Mask = "(99) 0000-0000";
            this.maskedTextTelefone.Name = "maskedTextTelefone";
            this.maskedTextTelefone.Size = new System.Drawing.Size(394, 31);
            this.maskedTextTelefone.TabIndex = 11;
            // 
            // maskedTextCPF
            // 
            this.maskedTextCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextCPF.Location = new System.Drawing.Point(63, 312);
            this.maskedTextCPF.Mask = "000.000.000-000";
            this.maskedTextCPF.Name = "maskedTextCPF";
            this.maskedTextCPF.Size = new System.Drawing.Size(396, 31);
            this.maskedTextCPF.TabIndex = 12;
            // 
            // gridCliente
            // 
            this.gridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCliente.Location = new System.Drawing.Point(514, 99);
            this.gridCliente.Name = "gridCliente";
            this.gridCliente.Size = new System.Drawing.Size(441, 588);
            this.gridCliente.TabIndex = 13;
            this.gridCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCliente_CellContentClick);
            this.gridCliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCliente_CellDoubleClick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(281, 440);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(214, 37);
            this.button2.TabIndex = 14;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(172, 496);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(214, 37);
            this.button3.TabIndex = 15;
            this.button3.Text = "Atualizar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrnTelaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 681);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.gridCliente);
            this.Controls.Add(this.maskedTextCPF);
            this.Controls.Add(this.maskedTextTelefone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textRG);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textEndereco);
            this.Controls.Add(this.textNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1080, 720);
            this.MinimumSize = new System.Drawing.Size(720, 480);
            this.Name = "FrnTelaCliente";
            this.Text = "Cadastro Do Cliente";
            this.Load += new System.EventHandler(this.FrnTelaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textEndereco;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textRG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextTelefone;
        private System.Windows.Forms.MaskedTextBox maskedTextCPF;
        private System.Windows.Forms.DataGridView gridCliente;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}