using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MalikBrotherCS
{
    class queryClass
    {
        public static int id = 0;                                      
        public static OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\MalikBrotherCS\\MalikBrotherCS\\bin\\Debug\\MalikBrotherCS.accdb");


        //Clear Controls 
        public static void clrearC(Form f)
        {
            foreach (Control c in f.Controls)
            {
                if (c is TextBoxFeatured) { c.Text = ""; }
            }

        }

        //All Query
        public static void insert(string qry)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand(qry, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public static void Delete(string qry)
        {
            try
            {

                OleDbCommand cmd = new OleDbCommand(qry, con);
                cmd.Parameters.AddWithValue("@i", id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public static void update(string qry)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand(qry, con);
                cmd.Parameters.AddWithValue("@i", id);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static DataSet ds;
        public static DataSet selectds(string qry)
        {

            try
            {
                DataSet dss = new DataSet();
                con.Open();
                OleDbDataAdapter adp = new OleDbDataAdapter(qry, con);
                adp.Fill(dss);
                ds = dss;
                con.Close();
                return ds;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return ds;
        }
        public static int pricee;
        public static string CarName;
        public static void select(string qry)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = qry;
                cmd.Parameters.AddWithValue("@p", CarName);
                OleDbDataReader readerr = cmd.ExecuteReader();
                while (readerr.Read())
                {
                    pricee = Convert.ToInt32(readerr["Daily_Price"].ToString());
                }
                con.Close();
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
      
    }
}
