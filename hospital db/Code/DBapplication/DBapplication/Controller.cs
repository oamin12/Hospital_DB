using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DBapplication
{
    public class Controller
    {
        DBManager dbMan;

        public Controller()
        {
            dbMan = new DBManager();
        }

        public int Insert()
        {
            string query = $"INSERT INTO  Values ();";
            return dbMan.ExecuteNonQuery(query);
        }
        public int InsertAperson(string Fname,string LName,string ID,string BOD,string Gender)
        {
            string query = $"INSERT INTO Person Values ('{Fname}','{LName}',{ID},'{BOD}','{Gender}');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertaDr(string ID, string Salary, string DID, string SuperID, string PersonID)
        {
            string query;
            if (SuperID == "-1")
            {
                query = $"INSERT INTO Doctors(ID,Salary,DepID,PersonID) Values ({ID},{Salary},{DID},{PersonID});";
                return dbMan.ExecuteNonQuery(query);
            }
            query = $"INSERT INTO Doctors Values ({ID},{Salary},{DID},{SuperID},{PersonID});";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertEmployee(string ID, string PersonID, string EmpType, string Salary, string DID )
        {
            string query;
            query = $"INSERT INTO Employee Values ({ID},{PersonID},{EmpType},{Salary},{DID});";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertaNurse(string ID, string Salary,string PersonID,string SuperID)
        {
            string query;
            if (SuperID == "-1")
            {
                query = $"INSERT INTO Nurse(ID,Salary,PersonID) Values ({ID},{Salary},{PersonID});";
                return dbMan.ExecuteNonQuery(query);
            }
            query = $"INSERT INTO Nurse Values ({ID},{Salary},{PersonID},{SuperID});";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertUser(string pass,string ID, string username,string UserTypeID)
        {
            string query = $"INSERT INTO Users Values ('{pass}',{ID},'{username}',{UserTypeID});";
            return dbMan.ExecuteNonQuery(query);
        }

        public int Delete()
        {
            string query = $"DELETE FROM  WHERE ";
            return dbMan.ExecuteNonQuery(query);
        }

        public int Update()
        {
            string query = $"UPDATE SET WHERE ;";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable Select()
        {
            string query = $"SELECT * FROM ;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable UserNameExists(string username)
        {
            string query = $"SELECT Username FROM Users where Username='{username}';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable IDExists(string ID)
        {
            string query = $"SELECT ID FROM Person where ID='{ID}';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable checkpass(string pass,string username)
        {
            string query = $"SELECT Username FROM Users where passwords='{pass}' AND Username='{username}';";
            return dbMan.ExecuteReader(query);
        }
        public int getUserTypeID(string username)
        {
            string query = $"SELECT UserTypeID FROM Users where Username='{username}';";
            return (int)dbMan.ExecuteScalar(query);
        }
        public DataTable SelectAllUserType()
        {
            string query = $"SELECT Tname FROM Usertype;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAllPersonID()
        {
            string query = $"SELECT ID FROM Person;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAllDrID()
        {
            string query = $"SELECT ID FROM Doctors;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAllNurseID()
        {
            string query = $"SELECT ID FROM Nurse;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectAllDeps()
        {
            string query = $"SELECT DepName FROM Department;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAllEmpType()
        {
            string query = $"SELECT Tname FROM EmployeeType;";
            return dbMan.ExecuteReader(query);
        }
        public int Count()
        {
            string query = $"SELECT COUNT() FROM ;";
            return (int)dbMan.ExecuteScalar(query);
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
