﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        string sqlAdr = "Server=localhost;Port=3306;Database=market_db;Uid=root;password=0000;";
        public Form3()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form3_Load);
        }

        void Form3_Load( object sender, EventArgs e )
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(sqlAdr);
                conn.Open();
                if ( conn.State == ConnectionState.Open )
                {
                    isConnectLabel.Text = "CONNECT";  // 연결 성공 메시지 표시
                    MessageBox.Show("연결햇음");      // 사용자에게 연결 성공 메시지 표시

                    // MySQL 데이터베이스에서 데이터를 가져오기 위한 SQL 명령어
                    MySqlCommand cmd_db = new MySqlCommand("SELECT * FROM buy", conn);

                    // DataTable을 사용하여 데이터를 저장
                    DataTable dt = new DataTable();

                    // MySqlDataAdapter를 사용하여 SQL 쿼리를 실행하고 결과를 DataTable에 채운다
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = cmd_db;
                    sda.Fill(dt);  // DataTable에 데이터 채우기

                    // BindingSource를 사용하여 DataGridView에 데이터 바인딩
                    BindingSource bsrc = new BindingSource();
                    bsrc.DataSource = dt;
                    dataGridView1.DataSource = bsrc;  // DataGridView에 데이터 바인딩

                    sda.Update(dt);  // 데이터가 변경되면 업데이트, 하지만 SELECT만 수행하므로 이 부분은 필요하지 않을 수 있음

                }
                else
                {
                    isConnectLabel.Text = "DISCONNECT";
                }
            }
            catch(MySqlException ex )
            {
                MessageBox.Show(ex.Message);
                isConnectLabel.Text = "Connect Error";
            }
        }
        private void label1_Click( object sender, EventArgs e )
        {

        }

        private void label3_Click( object sender, EventArgs e )
        {

        }

        private void dataGridView1_CellContentClick( object sender, DataGridViewCellEventArgs e )
        {

        }

        private void isConnectLabel_Click( object sender, EventArgs e )
        {

        }
    }
}
