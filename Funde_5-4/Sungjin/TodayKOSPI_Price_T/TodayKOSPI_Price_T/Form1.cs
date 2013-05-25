using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TodayKOSPI_Price_T
{

    
    public partial class Form1 : Form
    {

        //
        string url = "http://finance.naver.com/sise/sise_index_time.nhn?code=KOSPI&thistime=";

        //
        DateTime date = DateTime.Today;
        Page_UpDn page = new Page_UpDn();
        

        public Form1()
        {
            InitializeComponent();
            
        }

        //HTML 소스 문자열 변수로 추출
        string get_s()
        {

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url + date.ToString("yyyyMMdd") + "185901&page=" + page.i.ToString());

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.Default);



            string strHTML = reader.ReadToEnd();

            //reader.Dispose();

            //response.Close();
       

            return strHTML;

         }


        //정규화를 이용하여 소스 뷰에 출력
        void select_source()
        {

            string key = "<td class=\"Date\">(?<a>.*?)</td>.*?<td class=\"number_1\">(?<b>.*?)</td>";
            Regex re = new Regex(key, RegexOptions.IgnoreCase | RegexOptions.Singleline);
            for (Match m = re.Match(get_s()); m.Success; m = m.NextMatch())
            {
                string a = m.Groups["a"].Value;
                string b = m.Groups["b"].Value;
                dataGridView1.Rows.Add(a, b);
            }

        }


        //뷰 초기화
        void blank()
        {
            dataGridView1.Rows.Clear();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            page.Mius_P();
            blank();
            select_source();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            page.Puls_P();
            blank();
            select_source();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            date = dateTimePicker1.Value;
            blank();
            select_source();

        }


        
  
    }


    public class Page_UpDn
    {

        public int i = 1;

        public void Puls_P()
        {
            i++;
        }
        public void Mius_P()
        {
            if (i > 1)
                i--;
        }


    }



}
