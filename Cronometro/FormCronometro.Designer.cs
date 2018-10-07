namespace Cronometro
{
    partial class FormCronometro
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
            this.lblFechar = new System.Windows.Forms.Label();
            this.lblContador = new Cronometro.DoubleBufferedLabel();
            this.SuspendLayout();
            // 
            // lblFechar
            // 
            this.lblFechar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechar.AutoSize = true;
            this.lblFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechar.ForeColor = System.Drawing.Color.LightGray;
            this.lblFechar.Location = new System.Drawing.Point(1029, 9);
            this.lblFechar.Name = "lblFechar";
            this.lblFechar.Size = new System.Drawing.Size(37, 36);
            this.lblFechar.TabIndex = 2;
            this.lblFechar.Text = "X";
            this.lblFechar.Click += new System.EventHandler(this.lblFechar_Click);
            // 
            // lblContador
            // 
            this.lblContador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblContador.AutoSize = true;
            this.lblContador.BackColor = System.Drawing.Color.Transparent;
            this.lblContador.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 250.99F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.Location = new System.Drawing.Point(89, 48);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(0, 379);
            this.lblContador.TabIndex = 1;
            // 
            // FormCronometro
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1068, 427);
            this.Controls.Add(this.lblFechar);
            this.Controls.Add(this.lblContador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormCronometro";
            this.Text = "Cronômetro";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormCronometro_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DoubleBufferedLabel lblContador;
        private System.Windows.Forms.Label lblFechar;
    }
}