namespace WinFormsApp1
{
    partial class Form3
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            isConnectLabel = new Label();
            ( ( System.ComponentModel.ISupportInitialize )dataGridView1 ).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("맑은 고딕", 13.8F, FontStyle.Bold, GraphicsUnit.Point,   129);
            label1.Location = new Point(31, 9);
            label1.Name = "label1";
            label1.Size = new Size(46, 31);
            label1.TabIndex = 0;
            label1.Text = "DB";
            label1.Click +=  label1_Click ;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 43);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(591, 365);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick +=  dataGridView1_CellContentClick ;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("맑은 고딕", 13F);
            label2.Location = new Point(641, 63);
            label2.Name = "label2";
            label2.Size = new Size(79, 30);
            label2.TabIndex = 2;
            label2.Text = "Search";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(641, 110);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("맑은 고딕", 10.2F, FontStyle.Bold, GraphicsUnit.Point,   129);
            button1.Location = new Point(641, 379);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = true;
            // 
            // isConnectLabel
            // 
            isConnectLabel.AutoSize = true;
            isConnectLabel.Location = new Point(701, 421);
            isConnectLabel.Name = "isConnectLabel";
            isConnectLabel.Size = new Size(98, 20);
            isConnectLabel.TabIndex = 5;
            isConnectLabel.Text = "ISCONNECT?";
            isConnectLabel.Click +=  isConnectLabel_Click ;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(isConnectLabel);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ( ( System.ComponentModel.ISupportInitialize )dataGridView1 ).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private Label isConnectLabel;
    }
}