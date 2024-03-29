/*
 * LocalGovImsApi
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = LocalGovImsApiClient.Client.OpenAPIDateConverter;

namespace LocalGovImsApiClient.Model
{
    /// <summary>
    /// PaymentResponseModel
    /// </summary>
    [DataContract(Name = "PaymentResponseModel")]
    public partial class PaymentResponseModel : IEquatable<PaymentResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentResponseModel" /> class.
        /// </summary>
        /// <param name="paymentUrl">paymentUrl.</param>
        /// <param name="reference">reference.</param>
        public PaymentResponseModel(string paymentUrl = default(string), string reference = default(string))
        {
            this.PaymentUrl = paymentUrl;
            this.Reference = reference;
        }

        /// <summary>
        /// Gets or Sets PaymentUrl
        /// </summary>
        [DataMember(Name = "PaymentUrl", EmitDefaultValue = true)]
        public string PaymentUrl { get; set; }

        /// <summary>
        /// Gets or Sets Reference
        /// </summary>
        [DataMember(Name = "Reference", EmitDefaultValue = true)]
        public string Reference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentResponseModel {\n");
            sb.Append("  PaymentUrl: ").Append(PaymentUrl).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PaymentResponseModel);
        }

        /// <summary>
        /// Returns true if PaymentResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PaymentUrl == input.PaymentUrl ||
                    (this.PaymentUrl != null &&
                    this.PaymentUrl.Equals(input.PaymentUrl))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.PaymentUrl != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentUrl.GetHashCode();
                }
                if (this.Reference != null)
                {
                    hashCode = (hashCode * 59) + this.Reference.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
