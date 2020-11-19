using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace IOT.Map.InforMaps
{
    public class InforMap : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
    }
}
