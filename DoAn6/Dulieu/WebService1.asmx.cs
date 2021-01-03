using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Dulieu
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-EKGPHOV\\SQLEXPRESS;Initial Catalog=QuanLyNhanvien23;Integrated Security=True");
        [WebMethod]
        public int  HelloWorld()
        {
            return 7+8 ;
        }
        [WebMethod]
        public DataSet getdata()
        {
            conn.Open();
            string query= "select N.MANV,TENNV,GIOITINH,TRINHDO,NGAYSINH,HONNHAN,SOCMND,QUEQUAN,PHONE,EMAIL,C.TEN,P.TEN from NHANVIEN n JOIN PHONGBAN P ON N.PHONGBAN = P.MAPB JOIN CHUCVU C ON N.CHUCVU = C.MACV; ";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            conn.Close();
            da.Fill(ds);
            return ds;
        }
        [WebMethod]
        public DataSet getAccount()
        {
            conn.Open();
            string query = "select * from USERS ;";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            conn.Close();
            da.Fill(ds);
            return ds;
        }
        [WebMethod]
        public DataSet get
    }
}
