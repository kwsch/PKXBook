using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace PKXBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] filepaths = new string[1];
        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                filepaths = Directory.GetFiles(fbd.SelectedPath, "*.*", SearchOption.AllDirectories);
                textBox1.Text = fbd.SelectedPath;
                dataGridView1.DoubleBuffered(true);
                button2.Enabled = true;
                button3.Enabled = true;
            }
        }
        private void loaddata()
        {
            this.dataGridView1.DataSource = null;
            DataTable table = new DataTable();
            table.Columns.Add("File", typeof(int));
            for (int i = 0x90; i <= 0xAF; i++)
            {
                table.Columns.Add(i.ToString("X2"), typeof(string));
            }
            table.Columns.Add("Filename", typeof(string));

            for (int i = 0; i < filepaths.Length; i++)
            {
                string path = filepaths[i];
                string name = Path.GetFileNameWithoutExtension(path);
                string ext = Path.GetExtension(path);
                byte[] b = File.ReadAllBytes(path);
                if ((ext == ".pk6") && (b.Length == 232))
                {
                    table.Rows.Add(i,
                        b[0x90].ToString("X2"),
                        b[0x91].ToString("X2"),
                        b[0x92].ToString("X2"),
                        b[0x93].ToString("X2"),
                        b[0x94].ToString("X2"),
                        b[0x95].ToString("X2"),
                        b[0x96].ToString("X2"),
                        b[0x97].ToString("X2"),
                        b[0x98].ToString("X2"),
                        b[0x99].ToString("X2"),
                        b[0x9A].ToString("X2"),
                        b[0x9B].ToString("X2"),
                        b[0x9C].ToString("X2"),
                        b[0x9D].ToString("X2"),
                        b[0x9E].ToString("X2"),
                        b[0x9F].ToString("X2"),
                        b[0xA0].ToString("X2"),
                        b[0xA1].ToString("X2"),
                        b[0xA2].ToString("X2"),
                        b[0xA3].ToString("X2"),
                        b[0xA4].ToString("X2"),
                        b[0xA5].ToString("X2"),
                        b[0xA6].ToString("X2"),
                        b[0xA7].ToString("X2"),
                        b[0xA8].ToString("X2"),
                        b[0xA9].ToString("X2"),
                        b[0xAA].ToString("X2"),
                        b[0xAB].ToString("X2"),
                        b[0xAC].ToString("X2"),
                        b[0xAD].ToString("X2"),
                        b[0xAE].ToString("X2"),
                        b[0xAF].ToString("X2"),
                        name
                        );
                }
            }

            dataGridView1.DataSource = table;
            for (int i = 0x0; i < 0x21; i++)
            {
                dataGridView1.Columns[i].Width = 23;
            }
            dataGridView1.Columns[0].Width = 30;
            dataGridView1.Columns[0x21].Width = 200;

        }
        private void loaddata2()
        {
            this.dataGridView1.DataSource = null;
            DataTable table2 = new DataTable();
            table2.Columns.Add("File", typeof(int));

            table2.Columns.Add(0x16.ToString("X2"), typeof(string));
            table2.Columns.Add(0x17.ToString("X2"), typeof(string));
            table2.Columns.Add(0x35.ToString("X2"), typeof(string));
            table2.Columns.Add(0x36.ToString("X2"), typeof(string));
            table2.Columns.Add(0x37.ToString("X2"), typeof(string));
            table2.Columns.Add(0x3A.ToString("X2"), typeof(string));
            table2.Columns.Add(0x3B.ToString("X2"), typeof(string));
            table2.Columns.Add(0x3C.ToString("X2"), typeof(string));
            table2.Columns.Add(0x3D.ToString("X2"), typeof(string));
            table2.Columns.Add(0x3E.ToString("X2"), typeof(string));
            table2.Columns.Add(0x3F.ToString("X2"), typeof(string));
            table2.Columns.Add(0x58.ToString("X2"), typeof(string));
            table2.Columns.Add(0x59.ToString("X2"), typeof(string));
            table2.Columns.Add(0x73.ToString("X2"), typeof(string));
            table2.Columns.Add(0xC8.ToString("X2"), typeof(string));
            table2.Columns.Add(0xC9.ToString("X2"), typeof(string));
            table2.Columns.Add(0xCC.ToString("X2"), typeof(string));
            table2.Columns.Add(0xCD.ToString("X2"), typeof(string));
            table2.Columns.Add(0xCE.ToString("X2"), typeof(string));
            table2.Columns.Add(0xCF.ToString("X2"), typeof(string));
            table2.Columns.Add(0xD0.ToString("X2"), typeof(string));
            table2.Columns.Add(0xD7.ToString("X2"), typeof(string));
            table2.Columns.Add(0xE4.ToString("X2"), typeof(string));
            table2.Columns.Add(0xE5.ToString("X2"), typeof(string));
            table2.Columns.Add(0xE6.ToString("X2"), typeof(string));
            table2.Columns.Add(0xE7.ToString("X2"), typeof(string));

            table2.Columns.Add("Filename", typeof(string));

            for (int i = 0; i < filepaths.Length; i++)
            {
                string path = filepaths[i];
                string name = Path.GetFileNameWithoutExtension(path);
                string ext = Path.GetExtension(path);
                byte[] b = File.ReadAllBytes(path);
                if ((ext == ".pk6") && (b.Length == 232))
                {
                    table2.Rows.Add(i,
                        b[0x16].ToString("X2"),
                        b[0x17].ToString("X2"),
                        b[0x35].ToString("X2"),
                        b[0x36].ToString("X2"),
                        b[0x37].ToString("X2"),
                        b[0x3A].ToString("X2"),
                        b[0x3B].ToString("X2"),
                        b[0x3C].ToString("X2"),
                        b[0x3D].ToString("X2"),
                        b[0x3E].ToString("X2"),
                        b[0x3F].ToString("X2"),
                        b[0x58].ToString("X2"),
                        b[0x59].ToString("X2"),
                        b[0x73].ToString("X2"),
                        b[0xC8].ToString("X2"),
                        b[0xC9].ToString("X2"),
                        b[0xCC].ToString("X2"),
                        b[0xCD].ToString("X2"),
                        b[0xCE].ToString("X2"),
                        b[0xCF].ToString("X2"),
                        b[0xD0].ToString("X2"),
                        b[0xD7].ToString("X2"),
                        b[0xE4].ToString("X2"),
                        b[0xE5].ToString("X2"),
                        b[0xE6].ToString("X2"),
                        b[0xE7].ToString("X2"),
                        name
                        );
                }
            }

            dataGridView1.DataSource = table2;
            for (int i = 1; i < 0x1c; i++)
            {
                dataGridView1.Columns[i].Width = 23;
            }
            dataGridView1.Columns[0].Width = 30;
            dataGridView1.Columns[27].Width = 350;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loaddata2();

        }
    }
    public static class ExtensionMethods    // Speed up scrolling
    {
        public static void DoubleBuffered(this DataGridView dgv, bool setting)
        {
            Type dgvType = dgv.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dgv, setting, null);
        }
    }
}
