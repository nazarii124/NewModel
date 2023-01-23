namespace mdi
{
    partial class categorias
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
            this.txtZona = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.grelha = new System.Windows.Forms.DataGridView();
            this.txtPrateleira = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFila = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grelha)).BeginInit();
            this.SuspendLayout();
            // 
            // txtZona
            // 
            this.txtZona.Location = new System.Drawing.Point(144, 122);
            this.txtZona.Multiline = true;
            this.txtZona.Name = "txtZona";
            this.txtZona.Size = new System.Drawing.Size(101, 27);
            this.txtZona.TabIndex = 8;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(146, 89);
            this.txtCategoria.Multiline = true;
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(247, 27);
            this.txtCategoria.TabIndex = 9;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(146, 56);
            this.txtCodigo.Multiline = true;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 27);
            this.txtCodigo.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(89, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Zona";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(44, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prateleira:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(62, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Categoria:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(69, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Código:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(456, 310);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(332, 65);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Confirmar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(54, 310);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 65);
            this.button3.TabIndex = 14;
            this.button3.Text = "Limpar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(54, 239);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(105, 65);
            this.btnRemover.TabIndex = 13;
            this.btnRemover.Tag = "";
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionar.Location = new System.Drawing.Point(165, 239);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(108, 65);
            this.btnAdicionar.TabIndex = 12;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // grelha
            // 
            this.grelha.AllowUserToAddRows = false;
            this.grelha.AllowUserToDeleteRows = false;
            this.grelha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grelha.Location = new System.Drawing.Point(295, 122);
            this.grelha.Name = "grelha";
            this.grelha.RowTemplate.Height = 25;
            this.grelha.Size = new System.Drawing.Size(493, 182);
            this.grelha.TabIndex = 16;
            this.grelha.DoubleClick += new System.EventHandler(this.grelha_DoubleClick);
            // 
            // txtPrateleira
            // 
            this.txtPrateleira.Location = new System.Drawing.Point(144, 188);
            this.txtPrateleira.Multiline = true;
            this.txtPrateleira.Name = "txtPrateleira";
            this.txtPrateleira.Size = new System.Drawing.Size(99, 27);
            this.txtPrateleira.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(90, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fila";
            // 
            // txtFila
            // 
            this.txtFila.Location = new System.Drawing.Point(144, 155);
            this.txtFila.Multiline = true;
            this.txtFila.Name = "txtFila";
            this.txtFila.Size = new System.Drawing.Size(100, 27);
            this.txtFila.TabIndex = 8;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(165, 310);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(108, 65);
            this.btnAlterar.TabIndex = 12;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grelha);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtPrateleira);
            this.Controls.Add(this.txtFila);
            this.Controls.Add(this.txtZona);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "categorias";
            this.Text = "categorias";
            this.Load += new System.EventHandler(this.categorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grelha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtZona;
        private TextBox txtCategoria;
        private TextBox txtCodigo;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnGuardar;
        private Button button3;
        private Button btnRemover;
        private Button btnAdicionar;
        private DataGridView grelha;
        private TextBox txtPrateleira;
        private Label label5;
        private TextBox txtFila;
        private Button btnAlterar;
    }
}