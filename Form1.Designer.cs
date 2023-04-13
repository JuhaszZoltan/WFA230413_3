namespace WFA230413_3
{
    partial class Form1
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
            pbCoral = new PictureBox();
            pbPale = new PictureBox();
            pbAqua = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbCoral).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAqua).BeginInit();
            SuspendLayout();
            // 
            // pbCoral
            // 
            pbCoral.BackColor = Color.Coral;
            pbCoral.Location = new Point(12, 12);
            pbCoral.Name = "pbCoral";
            pbCoral.Size = new Size(372, 131);
            pbCoral.TabIndex = 0;
            pbCoral.TabStop = false;
            // 
            // pbPale
            // 
            pbPale.BackColor = Color.PaleGreen;
            pbPale.Location = new Point(12, 200);
            pbPale.Name = "pbPale";
            pbPale.Size = new Size(372, 131);
            pbPale.TabIndex = 0;
            pbPale.TabStop = false;
            // 
            // pbAqua
            // 
            pbAqua.BackColor = Color.Aqua;
            pbAqua.Location = new Point(12, 388);
            pbAqua.Name = "pbAqua";
            pbAqua.Size = new Size(372, 131);
            pbAqua.TabIndex = 0;
            pbAqua.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 531);
            Controls.Add(pbAqua);
            Controls.Add(pbPale);
            Controls.Add(pbCoral);
            Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbCoral).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPale).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAqua).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbCoral;
        private PictureBox pbPale;
        private PictureBox pbAqua;
    }
}