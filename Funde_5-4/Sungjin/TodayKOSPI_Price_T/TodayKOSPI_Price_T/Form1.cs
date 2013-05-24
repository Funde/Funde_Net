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
      
            string url = "http://finance.naver.com/sise/sise_index_time.nhn?code=KOSPI&thistime=20130524185901&page=";
           
          

        public Form1()
        {
            InitializeComponent();
            select_source();
        }

        


        string get_s()
        {

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.Default);



            string strHTML = reader.ReadToEnd();

            
            return strHTML;

            //reader.Dispose();

            //response.Close();

       
        }


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

        
  
    }
}
