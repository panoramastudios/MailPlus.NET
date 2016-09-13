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

    public partial class MailingHistoryResponse
    {
        /// <summary>
        /// Initializes a new instance of the MailingHistoryResponse class.
        /// </summary>
        public MailingHistoryResponse() { }

        /// <summary>
        /// Initializes a new instance of the MailingHistoryResponse class.
        /// </summary>
        public MailingHistoryResponse(IList<MailingHistory> mailingHistories = default(IList<MailingHistory>), Paging paging = default(Paging))
        {
            MailingHistories = mailingHistories;
            Paging = paging;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mailingHistories")]
        public IList<MailingHistory> MailingHistories { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "paging")]
        public Paging Paging { get; set; }

    }
}