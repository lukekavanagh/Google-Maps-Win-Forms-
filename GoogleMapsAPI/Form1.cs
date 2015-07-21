using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoogleMapsAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void search_data_Click(object sender, EventArgs e)
        {
            string street = txtbox_Street.Text;
            string city = txt_City.Text;
            string County = txt_County.Text;
            string Postcode = txt_Postcode.Text;

            try
            {
                StringBuilder queryaddress = new StringBuilder();
                queryaddress.Append("https://maps.google.com/maps?q=");


                if (street != string.Empty)
                {
                    queryaddress.Append(street+"," + "+");
                }

                if (city != string.Empty)
                {
                    queryaddress.Append(city + "," + "+");
                }

                if (County != string.Empty)
                {
                    queryaddress.Append(County + "," + "+");
                }

                if (Postcode != string.Empty)
                {
                    queryaddress.Append(Postcode + "," + "+");
                }

                webBrowser1.Navigate(queryaddress.ToString());



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }
    }
}
