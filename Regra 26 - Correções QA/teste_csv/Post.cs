using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.IO;

namespace teste_csv
{
    class Post
    {
        public void ExecuteScript(string ano, string mes, string ciclo, string anoan, string mesan, string junto)
        {
            using (StreamReader sr = new StreamReader("./SCRIPTS/create_post.txt"))
            {

                using (StreamWriter sw = File.CreateText($"./SCRIPTS/create_post_{ciclo}{mes}{ano}.sql"))
                {
                    while (!sr.EndOfStream)
                    {
                        if (junto == "232425")
                        {
                            sw.WriteLine(sr.ReadLine().Replace("--a", "").Replace("--b", "").Replace("--c", "").Replace("ANOAN", $"{anoan}").Replace("MESAN", $"{mesan}").Replace("CICLO", $"{ciclo}").Replace("ANOAT", $"{ano}").Replace("MESAT", $"{mes}"));
                        }
                        if (junto == "2425")
                        {
                            sw.WriteLine(sr.ReadLine().Replace("--b", "").Replace("--c", "").Replace("ANOAN", $"{anoan}").Replace("MESAN", $"{mesan}").Replace("CICLO", $"{ciclo}").Replace("ANOAT", $"{ano}").Replace("MESAT", $"{mes}"));
                        }
                        if (junto =="25")
                        {
                            sw.WriteLine(sr.ReadLine().Replace("--c", "").Replace("ANOAN", $"{anoan}").Replace("MESAN", $"{mesan}").Replace("CICLO", $"{ciclo}").Replace("ANOAT", $"{ano}").Replace("MESAT", $"{mes}"));
                        }
                        if (junto == "23")
                        {
                            sw.WriteLine(sr.ReadLine().Replace("--a", "").Replace("ANOAN", $"{anoan}").Replace("MESAN", $"{mesan}").Replace("CICLO", $"{ciclo}").Replace("ANOAT", $"{ano}").Replace("MESAT", $"{mes}"));
                        }

                    }

                }
            }
            Process t = new Process();
            t.StartInfo.WorkingDirectory = Environment.CurrentDirectory;
            t.StartInfo = new ProcessStartInfo("psql", $@"-d ""host=10.90.126.134 port=5433 dbname=postgres user=smart_movel password=Sus1234!@"" -f ""./SCRIPTS/create_post_{ciclo}{mes}{ano}.sql""");
            t.StartInfo.UseShellExecute = false;
            t.Start();
            t.WaitForExit();

        }

    }




}

