// Copyright (c) Pomelo Foundation. All rights reserved.
// Licensed under the MIT. See LICENSE in the project root for license information.

using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Microsoft.EntityFrameworkCore.Metadata
{
    public class MySqlKeyAnnotations : RelationalKeyAnnotations, IMySqlKeyAnnotations
    {
        public MySqlKeyAnnotations([NotNull] IKey key)
            : base(key)
        {
        }

        protected MySqlKeyAnnotations([NotNull] RelationalAnnotations annotations)
            : base(annotations)
        {
        }
    }
}
