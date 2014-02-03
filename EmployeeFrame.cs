﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktikfall
{
    public partial class EmployeeFrame : Form
    {
        public EmployeeFrame()
        {
            InitializeComponent();
            DataTable dt = controller.GetAllObjectsNr();
            dgvObject.DataSource = dt;
            dgvObjectShowing.DataSource = dt;
            DataTable dt2 = controller.GetAllProspectiveBuyers();
            dgvProspectiveBuyerShowing.DataSource = dt2;

            tbObjectArea.ReadOnly = true;
            tbNrOfRooms.ReadOnly = true;
            tbUnitType.ReadOnly = true;
            tbPricePerKvm.ReadOnly = true;
            richTextBox1.ReadOnly = true;

            lblObjBrokerSsnr.Visible = false;
            tbObjBrokerSsnr.Visible = false;
            
            lblObjNr.Visible = false;
            tbObjNr.Visible = false;
            
            lblObjAddressforTB.Visible = false;
            tbObjAddress.Visible = false;

            lblObjCityforTB.Visible = false;
            tbObjCity.Visible = false;

            lblObjPrice.Visible = false;
            tbObjPrice.Visible = false;
        }

        Controller controller = new Controller();


        /*private void btnObjAdd_Click(object sender, EventArgs e)
        {
            try
            {

                int parsedValue;
                if (!int.TryParse(tbObjNr.Text, out parsedValue))
                {
                    MessageBox.Show("Objektnummer får endast innehålla siffror");

                }

                else if (tbObjAdress.Text == "")
                {
                    MessageBox.Show("Du har ej angivit en adress.");
                }

                else if (tbObjPrice.Text == "")
                {
                    MessageBox.Show("Du har ej angivit ett pris.");
                }

                else if (tbObjArea.Text == "")
                {
                    MessageBox.Show("Du har ej angivit area");
                }              

                else if (tbObjRoom.Text == "")
                {
                    MessageBox.Show("Du har ej angivit antal rum");
                }

                else if (tbObjUnitType.Text == "")
                {
                    MessageBox.Show("Du har ej angivit bostadstyp");
                }

                else if (rtbObjInfo.Text == "")
                {
                    MessageBox.Show("Du har ej angivit någon beskrivning");
                }

                else if (tbBrokerNr.Text == "")
                {
                    MessageBox.Show("Du har ej angivit mäklarnummer.");
                }

                else
                {
                    string objNr = tbObjNr.Text;
                    string objAdress = tbObjAdress.Text;
                    int objPrice = int.Parse(tbObjPrice.Text);
                    string objRooms = tbObjRoom.Text;
                    string objUnitType = tbObjUnitType.Text;
                    double objArea = double.Parse(tbObjArea.Text);
                    string objInfo = rtbObjInfo.Text;
                    string brokerSsnr = tbBrokerNr.Text;
                    string objCity = tbObjCity.Text;

                    Controller controller = new Controller();

                    // DateTime result = dateTimePicker1.Value;
                    //string date = result.ToString();

                    controller.AddObject(objNr, objAdress, objCity, objPrice, objArea, objRooms, objUnitType, objInfo, brokerSsnr);
                    MessageBox.Show("Objekt registrerat!");
                    DataTable dt = controller.GetAllObjectsNr();
                    dgvObject.DataSource = dt;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Det går inte att registrera objektet\n" + ex);
            }

        }*/

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbObjSearch.Text == "" || tbObjSearch.Text == "Sökord")
                {
                    tbObjSearch.Text = "";
                    tbObjSearch.ForeColor = Color.LightSlateGray;
                    tbObjSearch.Text = "Sökord";
                    MessageBox.Show("Du har ej angivit ett sökord"); 
                }

                else 
                {
                    string searchString = tbObjSearch.Text;
                    DataTable dt = controller.SearchObjectByString(searchString);
                    dgvObject.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem i sökfunktion\n" + ex);
            }
            
        }

        private void btnAddProspectiveBuyer_Click(object sender, EventArgs e)
        {
            try
            {

                int parsedValue;
                if (!int.TryParse(tbBuyerSsn.Text, out parsedValue))
                {
                    MessageBox.Show("Personnummer får endast innehålla siffror");

                }

                else if (tbBuyerName.Text == "")
                {
                    MessageBox.Show("Du har ej angivit ett namn");
                }

                else if (tbBuyerTel.Text == "")
                {
                    MessageBox.Show("Du har ej angivit ett telefonnummer");
                }

                else if (tbProspectiveBuyerEmail.Text == "")
                {
                    MessageBox.Show("Du har ej angivit en email");
                }

                else
                {
                    string ssnr = tbBuyerSsn.Text;
                    string name = tbBuyerName.Text;
                    string phonenr = tbBuyerTel.Text;
                    string email = tbProspectiveBuyerEmail.Text;
                    controller.AddProspectiveBuyer(ssnr, name, phonenr, email);
                    MessageBox.Show("Ny spekulant registrerad");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Det går inte att registrera en spekulant/n" + ex);
            }
           

        }

        private void lblObjAddress_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvObject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvObject.Rows[e.RowIndex];
                
                lblObjAddress.Text = row.Cells["objAdress"].Value.ToString();
                lblObjCity.Text = row.Cells["objCity"].Value.ToString();
                lblPrice.Text = row.Cells["objPrice"].Value.ToString() + " kr";
                tbObjectArea.Text = row.Cells["objArea"].Value.ToString();
                tbNrOfRooms.Text = row.Cells["objRooms"].Value.ToString();
                tbUnitType.Text = row.Cells["objUnitType"].Value.ToString();
                richTextBox1.Text = row.Cells["objInfo"].Value.ToString();

                string price = row.Cells["objPrice"].Value.ToString();
                string area = row.Cells["objArea"].Value.ToString();
                int priceperkvm = int.Parse(price)/int.Parse(area);
                tbPricePerKvm.Text = priceperkvm.ToString();

            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddShowing_Click(object sender, EventArgs e)
        {
            string objNr = lblSelectedObjectShowing.Text;
            string buyerSsnr = lblSelectedBuyerShowing.Text;
            string showingDate = dtpVisningsdatumVisning.Text;
            int nrOfRows = controller.RegisterShowing(objNr, buyerSsnr, showingDate);
            MessageBox.Show("Visning Registrerad!");
            lblSelectedBuyerShowing.Visible = false;
            lblSelectedObjectShowing.Visible = false;
        }

        

      
        private void tbObjSearchClick(object sender, EventArgs e)
        {
            tbObjSearch.Text = "";
            tbObjSearch.ForeColor = Color.Black;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //string adress = tbObjAdress.Text;
            StringBuilder queryAddress = new StringBuilder();
            queryAddress.Append("https://maps.google.se/");
           // queryAddress.Append(adress + "," + "+");
           // webBrowser1.Navigate(queryAddress.ToString());

        }

        private void groupBoxVisning_Enter(object sender, EventArgs e)
        {

        }

        private void dgvObjectShowing_CellClicked(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvObjectShowing.Rows[e.RowIndex];
                string selectedItem = row.Cells["objNr"].Value.ToString();
                lblSelectedObjectShowing.Text = "Valt objekt: " + selectedItem;
                lblSelectedObjectShowing.Visible = true;

            }
        }

        private void dgvProspectiveBuyerShowing_CellClicked(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvProspectiveBuyerShowing.Rows[e.RowIndex];
                string selectedItem = row.Cells["buyerSsnr"].Value.ToString();
                lblSelectedBuyerShowing.Text = "Vald spekulant: " + selectedItem;
                lblSelectedBuyerShowing.Visible = true;

            }
        }

        //Avslutar applikationen när användaren stänger EmployeeFrame
        private void EmployeeFrame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lblSelectedObjectShowing_Click(object sender, EventArgs e)
        {

        }

        public void rbUpdateObject(object sender, EventArgs e)
        {
            tbObjectArea.ReadOnly = false;
            tbNrOfRooms.ReadOnly = false;
            tbUnitType.ReadOnly = false;
            tbPricePerKvm.ReadOnly = false;
            richTextBox1.ReadOnly = false;

            lblObjBrokerSsnr.Visible = true;
            tbObjBrokerSsnr.Visible = true;

            lblObjNr.Visible = true;
            tbObjNr.Visible = true;

            lblObjAddressforTB.Visible = true;
            tbObjAddress.Visible = true;

            lblObjCityforTB.Visible = true;
            tbObjCity.Visible = true;

            lblObjPrice.Visible = true;
            tbObjPrice.Visible = true;


        }

        private void btnSearchProBuyer_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbSearchProBuyer.Text == "" || tbSearchProBuyer.Text == "Sökord")
                {
                    tbSearchProBuyer.Text = "";
                    tbSearchProBuyer.ForeColor = Color.LightSlateGray;
                    tbSearchProBuyer.Text = "Sökord";
                    MessageBox.Show("Du har ej angivit ett sökord");
                }

                else
                {
                    string searchString = tbSearchProBuyer.Text;
                    DataTable dt = controller.SearchProBuyerByString(searchString);
                    dgvProspectiveBuyer.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem i sökfunktion\n" + ex);
            }
        }

        private void tb_clickSearch(object sender, EventArgs e)
        {
            tbSearchProBuyer.Text = "";
            tbSearchProBuyer.ForeColor = Color.Black;

        }

        private void dgvProBuyer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvProspectiveBuyer.Rows[e.RowIndex];

                tbBuyerSsn.Text = row.Cells["buyerSsnr"].Value.ToString();
                tbBuyerName.Text = row.Cells["name"].Value.ToString();
                tbBuyerTel.Text = row.Cells["phoneNr"].Value.ToString();
                tbProspectiveBuyerEmail.Text = row.Cells["email"].Value.ToString();
                

              

            }
        }

       




    }
}
