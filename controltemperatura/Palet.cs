using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace controltemperatura
{
    class Palet
    {
        private string _SSCC { get; set; }
        private string _ubicacion { get; set; }
        private double _Temperatura { get; set; }
        private DateTime _Fecha { get; set; }
        private bool _procesado { get; set; }
        private bool _muestra { get; set; }
        private int _tunel { get; set; }
     //   private SqlConnection conexion{get; set;}
       // private SqlCommand comando{get; set;}
        public string msg_sql { get; set; }
        public Palet(string SCCC, double Temperatura) 
        {
            _SSCC = SCCC;
            _Temperatura = Temperatura;
            _procesado = false;
            _Fecha = DateTime.Now;
           /* conexion = new SqlConnection();
            comando = new SqlCommand();
            conexion.ConnectionString = @"data source = 192.168.1.195\SQLSERVER2008; initial catalog = Ds_Rinya; user id = Ctemperatura; password = temperatura";
            conexion.ConnectionString = "Data Source=192.168.1.195\\sqlserver2008;Initial Catalog=QC600;Persist Security Info=True;User ID=dso;Password=dsodsodso";
            msg_sql = "";*/
        }
        public Palet(string SCCC, string Tempe,bool muestra)
        {
            double tempo_temperatura;
            _SSCC = SCCC;
            _ubicacion = "";
            _muestra = muestra;
            try
            {
                if (double.TryParse(Tempe.Replace('.', ','), out tempo_temperatura))
                {
                    _Temperatura = tempo_temperatura;
                }
                else 
                {
                    _Temperatura = -999.999;
                }
                
            }catch (Exception e) { }
            _procesado = false;
            _Fecha = DateTime.Now;
            msg_sql = "";
        }
        private Quality con = new Quality();
        public bool existe()
        {
            bool result = false;
            string sql = "select count(*) from DATOS_ORGANOLEPTICO where SSCC='" + _SSCC + "'";
            string conteo_s = con.sql_string(sql);
            int conteo_i = 0;
            int.TryParse(conteo_s, out conteo_i);
            if (conteo_i > 0)
                result = true;
            msg_sql = "FALLO AL INTRODUCIR LA Matricula \r\nError: La matricula no existe en Quality!!";
            return result;
        }
        public Palet(string SCCC, string Tempe, string ubica)
        {
            double tempo_temperatura;
            _SSCC = SCCC;
            _ubicacion = ubica;
            try
            {
                if (double.TryParse(Tempe.Replace(',', '.'), out tempo_temperatura))
                {
                    _Temperatura = tempo_temperatura;
                }
                else
                {
                    _Temperatura = -999.999;
                }

            }
            catch (Exception e) { }
            _procesado = false;
            _Fecha = DateTime.Now;
                      msg_sql = "";
        }
        public string ubicacion() { return _ubicacion; }
        public string get_SCCC() { return _SSCC; }
        public double get_Temperatura() { return _Temperatura; }
        public DateTime get_Fecha() { return _Fecha; }
        public bool get_procesado() { return _procesado; }
        public int get_tunel() { return _tunel; }
        public bool insertar_Quality() 
        {
            bool exito;
            if (_Temperatura == -999.999)
            {
                msg_sql = "FALLO AL INTRODUCIR LA TEMPERATURA \r\nError: Temperatura Formato Erroneo!!"; 
                return false;
            }
            try
            {
                string sql = "insert into [QC600].[dbo].[dbControlTemperatura] (SSCC, Temperatura, Fecha, procesado,[Muestra]) values('" + _SSCC + "', " + _Temperatura.ToString().Replace(',','.') + ",GETDATE(),0,0)";
                con.sql_update(sql);
                //  comando.Connection = conexion;
              

              //  int NFilas = comando.ExecuteNonQuery();

                string sql_select = @"select [Temperatura]  FROM [QC600].[dbo].[dbControlTemperatura] where [SSCC] like '" + _SSCC + @"'";
                
                double temp = -999.999;
                double.TryParse(con.sql_string(sql_select) , out temp );
                int tunel = -99;
                string sql_tunel = @"select top 1 TUNEL from CONTROL_TUNEL where SSCC  like '" + _SSCC + @"' order by FECHA_CREACION desc";
                int.TryParse(con.sql_string(sql_tunel), out tunel);
                _tunel = tunel;
                if ( temp != -999.999  && tunel!=-99)
                {
                    msg_sql = "Temperatura Almacenada exitosamente";
                    exito = true;
                    // MessageBox.Show("Temperatura Almacenada exitosamente");
                }
                else {
                    msg_sql = "FALLO AL INTRODUCIR LA TEMPERATURA \r\nError: Temperatura No Almacenada!!"; 
                    exito = false; 
                }

                 
                // this.GridView1.DataSource = dt;
                //this.GridView1.DataBind();
                //LabelInfo.Text = String.Format("Total datos en la tabla: {0}", dt.Rows.Count);
            }
            catch (Exception ex)
            {
               // MessageBox.Show("FALLO AL INTRODUCIR LA TEMPERATURA \r\nError: " + ex);
                msg_sql = "FALLO AL INTRODUCIR LA TEMPERATURA \r\nError: " + ex;
                exito = false;
                ///LabelInfo.Text = "Error: " + ex.Message;
            }
          
            
            return exito;
        }
        
     }
}
