// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Web linked service.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Web")]
    public partial class WebLinkedService : LinkedService
    {
        /// <summary>
        /// Initializes a new instance of the WebLinkedService class.
        /// </summary>
        public WebLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WebLinkedService class.
        /// </summary>
        /// <param name="typeProperties">Web linked service properties.</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="connectVia">The integration runtime reference.</param>
        /// <param name="description">Linked service description.</param>
        /// <param name="parameters">Parameters for linked service.</param>
        /// <param name="annotations">List of tags that can be used for
        /// describing the linked service.</param>
        public WebLinkedService(WebLinkedServiceTypeProperties typeProperties, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), IntegrationRuntimeReference connectVia = default(IntegrationRuntimeReference), string description = default(string), IDictionary<string, ParameterSpecification> parameters = default(IDictionary<string, ParameterSpecification>), IList<object> annotations = default(IList<object>))
            : base(additionalProperties, connectVia, description, parameters, annotations)
        {
            TypeProperties = typeProperties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets web linked service properties.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties")]
        public WebLinkedServiceTypeProperties TypeProperties { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (TypeProperties == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TypeProperties");
            }
            if (TypeProperties != null)
            {
                TypeProperties.Validate();
            }
        }
    }
}
