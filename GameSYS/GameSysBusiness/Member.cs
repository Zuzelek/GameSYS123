using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;

using System.Windows.Forms;
using GameSYS.Database_Connection;

namespace GameSYS
{
    class Member
    {
        private int memberID;
        private String forename;
        private String surname;
        private String emailAddress;
        private String password;
        private String street;
        private String city;
        private String countyID;
        private String eircode;
        private int phone;
        private String DOB;
        private String regDate;
        private char regStatus;

        //constructors
        public Member()
        {
            this.memberID = 0;
            this.forename = "";
            this.surname = "";
            this.emailAddress = "";
            this.password = "";
            this.street = "";
            this.city = "";
            this.countyID = "";
            this.eircode = "";
            this.phone = 0;
            this.DOB = "";
            this.regDate = "";

        }
      public Member(int memberID, string Forename, string Surname, string EmailAddress, string Password, string Street, string City, string CountyID, string Eircode, int Phone, string DOB, string RegDate, char RegStatus)
        {
            this.memberID = memberID;
            this.forename = Forename;
            this.surname = Surname;
            this.emailAddress = EmailAddress;
            this.password = Password;
            this.street = Street;
            this.city = City;
            this.countyID = CountyID;
            this.eircode = Eircode;
            this.phone = Phone;
            this.DOB = DOB;
            this.regDate = RegDate;
            this.regStatus = RegStatus;


        }
        //GETTERS

    public int getMemberID()
        {
            return this.memberID;
        }
    public String getForename()
        {
            return this.forename;
        }
    public String getSurname()
        {
            return this.surname;
        }
    public String getEmailAddress()
        {
            return this.emailAddress;
        }
    public String getPassword()
        {
            return this.password;
        }
    public String getStreet()
        {
            return this.street;
        }
    public String getCity()
        {
            return this.city;
        }
    public String getCountyID()
        {
            return this.countyID;
        }
    public String getEircode()
        {
            return this.eircode;
        }
    public int getPhone()
        {
            return this.phone;
        }
    public String getDOB()
        {
            return this.DOB;
        }
    public String getRegDate()
        {
            return this.regDate;
        }
    public char getRegStatus()
        {
            return this.regStatus;
        }
    //SETTERS
    public void setMemberID(int MemberID)
        {
            memberID = MemberID;
        }
    public void setForename(String Forename)
        {
            forename = Forename;
        }
    public void setSurname(String Surname)
        {
            surname = Surname;
        }
    public void setEmailAddress(String EmailAddress)
        {
            emailAddress = EmailAddress;
        }
    public void setPassword(String Password)
        {
            password = Password;
        }
    public void setStreet(String Street)
        {
            street = Street;
        }
    public void setCity(String City)
        {
            city = City;
        }
    public void setCountyID(String CountyID)
        {
            countyID = CountyID;
        }
    public void setEircode(String Eircode)
        {
            eircode = Eircode;
        }
    public void setPhone(int Phone)
        {
            phone = Phone;
        }
    public void setDOB(String dob)
        {
            DOB = dob;
        }
    public void setRegDate(String RegDate)
        {
            regDate = RegDate;
        }
    public void setRegStatus(char RegStatus)
        {
            regStatus = RegStatus;
        }
    public static DataSet getAllMembers(String CountyID)
        {
            //Opening a DB Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //SQL Query to be executed
            String sqlQuery = "SELECT Forename, Surname, EmailAddress, HouseNumber, Street, City, CountyID, Eircode, Phone, DOB" +
                                "FROM Members WHERE County = '" + CountyID + "' ORDER BY NAME";

            //EXECUTE SQL QUERY
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "memb");

            //CLOSING DB CONNECTION
            conn.Close();

            return ds;     
    }
       
