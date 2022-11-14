namespace FitAcademy.ProjetoExemplo.WindowsForms.UI
{
    partial class FFormularioInicial
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
            this.lblNomeFornecedor = new System.Windows.Forms.Label();
            this.txtNomeFornecedor = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblContato = new System.Windows.Forms.Label();
            this.txtNomeContato = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dgvFornecedores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeFornecedor
            // 
            this.lblNomeFornecedor.AutoSize = true;
            this.lblNomeFornecedor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNomeFornecedor.Location = new System.Drawing.Point(12, 21);
            this.lblNomeFornecedor.Name = "lblNomeFornecedor";
            this.lblNomeFornecedor.Size = new System.Drawing.Size(125, 15);
            this.lblNomeFornecedor.TabIndex = 0;
            this.lblNomeFornecedor.Text = "Nome do Fornecedor";
            this.lblNomeFornecedor.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNomeFornecedor
            // 
            this.txtNomeFornecedor.Location = new System.Drawing.Point(12, 39);
            this.txtNomeFornecedor.Name = "txtNomeFornecedor";
            this.txtNomeFornecedor.Size = new System.Drawing.Size(356, 23);
            this.txtNomeFornecedor.TabIndex = 1;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEndereco.Location = new System.Drawing.Point(12, 72);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(59, 15);
            this.lblEndereco.TabIndex = 2;
            this.lblEndereco.Text = "Endereço";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(12, 90);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(519, 23);
            this.txtEndereco.TabIndex = 1;
            this.txtEndereco.TextChanged += new System.EventHandler(this.txtEndereco_TextChanged);
            // 
            // lblContato
            // 
            this.lblContato.AutoSize = true;
            this.lblContato.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblContato.Location = new System.Drawing.Point(12, 127);
            this.lblContato.Name = "lblContato";
            this.lblContato.Size = new System.Drawing.Size(105, 15);
            this.lblContato.TabIndex = 2;
            this.lblContato.Text = "Nome do Contato";
            // 
            // txtNomeContato
            // 
            this.txtNomeContato.Location = new System.Drawing.Point(12, 145);
            this.txtNomeContato.Name = "txtNomeContato";
            this.txtNomeContato.Size = new System.Drawing.Size(162, 23);
            this.txtNomeContato.TabIndex = 1;
            this.txtNomeContato.TextChanged += new System.EventHandler(this.txtEndereco_TextChanged);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTelefone.Location = new System.Drawing.Point(12, 180);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(56, 15);
            this.lblTelefone.TabIndex = 2;
            this.lblTelefone.Text = "Telefone";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(12, 198);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(125, 23);
            this.txtTelefone.TabIndex = 1;
            this.txtTelefone.TextChanged += new System.EventHandler(this.txtEndereco_TextChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(12, 243);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(250, 65);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dgvFornecedores
            // 
            this.dgvFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFornecedores.Location = new System.Drawing.Point(12, 326);
            this.dgvFornecedores.Name = "dgvFornecedores";
            this.dgvFornecedores.RowTemplate.Height = 25;
            this.dgvFornecedores.Size = new System.Drawing.Size(693, 150);
            this.dgvFornecedores.TabIndex = 4;
            // 
            // FFormularioInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 488);
            this.Controls.Add(this.dgvFornecedores);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblContato);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtNomeContato);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtNomeFornecedor);
            this.Controls.Add(this.lblNomeFornecedor);
            this.Name = "FFormularioInicial";
            this.Text = "Tela de Cadastro de Fornecedor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNomeFornecedor;
        private TextBox txtNomeFornecedor;
        private Label lblEndereco;
        private TextBox txtEndereco;
        private Label lblContato;
        private TextBox txtNomeContato;
        private Label lblTelefone;
        private TextBox txtTelefone;
        private Button btnSalvar;
        private DataGridView dgvFornecedores;
    }
}