namespace WinFormsApp1
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
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
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
            button1 = new Button();
            button2 = new Button();
            InstallClinetTest = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(68, 33);
            button1.Name = "button1";
            button1.Size = new Size(113, 56);
            button1.TabIndex = 0;
            button1.Text = "Form1 Activate";
            button1.UseVisualStyleBackColor = true;
            button1.Click +=  button1_Click ;
            // 
            // button2
            // 
            button2.Location = new Point(68, 106);
            button2.Name = "button2";
            button2.Size = new Size(113, 56);
            button2.TabIndex = 1;
            button2.Text = "DB Active";
            button2.UseVisualStyleBackColor = true;
            button2.Click +=  button2_Click ;
            // 
            // InstallClinetTest
            // 
            InstallClinetTest.Location = new Point(68, 180);
            InstallClinetTest.Name = "InstallClinetTest";
            InstallClinetTest.Size = new Size(113, 56);
            InstallClinetTest.TabIndex = 2;
            InstallClinetTest.Text = "Install Client Test";
            InstallClinetTest.UseVisualStyleBackColor = true;
            InstallClinetTest.Click +=  button3_Click ;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(InstallClinetTest);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            Load +=  Form2_Load ;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button InstallClinetTest;
    }
}