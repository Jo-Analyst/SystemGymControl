﻿using System.Data;
using System.Data.SqlClient;

namespace Bussiness
{
    public class Package
    {
        private int id;
        private string description;
        private decimal valuePackage;
        private int duration;
        private string period;

        Database.Package package = new Database.Package();

        public int _id
        {
            get { return id; }
            set { id = value; }
        }
        public string _description
        {
            get { return description; }
            set { description = value; }
        }
        public int _duration
        {
            get { return duration; }
            set { duration = value; }
        }
        public decimal _value
        {
            get { return valuePackage; }
            set { valuePackage = value; }
        }
        public string _period
        {
            get { return period; }
            set { period = value; }
        }

        public string ValidateFieldsGetMessage()
        {
            string message = "";
            if (string.IsNullOrEmpty(_description))
                message = "Campo 'Descrição' obrigatório!";
            else if (_duration == 0)
                message = "Campo 'Duração' obrigatório!";
            else if (string.IsNullOrEmpty(_period))
                message = "Campo 'Período' obrigatório!";

            return message;
        }

        public void Save()
        {
            package._id = this._id;
            package._description = this._description;
            package._duration = this._duration;
            package._value = this._value;
            package._period = this._period;

            package.Save();
        }

        public void Delete(int idPackage)
        {
            package.Delete(idPackage);
        }

        public DataTable SearchAll()
        {
            return package.SearchAll();
        }
        
        public DataTable SearchDescription(string description)
        {
            return package.SearchDescription(description);
        }


        public SqlDataReader SearchID(int idPackage)
        {
            return package.SearchID(idPackage);
        }
    }
}
