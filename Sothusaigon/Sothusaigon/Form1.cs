using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Sothusaigon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
           
        }        
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            this.lstThumoi.MouseDown += new MouseEventHandler(this.lstThumoi_MouseDown);

        }

        private void mnuLoad_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("thumoi.txt");
            if (reader == null) return;
            string input = null;
            while ((input = reader.ReadLine()) != null)
            {
                lstThumoi.Items.Add(input);
            }
            reader.Close();
        }

        private void lstThumoi_MouseDown(object sender, MouseEventArgs e)
        {

            if (lstThumoi.Items.Count == 0)
                return;

            int index = lstThumoi.IndexFromPoint(e.X, e.Y);
            if (index != -1)
            {
                string s = lstThumoi.Items[index].ToString();
                DragDropEffects dde = DoDragDrop(s, DragDropEffects.All);
            }
        }

        private void lstdanhsach_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void lstdanhsach_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                string str = (string)e.Data.GetData(DataFormats.StringFormat);

                if (!lstdanhsach.Items.Contains(str))
                {
                    lstdanhsach.Items.Insert(0, str);
                }
                else
                {
                    MessageBox.Show("Không được trùng danh sách!","Chú ý!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }               
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = String.Format("Bây giờ là {0}:{1}:{2} ngày {3} tháng {4} năm {5}",
                            DateTime.Now.Hour,
                            DateTime.Now.Minute,
                            DateTime.Now.Second,
                            DateTime.Now.Day,
                            DateTime.Now.Month,
                            DateTime.Now.Year);
        }
    }
}
