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
            previewImage = new PictureBox();
            targetPath = new TextBox();
            label1 = new Label();
            sizex = new TextBox();
            label2 = new Label();
            kindseq = new RadioButton();
            kindsingle = new RadioButton();
            label3 = new Label();
            label4 = new Label();
            sizey = new TextBox();
            exportButton = new Button();
            sdkpathLabel = new LinkLabel();
            additiveCheckbox = new CheckBox();
            blendBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)previewImage).BeginInit();
            SuspendLayout();
            // 
            // previewImage
            // 
            previewImage.Location = new Point(12, 90);
            previewImage.Name = "previewImage";
            previewImage.Size = new Size(300, 300);
            previewImage.SizeMode = PictureBoxSizeMode.StretchImage;
            previewImage.TabIndex = 0;
            previewImage.TabStop = false;
            previewImage.DragDrop += previewImage_DragDrop;
            previewImage.Paint += previewImage_Paint;
            // 
            // targetPath
            // 
            targetPath.Location = new Point(12, 41);
            targetPath.Name = "targetPath";
            targetPath.Size = new Size(300, 31);
            targetPath.TabIndex = 1;
            targetPath.TextChanged += targetPath_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(152, 25);
            label1.TabIndex = 2;
            label1.Text = "$basetexture Path";
            // 
            // sizex
            // 
            sizex.Location = new Point(318, 224);
            sizex.Name = "sizex";
            sizex.Size = new Size(136, 31);
            sizex.TabIndex = 4;
            sizex.Text = "2";
            sizex.TextChanged += rowColChange;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(318, 90);
            label2.Name = "label2";
            label2.Size = new Size(49, 25);
            label2.TabIndex = 5;
            label2.Text = "Type";
            // 
            // kindseq
            // 
            kindseq.AutoSize = true;
            kindseq.Checked = true;
            kindseq.Location = new Point(318, 118);
            kindseq.Name = "kindseq";
            kindseq.Size = new Size(113, 29);
            kindseq.TabIndex = 6;
            kindseq.TabStop = true;
            kindseq.Text = "Sequence";
            kindseq.UseVisualStyleBackColor = true;
            // 
            // kindsingle
            // 
            kindsingle.AutoSize = true;
            kindsingle.Location = new Point(318, 153);
            kindsingle.Name = "kindsingle";
            kindsingle.Size = new Size(85, 29);
            kindsingle.TabIndex = 7;
            kindsingle.Text = "Single";
            kindsingle.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(318, 196);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 8;
            label3.Text = "Columns";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(318, 258);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 9;
            label4.Text = "Rows";
            // 
            // sizey
            // 
            sizey.Location = new Point(318, 286);
            sizey.Name = "sizey";
            sizey.Size = new Size(136, 31);
            sizey.TabIndex = 10;
            sizey.Text = "2";
            sizey.TextChanged += rowColChange;
            // 
            // exportButton
            // 
            exportButton.Location = new Point(12, 404);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(440, 34);
            exportButton.TabIndex = 11;
            exportButton.Text = "Export";
            exportButton.UseVisualStyleBackColor = true;
            exportButton.Click += button2_Click;
            // 
            // sdkpathLabel
            // 
            sdkpathLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            sdkpathLabel.AutoSize = true;
            sdkpathLabel.Location = new Point(370, 13);
            sdkpathLabel.Name = "sdkpathLabel";
            sdkpathLabel.Size = new Size(84, 25);
            sdkpathLabel.TabIndex = 12;
            sdkpathLabel.TabStop = true;
            sdkpathLabel.Text = "SDK Path";
            sdkpathLabel.TextAlign = ContentAlignment.TopRight;
            sdkpathLabel.LinkClicked += linkLabel1_LinkClicked;
            // 
            // additiveCheckbox
            // 
            additiveCheckbox.AutoSize = true;
            additiveCheckbox.Location = new Point(318, 323);
            additiveCheckbox.Name = "additiveCheckbox";
            additiveCheckbox.Size = new Size(104, 29);
            additiveCheckbox.TabIndex = 13;
            additiveCheckbox.Text = "Additive";
            additiveCheckbox.UseVisualStyleBackColor = true;
            // 
            // blendBox
            // 
            blendBox.AutoSize = true;
            blendBox.Location = new Point(318, 358);
            blendBox.Name = "blendBox";
            blendBox.Size = new Size(144, 29);
            blendBox.TabIndex = 14;
            blendBox.Text = "Blend Frames";
            blendBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 452);
            Controls.Add(blendBox);
            Controls.Add(additiveCheckbox);
            Controls.Add(sdkpathLabel);
            Controls.Add(exportButton);
            Controls.Add(sizey);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(kindsingle);
            Controls.Add(kindseq);
            Controls.Add(label2);
            Controls.Add(sizex);
            Controls.Add(label1);
            Controls.Add(targetPath);
            Controls.Add(previewImage);
            MaximizeBox = false;
            MinimizeBox = false;
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
        private Label label4;
        private TextBox sizey;
        private Button exportButton;
        private LinkLabel sdkpathLabel;
        private CheckBox additiveCheckbox;
        private CheckBox blendBox;
    }
}
