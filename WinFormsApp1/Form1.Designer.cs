
namespace WinFormsApp1
{
    partial class F_contatos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_contatos));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.novo = new System.Windows.Forms.ToolStripButton();
            this.tsb_cancelar = new System.Windows.Forms.ToolStripButton();
            this.tlb_salvar = new System.Windows.Forms.ToolStripButton();
            this.tlb_alterar = new System.Windows.Forms.ToolStripButton();
            this.tlb_excluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txt_buscarPorNome = new System.Windows.Forms.ToolStripTextBox();
            this.tlb_pesquisar = new System.Windows.Forms.ToolStripButton();
            this.tb_Nome = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_email = new System.Windows.Forms.Label();
            this.lb_telefone = new System.Windows.Forms.Label();
            this.mtb_telefone = new System.Windows.Forms.MaskedTextBox();
            this.dg_Dados = new System.Windows.Forms.DataGridView();
            this.btn_BuscaDataGrip = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Dados)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novo,
            this.tsb_cancelar,
            this.tlb_salvar,
            this.tlb_alterar,
            this.tlb_excluir,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.txt_buscarPorNome,
            this.tlb_pesquisar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(628, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // novo
            // 
            this.novo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.novo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.novo.Image = ((System.Drawing.Image)(resources.GetObject("novo.Image")));
            this.novo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.novo.Name = "novo";
            this.novo.Size = new System.Drawing.Size(23, 22);
            this.novo.Text = "Novo";
            this.novo.Click += new System.EventHandler(this.novo_Click);
            // 
            // tsb_cancelar
            // 
            this.tsb_cancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("tsb_cancelar.Image")));
            this.tsb_cancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_cancelar.Name = "tsb_cancelar";
            this.tsb_cancelar.Size = new System.Drawing.Size(23, 22);
            this.tsb_cancelar.Text = "cancelar";
            this.tsb_cancelar.Click += new System.EventHandler(this.tsb_cancelar_Click);
            // 
            // tlb_salvar
            // 
            this.tlb_salvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlb_salvar.Image = ((System.Drawing.Image)(resources.GetObject("tlb_salvar.Image")));
            this.tlb_salvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlb_salvar.Name = "tlb_salvar";
            this.tlb_salvar.Size = new System.Drawing.Size(23, 22);
            this.tlb_salvar.Text = "Salvar";
            this.tlb_salvar.Click += new System.EventHandler(this.tlb_salvar_Click);
            // 
            // tlb_alterar
            // 
            this.tlb_alterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlb_alterar.Image = ((System.Drawing.Image)(resources.GetObject("tlb_alterar.Image")));
            this.tlb_alterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlb_alterar.Name = "tlb_alterar";
            this.tlb_alterar.Size = new System.Drawing.Size(23, 22);
            this.tlb_alterar.Text = "Alterar";
            this.tlb_alterar.Click += new System.EventHandler(this.tlb_alterar_Click);
            // 
            // tlb_excluir
            // 
            this.tlb_excluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlb_excluir.Image = ((System.Drawing.Image)(resources.GetObject("tlb_excluir.Image")));
            this.tlb_excluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlb_excluir.Name = "tlb_excluir";
            this.tlb_excluir.Size = new System.Drawing.Size(23, 22);
            this.tlb_excluir.Text = "Excluir";
            this.tlb_excluir.Click += new System.EventHandler(this.tlb_excluir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(103, 22);
            this.toolStripLabel1.Text = "Buscar p/ Nome";
            // 
            // txt_buscarPorNome
            // 
            this.txt_buscarPorNome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_buscarPorNome.Name = "txt_buscarPorNome";
            this.txt_buscarPorNome.Size = new System.Drawing.Size(100, 25);
            // 
            // tlb_pesquisar
            // 
            this.tlb_pesquisar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlb_pesquisar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tlb_pesquisar.Image = ((System.Drawing.Image)(resources.GetObject("tlb_pesquisar.Image")));
            this.tlb_pesquisar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlb_pesquisar.Name = "tlb_pesquisar";
            this.tlb_pesquisar.Size = new System.Drawing.Size(23, 22);
            this.tlb_pesquisar.Text = "Pesquisar";
            this.tlb_pesquisar.Click += new System.EventHandler(this.tlb_pesquisar_Click);
            // 
            // tb_Nome
            // 
            this.tb_Nome.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Nome.Location = new System.Drawing.Point(35, 69);
            this.tb_Nome.Name = "tb_Nome";
            this.tb_Nome.Size = new System.Drawing.Size(309, 35);
            this.tb_Nome.TabIndex = 3;
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_email.Location = new System.Drawing.Point(35, 125);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(309, 35);
            this.tb_email.TabIndex = 5;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_name.Location = new System.Drawing.Point(35, 49);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(44, 17);
            this.lb_name.TabIndex = 9;
            this.lb_name.Text = "Nome";
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_email.Location = new System.Drawing.Point(35, 107);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(39, 17);
            this.lb_email.TabIndex = 10;
            this.lb_email.Text = "Email";
            // 
            // lb_telefone
            // 
            this.lb_telefone.AutoSize = true;
            this.lb_telefone.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_telefone.Location = new System.Drawing.Point(350, 49);
            this.lb_telefone.Name = "lb_telefone";
            this.lb_telefone.Size = new System.Drawing.Size(58, 17);
            this.lb_telefone.TabIndex = 11;
            this.lb_telefone.Text = "Telefone";
            this.lb_telefone.Click += new System.EventHandler(this.lb_telefone_Click);
            // 
            // mtb_telefone
            // 
            this.mtb_telefone.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtb_telefone.Location = new System.Drawing.Point(350, 69);
            this.mtb_telefone.Mask = "(99) 00000-0000";
            this.mtb_telefone.Name = "mtb_telefone";
            this.mtb_telefone.Size = new System.Drawing.Size(164, 35);
            this.mtb_telefone.TabIndex = 12;
            // 
            // dg_Dados
            // 
            this.dg_Dados.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dg_Dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Dados.Location = new System.Drawing.Point(35, 192);
            this.dg_Dados.Name = "dg_Dados";
            this.dg_Dados.RowTemplate.Height = 25;
            this.dg_Dados.Size = new System.Drawing.Size(381, 136);
            this.dg_Dados.TabIndex = 13;
            this.dg_Dados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_BuscaDataGrip
            // 
            this.btn_BuscaDataGrip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_BuscaDataGrip.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_BuscaDataGrip.Location = new System.Drawing.Point(422, 290);
            this.btn_BuscaDataGrip.Name = "btn_BuscaDataGrip";
            this.btn_BuscaDataGrip.Size = new System.Drawing.Size(143, 38);
            this.btn_BuscaDataGrip.TabIndex = 14;
            this.btn_BuscaDataGrip.Text = "Buscar";
            this.btn_BuscaDataGrip.UseVisualStyleBackColor = true;
            this.btn_BuscaDataGrip.Click += new System.EventHandler(this.btn_BuscaDataGrip_Click);
            // 
            // F_contatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(628, 335);
            this.Controls.Add(this.btn_BuscaDataGrip);
            this.Controls.Add(this.dg_Dados);
            this.Controls.Add(this.mtb_telefone);
            this.Controls.Add(this.lb_telefone);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_Nome);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "F_contatos";
            this.Text = "Contatos";
            this.Load += new System.EventHandler(this.F_contatos_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Dados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton novo;
        private System.Windows.Forms.ToolStripButton tsb_cancelar;
        private System.Windows.Forms.ToolStripButton tlb_salvar;
        private System.Windows.Forms.ToolStripButton tlb_alterar;
        private System.Windows.Forms.ToolStripButton tlb_excluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txt_buscarPorID;
        private System.Windows.Forms.ToolStripButton tlb_pesquisar;
        private System.Windows.Forms.TextBox tb_Nome;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label lb_telefone;
        private System.Windows.Forms.MaskedTextBox mtb_telefone;
        private System.Windows.Forms.DataGridView dg_Dados;
        private System.Windows.Forms.Button btn_BuscaDataGrip;
        private System.Windows.Forms.ToolStripTextBox txt_buscarPorNome;
    }
}

