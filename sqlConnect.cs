using System;
using System.Data.SqlClient;
namespace Sqlcommands
{
    public class sqlConnect
    {
        static SqlConnection con;
        static SqlCommand cmd;
        public static void CreateConnection()
        {
            string constr = "Data source=LAPTOP-TM2D627A;initial catalog=LibrarySystem;user =sa;password=pass@123";
            con = new SqlConnection();
            con.ConnectionString = constr;
        }
        public static void addBook(string A, string B, int C)
        {
            con.Open();
            string query = "insert into LibraryBook values('" + A + "','" + B + "'," + C + ")";
            cmd = new SqlCommand(query, con);
            con.Close();

        }
        public static void removebook(string A, string B)
        {
            con.Open();
            string query = "delete from LibraryBook where Bookname='" + A + "' and AuthoName='" + B + "'";
            cmd = new SqlCommand(query, con);
            con.Close();
        }

        public static void updateBook(string A, string B)
        {
            con.Open();
            string query = "update LibraryBook set Bookname ='" + A + "'where Bookname = '" + B + "'or AuthoName='" + B + "'";
            cmd = new SqlCommand(query, con);
            con.Close();
        }
        public static void addMember(string A)
        {
            con.Open();
            string query = "insert into LibraryMember values('" + A + "')";
            cmd = new SqlCommand(query, con);
            con.Close();

        }
        public static void removemember(string A)
        {
            con.Open();
            string query = "delete from LibraryMember where MemName ='" + A + "'";
            cmd = new SqlCommand(query, con);
            con.Close();
        }
        public static void updateMember(string A,string B)
        {
            con.Open();
            string query = "update LibraryBook set MemName ='" + A + "'where MemName = '" + B + "'";
            cmd = new SqlCommand(query, con);
            con.Close();
        }

        public static void searchbook(string A)
        {
            con.Open();
            string query = "select * from LibraryBook where Bookname = '"+A+"' or AuthoName = '"+A+"'";
            cmd = new  SqlCommand (query, con);
            con.Close();
        }

    }
}
