using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace pre_geracao
{
    class Program
    {

        static void Main(string[] args)
        {
        Inicio:
            Console.Title = "Processo de pré-geração";
            Console.Clear();
            if (File.Exists($"./ENTRADA/log.txt"))
            {
                File.Delete($"./ENTRADA/log.txt");

                string line = null;
                string line_to_delete = "--------FIM--------";
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
                                    if (line.Contains(line_to_delete))
                                    {
                                        Console.WriteLine("Linha deletada!");
                                        continue;
                                    }
                                    w.WriteLine(line);
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
                                    sw.WriteLine(sr.ReadLine().Replace("arquivo", $"./INTER/{s}.csv"));                               
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

                Process q = new Process();
                q.StartInfo.WorkingDirectory = Environment.CurrentDirectory;
                q.StartInfo = new ProcessStartInfo("psql", $@"-d ""host=10.90.126.134 port=5433 dbname=postgres user=smart_fixa password=Sus1234!@"" -f ""./SCRIPTS/SCRIPT_GERACAO_POST.sql""");
                q.StartInfo.UseShellExecute = false;
                q.Start();
                q.WaitForExit();
                
                string[] limpa = Directory.GetFiles(@".\ENTRADA\");
                List<string> file = new List<string>();
                foreach (string i in limpa)
                {
                    if (!File.Exists($"./ENTRADA{Path.GetFileNameWithoutExtension(i)}"))
                    {
                        File.Copy($@"./ENTRADA/{Path.GetFileName(i)}", $"./BACKUP/{Path.GetFileName(i)}");
                        File.Delete($"./INTER/{Path.GetFileName(i)}");
                        File.Delete($"./ENTRADA/{Path.GetFileName(i)}");
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