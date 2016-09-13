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

    public partial class MailingHistory
    {
        /// <summary>
        /// Initializes a new instance of the MailingHistory class.
        /// </summary>
        public MailingHistory() { }

        /// <summary>
        /// Initializes a new instance of the MailingHistory class.
        /// </summary>
        public MailingHistory(bool clicked, Mailing mailing, bool opened, DateTime sentDate, string bounce = default(string))
        {
            Bounce = bounce;
            Clicked = clicked;
            Mailing = mailing;
            Opened = opened;
            SentDate = sentDate;
        }

        /// <summary>
        /// Possible values include: 'HARDBOUNCE', 'SOFTBOUNCE'
        /// </summary>
        [JsonProperty(PropertyName = "bounce")]
        public string Bounce { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "clicked")]
        public bool Clicked { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mailing")]
        public Mailing Mailing { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opened")]
        public bool Opened { get; set; }

        /// <summary>
        /// Date &amp; time the mailing was sent
        /// </summary>
        [JsonProperty(PropertyName = "sentDate")]
        public DateTime SentDate { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Mailing == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Mailing");
            }
            if (this.Mailing != null)
            {
                this.Mailing.Validate();
            }
        }
    }
}
