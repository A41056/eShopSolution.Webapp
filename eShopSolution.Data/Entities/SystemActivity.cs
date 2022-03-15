using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Data.Entities
{
    public class SystemActivity
    {
        public int Id { get; set; }
        public string ActionName { get; set; }
        public DateTime ActionDate { get; set; }
        public int FunctionId { get; set; }
        public int UserId { get; set; }
        public string ClientIP { get; set; }
    }
}
