using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using System.Configuration;
using System.Data;

namespace DGV.ViewModels
{
    public class DisplayViewModel : Screen
    {
        public void DataBinding()
        {
            SqlConnection con = new SqlConnection();
            String SqlConnection = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM [Employee]";
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Employee");
            da.Fill(dt);

            myDG.ItemSource = dt.DefaultView;
        }
    }
}
