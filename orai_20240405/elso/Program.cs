using System.Data.SQLite;

namespace elso
{   
    internal class Program
    {
        static SQLiteConnection connection;  //megad egy hidat

        static void InitializeDatabase()
        { 
            connection = new SQLiteConnection("Data Source = iskola.db"); //létrehozzuk az iskola adatbázist
            connection.Open(); //majd megnyitjuk

            string createIskolaTable = @"CREATE TABLE IF NOT EXISTS Iskola(
                                       id INTEGER PRIMARY KEY AUTOINCREMENT,
                                       Nev TEXT NOT NULL,
                                       Cim TEXT NOT NULL
                                       );";
            SQLiteCommand command = new SQLiteCommand(createIskolaTable, connection);
            command.ExecuteNonQuery();

            string createDiakTable = @"CREATE TABLE IF NOT EXISTS Diak(
                                       id INTEGER PRIMARY KEY AUTOINCREMENT,
                                       Nev TEXT NOT NULL,
                                       Kor TEXT NOT NULL
                                       );";

            SQLiteCommand command2 = new SQLiteCommand(createDiakTable, connection);
            command2.ExecuteNonQuery();

            string createIskolaDiakTable = @"CREATE TABLE IF NOT EXISTS Diak(
                                           IskolaId INTEGER,
                                           DiakId INTEGER,
                                           FOREIGN KEY (IskolaId) REFERENCES Iskola(Id),
                                           FOREIGN KEY (DiakId) REFERENCES Diak(Id)
                                       );";

            SQLiteCommand command3 = new SQLiteCommand(createIskolaDiakTable, connection);
            command3.ExecuteNonQuery();
        }

        static void DiakUj(int index, string nev, int kor)
        {
            string insertDiak = "INSERT INTO Diak (Nev, Kor) VALUES (@nev, @kor)";
            SQLiteCommand command = new SQLiteCommand(insertDiak, connection);
            command.Parameters.AddWithValue("@nev", nev);
            command.Parameters.AddWithValue("@kor", kor);
            command.ExecuteNonQuery();

            long diakId = connection.LastInsertRowId;

            string insertIskolaDiak = "INSERT INTO Iskola_Diak (IskolaId, DiakId) VALUES (@idkolaId, @DiakId)";
            SQLiteCommand command2 = new SQLiteCommand(insertIskolaDiak, connection);
            command2.Parameters.AddWithValue("@iskolaId", index);
            command2.Parameters.AddWithValue("@diakId", diakId);
            command2.ExecuteNonQuery();

            Console.WriteLine("A diák sikeresen hozzáadva az iskolához");
        }

        static void IskolaUj(string nev, string cim)
        {
            string insertIskola = "INSERT INTO Iskola (Nev, Cim) VALUES (@nev, @cim);";
            SQLiteCommand command = new SQLiteCommand(insertIskola, connection);
            command.Parameters.AddWithValue("@nev", nev);
            command.Parameters.AddWithValue("@cim", cim);
            command.ExecuteNonQuery();

            Console.WriteLine("Az iskola sikeresen hozzá lett adva.");
        }

        static void IskolakListazasa()
        {
            string selectIskola = "SELECT * FROM Iskola;";
            SQLiteCommand command = new SQLiteCommand(selectIskola, connection);

            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read()) 
            {
                Console.WriteLine($"({reader["Id"]}) {reader["Nev"]} - {reader["Cim"]}");
            }
        
        }

        static void IskolaAdatainakMegjelenitese (int index)
        {
            string selectIskola = "SELECT * FROM Iskola WHERE Id = @id";
            SQLiteCommand command = new SQLiteCommand( selectIskola, connection);
            command.Parameters.AddWithValue("@id", index);
            SQLiteDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                Console.WriteLine($"Iskola neve: {reader["Nev"]}, címe: {reader["Cím"]}");
                reader.Close();

                string selectIskolaDiak = @"SELECT Diak, Nev FROM Diak "
                                    + "INNER JOIN Iskola_Diak ON Diak.Id = Iskola_Diak_DiakId "
                                    + "WHERE Iskola_Diak.IskolaId = @id";
                SQLiteCommand command2 = new SQLiteCommand( selectIskolaDiak, connection);
                command2.Parameters.AddWithValue("i@d", index);
                SQLiteDataReader reader2 = command2.ExecuteReader();
                while (reader2.Read())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\t - {reader2["Nev"]} ({reader2["Kor"]}) ");
                    Console.ResetColor();
                }
                reader2.Close();
            }
            else
            {
                Console.WriteLine("Nincs ilyen azonosítójú iskola...");
            }



        }



        static void Main(string[] args)
        {
            InitializeDatabase();
            //Console.WriteLine("Proba...");
            bool kilepes = false;

            while (!kilepes)
            {
                Console.WriteLine("Válassz egy műveletet:");
                Console.WriteLine("1 - Új iskola hozzáadása");
                Console.WriteLine("2 - Diák hozzáadása az iskolához");
                Console.WriteLine("3 - Iskola adatainak megjelenítése");
                Console.WriteLine("4 - Kilépés");

                string valasztas = Console.ReadLine();

                switch (valasztas) 
                {
                    case "1":
                        Console.WriteLine("Adja meg az iskola nevét:");
                        string nev = Console.ReadLine();
                        Console.WriteLine("Adja meg az iksola címét");
                        string cim = Console.ReadLine();
                        IskolaUj(nev, cim);
                        break;
                    case "2":
                        Console.WriteLine("Melyik iskolához szeretne diákot hozzáadni?");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        IskolakListazasa();
                        Console.ResetColor();
                        int iskolaindex = int.Parse(Console.ReadLine());
                        Console.WriteLine("Adja meg a diák nevét:");
                        string DiakNev = Console.ReadLine();
                        Console.WriteLine("Adja meg a diák korát:");
                        int diakKor = int.Parse(Console.ReadLine());

                        DiakUj(iskolaindex, DiakNev, diakKor);
                        break;
                    case "3":
                        IskolakListazasa();
                        Console.WriteLine("Válassza ki az iskolát.");
                        int kivalasztottIskola = int.Parse(Console.ReadLine());
                        IskolaAdatainakMegjelenitese(kivalasztottIskola);
                        break;

                    case "4":
                        kilepes = true;
                        break;
                    default:
                        Console.WriteLine("Nincs ilyen lehetőség...");
                        break;
                }
            }


        }
    }
}
