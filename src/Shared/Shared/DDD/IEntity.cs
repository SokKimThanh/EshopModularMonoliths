using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.DDD
{
    /// <summary>
    /// audit interface
    /// </summary>
    public interface IEntity
    {
        string CreatedBy { get; set; }
        DateTime Created { get; set; }
        string LastModifiedBy { get; set; }
        DateTime? LastModified { get; set; }
    }

    /// <summary>
    /// Generic Entity id
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IEntity<T> : IEntity
    {
        T Id { get; set; }
    }
}
