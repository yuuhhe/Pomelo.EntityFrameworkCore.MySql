﻿// Copyright (c) Pomelo Foundation. All rights reserved.
// Licensed under the MIT. See LICENSE in the project root for license information.

using JetBrains.Annotations;

// ReSharper disable once CheckNamespace
namespace Microsoft.EntityFrameworkCore.Migrations.Operations
{
    public class MySqlCreateDatabaseOperation : MigrationOperation 
    {
        public virtual string Name { get;[param: NotNull] set; }

        [CanBeNull]
        public virtual string Template { get; set; }
    }
}
