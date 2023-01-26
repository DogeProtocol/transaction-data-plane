using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace dp.write.transaction.Services.Queues
{
    /// <summary>
    /// Defines the interface for <see cref="Downloader"/> cache implementations.
    /// </summary>
    public interface IQueueService : IDisposable
    {
        /// <summary>
        /// Adds an item to the cache.
        /// </summary>
        /// <param name="Id">The cache id.</param>
        /// <param name="jsondocument">The jsondocument of the item to add.</param>
        void Set(string id, object jsondocument, object dateadded, object state);

        void Put(string id, object state);

        /// <summary>
        /// Gets the jsondocument for the item with the given
        /// id. Returns null if the item is not found.
        /// </summary>
        /// <param name="id">The id of the item to get.</param>
        /// <returns>The jsondocument, or null if none is found.</returns>
        T Get<T>(string state);


    }
}
