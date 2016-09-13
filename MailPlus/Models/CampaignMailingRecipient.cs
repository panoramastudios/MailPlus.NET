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

    public partial class CampaignMailingRecipient
    {
        /// <summary>
        /// Initializes a new instance of the CampaignMailingRecipient class.
        /// </summary>
        public CampaignMailingRecipient() { }

        /// <summary>
        /// Initializes a new instance of the CampaignMailingRecipient class.
        /// </summary>
        public CampaignMailingRecipient(int campaignSubscriptionId, ContactIdentifier contactIdentifier, DateTime sendDate)
        {
            CampaignSubscriptionId = campaignSubscriptionId;
            ContactIdentifier = contactIdentifier;
            SendDate = sendDate;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaignSubscriptionId")]
        public int CampaignSubscriptionId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contactIdentifier")]
        public ContactIdentifier ContactIdentifier { get; set; }

        /// <summary>
        /// Date &amp; time the mailing has been sent
        /// </summary>
        [JsonProperty(PropertyName = "sendDate")]
        public DateTime SendDate { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (ContactIdentifier == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ContactIdentifier");
            }
            if (this.ContactIdentifier != null)
            {
                this.ContactIdentifier.Validate();
            }
        }
    }
}