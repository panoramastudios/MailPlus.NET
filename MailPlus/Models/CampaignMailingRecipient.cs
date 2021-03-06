// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace MailPlus.Models
{
    using System.Linq;

    public partial class CampaignMailingRecipient
    {
        /// <summary>
        /// Initializes a new instance of the CampaignMailingRecipient class.
        /// </summary>
        public CampaignMailingRecipient() { }

        /// <summary>
        /// Initializes a new instance of the CampaignMailingRecipient class.
        /// </summary>
        /// <param name="sendDate">Date & time the mailing has been
        /// sent</param>
        public CampaignMailingRecipient(int campaignSubscriptionId, ContactIdentifier contactIdentifier, System.DateTime sendDate)
        {
            CampaignSubscriptionId = campaignSubscriptionId;
            ContactIdentifier = contactIdentifier;
            SendDate = sendDate;
        }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "campaignSubscriptionId")]
        public int CampaignSubscriptionId { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "contactIdentifier")]
        public ContactIdentifier ContactIdentifier { get; set; }

        /// <summary>
        /// Gets or sets date &amp; time the mailing has been sent
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "sendDate")]
        public System.DateTime SendDate { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ContactIdentifier == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "ContactIdentifier");
            }
            if (this.ContactIdentifier != null)
            {
                this.ContactIdentifier.Validate();
            }
        }
    }
}
