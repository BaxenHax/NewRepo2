namespace Exercicios_Uninove
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
            this.lblX = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnpre = new System.Windows.Forms.Button();
            this.btnpos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(78, 22);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(14, 13);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "X";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(105, 50);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(242, 20);
            this.txtResultado.TabIndex = 1;
            // 
            // btnpre
            // 
            this.btnpre.Location = new System.Drawing.Point(68, 148);
            this.btnpre.Name = "btnpre";
            this.btnpre.Size = new System.Drawing.Size(313, 23);
            this.btnpre.TabIndex = 2;
            this.btnpre.Text = "Incremento pré-fixado";
            this.btnpre.UseVisualStyleBackColor = true;
            this.btnpre.Click += new System.EventHandler(this.btnpre_Click);
            // 
            // btnpos
            // 
            this.btnpos.Location = new System.Drawing.Point(438, 148);
            this.btnpos.Name = "btnpos";
            this.btnpos.Size = new System.Drawing.Size(308, 23);
            this.btnpos.TabIndex = 3;
            this.btnpos.Text = "Incremento pós-fixado";
            this.btnpos.UseVisualStyleBackColor = true;
            this.btnpos.Click += new System.EventHandler(this.btnpos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnpos);
            this.Controls.Add(this.btnpre);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnpre;
        private System.Windows.Forms.Button btnpos;
    }
}

