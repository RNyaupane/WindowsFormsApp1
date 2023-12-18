namespace WindowsFormsApp1
{
    partial class Form2
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
            dataGridViewData = new DataGridView();
            buttonData = new Button();
            buttonAdoNet = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewData
            // 
            dataGridViewData.AllowUserToOrderColumns = true;
            dataGridViewData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewData.Location = new Point(95, 150);
            dataGridViewData.Name = "dataGridViewData";
            dataGridViewData.RowHeadersWidth = 51;
            dataGridViewData.RowTemplate.Height = 29;
            dataGridViewData.Size = new Size(645, 269);
            dataGridViewData.TabIndex = 0;
            // 
            // buttonData
            // 
            buttonData.Location = new Point(95, 75);
            buttonData.Name = "buttonData";
            buttonData.Size = new Size(94, 29);
            buttonData.TabIndex = 1;
            buttonData.Text = "Data";
            buttonData.UseVisualStyleBackColor = true;
            buttonData.Click += buttonData_Click;
            // 
            // buttonAdoNet
            // 
            buttonAdoNet.Location = new Point(269, 78);
            buttonAdoNet.Name = "buttonAdoNet";
            buttonAdoNet.Size = new Size(94, 29);
            buttonAdoNet.TabIndex = 2;
            buttonAdoNet.Text = "ADO.Net";
            buttonAdoNet.UseVisualStyleBackColor = true;
            buttonAdoNet.Click += buttonAdoNet_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAdoNet);
            Controls.Add(buttonData);
            Controls.Add(dataGridViewData);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewData;
        private Button buttonData;
        private Button buttonAdoNet;
    }
}