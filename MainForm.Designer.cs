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
            this.addMaterialButton = new System.Windows.Forms.Button();
            this.edgeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(126, 12);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(82, 34);
            this.testButton.TabIndex = 1;
            this.testButton.Text = "Cutting без кромки";
            this.testButton.UseVisualStyleBackColor = true;
            // 
            // resultTextBox
            // 
            this.resultTextBox.AcceptsTab = true;
            this.resultTextBox.Location = new System.Drawing.Point(35, 52);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(649, 386);
            this.resultTextBox.TabIndex = 4;
            this.resultTextBox.Text = "";
            // 
            // addMaterialButton
            // 
            this.addMaterialButton.Location = new System.Drawing.Point(602, 12);
            this.addMaterialButton.Name = "addMaterialButton";
            this.addMaterialButton.Size = new System.Drawing.Size(82, 34);
            this.addMaterialButton.TabIndex = 6;
            this.addMaterialButton.Text = "Добавить материал";
            this.addMaterialButton.UseVisualStyleBackColor = true;
            // 
            // edgeButton
            // 
            this.edgeButton.Location = new System.Drawing.Point(35, 12);
            this.edgeButton.Name = "edgeButton";
            this.edgeButton.Size = new System.Drawing.Size(85, 34);
            this.edgeButton.TabIndex = 7;
            this.edgeButton.Text = "Cutting с кромкой";
            this.edgeButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.edgeButton);
            this.Controls.Add(this.addMaterialButton);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.testButton);
            this.Name = "MainForm";
            this.Text = "GetData";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.RichTextBox resultTextBox;
        private System.Windows.Forms.Button addMaterialButton;
        private System.Windows.Forms.Button edgeButton;
    }
}

