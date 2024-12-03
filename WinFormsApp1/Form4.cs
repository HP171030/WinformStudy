using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        MySqlConnection conn;
        public Form4()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            conn = DBConnectManager.GetConnection();                //SQL 커넥션 가져오기
            MySqlCommand cmd = new MySqlCommand("SELECT DISTINCT mem_id FROM member", conn); //쿼리문 추가
            using ( MySqlDataReader dr = cmd.ExecuteReader() )
            {
                                                       //쿼리문 데이터리더에 바인딩
                while ( dr.Read() )                                     //다 읽을때까지
                {
                    MemberBox.Items.Add(dr ["mem_id"]);      //콤보박스에 하나씩 추가
                }
            }

        }
        private void comboBox1_SelectedIndexChanged( object sender, EventArgs e )
        {

        }

        private void mem_id_Click( object sender, EventArgs e )
        {

        }

        private void label2_Click( object sender, EventArgs e )
        {

        }

        private void button1_Click( object sender, EventArgs e )
        {
            try
            {
                string itName = itemName.Text;
                string catName = categoryName.Text;
                if ( !int.TryParse(priceName.Text, out int price) )
                {
                    MessageBox.Show("가격은 숫자만 입력해주세요");
                    return;
                }
                if ( !int.TryParse(amountName.Text, out int amount) )
                {
                    MessageBox.Show("양은 숫자만 입력해주세요");
                    return;
                }

                string query = "INSERT INTO buy (mem_id,prod_name,group_name,price,amount)" +
                    "           VALUES(@memId,@prodName,@category,@price,@amount)";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@memId", MemberBox.Text);
                cmd.Parameters.AddWithValue("@prodName", itName);
                cmd.Parameters.AddWithValue("@category", catName);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@amount", amount);

                if ( cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("데이터가 추가되었습니다");
                }
                else
                {
                    MessageBox.Show("데이터 추가 실패");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"오류 :  {ex.Message}");
            }
        }
    }
}
