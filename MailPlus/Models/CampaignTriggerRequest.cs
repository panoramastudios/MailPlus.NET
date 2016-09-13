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

    public partial class CampaignTriggerRequest
    {
        /// <summary>
        /// Initializes a new instance of the CampaignTriggerRequest class.
        /// </summary>
        public CampaignTriggerRequest() { }

        /// <summary>
        /// Initializes a new instance of the CampaignTriggerRequest class.
        /// </summary>
        public CampaignTriggerRequest(string externalContactId, IList<CampaignField> campaignFields = default(IList<CampaignField>))
        {
            CampaignFields = campaignFields;
            ExternalContactId = externalContactId;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaignFields")]
        public IList<CampaignField> CampaignFields { get; set; }

        /// <summary>
        /// Specified contact reference by external system
        /// </summary>
        [JsonProperty(PropertyName = "externalContactId")]
        public string ExternalContactId { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (ExternalContactId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ExternalContactId");
            }
            if (this.CampaignFields != null)
            {
                foreach (var element in this.CampaignFields)
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
