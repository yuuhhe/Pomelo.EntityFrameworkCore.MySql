// Copyright (c) Pomelo Foundation. All rights reserved.
// Licensed under the MIT. See LICENSE in the project root for license information.

using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Microsoft.EntityFrameworkCore.Metadata
{
    public class MySqlEntityTypeAnnotations : RelationalEntityTypeAnnotations, IMySqlEntityTypeAnnotations
    {
        public MySqlEntityTypeAnnotations([NotNull] IEntityType entityType)
            : base(entityType)
        {
        }

        public MySqlEntityTypeAnnotations([NotNull] RelationalAnnotations annotations)
            : base(annotations)
        {
        }
    }
}
