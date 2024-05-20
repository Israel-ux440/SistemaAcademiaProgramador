namespace SistemaAcademiaProgramador.WinApp
{
    partial class TelaLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            btnEntrar = new Button();
            lblNome = new Label();
            txtNome = new TextBox();
            lblSenha = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_titulo;
            pictureBox1.Location = new Point(110, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(311, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(236, 106, 250);
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(135, 340);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(230, 60);
            btnEntrar.TabIndex = 1;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.ForeColor = SystemColors.Control;
            lblNome.Location = new Point(135, 197);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(161, 25);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome de Usuário";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 14.25F);
            txtNome.Location = new Point(135, 225);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(230, 33);
            txtNome.TabIndex = 3;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenha.ForeColor = SystemColors.Control;
            lblSenha.Location = new Point(135, 262);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(64, 25);
            lblSenha.TabIndex = 2;
            lblSenha.Text = "Senha";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14.25F);
            textBox1.Location = new Point(135, 290);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(230, 33);
            textBox1.TabIndex = 3;
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(117, 67, 186);
            ClientSize = new Size(525, 525);
            Controls.Add(textBox1);
            Controls.Add(lblSenha);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(btnEntrar);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "TelaLogin";
            Text = "Form1";
            Click += TelaLogin_Click;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnEntrar;
        private Label lblNome;
        private TextBox txtNome;
        private Label lblSenha;
        private TextBox textBox1;
    }
}
