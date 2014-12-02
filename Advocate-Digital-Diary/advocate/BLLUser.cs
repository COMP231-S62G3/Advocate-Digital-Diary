using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace advocate
{
    class BLLUser
    {
        private int _UserNo;
        private string _UserId;
        private string _Password;
        private string _Name;
        private string _UserType;
        private string _Permissions;


        public int UserNo
        {
            set
            {
                _UserNo = value;
            }
            get
            {
                return (_UserNo);
            }
        }

        public string UserId
        {
            set
            {
                _UserId = value;
            }
            get
            {
                return (_UserId);
            }
        }

        public string Password
        {
            set
            {
                _Password = value;
            }
            get
            {
                return (_Password);
            }
        }

        public string UserName
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

        public string UserType
        {
            set
            {
                _UserType = value;
            }
            get
            {
                return (_UserType);
            }
        }

        public string Permissions
        {
            set
            {
                _Permissions = value;
            }
            get
            {
                return (_Permissions);
            }
        }

        public int AuthenticateUser()
        {
            DAL.cDAL obj = new DAL.cDAL();
            obj.CreateConnection(Program.ConnectionString);
            DataTable tb = obj.GetTableData("AuthenticateUser", true, "@UserId", _UserId, "@Password", _Password);

            obj.CloseConnection();

            if (tb.Rows.Count > 0)
            {
                Program.UserNo = Convert.ToInt32(tb.Rows[0][0]);
                Program.Password = tb.Rows[0][2].ToString();
                Program.UserType = tb.Rows[0][4].ToString();
                Program.Permissions = tb.Rows[0][5].ToString();
            }


            return (tb.Rows.Count);

        }

        public int SaveUser()
        {
            DAL.cDAL obj = new DAL.cDAL();
            obj.CreateConnection(Program.ConnectionString);
            int retvalue = obj.ExecuteProcedure("addusers", "@userid", _UserId, "@Password", _Password, "@Name", _Name, "@usertype", _UserType,"@permissions",_Permissions);
            obj.CloseConnection();
            return (retvalue);
        }

        public void DeleteUser(int pUserNo)
        {
            DAL.cDAL obj = new DAL.cDAL();
            obj.CreateConnection(Program.ConnectionString);
            obj.ExecuteProcedure("deleteuser", "@userno", pUserNo.ToString());
            obj.CloseConnection();
        }

        public int UpdateUser(int pUserNo)
        {
            DAL.cDAL obj = new DAL.cDAL();
            obj.CreateConnection(Program.ConnectionString);
            int retvalue = obj.ExecuteProcedure("updateuser","userno",pUserNo.ToString(), "@userid", _UserId, "@Name", _Name, "@Password", _Password, "@Usertype", _UserType, "@Permissions", _Permissions);
            obj.CloseConnection();
            return (retvalue);
        }

        public DataTable GetAllusers()
        {
            DAL.cDAL obj = new DAL.cDAL();
            obj.CreateConnection(Program.ConnectionString);
            DataTable tb = obj.GetTableData("getallusers");
            obj.CloseConnection();
            return (tb);
        }

        public void GetUser(int value)
        {
            DAL.cDAL obj = new DAL.cDAL();
            obj.CreateConnection(Program.ConnectionString);
            DataTable tb = obj.GetTableData("getuser", "@userno", value);
            UserId = tb.Rows[0][1].ToString();
            Password = tb.Rows[0][2].ToString();
            UserName = tb.Rows[0][3].ToString();
            UserType = tb.Rows[0][4].ToString();
            Permissions = tb.Rows[0][5].ToString();


        }
    }
}
