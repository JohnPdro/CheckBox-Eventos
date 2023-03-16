
namespace CheckBox_e_Eventos
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
            this.label1 = new System.Windows.Forms.Label();
            this.chkMaca = new System.Windows.Forms.CheckBox();
            this.chkUva = new System.Windows.Forms.CheckBox();
            this.chkLaranja = new System.Windows.Forms.CheckBox();
            this.chkAbacaxi = new System.Windows.Forms.CheckBox();
            this.chkMelancia = new System.Windows.Forms.CheckBox();
            this.btnEscolha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escolha as frutas : ";
            // 
            // chkMaca
            // 
            this.chkMaca.AutoSize = true;
            this.chkMaca.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMaca.ForeColor = System.Drawing.Color.Black;
            this.chkMaca.Location = new System.Drawing.Point(13, 56);
            this.chkMaca.Name = "chkMaca";
            this.chkMaca.Size = new System.Drawing.Size(69, 20);
            this.chkMaca.TabIndex = 1;
            this.chkMaca.Text = "MAÇÃ";
            this.chkMaca.UseVisualStyleBackColor = true;
            // 
            // chkUva
            // 
            this.chkUva.AutoSize = true;
            this.chkUva.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUva.ForeColor = System.Drawing.Color.Black;
            this.chkUva.Location = new System.Drawing.Point(13, 88);
            this.chkUva.Name = "chkUva";
            this.chkUva.Size = new System.Drawing.Size(57, 20);
            this.chkUva.TabIndex = 2;
            this.chkUva.Text = "UVA";
            this.chkUva.UseVisualStyleBackColor = true;
            // 
            // chkLaranja
            // 
            this.chkLaranja.AutoSize = true;
            this.chkLaranja.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLaranja.ForeColor = System.Drawing.Color.Black;
            this.chkLaranja.Location = new System.Drawing.Point(13, 120);
            this.chkLaranja.Name = "chkLaranja";
            this.chkLaranja.Size = new System.Drawing.Size(91, 20);
            this.chkLaranja.TabIndex = 3;
            this.chkLaranja.Text = "LARANJA";
            this.chkLaranja.UseVisualStyleBackColor = true;
            // 
            // chkAbacaxi
            // 
            this.chkAbacaxi.AutoSize = true;
            this.chkAbacaxi.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAbacaxi.ForeColor = System.Drawing.Color.Black;
            this.chkAbacaxi.Location = new System.Drawing.Point(13, 154);
            this.chkAbacaxi.Name = "chkAbacaxi";
            this.chkAbacaxi.Size = new System.Drawing.Size(93, 20);
            this.chkAbacaxi.TabIndex = 4;
            this.chkAbacaxi.Text = "ABACAXI";
            this.chkAbacaxi.UseVisualStyleBackColor = true;
            // 
            // chkMelancia
            // 
            this.chkMelancia.AutoSize = true;
            this.chkMelancia.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMelancia.ForeColor = System.Drawing.Color.Black;
            this.chkMelancia.Location = new System.Drawing.Point(13, 189);
            this.chkMelancia.Name = "chkMelancia";
            this.chkMelancia.Size = new System.Drawing.Size(102, 20);
            this.chkMelancia.TabIndex = 5;
            this.chkMelancia.Text = "MELANCIA";
            this.chkMelancia.UseVisualStyleBackColor = true;
            // 
            // btnEscolha
            // 
            this.btnEscolha.BackColor = System.Drawing.Color.White;
            this.btnEscolha.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscolha.ForeColor = System.Drawing.Color.Black;
            this.btnEscolha.Location = new System.Drawing.Point(229, 14);
            this.btnEscolha.Name = "btnEscolha";
            this.btnEscolha.Size = new System.Drawing.Size(209, 48);
            this.btnEscolha.TabIndex = 6;
            this.btnEscolha.Text = "Escolha uma fruta ao lado e clique aqui";
            this.btnEscolha.UseVisualStyleBackColor = false;
            this.btnEscolha.Click += new System.EventHandler(this.btnEscolha_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(450, 239);
            this.Controls.Add(this.btnEscolha);
            this.Controls.Add(this.chkMelancia);
            this.Controls.Add(this.chkAbacaxi);
            this.Controls.Add(this.chkLaranja);
            this.Controls.Add(this.chkUva);
            this.Controls.Add(this.chkMaca);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkMaca;
        private System.Windows.Forms.CheckBox chkUva;
        private System.Windows.Forms.CheckBox chkLaranja;
        private System.Windows.Forms.CheckBox chkAbacaxi;
        private System.Windows.Forms.CheckBox chkMelancia;
        private System.Windows.Forms.Button btnEscolha;
    }
}

