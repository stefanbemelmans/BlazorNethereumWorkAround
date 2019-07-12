using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace nt.Client.Nft.Components
{
    public class BaseComponent
    {
        public Guid Guid { get; } = Guid.NewGuid();
    }
}
