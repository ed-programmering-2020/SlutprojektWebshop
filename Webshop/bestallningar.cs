using MySql.Data.MySqlClient;
using System.Data;
using System;
namespace Webshop
{

    public class bestallningar
    {



        public bestallningar() { }  // tom standardkonstruktör

        // Variabelista 
        int bestid;  //Primary key
        int kundid;
        string model;
        string marke;
        string monster;
        string farg;


        public static MySqlCommand getAll()
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = " Select * from bestallningar";
            return command;
        }

        public static MySqlCommand getAllWithID(int id)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = " Select * from bestallningar where kundID = \"" + id + "\"";
            return command;
        }

        public static MySqlCommand getAllWithBestID(string id)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = " Select * from bestallningar where bestID = \"" + id + "\"";
            return command;
        }

        public static MySqlCommand DeleteWithBestID(string id)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = " Delete from bestallningar where bestID = \"" + id + "\"";
            return command;
        }

        public static MySqlCommand UppdateWithBestID(string id, string model, string brand, string pattern, string colors)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = String.Format("Update bestallningar Set Model = \"{0}\", Marke = \"{1}\", Monster = \"{2}\", Farg = \"{3}\" where BestID = \"" + id + "\"", model, brand, pattern, colors);
            return command;
        }


        // Datarad till objekt via Konstruktör 
        public bestallningar(DataRow dr)
        {
            bestID = dr["bestID"] == DBNull.Value ? bestID = 0 : (int)dr["bestID"];
            kundID = dr["kundID"] == DBNull.Value ? kundID = 0 : (int)dr["kundID"];
            Model = dr["Model"] == DBNull.Value ? Model = "" : (string)dr["Model"];
            Marke = dr["Marke"] == DBNull.Value ? Marke = "" : (string)dr["Marke"];
            Monster = dr["Monster"] == DBNull.Value ? Monster = "" : (string)dr["Monster"];
            Farg = dr["Farg"] == DBNull.Value ? Farg = "" : (string)dr["Farg"];
        }

        // todo: rätt ToString för att fylla listboxar mm)
        public override string ToString() { return "Not implemented yet"; }

        // metod för radera detta objekt
        public MySqlCommand GetDeleteCommand()
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "DELETE from bestallningar WHERE bestID = @bestID";
            command.Parameters.AddWithValue("@bestID", bestID);
            return command;
        }

        // metod för updatera detta objekt
        public MySqlCommand GetUpdateCommand()
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = " UPDATE bestallningar SET bestID = @bestID, kundID = @kundID, Model = @Model, Marke = @Marke, Monster = @Monster, Farg = @Farg WHERE bestID = @bestID"; command.Parameters.AddWithValue("@bestID", bestID);
            command.Parameters.AddWithValue("@kundID", kundID);
            command.Parameters.AddWithValue("@Model", Model);
            command.Parameters.AddWithValue("@Marke", Marke);
            command.Parameters.AddWithValue("@Monster", Monster);
            command.Parameters.AddWithValue("@Farg", Farg);
            return command;
        }

        // metod för insert detta objekt i DB
        public MySqlCommand GetInsertCommand()
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "INSERT INTO bestallningar (bestID, kundID, Model, Marke, Monster, Farg ) Values (@bestID, @kundID, @Model, @Marke, @Monster, @Farg)"; command.Parameters.AddWithValue("@bestID", bestID);
            command.Parameters.AddWithValue("@kundID", kundID);
            command.Parameters.AddWithValue("@Model", Model);
            command.Parameters.AddWithValue("@Marke", Marke);
            command.Parameters.AddWithValue("@Monster", Monster);
            command.Parameters.AddWithValue("@Farg", Farg);
            return command;
        }

        public static MySqlCommand GetInsertCommandAutoID(int clientID, string modell, string brand, string patterns, string colors)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "INSERT INTO bestallningar (kundID, Model, Marke, Monster, Farg ) Values (@kundID, @Model, @Marke, @Monster, @Farg)";
            command.Parameters.AddWithValue("@kundID", clientID);
            command.Parameters.AddWithValue("@Model", modell);
            command.Parameters.AddWithValue("@Marke", brand);
            command.Parameters.AddWithValue("@Monster", patterns);
            command.Parameters.AddWithValue("@Farg", colors);
            return command;
        }


        // Getter och Setter
        public int bestID { get { return bestid; } set { bestid = value; } }
        public int kundID { get { return kundid; } set { kundid = value; } }
        public string Model { get { return model; } set { model = value; } }
        public string Marke { get { return marke; } set { marke = value; } }
        public string Monster { get { return monster; } set { monster = value; } }
        public string Farg { get { return farg; } set { farg = value; } }
    }
}