namespace MKSCreator
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			previewImage = new PictureBox();
			targetPath = new TextBox();
			label1 = new Label();
			sizex = new TextBox();
			label2 = new Label();
			kindseq = new RadioButton();
			kindsingle = new RadioButton();
			label3 = new Label();
			sizey = new TextBox();
			exportButton = new Button();
			sdkpathLabel = new LinkLabel();
			additiveCheckbox = new CheckBox();
			blendBox = new CheckBox();
			coloralpha = new CheckBox();
			loopBox = new CheckBox();
			keepBox = new CheckBox();
			((System.ComponentModel.ISupportInitialize)previewImage).BeginInit();
			SuspendLayout();
			// 
			// previewImage
			// 
			previewImage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			previewImage.Location = new Point(11, 54);
			previewImage.Margin = new Padding(2);
			previewImage.MaximumSize = new Size(200, 200);
			previewImage.MinimumSize = new Size(200, 200);
			previewImage.Name = "previewImage";
			previewImage.Size = new Size(200, 200);
			previewImage.SizeMode = PictureBoxSizeMode.StretchImage;
			previewImage.TabIndex = 0;
			previewImage.TabStop = false;
			previewImage.DragDrop += previewImage_DragDrop;
			previewImage.Paint += previewImage_Paint;
			// 
			// targetPath
			// 
			targetPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			targetPath.Location = new Point(11, 25);
			targetPath.Margin = new Padding(2);
			targetPath.Name = "targetPath";
			targetPath.Size = new Size(308, 23);
			targetPath.TabIndex = 1;
			targetPath.TextChanged += targetPath_TextChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(11, 8);
			label1.Margin = new Padding(2, 0, 2, 0);
			label1.Name = "label1";
			label1.Size = new Size(100, 15);
			label1.TabIndex = 2;
			label1.Text = "$basetexture Path";
			// 
			// sizex
			// 
			sizex.Location = new Point(215, 134);
			sizex.Margin = new Padding(2);
			sizex.Name = "sizex";
			sizex.RightToLeft = RightToLeft.Yes;
			sizex.Size = new Size(50, 23);
			sizex.TabIndex = 4;
			sizex.Text = "2";
			sizex.TextChanged += rowColChange;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(215, 54);
			label2.Margin = new Padding(2, 0, 2, 0);
			label2.Name = "label2";
			label2.Size = new Size(32, 15);
			label2.TabIndex = 5;
			label2.Text = "Type";
			// 
			// kindseq
			// 
			kindseq.AutoSize = true;
			kindseq.Checked = true;
			kindseq.Location = new Point(215, 71);
			kindseq.Margin = new Padding(2);
			kindseq.Name = "kindseq";
			kindseq.Size = new Size(76, 19);
			kindseq.TabIndex = 6;
			kindseq.TabStop = true;
			kindseq.Text = "Sequence";
			kindseq.UseVisualStyleBackColor = true;
			// 
			// kindsingle
			// 
			kindsingle.AutoSize = true;
			kindsingle.Location = new Point(215, 94);
			kindsingle.Margin = new Padding(2);
			kindsingle.Name = "kindsingle";
			kindsingle.Size = new Size(57, 19);
			kindsingle.TabIndex = 7;
			kindsingle.Text = "Single";
			kindsingle.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(215, 118);
			label3.Margin = new Padding(2, 0, 2, 0);
			label3.Name = "label3";
			label3.Size = new Size(94, 15);
			label3.TabIndex = 8;
			label3.Text = "Columns / Rows";
			// 
			// sizey
			// 
			sizey.Location = new Point(269, 134);
			sizey.Margin = new Padding(2);
			sizey.Name = "sizey";
			sizey.RightToLeft = RightToLeft.Yes;
			sizey.Size = new Size(50, 23);
			sizey.TabIndex = 10;
			sizey.Text = "2";
			sizey.TextChanged += rowColChange;
			// 
			// exportButton
			// 
			exportButton.Location = new Point(10, 258);
			exportButton.Margin = new Padding(2);
			exportButton.Name = "exportButton";
			exportButton.Size = new Size(309, 26);
			exportButton.TabIndex = 11;
			exportButton.Text = "Export";
			exportButton.UseVisualStyleBackColor = true;
			exportButton.Click += button2_Click;
			// 
			// sdkpathLabel
			// 
			sdkpathLabel.AutoSize = true;
			sdkpathLabel.Location = new Point(217, 8);
			sdkpathLabel.Margin = new Padding(2, 0, 2, 0);
			sdkpathLabel.Name = "sdkpathLabel";
			sdkpathLabel.RightToLeft = RightToLeft.Yes;
			sdkpathLabel.Size = new Size(55, 15);
			sdkpathLabel.TabIndex = 12;
			sdkpathLabel.TabStop = true;
			sdkpathLabel.Text = "SDK Path";
			sdkpathLabel.TextAlign = ContentAlignment.MiddleRight;
			sdkpathLabel.LinkClicked += linkLabel1_LinkClicked;
			// 
			// additiveCheckbox
			// 
			additiveCheckbox.AutoSize = true;
			additiveCheckbox.Location = new Point(215, 212);
			additiveCheckbox.Margin = new Padding(2);
			additiveCheckbox.Name = "additiveCheckbox";
			additiveCheckbox.Size = new Size(70, 19);
			additiveCheckbox.TabIndex = 13;
			additiveCheckbox.Text = "Additive";
			additiveCheckbox.UseVisualStyleBackColor = true;
			// 
			// blendBox
			// 
			blendBox.AutoSize = true;
			blendBox.Location = new Point(215, 178);
			blendBox.Margin = new Padding(2);
			blendBox.Name = "blendBox";
			blendBox.Size = new Size(97, 19);
			blendBox.TabIndex = 14;
			blendBox.Text = "Blend Frames";
			blendBox.UseVisualStyleBackColor = true;
			// 
			// coloralpha
			// 
			coloralpha.AutoSize = true;
			coloralpha.Location = new Point(215, 195);
			coloralpha.Margin = new Padding(2);
			coloralpha.Name = "coloralpha";
			coloralpha.Size = new Size(93, 19);
			coloralpha.TabIndex = 15;
			coloralpha.Text = "$color/alpha";
			coloralpha.UseVisualStyleBackColor = true;
			// 
			// loopBox
			// 
			loopBox.AutoSize = true;
			loopBox.Location = new Point(215, 161);
			loopBox.Margin = new Padding(2);
			loopBox.Name = "loopBox";
			loopBox.Size = new Size(66, 19);
			loopBox.TabIndex = 16;
			loopBox.Text = "Looped";
			loopBox.UseVisualStyleBackColor = true;
			// 
			// keepBox
			// 
			keepBox.AutoSize = true;
			keepBox.Location = new Point(215, 229);
			keepBox.Margin = new Padding(2);
			keepBox.Name = "keepBox";
			keepBox.Size = new Size(79, 19);
			keepBox.TabIndex = 17;
			keepBox.Text = "Keep MKS";
			keepBox.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			AllowDrop = true;
			AutoScaleMode = AutoScaleMode.None;
			AutoSize = true;
			ClientSize = new Size(330, 293);
			Controls.Add(keepBox);
			Controls.Add(loopBox);
			Controls.Add(coloralpha);
			Controls.Add(blendBox);
			Controls.Add(additiveCheckbox);
			Controls.Add(sdkpathLabel);
			Controls.Add(exportButton);
			Controls.Add(sizey);
			Controls.Add(label3);
			Controls.Add(kindsingle);
			Controls.Add(kindseq);
			Controls.Add(label2);
			Controls.Add(sizex);
			Controls.Add(label1);
			Controls.Add(targetPath);
			Controls.Add(previewImage);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(2);
			MaximizeBox = false;
			MaximumSize = new Size(346, 332);
			MinimizeBox = false;
			MinimumSize = new Size(346, 332);
			Name = "Form1";
			Text = "SpriteCard Edit";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)previewImage).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox previewImage;
        private TextBox targetPath;
        private Label label1;
        private TextBox sizex;
        private Label label2;
        private RadioButton kindseq;
        private RadioButton kindsingle;
        private Label label3;
        private TextBox sizey;
        private Button exportButton;
        private LinkLabel sdkpathLabel;
        private CheckBox additiveCheckbox;
        private CheckBox blendBox;
		private CheckBox coloralpha;
		private CheckBox loopBox;
		private CheckBox keepBox;
	}
}
