using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace IOT.Map.InforMaps
{
    public class InforMapDto : AuditedEntityDto<Guid>
    {
        //public Guid AuthorId { get; set; }

        public string Name { get; set; }
    }
}
