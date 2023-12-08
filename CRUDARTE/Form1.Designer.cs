namespace CRUDARTE
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtArtista = new System.Windows.Forms.TextBox();
            this.txtArte = new System.Windows.Forms.TextBox();
            this.dtDataCriação = new System.Windows.Forms.DateTimePicker();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.mbtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbMaterial = new System.Windows.Forms.ComboBox();
            this.cbEstilo = new System.Windows.Forms.ComboBox();
            this.btnExibir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 58);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(124, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Artes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(151, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "*Nome/pseudônimo do artista";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "*Nome da arte";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(419, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "*Estilo da arte";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(458, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "*Data de criação";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "*Gênero da arte";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(184, 327);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "*Material";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.SystemColors.Control;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtCodigo.Location = new System.Drawing.Point(25, 137);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(101, 19);
            this.txtCodigo.TabIndex = 100;
            this.txtCodigo.TabStop = false;
            // 
            // txtArtista
            // 
            this.txtArtista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtArtista.Location = new System.Drawing.Point(154, 137);
            this.txtArtista.Name = "txtArtista";
            this.txtArtista.Size = new System.Drawing.Size(422, 26);
            this.txtArtista.TabIndex = 2;
            // 
            // txtArte
            // 
            this.txtArte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtArte.Location = new System.Drawing.Point(25, 273);
            this.txtArte.Name = "txtArte";
            this.txtArte.Size = new System.Drawing.Size(385, 26);
            this.txtArte.TabIndex = 5;
            // 
            // dtDataCriação
            // 
            this.dtDataCriação.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtDataCriação.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataCriação.Location = new System.Drawing.Point(461, 273);
            this.dtDataCriação.Name = "dtDataCriação";
            this.dtDataCriação.Size = new System.Drawing.Size(115, 26);
            this.dtDataCriação.TabIndex = 6;
            // 
            // cbGenero
            // 
            this.cbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Items.AddRange(new object[] {
            "Pintura",
            "Escultura",
            "Música",
            "Literatura",
            "Fotografia",
            "Dança"});
            this.cbGenero.Location = new System.Drawing.Point(25, 348);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(138, 28);
            this.cbGenero.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtEmail.Location = new System.Drawing.Point(25, 205);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(385, 26);
            this.txtEmail.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(439, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 18);
            this.label10.TabIndex = 20;
            this.label10.Text = "Telefone";
            // 
            // mbtTelefone
            // 
            this.mbtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mbtTelefone.Location = new System.Drawing.Point(442, 205);
            this.mbtTelefone.Mask = "(00)00000-9999";
            this.mbtTelefone.Name = "mbtTelefone";
            this.mbtTelefone.Size = new System.Drawing.Size(134, 26);
            this.mbtTelefone.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 415);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(735, 167);
            this.dataGridView1.TabIndex = 15;
            // 
            // cbMaterial
            // 
            this.cbMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaterial.FormattingEnabled = true;
            this.cbMaterial.Items.AddRange(new object[] {
            "Pintura em quadro",
            "Pintura digital",
            "Pintura tradicional",
            "Escultura em madeira",
            "Escultura em argila",
            "Outros"});
            this.cbMaterial.Location = new System.Drawing.Point(187, 348);
            this.cbMaterial.Name = "cbMaterial";
            this.cbMaterial.Size = new System.Drawing.Size(206, 28);
            this.cbMaterial.TabIndex = 8;
            // 
            // cbEstilo
            // 
            this.cbEstilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstilo.FormattingEnabled = true;
            this.cbEstilo.Items.AddRange(new object[] {
            "Arte Abstrata",
            "Dança Contemporânea",
            "Dança do ventre",
            "Escultura Barroca",
            "Escultura Modernista",
            "Escultura Renascentista",
            "Fotografia Artística",
            "Ilustrações",
            "Literatura Narrativa",
            "Literatura poética",
            "Pintura de Paisagem",
            "Pintura de Retratos",
            "Teatro Musical",
            "Teatro Tradicional",
            "Outros"});
            this.cbEstilo.Location = new System.Drawing.Point(422, 348);
            this.cbEstilo.Name = "cbEstilo";
            this.cbEstilo.Size = new System.Drawing.Size(205, 28);
            this.cbEstilo.TabIndex = 9;
            // 
            // btnExibir
            // 
            this.btnExibir.BackgroundImage = global::CRUDARTE.Properties.Resources.exibir;
            this.btnExibir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibir.Location = new System.Drawing.Point(656, 333);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(79, 47);
            this.btnExibir.TabIndex = 14;
            this.btnExibir.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::CRUDARTE.Properties.Resources.cancelar;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(656, 283);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(79, 47);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = global::CRUDARTE.Properties.Resources.lixo;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(656, 233);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(79, 47);
            this.btnExcluir.TabIndex = 12;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = global::CRUDARTE.Properties.Resources.editar;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(656, 183);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(79, 47);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalvar.BackgroundImage")));
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(656, 133);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(79, 47);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(759, 594);
            this.Controls.Add(this.cbEstilo);
            this.Controls.Add(this.cbMaterial);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.mbtTelefone);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbGenero);
            this.Controls.Add(this.dtDataCriação);
            this.Controls.Add(this.txtArte);
            this.Controls.Add(this.txtArtista);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de artes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtArtista;
        private System.Windows.Forms.TextBox txtArte;
        private System.Windows.Forms.DateTimePicker dtDataCriação;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mbtTelefone;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.ComboBox cbMaterial;
        private System.Windows.Forms.ComboBox cbEstilo;
    }
}

