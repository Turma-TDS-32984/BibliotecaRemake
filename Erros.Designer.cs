namespace BibliotecaRemake
{
    partial class Erros
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblErro = new MaterialSkin.Controls.MaterialLabel();
            this.btnErro = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 486);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblErro, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnErro, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(675, 486);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.Depth = 0;
            this.lblErro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblErro.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblErro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblErro.Location = new System.Drawing.Point(3, 0);
            this.lblErro.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(669, 243);
            this.lblErro.TabIndex = 0;
            this.lblErro.Text = "materialLabel1";
            this.lblErro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnErro
            // 
            this.btnErro.Animated = true;
            this.btnErro.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnErro.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnErro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnErro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnErro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnErro.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnErro.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.btnErro.ForeColor = System.Drawing.Color.White;
            this.btnErro.Location = new System.Drawing.Point(3, 246);
            this.btnErro.Name = "btnErro";
            this.btnErro.Size = new System.Drawing.Size(669, 237);
            this.btnErro.TabIndex = 1;
            this.btnErro.Text = "Voltar";
            // 
            // Erros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Controls.Add(this.panel1);
            this.Name = "Erros";
            this.Size = new System.Drawing.Size(675, 486);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialLabel lblErro;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnErro;
    }
}
