using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace advocate
{
    class BLLcasetype
    {
        private int _CaseTypeId;
        private string _CaseTypeName;
        private string _Description;

        public int CaseTypeId
        {
            set
            {
                _CaseTypeId = value;
            }
            get
            {
                return (_CaseTypeId);
            }
        }
        public string CaseTypeName
        {
            set
            {
                _CaseTypeName = value;
            }
            get
            {
                return (_CaseTypeName);
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
        public int SaveCaseType()
        {
            DAL.cDAL obj = new DAL.cDAL();
            obj.CreateConnection(Program.ConnectionString);
            int retvalue = obj.ExecuteProcedure("addcasetype", "@Name", _CaseTypeName,"@Description", _Description);
            obj.CloseConnection();
            return (retvalue);
        }
        public void DeleteCaseType()
        {
            DAL.cDAL obj = new DAL.cDAL();
            obj.CreateConnection(Program.ConnectionString);
            obj.ExecuteProcedure("deletecasetype", "@casetypeid", _CaseTypeId.ToString());
            obj.CloseConnection();
        }
        public DataTable GetAllCaseType()
        {
            DAL.cDAL obj = new DAL.cDAL();
            obj.CreateConnection(Program.ConnectionString);
            DataTable tb = obj.GetTableData("getcasetypes");
            obj.CloseConnection();
            return (tb);
        }
        public int UpdateCaseType()
        {
            DAL.cDAL obj = new DAL.cDAL();
            obj.CreateConnection(Program.ConnectionString);
            int retvalue = obj.ExecuteProcedure("updatecasetype", "@casetypeid",_CaseTypeId.ToString(),"@Name", _CaseTypeName,"@Description", _Description);
            obj.CloseConnection();
            return (retvalue);
        }
        public void GetCaseType(int value)
        {
            DAL.cDAL obj = new DAL.cDAL();
            obj.CreateConnection(Program.ConnectionString);
            DataTable tb = obj.GetTableData("getcasetype", "@casetypeid", value);
            CaseTypeName = tb.Rows[0][1].ToString();
            Description = tb.Rows[0][2].ToString();
            
        }
        
            
    
    }
}
