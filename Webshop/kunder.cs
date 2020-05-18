using MySql.Data.MySqlClient;
using System.Data;
using System;
namespace Webshop
{

    public class kunder
    {



        public kunder() { }  // tom standardkonstruktör

        // Variabelista 
        int id;  //Primary key
        string fornamn;
        string efternamn;
        string anvandarnamn;
        string losenord;


        public static MySqlCommand getAll()
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = " Select * from kunder";
            return command;
        }


        // Datarad till objekt via Konstruktör 
        public kunder(DataRow dr)
        {
            ID = dr["ID"] == DBNull.Value ? ID = 0 : (int)dr["ID"];
            Fornamn = dr["Fornamn"] == DBNull.Value ? Fornamn = "" : (string)dr["Fornamn"];
            Efternamn = dr["Efternamn"] == DBNull.Value ? Efternamn = "" : (string)dr["Efternamn"];
            Anvandarnamn = dr["Anvandarnamn"] == DBNull.Value ? Anvandarnamn = "" : (string)dr["Anvandarnamn"];
            Losenord = dr["Losenord"] == DBNull.Value ? Losenord = "" : (string)dr["Losenord"];
        }

        public static  MySqlCommand getKunderByUsername(string username)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "Select * from kunder WHERE Anvandarnamn = @anvandarnamn";
            command.Parameters.AddWithValue("@anvandarnamn", username);

            return command; 
        }

        // todo: rätt ToString för att fylla listboxar mm)
        public override string ToString() { return "Not implemented yet"; }

        // metod för radera detta objekt
        public MySqlCommand GetDeleteCommand()
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "DELETE from kunder WHERE ID = @ID";
            command.Parameters.AddWithValue("@ID", ID);
            return command;
        }

        // metod för updatera detta objekt
        public MySqlCommand GetUpdateCommand()
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = " UPDATE kunder SET ID = @ID, Fornamn = @Fornamn, Efternamn = @Efternamn, Anvandarnamn = @Anvandarnamn, Losenord = @Losenord WHERE ID = @ID"; command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@Fornamn", Fornamn);
            command.Parameters.AddWithValue("@Efternamn", Efternamn);
            command.Parameters.AddWithValue("@Anvandarnamn", Anvandarnamn);
            command.Parameters.AddWithValue("@Losenord", Losenord);
            return command;
        }

        // metod för insert detta objekt i DB
        public MySqlCommand GetInsertCommand()
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "INSERT INTO kunder (ID, Fornamn, Efternamn, Anvandarnamn, Losenord ) Values (@ID, @Fornamn, @Efternamn, @Anvandarnamn, @Losenord)"; command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@Fornamn", Fornamn);
            command.Parameters.AddWithValue("@Efternamn", Efternamn);
            command.Parameters.AddWithValue("@Anvandarnamn", Anvandarnamn);
            command.Parameters.AddWithValue("@Losenord", Losenord);
            return command;
        }


        // Getter och Setter
        public int ID { get { return id; } set { id = value; } }
        public string Fornamn { get { return fornamn; } set { fornamn = value; } }
        public string Efternamn { get { return efternamn; } set { efternamn = value; } }
        public string Anvandarnamn { get { return anvandarnamn; } set { anvandarnamn = value; } }
        public string Losenord { get { return losenord; } set { losenord = value; } }
    }
}