using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace advocate
{
    class BLLcourt
    {
        private int _CourtId;
        private string _CourtName;
        private string _State;
        private string _City;
        private string _Description;

        public int CourtId
        {
            set
            {
                _CourtId = value;
            }
            get
            {
                return(_CourtId);
            }
        }
        public string CourtName
        {
            set
            {
                _CourtName = value;
            }
            get
            {
                return(_CourtName);
            }
        }
        public string State
        {
            set
            {
                _State = value;
            }
            get
            {
                return (_State);
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
        public int SaveCourt()
        {
            DAL.cDAL obj = new DAL.cDAL();
            obj.CreateConnection(Program.ConnectionString);
            int retvalue = obj.ExecuteProcedure("addcourt", "@Name", _CourtName, "@State", _State, "@City", _City, "@Description", _Description);
            obj.CloseConnection();
            return (retvalue);
        }
        public void DeleteCourt()
        {
            DAL.cDAL obj = new DAL.cDAL();
            obj.CreateConnection(Program.ConnectionString);
            obj.ExecuteProcedure("deletecourt", "@courtid", _CourtId.ToString());
            obj.CloseConnection();
        }
        public DataTable GetAllCourt()
        {
            DAL.cDAL obj = new DAL.cDAL();
            obj.CreateConnection(Program.ConnectionString);
            DataTable tb = obj.GetTableData("getcourts");
            obj.CloseConnection();
            return (tb);
        }
        public int UpdateCourt()
        {
            DAL.cDAL obj = new DAL.cDAL();
            obj.CreateConnection(Program.ConnectionString);
            int retvalue = obj.ExecuteProcedure("updatecourt", "@courtid", _CourtId.ToString(), "@Name", _CourtName, "@State", _State, "@City", _City, "@Description", _Description);
            obj.CloseConnection();
            return (retvalue);
        }
        public void GetCourt(int value)
        {
            DAL.cDAL obj = new DAL.cDAL();
            obj.CreateConnection(Program.ConnectionString);
            DataTable tb = obj.GetTableData("getcourt", "@courtid", value);
            CourtName = tb.Rows[0][1].ToString();
            State = tb.Rows[0][2].ToString();
            City = tb.Rows[0][3].ToString();
            Description = tb.Rows[0][4].ToString();
            
        }
            
    }
}
