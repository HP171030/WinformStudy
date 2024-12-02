using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string sqlAdr = "Server=localhost;Database=market_db;Uid=root;password=0000;";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load( object sender, EventArgs e )
        {

        }

        private void label1_Click( object sender, EventArgs e )
        {
            
        }

        private void button1_Click( object sender, EventArgs e )
        {
            labelContain.Text = mainLabel.Text.Contains("TestText").ToString();     //포함되어있는게 맞는지 아닌지?.
            labelEqual.Text = mainLabel.Text.Equals("TestText").ToString();
            labelLength.Text = mainLabel.Text.Length.ToString();
            labelReplace.Text = mainLabel.Text.Replace("Text", "ReplacedText");
            string [] splited = mainLabel.Text.Split(',');
            labelSplit.Text = splited [0];
            labelSplit2.Text = splited [1];
            labelSubstring.Text = mainLabel.Text.Substring(0, 5);
            labelToLower.Text = mainLabel.Text.ToLower();
            labelToUpper.Text = mainLabel.Text.ToUpper();
            labelTrim.Text = mainLabel.Text.Trim();
        }

        private void label2_Click( object sender, EventArgs e )
        {

        }

        private void label3_Click( object sender, EventArgs e )
        {

        }

        private void label6_Click( object sender, EventArgs e )
        {

        }
    }
}
