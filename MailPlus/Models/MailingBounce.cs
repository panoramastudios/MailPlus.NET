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

    public partial class MailingBounce
    {
        /// <summary>
        /// Initializes a new instance of the MailingBounce class.
        /// </summary>
        public MailingBounce() { }

        /// <summary>
        /// Initializes a new instance of the MailingBounce class.
        /// </summary>
        public MailingBounce(DateTime bounceDate, ContactIdentifier contactIdentifier, string type)
        {
            BounceDate = bounceDate;
            ContactIdentifier = contactIdentifier;
            Type = type;
        }

        /// <summary>
        /// Date &amp; time the bounce occured
        /// </summary>
        [JsonProperty(PropertyName = "bounceDate")]
        public DateTime BounceDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contactIdentifier")]
        public ContactIdentifier ContactIdentifier { get; set; }

        /// <summary>
        /// Possible values include: 'HARDBOUNCE', 'SOFTBOUNCE'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (ContactIdentifier == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ContactIdentifier");
            }
            if (Type == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Type");
            }
            if (this.ContactIdentifier != null)
            {
                this.ContactIdentifier.Validate();
            }
        }
    }
}
