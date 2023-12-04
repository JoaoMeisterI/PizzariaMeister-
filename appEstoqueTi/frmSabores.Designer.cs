namespace appEstoqueTi
{
    partial class frmSabores
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
            lbl_sabor = new Label();
            lbl_quantidade = new Label();
            btn_peperone = new Button();
            btn_4queijos = new Button();
            btn_calabresa = new Button();
            btn_Picanha = new Button();
            btn_Marguerita = new Button();
            btn_Mignon = new Button();
            btn_FrangoBacon = new Button();
            btn_vegetariana = new Button();
            btn_bacon = new Button();
            btn_finalizaPedido = new Button();
            SuspendLayout();
            // 
            // lbl_sabor
            // 
            lbl_sabor.AutoEllipsis = true;
            lbl_sabor.AutoSize = true;
            lbl_sabor.Font = new Font("Stencil", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_sabor.ForeColor = Color.Red;
            lbl_sabor.Location = new Point(68, 107);
            lbl_sabor.Name = "lbl_sabor";
            lbl_sabor.Size = new Size(401, 33);
            lbl_sabor.TabIndex = 4;
            lbl_sabor.Text = "ESCOLHA OS SEUS SABORES";
            // 
            // lbl_quantidade
            // 
            lbl_quantidade.AutoEllipsis = true;
            lbl_quantidade.AutoSize = true;
            lbl_quantidade.Font = new Font("Stencil", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_quantidade.ForeColor = Color.FromArgb(255, 192, 192);
            lbl_quantidade.Location = new Point(190, 156);
            lbl_quantidade.Name = "lbl_quantidade";
            lbl_quantidade.Size = new Size(146, 20);
            lbl_quantidade.TabIndex = 5;
            lbl_quantidade.Text = "ATÉ 4 SABORES";
            // 
            // btn_peperone
            // 
            btn_peperone.BackColor = Color.White;
            btn_peperone.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_peperone.ForeColor = Color.Lime;
            btn_peperone.Location = new Point(68, 254);
            btn_peperone.Name = "btn_peperone";
            btn_peperone.Size = new Size(117, 58);
            btn_peperone.TabIndex = 6;
            btn_peperone.Text = "Peperone";
            btn_peperone.UseVisualStyleBackColor = false;
            btn_peperone.Click += btn_peperone_Click;
            // 
            // btn_4queijos
            // 
            btn_4queijos.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_4queijos.ForeColor = Color.Lime;
            btn_4queijos.Location = new Point(205, 254);
            btn_4queijos.Name = "btn_4queijos";
            btn_4queijos.Size = new Size(117, 58);
            btn_4queijos.TabIndex = 7;
            btn_4queijos.Text = "4 Queijos";
            btn_4queijos.UseVisualStyleBackColor = true;
            btn_4queijos.Click += btn_4queijos_Click;
            // 
            // btn_calabresa
            // 
            btn_calabresa.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_calabresa.ForeColor = Color.Lime;
            btn_calabresa.Location = new Point(339, 254);
            btn_calabresa.Name = "btn_calabresa";
            btn_calabresa.Size = new Size(117, 58);
            btn_calabresa.TabIndex = 8;
            btn_calabresa.Text = "Calabresa";
            btn_calabresa.UseVisualStyleBackColor = true;
            btn_calabresa.Click += btn_calabresa_Click;
            // 
            // btn_Picanha
            // 
            btn_Picanha.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Picanha.ForeColor = Color.Lime;
            btn_Picanha.Location = new Point(68, 327);
            btn_Picanha.Name = "btn_Picanha";
            btn_Picanha.Size = new Size(117, 58);
            btn_Picanha.TabIndex = 9;
            btn_Picanha.Text = "Picanha";
            btn_Picanha.UseVisualStyleBackColor = true;
            btn_Picanha.Click += btn_Picanha_Click;
            // 
            // btn_Marguerita
            // 
            btn_Marguerita.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Marguerita.ForeColor = Color.Lime;
            btn_Marguerita.Location = new Point(205, 327);
            btn_Marguerita.Name = "btn_Marguerita";
            btn_Marguerita.Size = new Size(117, 58);
            btn_Marguerita.TabIndex = 10;
            btn_Marguerita.Text = "Marguerita";
            btn_Marguerita.UseVisualStyleBackColor = true;
            btn_Marguerita.Click += btn_Marguerita_Click;
            // 
            // btn_Mignon
            // 
            btn_Mignon.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Mignon.ForeColor = Color.Lime;
            btn_Mignon.Location = new Point(339, 327);
            btn_Mignon.Name = "btn_Mignon";
            btn_Mignon.Size = new Size(117, 58);
            btn_Mignon.TabIndex = 11;
            btn_Mignon.Text = "Mignon";
            btn_Mignon.UseVisualStyleBackColor = true;
            btn_Mignon.Click += btn_Mignon_Click;
            // 
            // btn_FrangoBacon
            // 
            btn_FrangoBacon.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_FrangoBacon.ForeColor = Color.Lime;
            btn_FrangoBacon.Location = new Point(68, 401);
            btn_FrangoBacon.Name = "btn_FrangoBacon";
            btn_FrangoBacon.Size = new Size(117, 58);
            btn_FrangoBacon.TabIndex = 12;
            btn_FrangoBacon.Text = "Frango e Bacon";
            btn_FrangoBacon.UseVisualStyleBackColor = true;
            btn_FrangoBacon.Click += btn_FrangoBacon_Click;
            // 
            // btn_vegetariana
            // 
            btn_vegetariana.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_vegetariana.ForeColor = Color.Lime;
            btn_vegetariana.Location = new Point(202, 401);
            btn_vegetariana.Name = "btn_vegetariana";
            btn_vegetariana.Size = new Size(120, 58);
            btn_vegetariana.TabIndex = 13;
            btn_vegetariana.Text = "Vegetariana";
            btn_vegetariana.UseVisualStyleBackColor = true;
            btn_vegetariana.Click += btn_vegetariana_Click;
            // 
            // btn_bacon
            // 
            btn_bacon.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_bacon.ForeColor = Color.Lime;
            btn_bacon.Location = new Point(339, 401);
            btn_bacon.Name = "btn_bacon";
            btn_bacon.Size = new Size(117, 58);
            btn_bacon.TabIndex = 14;
            btn_bacon.Text = "Bacon";
            btn_bacon.UseVisualStyleBackColor = true;
            btn_bacon.Click += btn_bacon_Click;
            // 
            // btn_finalizaPedido
            // 
            btn_finalizaPedido.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_finalizaPedido.ForeColor = Color.Red;
            btn_finalizaPedido.Location = new Point(131, 508);
            btn_finalizaPedido.Name = "btn_finalizaPedido";
            btn_finalizaPedido.Size = new Size(248, 29);
            btn_finalizaPedido.TabIndex = 15;
            btn_finalizaPedido.Text = "Finalizar Pedido";
            btn_finalizaPedido.UseVisualStyleBackColor = true;
            btn_finalizaPedido.Click += btn_finalizaPedido_Click;
            // 
            // frmSabores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(532, 642);
            Controls.Add(btn_finalizaPedido);
            Controls.Add(btn_bacon);
            Controls.Add(btn_vegetariana);
            Controls.Add(btn_FrangoBacon);
            Controls.Add(btn_Mignon);
            Controls.Add(btn_Marguerita);
            Controls.Add(btn_Picanha);
            Controls.Add(btn_calabresa);
            Controls.Add(btn_4queijos);
            Controls.Add(btn_peperone);
            Controls.Add(lbl_quantidade);
            Controls.Add(lbl_sabor);
            Name = "frmSabores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sabores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_sabor;
        private Label lbl_quantidade;
        private Button btn_peperone;
        private Button btn_4queijos;
        private Button btn_calabresa;
        private Button btn_Picanha;
        private Button btn_Marguerita;
        private Button btn_Mignon;
        private Button btn_FrangoBacon;
        private Button btn_vegetariana;
        private Button btn_bacon;
        private Button btn_finalizaPedido;
    }
}