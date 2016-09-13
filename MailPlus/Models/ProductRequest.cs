// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace MailPlus.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class ProductRequest
    {
        /// <summary>
        /// Initializes a new instance of the ProductRequest class.
        /// </summary>
        public ProductRequest() { }

        /// <summary>
        /// Initializes a new instance of the ProductRequest class.
        /// </summary>
        public ProductRequest(Product product, bool? update = default(bool?))
        {
            Product = product;
            Update = update;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "product")]
        public Product Product { get; set; }

        /// <summary>
        /// Only existing products can be updated - Default value: false
        /// </summary>
        [JsonProperty(PropertyName = "update")]
        public bool? Update { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Product == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Product");
            }
            if (this.Product != null)
            {
                this.Product.Validate();
            }
        }
    }
}
