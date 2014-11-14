using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace advocate
{
    class BLLCases
    {
        private int _CaseId;
        private string _Title;
        private DateTime _FileDate;
        private int _CourtId;
        private int _JudgeId;
        private int _CaseTypeId;
        private string _Description;

        public DataTable tbPlaintiff;
        public DataTable tbDefendent;

        public int JudgeId
        {
            set
            {
                _JudgeId = value;
            }
            get
            {
                return (_JudgeId);
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
        public string Title
        {
            set
            {
                _Title = value;
            }
            get
            {
                return (_Title);
            }
        }
        public DateTime FileDate
        {
            set
            {
                _FileDate = value;
            }
            get
            {
                return (_FileDate);
            }
        }
        public int CourtId
        {
            set
            {
                _CourtId = value;
            }
            get
            {
                return (_CourtId);
            }
        }
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

        public BLLCases()
        {
            tbPlaintiff = new DataTable();

            tbPlaintiff.Columns.Add("Name");
            tbPlaintiff.Columns.Add("Address");
            tbPlaintiff.Columns.Add("City");
            tbPlaintiff.Columns.Add("Pin");
            tbPlaintiff.Columns.Add("Phone");
            tbPlaintiff.Columns.Add("PlaintiffId");

            tbDefendent = new DataTable();
            tbDefendent.Columns.Add("Name");
            tbDefendent.Columns.Add("Address");
            tbDefendent.Columns.Add("City");
            tbDefendent.Columns.Add("Pin");
            tbDefendent.Columns.Add("Phone");
            tbDefendent.Columns.Add("DefendantId");
        }
       
        public int SaveCase()
        {
            DAL.cDAL obj = new DAL.cDAL();
            obj.CreateConnection(Program.ConnectionString);
            int retvalue = obj.ExecuteProcedure("addCase",true,"@CaseNo",  "@Title", _Title, "@FileDate", _FileDate.ToShortDateString(), "@CourtId", _CourtId.ToString(), "@JudgeId", _JudgeId.ToString(),"@CaseTypeId",_CaseTypeId.ToString(),"@Description",_Description);
            
            foreach (DataRow row in tbPlaintiff.Rows)
            {
               obj.ExecuteProcedure("AddPlantiff", "@Name", row[0].ToString(), "@Address", row[1].ToString(), "@City", row[2].ToString(), "@Pin", row[3].ToString(), "@Phone", row[4].ToString(),"@CaseNo", retvalue.ToString ());
            }

            foreach (DataRow row in tbDefendent.Rows)
            {
                obj.ExecuteProcedure("Adddefendant", "@Name", row[0].ToString(), "@Address", row[1].ToString(), "@City", row[2].ToString(), "@Pin", row[3].ToString(), "@Phone", row[4].ToString(), "@CaseNo", retvalue.ToString ());
            }
            obj.CloseConnection();
            return (retvalue);
            
           
        }
        
        public void DeleteCase()
        {
            DAL.cDAL obj = new DAL.cDAL();
            obj.CreateConnection(Program.ConnectionString);
            obj.ExecuteProcedure("deleteACase", "@CaseId", _CaseId.ToString());

            obj.CloseConnection();
        }
        
        public DataTable GetAllCases()
        {
            DAL.cDAL obj = new DAL.cDAL();
            obj.CreateConnection(Program.ConnectionString);
            DataTable tb = obj.GetTableData("GetAllCase");
            obj.CloseConnection();
            return (tb);
        }
        
        public int UpdateCase()
        {
            DAL.cDAL obj = new DAL.cDAL();
            obj.CreateConnection(Program.ConnectionString);
            int retvalue = obj.ExecuteProcedure("UpdateACase", "@CaseId", _CaseId.ToString(), "@Title", _Title, 
                "@FileDate", _FileDate.ToShortDateString(), "@CourtId", _CourtId.ToString(), "@JudgeId", _JudgeId.ToString(),
                "@CasetypeId", _CaseTypeId.ToString(),"@Description",_Description);


            foreach (DataRow row in tbPlaintiff.Rows)
            {
                if (row[5].ToString() == "0")
                {
                    obj.ExecuteProcedure("AddPlantiff", "@Name", row[0].ToString(), "@Address", row[1].ToString(), "@City", row[2].ToString(), "@Pin", row[3].ToString(), "@Phone", row[4].ToString(), "@CaseNo", retvalue.ToString());
                }
                else
                {
                    obj.ExecuteProcedure("UpdatePlantiff", "@PlaintiffId", row[5].ToString(), "@Name", row[0].ToString(), "@Address", row[1].ToString(), "@City", row[2].ToString(), "@Pin", row[3].ToString(), "@Phone", row[4].ToString());
                }
            }

            foreach (DataRow row in tbDefendent.Rows)
            {
                if (row[5].ToString() == "0")
                {
                    obj.ExecuteProcedure("Adddefendant", "@Name", row[0].ToString(), "@Address", row[1].ToString(), "@City", row[2].ToString(), "@Pin", row[3].ToString(), "@Phone", row[4].ToString(), "@CaseNo", retvalue.ToString());
                }
                else
                {
                    obj.ExecuteProcedure("UpdateDefendant", "@DefendantId", row[5].ToString(), "@Name", row[0].ToString(), "@Address", row[1].ToString(), "@City", row[2].ToString(), "@Pin", row[3].ToString(), "@Phone", row[4].ToString());
                }
            }
            
            
            
            obj.CloseConnection();

            return (retvalue);
        }
        
        public void GetCase(int value)
        {
            DAL.cDAL obj = new DAL.cDAL();
            obj.CreateConnection(Program.ConnectionString);
            DataTable tb = obj.GetTableData("GetACase", "@CaseId", value);
            Title = tb.Rows[0][1].ToString();
            FileDate = Convert.ToDateTime( tb.Rows[0][2]);
            CourtId = Convert.ToInt32(tb.Rows[0][3]);
            JudgeId = Convert.ToInt32(tb.Rows[0][4]);
            CaseTypeId = Convert.ToInt32(tb.Rows[0][5]);
            Description = tb.Rows[0][6].ToString();

            DataTable tbP = obj.GetTableData("GetPlaintiffs", "@CaseNo", value);

            foreach (DataRow rw in tbP.Rows)
            {
                DataRow row = tbPlaintiff.NewRow();
                row[0] = rw[1].ToString();
                row[1] = rw[2].ToString();
                row[2] = rw[3].ToString();
                row[3] = rw[4].ToString();
                row[4] = rw[5].ToString();
                row[5] = rw[0].ToString();
               
                tbPlaintiff.Rows.Add(row);
            }

            DataTable tbD = obj.GetTableData("GetDefendants","@CaseNo",value);

            foreach (DataRow rw in tbD.Rows)
            {
                DataRow row = tbDefendent.NewRow();

                row[0] = rw[1].ToString();
                row[1] = rw[2].ToString();
                row[2] = rw[3].ToString();
                row[3] = rw[4].ToString();
                row[4] = rw[5].ToString();
                row[5] = rw[0].ToString();
               
                tbDefendent.Rows.Add(row);

            }
        
        }

        public DataTable GetCases(int pvalue)
        {
            DAL.cDAL obj = new DAL.cDAL();
            obj.CreateConnection(Program.ConnectionString);
            DataTable tb = obj.GetTableData("Getacase","@CaseId",pvalue);
            obj.CloseConnection();
            return (tb);
        }

        public DataTable GetDetailForCase(int pvalue)
        {
            DAL.cDAL obj = new DAL.cDAL();
            obj.CreateConnection(Program.ConnectionString);
            DataTable tb = obj.GetTableData("GetDetailForCase", "@CaseId", pvalue);
            obj.CloseConnection();
            return (tb);
        }


        public void AddPlaintiff( string Name, string Address, string City, int pin, int phone )
        {
            
            DataRow row = tbPlaintiff.NewRow();
            row[0] = Name;
            row[1] = Address;
            row[2] = City;
            row[3] = pin;
            row[4] = phone;
            
            tbPlaintiff.Rows.Add(row);

        }
        public void AddDefendant(string Name, string Address, string City, int pin, int phone )
        {

            DataRow row = tbDefendent.NewRow();
            row[0] = Name;
            row[1] = Address;
            row[2] = City;
            row[3] = pin;
            row[4] = phone;
            
            tbDefendent.Rows.Add(row);

        }       
    }
}
