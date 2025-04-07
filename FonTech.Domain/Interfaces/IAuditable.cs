using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FonTech.Domain.Interfaces;

public interface IAuditable
{
    DateTime CreatedAt { get; set; }
    DateTime UpdateAt { get; set; }
}

