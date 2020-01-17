namespace GetDataFromDataBase
{
    partial class AddMaterialForm
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
            this.materialGridView = new System.Windows.Forms.DataGridView();
            this.materialColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.materialGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // materialGridView
            // 
            this.materialGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.materialColumn,
            this.numberColumn});
            this.materialGridView.Location = new System.Drawing.Point(12, 12);
            this.materialGridView.Name = "materialGridView";
            this.materialGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.materialGridView.Size = new System.Drawing.Size(344, 282);
            this.materialGridView.TabIndex = 1;
            // 
            // materialColumn
            // 
            this.materialColumn.HeaderText = "Материал";
            this.materialColumn.Name = "materialColumn";
            this.materialColumn.Width = 200;
            // 
            // numberColumn
            // 
            this.numberColumn.HeaderText = "Номер материала";
            this.numberColumn.Name = "numberColumn";
            // 
            // AddMaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialGridView);
            this.Name = "AddMaterialForm";
            this.Text = "AddMaterialForm";
            ((System.ComponentModel.ISupportInitialize)(this.materialGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView materialGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberColumn;
    }
}