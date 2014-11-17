using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace advocate
{
    class BllPayment
    {
        private int _PaymentNo;
        private DateTime _Date;
        private float _Amount;
        private string _Mode;
        private string _ParticularNo;
        private string _Bank;
        private int _CaseId;

        public string Mode
        {
            set
            {
                _Mode = value;
            }
            get
            {
                return (_Mode);
            }
        }

        public string Bank
        {
            set
            {
                _Bank = value;
            }
            get
            {
                return (_Bank);
            }
        }

        public string ParticularNo
        {
            set
            {
                _ParticularNo = value;
            }
            get
            {
                return (_ParticularNo);
            }
        }

        public float Amount
        {
            set
            {
                _Amount = value;
            }
            get
            {
                return(_Amount);
            }
        }

        public DateTime Date
        {
            set
            {
                _Date = value;
            }
            get
            {
                return (_Date);
            }
        }

        public int PaymentNo
        {
            set
            {
                _PaymentNo = value;
            }
            get
            {
                return (_PaymentNo);
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

        public int SavePayment()
        {
            DAL.cDAL obj = new DAL.cDAL();
            obj.CreateConnection(Program.ConnectionString);
            int retvalue = obj.ExecuteProcedure("AddPayment","@Date", _Date.ToShortDateString(), "@Amount", _Amount.ToString(),"@Mode",_Mode,"@ParticularNo",_ParticularNo,"@Bank",_Bank, "@CaseId", _CaseId.ToString());
            obj.CloseConnection();
            return (retvalue);
        }

        public void DeletePayment()
        {
            DAL.cDAL obj = new DAL.cDAL();
            obj.CreateConnection(Program.ConnectionString);
            obj.ExecuteProcedure("DeletePayment", "@PaymentNo", _PaymentNo.ToString());
            obj.CloseConnection();
        }

        public DataTable GetPayments(int value)
        {
            DAL.cDAL obj = new DAL.cDAL();
            obj.CreateConnection(Program.ConnectionString);
            DataTable tb = obj.GetTableData("GetAllPayment", "@CaseId", value);
            obj.CloseConnection();
            return (tb);
        }

        public DataTable GetPayment(int value)
        {
            DAL.cDAL obj = new DAL.cDAL();
            obj.CreateConnection(Program.ConnectionString);
            DataTable tb = obj.GetTableData("GetPayment", "@CaseId", value);
            obj.CloseConnection();
            return (tb);
        }


    }
}
