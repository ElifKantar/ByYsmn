using System;
using System.Collections.Generic;
using System.Text;

namespace ByYsmn.Core.Shared
{
    public class EntityPlain<T>
    {
        public T Id { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

    }
}
