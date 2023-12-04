namespace appEstoqueTi
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            btn_mostraPizza = new Button();
            SuspendLayout();
            // 
            // btn_mostraPizza
            // 
            btn_mostraPizza.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_mostraPizza.ImageAlign = ContentAlignment.MiddleLeft;
            btn_mostraPizza.Location = new Point(219, 500);
            btn_mostraPizza.Name = "btn_mostraPizza";
            btn_mostraPizza.Size = new Size(94, 29);
            btn_mostraPizza.TabIndex = 0;
            btn_mostraPizza.Text = "Pizzas";
            btn_mostraPizza.UseVisualStyleBackColor = true;
            btn_mostraPizza.Click += btn_mostraPizza_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(532, 642);
            Controls.Add(btn_mostraPizza);
            DoubleBuffered = true;
            MaximumSize = new Size(600, 700);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pizzaria Meister";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_mostraPizza;
    }
}
