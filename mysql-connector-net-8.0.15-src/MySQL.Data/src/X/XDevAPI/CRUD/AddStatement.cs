// Copyright (c) 2015, 2018, Oracle and/or its affiliates. All rights reserved.
//
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License, version 2.0, as
// published by the Free Software Foundation.
//
// This program is also distributed with certain software (including
// but not limited to OpenSSL) that is licensed under separate terms,
// as designated in a particular file or component or in included license
// documentation.  The authors of MySQL hereby grant you an
// additional permission to link the program and your derivative works
// with the separately licensed software that they have included with
// MySQL.
//
// Without limiting anything contained in the foregoing, this file,
// which is part of MySQL Connector/NET, is also subject to the
// Universal FOSS Exception, version 1.0, a copy of which can be found at
// http://oss.oracle.com/licenses/universal-foss-exception.
//
// This program is distributed in the hope that it will be useful, but
// WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
// See the GNU General Public License, version 2.0, for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software Foundation, Inc.,
// 51 Franklin St, Fifth Floor, Boston, MA 02110-1301  USA

using System.Collections.Generic;
using MySqlX.XDevAPI.Common;
using System.Linq;
using System;

namespace MySqlX.XDevAPI.CRUD
{
  /// <summary>
  /// Represents a chaining collection insert statement.
  /// </summary>
  public class AddStatement : CrudStatement<Result>
  {
    private List<DbDoc> _DbDocs = new List<DbDoc>();
    internal bool upsert;

    internal AddStatement(Collection collection) : base(collection)
    {
    }

    /// <summary>
    /// Adds documents to the collection.
    /// </summary>
    /// <param name="items">The documents to add.</param>
    /// <returns>This <see cref="AddStatement"/> object.</returns>
    /// <exception cref="ArgumentNullException">The <paramref name="items"/> array is null.</exception>
    public AddStatement Add(params object[] items)
    {
      if (items == null)
        throw new ArgumentNullException();

      _DbDocs.AddRange(GetDocs(items));
      return this;
    }

    /// <summary>
    /// Executes the Add statement.
    /// </summary>
    /// <returns>A <see cref="Result"/> object containing the results of the execution.</returns>
    public override Result Execute()
    {
      try
      {
        ValidateOpenSession();
        if (_DbDocs.Count == 0)
          return new Result(null);

        //List<string> newIds = AssignIds();
        return Target.Session.XSession.Insert(Target, _DbDocs.ToArray(), null, upsert);
      }
      finally
      {
        _DbDocs.Clear();
      }
    }

    //private List<string> AssignIds()
    //{
    //  List<string> newIds = new List<string>();
    //  foreach (DbDoc doc in _DbDocs)
    //  {
    //    doc.EnsureId();
    //    newIds.Add(doc.Id.ToString());
    //  }

    //  return newIds;
    //}
  }
}
