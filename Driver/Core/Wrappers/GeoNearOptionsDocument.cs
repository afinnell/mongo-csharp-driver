﻿/* Copyright 2010-2011 10gen Inc.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Bson.Serialization;

namespace MongoDB.Driver {
    /// <summary>
    /// Represents a BSON document that can be used where an IMongoGeoNearOptions is expected.
    /// </summary>
    public class GeoNearOptionsDocument : BsonDocument, IMongoGeoNearOptions {
        #region constructors
        /// <summary>
        /// Initializes a new instance of the GeoNearOptionsDocument class.
        /// </summary>
        public GeoNearOptionsDocument() {
        }

        /// <summary>
        /// Initializes a new instance of the GeoNearOptionsDocument class specifying whether duplicate element names are allowed
        /// (allowing duplicate element names is not recommended).
        /// </summary>
        /// <param name="allowDuplicateNames">Whether duplicate element names are allowed.</param>
        public GeoNearOptionsDocument(
            bool allowDuplicateNames
        )
            : base(allowDuplicateNames) {
        }

        /// <summary>
        /// Initializes a new instance of the GeoNearOptionsDocument class and adds one element.
        /// </summary>
        /// <param name="element">An element to add to the document.</param>
        public GeoNearOptionsDocument(
            BsonElement element
        )
            : base(element) {
        }

        /// <summary>
        /// Initializes a new instance of the GeoNearOptionsDocument class and adds new elements from a dictionary of key/value pairs.
        /// </summary>
        /// <param name="dictionary">A dictionary to initialize the document from.</param>
        public GeoNearOptionsDocument(
            Dictionary<string, object> dictionary
        )
            : base(dictionary) {
        }

        /// <summary>
        /// Initializes a new instance of the GeoNearOptionsDocument class and adds new elements from a dictionary of key/value pairs.
        /// </summary>
        /// <param name="dictionary">A dictionary to initialize the document from.</param>
        /// <param name="keys">A list of keys to select values from the dictionary.</param>
        public GeoNearOptionsDocument(
            Dictionary<string, object> dictionary,
            IEnumerable<string> keys
        )
            : base(dictionary, keys) {
        }

        /// <summary>
        /// Initializes a new instance of the GeoNearOptionsDocument class and adds new elements from a dictionary of key/value pairs.
        /// </summary>
        /// <param name="dictionary">A dictionary to initialize the document from.</param>
        public GeoNearOptionsDocument(
            IDictionary<string, object> dictionary
        )
            : base(dictionary) {
        }

        /// <summary>
        /// Initializes a new instance of the GeoNearOptionsDocument class and adds new elements from a dictionary of key/value pairs.
        /// </summary>
        /// <param name="dictionary">A dictionary to initialize the document from.</param>
        /// <param name="keys">A list of keys to select values from the dictionary.</param>
        public GeoNearOptionsDocument(
            IDictionary<string, object> dictionary,
            IEnumerable<string> keys
        )
            : base(dictionary, keys) {
        }

        /// <summary>
        /// Initializes a new instance of the GeoNearOptionsDocument class and adds new elements from a dictionary of key/value pairs.
        /// </summary>
        /// <param name="dictionary">A dictionary to initialize the document from.</param>
        public GeoNearOptionsDocument(
            IDictionary dictionary
        )
            : base(dictionary) {
        }

        /// <summary>
        /// Initializes a new instance of the GeoNearOptionsDocument class and adds new elements from a dictionary of key/value pairs.
        /// </summary>
        /// <param name="dictionary">A dictionary to initialize the document from.</param>
        /// <param name="keys">A list of keys to select values from the dictionary.</param>
        public GeoNearOptionsDocument(
            IDictionary dictionary,
            IEnumerable keys
        )
            : base(dictionary, keys) {
        }

        /// <summary>
        /// Initializes a new instance of the GeoNearOptionsDocument class and adds new elements from a list of elements.
        /// </summary>
        /// <param name="elements">A list of elements to add to the document.</param>
        public GeoNearOptionsDocument(
            IEnumerable<BsonElement> elements
        )
            : base(elements) {
        }

        /// <summary>
        /// Initializes a new instance of the GeoNearOptionsDocument class and adds one or more elements.
        /// </summary>
        /// <param name="elements">One or more elements to add to the document.</param>
        public GeoNearOptionsDocument(
            params BsonElement[] elements
        )
            : base(elements) {
        }

        /// <summary>
        /// Initializes a new instance of the GeoNearOptionsDocument class and creates and adds a new element.
        /// </summary>
        /// <param name="name">The name of the element to add to the document.</param>
        /// <param name="value">The value of the element to add to the document.</param>
        public GeoNearOptionsDocument(
            string name,
            BsonValue value
        )
            : base(name, value) {
        }
        #endregion
    }
}
