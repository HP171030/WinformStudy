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
            MemberInput = new TextBox();
            Delete = new Button();
            isConnectLabel = new Label();
            label3 = new Label();
            Add = new Button();
            refresh = new Button();
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
            label2.Location = new Point(641, 43);
            label2.Name = "label2";
            label2.Size = new Size(97, 30);
            label2.TabIndex = 2;
            label2.Text = "Member";
            label2.Click +=  label2_Click ;
            // 
            // MemberInput
            // 
            MemberInput.Location = new Point(641, 86);
            MemberInput.Name = "MemberInput";
            MemberInput.Size = new Size(125, 27);
            MemberInput.TabIndex = 3;
            // 
            // Delete
            // 
            Delete.Font = new Font("맑은 고딕", 10.2F, FontStyle.Bold, GraphicsUnit.Point,   129);
            Delete.Location = new Point(660, 379);
            Delete.Name = "Delete";
            Delete.Size = new Size(94, 29);
            Delete.TabIndex = 4;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click +=  Delete_Click ;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("맑은 고딕", 13F);
            label3.Location = new Point(660, 187);
            label3.Name = "label3";
            label3.Size = new Size(0, 30);
            label3.TabIndex = 6;
            // 
            // Add
            // 
            Add.Font = new Font("맑은 고딕", 10.2F, FontStyle.Bold, GraphicsUnit.Point,   129);
            Add.Location = new Point(660, 344);
            Add.Name = "Add";
            Add.Size = new Size(94, 29);
            Add.TabIndex = 7;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click +=  Add_Click ;
            // 
            // refresh
            // 
            refresh.Font = new Font("맑은 고딕", 10.2F, FontStyle.Bold, GraphicsUnit.Point,   129);
            refresh.Location = new Point(660, 296);
            refresh.Name = "refresh";
            refresh.Size = new Size(94, 29);
            refresh.TabIndex = 8;
            refresh.Text = "Refresh";
            refresh.UseVisualStyleBackColor = true;
            refresh.Click +=  refresh_Click ;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(refresh);
            Controls.Add(Add);
            Controls.Add(label3);
            Controls.Add(isConnectLabel);
            Controls.Add(Delete);
            Controls.Add(MemberInput);
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
        private TextBox MemberInput;
        private Button Delete;
        private Label isConnectLabel;
        private Label label3;
        private Button Add;
        private Button refresh;
    }
}