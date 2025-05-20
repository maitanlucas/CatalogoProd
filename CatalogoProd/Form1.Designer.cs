namespace CatalogoProd
{
    partial class Form1
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
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnFavoritos = new System.Windows.Forms.Button();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.txtPrecoMin = new System.Windows.Forms.TextBox();
            this.txtPrecoMax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(45, 234);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(566, 253);
            this.dgvProdutos.TabIndex = 0;
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(478, 104);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(133, 31);
            this.btnCarregar.TabIndex = 1;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(478, 141);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(133, 31);
            this.btnFiltrar.TabIndex = 2;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(478, 67);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(133, 31);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Favoritar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnFavoritos
            // 
            this.btnFavoritos.Location = new System.Drawing.Point(478, 178);
            this.btnFavoritos.Name = "btnFavoritos";
            this.btnFavoritos.Size = new System.Drawing.Size(133, 31);
            this.btnFavoritos.TabIndex = 4;
            this.btnFavoritos.Text = "Favoritos";
            this.btnFavoritos.UseVisualStyleBackColor = true;
            this.btnFavoritos.Click += new System.EventHandler(this.btnFavoritos_Click);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(45, 188);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(356, 21);
            this.cmbCategoria.TabIndex = 5;
            // 
            // txtPrecoMin
            // 
            this.txtPrecoMin.Location = new System.Drawing.Point(45, 78);
            this.txtPrecoMin.Name = "txtPrecoMin";
            this.txtPrecoMin.Size = new System.Drawing.Size(356, 20);
            this.txtPrecoMin.TabIndex = 6;
            // 
            // txtPrecoMax
            // 
            this.txtPrecoMax.Location = new System.Drawing.Point(45, 132);
            this.txtPrecoMax.Name = "txtPrecoMax";
            this.txtPrecoMax.Size = new System.Drawing.Size(356, 20);
            this.txtPrecoMax.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Preço Máximo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Preço Mínimo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(186, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "CATÁLOGO DE PRODUTOS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 510);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrecoMax);
            this.Controls.Add(this.txtPrecoMin);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.btnFavoritos);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.dgvProdutos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnFavoritos;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.TextBox txtPrecoMin;
        private System.Windows.Forms.TextBox txtPrecoMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

