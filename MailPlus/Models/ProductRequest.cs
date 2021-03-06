// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace MailPlus.Models
{
    using System.Linq;

    public partial class ProductRequest
    {
        /// <summary>
        /// Initializes a new instance of the ProductRequest class.
        /// </summary>
        public ProductRequest() { }

        /// <summary>
        /// Initializes a new instance of the ProductRequest class.
        /// </summary>
        /// <param name="update">Only existing products can be updated -
        /// Default value: false</param>
        public ProductRequest(Product product, bool? update = default(bool?))
        {
            Product = product;
            Update = update;
        }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "product")]
        public Product Product { get; set; }

        /// <summary>
        /// Gets or sets only existing products can be updated - Default
        /// value: false
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "update")]
        public bool? Update { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Product == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Product");
            }
            if (this.Product != null)
            {
                this.Product.Validate();
            }
        }
    }
}
