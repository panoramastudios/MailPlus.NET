// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace MailPlus.Models
{
    using System.Linq;

    public partial class CampaignField
    {
        /// <summary>
        /// Initializes a new instance of the CampaignField class.
        /// </summary>
        public CampaignField() { }

        /// <summary>
        /// Initializes a new instance of the CampaignField class.
        /// </summary>
        /// <param name="name">Placeholder name used in campaign
        /// mailing</param>
        /// <param name="type">Default: STRING. Possible values include:
        /// 'STRING', 'PRODUCTLIST'</param>
        /// <param name="value">Used by the string campaignfield</param>
        /// <param name="values">Used by the productlist campaignfield to post
        /// multiple product references</param>
        public CampaignField(string name, string type = default(string), string value = default(string), System.Collections.Generic.IList<string> values = default(System.Collections.Generic.IList<string>))
        {
            Name = name;
            Type = type;
            Value = value;
            Values = values;
        }

        /// <summary>
        /// Gets or sets placeholder name used in campaign mailing
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets default: STRING. Possible values include: 'STRING',
        /// 'PRODUCTLIST'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets used by the string campaignfield
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets used by the productlist campaignfield to post
        /// multiple product references
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "values")]
        public System.Collections.Generic.IList<string> Values { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}
