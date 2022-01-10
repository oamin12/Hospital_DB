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
        public int InsertAperson(string Fname,string LName,string BOD,string Gender)
        {
            string query = $"INSERT INTO Person Values ('{Fname}','{LName}','{BOD}','{Gender}');";
            return dbMan.ExecuteNonQuery(query);
        }


        public int InsertPersonNoID(string Fname, string Lname, string BOD, string Gender)
        {
            string query = $"INSERT INTO Person(FName,LName,BoD,gender)  Values ('{Fname}','{Lname}','{BOD}','{Gender}');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertaDr(string Salary, string DID,string PersonID ,string SuperID)
        {
            string query;
            if (SuperID == "-1" || SuperID == "")
            {
                query = $"INSERT INTO Doctors(Salary,DepID,PersonID) Values ({Salary},{DID},{PersonID});";
                return dbMan.ExecuteNonQuery(query);
            }
            query = $"INSERT INTO Doctors Values ({Salary},{DID},{SuperID},{PersonID});";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertEmployee(string PersonID, string EmpType, string Salary, string DID )
        {
            string query;
            query = $"INSERT INTO Employee Values ({PersonID},{EmpType},{Salary},{DID});";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertaNurse(string Salary,string PersonID,string SuperID)
        {
            string query;
            if (SuperID == "-1" || SuperID == "")
            {
                query = $"INSERT INTO Nurse(Salary,PersonID) Values ({Salary},{PersonID});";
                return dbMan.ExecuteNonQuery(query);
            }
            query = $"INSERT INTO Nurse Values ({Salary},{PersonID},{SuperID});";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable LookUpPatient(string Fname, string Lname)
        {
            string query = $"SELECT P.ID, Pr.FName, Pr.LName, Pr.BoD, Pr.gender FROM Patient as P, Person as Pr Where Pr.FName = '{Fname}' AND Pr.LName = '{Lname}' AND P.PersonID = Pr.ID";
            return dbMan.ExecuteReader(query);
        }



        public int InsertUser(string pass,string ID, string username,string UserTypeID)
        {
            string query = $"INSERT INTO Users Values ('{pass}',{ID},'{username}',{UserTypeID});";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertAllergy(int patID , string allergy)
        {
            string query = $"INSERT INTO Patient_allergies Values ({patID},'{allergy}');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertDisease(int patID, string Disease)
        {
            string query = $"INSERT INTO Patient_Diseases Values ({patID},'{Disease}');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int Delete()
        {
            string query = $"DELETE FROM  WHERE ";
            return dbMan.ExecuteNonQuery(query);
        }
        public int DeletePatientsRequests(int patid)
        {
            string query = "DELETE FROM requests WHERE PatientID =  " + patid +";";
            return dbMan.ExecuteNonQuery(query);
        }
        public int DeletePatientsScans(int patid)
        {
            string query = "DELETE FROM Has_a_scan WHERE PatientID =  " + patid + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public int DeletePatientsAppointments(int patid)
        {
            string query = "DELETE FROM Appointment WHERE PatientID =  " + patid + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public int DeletePatientsOperations(int patid)
        {
            string query = "DELETE FROM operations WHERE PatientID =  " + patid + ";";
            return dbMan.ExecuteNonQuery(query);
        }




        public int Update()
        {
            string query = $"UPDATE SET WHERE ;";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateDr(string ID,string Fname,string Lname)
        {
            string query;
            if (Fname == "" && Lname!="")
            {
                query = $"UPDATE Person SET LName='{Lname}'  WHERE ID={ID};";
                return dbMan.ExecuteNonQuery(query);
            }
            if (Lname == "" && Fname!="")
            {
                query = $"UPDATE Person SET FName='{Fname}' WHERE ID={ID};";
                return dbMan.ExecuteNonQuery(query);
            }
            if (Fname == "" && Lname == "")
            {
                return 1;
            }
            query = $"UPDATE Person SET FName='{Fname}',LName='{Lname}'  WHERE ID={ID};";
            return dbMan.ExecuteNonQuery(query);
        }



        public int UpdateDrS(string ID,string Super)
        {
            string query = $"UPDATE Doctors SET SuperID={Super}  WHERE ID={ID};";
            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdateEMpDEp(string ID, string DiD)
        {
            string query = $"UPDATE Employee SET DepartmentID={DiD}  WHERE ID={ID};";
            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdateRoomRes(string ID, string NID)
        {
            string query = $"UPDATE Room SET ResposibleNurseID={NID}  WHERE ID={ID};";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateNurseSuper(string ID, string Super)
        {
            string query = $"UPDATE Nurse SET SuperID={Super}  WHERE ID={ID};";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateUsername(string username,string newusername)
        {
            string query = $"UPDATE Users SET Username='{newusername}' WHERE Username='{username}';";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateDepHead(string ID,string DID)
        {
            string query = $"UPDATE Department SET DepHead='{DID}' WHERE DepID='{ID}';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdatePass(string username,string pass)
        {
            string query = $"UPDATE Users SET passwords='{pass}' WHERE Username='{username}';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int Patient_leaves_Room(int patid)
        {
            string query = $"UPDATE Room SET PatientID = null , Notes = null WHERE PatientID = " + patid + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public int Patient_has_no_doctor(int patid)
        {
            string query = $"UPDATE Patient SET ResDrID = null WHERE ID = " + patid + ";";
            return dbMan.ExecuteNonQuery(query);
        }



        public int UpdateBloodType(int patid , string btype)
        {
            string query = "UPDATE Patient SET BloodType = '" +btype+ "' WHERE ID = "+ patid +";";
            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdateReport(int patid, string report , string appointment)
        {
            string query = "UPDATE Appointment SET Report = '" + report + "' WHERE PatientID = " + patid + " and Date_time = '" + appointment + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable Select()
        {
            string query = $"SELECT * FROM ;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectUser()
        {
            string query = $"SELECT Username,FName,LName FROM Users,Person where PersonID=ID;";
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
        public DataTable SelectDocPatient_IDs(int docid)
        {
            string query = "SELECT ID FROM Patient Where ResDrID =  " + docid ;
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectPatientdata(int patid)
        {
            string query = "SELECT * FROM Patient Where ID =  " + patid;
            return dbMan.ExecuteReader(query);
        }

        public DataTable Checkappointment(int docid , DateTime strt)
        {
            string StoredProcedureName = StoredProcedures.getappointment;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@@appdate", strt);
            Parameters.Add("@docid", docid);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable SelectPatientnameanddata(string name , int docid)
        {
            string query = "select Distinct  pat.ID , p.FName , p.LName , p.BoD , p.gender from Person as p , Patient pat where pat.PersonID = p.ID and pat.ResDrID = " +docid + " and (FName = '" + name+"' OR LName = '" + name+"' );";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectallPatientnameanddata( int docid)
        {
            string query = "select Distinct  pat.ID , p.FName , p.LName , p.BoD , p.gender from Person as p , Patient pat where pat.PersonID = p.ID and pat.ResDrID = " + docid + " ;";
            return dbMan.ExecuteReader(query);
        }
        ///
       
        ///////stored proc
        public DataTable SelectPatientsnames(int docid)
        {
            string StoredProcedureName = StoredProcedures.getdrpatients;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@docid", docid);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);

        }
        public DataTable getappointments(int docid , DateTime strt , DateTime final)
        {
            string StoredProcedureName = StoredProcedures.getappointment;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@startdate", strt);
            Parameters.Add("@finaldate", final);
            Parameters.Add("@docid", docid);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);

        }

        public DataTable checkappointmentandDr(int docid, string strt)
        {
            string query = "select * from Appointment  where DrID =   " + docid + "and Date_time = '"+ strt + "';";
            return dbMan.ExecuteReader(query);

        }

        public int updateappoint(int docid, DateTime oldapp , DateTime newapp)
        {
            string StoredProcedureName = StoredProcedures.updateappoint;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@newdate", newapp);
            Parameters.Add("@olddate", oldapp);
            Parameters.Add("@docid", docid);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);

        }

        public int cancelappointment(int docid, DateTime oldapp)
        {
            string StoredProcedureName = StoredProcedures.cancelappoint;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@appdate", oldapp);
            Parameters.Add("@docid", docid);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);

        }


        public DataTable selectappointments(int docid)
        {
            string query = "select Date_time from Appointment  where DrID =   "+ docid+ ";";
            return dbMan.ExecuteReader(query);
        }

        public DataTable docSchedule(int id)
        {
            string query = $"select Date_time, Atype from Appointment where DrID = {id}";
            return dbMan.ExecuteReader(query); 
        }

        public DataTable SelectPatientPersondata(int patid)
        {
            string query = "SELECT * FROM Person Where ID =  " + patid;
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectPatientAllergies(int patid)
        {
            string query = "SELECT allergies FROM Patient_allergies Where patientID =  " + patid;
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectPatientDiseases(int patid)
        {
            string query = "SELECT Diseases FROM Patient_Diseases Where patientID =  " + patid;
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAppointmentsDates(int docid , int patid)
        {
            string query = "SELECT Date_time , Report FROM Appointment Where PatientID =  " + patid + " and DrID = "+ docid ;
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectAppointmentReport(int docid, int patid , string app)
        {
            string query = "SELECT Report FROM Appointment Where PatientID =  " + patid + " and DrID = " + docid + " and Date_time = '" + app + "';";
            return dbMan.ExecuteReader(query);
        }

        public int getLastAddedPerson()
        {
            string query = $"SELECT TOP 1 *  FROM Person ORDER BY ID DESC;";
            return (int)dbMan.ExecuteScalar(query);
        }
        public int getUserTypeID(string username)
        {
            string query = $"SELECT UserTypeID FROM Users where Username='{username}';";
            return (int)dbMan.ExecuteScalar(query);
        }

        public int getDrPID(string ID)
        {
            string query = $"SELECT PersonID FROM Doctors where ID={ID};";
            return (int)dbMan.ExecuteScalar(query);
        }
        public int getNursePID(string ID)
        {
            string query = $"SELECT PersonID FROM Nurse where ID={ID};";
            return (int)dbMan.ExecuteScalar(query);
        }

        public int getEmpPID(string ID)
        {
            string query = $"SELECT PersonID FROM Employee where ID={ID};";
            return (int)dbMan.ExecuteScalar(query);
        }
        public int getDocID(string username)
        {
            string query = "SELECT d.ID FROM Doctors as d , Users as u where u.PersonID = d.PersonID and Username = '" + username +"';";
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

        public DataTable SelectAllEmpID()
        {
            string query = $"SELECT ID FROM Employee;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAllNurseID()
        {
            string query = $"SELECT ID FROM Nurse;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAllDrPID()
        {
            string query = $"SELECT PersonID FROM Doctors;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAllroomID()
        {
            string query = $"SELECT ID FROM Room;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAllDr()
        {
            string query = $"SELECT * FROM Person AS P,Doctors  where PersonID=P.ID;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAllNurses()
        {
            string query = $"SELECT * FROM Person AS P,Nurse  where PersonID=P.ID;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAllEmps()
        {
            string query = $"SELECT * FROM Person AS P,Employee  where PersonID=P.ID;";
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
        //public int InsertSupplier(string snum, string sname, string city, int status)
        //{
        //    string query = "INSERT INTO S (S#, Name, City, Status) " +
        //                    "Values ('" + snum + "','" + sname + "','" + city + "'," + status + ");";
        //    return dbMan.ExecuteNonQuery(query);
        //}

        //public int DeleteSupplier(string snum)
        //{
        //    string query = "DELETE FROM S WHERE S#='" + snum + "';";
        //    return dbMan.ExecuteNonQuery(query);
        //}

        //public int UpdateSupplier(string snum, string city)
        //{
        //    string query = "UPDATE S SET City='" + city + "' WHERE S#='" + snum + "';";
        //    return dbMan.ExecuteNonQuery(query);
        //}

        //public DataTable SelectAllSuppliers()
        //{
        //    string query = "SELECT * FROM S;";
        //    return dbMan.ExecuteReader(query);
        //}

        //public int CountSuppliers()
        //{
        //    string query = "SELECT COUNT(S#) FROM S;";
        //    return (int)dbMan.ExecuteScalar(query);
        //}

        public DataTable SelectPatients()
        {
            string query = $"SELECT P.ID, CONCAT(FName, ' ', LName) AS FName FROM Person PD, Patient P WHERE PD.ID=P.PersonId ";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectDoctors_Name_ID()
        {
            string query = "select D.ID, CONCAT(FName, ' ', LName) AS Fname from Person as PD, Doctors as D where PD.ID = D.PersonID";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectDoCtorNameId_Department(int depID)
        {
            string query = $"select D.ID, CONCAT(FName, ' ', LName) AS Fname from Person as PD, Doctors as D where PD.ID = D.PersonID AND D.DepID = {depID}";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectOperationType_ID()
        {
            string query = "select Oname, ID from OperationType";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectScanType()
        {
            string query = "SELECT ID, SType FROM ScanLab ";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectAllRooms()
        {
            string query = $"SELECT ID from Room";
            return dbMan.ExecuteReader(query);
        }


        public DataTable SelectOpRoom()
        {
            string query = $" select * from OperationRoom";
            return dbMan.ExecuteReader(query);
        }
        public int RequestSuregry(int RoomID, string startDate, string EndDate, int PatientID, int drID)
        {
            string query = $"update Operations_Requests set Operation_Location = {RoomID}, Starts = '{startDate}', Ends = '{EndDate}' where Patient_ID = {PatientID} AND Doctor_ID = {drID}";
            return dbMan.ExecuteNonQuery(query);
        }

        //public int RequestScan(int scanID, int PatientID, string ScanDate, bool accepted = false)
        //{
        //    string query = $"Insert into request(Accepted, PatientID, ScanID, ScanDate) Values({accepted}, {PatientID},{ScanDate},{ScanDate})";
        //    return dbMan.ExecuteNonQuery(query);
        //}

        //public int RequestRoom(int roomID, int patientId, bool accepted = false )
        //{
        //    string query = $"Insert into requests(Accepted, RoomID,PatientID) Values ({accepted}, {roomID}, {patientId})";
        //    return dbMan.ExecuteNonQuery(query);
        //}

        public int GetLastPersonId()
        {
            string query = "SELECT TOP 1 *  FROM Person ORDER BY ID DESC;";
            return (int)dbMan.ExecuteScalar(query);
        }
        public int RequestRoom(int roomID, int nurseID, int PatientID)
        {
            string query = $"insert into Room_Requests(Room_ID, Nurse_ID,Patient_ID) Values ({roomID}, {nurseID}, {PatientID})";
            return dbMan.ExecuteNonQuery(query);
        }

        public int RetrieveCorrespondingNurse(int RoomId)
        {
            string query = $" select ResposibleNurseID from room where ID ={RoomId}";
            return (int)dbMan.ExecuteScalar(query);
        }

        public int RequestScan(int patientId, string date, int scanID)
        {
            string query = $"insert into Scan_Requests(Patient_ID,Datee,Scan_ID) values({patientId}, '{date}', {scanID}) ";
            return dbMan.ExecuteNonQuery(query);
        }

        public int RequestAppointment(int patientID, int DrId, string Adate, string Type)
        {
            string query = $"insert into Appointment_Requests(Patient_ID,Dr_ID,Timee,Appointment_Type) values({patientID},{DrId},'{Adate}','{Type}')";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertNewPatient(int personID, string bloodType, int DrID)
        {
            string query = $"insert into Patient values ({personID}, '{bloodType}', {DrID})";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable SelectDepNAmeID()
        {
            string query = "select DepID,DepName from Department";
            return dbMan.ExecuteReader(query);
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
