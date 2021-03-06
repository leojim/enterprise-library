﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Web;

namespace AExpense.DataAccessLayer
{
    [SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    public class ExpenseTable<TEntity> : IExpenseTable<TEntity>
        where TEntity : class
    {
        private readonly Table<TEntity> _table;

        public ExpenseTable(Table<TEntity> table)
        {
            _table = table;
        }

        public IEnumerable<TEntity> Collection
        {
            get { return _table; }
        }

        public void InsertOnSubmit(TEntity entity)
        {
            _table.InsertOnSubmit(entity);
        }


        public Type ElementType
        {
            get { throw new NotImplementedException(); }
        }

        public System.Linq.Expressions.Expression Expression
        {
            get { throw new NotImplementedException(); }
        }

        public IQueryProvider Provider
        {
            get { throw new NotImplementedException(); }
        }

        public System.Collections.IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator<TEntity> IEnumerable<TEntity>.GetEnumerator()
        {
            return this._table.GetEnumerator();
        }
    }
}