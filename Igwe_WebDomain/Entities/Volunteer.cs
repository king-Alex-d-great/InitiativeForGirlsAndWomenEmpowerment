using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Igwe.Domain.Enumerators;

namespace Igwe.Domain.Entities
{
    class Volunteer
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public TeamName TeamName { get; set; }
        public decimal Donations { get; set; }
    }
}
