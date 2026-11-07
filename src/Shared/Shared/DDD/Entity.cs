using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.DDD
{
    /// <summary>
    /// Implement entity
    /// </summary>
    /// <typeparam name="T"></typeparam>
    abstract class Entity<T> : IEntity<T>
    {
        public T Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModified { get; set; } 
    }
}
