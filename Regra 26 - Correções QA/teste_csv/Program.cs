using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste_csv
{
    class Program
    {
        public static Parametros parameter = new Parametros()
        {
            IpOracle = "10.90.126.134",
            OraPort = 1521,
            OraDb = "XE",
            OraUser = "smartuser",
            OraPass = "Sus1234",
        };
    
        static void Main(string[] args)
        {
            Inicio:
            Console.Title = "Revisao de Multas 5k";            

            int f = 1;
            DateTime thisDay = DateTime.Today;            
            var vSubD = thisDay.AddDays(-3);
            int mes = vSubD.Month;
            string Dmes;
            int dia = vSubD.Day;
            dia = 3;
            mes = 12;
            string Dciclo;           
            int ano = vSubD.Year;
            var vSubM = thisDay.AddMonths(-1);
            var vSubMD = vSubD.AddMonths(-1);
            int mesAnt = vSubM.Month;
            string DmesAnt;
            int anoAnt = vSubM.Year;
            if (mes <= 9)
            {
                Dmes = "0" + mes;
            }
            else
            {
                Dmes = "" + mes;
            }
            if (mesAnt <= 9)
            {
                DmesAnt = "0" + mesAnt;
            }
            else
            {
                DmesAnt = "" + mesAnt;
            }
            OracleDb oraDb = new OracleDb(parameter);
           
            Post pos = new Post();
            switch (dia)
            {
                case 1:

                    for (f = 1; f < 5; f++)
                    {
                        switch (f)
                        {
                            case 1:
                                Dciclo = "01";
                                Console.WriteLine($"O clico é {Dciclo}");                                
                                oraDb.ExecuteScript($"./SCRIPTS/create.txt", true, anoAnt.ToString(), DmesAnt, Dciclo, ano.ToString(), Dmes, vSubMD.ToString("dd/MM/yyyy"), vSubD.ToString("dd/MM/yyyy"));
                                oraDb.ExecuteScript($"./SCRIPTS/script_24.txt", true, Dciclo, ano.ToString(), Dmes);
                                oraDb.ExecuteScript($"./SCRIPTS/script_25.txt", true, Dciclo, ano.ToString(), Dmes);
                                pos.ExecuteScript(ano.ToString(), Dmes, Dciclo, anoAnt.ToString(), DmesAnt, "232425");
                                break;
                            case 2:
                                Dciclo = "20";
                                Console.WriteLine($"O clico é {Dciclo}");
                                oraDb.ExecuteScript($"./SCRIPTS/script_24.txt", true, Dciclo, ano.ToString(), Dmes);
                                oraDb.ExecuteScript($"./SCRIPTS/script_25.txt", true, Dciclo, ano.ToString(), Dmes);
                                pos.ExecuteScript(ano.ToString(), Dmes, Dciclo, anoAnt.ToString(), DmesAnt, "2425");
                                break;
                            case 3:
                                Dciclo = "34";
                                Console.WriteLine($"O clico é {Dciclo}");
                                oraDb.ExecuteScript($"./SCRIPTS/create.txt", true, anoAnt.ToString(), DmesAnt, Dciclo, ano.ToString(), Dmes, vSubMD.ToString("dd/MM/yyyy"), vSubD.ToString("dd/MM/yyyy"));
                                oraDb.ExecuteScript($"./SCRIPTS/script_24.txt", true, Dciclo, ano.ToString(), Dmes);
                                oraDb.ExecuteScript($"./SCRIPTS/script_25.txt", true, Dciclo, ano.ToString(), Dmes);
                                pos.ExecuteScript(ano.ToString(), Dmes, Dciclo, anoAnt.ToString(), DmesAnt, "232425");
                                break;
                            case 4:
                                Dciclo = "76";
                                Console.WriteLine($"O clico é {Dciclo}");
                                oraDb.ExecuteScript($"./SCRIPTS/create.txt", true, anoAnt.ToString(), DmesAnt, Dciclo, ano.ToString(), Dmes, vSubMD.ToString("dd/MM/yyyy"), vSubD.ToString("dd/MM/yyyy"));
                                oraDb.ExecuteScript($"./SCRIPTS/script_24.txt", true, Dciclo, ano.ToString(), Dmes);
                                oraDb.ExecuteScript($"./SCRIPTS/script_25.txt", true, Dciclo, ano.ToString(), Dmes);
                                pos.ExecuteScript(ano.ToString(), Dmes, Dciclo, anoAnt.ToString(), DmesAnt, "232425");
                                break;
                        }
                    }
                    break;

                case 2:
                    for (f = 1; f < 3; f++)
                    {
                        switch (f)
                        {
                            case 1:
                                Dciclo = "11";
                                Console.WriteLine($"O clico é {Dciclo}");
                                oraDb.ExecuteScript($"./SCRIPTS/create.txt", true, anoAnt.ToString(), DmesAnt, Dciclo, ano.ToString(), Dmes, vSubMD.ToString("dd/MM/yyyy"), vSubD.ToString("dd/MM/yyyy"));
                                oraDb.ExecuteScript($"./SCRIPTS/script_24.txt", true, Dciclo, ano.ToString(), Dmes);
                                oraDb.ExecuteScript($"./SCRIPTS/script_25.txt", true, Dciclo, ano.ToString(), Dmes);
                                pos.ExecuteScript(ano.ToString(), Dmes, Dciclo, anoAnt.ToString(), DmesAnt, "232425");
                                break;
                            case 2:
                                Dciclo = "61";
                                Console.WriteLine($"O clico é {Dciclo}");
                                oraDb.ExecuteScript($"./SCRIPTS/create.txt", true, anoAnt.ToString(), DmesAnt, Dciclo, ano.ToString(), Dmes, vSubMD.ToString("dd/MM/yyyy"), vSubD.ToString("dd/MM/yyyy"));
                                oraDb.ExecuteScript($"./SCRIPTS/script_24.txt", true, Dciclo, ano.ToString(), Dmes);
                                oraDb.ExecuteScript($"./SCRIPTS/script_25.txt", true, Dciclo, ano.ToString(), Dmes);
                                pos.ExecuteScript(ano.ToString(), Dmes, Dciclo, anoAnt.ToString(), DmesAnt, "232425");
                                break;                          
                        }
                    }
                    break;

                case 3:
                    Dciclo = "35";
                    Console.WriteLine($"O clico é {Dciclo}");
                    //oraDb.ExecuteScript($"./SCRIPTS/create.txt", true, anoAnt.ToString(), DmesAnt, Dciclo, ano.ToString(), Dmes, vSubMD.ToString("dd/MM/yyyy"), vSubD.ToString("dd/MM/yyyy"));
                    //oraDb.ExecuteScript($"./SCRIPTS/script_24.txt", true, Dciclo, ano.ToString(), Dmes);
                    //oraDb.ExecuteScript($"./SCRIPTS/script_25.txt", true, Dciclo, ano.ToString(), Dmes);
                    //pos.ExecuteScript(ano.ToString(), Dmes, Dciclo, anoAnt.ToString(), DmesAnt, "232425");
                    break;

                case 4:
                    for (f = 1; f < 3; f++)
                    {
                        switch (f)
                        {
                            case 1:
                                Dciclo = "02";
                                Console.WriteLine($"O clico é {Dciclo}");
                                oraDb.ExecuteScript($"./SCRIPTS/create.txt", true, anoAnt.ToString(), DmesAnt, Dciclo, ano.ToString(), Dmes, vSubMD.ToString("dd/MM/yyyy"), vSubD.ToString("dd/MM/yyyy"));
                                oraDb.ExecuteScript($"./SCRIPTS/script_24.txt", true, Dciclo, ano.ToString(), Dmes);
                                oraDb.ExecuteScript($"./SCRIPTS/script_25.txt", true, Dciclo, ano.ToString(), Dmes);
                                pos.ExecuteScript(ano.ToString(), Dmes, Dciclo, anoAnt.ToString(), DmesAnt, "232425");
                                break;
                            case 2:
                                Dciclo = "75";
                                Console.WriteLine($"O clico é {Dciclo}");
                                oraDb.ExecuteScript($"./SCRIPTS/create.txt", true, anoAnt.ToString(), DmesAnt, Dciclo, ano.ToString(), Dmes, vSubMD.ToString("dd/MM/yyyy"), vSubD.ToString("dd/MM/yyyy"));
                                oraDb.ExecuteScript($"./SCRIPTS/script_24.txt", true, Dciclo, ano.ToString(), Dmes);
                                oraDb.ExecuteScript($"./SCRIPTS/script_25.txt", true, Dciclo, ano.ToString(), Dmes);
                                pos.ExecuteScript(ano.ToString(), Dmes, Dciclo, anoAnt.ToString(), DmesAnt, "232425");
                                break;
                        }
                    }
                    break;

                case 5:
                    Dciclo = "21";
                    Console.WriteLine($"O clico é {Dciclo}");
                    oraDb.ExecuteScript($"./SCRIPTS/script_24.txt", true, Dciclo, ano.ToString(), Dmes);
                    oraDb.ExecuteScript($"./SCRIPTS/script_25.txt", true, Dciclo, ano.ToString(), Dmes);
                    pos.ExecuteScript(ano.ToString(), Dmes, Dciclo, anoAnt.ToString(), DmesAnt, "2425");
                    break;

                case 6:
                    for (f = 1; f < 3; f++)
                    {
                        switch (f)
                        {
                            case 1:
                                Dciclo = "16";
                                Console.WriteLine($"O clico é {Dciclo}");
                                oraDb.ExecuteScript($"./SCRIPTS/create.txt", true, anoAnt.ToString(), DmesAnt, Dciclo, ano.ToString(), Dmes, vSubMD.ToString("dd/MM/yyyy"), vSubD.ToString("dd/MM/yyyy"));
                                oraDb.ExecuteScript($"./SCRIPTS/script_24.txt", true, Dciclo, ano.ToString(), Dmes);
                                oraDb.ExecuteScript($"./SCRIPTS/script_25.txt", true, Dciclo, ano.ToString(), Dmes);
                                pos.ExecuteScript(ano.ToString(), Dmes, Dciclo, anoAnt.ToString(), DmesAnt, "232425");
                                break;
                            case 2:
                                Dciclo = "36";
                                Console.WriteLine($"O clico é {Dciclo}");
                                oraDb.ExecuteScript($"./SCRIPTS/create.txt", true, anoAnt.ToString(), DmesAnt, Dciclo, ano.ToString(), Dmes, vSubMD.ToString("dd/MM/yyyy"), vSubD.ToString("dd/MM/yyyy"));
                                oraDb.ExecuteScript($"./SCRIPTS/script_24.txt", true, Dciclo, ano.ToString(), Dmes);
                                oraDb.ExecuteScript($"./SCRIPTS/script_25.txt", true, Dciclo, ano.ToString(), Dmes);
                                pos.ExecuteScript(ano.ToString(), Dmes, Dciclo, anoAnt.ToString(), DmesAnt, "232425");
                                break;
                        }
                    }
                    break;

                case 7:
                    Dciclo = "40";
                    Console.WriteLine($"O clico é {Dciclo}");
                    oraDb.ExecuteScript($"./SCRIPTS/create.txt", true, anoAnt.ToString(), DmesAnt, Dciclo, ano.ToString(), Dmes, vSubMD.ToString("dd/MM/yyyy"), vSubD.ToString("dd/MM/yyyy"));
                    oraDb.ExecuteScript($"./SCRIPTS/script_24.txt", true, Dciclo, ano.ToString(), Dmes);
                    oraDb.ExecuteScript($"./SCRIPTS/script_25.txt", true, Dciclo, ano.ToString(), Dmes);
                    pos.ExecuteScript(ano.ToString(), Dmes, Dciclo, anoAnt.ToString(), DmesAnt, "232425");
                    break;

                case 8:

                    for (f = 1; f < 5; f++)
                    {
                        switch (f)
                        {
                            case 1:
                                Dciclo = "13";
                                Console.WriteLine($"O clico é {Dciclo}");
                                oraDb.ExecuteScript($"./SCRIPTS/create.txt", true, anoAnt.ToString(), DmesAnt, Dciclo, ano.ToString(), Dmes, vSubMD.ToString("dd/MM/yyyy"), vSubD.ToString("dd/MM/yyyy"));
                                oraDb.ExecuteScript($"./SCRIPTS/script_24.txt", true, Dciclo, ano.ToString(), Dmes);
                                oraDb.ExecuteScript($"./SCRIPTS/script_25.txt", true, Dciclo, ano.ToString(), Dmes);
                                pos.ExecuteScript(ano.ToString(), Dmes, Dciclo, anoAnt.ToString(), DmesAnt, "232425");
                                break;
                            case 2:
                                Dciclo = "12";
                                Console.WriteLine($"O clico é {Dciclo}");
                                oraDb.ExecuteScript($"./SCRIPTS/create.txt", true, anoAnt.ToString(), DmesAnt, Dciclo, ano.ToString(), Dmes, vSubMD.ToString("dd/MM/yyyy"), vSubD.ToString("dd/MM/yyyy"));
                                oraDb.ExecuteScript($"./SCRIPTS/script_24.txt", true, Dciclo, ano.ToString(), Dmes);
                                oraDb.ExecuteScript($"./SCRIPTS/script_25.txt", true, Dciclo, ano.ToString(), Dmes);
                                pos.ExecuteScript(ano.ToString(), Dmes, Dciclo, anoAnt.ToString(), DmesAnt, "232425");
                                break;
                            case 3:
                                Dciclo = "53";
                                Console.WriteLine($"O clico é {Dciclo}");
                                oraDb.ExecuteScript($"./SCRIPTS/create.txt", true, anoAnt.ToString(), DmesAnt, Dciclo, ano.ToString(), Dmes, vSubMD.ToString("dd/MM/yyyy"), vSubD.ToString("dd/MM/yyyy"));
                                oraDb.ExecuteScript($"./SCRIPTS/script_24.txt", true, Dciclo, ano.ToString(), Dmes);
                                oraDb.ExecuteScript($"./SCRIPTS/script_25.txt", true, Dciclo, ano.ToString(), Dmes);
                                pos.ExecuteScript(ano.ToString(), Dmes, Dciclo, anoAnt.ToString(), DmesAnt, "232425");
                                break;
                            case 4:
                                Dciclo = "37";
                                Console.WriteLine($"O clico é {Dciclo}");
                                oraDb.ExecuteScript($"./SCRIPTS/create.txt", true, anoAnt.ToString(), DmesAnt, Dciclo, ano.ToString(), Dmes, vSubMD.ToString("dd/MM/yyyy"), vSubD.ToString("dd/MM/yyyy"));
                                oraDb.ExecuteScript($"./SCRIPTS/script_24.txt", true, Dciclo, ano.ToString(), Dmes);
                                oraDb.ExecuteScript($"./SCRIPTS/script_25.txt", true, Dciclo, ano.ToString(), Dmes);
                                pos.ExecuteScript(ano.ToString(), Dmes, Dciclo, anoAnt.ToString(), DmesAnt, "232425");
                                break;
                        }
                    }
                    break;

                case 9:
                    for (f = 1; f < 3; f++)
                    {
                        switch (f)
                        {
                            case 1:
                                Dciclo = "41";
                                Console.WriteLine($"O clico é {Dciclo}");
                                oraDb.ExecuteScript($"./SCRIPTS/create.txt", true, anoAnt.ToString(), DmesAnt, Dciclo, ano.ToString(), Dmes, vSubMD.ToString("dd/MM/yyyy"), vSubD.ToString("dd/MM/yyyy"));
                                oraDb.ExecuteScript($"./SCRIPTS/script_24.txt", true, Dciclo, ano.ToString(), Dmes);
                                oraDb.ExecuteScript($"./SCRIPTS/script_25.txt", true, Dciclo, ano.ToString(), Dmes);
                                pos.ExecuteScript(ano.ToString(), Dmes, Dciclo, anoAnt.ToString(), DmesAnt, "232425");
                                break;
                            case 2:
                                Dciclo = "03";
                                Console.WriteLine($"O clico é {Dciclo}");
                                oraDb.ExecuteScript($"./SCRIPTS/create.txt", true, anoAnt.ToString(), DmesAnt, Dciclo, ano.ToString(), Dmes, vSubMD.ToString("dd/MM/yyyy"), vSubD.ToString("dd/MM/yyyy"));
                                oraDb.ExecuteScript($"./SCRIPTS/script_24.txt", true, Dciclo, ano.ToString(), Dmes);
                                oraDb.ExecuteScript($"./SCRIPTS/script_25.txt", true, Dciclo, ano.ToString(), Dmes);
                                pos.ExecuteScript(ano.ToString(), Dmes, Dciclo, anoAnt.ToString(), DmesAnt, "232425");
                                break;
                        }
                    }
                    break;

                case 10:
                    for (f = 1; f < 3; f++)
                    {
                        switch (f)
                        {
                            case 1:
                                Dciclo = "42";
                                Console.WriteLine($"O clico é {Dciclo}");
                                oraDb.ExecuteScript($"./SCRIPTS/create.txt", true, anoAnt.ToString(), DmesAnt, Dciclo, ano.ToString(), Dmes, vSubMD.ToString("dd/MM/yyyy"), vSubD.ToString("dd/MM/yyyy"));
                                oraDb.ExecuteScript($"./SCRIPTS/script_24.txt", true, Dciclo, ano.ToString(), Dmes);
                                oraDb.ExecuteScript($"./SCRIPTS/script_25.txt", true, Dciclo, ano.ToString(), Dmes);
                                pos.ExecuteScript(ano.ToString(), Dmes, Dciclo, anoAnt.ToString(), DmesAnt, "232425");
                                break;
                            case 2:
                                Dciclo = "22";
                                Console.WriteLine($"O clico é {Dciclo}");                       
                                oraDb.ExecuteScript($"./SCRIPTS/script_25.txt", true, Dciclo, ano.ToString(), Dmes);
                                pos.ExecuteScript(ano.ToString(), Dmes, Dciclo, anoAnt.ToString(), DmesAnt, "25");
                                break;
                        }
                    }
                    break;
                    ;

                case 11:
                    Dciclo = "14";
                    Console.WriteLine($"O clico é {Dciclo}");                    
                    oraDb.ExecuteScript($"./SCRIPTS/create.txt", true, anoAnt.ToString(), DmesAnt, Dciclo, ano.ToString(), Dmes, vSubMD.ToString("dd/MM/yyyy"), vSubD.ToString("dd/MM/yyyy"));
                    oraDb.ExecuteScript($"./SCRIPTS/script_24.txt", true, Dciclo, ano.ToString(), Dmes);
                    oraDb.ExecuteScript($"./SCRIPTS/script_25.txt", true, Dciclo, ano.ToString(), Dmes);
                    pos.ExecuteScript(ano.ToString(), Dmes, Dciclo, anoAnt.ToString(), DmesAnt, "232425");
                    break;
                    

                case 13:
                    for (f = 1; f < 3; f++)
                    {
                        switch (f)
                        {
                            case 1:
                                Dciclo = "15";
                                Console.WriteLine($"O clico é {Dciclo}");
                                oraDb.ExecuteScript($"./SCRIPTS/create.txt", true, anoAnt.ToString(), DmesAnt, Dciclo, ano.ToString(), Dmes, vSubMD.ToString("dd/MM/yyyy"), vSubD.ToString("dd/MM/yyyy"));
                                oraDb.ExecuteScript($"./SCRIPTS/script_24.txt", true, Dciclo, ano.ToString(), Dmes);
                                oraDb.ExecuteScript($"./SCRIPTS/script_25.txt", true, Dciclo, ano.ToString(), Dmes);
                                pos.ExecuteScript(ano.ToString(), Dmes, Dciclo, anoAnt.ToString(), DmesAnt, "232425");
                                break;
                            case 2:
                                Dciclo = "31";
                                Console.WriteLine($"O clico é {Dciclo}");
                                oraDb.ExecuteScript($"./SCRIPTS/create.txt", true, anoAnt.ToString(), DmesAnt, Dciclo, ano.ToString(), Dmes, vSubMD.ToString("dd/MM/yyyy"), vSubD.ToString("dd/MM/yyyy"));
                                oraDb.ExecuteScript($"./SCRIPTS/script_24.txt", true, Dciclo, ano.ToString(), Dmes);
                                oraDb.ExecuteScript($"./SCRIPTS/script_25.txt", true, Dciclo, ano.ToString(), Dmes);
                                pos.ExecuteScript(ano.ToString(), Dmes, Dciclo, anoAnt.ToString(), DmesAnt, "232425");
                                break;
                        }
                    }
                    break;

                case 15:
                    for (f = 1; f < 4; f++)
                    {
                        switch (f)
                        {
                            case 1:
                                Dciclo = "04";
                                Console.WriteLine($"O clico é {Dciclo}");
                                oraDb.ExecuteScript($"./SCRIPTS/create.txt", true, anoAnt.ToString(), DmesAnt, Dciclo, ano.ToString(), Dmes, vSubMD.ToString("dd/MM/yyyy"), vSubD.ToString("dd/MM/yyyy"));
                                oraDb.ExecuteScript($"./SCRIPTS/script_24.txt", true, Dciclo, ano.ToString(), Dmes);
                                oraDb.ExecuteScript($"./SCRIPTS/script_25.txt", true, Dciclo, ano.ToString(), Dmes);
                                pos.ExecuteScript(ano.ToString(), Dmes, Dciclo, anoAnt.ToString(), DmesAnt, "232425");
                                break;
                            case 2:
                                Dciclo = "97";
                                Console.WriteLine($"O clico é {Dciclo}");
                                oraDb.ExecuteScript($"./SCRIPTS/create.txt", true, anoAnt.ToString(), DmesAnt, Dciclo, ano.ToString(), Dmes, vSubMD.ToString("dd/MM/yyyy"), vSubD.ToString("dd/MM/yyyy"));
                                pos.ExecuteScript(ano.ToString(), Dmes, Dciclo, anoAnt.ToString(), DmesAnt, "23");
                                break;
                            case 3:
                                Dciclo = "98";
                                Console.WriteLine($"O clico é {Dciclo}");
                                oraDb.ExecuteScript($"./SCRIPTS/create.txt", true, anoAnt.ToString(), DmesAnt, Dciclo, ano.ToString(), Dmes, vSubMD.ToString("dd/MM/yyyy"), vSubD.ToString("dd/MM/yyyy"));
                                oraDb.ExecuteScript($"./SCRIPTS/script_24.txt", true, Dciclo, ano.ToString(), Dmes);
                                oraDb.ExecuteScript($"./SCRIPTS/script_25.txt", true, Dciclo, ano.ToString(), Dmes);
                                pos.ExecuteScript(ano.ToString(), Dmes, Dciclo, anoAnt.ToString(), DmesAnt, "232425");
                                break;
                        }
                    }
                    break;

                case 16:
                    for (f = 1; f < 3; f++)
                    {
                        switch (f)
                        {
                            case 1:
                                Dciclo = "71";
                                Console.WriteLine($"O clico é {Dciclo}");
                                oraDb.ExecuteScript($"./SCRIPTS/create.txt", true, anoAnt.ToString(), DmesAnt, Dciclo, ano.ToString(), Dmes, vSubMD.ToString("dd/MM/yyyy"), vSubD.ToString("dd/MM/yyyy"));
                                oraDb.ExecuteScript($"./SCRIPTS/script_24.txt", true, Dciclo, ano.ToString(), Dmes);
                                oraDb.ExecuteScript($"./SCRIPTS/script_25.txt", true, Dciclo, ano.ToString(), Dmes);
                                pos.ExecuteScript(ano.ToString(), Dmes, Dciclo, anoAnt.ToString(), DmesAnt, "232425");
                                break;
                            case 2:
                                Dciclo = "97";
                                Console.WriteLine($"O clico é {Dciclo}");
                                oraDb.ExecuteScript($"./SCRIPTS/script_24.txt", true, Dciclo, ano.ToString(), Dmes);
                                oraDb.ExecuteScript($"./SCRIPTS/script_25.txt", true, Dciclo, ano.ToString(), Dmes);
                                pos.ExecuteScript(ano.ToString(), Dmes, Dciclo, anoAnt.ToString(), DmesAnt, "2425");
                                break;
                        }
                    }
                    break;

                case 17:
                    for (f = 1; f < 3; f++)
                    {
                        switch (f)
                        {
                            case 1:
                                Dciclo = "62";
                                Console.WriteLine($"O clico é {Dciclo}");
                                oraDb.ExecuteScript($"./SCRIPTS/create.txt", true, anoAnt.ToString(), DmesAnt, Dciclo, ano.ToString(), Dmes, vSubMD.ToString("dd/MM/yyyy"), vSubD.ToString("dd/MM/yyyy"));
                                oraDb.ExecuteScript($"./SCRIPTS/script_24.txt", true, Dciclo, ano.ToString(), Dmes);
                                oraDb.ExecuteScript($"./SCRIPTS/script_25.txt", true, Dciclo, ano.ToString(), Dmes);
                                pos.ExecuteScript(ano.ToString(), Dmes, Dciclo, anoAnt.ToString(), DmesAnt, "232425");
                                break;
                            case 2:
                                Dciclo = "43";
                                Console.WriteLine($"O clico é {Dciclo}");
                                oraDb.ExecuteScript($"./SCRIPTS/create.txt", true, anoAnt.ToString(), DmesAnt, Dciclo, ano.ToString(), Dmes, vSubMD.ToString("dd/MM/yyyy"), vSubD.ToString("dd/MM/yyyy"));
                                oraDb.ExecuteScript($"./SCRIPTS/script_24.txt", true, Dciclo, ano.ToString(), Dmes);
                                oraDb.ExecuteScript($"./SCRIPTS/script_25.txt", true, Dciclo, ano.ToString(), Dmes);
                                pos.ExecuteScript(ano.ToString(), Dmes, Dciclo, anoAnt.ToString(), DmesAnt, "232425");
                                break;
                        }
                    }
                    break;

                case 18:
                    Dciclo = "88";
                    Console.WriteLine($"O clico é {Dciclo}");
                    oraDb.ExecuteScript($"./SCRIPTS/create.txt", true, anoAnt.ToString(), DmesAnt, Dciclo, ano.ToString(), Dmes, vSubMD.ToString("dd/MM/yyyy"), vSubD.ToString("dd/MM/yyyy"));
                    oraDb.ExecuteScript($"./SCRIPTS/script_24.txt", true, Dciclo, ano.ToString(), Dmes);
                    oraDb.ExecuteScript($"./SCRIPTS/script_25.txt", true, Dciclo, ano.ToString(), Dmes);
                    pos.ExecuteScript(ano.ToString(), Dmes, Dciclo, anoAnt.ToString(), DmesAnt, "232425");
                    break;

                case 19:
                    for (f = 1; f < 4; f++)
                    {
                        switch (f)
                        {
                            case 1:
                                Dciclo = "05";
                                Console.WriteLine($"O clico é {Dciclo}");
                                oraDb.ExecuteScript($"./SCRIPTS/create.txt", true, anoAnt.ToString(), DmesAnt, Dciclo, ano.ToString(), Dmes, vSubMD.ToString("dd/MM/yyyy"), vSubD.ToString("dd/MM/yyyy"));
                                oraDb.ExecuteScript($"./SCRIPTS/script_24.txt", true, Dciclo, ano.ToString(), Dmes);
                                oraDb.ExecuteScript($"./SCRIPTS/script_25.txt", true, Dciclo, ano.ToString(), Dmes);
                                pos.ExecuteScript(ano.ToString(), Dmes, Dciclo, anoAnt.ToString(), DmesAnt, "232425");
                                break;
                            case 2:
                                Dciclo = "72";
                                Console.WriteLine($"O clico é {Dciclo}");
                                oraDb.ExecuteScript($"./SCRIPTS/create.txt", true, anoAnt.ToString(), DmesAnt, Dciclo, ano.ToString(), Dmes, vSubMD.ToString("dd/MM/yyyy"), vSubD.ToString("dd/MM/yyyy"));
                                oraDb.ExecuteScript($"./SCRIPTS/script_24.txt", true, Dciclo, ano.ToString(), Dmes);
                                oraDb.ExecuteScript($"./SCRIPTS/script_25.txt", true, Dciclo, ano.ToString(), Dmes);
                                pos.ExecuteScript(ano.ToString(), Dmes, Dciclo, anoAnt.ToString(), DmesAnt, "232425");
                                break;
                            case 3:
                                Dciclo = "44";
                                Console.WriteLine($"O clico é {Dciclo}");
                                oraDb.ExecuteScript($"./SCRIPTS/create.txt", true, anoAnt.ToString(), DmesAnt, Dciclo, ano.ToString(), Dmes, vSubMD.ToString("dd/MM/yyyy"), vSubD.ToString("dd/MM/yyyy"));
                                oraDb.ExecuteScript($"./SCRIPTS/script_24.txt", true, Dciclo, ano.ToString(), Dmes);
                                oraDb.ExecuteScript($"./SCRIPTS/script_25.txt", true, Dciclo, ano.ToString(), Dmes);
                                pos.ExecuteScript(ano.ToString(), Dmes, Dciclo, anoAnt.ToString(), DmesAnt, "232425");
                                break;
                        }
                    }
                    break;

                case 20:
                    for (f = 1; f < 6; f++)
                    {
                        switch (f)
                        {
                            case 1:
                                Dciclo = "17";
                                Console.WriteLine($"O clico é {Dciclo}");
                                oraDb.ExecuteScript($"./SCRIPTS/create.txt", true, anoAnt.ToString(), DmesAnt, Dciclo, ano.ToString(), Dmes, vSubMD.ToString("dd/MM/yyyy"), vSubD.ToString("dd/MM/yyyy"));
                                oraDb.ExecuteScript($"./SCRIPTS/script_24.txt", true, Dciclo, ano.ToString(), Dmes);
                                oraDb.ExecuteScript($"./SCRIPTS/script_25.txt", true, Dciclo, ano.ToString(), Dmes);
                                pos.ExecuteScript(ano.ToString(), Dmes, Dciclo, anoAnt.ToString(), DmesAnt, "232425");
                                break;
                            case 2:
                                Dciclo = "06";
                                Console.WriteLine($"O clico é {Dciclo}");
                                oraDb.ExecuteScript($"./SCRIPTS/create.txt", true, anoAnt.ToString(), DmesAnt, Dciclo, ano.ToString(), Dmes, vSubMD.ToString("dd/MM/yyyy"), vSubD.ToString("dd/MM/yyyy"));
                                oraDb.ExecuteScript($"./SCRIPTS/script_24.txt", true, Dciclo, ano.ToString(), Dmes);
                                oraDb.ExecuteScript($"./SCRIPTS/script_25.txt", true, Dciclo, ano.ToString(), Dmes);
                                pos.ExecuteScript(ano.ToString(), Dmes, Dciclo, anoAnt.ToString(), DmesAnt, "232425");
                                break;
                            case 3:
                                Dciclo = "18";
                                Console.WriteLine($"O clico é {Dciclo}");
                                oraDb.ExecuteScript($"./SCRIPTS/create.txt", true, anoAnt.ToString(), DmesAnt, Dciclo, ano.ToString(), Dmes, vSubMD.ToString("dd/MM/yyyy"), vSubD.ToString("dd/MM/yyyy"));
                                oraDb.ExecuteScript($"./SCRIPTS/script_24.txt", true, Dciclo, ano.ToString(), Dmes);
                                oraDb.ExecuteScript($"./SCRIPTS/script_25.txt", true, Dciclo, ano.ToString(), Dmes);
                                pos.ExecuteScript(ano.ToString(), Dmes, Dciclo, anoAnt.ToString(), DmesAnt, "232425");
                                break;
                            case 4:
                                Dciclo = "45";
                                Console.WriteLine($"O clico é {Dciclo}");
                                oraDb.ExecuteScript($"./SCRIPTS/create.txt", true, anoAnt.ToString(), DmesAnt, Dciclo, ano.ToString(), Dmes, vSubMD.ToString("dd/MM/yyyy"), vSubD.ToString("dd/MM/yyyy"));
                                oraDb.ExecuteScript($"./SCRIPTS/script_24.txt", true, Dciclo, ano.ToString(), Dmes);
                                oraDb.ExecuteScript($"./SCRIPTS/script_25.txt", true, Dciclo, ano.ToString(), Dmes);
                                pos.ExecuteScript(ano.ToString(), Dmes, Dciclo, anoAnt.ToString(), DmesAnt, "232425");
                                break;
                            case 5:
                                Dciclo = "23";
                                Console.WriteLine($"O clico é {Dciclo}");                                
                                oraDb.ExecuteScript($"./SCRIPTS/script_24.txt", true, Dciclo, ano.ToString(), Dmes);
                                oraDb.ExecuteScript($"./SCRIPTS/script_25.txt", true, Dciclo, ano.ToString(), Dmes);
                                pos.ExecuteScript(ano.ToString(), Dmes, Dciclo, anoAnt.ToString(), DmesAnt, "2425");
                                break;
                        }
                    }
                    break;

                case 21:
                    Dciclo = "74";
                    Console.WriteLine($"O clico é {Dciclo}");
                    oraDb.ExecuteScript($"./SCRIPTS/create.txt", true, anoAnt.ToString(), DmesAnt, Dciclo, ano.ToString(), Dmes, vSubMD.ToString("dd/MM/yyyy"), vSubD.ToString("dd/MM/yyyy"));
                    oraDb.ExecuteScript($"./SCRIPTS/script_24.txt", true, Dciclo, ano.ToString(), Dmes);
                    oraDb.ExecuteScript($"./SCRIPTS/script_25.txt", true, Dciclo, ano.ToString(), Dmes);
                    pos.ExecuteScript(ano.ToString(), Dmes, Dciclo, anoAnt.ToString(), DmesAnt, "232425");
                    break;

                case 22:
                    for (f = 1; f < 4; f++)
                    {
                        switch (f)
                        {
                            case 1:
                                Dciclo = "09";
                                Console.WriteLine($"O clico é {Dciclo}");
                                oraDb.ExecuteScript($"./SCRIPTS/create.txt", true, anoAnt.ToString(), DmesAnt, Dciclo, ano.ToString(), Dmes, vSubMD.ToString("dd/MM/yyyy"), vSubD.ToString("dd/MM/yyyy"));
                                oraDb.ExecuteScript($"./SCRIPTS/script_24.txt", true, Dciclo, ano.ToString(), Dmes);
                                oraDb.ExecuteScript($"./SCRIPTS/script_25.txt", true, Dciclo, ano.ToString(), Dmes);
                                pos.ExecuteScript(ano.ToString(), Dmes, Dciclo, anoAnt.ToString(), DmesAnt, "232425");
                                break;
                            case 2:
                                Dciclo = "32";
                                Console.WriteLine($"O clico é {Dciclo}");
                                oraDb.ExecuteScript($"./SCRIPTS/create.txt", true, anoAnt.ToString(), DmesAnt, Dciclo, ano.ToString(), Dmes, vSubMD.ToString("dd/MM/yyyy"), vSubD.ToString("dd/MM/yyyy"));
                                oraDb.ExecuteScript($"./SCRIPTS/script_24.txt", true, Dciclo, ano.ToString(), Dmes);
                                oraDb.ExecuteScript($"./SCRIPTS/script_25.txt", true, Dciclo, ano.ToString(), Dmes);
                                pos.ExecuteScript(ano.ToString(), Dmes, Dciclo, anoAnt.ToString(), DmesAnt, "232425");
                                break;
                            case 3:
                                Dciclo = "73";
                                Console.WriteLine($"O clico é {Dciclo}");
                                oraDb.ExecuteScript($"./SCRIPTS/create.txt", true, anoAnt.ToString(), DmesAnt, Dciclo, ano.ToString(), Dmes, vSubMD.ToString("dd/MM/yyyy"), vSubD.ToString("dd/MM/yyyy"));
                                oraDb.ExecuteScript($"./SCRIPTS/script_24.txt", true, Dciclo, ano.ToString(), Dmes);
                                oraDb.ExecuteScript($"./SCRIPTS/script_25.txt", true, Dciclo, ano.ToString(), Dmes);
                                pos.ExecuteScript(ano.ToString(), Dmes, Dciclo, anoAnt.ToString(), DmesAnt, "232425");
                                break;
                        }
                    }
                    break;

                case 23:
                    for (f = 1; f < 4; f++)
                    {
                        switch (f)
                        {
                            case 1:
                                Dciclo = "33";
                                Console.WriteLine($"O clico é {Dciclo}");
                                oraDb.ExecuteScript($"./SCRIPTS/create.txt", true, anoAnt.ToString(), DmesAnt, Dciclo, ano.ToString(), Dmes, vSubMD.ToString("dd/MM/yyyy"), vSubD.ToString("dd/MM/yyyy"));
                                oraDb.ExecuteScript($"./SCRIPTS/script_24.txt", true, Dciclo, ano.ToString(), Dmes);
                                oraDb.ExecuteScript($"./SCRIPTS/script_25.txt", true, Dciclo, ano.ToString(), Dmes);
                                pos.ExecuteScript(ano.ToString(), Dmes, Dciclo, anoAnt.ToString(), DmesAnt, "232425");
                                break;
                            case 2:
                                Dciclo = "56";
                                Console.WriteLine($"O clico é {Dciclo}");
                                oraDb.ExecuteScript($"./SCRIPTS/create.txt", true, anoAnt.ToString(), DmesAnt, Dciclo, ano.ToString(), Dmes, vSubMD.ToString("dd/MM/yyyy"), vSubD.ToString("dd/MM/yyyy"));
                                oraDb.ExecuteScript($"./SCRIPTS/script_24.txt", true, Dciclo, ano.ToString(), Dmes);
                                oraDb.ExecuteScript($"./SCRIPTS/script_25.txt", true, Dciclo, ano.ToString(), Dmes);
                                pos.ExecuteScript(ano.ToString(), Dmes, Dciclo, anoAnt.ToString(), DmesAnt, "232425");
                                break;
                            case 3:
                                Dciclo = "24";
                                Console.WriteLine($"O clico é {Dciclo}");                                
                                oraDb.ExecuteScript($"./SCRIPTS/script_24.txt", true, Dciclo, ano.ToString(), Dmes);
                                oraDb.ExecuteScript($"./SCRIPTS/script_25.txt", true, Dciclo, ano.ToString(), Dmes);
                                pos.ExecuteScript(ano.ToString(), Dmes, Dciclo, anoAnt.ToString(), DmesAnt, "2425");
                                break;
                        }
                    }
                    break;

                case 26:
                    Dciclo = "10";
                    Console.WriteLine($"O clico é {Dciclo}");                    
                    oraDb.ExecuteScript($"./SCRIPTS/script_24.txt", true, Dciclo, ano.ToString(), Dmes);
                    oraDb.ExecuteScript($"./SCRIPTS/script_25.txt", true, Dciclo, ano.ToString(), Dmes);
                    pos.ExecuteScript(ano.ToString(), Dmes, Dciclo, anoAnt.ToString(), DmesAnt, "2425");                    
                    break;

                case 28:
                    for (f = 1; f < 3; f++)
                    {
                        switch (f)
                        {
                            case 1:
                                Dciclo = "07";
                                Console.WriteLine($"O clico é {Dciclo}");
                                oraDb.ExecuteScript($"./SCRIPTS/script_24.txt", true, Dciclo, ano.ToString(), Dmes);
                                oraDb.ExecuteScript($"./SCRIPTS/script_25.txt", true, Dciclo, ano.ToString(), Dmes);
                                pos.ExecuteScript(ano.ToString(), Dmes, Dciclo, anoAnt.ToString(), DmesAnt, "2425");
                                break;
                            case 2:
                                Dciclo = "57";
                                Console.WriteLine($"O clico é {Dciclo}");
                                oraDb.ExecuteScript($"./SCRIPTS/script_24.txt", true, Dciclo, ano.ToString(), Dmes);
                                oraDb.ExecuteScript($"./SCRIPTS/script_25.txt", true, Dciclo, ano.ToString(), Dmes);
                                pos.ExecuteScript(ano.ToString(), Dmes, Dciclo, anoAnt.ToString(), DmesAnt, "2425");
                                break;
                        }
                    }
                    break;

            }
            int x = 0;
            int hora = DateTime.Now.Hour;
            while ((thisDay.Day.ToString("dd/MM/yyyy") == DateTime.Today.Day.ToString("dd/MM/yyyy")) || hora != 10)
            {
                x++;
                hora = DateTime.Now.Hour;
                if (x == 1)
                {
                    Console.WriteLine("Aguardando próximo dia......");
                }
            }

            goto Inicio;




        }
    }
}