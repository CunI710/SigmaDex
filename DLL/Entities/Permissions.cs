using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public static class Permissions
    {
        public const string Create = nameof(Create); 
        public const string Read = nameof(Read); 
        public const string Update = nameof(Update); 
        public const string Delete = nameof(Delete); 
    }
}
