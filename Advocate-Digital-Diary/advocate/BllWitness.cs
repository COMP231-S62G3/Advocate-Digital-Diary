using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace advocate
{
    class BllWitness
    {
        private int _WitnessNo;
        private string _Name;
        private string _Address;
        private string _City;
        private int _Pin;
        private int _Phone;
        private int _CaseId;

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

        public string Address
        {
            set
            {
                _Address = value;
            }
            get
            {
                return (_Address);
            }
        }

        public string City
        {
            set
            {
                _City = value;
            }
            get
            {
                return (_City);
            }
        }

        public int WitnessNo
        {
            set
            {
                _WitnessNo = value;
            }
            get
            {
                return (_WitnessNo);
            }
        }

        public int Pin
        {
            set
            {
                _Pin = value;
            }
            get
            {
                return (_Pin);
            }
        }

        public int Phone
        {
            set
            {
                _Phone = value;
            }
            get
            {
                return (_Phone);
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

        public int SaveWitness()
        {
            DAL.cDAL obj = new DAL.cDAL();
            obj.CreateConnection(Program.ConnectionString);
            int retvalue = obj.ExecuteProcedure("AddWitness", "@Name", _Name, "@Address", _Address, "@City", _City, "@Pin",_Pin.ToString(),"@Phone", _Phone.ToString(),"@CaseId",_CaseId.ToString());
            obj.CloseConnection();
            return (retvalue);
        }

        public void DeleteWitness()
        {
            DAL.cDAL obj = new DAL.cDAL();
            obj.CreateConnection(Program.ConnectionString);
            obj.ExecuteProcedure("DeleteWitness", "@WitnessNo",_WitnessNo.ToString());
            obj.CloseConnection();
        }

        public DataTable GetAllWitness()
        {
            DAL.cDAL obj = new DAL.cDAL();
            obj.CreateConnection(Program.ConnectionString);
            DataTable tb = obj.GetTableData("GetAllWitnesses");
            obj.CloseConnection();
            return (tb);
        }

        public DataTable GetAWitness(int value)
        {
            DAL.cDAL obj = new DAL.cDAL();
            obj.CreateConnection(Program.ConnectionString);
            DataTable tb = obj.GetTableData("GetWitnessesforhearings","@CaseId", value);
            obj.CloseConnection();
            return (tb);
        }


        public int UpdateWitness()
        {
            DAL.cDAL obj = new DAL.cDAL();
            obj.CreateConnection(Program.ConnectionString);
            int retvalue = obj.ExecuteProcedure("UpdateWitness", "@WitnessNo", _WitnessNo.ToString(), "@Name", _Name, "@Address", _Address, "@City", _City,"@Pin",_Pin.ToString(), "@Phone", _Phone.ToString(),"@CaseId",_CaseId.ToString());
            obj.CloseConnection();
            return (retvalue);
        }

        public void GetWitness(int value)
        {
            DAL.cDAL obj = new DAL.cDAL();
            obj.CreateConnection(Program.ConnectionString);
            DataTable tb = obj.GetTableData("GetWitness", "@WitnessNo", value);
            Name = tb.Rows[0][1].ToString();
            Address = tb.Rows[0][2].ToString();
            City = tb.Rows[0][3].ToString();
            Pin = Convert.ToInt32( tb.Rows[0][4]);
            Phone = Convert.ToInt32(tb.Rows[0][5]);
            CaseId = Convert.ToInt32(tb.Rows[0][6]);
        }

        public DataTable GetWitnesses(int value)
        {
            DAL.cDAL obj = new DAL.cDAL();
            obj.CreateConnection(Program.ConnectionString);
            DataTable tb = obj.GetTableData("GetWitnesses2", "@CaseId", value);
            obj.CloseConnection();
            return (tb);
        }

    }
}
