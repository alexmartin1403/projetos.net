using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste_csv
{
    class Parametros
    {
        public string IpOracle { get; set; }
        public string IpPostgre { get; set; }
        public int OraPort { get; set; }
        public int PgPort { get; set; }
        public string OraDb { get; set; }
        public string PgDb { get; set; }
        public string OraUser { get; set; }
        public string PgUser { get; set; }
        public string OraPass { get; set; }
        public string PgPass { get; set; }
        public string OldValue { get; internal set; }
        public string NewValue { get; internal set; }
    }
}
