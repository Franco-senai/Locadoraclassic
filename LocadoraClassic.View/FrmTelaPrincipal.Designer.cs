namespace LocadoraClassic.View
{
    partial class FrmMenu
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genêroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarLocaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioDiarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturamentoDoDiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturamenteDoMêsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gráficosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficoDePizzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gráficoAtrasadosPorMêsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pendentesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.locaçãoToolStripMenuItem,
            this.relatoriosToolStripMenuItem,
            this.gráficosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(704, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genêroToolStripMenuItem,
            this.categoriaToolStripMenuItem,
            this.filmeToolStripMenuItem,
            this.clienteToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // genêroToolStripMenuItem
            // 
            this.genêroToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.genêroToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genêroToolStripMenuItem.Name = "genêroToolStripMenuItem";
            this.genêroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.genêroToolStripMenuItem.Text = "Genêro";
            this.genêroToolStripMenuItem.Click += new System.EventHandler(this.genêroToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // filmeToolStripMenuItem
            // 
            this.filmeToolStripMenuItem.Font = new System.Drawing.Font("Romantic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.filmeToolStripMenuItem.Name = "filmeToolStripMenuItem";
            this.filmeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.filmeToolStripMenuItem.Text = "Filme";
            this.filmeToolStripMenuItem.Click += new System.EventHandler(this.filmeToolStripMenuItem_Click);
            // 
            // locaçãoToolStripMenuItem
            // 
            this.locaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarLocaçãoToolStripMenuItem,
            this.relatorioDiarioToolStripMenuItem});
            this.locaçãoToolStripMenuItem.Name = "locaçãoToolStripMenuItem";
            this.locaçãoToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.locaçãoToolStripMenuItem.Text = "Locação";
            this.locaçãoToolStripMenuItem.Click += new System.EventHandler(this.locaçãoToolStripMenuItem_Click);
            // 
            // realizarLocaçãoToolStripMenuItem
            // 
            this.realizarLocaçãoToolStripMenuItem.Name = "realizarLocaçãoToolStripMenuItem";
            this.realizarLocaçãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.realizarLocaçãoToolStripMenuItem.Text = "Realizar locação";
            this.realizarLocaçãoToolStripMenuItem.Click += new System.EventHandler(this.realizarLocaçãoToolStripMenuItem_Click);
            // 
            // relatorioDiarioToolStripMenuItem
            // 
            this.relatorioDiarioToolStripMenuItem.Name = "relatorioDiarioToolStripMenuItem";
            this.relatorioDiarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.relatorioDiarioToolStripMenuItem.Text = "Relatorio Diário";
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pendentesToolStripMenuItem1,
            this.faturamentoDoDiaToolStripMenuItem,
            this.faturamenteDoMêsToolStripMenuItem});
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatoriosToolStripMenuItem.Text = "Relatorios";
            this.relatoriosToolStripMenuItem.Click += new System.EventHandler(this.relatoriosToolStripMenuItem_Click);
            // 
            // faturamentoDoDiaToolStripMenuItem
            // 
            this.faturamentoDoDiaToolStripMenuItem.Name = "faturamentoDoDiaToolStripMenuItem";
            this.faturamentoDoDiaToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.faturamentoDoDiaToolStripMenuItem.Text = "Faturamento do Dia";
            this.faturamentoDoDiaToolStripMenuItem.Click += new System.EventHandler(this.faturamentoDoDiaToolStripMenuItem_Click);
            // 
            // faturamenteDoMêsToolStripMenuItem
            // 
            this.faturamenteDoMêsToolStripMenuItem.Name = "faturamenteDoMêsToolStripMenuItem";
            this.faturamenteDoMêsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.faturamenteDoMêsToolStripMenuItem.Text = "Faturamente do Mês";
            this.faturamenteDoMêsToolStripMenuItem.Click += new System.EventHandler(this.faturamenteDoMêsToolStripMenuItem_Click);
            // 
            // gráficosToolStripMenuItem
            // 
            this.gráficosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graficoDePizzaToolStripMenuItem,
            this.gráficoAtrasadosPorMêsToolStripMenuItem});
            this.gráficosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gráficosToolStripMenuItem.Name = "gráficosToolStripMenuItem";
            this.gráficosToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.gráficosToolStripMenuItem.Text = "Gráficos";
            // 
            // graficoDePizzaToolStripMenuItem
            // 
            this.graficoDePizzaToolStripMenuItem.Name = "graficoDePizzaToolStripMenuItem";
            this.graficoDePizzaToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.graficoDePizzaToolStripMenuItem.Text = "Grafico de Pizza de clientes por Endereço";
            // 
            // gráficoAtrasadosPorMêsToolStripMenuItem
            // 
            this.gráficoAtrasadosPorMêsToolStripMenuItem.Name = "gráficoAtrasadosPorMêsToolStripMenuItem";
            this.gráficoAtrasadosPorMêsToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.gráficoAtrasadosPorMêsToolStripMenuItem.Text = "Gráfico Barra Atrasados Por Mês";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // pendentesToolStripMenuItem1
            // 
            this.pendentesToolStripMenuItem1.Name = "pendentesToolStripMenuItem1";
            this.pendentesToolStripMenuItem1.Size = new System.Drawing.Size(183, 22);
            this.pendentesToolStripMenuItem1.Text = "Pendentes";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(720, 480);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(720, 480);
            this.Name = "FrmMenu";
            this.Text = "Locadora Classic";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genêroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizarLocaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioDiarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturamentoDoDiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturamenteDoMêsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pendentesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gráficosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficoDePizzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gráficoAtrasadosPorMêsToolStripMenuItem;
    }
}

