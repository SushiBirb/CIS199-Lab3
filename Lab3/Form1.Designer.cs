namespace Lab3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.topLeftPictureBox = new System.Windows.Forms.PictureBox();
            this.bottomRightPictureBox = new System.Windows.Forms.PictureBox();
            this.radiusPromptLabel = new System.Windows.Forms.Label();
            this.radiusTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.diameterPromptLabel = new System.Windows.Forms.Label();
            this.diameterOutputLabel = new System.Windows.Forms.Label();
            this.surfaceAreaPromptLabel = new System.Windows.Forms.Label();
            this.surfaceAreaOutputLabel = new System.Windows.Forms.Label();
            this.volumePromptLabel = new System.Windows.Forms.Label();
            this.volumeOutputLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.topLeftPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomRightPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // topLeftPictureBox
            // 
            this.topLeftPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Sphere_and_Ball")));
            this.topLeftPictureBox.Location = new System.Drawing.Point(12, 12);
            this.topLeftPictureBox.Name = "topLeftPictureBox";
            this.topLeftPictureBox.Size = new System.Drawing.Size(150, 150);
            this.topLeftPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.topLeftPictureBox.TabIndex = 0;
            this.topLeftPictureBox.TabStop = false;
            // 
            // bottomRightPictureBox
            // 
            this.bottomRightPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Sphere_and_Ball")));
            this.bottomRightPictureBox.Location = new System.Drawing.Point(220, 205);
            this.bottomRightPictureBox.Name = "bottomRightPictureBox";
            this.bottomRightPictureBox.Size = new System.Drawing.Size(150, 150);
            this.bottomRightPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bottomRightPictureBox.TabIndex = 1;
            this.bottomRightPictureBox.TabStop = false;
            // 
            // radiusPromptLabel
            // 
            this.radiusPromptLabel.AutoSize = true;
            this.radiusPromptLabel.Location = new System.Drawing.Point(168, 54);
            this.radiusPromptLabel.Name = "radiusPromptLabel";
            this.radiusPromptLabel.Size = new System.Drawing.Size(91, 13);
            this.radiusPromptLabel.TabIndex = 2;
            this.radiusPromptLabel.Text = "Radius of sphere:";
            // 
            // radiusTextBox
            // 
            this.radiusTextBox.Location = new System.Drawing.Point(264, 51);
            this.radiusTextBox.Name = "radiusTextBox";
            this.radiusTextBox.Size = new System.Drawing.Size(100, 20);
            this.radiusTextBox.TabIndex = 3;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(278, 86);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // diameterPromptLabel
            // 
            this.diameterPromptLabel.Location = new System.Drawing.Point(15, 201);
            this.diameterPromptLabel.Name = "diameterPromptLabel";
            this.diameterPromptLabel.Size = new System.Drawing.Size(65, 20);
            this.diameterPromptLabel.TabIndex = 5;
            this.diameterPromptLabel.Text = "Diameter";
            this.diameterPromptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // diameterOutputLabel
            // 
            this.diameterOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.diameterOutputLabel.Location = new System.Drawing.Point(86, 199);
            this.diameterOutputLabel.Name = "diameterOutputLabel";
            this.diameterOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.diameterOutputLabel.TabIndex = 6;
            this.diameterOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // surfaceAreaPromptLabel
            // 
            this.surfaceAreaPromptLabel.Location = new System.Drawing.Point(12, 246);
            this.surfaceAreaPromptLabel.Name = "surfaceAreaPromptLabel";
            this.surfaceAreaPromptLabel.Size = new System.Drawing.Size(68, 20);
            this.surfaceAreaPromptLabel.TabIndex = 7;
            this.surfaceAreaPromptLabel.Text = "Surface Area";
            this.surfaceAreaPromptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // surfaceAreaOutputLabel
            // 
            this.surfaceAreaOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.surfaceAreaOutputLabel.Location = new System.Drawing.Point(86, 244);
            this.surfaceAreaOutputLabel.Name = "surfaceAreaOutputLabel";
            this.surfaceAreaOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.surfaceAreaOutputLabel.TabIndex = 8;
            this.surfaceAreaOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // volumePromptLabel
            // 
            this.volumePromptLabel.Location = new System.Drawing.Point(15, 291);
            this.volumePromptLabel.Name = "volumePromptLabel";
            this.volumePromptLabel.Size = new System.Drawing.Size(65, 20);
            this.volumePromptLabel.TabIndex = 9;
            this.volumePromptLabel.Text = "Volume";
            this.volumePromptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // volumeOutputLabel
            // 
            this.volumeOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.volumeOutputLabel.Location = new System.Drawing.Point(86, 289);
            this.volumeOutputLabel.Name = "volumeOutputLabel";
            this.volumeOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.volumeOutputLabel.TabIndex = 10;
            this.volumeOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.volumeOutputLabel);
            this.Controls.Add(this.volumePromptLabel);
            this.Controls.Add(this.surfaceAreaOutputLabel);
            this.Controls.Add(this.surfaceAreaPromptLabel);
            this.Controls.Add(this.diameterOutputLabel);
            this.Controls.Add(this.diameterPromptLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.radiusTextBox);
            this.Controls.Add(this.radiusPromptLabel);
            this.Controls.Add(this.bottomRightPictureBox);
            this.Controls.Add(this.topLeftPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab 3";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.topLeftPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomRightPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox topLeftPictureBox;
        private System.Windows.Forms.PictureBox bottomRightPictureBox;
        private System.Windows.Forms.Label radiusPromptLabel;
        private System.Windows.Forms.TextBox radiusTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label diameterPromptLabel;
        private System.Windows.Forms.Label diameterOutputLabel;
        private System.Windows.Forms.Label surfaceAreaPromptLabel;
        private System.Windows.Forms.Label surfaceAreaOutputLabel;
        private System.Windows.Forms.Label volumePromptLabel;
        private System.Windows.Forms.Label volumeOutputLabel;
    }
}
