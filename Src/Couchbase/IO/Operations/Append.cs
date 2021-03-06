﻿using Couchbase.Core;
using Couchbase.Core.Serializers;
using Couchbase.IO.Converters;

namespace Couchbase.IO.Operations
{
    internal sealed class Append<T> : OperationBase<T>
    {
        public Append(IByteConverter converter)
            : base(converter)
        {
        }

        public Append(string key, T value, ITypeSerializer serializer, IVBucket vBucket, IByteConverter converter)
            : base(key, value, serializer, vBucket, converter)
        {
        }

        public Append(string key, T value, IVBucket vBucket, IByteConverter converter)
            : base(key, value, vBucket, converter)
        {
        }

        public Append(string key, IVBucket vBucket, IByteConverter converter)
            : base(key, vBucket, converter)
        {
        }

        public Append(string key, IVBucket vBucket, IByteConverter converter, ITypeSerializer serializer)
            : base(key, vBucket, converter, serializer)
        {
        }

        public override byte[] CreateExtras()
        {
            return new byte[0];
        }

        public override OperationCode OperationCode
        {
            get { return OperationCode.Append; }
        }
    }
}

#region [ License information ]

/* ************************************************************
 *
 *    @author Couchbase <info@couchbase.com>
 *    @copyright 2014 Couchbase, Inc.
 *
 *    Licensed under the Apache License, Version 2.0 (the "License");
 *    you may not use this file except in compliance with the License.
 *    You may obtain a copy of the License at
 *
 *        http://www.apache.org/licenses/LICENSE-2.0
 *
 *    Unless required by applicable law or agreed to in writing, software
 *    distributed under the License is distributed on an "AS IS" BASIS,
 *    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *    See the License for the specific language governing permissions and
 *    limitations under the License.
 *
 * ************************************************************/

#endregion [ License information ]