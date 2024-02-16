namespace SynContext
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
            moneyTextBox = new TextBox();
            nameTextBox = new TextBox();
            percentTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            outputListBox = new ListBox();
            SuspendLayout();
            // 
            // moneyTextBox
            // 
            moneyTextBox.Location = new Point(12, 35);
            moneyTextBox.Name = "moneyTextBox";
            moneyTextBox.Size = new Size(125, 27);
            moneyTextBox.TabIndex = 0;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(143, 35);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(125, 27);
            nameTextBox.TabIndex = 1;
            // 
            // percentTextBox
            // 
            percentTextBox.Location = new Point(274, 35);
            percentTextBox.Name = "percentTextBox";
            percentTextBox.Size = new Size(125, 27);
            percentTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 12);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 4;
            label2.Text = "name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(274, 12);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 5;
            label3.Text = "percent:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 6;
            label1.Text = "money:";
            // 
            // outputListBox
            // 
            outputListBox.FormattingEnabled = true;
            outputListBox.Location = new Point(12, 88);
            outputListBox.Name = "outputListBox";
            outputListBox.Size = new Size(387, 124);
            outputListBox.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 253);
            Controls.Add(outputListBox);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(percentTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(moneyTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox moneyTextBox;
        private TextBox nameTextBox;
        private TextBox percentTextBox;
        private Label label2;
        private Label label3;
        private Label label1;
        private ListBox outputListBox;
    }
}
