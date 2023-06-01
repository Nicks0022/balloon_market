namespace Mercado_balão
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
            this.lblProduto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.txtVTotal = new System.Windows.Forms.TextBox();
            this.txtTPagar = new System.Windows.Forms.TextBox();
            this.rbdVista = new System.Windows.Forms.RadioButton();
            this.rdbPrazo = new System.Windows.Forms.RadioButton();
            this.pbxImagem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Footlight MT Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(12, 41);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(277, 20);
            this.lblProduto.TabIndex = 0;
            this.lblProduto.Text = "Informe o valor do produto (R$):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Footlight MT Light", 10F);
            this.label2.Location = new System.Drawing.Point(12, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Informe a quantidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Footlight MT Light", 10F);
            this.label3.Location = new System.Drawing.Point(12, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Footlight MT Light", 10F);
            this.label5.Location = new System.Drawing.Point(12, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total a pagar:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Footlight MT Light", 10F);
            this.linkLabel1.Location = new System.Drawing.Point(221, 255);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(273, 20);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Selecione a forma de pagamento";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Footlight MT Light", 10F);
            this.btnCalcular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCalcular.Location = new System.Drawing.Point(138, 432);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(123, 45);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Footlight MT Light", 10F);
            this.btnSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSair.Location = new System.Drawing.Point(489, 432);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(123, 45);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Footlight MT Light", 10F);
            this.btnLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLimpar.Location = new System.Drawing.Point(313, 432);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(123, 45);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Footlight MT Light", 10F);
            this.numericUpDown1.Location = new System.Drawing.Point(207, 117);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 29);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(295, 41);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(199, 26);
            this.txtProduto.TabIndex = 11;
            // 
            // txtVTotal
            // 
            this.txtVTotal.Location = new System.Drawing.Point(117, 191);
            this.txtVTotal.Name = "txtVTotal";
            this.txtVTotal.Size = new System.Drawing.Size(199, 26);
            this.txtVTotal.TabIndex = 12;
            // 
            // txtTPagar
            // 
            this.txtTPagar.Location = new System.Drawing.Point(138, 360);
            this.txtTPagar.Name = "txtTPagar";
            this.txtTPagar.Size = new System.Drawing.Size(199, 26);
            this.txtTPagar.TabIndex = 13;
            // 
            // rbdVista
            // 
            this.rbdVista.AutoSize = true;
            this.rbdVista.Font = new System.Drawing.Font("Footlight MT Light", 10F);
            this.rbdVista.Location = new System.Drawing.Point(173, 296);
            this.rbdVista.Name = "rbdVista";
            this.rbdVista.Size = new System.Drawing.Size(88, 24);
            this.rbdVista.TabIndex = 14;
            this.rbdVista.TabStop = true;
            this.rbdVista.Text = "Á vista";
            this.rbdVista.UseVisualStyleBackColor = true;
            this.rbdVista.Visible = false;
            this.rbdVista.CheckedChanged += new System.EventHandler(this.rbdVista_CheckedChanged);
            // 
            // rdbPrazo
            // 
            this.rdbPrazo.AutoSize = true;
            this.rdbPrazo.Font = new System.Drawing.Font("Footlight MT Light", 10F);
            this.rdbPrazo.Location = new System.Drawing.Point(430, 296);
            this.rdbPrazo.Name = "rdbPrazo";
            this.rdbPrazo.Size = new System.Drawing.Size(171, 24);
            this.rdbPrazo.TabIndex = 15;
            this.rdbPrazo.TabStop = true;
            this.rdbPrazo.Text = "Parcelado em 3X";
            this.rdbPrazo.UseVisualStyleBackColor = true;
            this.rdbPrazo.Visible = false;
            // 
            // pbxImagem
            // 
            this.pbxImagem.Image = global::Mercado_balão.Properties.Resources.balão;
            this.pbxImagem.Location = new System.Drawing.Point(553, 12);
            this.pbxImagem.Name = "pbxImagem";
            this.pbxImagem.Size = new System.Drawing.Size(322, 263);
            this.pbxImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagem.TabIndex = 16;
            this.pbxImagem.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(973, 526);
            this.Controls.Add(this.pbxImagem);
            this.Controls.Add(this.rdbPrazo);
            this.Controls.Add(this.rbdVista);
            this.Controls.Add(this.txtTPagar);
            this.Controls.Add(this.txtVTotal);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblProduto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Mercado Balão da Fartura";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.TextBox txtVTotal;
        private System.Windows.Forms.TextBox txtTPagar;
        private System.Windows.Forms.RadioButton rbdVista;
        private System.Windows.Forms.RadioButton rdbPrazo;
        private System.Windows.Forms.PictureBox pbxImagem;
    }
}

