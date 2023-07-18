namespace CatalogoFilmes.View
{
    partial class TelaMenu
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
            this.lblCadastrar = new System.Windows.Forms.Label();
            this.lblSelecione = new System.Windows.Forms.Label();
            this.btnFilme = new System.Windows.Forms.Button();
            this.btnSerie = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCadastrar
            // 
            this.lblCadastrar.AutoSize = true;
            this.lblCadastrar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCadastrar.Location = new System.Drawing.Point(66, 37);
            this.lblCadastrar.Name = "lblCadastrar";
            this.lblCadastrar.Size = new System.Drawing.Size(247, 28);
            this.lblCadastrar.TabIndex = 0;
            this.lblCadastrar.Text = "Cadastrar Filmes e Séries";
            // 
            // lblSelecione
            // 
            this.lblSelecione.AutoSize = true;
            this.lblSelecione.Location = new System.Drawing.Point(80, 107);
            this.lblSelecione.Name = "lblSelecione";
            this.lblSelecione.Size = new System.Drawing.Size(216, 15);
            this.lblSelecione.TabIndex = 1;
            this.lblSelecione.Text = "Selecione abaixo o modelo de cadastro:";
            // 
            // btnFilme
            // 
            this.btnFilme.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFilme.Location = new System.Drawing.Point(90, 161);
            this.btnFilme.Name = "btnFilme";
            this.btnFilme.Size = new System.Drawing.Size(75, 23);
            this.btnFilme.TabIndex = 2;
            this.btnFilme.Text = "FILME";
            this.btnFilme.UseVisualStyleBackColor = true;
            // 
            // btnSerie
            // 
            this.btnSerie.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSerie.Location = new System.Drawing.Point(203, 161);
            this.btnSerie.Name = "btnSerie";
            this.btnSerie.Size = new System.Drawing.Size(75, 23);
            this.btnSerie.TabIndex = 3;
            this.btnSerie.Text = "SÉRIE";
            this.btnSerie.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSair.Location = new System.Drawing.Point(143, 224);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // TelaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(366, 289);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSerie);
            this.Controls.Add(this.btnFilme);
            this.Controls.Add(this.lblSelecione);
            this.Controls.Add(this.lblCadastrar);
            this.Name = "TelaMenu";
            this.Text = "Menu Sistema de Catalogo Filmes e Séries";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCadastrar;
        private Label lblSelecione;
        private Button btnFilme;
        private Button btnSerie;
        private Button btnSair;
    }
}