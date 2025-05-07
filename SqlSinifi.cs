using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

public class Class1
{
	public SqlConnection baglanti()
	{

		SqlConnection baglantı = new SqlConnection(@"Data Source=LAPTOP-558BI1BU\MSSQLSERVER02;Initial Catalog=Dbo_yemektarif;Integrated Security=True;TrustServerCertificate=True");
		baglan.Open();
		return baglan;
	}
}
