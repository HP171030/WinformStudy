using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        static string documentDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string path = $@"{documentDir}\TestClientFolder";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load( object sender, EventArgs e )

        {   //폴더가 있는지 없는지만으로 게임이 설치됐는지 판단하기에는 부족함
            //레지스트리를 사용하는지?
            MessageBox.Show("로드");
            if (Directory.Exists(path) && File.Exists($@"{path}\TestClientFile.txt"))
            {
                RefreshButton();
            }
            else
            {
                MessageBox.Show("실패");
            }
        }
        void RefreshButton()
        {
            InstallClinetTest.Text = "StartClient Test";
        }
        private void button1_Click( object sender, EventArgs e )
        {
            Form1 windowForm1 = new Form1();
            windowForm1.Show();
            Hide();

        }

        private void button2_Click( object sender, EventArgs e )
        {
            Form3 windowForm3 = new Form3();
            windowForm3.Show();
            Hide();
        }

        private void linkLabel1_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {

        }

        private void button3_Click( object sender, EventArgs e )
        {
            /*
             * 디렉토리에 프로그램을 설치함 (이때 디렉토리가 확정됨)
             * 해당 디렉토리 가져오고 프로그램 실행
            */

            if(File.Exists($@"{path}\TestClientFile.txt"))
            {
                MessageBox.Show("실행 테스트");
                Process.Start("notepad.exe",$@"{path}\TestClientFile.txt");

            }
            else
            {
                using ( FolderBrowserDialog fbd = new FolderBrowserDialog() )
                {
                    fbd.SelectedPath = documentDir;
                    fbd.Description = "설치할 디렉토리 설정";

                    if ( fbd.ShowDialog() == DialogResult.OK )
                    {
                        string folderName = "TestClientFolder";
                        string path = Path.Combine(fbd.SelectedPath, folderName);
                        if ( !Directory.Exists(path) )
                        {
                            Directory.CreateDirectory(path);
                        }
                        string filePath = Path.Combine(path, "TestClientFile.txt");
                        using ( StreamWriter writer = new StreamWriter(filePath) )  //테스트용으로 텍스트파일 생성
                        {
                            
                            writer.WriteLine("Client Test");
                            RefreshButton();
                            MessageBox.Show("설치 완료");
                        }

                    }
                }
            }
            



        }
    }
}
