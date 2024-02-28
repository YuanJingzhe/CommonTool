namespace LogFileTool
{
    partial class LogToolMainForm
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
            oriFilePathTextBox = new TextBox();
            selectFileBtn = new Button();
            keywordLabel = new Label();
            keywordsTextBox = new TextBox();
            getKeywordsLinesBtn = new Button();
            delKeywordsLinesBtn = new Button();
            outputPathLabel = new Label();
            outputFilePathTextBox = new TextBox();
            SuspendLayout();
            // 
            // oriFilePathTextBox
            // 
            oriFilePathTextBox.Location = new Point(124, 23);
            oriFilePathTextBox.Name = "oriFilePathTextBox";
            oriFilePathTextBox.Size = new Size(647, 27);
            oriFilePathTextBox.TabIndex = 0;
            oriFilePathTextBox.TextChanged += OriFilePathTextBoxChanged;
            // 
            // selectFileBtn
            // 
            selectFileBtn.Location = new Point(12, 21);
            selectFileBtn.Name = "selectFileBtn";
            selectFileBtn.Size = new Size(94, 29);
            selectFileBtn.TabIndex = 1;
            selectFileBtn.Text = "选择文件";
            selectFileBtn.UseVisualStyleBackColor = true;
            selectFileBtn.Click += OnSelectFileBtnClick;
            // 
            // keywordLabel
            // 
            keywordLabel.AutoSize = true;
            keywordLabel.Location = new Point(12, 69);
            keywordLabel.Name = "keywordLabel";
            keywordLabel.Size = new Size(54, 20);
            keywordLabel.TabIndex = 2;
            keywordLabel.Text = "关键词";
            // 
            // keywordsTextBox
            // 
            keywordsTextBox.Location = new Point(124, 69);
            keywordsTextBox.Name = "keywordsTextBox";
            keywordsTextBox.Size = new Size(647, 27);
            keywordsTextBox.TabIndex = 3;
            // 
            // getKeywordsLinesBtn
            // 
            getKeywordsLinesBtn.Location = new Point(125, 160);
            getKeywordsLinesBtn.Name = "getKeywordsLinesBtn";
            getKeywordsLinesBtn.Size = new Size(94, 29);
            getKeywordsLinesBtn.TabIndex = 4;
            getKeywordsLinesBtn.Text = "提取行";
            getKeywordsLinesBtn.UseVisualStyleBackColor = true;
            getKeywordsLinesBtn.Click += OnGetLinesBtnClick;
            // 
            // delKeywordsLinesBtn
            // 
            delKeywordsLinesBtn.Location = new Point(512, 160);
            delKeywordsLinesBtn.Name = "delKeywordsLinesBtn";
            delKeywordsLinesBtn.Size = new Size(94, 29);
            delKeywordsLinesBtn.TabIndex = 5;
            delKeywordsLinesBtn.Text = "删除行";
            delKeywordsLinesBtn.UseVisualStyleBackColor = true;
            delKeywordsLinesBtn.Click += OnDelLinesBtnClick;
            // 
            // outputPathLabel
            // 
            outputPathLabel.AutoSize = true;
            outputPathLabel.Location = new Point(12, 112);
            outputPathLabel.Name = "outputPathLabel";
            outputPathLabel.Size = new Size(69, 20);
            outputPathLabel.TabIndex = 6;
            outputPathLabel.Text = "输出路径";
            // 
            // outputFilePathTextBox
            // 
            outputFilePathTextBox.Location = new Point(125, 109);
            outputFilePathTextBox.Name = "outputFilePathTextBox";
            outputFilePathTextBox.Size = new Size(646, 27);
            outputFilePathTextBox.TabIndex = 7;
            outputFilePathTextBox.TextChanged += OutPutFilePathTextBoxChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(outputFilePathTextBox);
            Controls.Add(outputPathLabel);
            Controls.Add(delKeywordsLinesBtn);
            Controls.Add(getKeywordsLinesBtn);
            Controls.Add(keywordsTextBox);
            Controls.Add(keywordLabel);
            Controls.Add(selectFileBtn);
            Controls.Add(oriFilePathTextBox);
            Name = "LogToolMainForm";
            Text = "LogFileTool";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox oriFilePathTextBox;
        private Button selectFileBtn;
        private Label keywordLabel;
        private TextBox keywordsTextBox;
        private Button getKeywordsLinesBtn;
        private Button delKeywordsLinesBtn;
        private Label outputPathLabel;
        private TextBox outputFilePathTextBox;
    }
}
