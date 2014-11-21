using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace advocate
{
    class BLLActs
    {
        private int _ActId;
        private string _ActName;
        private string _Description;
       
        public int ActId
        {
            set
            {
                _ActId = value;
            }
            get
            {
                return (_ActId);
            }
        }
        public string ActName
        {
            set
            {
                _ActName = value;
            }
            get
            {
                return (_ActName);
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
       

        public int SaveAct()
        {
            DAL.cDAL obj = new DAL.cDAL();
            obj.CreateConnection(Program.ConnectionString);
            int retvalue = obj.ExecuteProcedure("addact", "@Name", _ActName, "@Description", _Description);
            obj.CloseConnection();
            return (retvalue);


        }
        public void DeleteAct()
        {
            DAL.cDAL obj = new DAL.cDAL();
            obj.CreateConnection(Program.ConnectionString);
            obj.ExecuteProcedure("deleteact", "@actid", _ActId.ToString());

            obj.CloseConnection();
        }
        public DataTable GetActs()
        {
            DAL.cDAL obj = new DAL.cDAL();
            obj.CreateConnection(Program.ConnectionString);
            DataTable tb = obj.GetTableData("getacts");
            obj.CloseConnection();
            return (tb);
        }
        public int UpdateAct()
        {
            DAL.cDAL obj = new DAL.cDAL();
            obj.CreateConnection(Program.ConnectionString);
            int retvalue = obj.ExecuteProcedure("updateact", "@actid", _ActId.ToString(), "@Name", _ActName, "@Description", _Description);
            obj.CloseConnection();
            return (retvalue);
        }
        public void GetAct(int value)
        {
            DAL.cDAL obj = new DAL.cDAL();
            obj.CreateConnection(Program.ConnectionString);
            DataTable tb = obj.GetTableData("getact", "@actid", value);
            ActName = tb.Rows[0][1].ToString();
            Description = tb.Rows[0][2].ToString();
        }
    }
}
