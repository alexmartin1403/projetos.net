using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste_csv
{
    class OracleDb
    {
        public Parametros parametros { get; set; }
        public string ConnString { get; private set; }
        public string StrBatch { get; private set; }
        public string ScriptPath { get; set; }
        public List<string> ListParameters { get; set; }
        public Process Sqlpl { get; private set; }
        public OracleConnection ConnectionOracle { get; private set; }
        public OracleDb()
        {
        }
        public OracleDb(Parametros parameters)
        {
            parametros = parameters;
            ListParameters = new List<string>();
        }
        public void setStringConnToBath()
        {
            StrBatch = string.Empty;
            StrBatch = $@"{parametros.OraUser}/{parametros.OraPass}@{parametros.IpOracle}";
            StrBatch += $@":{parametros.OraPort}/{parametros.OraDb}";
            if (!(ScriptPath is null))
            {
                if (ListParameters.Count > 0)
                {
                    StringBuilder sb = ParamsToString(ListParameters);
                    StrBatch += $@" @{ScriptPath} {sb.ToString()}";
                }

                else
                {
                    StrBatch += $@" @{ScriptPath}";
                }

            }
        }
        public void ExecuteScript(string pathOfScript, bool sequencial, params string[] parametros)
        {
            ScriptPath = pathOfScript is null ? null : pathOfScript;
            ListDinamic(parametros);
            setStringConnToBath();
            Sqlpl = new Process
            {
                StartInfo = new ProcessStartInfo("sqlplus")
                {
                    Arguments = StrBatch,
                    UseShellExecute = false
                }
            };
            Sqlpl.Start();
            if (sequencial)
            {
                Sqlpl.WaitForExit();
            }
        }
        public void StartLoader(string ctlName, string logName, string nomeArq)
        {
            // Seta o scriptPath para nulo para que o metodo setString conn defina
            // Somente uma string de conexão sem nenhum parametro
            ScriptPath = null;
            setStringConnToBath();
            Sqlpl = new Process()
            {
                StartInfo = new ProcessStartInfo("sqlldr")
                {
                    Arguments = $"{StrBatch} CONTROL={ctlName} LOG={logName} data={nomeArq}"
                }
            };
            Sqlpl.Start();
            Sqlpl.WaitForExit();
        }
        public void ListDinamic(string[] parametros)
        {
            List<string> aux = new List<string>();
            foreach (string s in parametros)
            {
                aux.Add(s);
            }
            ListParameters = aux;
        }
        public StringBuilder ParamsToString(List<string> parameters)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < parameters.Count; i++)
            {
                // Espaço no final necessário para separar os parâmetros...
                string s = $"{parameters[i]} ";
                sb.Append(s);
            }
            return sb;
        }
    }
}
