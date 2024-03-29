﻿using System.Data;

namespace Bussiness
{
    public class ResponsibleStudent : Person
    {

        Database.ResponsibleStudent responsible = new Database.ResponsibleStudent();

        private string kinship;
        private int studentID;

        public override int _id { get; set; }
        public override string _name { get; set; }
        public override string _cpf { get; set; }
        public override string _phone { get; set; }
        public string _kinship
        {
            get { return kinship; }
            set { kinship = value; }
        }
        public int _studentID
        {
            get { return studentID; }
            set { studentID = value; }
        }

        public string ValidateFieldsAndGetMessage()
        {
            string message = null;

            if (string.IsNullOrEmpty(this._name))
                message = "Campo Nome do responsável obrigatório!";
           else if (string.IsNullOrEmpty(this._kinship))
                message = "Campo Grau de Parentesco obrigatório!";
            else if (!CPF.ValidateCPF(this._cpf) && this._cpf.Length == 14)
                message = "CPF inválido!";

            return message;
        }

        public override void Save()
        {
            responsible._id = this._id;
            responsible._name = this._name;
            responsible._cpf = this._cpf;
            responsible._kinship = this._kinship;
            responsible._studentID = this._studentID;
            responsible._phone = this._phone;
            responsible.Save();
        }

        public override DataTable SearchID(int studentID)
        {
            return responsible.SearchID(studentID);
        }
    }
}