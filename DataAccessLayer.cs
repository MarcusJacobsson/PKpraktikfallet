﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;



namespace praktikfall
{
    class DataAccessLayer
    {
        string connectionString = "server=localhost; Trusted_Connection=yes; database=PK Praktikfallet;";

        //generisk metod för att skicka query som uppdaterar eller lägger till nya objekt
        private int ExecuteUpdate(string sqlStr)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                Debug.WriteLine(sqlStr);
                SqlCommand com = new SqlCommand(sqlStr, con);
                int nrOfRows = com.ExecuteNonQuery();
                con.Close();
                Debug.WriteLine("denna metoden har fungerat , duktigt august!");
                return nrOfRows;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("{0} Exception caught.", ex);
                return 0;
            }
        }

        //Generisk metod för att exempelvis söka objekt
        private DataTable ExecuteQuery(string sqlStr)
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                Console.WriteLine(sqlStr);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlStr, con);
                dataAdapter.Fill(dataTable);
                con.Close();
                Debug.WriteLine("denna metoden har fungerat , duktigt august!");
            }
            catch (Exception ex)
            {
                Debug.WriteLine("{0} Exception caught.", ex);
            }
            return dataTable;
        }


       //Lägg till OBJEKT
        public int AddObject(string objNr, string objAdress, string objCity, int objPrice, double objArea, string objRooms, string objUnitType, string objInfo, string brokerSsnr)
        {
            string sqlStr = "insert into RealEstateObject values ('";
            sqlStr += objNr + "','" + objAdress + "','" + objCity + "','" + objPrice + 
                "','" + objArea + "','"  + objRooms + "','" + objUnitType + "','" + objInfo + "','" + brokerSsnr + "')";
            int nrOfRows = ExecuteUpdate(sqlStr);
            return nrOfRows;
            
        }
        //Ta bort OBJEKT
        public int DeleteObject(string objNr)
        {
            string sqlStr = "delete from RealEstateObject where objNr = '" + objNr + "'";
            int nrOfRows = ExecuteUpdate(sqlStr);
            return nrOfRows;
        }
        //Uppdatera OBJEKT
        public int UpdateObject(string objNr, string objAdress, string objCity, int objPrice, double objArea, string objRooms, string objUnitType, string objInfo, string brokerSsnr)
        {
            string sqlStr = "update RealEstateObject set objAdress = '" + objAdress + "',objCity = '" + objCity + 
                "', objPrice = '" + objPrice + "', objArea = '" + objArea + 
                "', objRooms = '" + objRooms + "', objUnitType = '" + objUnitType +
                "', objInfo = '" + objInfo + "',brokerSsnr = '" + brokerSsnr + "' where objNr = '" + objNr + "'";
            int nrOfRows = ExecuteUpdate(sqlStr);
            return nrOfRows;
        }
        //Söka OBJEKT
        public DataTable GetObject(string objNr)
        {
            string sqlStr = "select * from RealEstateObject where objNr = '" + objNr + "'";
            DataTable dt = ExecuteQuery(sqlStr);
            return dt;
        }
        // Hämta alla OBJEKT
        public DataTable GetAllObjectsNr()
        {
            string sqlStr = "select * from RealEstateObject";
            DataTable dt = ExecuteQuery(sqlStr);
            return dt;
        }

        //Sökknapp i Objekt för att visa objekt med viss sträng
        public DataTable SearchObjectByString(string searchString)
        {
            string sqlStr = "Select * from RealEstateObject where objNr like '%" + searchString + "%' or objAdress like '%" + searchString + "%' or objCity like '%" + searchString + "%' or objPrice like '%" + searchString + "%' or objArea like '%" + searchString + "%' or objRooms like '%" + searchString + "%' or objUnitType like '%" + searchString + "%'";
            DataTable dt = ExecuteQuery(sqlStr);
            return dt;
        }
       

        //Lägg till MÄKLARE
        public int AddBroker(string brokerSsnr, string name, string brokerAddress, string city, string phoneNr, string email)
        {

            string sqlStr = "insert into RealEstateBroker values ('";
            sqlStr += brokerSsnr + "','" + name + "','" + brokerAddress + "','" + city + "','" + phoneNr + "','" + email + "')";
            int nrOfRows = ExecuteUpdate(sqlStr);
            return nrOfRows;
        }
        //Ta bort MÄKLARE
        public int DeleteBroker(string brokerSsnr)
        {
            string sqlStr = "delete from RealEstateBroker where brokerSsnr = '" + brokerSsnr + "'";
            int nrOfRows = ExecuteUpdate(sqlStr);
            return nrOfRows;
        }
        //Uppdatera MÄKLARE
        public int UpdateBroker(string brokerSsnr, string name, string brokerAddress, string city, string phoneNr, string email)
        {
            string sqlStr = "update RealEstateBroker set name = '" + name + "', brokerAddress = '" + brokerAddress + "', city = '" + city + "', phoneNr = '" + phoneNr + "', email = '" + email + "' where brokerSsnr = '" + brokerSsnr + "'";
            int nrOfRows = ExecuteUpdate(sqlStr);
            return nrOfRows;
        }
        //Söka MÄKLARE
        public DataTable GetBroker(string brokerSsnr)
        {
            string sqlStr = "select * from RealEstateBroker where brokerSsnr = '" + brokerSsnr + "'";
            DataTable dt = ExecuteQuery(sqlStr);
            return dt;
        }
        //Lägga till spekulant
        public int AddProspectiveBuyer(string buyerSsnr, string name, string phoneNr, string email)
        {
            string sqlStr = "insert into ProspectiveBuyer values('" + buyerSsnr + "','" + name + "','" + phoneNr + "','" + email + "')";
            int nrOfRows = ExecuteUpdate(sqlStr);
            return nrOfRows;
        }
        //Ta bort spekulant
        public int DeleteProspectiveBuyer(string buyerSsnr)
        {
            string sqlStr = "delete from ProspectiveBuyer where buyerSsnr = '" + buyerSsnr + "'";
            int nrOfRows = ExecuteUpdate(sqlStr);
            return nrOfRows;
        }
        //Uppdatera spekulant
        public int UpdateProspectiveBuyer(string buyerSsnr, string name, string phoneNr, string email)
        {
            string sqlStr = "update ProspectiveBuyer set name = '" + name + "', phoneNr = '" + phoneNr + "', email = '" + email + "' where buyerSsnr = '" + buyerSsnr + "'";
            int nrOfRows = ExecuteUpdate(sqlStr);
            return nrOfRows;
        }
        //Söka spekulant
        public DataTable GetProspectiveBuyer(string buyerSsnr)
        {
            string sqlStr = "select * from ProspectiveBuyer where buyerSsnr = '" + buyerSsnr + "'";
            DataTable dt = ExecuteQuery(sqlStr);
            return dt;
        }
        //Hämta alla spekulanter
        public DataTable GetAllProspectiveBuyers()
        {
            string sqlStr = "select * from Prospectivebuyer";
            DataTable dt = ExecuteQuery(sqlStr);
            return dt;
        }
        //Lägg till Ägare   ___OBS___ Lägger endast till en ägare i systemet. Kopplingen mellan Object och Owner görs ej här!
        public int AddObjectOwner(string ownerSsnr, string phoneNr, string email)
        {
            string sqlStr = "insert into ObjectOwner values ('" + ownerSsnr + "','" + phoneNr + "','" + email + "')";
            int nrOfRows = ExecuteUpdate(sqlStr);
            return nrOfRows;
        }
        //Ta bort ägare
        public int RemoveObjectOwner(string ownerSsnr)
        {
            string sqlStr = "delete from ObjectOwner where ownerSsnr = '" + ownerSsnr + "'";
            int nrOfRows = ExecuteUpdate(sqlStr);
            return nrOfRows;
        }
        //Uppdatera Ägare
        public int UpdateObjectOwner(string ownerSsnr, string phoneNr, string email)
        {
            string sqlStr = "update ObjectOwner set phoneNr = '" + phoneNr + "', email = '" + email + "' where ownerSsnr = '" + ownerSsnr + "'";
            int nrOfRows = ExecuteUpdate(sqlStr);
            return nrOfRows;
        }
        //Söka Ägare
        public DataTable GetObjectOwner(string ownerSsnr)
        {
            string sqlStr = "select * from ObjectOwner where ownerSsnr = '" + ownerSsnr + "'";
            DataTable dt = ExecuteQuery(sqlStr);
            return dt;
        }
        //Registrera givet OBJEKT med given ÄGARE     HÄR registreras ett objekts ägare
        public int RegisterObjectOwner(string objNr, string ownerSsnr)
        {
            string sqlStr = "insert into HasOwner values ('" + objNr + "','" + ownerSsnr + "')";
            int nrOfRows = ExecuteUpdate(sqlStr);
            return nrOfRows;
        }   
        //Registrera VISNING
        public int RegisterShowing(string objNr, string buyerSsnr, string showingDate)
        {
            string sqlStr = "insert into Showing values ('" + objNr + "','" + buyerSsnr + "','" + showingDate + "')";
            int nrOfRows = ExecuteUpdate(sqlStr);
            return nrOfRows;
        }
    }
}