using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticktets.Shared.Entities
{
    public class TicketControl
    {
        public int Id { get; set; }

        public string? TicketID { get; set; }

        public DateTime? UseDate { get; set; }

        public bool IsUsed { get; set; }

        public string? Tribune { get; set; }

    }
}
