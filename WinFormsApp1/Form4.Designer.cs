namespace WinFormsApp1
{
    partial class Form4
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
            mem_id = new Label();
            button1 = new Button();
            MemberBox = new ComboBox();
            itemName = new TextBox();
            label2 = new Label();
            categoryName = new TextBox();
            label3 = new Label();
            priceName = new TextBox();
            label4 = new Label();
            amountName = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // mem_id
            // 
            mem_id.AutoSize = true;
            mem_id.Location = new Point(58, 43);
            mem_id.Name = "mem_id";
            mem_id.Size = new Size(66, 20);
            mem_id.TabIndex = 0;
            mem_id.Text = "Member";
            mem_id.Click +=  mem_id_Click ;
            // 
            // button1
            // 
            button1.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point,   129);
            button1.Location = new Point(144, 397);
            button1.Name = "button1";
            button1.Size = new Size(167, 63);
            button1.TabIndex = 1;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = true;
            button1.Click +=  button1_Click ;
            // 
            // MemberBox
            // 
            MemberBox.FormattingEnabled = true;
            MemberBox.Location = new Point(260, 40);
            MemberBox.Name = "MemberBox";
            MemberBox.Size = new Size(151, 28);
            MemberBox.TabIndex = 2;
            MemberBox.SelectedIndexChanged +=  comboBox1_SelectedIndexChanged ;
            // 
            // itemName
            // 
            itemName.Location = new Point(260, 127);
            itemName.Name = "itemName";
            itemName.Size = new Size(151, 27);
            itemName.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 127);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 5;
            label2.Text = "Item Name";
            label2.Click +=  label2_Click ;
            // 
            // categoryName
            // 
            categoryName.Location = new Point(260, 185);
            categoryName.Name = "categoryName";
            categoryName.Size = new Size(151, 27);
            categoryName.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 185);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 7;
            label3.Text = "Category";
            // 
            // priceName
            // 
            priceName.Location = new Point(260, 244);
            priceName.Name = "priceName";
            priceName.Size = new Size(151, 27);
            priceName.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 244);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 9;
            label4.Text = "Price";
            // 
            // amountName
            // 
            amountName.Location = new Point(260, 302);
            amountName.Name = "amountName";
            amountName.Size = new Size(151, 27);
            amountName.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 302);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 11;
            label5.Text = "Amount";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 483);
            Controls.Add(amountName);
            Controls.Add(label5);
            Controls.Add(priceName);
            Controls.Add(label4);
            Controls.Add(categoryName);
            Controls.Add(label3);
            Controls.Add(itemName);
            Controls.Add(label2);
            Controls.Add(MemberBox);
            Controls.Add(button1);
            Controls.Add(mem_id);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label mem_id;
        private Button button1;
        private ComboBox MemberBox;
        private TextBox itemName;
        private Label label2;
        private TextBox categoryName;
        private Label label3;
        private TextBox priceName;
        private Label label4;
        private TextBox amountName;
        private Label label5;
    }
}