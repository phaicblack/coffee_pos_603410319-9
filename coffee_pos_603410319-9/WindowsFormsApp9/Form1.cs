using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        string p_s = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public Form1()
        {
            InitializeComponent();
        }

        public void phai(string Menu,string Bath)
        {
            string[] phai = { Menu, Bath };
            var list = new ListViewItem(phai);
            listView1.Items.Add(list);
            mi();
            
        }

        bool ok = false;
        private void button4_Click(object sender, EventArgs e)
        {
            ttb1.Text = "";
            if (ok == false)
            {
                tabControl1.TabPages.Insert(1, Payment);
                ok = true;
                tabControl1.SelectedTab = Payment;
            }
            else tabControl1.SelectedTab = Payment;

            if (listView1.Items.Count > 0) fa();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            phai("Esspresso)(Hot)", "35");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            phai("Americano)(Hot)", "35");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            phai("Latte)(Hot)", "35");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            phai("Mocha)(Hot)", "35");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            phai("Cappuccino)(Hot)", "35");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            phai("GreenTea)(Hot)", "20");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            phai("ThaiTea)(Hot)", "20");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            phai("CoCoa)(Hot)", "20");
        }

        private void button48_Click(object sender, EventArgs e)
        {
            phai("Milk)(Hot)", "20");
        }

        private void button39_Click(object sender, EventArgs e)
        {
            phai("Milo)(Hot)", "20");
        }

        private void button36_Click(object sender, EventArgs e)
        {
            phai("NestCafe)(Hot)", "20");
        }

        private void button33_Click(object sender, EventArgs e)
        {
            phai("Nestca tea)(Hot)", "20");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            phai("Esspresso)(Ice)", "45");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            phai("Americano)(Ice)", "45");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            phai("Latte)(Ice)", "45");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            phai("Mocha)(Ice)", "45");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            phai("Cappuccino)(Ice)", "45");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            phai("GreenTea)(Ice)", "25");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            phai("ThaiTea)(Ice)", "25");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            phai("CoCoa)(Ice)", "25");
        }

        private void button47_Click(object sender, EventArgs e)
        {
            phai("Milk)(Ice)", "25");
        }

        private void button44_Click(object sender, EventArgs e)
        {
            phai("MilkTea)(Ice)", "25");
        }

        private void button41_Click(object sender, EventArgs e)
        {
            phai("LemonTea)(Ice)", "25");
        }

        private void button38_Click(object sender, EventArgs e)
        {
            phai("Milo)(Ice)", "25");
        }

        private void button35_Click(object sender, EventArgs e)
        {
            phai("Nestcafe)(Ice)", "25");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            phai("Nestca Tea)(Ice)", "25");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            phai("Red lime Soda)(Ice)", "25");
        }

        private void button50_Click(object sender, EventArgs e)
        {
            phai("honey lime Soda)(Ice)", "25");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            phai("Esspresso)(Frappe)", "50");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            phai("Latte)(Frappe)", "50");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            phai("Mocha)(Frappe)", "50");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            phai("Cappuccino)(Frappe)", "50");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            phai("GreenTea)(Frappe)", "30");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            phai("ThaiTea)(Frappe)", "30");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            phai("CoCoa)(Frappe)", "30");
        }

        private void button46_Click(object sender, EventArgs e)
        {
            phai("Milk)(Frappe)", "30");
        }

        private void button43_Click(object sender, EventArgs e)
        {
            phai("MilkTea)(Frappe)", "30");
        }

        private void button40_Click(object sender, EventArgs e)
        {
            phai("LemonTea)(Frappe)", "30");
        }

        private void button37_Click(object sender, EventArgs e)
        {
            phai("Milo)(Frappe)", "30");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            phai("Nestcafe)(Frappe)", "30");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            phai("Nestca Tea)(Frappe)", "30");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            phai("Italian Soda)(Frappe)", "30");
        }

        double price;
        public string [] mi()
        {
            price = 0;
            string[] Ar = new string[listView1.Items.Count];
            int item = listView1.Items.Count;
            for(int i = 0;i<item; i++)
            {
                price += double.Parse(listView1.Items[i].SubItems[1].Text);
                Ar[i] = listView1.Items[i].SubItems[0].Text.ToString();
            }
            label27.Text = price.ToString();
            return Ar;
        }

        public string[] mil()
        {
            price = 0;
            string[] Ar = new string[listView1.Items.Count];
            int item = listView1.Items.Count;
            for (int i = 0; i < item; i++)
            {
                price += double.Parse(listView1.Items[i].SubItems[1].Text);
                Ar[i] = listView1.Items[i].SubItems[1].Text.ToString();
            }            
            return Ar;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.Controls.Remove(Payment);
        }

        public void fa()
        {
            string[] ph = mi();
            string[] ai = mil();
            string pim = "Coffee_Pos" + DateTime.Now.ToString("hhmmss_dd_mm_yyyy");
            string bill = "Coffee_Pos";
            bill += "\r\n" + DateTime.Now.ToString("hh:mm:ss:") + "\r\n" + DateTime.Now.ToString("dd/mm/yyyy") + "\r\n" + "\r\n";
            bill += "Menu" + "\r\n";
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                bill += ph[i] + new string(' ', 20) + ai[i] + "Bath" + "\r\n";
            }
            bill += "\r\n";
            bill += "Total Price : " + label27.Text;
            System.IO.File.WriteAllText(p_s + @"\" + pim + ".txt", bill);
            ttb1.Text += bill + "\r\n" + "\r\n" + "\r\n" + "\r\n" + "Save File at" + p_s + @"\" + pim + ".txt";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            ok = false;
            tabControl1.Controls.Remove(Payment);
            label27.Text = "";
            ttb1.Text = "";
        }
    }
}
