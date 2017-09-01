using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public enum Type
    {
        CLEANING, MAINTENANCE, SERVICE
    }

    public enum ServiceStatus
    {
        NEW, IN_PROGRESS, FINISHED
    }
}
