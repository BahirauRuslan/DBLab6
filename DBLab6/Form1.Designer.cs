namespace DBLab6
{
    public partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView mainDataGridView;
        private System.Windows.Forms.DataGridView secondDataGridView;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.ListBox leftListBox;
        private System.Windows.Forms.ListBox rightListBox;

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
            this.mainDataGridView = new System.Windows.Forms.DataGridView();
            this.secondDataGridView = new System.Windows.Forms.DataGridView();
            this.clearButton = new System.Windows.Forms.Button();
            this.readButton = new System.Windows.Forms.Button();
            this.leftListBox = new System.Windows.Forms.ListBox();
            this.rightListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainDataGridView
            // 
            this.mainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDataGridView.Location = new System.Drawing.Point(13, 13);
            this.mainDataGridView.Name = "mainDataGridView";
            this.mainDataGridView.Size = new System.Drawing.Size(317, 222);
            this.mainDataGridView.TabIndex = 0;
            // 
            // secondDataGridView
            // 
            this.secondDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.secondDataGridView.Location = new System.Drawing.Point(336, 13);
            this.secondDataGridView.Name = "secondDataGridView";
            this.secondDataGridView.Size = new System.Drawing.Size(249, 222);
            this.secondDataGridView.TabIndex = 1;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(429, 313);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(510, 313);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(75, 23);
            this.readButton.TabIndex = 3;
            this.readButton.Text = "Читать";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.ReadButton_Click);
            // 
            // leftListBox
            // 
            this.leftListBox.FormattingEnabled = true;
            this.leftListBox.Items.AddRange(new object[] {
            "Фамилия начинается на \"Б\"",
            "Номер группы меньше 10704000",
            "Фамилия начинается на \"А\"",
            "Номер группы больше 10701111"});
            this.leftListBox.Location = new System.Drawing.Point(13, 241);
            this.leftListBox.Name = "leftListBox";
            this.leftListBox.Size = new System.Drawing.Size(186, 95);
            this.leftListBox.TabIndex = 4;
            // 
            // rightListBox
            // 
            this.rightListBox.FormattingEnabled = true;
            this.rightListBox.Items.AddRange(new object[] {
            "Фамилия начинается на \"Б\"",
            "Номер группы меньше 10704000",
            "Фамилия начинается на \"А\"",
            "Номер группы больше 10701111"});
            this.rightListBox.Location = new System.Drawing.Point(205, 241);
            this.rightListBox.Name = "rightListBox";
            this.rightListBox.Size = new System.Drawing.Size(186, 95);
            this.rightListBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 347);
            this.Controls.Add(this.rightListBox);
            this.Controls.Add(this.leftListBox);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.secondDataGridView);
            this.Controls.Add(this.mainDataGridView);
            this.Name = "Form1";
            this.Text = "Лаб. 6, Руслан, гр. 10701116";
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}