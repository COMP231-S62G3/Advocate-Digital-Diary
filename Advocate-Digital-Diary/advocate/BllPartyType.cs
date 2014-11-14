using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace advocate
{
    class BllPartyType
    {
        private int _PartyTypeId;
        private string _Title;

        public int PartyTypeId
        {
            set
            {
                _PartyTypeId = value;
            }
            get
            {
                return(_PartyTypeId);
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
                return(_Title);
            }
        }

        public DataTable GetAllParties()
        {
            DAL.cDAL obj = new DAL.cDAL();
            obj.CreateConnection(Program.ConnectionString);
            DataTable retvalue = obj.GetTableData("GetAllPartyType");
            obj.CloseConnection();
            return(retvalue);
        }

        public void GetAPArtyType(int value)
        {
            DAL.cDAL obj = new DAL.cDAL();
            obj.CreateConnection(Program.ConnectionString);
            DataTable tb = obj.GetTableData("GetAParty","@PartyTypeId",value);
            Title = tb.Rows[0][1].ToString();
        }
        
    }
}
