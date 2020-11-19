using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace IOT.Books
{
    public class Book : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public DateTime PublishDate { get; set; }

        public float Price { get; set; }
    }
}
