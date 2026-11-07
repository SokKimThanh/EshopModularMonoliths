using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.DDD
{
    /// <summary>
    /// audit interface
    /// </summary>
    internal interface IEntity
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
    interface IEntity<T> : IEntity
    {
        T Id { get; set; }
    }
}
