﻿namespace LocadoraClassic.View
{
    partial class FrnTelaGenero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrnTelaGenero));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textgenero = new System.Windows.Forms.TextBox();
            this.dgvGeneros = new System.Windows.Forms.DataGridView();
            this.botaoexcluir = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneros)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(238, 44);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(413, 35);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 161);
            this.label1.MaximumSize = new System.Drawing.Size(80, 50);
            this.label1.MinimumSize = new System.Drawing.Size(80, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(603, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textgenero
            // 
            this.textgenero.Location = new System.Drawing.Point(185, 161);
            this.textgenero.Multiline = true;
            this.textgenero.Name = "textgenero";
            this.textgenero.Size = new System.Drawing.Size(592, 27);
            this.textgenero.TabIndex = 3;
            this.textgenero.TextChanged += new System.EventHandler(this.textgenero_TextChanged);
            // 
            // dgvGeneros
            // 
            this.dgvGeneros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGeneros.Location = new System.Drawing.Point(28, 299);
            this.dgvGeneros.Name = "dgvGeneros";
            this.dgvGeneros.Size = new System.Drawing.Size(860, 370);
            this.dgvGeneros.TabIndex = 4;
            this.dgvGeneros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvGeneros.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGeneros_CellDoubleClick);
            // 
            // botaoexcluir
            // 
            this.botaoexcluir.Location = new System.Drawing.Point(394, 206);
            this.botaoexcluir.Name = "botaoexcluir";
            this.botaoexcluir.Size = new System.Drawing.Size(170, 37);
            this.botaoexcluir.TabIndex = 5;
            this.botaoexcluir.Text = "Excluir";
            this.botaoexcluir.UseVisualStyleBackColor = true;
            this.botaoexcluir.Click += new System.EventHandler(this.botaoexcluir_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(185, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 37);
            this.button2.TabIndex = 6;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrnTelaGenero
            // 
            this.ClientSize = new System.Drawing.Size(911, 681);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.botaoexcluir);
            this.Controls.Add(this.dgvGeneros);
            this.Controls.Add(this.textgenero);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1080, 720);
            this.MinimumSize = new System.Drawing.Size(720, 480);
            this.Name = "FrnTelaGenero";
            this.Text = "Cadastro de Genêro";
            this.Load += new System.EventHandler(this.FrnTelaGenero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FrmTelaGenero;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textgenero;
        private System.Windows.Forms.DataGridView dgvGeneros;
        private System.Windows.Forms.Button botaoexcluir;
        private System.Windows.Forms.Button button2;
    }
}