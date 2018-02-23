namespace HelloWorld
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
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
            this.title_output = new System.Windows.Forms.Label();
            this.Text_HelloWorld = new System.Windows.Forms.Label();
            this.ShowWords = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title_output
            // 
            this.title_output.AutoSize = true;
            this.title_output.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.title_output.Location = new System.Drawing.Point(12, 28);
            this.title_output.Name = "title_output";
            this.title_output.Size = new System.Drawing.Size(99, 27);
            this.title_output.TabIndex = 1;
            this.title_output.Text = "Output : ";
            // 
            // Text_HelloWorld
            // 
            this.Text_HelloWorld.AutoSize = true;
            this.Text_HelloWorld.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Text_HelloWorld.Location = new System.Drawing.Point(117, 28);
            this.Text_HelloWorld.Name = "Text_HelloWorld";
            this.Text_HelloWorld.Size = new System.Drawing.Size(17, 27);
            this.Text_HelloWorld.TabIndex = 2;
            this.Text_HelloWorld.Text = " ";
            // 
            // ShowWords
            // 
            this.ShowWords.Location = new System.Drawing.Point(46, 85);
            this.ShowWords.Name = "ShowWords";
            this.ShowWords.Size = new System.Drawing.Size(166, 47);
            this.ShowWords.TabIndex = 3;
            this.ShowWords.Text = "Show";
            this.ShowWords.UseVisualStyleBackColor = true;
            this.ShowWords.Click += new System.EventHandler(this.ShowWords_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 144);
            this.Controls.Add(this.ShowWords);
            this.Controls.Add(this.Text_HelloWorld);
            this.Controls.Add(this.title_output);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label title_output;
        private System.Windows.Forms.Label Text_HelloWorld;
        private System.Windows.Forms.Button ShowWords;
    }
}