    public void getMember(int Id)
        {
            Debug.WriteLine("Method called");
            //OPEN A DB CONNECTION
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //SQL QUERY
            String sqlQuery = "SELECT * From Members WHERE MemberID = " + Id;

            //Execute the SQL QUERY
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            //SET INSTANCE VARIABLES
            setMemberID(dr.GetInt32(0));
            setForename(dr.GetString(1));
            setSurname(dr.GetString(2));
            setEmailAddress(dr.GetString(3));
            setPassword(dr.GetString(4));
            setStreet(dr.GetString(5));
            setCity(dr.GetString(6));
            setCountyID(dr.GetString(7));
            setEircode(dr.GetString(8));
            setPhone(dr.GetInt32(9));
            setDOB(dr.GetString(10));

            //CLOSE DB
            conn.Close();
    }
        public void registerMember()
        {
            //OPEN A DB CONNECTION
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //SQL QUERY
            String sqlQuery = "INSERT INTO MEMBERS Values (" +
                this.memberID + ",'" +
                this.forename + "','" +
                this.surname + "','" +
                this.emailAddress + "','" +
                this.password + "','" +
                this.street + "','" +
                this.city + "'," +
                this.countyID + ",'" +
                this.eircode + "'," +
                this.phone + ",'" +
                this.DOB + "','" +
                this.regDate + "','" +
                this.regStatus + "')";

            //EXECUTE SQL QUERY
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

             cmd.ExecuteNonQuery();

            //CLOSE DB CONN
            conn.Close();
        }

        //UPDATE Member
        public void updateMember()
        {
            //Open a DB Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL query to be executed
            String sqlQuery = "UPDATE Members SET " +
                "MemberID = " + this.memberID + "," +
                "Forename = '" + this.forename + "'," +
                "Surname = '" + this.surname + "'," +
                "EmailAddress = '" + this.emailAddress + "'," +
                "Password = '" + this.password + "'," +
                "Street = '" + this.street + "'," +
                "City = '" + this.city + "'," +
                "CountyID = " + this.countyID + "," +
                "Eircode = '" + this.eircode + "'," +
                "Phone = " + this.phone +
                " WHERE MemberID = " + this.memberID;

            //EXECUTE THE SQL QUERY
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db conenction
            conn.Close();


        }
        //DEREGISTER MEMBER
        public void deregisterMember(int ID)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //SQL QUERY
            String sqlQuery = "UPDATE Members SET " +
                            "RegStatus = 'D' WHERE MemberID = " + ID;

            //EXECUTE QUERY
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();

            cmd.ExecuteNonQuery();

            //CLOSE DB connection
            conn.Close();
        }
        //FIND Member
        public static DataSet findMembers(String memrName)
        {
            //OPEN DB CONNECTION
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //DEFINE SQL QUERY
            String sqlQuery = "SELECT MemberID, Forename, Surname, EIRCODE FROM Members " +
                              "WHERE Forename LIKE '" + memrName + "%' ORDER BY Forename";

            //EXECUTE THE SQL QUERY
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "Memr");

            //Close DB
            conn.Close();

            return ds;
        }
        public static DataSet findRegisteredMembers(String memrName)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT MemberID, Forename, Surname, EIRCODE FROM Members WHERE UPPER(Forename) LIKE UPPER('" + memrName + "%') ORDER BY Forename";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds, "memr");

            conn.Close();

            return ds;
        }
        
        //GET NEXT PROD ID
        public static int getNextMemberID()
        {
            //OPEN A DB CONNECTION
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //DEFINE THE SQL QUERY
            String sqlQuery = "SELECT MAX(MemberID) FROM Members";

            //EXECUTE SQL QUERY
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            int nextId;
            dr.Read();

            if (dr.IsDBNull(0))
            {
                nextId = 1;
            }
            else
            {
                nextId = dr.GetInt32(0) + 1;
            }
            //CLOSE DB CONN
            conn.Close();

            return nextId;
        }

        public static Boolean validLogin(String usern, String passw)
        {
            Boolean valid = false;

            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT * FROM LoginTable WHERE username = '" + usern + "' AND Password = '" + passw + "'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
                valid = true;

            conn.Close();
            return valid;
        }
        
    }
}
