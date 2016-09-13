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

    public partial class Contact
    {
        /// <summary>
        /// Initializes a new instance of the Contact class.
        /// </summary>
        public Contact() { }

        /// <summary>
        /// Initializes a new instance of the Contact class.
        /// </summary>
        public Contact(string externalId, IList<Channel> channels = default(IList<Channel>), long? created = default(long?), string encryptedId = default(string), long? lastChanged = default(long?), IDictionary<string, object> properties = default(IDictionary<string, object>), bool? temporary = default(bool?), bool? testGroup = default(bool?))
        {
            Channels = channels;
            Created = created;
            EncryptedId = encryptedId;
            ExternalId = externalId;
            LastChanged = lastChanged;
            Properties = properties;
            Temporary = temporary;
            TestGroup = testGroup;
        }

        /// <summary>
        /// All available channels for this contact - Cannot be modified
        /// </summary>
        [JsonProperty(PropertyName = "channels")]
        public IList<Channel> Channels { get; set; }

        /// <summary>
        /// Date &amp; time the contact was created - Cannot be modified
        /// </summary>
        [JsonProperty(PropertyName = "created")]
        public long? Created { get; set; }

        /// <summary>
        /// Contact reference generated by MailPlus - Cannot be modified
        /// </summary>
        [JsonProperty(PropertyName = "encryptedId")]
        public string EncryptedId { get; set; }

        /// <summary>
        /// Specified contact reference by external system
        /// </summary>
        [JsonProperty(PropertyName = "externalId")]
        public string ExternalId { get; set; }

        /// <summary>
        /// Date &amp; time the contact has been changed - Cannot be modified
        /// </summary>
        [JsonProperty(PropertyName = "lastChanged")]
        public long? LastChanged { get; set; }

        /// <summary>
        /// Available properties can be retrieved by /contact/properties/list
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public IDictionary<string, object> Properties { get; set; }

        /// <summary>
        /// Indication whether the contact is temporary - Cannot be modified
        /// </summary>
        [JsonProperty(PropertyName = "temporary")]
        public bool? Temporary { get; set; }

        /// <summary>
        /// Defines whether the contact is added to the test group
        /// </summary>
        [JsonProperty(PropertyName = "testGroup")]
        public bool? TestGroup { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (ExternalId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ExternalId");
            }
            if (this.Channels != null)
            {
                foreach (var element in this.Channels)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}