namespace Q1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.nweGameButton = new System.Windows.Forms.Button();
            this.answerLabel = new System.Windows.Forms.Label();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.answerButton = new System.Windows.Forms.Button();
            this.HintLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nweGameButton
            // 
            this.nweGameButton.Location = new System.Drawing.Point(372, 105);
            this.nweGameButton.Name = "nweGameButton";
            this.nweGameButton.Size = new System.Drawing.Size(75, 23);
            this.nweGameButton.TabIndex = 0;
            this.nweGameButton.Text = "新遊戲";
            this.nweGameButton.UseVisualStyleBackColor = true;
            this.nweGameButton.Click += new System.EventHandler(this.nweGameButton_Click);
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Location = new System.Drawing.Point(218, 110);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(29, 12);
            this.answerLabel.TabIndex = 1;
            this.answerLabel.Text = "解答";
            // 
            // answerTextBox
            // 
            this.answerTextBox.Location = new System.Drawing.Point(194, 153);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(100, 22);
            this.answerTextBox.TabIndex = 2;
            // 
            // answerButton
            // 
            this.answerButton.Location = new System.Drawing.Point(372, 212);
            this.answerButton.Name = "answerButton";
            this.answerButton.Size = new System.Drawing.Size(75, 23);
            this.answerButton.TabIndex = 0;
            this.answerButton.Text = "判斷";
            this.answerButton.UseVisualStyleBackColor = true;
            this.answerButton.Click += new System.EventHandler(this.answerButton_Click);
            // 
            // HintLabel
            // 
            this.HintLabel.AutoSize = true;
            this.HintLabel.Location = new System.Drawing.Point(214, 212);
            this.HintLabel.Name = "HintLabel";
            this.HintLabel.Size = new System.Drawing.Size(33, 12);
            this.HintLabel.TabIndex = 1;
            this.HintLabel.Text = "0A0B";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 514);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.HintLabel);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.answerButton);
            this.Controls.Add(this.nweGameButton);
            this.Name = "Form1";
            this.Text = "猜猜數字";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nweGameButton;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Button answerButton;
        private System.Windows.Forms.Label HintLabel;
    }
}

