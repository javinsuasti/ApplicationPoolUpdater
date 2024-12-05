namespace ApplicationPoolUpdater
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
            UserNameTBox = new TextBox();
            PasswordTBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            UpdateButton = new Button();
            label3 = new Label();
            textBoxResult = new TextBox();
            SuspendLayout();
            // 
            // UserNameTBox
            // 
            UserNameTBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UserNameTBox.Location = new Point(122, 31);
            UserNameTBox.Margin = new Padding(2);
            UserNameTBox.Name = "UserNameTBox";
            UserNameTBox.Size = new Size(264, 29);
            UserNameTBox.TabIndex = 0;
            // 
            // PasswordTBox
            // 
            PasswordTBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTBox.Location = new Point(122, 65);
            PasswordTBox.Margin = new Padding(2);
            PasswordTBox.Name = "PasswordTBox";
            PasswordTBox.PasswordChar = '*';
            PasswordTBox.Size = new Size(264, 29);
            PasswordTBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(27, 33);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 2;
            label1.Text = "UserName:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(27, 67);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // UpdateButton
            // 
            UpdateButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateButton.Location = new Point(390, 31);
            UpdateButton.Margin = new Padding(2);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(85, 63);
            UpdateButton.TabIndex = 4;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(27, 127);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 5;
            label3.Text = "Result:";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(122, 127);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(353, 129);
            textBoxResult.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 312);
            Controls.Add(textBoxResult);
            Controls.Add(label3);
            Controls.Add(UpdateButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PasswordTBox);
            Controls.Add(UserNameTBox);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "ApplicationPoolUpdater";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UserNameTBox;
        private TextBox PasswordTBox;
        private Label label1;
        private Label label2;
        private Button UpdateButton;
        private Label label3;
        private TextBox textBoxResult;
    }
}