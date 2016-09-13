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

    public partial class CampaignTrigger
    {
        /// <summary>
        /// Initializes a new instance of the CampaignTrigger class.
        /// </summary>
        public CampaignTrigger() { }

        /// <summary>
        /// Initializes a new instance of the CampaignTrigger class.
        /// </summary>
        public CampaignTrigger(string encryptedId, string name)
        {
            EncryptedId = encryptedId;
            Name = name;
        }

        /// <summary>
        /// encryptedTriggerId
        /// </summary>
        [JsonProperty(PropertyName = "encryptedId")]
        public string EncryptedId { get; set; }

        /// <summary>
        /// Trigger name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (EncryptedId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "EncryptedId");
            }
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}
