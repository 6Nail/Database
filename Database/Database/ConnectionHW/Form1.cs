using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectionHW
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void ConnectioToSqlServer_Click(object sender, EventArgs e)
    {
      var connectionString = new StringBuilder("Server=A-305-08;Database=Database;Trusted_Connection=True;"); 
      using(var connection = new SqlConnection(connectionString.ToString()))
      {
        connection.Open();
      }
      MessageBox.Show("Done!");
    }
  }
}
