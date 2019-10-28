using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogMonitor.DAL
{
    class ConnClass
    {
        public string Appconnection = @"Data Source=.;Initial Catalog=DataLogMonitor;Integrated Security=True";
        public string Datalogconnection = @"Data Source=.;Initial Catalog=OBEDB;Integrated Security=True";
    }
}
