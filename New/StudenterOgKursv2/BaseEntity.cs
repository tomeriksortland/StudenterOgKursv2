using System;
using System.Collections.Generic;
using System.Text;

namespace StudenterOgKursv2
{
    public class BaseEntity
    {
        public Guid Id { get; }

        public BaseEntity(Guid? id = null)
        {
            Id = id ?? Guid.NewGuid();
        }
    }
}
