using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FonTech.Domain.Interfaces;

namespace FonTech.Domain.Entity
{
    public class Report : IEntityId<long>, IAuditable
    {
        public long Id { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public long IdUser { get; set; }
    }
}
