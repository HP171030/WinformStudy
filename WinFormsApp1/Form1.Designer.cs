namespace WinFormsApp1
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainLabel = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            labelContain = new Label();
            labelEqual = new Label();
            labelLength = new Label();
            labelReplace = new Label();
            labelSplit = new Label();
            labelSubstring = new Label();
            labelToLower = new Label();
            labelToUpper = new Label();
            labelTrim = new Label();
            labelSplit2 = new Label();
            SuspendLayout();
            // 
            // mainLabel
            // 
            mainLabel.AutoSize = true;
            mainLabel.Location = new Point(94, 57);
            mainLabel.Name = "mainLabel";
            mainLabel.Size = new Size(178, 20);
            mainLabel.TabIndex = 0;
            mainLabel.Text = "   TestText ,TestTText2    ";
            mainLabel.Click +=  label1_Click ;
            // 
            // button1
            // 
            button1.Location = new Point(362, 42);
            button1.Name = "button1";
            button1.Size = new Size(111, 50);
            button1.TabIndex = 1;
            button1.Text = "TextApply";
            button1.UseVisualStyleBackColor = true;
            button1.Click +=  button1_Click ;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 184);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 2;
            label2.Text = "Contain";
            label2.Click +=  label2_Click ;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 226);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 3;
            label3.Text = "Equal";
            label3.Click +=  label3_Click ;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(94, 268);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 4;
            label4.Text = "Length";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(94, 316);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 5;
            label5.Text = "Replace";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(94, 361);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 6;
            label6.Text = "Split";
            label6.Click +=  label6_Click ;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(94, 406);
            label7.Name = "label7";
            label7.Size = new Size(73, 20);
            label7.TabIndex = 7;
            label7.Text = "Substring";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(94, 455);
            label8.Name = "label8";
            label8.Size = new Size(66, 20);
            label8.TabIndex = 8;
            label8.Text = "ToLower";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(94, 498);
            label9.Name = "label9";
            label9.Size = new Size(68, 20);
            label9.TabIndex = 9;
            label9.Text = "ToUpper";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(94, 543);
            label10.Name = "label10";
            label10.Size = new Size(39, 20);
            label10.TabIndex = 10;
            label10.Text = "Trim";
            // 
            // labelContain
            // 
            labelContain.AutoSize = true;
            labelContain.Location = new Point(227, 184);
            labelContain.Name = "labelContain";
            labelContain.Size = new Size(15, 20);
            labelContain.TabIndex = 11;
            labelContain.Text = "-";
            // 
            // labelEqual
            // 
            labelEqual.AutoSize = true;
            labelEqual.Location = new Point(227, 226);
            labelEqual.Name = "labelEqual";
            labelEqual.Size = new Size(15, 20);
            labelEqual.TabIndex = 12;
            labelEqual.Text = "-";
            // 
            // labelLength
            // 
            labelLength.AutoSize = true;
            labelLength.Location = new Point(227, 268);
            labelLength.Name = "labelLength";
            labelLength.Size = new Size(15, 20);
            labelLength.TabIndex = 13;
            labelLength.Text = "-";
            // 
            // labelReplace
            // 
            labelReplace.AutoSize = true;
            labelReplace.Location = new Point(227, 316);
            labelReplace.Name = "labelReplace";
            labelReplace.Size = new Size(15, 20);
            labelReplace.TabIndex = 14;
            labelReplace.Text = "-";
            // 
            // labelSplit
            // 
            labelSplit.AutoSize = true;
            labelSplit.Location = new Point(227, 361);
            labelSplit.Name = "labelSplit";
            labelSplit.Size = new Size(15, 20);
            labelSplit.TabIndex = 15;
            labelSplit.Text = "-";
            // 
            // labelSubstring
            // 
            labelSubstring.AutoSize = true;
            labelSubstring.Location = new Point(227, 406);
            labelSubstring.Name = "labelSubstring";
            labelSubstring.Size = new Size(15, 20);
            labelSubstring.TabIndex = 16;
            labelSubstring.Text = "-";
            // 
            // labelToLower
            // 
            labelToLower.AutoSize = true;
            labelToLower.Location = new Point(227, 455);
            labelToLower.Name = "labelToLower";
            labelToLower.Size = new Size(15, 20);
            labelToLower.TabIndex = 17;
            labelToLower.Text = "-";
            // 
            // labelToUpper
            // 
            labelToUpper.AutoSize = true;
            labelToUpper.Location = new Point(227, 498);
            labelToUpper.Name = "labelToUpper";
            labelToUpper.Size = new Size(15, 20);
            labelToUpper.TabIndex = 18;
            labelToUpper.Text = "-";
            // 
            // labelTrim
            // 
            labelTrim.AutoSize = true;
            labelTrim.Location = new Point(227, 543);
            labelTrim.Name = "labelTrim";
            labelTrim.Size = new Size(15, 20);
            labelTrim.TabIndex = 19;
            labelTrim.Text = "-";
            // 
            // labelSplit2
            // 
            labelSplit2.AutoSize = true;
            labelSplit2.Location = new Point(287, 361);
            labelSplit2.Name = "labelSplit2";
            labelSplit2.Size = new Size(15, 20);
            labelSplit2.TabIndex = 20;
            labelSplit2.Text = "-";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 628);
            Controls.Add(labelSplit2);
            Controls.Add(labelTrim);
            Controls.Add(labelToUpper);
            Controls.Add(labelToLower);
            Controls.Add(labelSubstring);
            Controls.Add(labelSplit);
            Controls.Add(labelReplace);
            Controls.Add(labelLength);
            Controls.Add(labelEqual);
            Controls.Add(labelContain);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(mainLabel);
            Name = "Form1";
            Text = "Form1";
            Load +=  Form1_Load ;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label mainLabel;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label labelContain;
        private Label labelEqual;
        private Label labelLength;
        private Label labelReplace;
        private Label labelSplit;
        private Label labelSubstring;
        private Label labelToLower;
        private Label labelToUpper;
        private Label labelTrim;
        private Label labelSplit2;
    }
}
