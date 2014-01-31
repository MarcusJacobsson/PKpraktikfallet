﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace praktikfall
{
    class Controller
    {
        DataAccessLayer dal = new DataAccessLayer();

        //Lägg till OBJEKT
        public int AddObject(string objNr, string objAdress, string objCity, int objPrice, double objArea, string objRooms, string objUnitType,string objInfo, string brokerSsnr)
        {
            int nrOfRows = dal.AddObject(objNr, objAdress, objCity, objPrice, objArea, objRooms, objUnitType, objInfo, brokerSsnr);
            return nrOfRows;
        }
        //Ta bort OBJEKT
        public int DeleteObject(string objNr)
        {
            int nrOfRows = dal.DeleteObject(objNr);
            return nrOfRows;
        }
        //Uppdatera OBJEKT
        public int UpdateObject(string objNr, string objAdress, string objCity, int objPrice, double objArea, string objRooms, string objUnitType, string objInfo, string brokerSsnr)
        {
            int nrOfRows = dal.UpdateObject(objNr, objAdress, objCity, objPrice, objArea, objRooms, objUnitType, objInfo, brokerSsnr);
            return nrOfRows;
        }


        //Sökknapp i Objekt för att visa ett objekt med en viss söksträng
        public DataTable SearchObjectByString(string searchString)
        {
            DataTable dt = dal.SearchObjectByString(searchString);
            return dt;
             
        }
        //Söka OBJEKT
        public DataTable GetObject(string objNr)
        {
            DataTable dt = dal.GetObject(objNr);
            return dt;
        }
        //Hämta alla OBJEKT
        public DataTable GetAllObjectsNr()
        {
            DataTable dt = dal.GetAllObjectsNr();
            return dt;
        }
        //Lägg till MÄKLARE
        public int AddBroker(string brokerSsnr, string name, string brokerAddress, string city, string phoneNr, string email)
        {
            int nrOfRows = dal.AddBroker(brokerSsnr, name, brokerAddress, city, phoneNr, email);
            return nrOfRows;
        }
        //Ta bort MÄKLARE
        public int DeleteBroker(string brokerSsnr)
        {
            int nrOfRows = dal.DeleteBroker(brokerSsnr);
            return nrOfRows;
        }
        //Uppdatea MÄKLARE
        public int UpdateBroker(string brokerSsnr, string name, string brokerAddress, string city, string phoneNr, string email)
        {
            int nrOfRows = dal.UpdateBroker(brokerSsnr, name, brokerAddress, city, phoneNr, email);
            return nrOfRows;
        }
        //Söka MÄKLARE
        public DataTable GetBroker(string brokerSsnr)
        {
            DataTable dt = dal.GetBroker(brokerSsnr);
            return dt;
        }
        //lägga till spekulant
        public int AddProspectiveBuyer(string buyerSsnr, string name, string phoneNr, string email)
        {
            int nrOfRows = dal.AddProspectiveBuyer(buyerSsnr, name, phoneNr, email);
            return nrOfRows;
        }
        //Ta bort spekulant
        public int DeleteProspectiveBuyer(string buyerSsnr)
        {
            int nrOfRows = dal.DeleteProspectiveBuyer(buyerSsnr);
            return nrOfRows;
        }
        //Uppdatera spekulant
        public int UpdateProspectiveBuyer(string buyerSsnr, string name, string phoneNr, string email)
        {
            int nrOfRows = dal.UpdateProspectiveBuyer(buyerSsnr, name, phoneNr, email);
            return nrOfRows;
        }
        //Söka spekulant
        public DataTable GetProspectiveBuyer(string buyerSsnr)
        {
            DataTable dt = dal.GetProspectiveBuyer(buyerSsnr);
            return dt;
        }
        //Hämta alla spekulanter
        public DataTable GetAllProspectiveBuyers()
        {
            DataTable dt = dal.GetAllProspectiveBuyers();
            return dt;
        }
        //Lägg till Ägare   ___OBS___ Lägger endast till en ägare i systemet. Kopplingen mellan Object och Owner görs ej här!
        public int AddObjectOwner(string ownerSsnr, string phoneNr, string email)
        {
            int nrOfRows = dal.AddObjectOwner(ownerSsnr, phoneNr, email);
            return nrOfRows;
        }
        //Ta bort Ägare
        public int RemoveObjectOwner(string ownerSsnr)
        {
            int nrOfRows = dal.RemoveObjectOwner(ownerSsnr);
            return nrOfRows;
        }
        //Uppdatera Ägare
        public int UpdateObjectOwner(string ownerSsnr, string phoneNr, string email)
        {
            int nrOfRows = dal.UpdateObjectOwner(ownerSsnr, phoneNr, email);
            return nrOfRows;
        }
        //Söka Ägare
        public DataTable GetObjectOwner (string ownerSsnr)
        {
            DataTable dt = dal.GetObjectOwner(ownerSsnr);
            return dt;
        }
        //Registrera givet OBJEKT med given ÄGARE     HÄR registreras ett objekts ägare
        public int RegisterObjectOwner(string objNr, string ownerSsnr)
        {
            int nrOfRows = dal.RegisterObjectOwner(objNr, ownerSsnr);
            return nrOfRows;
        }
        //registrera VISNING
        public int RegisterShowing (string objNr, string buyerSsnr, string showingDate)
        {
            int nrOfRows = dal.RegisterShowing(objNr, buyerSsnr, showingDate);
            return nrOfRows;
        }
    }
}