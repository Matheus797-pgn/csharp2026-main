namespace AplicativoDesketop01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            Usuarios = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Usuarios
            // 
            Usuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Usuarios.BackColor = Color.Transparent;
            Usuarios.Font = new Font("MS Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Usuarios.ForeColor = Color.Black;
            Usuarios.Location = new Point(41, 51);
            Usuarios.Name = "Usuarios";
            Usuarios.Size = new Size(405, 33);
            Usuarios.TabIndex = 3;
            Usuarios.Text = "Usuario\r\n";
            Usuarios.TextAlign = ContentAlignment.MiddleCenter;
            Usuarios.UseWaitCursor = true;
            Usuarios.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(41, 111);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(405, 23);
            textBox1.TabIndex = 4;
            textBox1.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("MS Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(41, 162);
            label1.Name = "label1";
            label1.Size = new Size(405, 34);
            label1.TabIndex = 5;
            label1.Text = "Senha\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.UseWaitCursor = true;
            label1.BackColorChanged += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(41, 233);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(405, 23);
            textBox2.TabIndex = 6;
            textBox2.UseWaitCursor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.AutoSize = true;
            button1.Font = new Font("MS Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(63, 313);
            button1.Name = "button1";
            button1.Size = new Size(357, 101);
            button1.TabIndex = 7;
            button1.Text = "Login\r\n";
            button1.UseVisualStyleBackColor = true;
            button1.UseWaitCursor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(462, 36);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.cesar1;
            ClientSize = new Size(486, 511);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(Usuarios);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela De login";
            UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Usuarios;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Button button1;
        private PictureBox pictureBox1;
    }
}
