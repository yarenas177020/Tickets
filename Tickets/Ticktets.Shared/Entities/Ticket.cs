using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticktets.Shared.Entities
{
    public class Ticket
    {
        public int Id { get; set; }

        public string? TicketID { get; set; }

        public DateTime? UseDate { get; set; } = null;

        public bool IsUsed { get; set; } = false;

        public string? Tribune { get; set; } = null;

    }
}
