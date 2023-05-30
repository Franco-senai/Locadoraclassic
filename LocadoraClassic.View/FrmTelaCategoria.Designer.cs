namespace LocadoraClassic.View
{
    partial class FrnCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrnCategoria));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.textcategoria = new System.Windows.Forms.TextBox();
            this.textDiaria = new System.Windows.Forms.TextBox();
            this.dvgCategoria = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(226, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor da Diaria";
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(530, 306);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(200, 30);
            this.Button1.TabIndex = 2;
            this.Button1.Text = "Cadastrar";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textcategoria
            // 
            this.textcategoria.Location = new System.Drawing.Point(231, 157);
            this.textcategoria.Multiline = true;
            this.textcategoria.Name = "textcategoria";
            this.textcategoria.Size = new System.Drawing.Size(393, 27);
            this.textcategoria.TabIndex = 3;
            // 
            // textDiaria
            // 
            this.textDiaria.Location = new System.Drawing.Point(231, 251);
            this.textDiaria.Multiline = true;
            this.textDiaria.Name = "textDiaria";
            this.textDiaria.Size = new System.Drawing.Size(393, 27);
            this.textDiaria.TabIndex = 4;
            this.textDiaria.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dvgCategoria
            // 
            this.dvgCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCategoria.Location = new System.Drawing.Point(12, 386);
            this.dvgCategoria.Name = "dvgCategoria";
            this.dvgCategoria.Size = new System.Drawing.Size(924, 264);
            this.dvgCategoria.TabIndex = 5;
            this.dvgCategoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgCategoria_CellContentClick);
            this.dvgCategoria.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgCategoria_CellDoubleClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(324, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(118, 306);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 30);
            this.button3.TabIndex = 7;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrnCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 725);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dvgCategoria);
            this.Controls.Add(this.textDiaria);
            this.Controls.Add(this.textcategoria);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrnCategoria";
            this.Text = "Cadastro Categoria";
            this.Load += new System.EventHandler(this.FrnCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.TextBox textcategoria;
        private System.Windows.Forms.TextBox textDiaria;
        private System.Windows.Forms.DataGridView dvgCategoria;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}