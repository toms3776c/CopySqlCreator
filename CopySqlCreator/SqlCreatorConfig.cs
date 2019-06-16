using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopySqlCreator
{
    class SqlCreatorConfig
    {
        public string ServerDest { get; set; }
        public string DbDest { get; set; }

        public string User { get; set; }

        public string Password { get; set; }



        public string DbSource { get; set; }

        public string SchemaSource { get; set; }

        public string LinkServerSource { get; set; }


        public string OutputSqlFolder { get; set; }

        public SqlCreatorConfig(string serverDest, string dbDest, string user, string password,
            string dbSource, string schemaSource, string linkServerSource,
            string outputSqlFolder)
        {
            this.ServerDest = serverDest;

        }
    }
}
