using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.DDD
{
    /// <summary>
    /// base abstract class implementing interface IEntity
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class Entity<T> : IEntity<T>
    {
        public T Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModified { get; set; } 
    }
}
