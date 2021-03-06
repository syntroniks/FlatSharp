﻿/*
 * Copyright 2018 James Courtney
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
 
 namespace FlatSharp.TypeModel
{
    /// <summary>
    /// Defines a FlatBuffer string type.
    /// </summary>
    public class StringTypeModel : RuntimeTypeModel
    {
        internal StringTypeModel() : base(typeof(string))
        {
        }

        /// <summary>
        /// Gets the schema type.
        /// </summary>
        public override FlatBufferSchemaType SchemaType => FlatBufferSchemaType.String;

        /// <summary>
        /// The alignment of the string values. Note that this is aligned by the uoffset_t.
        /// </summary>
        public override int Alignment => sizeof(uint);

        /// <summary>
        /// The inline size of the string (uoffset_t).
        /// </summary>
        public override int InlineSize => sizeof(uint);

        /// <summary>
        /// Strings are arbitrary in length.
        /// </summary>
        public override bool IsFixedSize => false;

        /// <summary>
        /// String are built in.
        /// </summary>
        public override bool IsBuiltInType => true;
    }
}
