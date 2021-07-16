using System;
using System.IO;

namespace Academy.Week1.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("___ Watcher Files ___");
            FileSystemWatcher fsw = new FileSystemWatcher();

            //percorso da tenere monitorato
            fsw.Path = @"C:\Users\mariangela.leone\Desktop\Academy.TestWeek1";

            //definisco il filtro di controllo sui file .txt
            fsw.Filter = "*.txt";

            fsw.NotifyFilter = NotifyFilters.LastWrite |
                NotifyFilters.LastAccess | NotifyFilters.FileName
                | NotifyFilters.DirectoryName;

            //Abilito le notifiche 
            fsw.EnableRaisingEvents = true;

            //Iscrizione all'evento
            fsw.Created += MonitoraggioSpesa.HandleNewTextFile;

            Console.WriteLine("Premi q per uscire");
            while (Console.Read() != 'q') ;

        }
    }

}

