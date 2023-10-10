namespace ConfigurationManagerDemo
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
            lblSetting1 = new Label();
            lblSetting2 = new Label();
            btn1 = new Button();
            btn2 = new Button();
            SuspendLayout();
            // 
            // lblSetting1
            // 
            lblSetting1.AutoSize = true;
            lblSetting1.Location = new Point(12, 9);
            lblSetting1.Name = "lblSetting1";
            lblSetting1.Size = new Size(63, 15);
            lblSetting1.TabIndex = 0;
            lblSetting1.Text = "lblSetting1";
            lblSetting1.Click += label1_Click;
            // 
            // lblSetting2
            // 
            lblSetting2.AutoSize = true;
            lblSetting2.Location = new Point(12, 24);
            lblSetting2.Name = "lblSetting2";
            lblSetting2.Size = new Size(63, 15);
            lblSetting2.TabIndex = 1;
            lblSetting2.Text = "lblSetting2";
            lblSetting2.Click += label2_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Algerian", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn1.Location = new Point(12, 63);
            btn1.Name = "btn1";
            btn1.Size = new Size(255, 64);
            btn1.TabIndex = 2;
            btn1.Text = "Connect to Northwind";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += button1_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Algerian", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn2.Location = new Point(12, 133);
            btn2.Name = "btn2";
            btn2.Size = new Size(255, 64);
            btn2.TabIndex = 3;
            btn2.Text = "Connect to GEX2024";
            btn2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(lblSetting2);
            Controls.Add(lblSetting1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSetting1;
        private Label lblSetting2;
        private Button btn1;
        private Button btn2;
    }
}