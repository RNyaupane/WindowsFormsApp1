namespace WindowsFormsApp1
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
            textBoxFirstNumber = new TextBox();
            buttonAdd = new Button();
            textBoxSecondNumber = new TextBox();
            label1 = new Label();
            label2 = new Label();
            labelResult = new Label();
            SuspendLayout();
            // 
            // textBoxFirstNumber
            // 
            textBoxFirstNumber.Location = new Point(188, 65);
            textBoxFirstNumber.Name = "textBoxFirstNumber";
            textBoxFirstNumber.Size = new Size(233, 27);
            textBoxFirstNumber.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(188, 158);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textBoxSecondNumber
            // 
            textBoxSecondNumber.Location = new Point(188, 102);
            textBoxSecondNumber.Name = "textBoxSecondNumber";
            textBoxSecondNumber.Size = new Size(233, 27);
            textBoxSecondNumber.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 68);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 3;
            label1.Text = "First number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 105);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 4;
            label2.Text = "Second number";
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(188, 223);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(49, 20);
            labelResult.TabIndex = 5;
            labelResult.Text = "Result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelResult);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxSecondNumber);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxFirstNumber);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxFirstNumber;
        private Button buttonAdd;
        private TextBox textBoxSecondNumber;
        private Label label1;
        private Label label2;
        private Label labelResult;
    }
}