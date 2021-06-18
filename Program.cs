using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

//import using System.Data;

//it is used to represent relational data in tabular form
//when we create instance of data table ,it does not have any columns.
//we create table schema by adding columns ,after that u can add rows to data table


//constructors used in data table
//DataTable(): This constructor is used to initialize a new instance of the System.Data.DataTable class with no arguments.
//DataTable(string tableName): It is used to initializes a new instance of the System.Data.DataTable class with the specified table name.


//properties of data table
//Columns: It is used to get the collection of columns that belong to this table.
//Constraints: t is used to get the collection of constraints maintained by this table.
//DataSet: It is used to get the DataSet to which this table belongs.
//DefaultView: It is used to get a customized view of the table that may include a filtered view.
//HasErrors: It is used to get a value indicating whether there are errors in any of the rows in the table of the DataSet.
//MinimumCapacity: It is used to get or set the initial starting size for this table.
//PrimaryKey: It is used to get or set an array of columns that function as primary keys for the data table.
//Rows: It is used to get the collection of rows that belong to this table.
//TableName: It is used to get or set the name of the DataTable.


//Methods used in data table
//Clear()
//Copy()
//Clone()
//select
//AcceptChanges()

namespace ADO.NETDataTable
{
    class Program
    {
        static void Main()
        {
            try
            {
                //create data table instance
                DataTable dt = new DataTable();

                //add data column and define schema

                //add data column
                DataColumn id = new DataColumn("id");
                id.DataType = typeof(int);    //defining its schema
                id.Unique = true;//defining its schema
                id.AllowDBNull = false;//defining its schema
                id.Caption = "Employee id";//defining its schema
                                           //add it to columns
                dt.Columns.Add(id);

                //add data column using properties
                //create instance
                DataColumn name = new DataColumn("name");
                name.MaxLength = 50;
                name.AllowDBNull = false;
                //add it to columns
                dt.Columns.Add(name);

                //creating data column with default properties
                //create instance
                DataColumn email = new DataColumn("email");
                //add it to columns
                dt.Columns.Add(email);

                //create primary key column in database
                dt.PrimaryKey = new DataColumn[] { id }; //setting id as primary key

                //Add New DataRow by creating the DataRow object
                //creating data rows
                //Once you created the DataColumns for the DataTable object,
                //then we can populate the DataTable object by adding DataRow objects
                DataRow row1 = dt.NewRow();
                row1["id"] = 1;
                row1["name"] = "Payal";
                row1["email"] = "payal@gmail.com";
                dt.Rows.Add(row1);

                //now iterate the data table
                foreach (DataRow r in dt.Rows)
                {
                    Console.WriteLine(r["id"] + "" + r["name"] + r["email"]);
                }

            }
            catch(Exception eg)
            {
                Console.WriteLine("not working" + eg);
            }
            Console.ReadLine();
        }
    }
}
