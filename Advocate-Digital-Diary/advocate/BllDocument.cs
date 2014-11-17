using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace advocate
{
    class BllDocument
    {
        private string _Name;
        private DateTime _ReceivingDate;
        private string _Description;
        private int _CaseId;
        private int _DocumentNo;

        public string Description
        {
            set
            {
                _Description = value;
            }
            get
            {
                return (_Description);
            }
        }

        public string Name
        {
            set
            {
                _Name = value;
            }
            get
            {
                return (_Name);
            }
        }

        public int DocumentNo
        {
            set
            {
                _DocumentNo = value;
            }
            get
            {
                return (_DocumentNo);
            }
        }

        public int CaseId
        {
            set
            {
                _CaseId = value;
            }
            get
            {
                return (_CaseId);
            }
        }

        public DateTime ReceivingDate
        {
            set
            {
                _ReceivingDate = value;
            }
            get
            {
                return (_ReceivingDate);
            }
        }

        public int SaveDocument()
        {
            DAL.cDAL obj = new DAL.cDAL();
            obj.CreateConnection(Program.ConnectionString);
            int retvalue = obj.ExecuteProcedure("AddDocument", "@Name", _Name, "@ReceivingDate", _ReceivingDate.ToShortDateString(), "@Description", _Description, "@CaseId", _CaseId.ToString());
            obj.CloseConnection();
            return (retvalue);
        }

        public void DeleteDocument()
        {
            DAL.cDAL obj = new DAL.cDAL();
            obj.CreateConnection(Program.ConnectionString);
            obj.ExecuteProcedure("DeleteDocument", "@DocumentNo", _DocumentNo.ToString());
            obj.CloseConnection();
        }

        public DataTable GetDocuments(int value)
        {
            DAL.cDAL obj = new DAL.cDAL();
            obj.CreateConnection(Program.ConnectionString);
            DataTable tb = obj.GetTableData("GetAllDocument", "@CaseId", value);
            obj.CloseConnection();
            return (tb);
        }
    }
}
