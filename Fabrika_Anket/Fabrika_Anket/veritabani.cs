using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace Denim_Anket
{

    public class veritabani
    {
        public SqlConnection sqlDbConn = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlConn"].ToString());

        public void baglan()
        {

            try
            {
                if (sqlDbConn.State == ConnectionState.Closed)
                    sqlDbConn.Open();
            }
            catch (Exception ex)
            {

                sqlDbConn.Open();
            }

        }


        public void baglantiKes()
        {
            try
            {
                sqlDbConn.Close();
                //sqlDbConn.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }



        public DataTable DataTable(string strSQL)
        {

            //DataSet ds = new DataSet();
            //SqlDataAdapter adp = new SqlDataAdapter(strSQL, sqlDbConn);
            //try
            //{
            //    adp.Fill(ds);

            //}
            //catch (Exception ex)
            //{ 
            //    ds.Dispose();
            //    adp.Dispose();
            //}
            //ds.Dispose();
            //adp.Dispose();
            //return ds.Tables["Sonuc"];


            SqlDataAdapter adap = new SqlDataAdapter(strSQL, sqlDbConn);
            adap.SelectCommand.CommandTimeout = 1000;

            DataSet data = new DataSet();
            adap.Fill(data);
            return data.Tables[0];

            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter(strSQL, sqlDbConn);
            try
            {
                adp.Fill(ds, "Sonuc");
            }
            catch (Exception ex)
            {
                ds.Dispose();
                adp.Dispose();
            }
            ds.Dispose();
            adp.Dispose();
            baglantiKes();

            return ds.Tables["Sonuc"];
        }

        public int ExecuteNonQuery(string strSQL)
        {
            baglan();
            SqlCommand cmd = new SqlCommand(strSQL, sqlDbConn);
            int deger = 0;
            try
            {
                deger = cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            cmd.Dispose();
            baglantiKes();
            return deger;
        }



        public String ExecuteScalar(string strSQL)
        {
            baglan();
            SqlCommand cmd = new SqlCommand(strSQL, sqlDbConn);
            Object sqlDeger;
            String sonuc = "";

            try
            {
                sqlDeger = cmd.ExecuteScalar();
                if (sqlDeger == null)
                {
                    sonuc = "";
                }
                else
                {
                    sonuc = sqlDeger.ToString();
                }
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }

            baglantiKes();

            return sonuc;
        }
        int deger;
        public int ExecuteReader(string strSQL)
        {

            baglan();
            SqlCommand cmd = new SqlCommand(strSQL, sqlDbConn);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if (rdr.HasRows)
                {
                    try
                    {
                        deger = Convert.ToInt32(rdr);
                    }
                    catch (SqlException ex)
                    {

                        throw new Exception(ex.Message);
                    }

                }
            }
            baglantiKes();
            return deger;

        }

        public DataRow GetDataRow(string strSQL)
        {
            baglan();
            SqlDataAdapter adp = new SqlDataAdapter(strSQL, sqlDbConn);
            adp.SelectCommand.CommandTimeout = 3000;
            DataTable table = new DataTable();
            try
            {
                adp.Fill(table);
                if (table.Rows.Count == 0) return null;
                return table.Rows[0];

            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }

            baglantiKes();
            GC.Collect();
        }

        public int SqlDataAdaptor(string strSQL)
        {
            baglan();
            SqlDataAdapter adp = new SqlDataAdapter(strSQL, sqlDbConn);
            DataTable table = new DataTable();
            int degerGetir;
            try
            {
                degerGetir = adp.Fill(table);

            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }
            GC.Collect();
            baglantiKes();
            return degerGetir;
        }
    }

}
