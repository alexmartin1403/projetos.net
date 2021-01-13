using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batimento_sigma
{
    class Program
    {
        static void Main(string[] args)
        {
        Inicio:
            Console.Title = "Batimento Sigma";
            Console.Clear();
            if (File.Exists($"./ENTRADA/log.txt"))
            {
                File.Delete($"./ENTRADA/log.txt");

                string line = null;
                string line_to_delete = "";
                string diretorioEntrada = @".\ENTRADA";
                string diretorioSaida = @".\INTER";

                if (!Directory.Exists(diretorioEntrada))
                {
                    Directory.CreateDirectory(diretorioEntrada);
                    Console.WriteLine("Nao foi encontrada a pasta de entrada!!! \nPrecione enter para sair...");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                if (!Directory.Exists(diretorioSaida))
                {
                    Directory.CreateDirectory(diretorioSaida);
                }
                List<string> listaArquivos = Directory.GetFiles(diretorioEntrada).ToList();
                if (listaArquivos.Count > 0)
                {
                    foreach (var arq in listaArquivos)
                    {
                        using (StreamReader reader = new StreamReader(arq))
                        {
                            using (StreamWriter w = new StreamWriter($@"{diretorioSaida}\{Path.GetFileName(arq)}"))
                            {
                                while ((line = reader.ReadLine()) != null)
                                {
                                    if (line == line_to_delete)
                                    {
                                        Console.WriteLine("Linha deletada!");
                                        break;
                                    }
                                    if (line == line_to_delete)
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        w.WriteLine(line);
                                    }
                                   
                                }
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("N�o foi localizado nenhum arquivo!!!\nPrecione enter para sair...");
                    goto Inicio;
                }


                string[] teste = Directory.GetFiles(@".\INTER\").OrderByDescending(x => x).ToArray();
                List<string> fileNames = new List<string>();
                foreach (string i in teste)
                {
                    if (!File.Exists($"./INTER/{Path.GetFileNameWithoutExtension(i)}"))
                    {
                        fileNames.Add(Path.GetFileNameWithoutExtension(i));
                    }
                    else
                    {
                        System.Console.WriteLine("Arquivo não localizado");
                    }

                }
                foreach (string s in fileNames)
                {
                    using (StreamReader sr = new StreamReader("./SCRIPTS/create.txt"))
                    {

                        using (StreamWriter sw = File.CreateText($"./SCRIPTS/{s}.sql"))
                        {
                            while (!sr.EndOfStream)
                            {
                                if (s.Substring(0, 7) == "REL_EMI")
                                {
                                    sw.WriteLine(sr.ReadLine().Replace("arquivo", $"./INTER/{s}.csv").Replace("table_name", $"tb_bl_r006_p0_extracao_e_temp").Replace("baseat", $"{s.Substring(24, 3)}").Replace("--b", ""));
                                }
                                else
                                {
                                    sw.WriteLine(sr.ReadLine().Replace("arquivo", $"./INTER/{s}.csv").Replace("table_name", $"tb_bl_r006_p0_extracao_temp").Replace("baseat", $"{s.Substring(14, 3)}").Replace("--a", ""));
                                }
                            }
                        }

                    }
                }

                foreach (string s in fileNames)
                {
                    Process p = new Process();
                    p.StartInfo.WorkingDirectory = Environment.CurrentDirectory;
                    p.StartInfo = new ProcessStartInfo("psql", $@"-d ""host=10.90.126.134 port=5433 dbname=postgres user=smart_fixa password=Sus1234!@"" -f ""./SCRIPTS/{s}.sql""");
                    p.StartInfo.UseShellExecute = false;
                    p.Start();
                    p.WaitForExit();

                }
                DateTime thisDay = DateTime.Today;
                int mes = thisDay.Month;
                int dia = thisDay.Day;
                int ano = thisDay.Year;
                string Dmes;
                string Ddia;
                if (mes <= 9)
                {
                    Dmes = "0" + mes;
                }
                else
                {
                    Dmes = "" + mes;
                }
                if (dia <= 9)
                {
                    Ddia = "0" + dia;
                }
                else
                {
                    Ddia = "" + dia;
                }

                using (StreamReader sr = new StreamReader("./SCRIPTS/batimento.sql"))
                {

                    using (StreamWriter sw = File.CreateText($"./SCRIPTS/batimento_final.sql"))
                    {
                        while (!sr.EndOfStream)
                        {
                            sw.WriteLine(sr.ReadLine().Replace("dtatual", $@"{Ddia}{Dmes}{ano}"));
                        }
                    }
                }
                Process t = new Process();
                t.StartInfo.WorkingDirectory = Environment.CurrentDirectory;
                t.StartInfo = new ProcessStartInfo("psql", $@"-d ""host=10.90.126.134 port=5433 dbname=postgres user=smart_fixa password=Sus1234!@"" -f ""./SCRIPTS/batimento_final.sql""");
                t.StartInfo.UseShellExecute = false;
                t.Start();
                t.WaitForExit();


                string[] limpa = Directory.GetFiles(@".\INTER\");
                List<string> file = new List<string>();
                foreach (string i in limpa)
                {
                    if (!File.Exists($"./INTER{Path.GetFileNameWithoutExtension(i)}"))
                    {
                        File.Copy($@"./ENTRADA/{Path.GetFileName(i)}", $"./BACKUP/{Path.GetFileName(i)}");                        
                        File.Delete($"./ENTRADA/{Path.GetFileName(i)}");
                        File.Delete($"./INTER/{Path.GetFileName(i)}");
                    }
                    else
                    {
                        System.Console.WriteLine("Arquivo não localizado");
                    }
                    Console.WriteLine("Executando...");
                }
                goto Inicio;
            }
            else
            {
                goto Inicio;
            }
        }
    }
}