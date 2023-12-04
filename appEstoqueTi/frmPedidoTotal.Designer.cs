namespace pizzariaMeister
{
    partial class frmPedidoTotal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedidoTotal));
            lbl_TotalPedido = new Label();
            lbl_ValorTotal = new Label();
            lbl_sabores = new Label();
            lbl_saboresEscolhidos = new Label();
            SuspendLayout();
            // 
            // lbl_TotalPedido
            // 
            lbl_TotalPedido.AutoEllipsis = true;
            resources.ApplyResources(lbl_TotalPedido, "lbl_TotalPedido");
            lbl_TotalPedido.ForeColor = Color.Red;
            lbl_TotalPedido.Name = "lbl_TotalPedido";
            lbl_TotalPedido.Click += lbl_tamanho_Click;
            // 
            // lbl_ValorTotal
            // 
            lbl_ValorTotal.AutoEllipsis = true;
            resources.ApplyResources(lbl_ValorTotal, "lbl_ValorTotal");
            lbl_ValorTotal.ForeColor = Color.Lime;
            lbl_ValorTotal.Name = "lbl_ValorTotal";
            // 
            // lbl_sabores
            // 
            lbl_sabores.AutoEllipsis = true;
            resources.ApplyResources(lbl_sabores, "lbl_sabores");
            lbl_sabores.ForeColor = Color.Red;
            lbl_sabores.Name = "lbl_sabores";
            // 
            // lbl_saboresEscolhidos
            // 
            lbl_saboresEscolhidos.AutoEllipsis = true;
            resources.ApplyResources(lbl_saboresEscolhidos, "lbl_saboresEscolhidos");
            lbl_saboresEscolhidos.ForeColor = Color.Lime;
            lbl_saboresEscolhidos.Name = "lbl_saboresEscolhidos";
            lbl_saboresEscolhidos.Click += label2_Click;
            // 
            // frmPedidoTotal
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            Controls.Add(lbl_saboresEscolhidos);
            Controls.Add(lbl_sabores);
            Controls.Add(lbl_ValorTotal);
            Controls.Add(lbl_TotalPedido);
            ForeColor = Color.Cornsilk;
            Name = "frmPedidoTotal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_TotalPedido;
        private Label lbl_ValorTotal;
        private Label lbl_sabores;
        private Label lbl_saboresEscolhidos;
    }
}