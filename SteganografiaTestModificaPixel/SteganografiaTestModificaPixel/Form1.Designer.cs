namespace SteganografiaTestModificaPixel
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
            this.TextToHide = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ImageContainer = new System.Windows.Forms.Panel();
            this.CurrentImage = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DecodeTXT = new System.Windows.Forms.Button();
            this.MSB_Mode = new System.Windows.Forms.RadioButton();
            this.LSB_Mode = new System.Windows.Forms.RadioButton();
            this.HideTextBTN = new System.Windows.Forms.Button();
            this.FileSelectionBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.ImageContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentImage)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextToHide
            // 
            this.TextToHide.CausesValidation = false;
            this.TextToHide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextToHide.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextToHide.Location = new System.Drawing.Point(0, 0);
            this.TextToHide.Multiline = true;
            this.TextToHide.Name = "TextToHide";
            this.TextToHide.PlaceholderText = "Inserire il testo da nascondere...";
            this.TextToHide.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextToHide.Size = new System.Drawing.Size(800, 113);
            this.TextToHide.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TextToHide);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 337);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 113);
            this.panel1.TabIndex = 1;
            // 
            // ImageContainer
            // 
            this.ImageContainer.Controls.Add(this.CurrentImage);
            this.ImageContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.ImageContainer.Location = new System.Drawing.Point(0, 0);
            this.ImageContainer.Name = "ImageContainer";
            this.ImageContainer.Size = new System.Drawing.Size(387, 337);
            this.ImageContainer.TabIndex = 2;
            // 
            // CurrentImage
            // 
            this.CurrentImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrentImage.Location = new System.Drawing.Point(0, 0);
            this.CurrentImage.Name = "CurrentImage";
            this.CurrentImage.Size = new System.Drawing.Size(387, 337);
            this.CurrentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CurrentImage.TabIndex = 0;
            this.CurrentImage.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.DecodeTXT);
            this.panel3.Controls.Add(this.MSB_Mode);
            this.panel3.Controls.Add(this.LSB_Mode);
            this.panel3.Controls.Add(this.HideTextBTN);
            this.panel3.Controls.Add(this.FileSelectionBTN);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(387, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(413, 337);
            this.panel3.TabIndex = 3;
            // 
            // DecodeTXT
            // 
            this.DecodeTXT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DecodeTXT.Location = new System.Drawing.Point(168, 61);
            this.DecodeTXT.Name = "DecodeTXT";
            this.DecodeTXT.Size = new System.Drawing.Size(231, 43);
            this.DecodeTXT.TabIndex = 4;
            this.DecodeTXT.Text = "Get text from image";
            this.DecodeTXT.UseVisualStyleBackColor = true;
            this.DecodeTXT.Click += new System.EventHandler(this.DecodeTXT_Click);
            // 
            // MSB_Mode
            // 
            this.MSB_Mode.AutoSize = true;
            this.MSB_Mode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MSB_Mode.Location = new System.Drawing.Point(6, 141);
            this.MSB_Mode.Name = "MSB_Mode";
            this.MSB_Mode.Size = new System.Drawing.Size(104, 25);
            this.MSB_Mode.TabIndex = 3;
            this.MSB_Mode.Text = "MSB Mode";
            this.MSB_Mode.UseVisualStyleBackColor = true;
            // 
            // LSB_Mode
            // 
            this.LSB_Mode.AutoSize = true;
            this.LSB_Mode.Checked = true;
            this.LSB_Mode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LSB_Mode.Location = new System.Drawing.Point(6, 110);
            this.LSB_Mode.Name = "LSB_Mode";
            this.LSB_Mode.Size = new System.Drawing.Size(98, 25);
            this.LSB_Mode.TabIndex = 2;
            this.LSB_Mode.TabStop = true;
            this.LSB_Mode.Text = "LSB Mode";
            this.LSB_Mode.UseVisualStyleBackColor = true;
            // 
            // HideTextBTN
            // 
            this.HideTextBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HideTextBTN.Location = new System.Drawing.Point(6, 61);
            this.HideTextBTN.Name = "HideTextBTN";
            this.HideTextBTN.Size = new System.Drawing.Size(156, 43);
            this.HideTextBTN.TabIndex = 1;
            this.HideTextBTN.Text = "Hide text in image";
            this.HideTextBTN.UseVisualStyleBackColor = true;
            this.HideTextBTN.Click += new System.EventHandler(this.hideTextBTN_Clicked);
            // 
            // FileSelectionBTN
            // 
            this.FileSelectionBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FileSelectionBTN.Location = new System.Drawing.Point(6, 12);
            this.FileSelectionBTN.Name = "FileSelectionBTN";
            this.FileSelectionBTN.Size = new System.Drawing.Size(393, 43);
            this.FileSelectionBTN.TabIndex = 0;
            this.FileSelectionBTN.Text = "Select Image";
            this.FileSelectionBTN.UseVisualStyleBackColor = true;
            this.FileSelectionBTN.Click += new System.EventHandler(this.imageSelectionBTN_Clicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 45);
            this.label1.TabIndex = 5;
            this.label1.Text = "*L\'immagine viene salvata in:\r\n\"SteganografiaTestModificaPixel\\SteganografiaTestM" +
    "odificaPixel\r\n\\bin\\Debug\\net6.0-windows\\\"";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ImageContainer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ImageContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CurrentImage)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox TextToHide;
        private Panel panel1;
        private Panel ImageContainer;
        private Panel panel3;
        private PictureBox CurrentImage;
        private Button FileSelectionBTN;
        private Button HideTextBTN;
        private RadioButton LSB_Mode;
        private RadioButton MSB_Mode;
        private Button DecodeTXT;
        private Label label1;
    }
}