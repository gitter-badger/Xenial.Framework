﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Xenial.Framework.Layouts.ColumnItems
{
    /// <summary>
    /// Class ColumnCollection.
    /// Implements the <see cref="System.Collections.Generic.ICollection{T}" />
    /// Implements the <see cref="System.Collections.Generic.IEnumerable{T}" />
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="System.Collections.Generic.ICollection{T}" />
    /// <seealso cref="System.Collections.Generic.IEnumerable{T}" />
    /// <autogeneratedoc />
    public sealed class ColumnCollection<T> : ICollection<T>, IEnumerable<T>
        where T : Column
    {
        int ICollection<T>.Count => columns.Count;
        bool ICollection<T>.IsReadOnly => false;
        void ICollection<T>.CopyTo(T[] array, int arrayIndex) => columns.CopyTo(array, arrayIndex);

        private readonly LinkedList<T> columns;

        /// <summary>
        /// Initializes a new instance of the <see cref="ColumnCollection{T}"/> class.
        /// </summary>
        /// <autogeneratedoc />
        public ColumnCollection()
            => columns = new();

        /// <summary>
        /// Initializes a new instance of the <see cref="ColumnCollection{T}"/> class.
        /// </summary>
        /// <param name="columns">The columns.</param>
        /// <autogeneratedoc />
        public ColumnCollection(IEnumerable<T> columns)
            => this.columns = new(columns);

        /// <summary>
        /// Adds the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <autogeneratedoc />
        public void Add(T item)
            => columns.AddLast(item);

        /// <summary>
        /// Clears this instance.
        /// </summary>
        /// <autogeneratedoc />
        public void Clear()
            => columns.Clear();

        /// <summary>
        /// Removes the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>bool.</returns>
        /// <autogeneratedoc />
        public bool Remove(T item)
            => columns.Remove(item);

        /// <summary>
        /// Determines whether this instance contains the object.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>bool.</returns>
        /// <autogeneratedoc />
        public bool Contains(T item)
            => columns.Contains(item);

        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>An enumerator that can be used to iterate through the collection.</returns>
        /// <autogeneratedoc />
        public IEnumerator<T> GetEnumerator() => columns.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => columns.GetEnumerator();
    }
}
