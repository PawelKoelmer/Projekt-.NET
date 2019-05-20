using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using projekt.Models;

namespace projekt {
    public class ApplicationDbContext {
        public string ConnectionString { get; set; }

        public ApplicationDbContext (string connectionString) {
            this.ConnectionString = connectionString;
        }
        private SqlConnection GetConnection () {
            var builder = new MySqlConnectionStringBuilder {
                Server = "tcp:s15988.database.windows.net,1433",
                Database = "s15988",
                UserID = "s15988@s15988",
                Password = "!PawelKoelm90"
            
            };
            Console.WriteLine(builder.ConnectionString);
            return new SqlConnection (builder.ConnectionString);
        }
        public List<Person> getAllPersons () {
            List<Person> list = new List<Person> ();

            using (SqlConnection conn = GetConnection ()) {

                try {
                    conn.Open ();
                    Console.WriteLine ("Chyba działa połączenie");
                    conn.Close ();
                } catch (MySqlException e) {
                    Console.WriteLine (e);
                   
                }
            }

            return list;

        }
    }
}