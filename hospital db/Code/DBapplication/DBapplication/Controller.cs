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
        public int InsertAperson(string Fname, string LName, string ID, string BOD, string Gender)
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

        public int InsertEmployee(string ID, string PersonID, string EmpType, string Salary, string DID)
        {
            string query;
            query = $"INSERT INTO Employee Values ({ID},{PersonID},{EmpType},{Salary},{DID});";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertaNurse(string ID, string Salary, string PersonID, string SuperID)
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



        public int InsertUser(string pass, string ID, string username, string UserTypeID)
        {
            string query = $"INSERT INTO Users Values ('{pass}',{ID},'{username}',{UserTypeID});";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertAllergy(int patID, string allergy)
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
            string query = "DELETE FROM requests WHERE PatientID =  " + patid + ";";
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



        public int UpdateBloodType(int patid, string btype)
        {
            string query = "UPDATE Patient SET BloodType = '" + btype + "' WHERE ID = " + patid + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdateReport(int patid, string report, string appointment)
        {
            string query = "UPDATE Appointment SET Report = '" + report + "' WHERE PatientID = " + patid + " and Date_time = '" + appointment + "';";
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

        public DataTable checkpass(string pass, string username)
        {
            string query = $"SELECT Username FROM Users where passwords='{pass}' AND Username='{username}';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectDocPatient_IDs(int docid)
        {
            string query = "SELECT ID FROM Patient Where ResDrID =  " + docid;
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectPatientdata(int patid)
        {
            string query = "SELECT * FROM Patient Where ID =  " + patid;
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectPatientnameanddata(string name, int docid)
        {
            string query = "select Distinct  pat.ID , p.FName , p.LName , p.BoD , p.gender from Person as p , Patient pat where pat.PersonID = p.ID and pat.ResDrID = " + docid + " and (FName = '" + name + "' OR LName = '" + name + "' );";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectallPatientnameanddata(int docid)
        {
            string query = "select Distinct  pat.ID , p.FName , p.LName , p.BoD , p.gender from Person as p , Patient pat where pat.PersonID = p.ID and pat.ResDrID = " + docid + " ;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectPatientsnames()
        {
            string query = "select Distinct FName from Person as p , Patient pat where pat.PersonID = p.ID union select Distinct LName from Person as p , Patient as pat where pat.PersonID = p.ID ";
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

        public DataTable SelectAppointmentsDates(int docid, int patid)
        {
            string query = "SELECT Date_time , Report FROM Appointment Where PatientID =  " + patid + " and DrID = " + docid;
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectAppointmentReport(int docid, int patid, string app)
        {
            string query = "SELECT Report FROM Appointment Where PatientID =  " + patid + " and DrID = " + docid + " and Date_time = '" + app + "';";
            return dbMan.ExecuteReader(query);
        }



        public int getUserTypeID(string username)
        {
            string query = $"SELECT UserTypeID FROM Users where Username='{username}';";
            return (int)dbMan.ExecuteScalar(query);
        }
        public int getDocID(string username)
        {
            string query = "SELECT d.ID FROM Doctors as d , Users as u where u.PersonID = d.PersonID and Username = '" + username + "';";
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
            string query = $"SELECT PD.ID, CONCAT(FName, ' ', LName) AS FName FROM PersonData PD, Patient P WHERE PD.ID=P.PersonId ";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectDoctors_Name_ID()
        {
            string query = "select D.ID, CONCAT(FName, ' ', LName) AS Fname from Person PD, Doctors D where PD.ID = D.ID";
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

        public int RequestSuregry()
        {
            return 0; //lesa hashof han3ml table wla eh
        }

        public int RequestScan(int scanID, int PatientID, string ScanDate, bool accepted = false)
        {
            string query = $"Insert into request(Accepted, PatientID, ScanID, ScanDate) Values({accepted}, {PatientID},{ScanDate},{ScanDate})";
            return dbMan.ExecuteNonQuery(query);
        }

        public int RequestRoom(int roomID, int patientId, bool accepted = false)
        {
            string query = $"Insert into requests(Accepted, RoomID,PatientID) Values ({accepted}, {roomID}, {patientId})";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable SelectScansIDs()
        {
            string query = $"Select ScanRequestID from Scan_Requests;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectRoomsIDs()
        {
            string query = $"Select RoomRequestID from Room_Requests;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectOperationssIDs()
        {
            string query = $"Select Operation_ID from Operations_Requests;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectAppointmentssIDs()
        {
            string query = $"Select AppointmentRequestID from Appointment_Requests;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectIDsDrs()
        {
            string query = $"Select ID from Doctors;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectIDsNrs()
        {
            string query = $"Select ID from Nurse ;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectIDsEmps()
        {
            string query = $"Select ID from Employee ;";
            return dbMan.ExecuteReader(query);
        }
        public int UpdateScanAccept(string reqID)
        {
            string query = $"UPDATE Scan_Requests SET Accepted = 1 WHERE ScanRequestID = " + reqID + " ;";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateScanCancel(string reqID)
        {
            string query = $"UPDATE Scan_Requests SET Accepted = 0 WHERE ScanRequestID = " + reqID + " ;";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateRoomAccept(string reqID)
        {
            string query = $"UPDATE Room_Requests SET Accepted = 1 WHERE RoomRequestID = " + reqID + " ;";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateRoomCancel(string reqID)
        {
            string query = $"UPDATE Room_Requests SET Accepted = 0 WHERE RoomRequestID = " + reqID + " ;";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateOperationAccept(string reqID)
        {
            string query = $"UPDATE Operations_Requests SET Accepted = 1 WHERE Operation_ID = " + reqID + " ;";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateOperationCancel(string reqID)
        {
            string query = $"UPDATE Operations_Requests SET Accepted = 0 WHERE Operation_ID = " + reqID + " ;";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateAppointmentAccept(string reqID)
        {
            string query = $"UPDATE Appointment_Requests SET Accepted = 1 WHERE AppointmentRequestID = " + reqID + " ;";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateAppointmentCancel(string reqID)
        {
            string query = $"UPDATE Appointment_Requests SET Accepted = 0 WHERE AppointmentRequestID = " + reqID + " ;";
            return dbMan.ExecuteNonQuery(query);
        }
        public int InsertApprovedScan(string reqID)
        {
            string query = $"INSERT INTO Has_a_scan (PatientID,Date_time,ScanID) Select Patient_ID,Datee,Scan_ID From Scan_Requests WHERE ScanRequestID = " + reqID + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public int InsertApprovedRoom(string reqID)
        {
            string query = $"INSERT INTO Room (ID,ResposibleNurseID,PatientID) Select Room_ID,Nurse_ID,Patient_ID From Room_Requests WHERE RoomRequestID = " + reqID + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public int InsertApprovedOperation(string reqID)
        {
            string query = $"INSERT INTO operations (ID,OLocation,startTime,endTime,PatientID,OTypeID,DoctorID) Select Operation_ID,Operation_Location,Starts,Ends,Patient_ID,Operation_Type,Doctor_ID From Operations_Requests WHERE Operation_ID = " + reqID + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public int InsertApprovedAppointment(string reqID)
        {
            string query = $"INSERT INTO Appointment (PatientID,DrID,Date_time,Atype) Select Patient_ID,Dr_ID,Timee,Appointment_Type From Appointment_Requests WHERE AppointmentRequestID = " + reqID + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable SelectAllScanReq()
        {
            string query = $"SELECT * FROM Scan_Requests;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectAllRoomReq()
        {
            string query = $"SELECT * FROM Room_Requests;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectAllOperationReq()
        {
            string query = $"SELECT * FROM Operations_Requests;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectAllAppointmentReq()
        {
            string query = $"SELECT * FROM Appointment_Requests;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectAllFnames()
        {
            string query = $"SELECT FName FROM Person;";
            return dbMan.ExecuteReader(query);
        }
        public int UpdateDrS(string id,string newS)
        {
            string query = $"UPDATE Doctors SET Salary = {newS} WHERE ID = {id} ;";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateNrS(string id, string newS)
        {
            string query = $"UPDATE Nurse SET Salary = {newS} WHERE ID = {id} ;";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateEmpS(string id, string newS)
        {
            string query = $"UPDATE Employee SET Salary = {newS} WHERE ID = {id} ;";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable SelectSearch(string fname)
        {
            string query = $"SELECT FName,LName,Person.ID,BoD,gender,Tname FROM Person,EmployeeType WHERE FName= '{fname}' AND Person.ID=EmployeeType.ID;";
            return dbMan.ExecuteReader(query);
        }
        public int Updatepayment(string payment,string ay)
        {
            string query = $"Update transactions Set Ttype='Deposit', payment= {payment} WHERE requestID={ay};";
            return dbMan.ExecuteNonQuery(query);
        }
        public int InsertScanTransaction(int counter,string reqID)
        {
            string query = $"INSERT INTO transactions(ID,requestID) values ({counter},{reqID});";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable SelectAlltrans()
        {
            string query = $"SELECT requestID FROM transactions;";
            return dbMan.ExecuteReader(query);
        }
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
