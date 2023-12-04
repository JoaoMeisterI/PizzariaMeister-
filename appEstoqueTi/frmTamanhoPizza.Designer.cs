namespace appEstoqueTi
{
    partial class frmTamanhoPizza
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
            btn_pequena = new Button();
            btn_media = new Button();
            btn_grande = new Button();
            lbl_tamanho = new Label();
            lbl_tit_pequena = new Label();
            lbl_tit_media = new Label();
            lbl_tit_grande = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btn_pequena
            // 
            btn_pequena.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_pequena.ForeColor = Color.Red;
            btn_pequena.Location = new Point(39, 251);
            btn_pequena.Name = "btn_pequena";
            btn_pequena.Size = new Size(461, 29);
            btn_pequena.TabIndex = 0;
            btn_pequena.Text = "Pizza Pequena";
            btn_pequena.UseVisualStyleBackColor = true;
            btn_pequena.Click += btn_pequena_Click;
            // 
            // btn_media
            // 
            btn_media.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_media.ForeColor = Color.Red;
            btn_media.Location = new Point(39, 385);
            btn_media.Name = "btn_media";
            btn_media.Size = new Size(461, 29);
            btn_media.TabIndex = 1;
            btn_media.Text = "Pizza Média";
            btn_media.UseVisualStyleBackColor = true;
            btn_media.Click += btn_media_Click;
            // 
            // btn_grande
            // 
            btn_grande.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_grande.ForeColor = Color.Red;
            btn_grande.Location = new Point(39, 516);
            btn_grande.Name = "btn_grande";
            btn_grande.Size = new Size(461, 29);
            btn_grande.TabIndex = 2;
            btn_grande.Text = "Pizza Grande";
            btn_grande.UseVisualStyleBackColor = true;
            btn_grande.Click += btn_grande_Click;
            // 
            // lbl_tamanho
            // 
            lbl_tamanho.AutoEllipsis = true;
            lbl_tamanho.AutoSize = true;
            lbl_tamanho.Font = new Font("Stencil", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_tamanho.ForeColor = Color.Red;
            lbl_tamanho.Location = new Point(12, 88);
            lbl_tamanho.Name = "lbl_tamanho";
            lbl_tamanho.Size = new Size(511, 33);
            lbl_tamanho.TabIndex = 3;
            lbl_tamanho.Text = "ESCOLHA O TAMANHO DA SUA PIZZA";
            lbl_tamanho.Click += label1_Click;
            // 
            // lbl_tit_pequena
            // 
            lbl_tit_pequena.AutoSize = true;
            lbl_tit_pequena.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_tit_pequena.ForeColor = Color.Lime;
            lbl_tit_pequena.Location = new Point(39, 223);
            lbl_tit_pequena.Name = "lbl_tit_pequena";
            lbl_tit_pequena.Size = new Size(84, 25);
            lbl_tit_pequena.TabIndex = 4;
            lbl_tit_pequena.Text = "R$ 35,00";
            // 
            // lbl_tit_media
            // 
            lbl_tit_media.AutoSize = true;
            lbl_tit_media.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_tit_media.ForeColor = Color.Lime;
            lbl_tit_media.Location = new Point(39, 357);
            lbl_tit_media.Name = "lbl_tit_media";
            lbl_tit_media.Size = new Size(84, 25);
            lbl_tit_media.TabIndex = 5;
            lbl_tit_media.Text = "R$ 50,00";
            // 
            // lbl_tit_grande
            // 
            lbl_tit_grande.AutoSize = true;
            lbl_tit_grande.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_tit_grande.ForeColor = Color.Lime;
            lbl_tit_grande.Location = new Point(39, 488);
            lbl_tit_grande.Name = "lbl_tit_grande";
            lbl_tit_grande.Size = new Size(84, 25);
            lbl_tit_grande.TabIndex = 6;
            lbl_tit_grande.Text = "R$ 75,00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(407, 223);
            label1.Name = "label1";
            label1.Size = new Size(93, 25);
            label1.TabIndex = 7;
            label1.Text = "3 Sabores";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Lime;
            label2.Location = new Point(407, 357);
            label2.Name = "label2";
            label2.Size = new Size(93, 25);
            label2.TabIndex = 8;
            label2.Text = "4 Sabores";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Lime;
            label3.Location = new Point(407, 488);
            label3.Name = "label3";
            label3.Size = new Size(93, 25);
            label3.TabIndex = 9;
            label3.Text = "5 Sabores";
            // 
            // frmTamanhoPizza
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(532, 642);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbl_tit_grande);
            Controls.Add(lbl_tit_media);
            Controls.Add(lbl_tit_pequena);
            Controls.Add(lbl_tamanho);
            Controls.Add(btn_grande);
            Controls.Add(btn_media);
            Controls.Add(btn_pequena);
            Name = "frmTamanhoPizza";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tamanho Pizza";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_pequena;
        private Button btn_media;
        private Button btn_grande;
        private Label lbl_tamanho;
        private Label lbl_tit_pequena;
        private Label lbl_tit_media;
        private Label lbl_tit_grande;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}