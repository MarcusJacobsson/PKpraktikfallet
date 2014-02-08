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
    public partial class frameMainMainframe : Form
    {
        public frameMainMainframe(string name, bool b)
        {
            InitializeComponent();
            string brokerName = name;
            lblStartEmpName.Text = brokerName;
            if (b == true)
            {
                bgBrokerAdministrateBroker.Visible = true;
            }

            else
            {
                bgBrokerAdministrateBroker.Visible = false;
                tpBrokerBrokerTabPage.Text = "";
            }
            Populate();
            DataTable dt = controller.SearchObjectByBrokerSsnr(brokerName);
            dgvStartYourObjects.DataSource = dt;
            DataTable dt2 = controller.SearchShowingsByBrokerSsnr(brokerName);
            dgvStartYourShowings.DataSource = dt2;
        }

        Controller controller = new Controller();

        public void MakeTbReadOnly()
        {

            tbObjectObjectNr.ReadOnly = true;
            tbObjectAddress.ReadOnly = true;
            tbObjectCity.ReadOnly = true;
            tbObjectPrice.ReadOnly = true;
            tbObjectArea.ReadOnly = true;
            tbObjectNumberOfRooms.ReadOnly = true;
            tbObjectType.ReadOnly = true;
            rtbObjectObjectInfo.ReadOnly = true;
            tbObjectBrokerSsnr.ReadOnly = true;
            tbObjectOwnerSsnr.ReadOnly = true;
            tbObjectAddress.ReadOnly = true;
            tbObjectOwnerEmail.ReadOnly = true;
            tbObjectOwnerName.ReadOnly = true;
            tbObjectOwnerPhoneNr.ReadOnly = true;
            tbObjectPricePerKvm.ReadOnly = true;
        }

        public void MakeTbEditable()
        {
            tbObjectObjectNr.ReadOnly = false;
            tbObjectAddress.ReadOnly = false;
            tbObjectCity.ReadOnly = false;
            tbObjectPrice.ReadOnly = false;
            tbObjectArea.ReadOnly = false;
            tbObjectNumberOfRooms.ReadOnly = false;
            tbObjectType.ReadOnly = false;
            rtbObjectObjectInfo.ReadOnly = false;
            tbObjectBrokerSsnr.ReadOnly = false;
            tbObjectOwnerSsnr.ReadOnly = false;
            tbObjectAddress.ReadOnly = false;
            tbObjectOwnerEmail.ReadOnly = false;
            tbObjectOwnerName.ReadOnly = false;
            tbObjectOwnerPhoneNr.ReadOnly = false;
            tbObjectPricePerKvm.ReadOnly = false;
            tbObjectOwnerEmail.ReadOnly = false;
            tbObjectOwnerName.ReadOnly = false;
            tbObjectOwnerPhoneNr.ReadOnly = false;
            tbObjectPricePerKvm.ReadOnly = false;
        }

        public void ClearObjectTb()
        {
            tbObjectObjectNr.Text = "";
            tbObjectAddress.Text = "";
            tbObjectCity.Text = "";
            tbObjectPrice.Text = "";
            tbObjectArea.Text = "";
            tbObjectNumberOfRooms.Text = "";
            tbObjectType.Text = "";
            rtbObjectObjectInfo.Text = "";
            tbObjectBrokerSsnr.Text = "";
            tbObjectOwnerSsnr.Text = "";
            tbObjectAddress.Text = "";
            tbObjectOwnerEmail.Text = "";
            tbObjectOwnerName.Text = "";
            tbObjectOwnerPhoneNr.Text = "";
            tbObjectPricePerKvm.Text = "";
        }

        public void Populate()                                                            //Uppdatera ALLA DGVS (utom Christians)
        {
            DataTable dtAllObjects = controller.GetAllObjectsNr();
            dgvObjectAllObjects.DataSource = dtAllObjects;                                          //Objektfliken, alla objekt i databasen          
            MakeTbReadOnly();
            btnObjectSubmit.Enabled = false;
            dgvShowingAllObjects.DataSource = dtAllObjects;                                   //Visningsfliken, alla objekt i databasen            
            DataTable dtAllProspectiveBuyers = controller.GetAllProspectiveBuyers();
            dgvShowingAllBuyers.DataSource = dtAllProspectiveBuyers;               //Visningsfliken, alla spekulanter i databasen 
            DataTable dtAllShowings = controller.GetShowings();
            dgvShowingCurrentShowings.DataSource = dtAllShowings;                         //Visningsfliken, alla nuvarande visningar i databasen
            DataTable dtAllBrokers = controller.GetAllBrokers();                          //Mäklarfliken (admin), visa alla mäklare
            dgvBrokerAllBrokers.DataSource = dtAllBrokers;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbObjectSearch.Text.Equals("") || tbObjectSearch.Text.Equals("Sökord"))
                {
                    tbObjectSearch.Text = "";
                    tbObjectSearch.ForeColor = Color.LightSlateGray;
                    tbObjectSearch.Text = "Sökord";
                    Populate();
                }

                else
                {
                    string searchString = tbObjectSearch.Text;
                    DataTable dt = controller.SearchObjectByString(searchString);
                    dgvObjectAllObjects.DataSource = dt;
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
                if (!int.TryParse(tbShowingBuyerSsnr.Text, out parsedValue))
                {
                    MessageBox.Show("Personnummer får endast innehålla siffror");

                }

                else if (tbBuyerName.Text.Equals(""))
                {
                    MessageBox.Show("Du har ej angivit ett namn");
                }

                else if (tbShowingBuyerTel.Text.Equals(""))
                {
                    MessageBox.Show("Du har ej angivit ett telefonnummer");
                }

                else if (tbShowingBuyerEmail.Text.Equals(""))
                {
                    MessageBox.Show("Du har ej angivit en email");
                }

                else
                {
                    string ssnr = tbShowingBuyerSsnr.Text;
                    string name = tbBuyerName.Text;
                    string phonenr = tbShowingBuyerTel.Text;
                    string email = tbShowingBuyerEmail.Text;
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

        private void dgvObject_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvObjectAllObjects.Rows[e.RowIndex];
                string objNr = row.Cells["objNr"].Value.ToString();
                this.setSelectedObjectAndOwner(objNr, row);
            }
        }

        private void setSelectedObjectAndOwner(string objNr, DataGridViewRow row)
        {

            DataTable objectInfo = this.controller.GetObject(objNr);
            foreach (DataRow row1 in objectInfo.Rows)
            {
                tbObjectObjectNr.Text = row1[0].ToString();
                tbObjectAddress.Text = row1[1].ToString();
                tbObjectCity.Text = row1[2].ToString();
                tbObjectPrice.Text = row1[3].ToString();
                lblObjectObjAddress.Text = row1[1].ToString();
                lblObjCity.Text = row1[2].ToString();
                lblObjectObjectPrice.Text = row1[3].ToString();
                tbObjectArea.Text = row1[4].ToString();
                tbObjectNumberOfRooms.Text = row1[5].ToString();
                tbObjectType.Text = row1[6].ToString();
                rtbObjectObjectInfo.Text = row1[7].ToString();
                tbObjectBrokerSsnr.Text = row1[8].ToString();
                tbObjectOwnerSsnr.Text = row1[9].ToString();
                string price = row1[3].ToString();
                string area = row1[4].ToString();
                int priceperkvm = int.Parse(price) / int.Parse(area);
                tbObjectPricePerKvm.Text = priceperkvm.ToString();

            }

            DataTable ownerInfo = this.controller.GetObjectOwner(tbObjectOwnerSsnr.Text);

            foreach (DataRow row1 in ownerInfo.Rows)
            {
                tbObjectOwnerPhoneNr.Text = row1[1].ToString();
                tbObjectOwnerEmail.Text = row1[2].ToString();
                tbObjectOwnerName.Text = row1[3].ToString();

            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddShowing_Click(object sender, EventArgs e)                //Lägg till visning
        {
            string objNr = lblShowingSelectedObject.Text;
            string showingDate = dtpShowingShowingDate.Text;
            string buyerSsnr = lblShowingSelectedBuyer.Text;
            bool showingExists = controller.ShowingExists(objNr, buyerSsnr);        //Kontrollerar om visningen redan finns

            if (showingExists)
            {
                MessageBox.Show("Visningen finns redan. Vänligen kontrollera dina val. Använd Uppdatera datum-knappen för att uppdatera visningsdatum.");
            }

            if (lblShowingSelectedBuyer.Text.Equals("selectedBuyer(invisible)"))
            {
                MessageBox.Show("Vänligen välj spekulant i listan.");
            }
            if (lblShowingSelectedObject.Text.Equals("selectedObject(invisible)"))
            {
                MessageBox.Show("Vänligen välj objekt i listan.");
            }
            if (!showingExists && !(lblShowingSelectedBuyer.Text.Equals("selectedBuyer(invisible)")) && !(lblShowingSelectedObject.Text.Equals("selectedObject(invisible)")))
            {
                int nrOfRows = controller.AddShowing(objNr, buyerSsnr, showingDate);
                MessageBox.Show("Visning registrerad!");
                Populate();
            }
        }

        private void tbObjSearchClick(object sender, EventArgs e)
        {
            tbObjectSearch.Text = "";
            tbObjectSearch.ForeColor = Color.Black;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            StringBuilder queryAddress = new StringBuilder();
            queryAddress.Append("https://maps.google.se/");

        }

        private void groupBoxVisning_Enter(object sender, EventArgs e)
        {

        }

        private void dgvObjectShowing_CellClicked(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvShowingAllObjects.Rows[e.RowIndex];
                string selectedItem = row.Cells["objNr"].Value.ToString();
                lblShowingSelectedObject.Text = selectedItem;

            }
        }

        private void dgvProspectiveBuyerShowing_CellClicked(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvShowingAllBuyers.Rows[e.RowIndex];
                string selectedItem = row.Cells["buyerSsnr"].Value.ToString();
                lblShowingSelectedBuyer.Text = selectedItem;
                tbShowingBuyerSsnr.Text = row.Cells["buyerSsnr"].Value.ToString();
                tbBuyerName.Text = row.Cells["name"].Value.ToString();
                tbShowingBuyerTel.Text = row.Cells["phoneNr"].Value.ToString();
                tbShowingBuyerEmail.Text = row.Cells["email"].Value.ToString();

            }
        }

        private void EmployeeFrame_FormClosed(object sender, FormClosedEventArgs e)         //Avslutar applikationen när användaren stänger EmployeeFrame
        {
            Application.Exit();
        }

        private void lblSelectedObjectShowing_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchProBuyer_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbShowingSearch.Text.Equals("") || tbShowingSearch.Text.Equals("Sökord"))
                {
                    tbShowingSearch.Text = "";
                    tbShowingSearch.ForeColor = Color.LightSlateGray;
                    tbShowingSearch.Text = "Sökord";
                    MessageBox.Show("Du har ej angivit ett sökord");
                }

                else
                {
                    string searchString = tbShowingSearch.Text;
                    DataTable dt = controller.SearchProBuyerByString(searchString);
                    dgvShowingAllBuyers.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem i sökfunktion\n" + ex);
            }
        }

        private void tb_clickSearch(object sender, EventArgs e)
        {
            tbShowingSearch.Text = "";
            tbShowingSearch.ForeColor = Color.Black;

        }

        private void dgvProBuyer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvShowingAllBuyers.Rows[e.RowIndex];

                tbShowingBuyerSsnr.Text = row.Cells["buyerSsnr"].Value.ToString();
                tbBuyerName.Text = row.Cells["name"].Value.ToString();
                tbShowingBuyerTel.Text = row.Cells["phoneNr"].Value.ToString();
                tbShowingBuyerEmail.Text = row.Cells["email"].Value.ToString();


            }
        }

        private void btnShowMap_Click(object sender, EventArgs e)
        {

            if (tbObjectAddress.Text.Equals("") || tbObjectCity.Text.Equals(""))
            {
                MessageBox.Show("Du har ej valt ett objekt");
            }
            else
            {
                MapFrame mf = new MapFrame(tbObjectAddress.Text, tbObjectCity.Text);
                mf.Show();
            }
        }

        private void btnShowingUpdate_Click(object sender, EventArgs e)
        {

            string objNr = lblShowingSelectedObject.Text;
            string showingDate = dtpShowingShowingDate.Text;
            string buyerSsnr = lblShowingSelectedBuyer.Text;

            if (lblShowingSelectedBuyer.Text.Equals("selectedBuyer(invisible)"))
            {
                MessageBox.Show("Vänligen välj spekulant i listan.");
            }

            if (lblShowingSelectedObject.Text.Equals("selectedObject(invisible)"))
            {
                MessageBox.Show("Vänligen välj objekt i listan.");
            }

            else
            {
                int nrOfRows = controller.UpdateShowing(objNr, buyerSsnr, showingDate);
                MessageBox.Show("Visning uppdaterad. Nytt visningsdatum " + showingDate);
                Populate();
            }

        }

        private void dgvShowingCurrentShowings_CellClicked(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvShowingCurrentShowings.Rows[e.RowIndex];
                string objNr = row.Cells["objNr"].Value.ToString();
                string buyerSsnr = row.Cells["buyerSsnr"].Value.ToString();
                lblShowingSelectedBuyerDelete.Text = buyerSsnr;
                lblShowingSelectedObjNrDelete.Text = objNr;  
            }
            
        }

        private void btnShowingDelete_Click(object sender, EventArgs e)                         //Ta bort visning/Ta bort spekulant från visning
        {
            string buyerSsnr = lblShowingSelectedBuyerDelete.Text;
            string objNr = lblShowingSelectedObjNrDelete.Text;

            if (rbShowingDeleteShowing.Checked)                                                  //Om "ta bort hela visningen" är valt
            {
                if (lblShowingSelectedObjNrDelete.Text.Equals("selectedForDelete(invisible)"))
                {
                    MessageBox.Show("Vänligen välj ett objekt i listan först.");
                }
                else
                {
                    int nrOfRows = controller.DeleteShowing(objNr);
                    MessageBox.Show("Visning borttagen");
                    Populate();
                    lblShowingSelectedBuyerDelete.Text = "selectedForDelete(invisible)";
                    lblShowingSelectedObjNrDelete.Text = "selectedForDelete(invisible)";
                }
            }
            if (!rbShowingDeleteBuyer.Checked && !rbShowingDeleteShowing.Checked)               // Om inget val gjorts, ge feedback
            {
                MessageBox.Show("Vänligen välj ett alternativ (ta bort alla visningar eller ta bort spekulant från visning) först.");
            }

            if (rbShowingDeleteBuyer.Checked)                                                   //Om "ta bort spekulant" är valt
            {
                if (lblShowingSelectedBuyerDelete.Text.Equals("selectedForDelete(invisible)"))
                {
                    MessageBox.Show("Vänligen välj en spekulant i listan först.");
                }
                else
                {
                    int nrOfRows = controller.DeleteBuyerFromShowing(buyerSsnr, objNr);
                    MessageBox.Show("Spekulant borttagen från visning");
                    Populate();
                    lblShowingSelectedBuyerDelete.Text = "selectedForDelete(invisible)";
                    lblShowingSelectedObjNrDelete.Text = "selectedForDelete(invisible)";
                }

            }
        }

        private void cbObjUpdateClick(object sender, EventArgs e)
        {
            dgvObject_CellClick(dgvObjectAllObjects, new DataGridViewCellEventArgs(0, 0));
        }

        private void btnObjSubmit_Click(object sender, EventArgs e)
        {
            string objNr = tbObjectObjectNr.Text;
            string objAdress = tbObjectAddress.Text;
            string objCity = tbObjectCity.Text;
            string objPrice = tbObjectPrice.Text;
            string objArea = tbObjectArea.Text;
            string objRooms = tbObjectNumberOfRooms.Text;
            string objUnitType = tbObjectType.Text;
            string objInfo = rtbObjectObjectInfo.Text;
            string brokerSsnr = tbObjectBrokerSsnr.Text;
            string ownerSsnr = tbObjectOwnerSsnr.Text;
            string phoneNr = tbObjectOwnerPhoneNr.Text;
            string email = tbObjectOwnerEmail.Text;
            string name = tbObjectOwnerName.Text;

            if (cbObjectUpdate.Checked && !cbObjectRegister.Checked && !tbObjectDeleteObject.Checked)
            {

                int nrOfRows = this.controller.UpdateObjectFlap(objNr, objAdress, objCity, objPrice, objArea, objRooms, objUnitType, objInfo, ownerSsnr, phoneNr, email, name);
                MessageBox.Show(nrOfRows.ToString());
                Populate();
            }

            else if (cbObjectRegister.Checked && !cbObjectUpdate.Checked && !tbObjectDeleteObject.Checked)
            {
                int nrOfRows = this.controller.AddObjectAndOwner(objNr, objAdress, objCity, objPrice, objArea, objRooms, objUnitType, objInfo, brokerSsnr, ownerSsnr, phoneNr, email, name);
                MessageBox.Show(nrOfRows.ToString());
                Populate();

            }

            else if (tbObjectDeleteObject.Checked && !cbObjectUpdate.Checked && !cbObjectRegister.Checked)
            {
                int nrOfRows = this.controller.DeleteObject(objNr);
                Populate();
            }
        }

        private void btnAddProspectiveBuyer_Click_1(object sender, EventArgs e)
        {
            try
            {

                int parsedValue;
                if (!int.TryParse(tbShowingBuyerSsnr.Text, out parsedValue))
                {
                    MessageBox.Show("Personnummer får endast innehålla siffror");

                }

                else if (tbBuyerName.Text.Equals(""))
                {
                    MessageBox.Show("Du har ej angivit ett namn");
                }

                else if (tbShowingBuyerTel.Text.Equals(""))
                {
                    MessageBox.Show("Du har ej angivit ett telefonnummer");
                }

                else if (tbShowingBuyerEmail.Text.Equals(""))
                {
                    MessageBox.Show("Du har ej angivit en email");
                }

                else
                {

                    string ssnr = tbShowingBuyerSsnr.Text;
                    string name = tbBuyerName.Text;
                    string phonenr = tbShowingBuyerTel.Text;
                    string email = tbShowingBuyerEmail.Text;
                    bool prospectiveBuyerExists = controller.ProspectiveBuyerExists(ssnr);

                    if (prospectiveBuyerExists)
                    {
                        MessageBox.Show("Det finns redan en spekulant med personnummer: " + ssnr);
                    }

                    else
                    {
                        controller.AddProspectiveBuyer(ssnr, name, phonenr, email);
                        MessageBox.Show("Ny spekulant med personnummer " + ssnr + " har registrerats");
                        Populate();
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Det går inte att registrera en spekulant/n" + ex);
            }
        }

        private void btnSearchProBuyer_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (tbShowingSearch.Text.Equals("") || tbShowingSearch.Text.Equals("Sökord"))
                {
                    tbShowingSearch.Text = "";
                    tbShowingSearch.ForeColor = Color.LightSlateGray;
                    tbShowingSearch.Text = "Sökord";
                    Populate();

                }

                else
                {
                    string searchString = tbShowingSearch.Text;
                    DataTable dt = controller.SearchProBuyerByString(searchString);
                    dgvShowingAllBuyers.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem i sökfunktion\n" + ex);
            }
        }

        private void btnUpdateProspectiveBuyer_Click(object sender, EventArgs e)
        {

            if (tbShowingBuyerSsnr.Text.Equals(""))
            {
                MessageBox.Show("Du har ej valt eller angivit ett personnummer");
            }
            else
            {

                string buyerSsnr = tbShowingBuyerSsnr.Text;
                string name = tbBuyerName.Text;
                string phoneNr = tbShowingBuyerTel.Text;
                string email = tbShowingBuyerEmail.Text;
                int nrOfRows = controller.UpdateProspectiveBuyer(buyerSsnr, name, phoneNr, email);
                MessageBox.Show("Spekulant " + buyerSsnr + " uppdaterad!");
                Populate();
            }
        }

        private void btnDeleteProspectiveBuyer_Click(object sender, EventArgs e)
        {
            if (tbShowingBuyerSsnr.Text.Equals(""))
            {
                MessageBox.Show("Du har ej valt eller angivit ett personnummer");
            }
            else
            {
                string buyerSsnr = tbShowingBuyerSsnr.Text;
                int nrOfRows = controller.DeleteProspectiveBuyer(buyerSsnr);
                MessageBox.Show("Spekulant " + buyerSsnr + " raderad!");
                Populate();
            }
        }

        private void tbSearchProBuyer_Click(object sender, EventArgs e)
        {
            tbShowingSearch.Text = "";
            tbShowingSearch.ForeColor = Color.Black;
        }

        private void dgvShowingObject_DBC(object sender, DataGridViewBindingCompleteEventArgs e) //FÖR ATT INTE VÄLJA FÖRSTA RADEN NÄR DGV LADDAS /Marcus
        {
            dgvShowingAllObjects.ClearSelection();
        }

        private void dgvShowingProspecitveBuyer_DBC(object sender, DataGridViewBindingCompleteEventArgs e) //FÖR ATT INTE VÄLJA FÖRSTA RADEN NÄR DGV LADDAS /Marcus
        {
            dgvShowingAllBuyers.ClearSelection();
        }

        private void dgvShowingCurrentShowings_DBC(object sender, DataGridViewBindingCompleteEventArgs e) //FÖR ATT INTE VÄLJA FÖRSTA RADEN NÄR DGV LADDAS /Marcus
        {
            dgvShowingCurrentShowings.ClearSelection();
        }
        private void dgvBrokerAllBrokers_DBC(object sender, DataGridViewBindingCompleteEventArgs e) //FÖR ATT INTE VÄLJA FÖRSTA RADEN NÄR DGV LADDAS
        {
            dgvBrokerAllBrokers.ClearSelection();
        }

        #region MAINMENU
        private void menuItem7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Version 1.0 BrokerApplication\n\n\n"
                + "Denna mjukvara är skapad av\n\n"
                + "Marcus Jacobsson, marcus.jacobsson@student.lu.se\n"
                + "Christian Runnström, christian.runnstrom@student.lu.se\n"
                + "William Svedström, william.svedstrom@student.lu.se\n"
                + "August Ransnäs, august.ransnas@student.lu.se\n\n"
                + "Copyright © 2014 Mäklarfirman",
                "Om",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }

        private void menuItem5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuItem9_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Visningar hanteras under fliken Visning. Här kan användaren lägga till, ta bort eller uppdatera visningar. \n\n"
                + "Hur lägger jag till en visning för ett objekt?\n"
                + "För att lägga till en visning för ett objekt, gör följande:\n"
                + "(1) välj ett objekt i listan under \"välj objekt\".\n"
                + "(2) välj vilken spekulant i listan \"Välj spekulant\" som ska gå på visningen.\n"
                + "(3) välj vilket datum under \"välj datum\" som visningen kommer äga rum.\n"
                + "(4) tryck på knappen \"Lägg till\" för att registrera din visning.\n\n"
                + "Hur tar jag bort en visning för ett objekt?\n"
                + "För att ta bort en visning från ett objekt, gör följande:\n"
                + "(1) välj ditt objekts objektnummer i listan under \"Ta bort visningar\".\n"
                + "(2) välj alternativet \"Ta bort alla visningar\" till höger om listan.\n"
                + "(3) tryck på knappen \"Ta bort\" för att ta bort alla visningar för objektet.\n\n"
                + "Hur tar jag bort endast en spekulant från ett objekts visning?\n"
                + "För att ta bort endast en spekulant från en visning, gör följande:\n"
                + "(1) välj en spekulanten i listan under \"Ta bort visningar\".\n"
                + "(2) välj alternativet \"Ta bort spekulant från visning\" till höger om listan.\n"
                + "(3) tryck på knappen \"Ta bort\" för att ta bort spekulanten från objektets visning.\n\n"
                + "Hur uppdaterar jag ett objekts visningsdatum?\n"
                + "För att uppdatera en visnings visningsdatum, gör följande:\n"
                + "(1) välj ett objekt i listan under \"välj objekt\".\n"
                + "(2) välj vilken spekulant i listan \"Välj spekulant\" som ska uppdateras.\n"
                + "(3) välj ett nytt datum under \"välj datum\"\n"
                + "(4) tryck på knappen \"Uppdatera datum\".",
                "Visning",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }

        private void menuItem11_Click(object sender, EventArgs e)
        {
            this.Hide();
            formLogin form = new formLogin();
            form.Show();
        }

        private void menuItem12_Click(object sender, EventArgs e)
        {
            //Visa/dölj en tab för Mäklare
        }
        #endregion MAINMENU

        private void btnBrokerSubmit_Click(object sender, EventArgs e)
        {
            string brokerSsnr = tbBrokerBrokerSsnr.Text;
            string pw = tbBrokerBrokerPw.Text;
            string name = tbBrokerBrokerName.Text;
            string phoneNr = tbBrokerBrokerPhoneNumber.Text;
            string email = tbBrokerBrokerEmail.Text;
            string city = tbBrokerBrokerCity.Text;
            string brokerAddress = tbBrokerBrokerAdress.Text;

            if (cbBrokerRegister.Checked && !cbBrokerDelete.Checked && !cbBrokerUpdate.Checked)
            {
                try
                {

                    int parsedValue;
                    if (!int.TryParse(tbBrokerBrokerSsnr.Text, out parsedValue))
                    {
                        MessageBox.Show("Personnummer får endast innehålla siffror");
                    }

                    else if (tbBrokerBrokerName.Text.Equals(""))
                    {
                        MessageBox.Show("Du har ej angivit ett namn");
                    }

                    else if (tbBrokerBrokerAdress.Text.Equals(""))
                    {
                        MessageBox.Show("Du har ej angivit en adress");
                    }

                    else if (tbBrokerBrokerCity.Text.Equals(""))
                    {
                        MessageBox.Show("Du har ej angivit en stad");
                    }

                    else if (tbBrokerBrokerPhoneNumber.Text.Equals(""))
                    {
                        MessageBox.Show("Du har ej angivit ett telefonnummer");
                    }

                    else if (tbBrokerBrokerEmail.Text.Equals(""))
                    {
                        MessageBox.Show("Du har ej angivit en email");
                    }

                    else if (tbBrokerBrokerPw.Text.Equals(""))
                    {
                        MessageBox.Show("Du har ej angivit ett lösenord");
                    }

                    else
                    {
                        bool brokerExists = controller.BrokerExists(brokerSsnr);

                        if (brokerExists)
                        {
                            MessageBox.Show("Det finns redan en mäklare med personnummer: " + brokerSsnr);
                        }

                        else
                        {
                            controller.AddBroker(brokerSsnr, name, brokerAddress, city, phoneNr, email, pw);
                            MessageBox.Show("Mäklare med personnummer " + brokerSsnr + " registrerad");
                            Populate();
                        }

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Det går inte att registrera en mäklare\n" + ex);
                }
            }

            if (!cbBrokerRegister.Checked && cbBrokerDelete.Checked && !cbBrokerUpdate.Checked)
            {
                try
                {
                    int nrOfRows = controller.DeleteBroker(brokerSsnr);

                    if (nrOfRows == 0)
                    {
                        MessageBox.Show("Ingen sådan mäklare finns registrerad. Vänligen försök igen.");
                    }
                    else
                    {
                        Populate();
                        tbBrokerBrokerAdress.Text = "";
                        tbBrokerBrokerCity.Text = "";
                        tbBrokerBrokerEmail.Text = "";
                        tbBrokerBrokerName.Text = "";
                        tbBrokerBrokerPhoneNumber.Text = "";
                        tbBrokerBrokerPw.Text = "";
                        tbBrokerBrokerSsnr.Text = "";
                        MessageBox.Show("Mäklare med personnummer " + brokerSsnr + " borttagen");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Det går inte att ta bort mäklare.\n" + ex);
                }

            }
            if (!cbBrokerRegister.Checked && !cbBrokerDelete.Checked && cbBrokerUpdate.Checked)
            {
                try
                {
                    int nrOfRows = controller.UpdateBroker(brokerSsnr, name, brokerAddress, city, phoneNr, email, pw);

                    if (nrOfRows == 0)
                    {
                        MessageBox.Show("Ingen sådan mäklare finns registrerad. Vänligen försök igen.");
                    }
                    else
                    {
                        Populate();
                        MessageBox.Show("Mäklare med personnummer " + brokerSsnr + " uppdaterad.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Det går inte att uppdatera mäklare.\n" + ex);
                }
            }
            if (!cbBrokerRegister.Checked && !cbBrokerDelete.Checked && !cbBrokerUpdate.Checked)
            {
                MessageBox.Show("Vänligen gör ett val först.");
            }
        }

        private void dgvBrokerAllBrokers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvBrokerAllBrokers.Rows[e.RowIndex];
                string selectedItem = row.Cells["brokerSsnr"].Value.ToString();
                lblShowingSelectedBuyer.Text = selectedItem;
                tbBrokerBrokerSsnr.Text = row.Cells["brokerSsnr"].Value.ToString();
                tbBrokerBrokerName.Text = row.Cells["name"].Value.ToString();
                tbBrokerBrokerAdress.Text = row.Cells["brokerAddress"].Value.ToString();
                tbBrokerBrokerCity.Text = row.Cells["city"].Value.ToString();
                tbBrokerBrokerPhoneNumber.Text = row.Cells["phoneNr"].Value.ToString();
                tbBrokerBrokerEmail.Text = row.Cells["email"].Value.ToString();
                tbBrokerBrokerPw.Text = row.Cells["pw"].Value.ToString();

            }
        }

        private void btnShowingSubmit_Click(object sender, EventArgs e)
        {
            string buyerSsnr = tbShowingBuyerSsnr.Text;
            string name = tbBuyerName.Text;
            string phoneNr = tbShowingBuyerTel.Text;
            string email = tbShowingBuyerEmail.Text;



            if (cbShowingRegisterBuyer.Checked && !cbShowingDeleteBuyer.Checked && !cbShowingUpdateBuyer.Checked)
            {
                try
                {
                    
                    bool buyerExists = controller.ProspectiveBuyerExists(buyerSsnr);

                    if (buyerExists)
                    {
                        MessageBox.Show("Det finns redan en spekulant med personnummer " + buyerSsnr + " registrerad");
                    }
                    else
                    {
                        int nrOfRows = controller.AddProspectiveBuyer(buyerSsnr, name, phoneNr, email);
                        Populate();
                        MessageBox.Show("Spekulant med personnummer " + buyerSsnr + " har lagts till");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Spekulant kunde inte regustreras.\n" + ex);
                }
            }
            if (!cbShowingRegisterBuyer.Checked && cbShowingDeleteBuyer.Checked && !cbShowingUpdateBuyer.Checked)
            {
                try
                {
                    int nrOfRows = controller.DeleteProspectiveBuyer(buyerSsnr);
                    if (nrOfRows == 0)
                    {
                        MessageBox.Show("Ingen sådan spekulant finns. Vänligen försök igen.");
                    }
                    else
                    {
                        Populate();
                        tbShowingBuyerEmail.Text = "";
                        tbBuyerName.Text = "";
                        tbShowingBuyerSsnr.Text = "";
                        tbShowingBuyerTel.Text = "";
                        MessageBox.Show("Spekulant borttagen.");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Det går inte att ta bort spekulant.\n" + ex);
                }
            }
            if (!cbShowingRegisterBuyer.Checked && !cbShowingDeleteBuyer.Checked && cbShowingUpdateBuyer.Checked)
            {
                try
                {
                    int nrOfRows = controller.UpdateProspectiveBuyer(buyerSsnr, name, phoneNr, email);
                    if (nrOfRows == 0)
                    {
                        MessageBox.Show("Ingen sådan spekulant finns. Vänligen försök igen.");
                    }
                    else
                    {
                        Populate();
                        MessageBox.Show("Spekulant med personnummer " + buyerSsnr + " uppdaterad.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Det går inte att uppdatera spekulant.\n" + ex);
                }
            }
            if (!cbShowingRegisterBuyer.Checked && !cbShowingDeleteBuyer.Checked && !cbShowingUpdateBuyer.Checked)
            {
                MessageBox.Show("Vänligen gör ett val först.");
            }
        }

        private void cbObjRegister_CheckedChanged(object sender, EventArgs e)
        {

            if (cbObjectRegister.Checked)
            {
                btnObjectSubmit.Enabled = true;
                MakeTbEditable();
                lblObjectObjAddress.Text = "";
                lblObjCity.Text = "";
                lblObjectObjectPrice.Text = "";
                ClearObjectTb();
            }
            else if (cbObjectRegister.Checked == false)
            {
                btnObjectSubmit.Enabled = false;
                MakeTbReadOnly();
            }

        }

        private void cbObjUpdate_CheckedChanged(object sender, EventArgs e)
        {

            if (cbObjectUpdate.Checked)
            {
                btnObjectSubmit.Enabled = true;
                MakeTbEditable();
            }
            else if (cbObjectUpdate.Checked == false)
            {
                btnObjectSubmit.Enabled = false;
                MakeTbReadOnly();
            }
        }

        private void cbObjDeleteObject_CheckedChanged(object sender, EventArgs e)
        {
            btnObjectSubmit.Enabled = true;
            if (tbObjectDeleteObject.Checked)
            {
                btnObjectSubmit.Enabled = true;
                MakeTbReadOnly();

            }
            else if (tbObjectDeleteObject.Checked == false)
            {
                btnObjectSubmit.Enabled = false;
                MakeTbReadOnly();
            }
        }

        private void tbShowingSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblBrokerSelectedBroker_Click(object sender, EventArgs e)
        {

        }
    }
}


