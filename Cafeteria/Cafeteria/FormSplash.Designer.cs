namespace Cafeteria
{
    partial class FormSplash
    {
        private System.ComponentModel.IContainer components = null;

        // componentes da tela
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCarregando;
        private System.Windows.Forms.ProgressBar barraProgresso;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCarregando = new System.Windows.Forms.Label();
            this.barraProgresso = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();

            // titulo grandao no meio
            this.lblTitulo.AutoSize = false;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 120);
            this.lblTitulo.Size = new System.Drawing.Size(500, 60);
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.Text = "Cafeteria Dev";

            // textinho embaixo
            this.lblCarregando.AutoSize = false;
            this.lblCarregando.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCarregando.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCarregando.Location = new System.Drawing.Point(0, 190);
            this.lblCarregando.Size = new System.Drawing.Size(500, 25);
            this.lblCarregando.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCarregando.Text = "Carregando, aguarde...";

            // barrinha
            this.barraProgresso.Location = new System.Drawing.Point(100, 230);
            this.barraProgresso.Size = new System.Drawing.Size(300, 20);
            this.barraProgresso.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.barraProgresso.MarqueeAnimationSpeed = 30;

            // form em si
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(45, 30, 20); // marrom café
            this.ClientSize = new System.Drawing.Size(500, 320);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblCarregando);
            this.Controls.Add(this.barraProgresso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cafeteria Dev";
            this.ResumeLayout(false);
        }
    }
}