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
			loopBox = new CheckBox();
			keepBox = new CheckBox();
			previewWindow = new PictureBox();
			label4 = new Label();
			speedSlider = new TrackBar();
			speedLabel = new Label();
			((System.ComponentModel.ISupportInitialize)previewImage).BeginInit();
			((System.ComponentModel.ISupportInitialize)previewWindow).BeginInit();
			((System.ComponentModel.ISupportInitialize)speedSlider).BeginInit();
			SuspendLayout();
			// 
			// previewImage
			// 
			previewImage.Location = new Point(11, 54);
			previewImage.Margin = new Padding(2);
			previewImage.Name = "previewImage";
			previewImage.Size = new Size(256, 256);
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
			targetPath.Size = new Size(466, 27);
			targetPath.TabIndex = 1;
			targetPath.TextChanged += targetPath_TextChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(11, 8);
			label1.Margin = new Padding(2, 0, 2, 0);
			label1.Name = "label1";
			label1.Size = new Size(126, 20);
			label1.TabIndex = 2;
			label1.Text = "$basetexture Path";
			// 
			// sizex
			// 
			sizex.Location = new Point(271, 143);
			sizex.Margin = new Padding(2);
			sizex.Name = "sizex";
			sizex.RightToLeft = RightToLeft.Yes;
			sizex.Size = new Size(48, 27);
			sizex.TabIndex = 4;
			sizex.Text = "2";
			sizex.TextChanged += rowColChange;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(271, 54);
			label2.Margin = new Padding(2, 0, 2, 0);
			label2.Name = "label2";
			label2.Size = new Size(40, 20);
			label2.TabIndex = 5;
			label2.Text = "Type";
			// 
			// kindseq
			// 
			kindseq.AutoSize = true;
			kindseq.Checked = true;
			kindseq.Location = new Point(271, 71);
			kindseq.Margin = new Padding(2);
			kindseq.Name = "kindseq";
			kindseq.Size = new Size(94, 24);
			kindseq.TabIndex = 6;
			kindseq.TabStop = true;
			kindseq.Text = "Sequence";
			kindseq.UseVisualStyleBackColor = true;
			// 
			// kindsingle
			// 
			kindsingle.AutoSize = true;
			kindsingle.Location = new Point(271, 94);
			kindsingle.Margin = new Padding(2);
			kindsingle.Name = "kindsingle";
			kindsingle.Size = new Size(71, 24);
			kindsingle.TabIndex = 7;
			kindsingle.Text = "Single";
			kindsingle.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(271, 118);
			label3.Margin = new Padding(2, 0, 2, 0);
			label3.Name = "label3";
			label3.Size = new Size(115, 20);
			label3.TabIndex = 8;
			label3.Text = "Columns / Rows";
			// 
			// sizey
			// 
			sizey.Location = new Point(323, 143);
			sizey.Margin = new Padding(2);
			sizey.Name = "sizey";
			sizey.RightToLeft = RightToLeft.Yes;
			sizey.Size = new Size(48, 27);
			sizey.TabIndex = 10;
			sizey.Text = "2";
			sizey.TextChanged += rowColChange;
			// 
			// exportButton
			// 
			exportButton.Location = new Point(11, 314);
			exportButton.Margin = new Padding(2);
			exportButton.Name = "exportButton";
			exportButton.Size = new Size(151, 28);
			exportButton.TabIndex = 11;
			exportButton.Text = "Export";
			exportButton.UseVisualStyleBackColor = true;
			exportButton.Click += button2_Click;
			// 
			// sdkpathLabel
			// 
			sdkpathLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			sdkpathLabel.AutoSize = true;
			sdkpathLabel.Location = new Point(406, 3);
			sdkpathLabel.Margin = new Padding(2, 0, 2, 0);
			sdkpathLabel.Name = "sdkpathLabel";
			sdkpathLabel.RightToLeft = RightToLeft.Yes;
			sdkpathLabel.Size = new Size(69, 20);
			sdkpathLabel.TabIndex = 12;
			sdkpathLabel.TabStop = true;
			sdkpathLabel.Text = "SDK Path";
			sdkpathLabel.TextAlign = ContentAlignment.MiddleRight;
			sdkpathLabel.LinkClicked += linkLabel1_LinkClicked;
			// 
			// additiveCheckbox
			// 
			additiveCheckbox.AutoSize = true;
			additiveCheckbox.Location = new Point(395, 127);
			additiveCheckbox.Margin = new Padding(2);
			additiveCheckbox.Name = "additiveCheckbox";
			additiveCheckbox.Size = new Size(87, 24);
			additiveCheckbox.TabIndex = 13;
			additiveCheckbox.Text = "Additive";
			additiveCheckbox.UseVisualStyleBackColor = true;
			// 
			// blendBox
			// 
			blendBox.AutoSize = true;
			blendBox.Location = new Point(395, 99);
			blendBox.Margin = new Padding(2);
			blendBox.Name = "blendBox";
			blendBox.Size = new Size(69, 24);
			blendBox.TabIndex = 14;
			blendBox.Text = "Blend";
			blendBox.UseVisualStyleBackColor = true;
			// 
			// loopBox
			// 
			loopBox.AutoSize = true;
			loopBox.Location = new Point(395, 71);
			loopBox.Margin = new Padding(2);
			loopBox.Name = "loopBox";
			loopBox.Size = new Size(82, 24);
			loopBox.TabIndex = 16;
			loopBox.Text = "Looped";
			loopBox.UseVisualStyleBackColor = true;
			// 
			// keepBox
			// 
			keepBox.AutoSize = true;
			keepBox.Location = new Point(168, 318);
			keepBox.Margin = new Padding(2);
			keepBox.Name = "keepBox";
			keepBox.Size = new Size(99, 24);
			keepBox.TabIndex = 17;
			keepBox.Text = "Keep MKS";
			keepBox.UseVisualStyleBackColor = true;
			// 
			// previewWindow
			// 
			previewWindow.Location = new Point(277, 207);
			previewWindow.Name = "previewWindow";
			previewWindow.Size = new Size(128, 128);
			previewWindow.TabIndex = 18;
			previewWindow.TabStop = false;
			previewWindow.Paint += previewWindow_Paint;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(272, 184);
			label4.Name = "label4";
			label4.Size = new Size(60, 20);
			label4.TabIndex = 19;
			label4.Text = "Preview";
			// 
			// speedSlider
			// 
			speedSlider.Location = new Point(411, 205);
			speedSlider.Minimum = 1;
			speedSlider.Name = "speedSlider";
			speedSlider.Orientation = Orientation.Vertical;
			speedSlider.Size = new Size(56, 130);
			speedSlider.TabIndex = 20;
			speedSlider.Value = 5;
			speedSlider.Scroll += speedSlider_Scroll;
			// 
			// speedLabel
			// 
			speedLabel.AutoSize = true;
			speedLabel.Location = new Point(442, 264);
			speedLabel.Name = "speedLabel";
			speedLabel.Size = new Size(37, 20);
			speedLabel.TabIndex = 21;
			speedLabel.Text = "50%";
			// 
			// Form1
			// 
			AllowDrop = true;
			AutoScaleMode = AutoScaleMode.None;
			AutoSize = true;
			ClientSize = new Size(486, 351);
			Controls.Add(speedLabel);
			Controls.Add(speedSlider);
			Controls.Add(label4);
			Controls.Add(previewWindow);
			Controls.Add(keepBox);
			Controls.Add(loopBox);
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
			MaximumSize = new Size(504, 398);
			MinimizeBox = false;
			MinimumSize = new Size(504, 398);
			Name = "Form1";
			SizeGripStyle = SizeGripStyle.Hide;
			Text = "SpriteCard Edit";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)previewImage).EndInit();
			((System.ComponentModel.ISupportInitialize)previewWindow).EndInit();
			((System.ComponentModel.ISupportInitialize)speedSlider).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox previewImage;
		private PictureBox previewWindow;
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
		private CheckBox loopBox;
		private CheckBox keepBox;
		private PictureBox pictureBox1;
		private Label label4;
		private TrackBar speedSlider;
		private Label speedLabel;
	}
}
