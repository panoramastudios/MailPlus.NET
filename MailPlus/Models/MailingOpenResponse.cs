// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace MailPlus.Models
{
    using System.Linq;

    public partial class MailingOpenResponse
    {
        /// <summary>
        /// Initializes a new instance of the MailingOpenResponse class.
        /// </summary>
        public MailingOpenResponse() { }

        /// <summary>
        /// Initializes a new instance of the MailingOpenResponse class.
        /// </summary>
        public MailingOpenResponse(System.Collections.Generic.IList<MailingOpen> opens = default(System.Collections.Generic.IList<MailingOpen>), Paging paging = default(Paging))
        {
            Opens = opens;
            Paging = paging;
        }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "opens")]
        public System.Collections.Generic.IList<MailingOpen> Opens { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "paging")]
        public Paging Paging { get; set; }

    }
}
