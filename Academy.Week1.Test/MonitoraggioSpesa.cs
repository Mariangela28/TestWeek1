using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Week1.Test
{
    public class MonitoraggioSpesa
    {
        private string categoria;
        public DateTime Data { get; set; }
        public string Categoria { get; set; }
        public string Descrizione { get; set; }
        public double Importo { get; set; }
        public static void HandleNewTextFile(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Il file è stato creato {0}", e.Name);
            try
            {
                //Lettura
                using (StreamReader reader = File.OpenText(e.FullPath))
                {
                    Console.WriteLine($"Contenuto del file {e.Name}");
                    //string line = reader.ReadLine();
                    string data = reader.ReadLine();
                    string[] values = data.Split(";");
                    //string categoria = reader.ReadLine();
                    
                    //string descrizione = reader.ReadLine();
                    //string importo = reader.ReadLine();
                    string[] dataSpesa = values[1].Split(";");
                    string categoria = reader.ReadLine();
                    string descrizione = reader.ReadLine();
                    //Categoria = dataSpesa[0];
                    //Descrizione = datiSpesa[1];
                    
                    double.TryParse(dataSpesa[3], out double importo);
                    //Importo = importo;

                    //while (line != null)
                    //{
                    //    Console.WriteLine(line);
                    //    line = reader.ReadLine();
                    //}

                    Console.WriteLine("\t Fine del file");
                    Console.WriteLine("\n");
                }

            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

        }
    }
    
}
