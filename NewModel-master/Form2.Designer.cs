namespace mdi
{
    partial class consgeral
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
            this.grelha = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grelha)).BeginInit();
            this.SuspendLayout();
            // 
            // grelha
            // 
            this.grelha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grelha.Location = new System.Drawing.Point(119, 101);
            this.grelha.Name = "grelha";
            this.grelha.RowTemplate.Height = 25;
            this.grelha.Size = new System.Drawing.Size(569, 252);
            this.grelha.TabIndex = 0;
            // 
            // consgeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grelha);
            this.Name = "consgeral";
            this.Text = "geral";
            this.Load += new System.EventHandler(this.consgeral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grelha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView grelha;
    }
}