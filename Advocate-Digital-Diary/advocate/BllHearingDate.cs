using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace advocate
{
    class BllHearingDate
    {
        private string _Description;
        private DateTime _Date;
        private int _HearingDateNo;
        private int _CaseId;

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

        public int HearingDateNo
        {
            set
            {
                _HearingDateNo = value;
            }
            get
            {
                return (_HearingDateNo);
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

        public int SaveDate()
        {
            DAL.cDAL obj = new DAL.cDAL();
            obj.CreateConnection(Program.ConnectionString);
            int retvalue = obj.ExecuteProcedure("Adddate", "@Date", _Date.ToShortDateString(), "@Description", _Description, "@CaseId", _CaseId.ToString());
            obj.CloseConnection();
            return (retvalue);
        }

        public void DeleteDate()
        {
            DAL.cDAL obj = new DAL.cDAL();
            obj.CreateConnection(Program.ConnectionString);
            obj.ExecuteProcedure("DeleteDate", "@HearingDateNo", _HearingDateNo.ToString());
            obj.CloseConnection();
        }

        public DataTable GetDates(int value)
        {
            DAL.cDAL obj = new DAL.cDAL();
            obj.CreateConnection(Program.ConnectionString);
            DataTable tb = obj.GetTableData("GetDate", "@CaseId", value);
            obj.CloseConnection();
            return (tb);
        }

        public DataTable GetUpcomingCases()
        {
            DAL.cDAL obj = new DAL.cDAL();
            obj.CreateConnection(Program.ConnectionString);
            DataTable tb = obj.GetTableData("upcoming");
            obj.CloseConnection();
            return (tb);
        }


    }
}
