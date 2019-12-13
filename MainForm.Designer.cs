namespace GetDataFromDataBase
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.testButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.RichTextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(690, 24);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(82, 76);
            this.testButton.TabIndex = 1;
            this.testButton.Text = "Тест\r\n";
            this.testButton.UseVisualStyleBackColor = true;
            // 
            // resultTextBox
            // 
            this.resultTextBox.AcceptsTab = true;
            this.resultTextBox.Location = new System.Drawing.Point(35, 24);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(649, 414);
            this.resultTextBox.TabIndex = 4;
            this.resultTextBox.Text = "";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(690, 106);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(82, 76);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(690, 188);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(82, 76);
            this.copyButton.TabIndex = 6;
            this.copyButton.Text = "Скопировать в буфер";
            this.copyButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.testButton);
            this.Name = "MainForm";
            this.Text = "GetData";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.RichTextBox resultTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button copyButton;
    }
}

