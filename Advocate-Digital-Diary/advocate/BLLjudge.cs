using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace advocate
{
    class BLLjudge
    {

        private int _JudgeId;
        private string _JudgeName;
        private string _JudgeGender;
        private string _JudgeAddress;
        private int _JudgePhoneno;


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
        public string JudgeName
        {
            set
            {
                _JudgeName = value;
            }
            get
            {
                return (_JudgeName);
            }
        }
        public string JudgeGender
        {
            set
            {
                _JudgeGender = value;
            }
            get
            {
                return (_JudgeGender);
            }
        }
        public string JudgeAddress
        {
            set
            {
                _JudgeAddress = value;
            }
            get
            {
                return (_JudgeAddress);
            }
        }
        public int JudgePhoneno
        {
            set
            {
                _JudgePhoneno = value;
            }
            get
            {
                return (_JudgePhoneno);
            }
        }

        public int SaveJudge()
        {
            DAL.cDAL obj = new DAL.cDAL();
            obj.CreateConnection(Program.ConnectionString);
            int retvalue = obj.ExecuteProcedure("addjudge", "@Name", _JudgeName, "@Address", _JudgeAddress, "@Gender", _JudgeGender, "@Phone", _JudgePhoneno.ToString());
            obj.CloseConnection();
            return (retvalue);


        }
        public void DeleteJudge()
        {
            DAL.cDAL obj = new DAL.cDAL();
            obj.CreateConnection(Program.ConnectionString);
            obj.ExecuteProcedure("deletejudge", "@judgeid", _JudgeId.ToString());

            obj.CloseConnection();
        }
        public DataTable GetAllJudges()
        {
            DAL.cDAL obj = new DAL.cDAL();
            obj.CreateConnection(Program.ConnectionString);
            DataTable tb = obj.GetTableData("getjudges");
            obj.CloseConnection();
            return (tb);
        }
        public int UpdateJudge()
        {
            DAL.cDAL obj = new DAL.cDAL();
            obj.CreateConnection(Program.ConnectionString);
            int retvalue = obj.ExecuteProcedure("updatejudge", "@judgeid", _JudgeId.ToString(), "@Name", _JudgeName, "@Gender", _JudgeGender, "@Address", _JudgeAddress, "@Phone", _JudgePhoneno.ToString());
            obj.CloseConnection();
            return (retvalue);
        }
        public void GetJudge(int value)
        {
            DAL.cDAL obj = new DAL.cDAL();
            obj.CreateConnection(Program.ConnectionString);
            DataTable tb = obj.GetTableData("getjudge", "@judgeid", value);
            JudgeName = tb.Rows[0][1].ToString();
            JudgeGender = tb.Rows[0][3].ToString();
            JudgeAddress = tb.Rows[0][2].ToString();
            JudgePhoneno = Convert.ToInt32(tb.Rows[0][4]);

        }
    }
}
