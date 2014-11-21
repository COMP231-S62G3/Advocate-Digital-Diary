using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace advocate
{
    class BllStatement
    {
        private int _StatementNo;
        private string _Statement;
        private int _HearingDateNo;
        private int _CaseId;
        private int _WitnessNo;
        private string _Witness;
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

        public int StatementNo
        {
            set
            {
                _StatementNo = value;
            }
            get
            {
                return (_StatementNo);
            }
        }

        public string Statement
        {
            set
            {
                _Statement = value;
            }
            get
            {
                return (_Statement);
            }
        }

        public string Witness
        {
            set
            {
                _Witness = value;
            }
            get
            {
                return (_Witness);
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


        public int SaveStatement()
        {
            DAL.cDAL obj = new DAL.cDAL();
            obj.CreateConnection(Program.ConnectionString);
            int retvalue = obj.ExecuteProcedure("addstatement", "@statement", _Statement, "@Hearingdateno", _HearingDateNo.ToString(),"@WitnessNo",_WitnessNo.ToString());
            obj.CloseConnection();
            return (retvalue);


        }
        public void DeleteStatement(int pStatementNo)
        {
            DAL.cDAL obj = new DAL.cDAL();
            obj.CreateConnection(Program.ConnectionString);
            obj.ExecuteProcedure("deletestatement", "@statementno", pStatementNo.ToString () );
            obj.CloseConnection();
        }
        public DataTable GetAllStatements()
        {
            DAL.cDAL obj = new DAL.cDAL();
            obj.CreateConnection(Program.ConnectionString);
            DataTable tb = obj.GetTableData("getallstatement");
            obj.CloseConnection();
            return (tb);
        }
        public int UpdateStatement()
        {
            DAL.cDAL obj = new DAL.cDAL();
            obj.CreateConnection(Program.ConnectionString);
            int retvalue = obj.ExecuteProcedure("updatestatement", "@statementno", _StatementNo.ToString(), "@Statement", _Statement, "@Hearingdateno", _HearingDateNo.ToString(),"@WitnessNo",_WitnessNo.ToString());
            obj.CloseConnection();
            return (retvalue);
        }
        public void GetStatement(int value)
        {
            DAL.cDAL obj = new DAL.cDAL();
            obj.CreateConnection(Program.ConnectionString);
            DataTable tb = obj.GetTableData("getstatementforhearingdate", "@hearingdateno", value);
            Statement = tb.Rows[0][1].ToString();
            HearingDateNo = Convert.ToInt32( tb.Rows[0][2]);
            CaseId = Convert.ToInt32( tb.Rows[0][3]);
        }


        public DataTable  GetWitnessStatements(int pWitnessNo)
        {
            DAL.cDAL obj = new DAL.cDAL();
            obj.CreateConnection(Program.ConnectionString);
            DataTable tb = obj.GetTableData("GetWitnessStatements", "WitnessNo", pWitnessNo);
            obj.CloseConnection();
            return (tb);

        }


    }
}
