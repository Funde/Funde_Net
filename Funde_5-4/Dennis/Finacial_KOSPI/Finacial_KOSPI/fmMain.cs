using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Net;
using System.IO;


namespace Finacial_KOSPI
{
    public partial class fmMain : Form
    {
        public fmMain()
        {
            InitializeComponent();

            dateTimePicker1.CustomFormat = "yyyyMMdd";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
        }

        private void b_HtmlLoad_Click(object sender, EventArgs e)
        {
            
            const string htmldate = "<td class=\"date\">";
            const string htmlnumber = "<td class=\"number_1\">";
            const string htmlend    = "</td>";
            String dates = "";
            dates = dateTimePicker1.Text;
            dataGridView1.Rows.Clear();
            for (int i = 1; i <= 60; i++)
            {
                String vURL = "http://finance.naver.com/sise/sise_index_time.nhn?code=KOSPI&thistime="+ dates +"185901&page=" + i.ToString();
                HttpWebRequest oRequest = (HttpWebRequest)WebRequest.Create(vURL);
                HttpWebResponse oGetResponse = (HttpWebResponse)oRequest.GetResponse();
                StreamReader oStreamReader = new StreamReader(oGetResponse.GetResponseStream(), Encoding.GetEncoding("ks_c_5601-1987"), true);
                string strHtml = oStreamReader.ReadToEnd();
                int j = 0;
                
                while((j = strHtml.IndexOf(htmldate, j)) != -1)
                {
                    int startpos, endpos;
                    string[] context = new string[2];
                    startpos    = j + htmldate.Length;
                    endpos      = strHtml.IndexOf(htmlend, j);
                    
                    context[0] = strHtml.Substring(startpos, endpos-startpos);
                    
                    j = endpos;

                    j = strHtml.IndexOf(htmlnumber, j);
                    startpos    = j + htmlnumber.Length;
                    endpos      = strHtml.IndexOf(htmlend, j);


                    context[1] = strHtml.Substring(startpos, endpos - startpos);
                    dataGridView1.Rows.Add(context);
                }
            }
            
//dataGridView1.Row
            
        }
    }
}
