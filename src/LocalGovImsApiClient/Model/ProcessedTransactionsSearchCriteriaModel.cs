/*
 * Api
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
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
    /// ProcessedTransactionsSearchCriteriaModel
    /// </summary>
    [DataContract(Name = "ProcessedTransactionsSearchCriteriaModel")]
    public partial class ProcessedTransactionsSearchCriteriaModel : IEquatable<ProcessedTransactionsSearchCriteriaModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessedTransactionsSearchCriteriaModel" /> class.
        /// </summary>
        /// <param name="receiptNumber">receiptNumber.</param>
        /// <param name="fundCodes">fundCodes.</param>
        /// <param name="accountReference">accountReference.</param>
        /// <param name="amount">amount.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="appReference">appReference.</param>
        /// <param name="mopCodes">mopCodes.</param>
        /// <param name="narrative">narrative.</param>
        /// <param name="internalReference">internalReference.</param>
        /// <param name="pspReference">pspReference.</param>
        public ProcessedTransactionsSearchCriteriaModel(string receiptNumber = default(string), List<string> fundCodes = default(List<string>), string accountReference = default(string), double amount = default(double), DateTime startDate = default(DateTime), DateTime endDate = default(DateTime), string appReference = default(string), List<string> mopCodes = default(List<string>), string narrative = default(string), string internalReference = default(string), string pspReference = default(string))
        {
            this.ReceiptNumber = receiptNumber;
            this.FundCodes = fundCodes;
            this.AccountReference = accountReference;
            this.Amount = amount;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.AppReference = appReference;
            this.MopCodes = mopCodes;
            this.Narrative = narrative;
            this.InternalReference = internalReference;
            this.PspReference = pspReference;
        }

        /// <summary>
        /// Gets or Sets ReceiptNumber
        /// </summary>
        [DataMember(Name = "ReceiptNumber", EmitDefaultValue = false)]
        public string ReceiptNumber { get; set; }

        /// <summary>
        /// Gets or Sets FundCodes
        /// </summary>
        [DataMember(Name = "FundCodes", EmitDefaultValue = false)]
        public List<string> FundCodes { get; set; }

        /// <summary>
        /// Gets or Sets AccountReference
        /// </summary>
        [DataMember(Name = "AccountReference", EmitDefaultValue = false)]
        public string AccountReference { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "Amount", EmitDefaultValue = false)]
        public double Amount { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name = "StartDate", EmitDefaultValue = false)]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name = "EndDate", EmitDefaultValue = false)]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Gets or Sets AppReference
        /// </summary>
        [DataMember(Name = "AppReference", EmitDefaultValue = false)]
        public string AppReference { get; set; }

        /// <summary>
        /// Gets or Sets MopCodes
        /// </summary>
        [DataMember(Name = "MopCodes", EmitDefaultValue = false)]
        public List<string> MopCodes { get; set; }

        /// <summary>
        /// Gets or Sets Narrative
        /// </summary>
        [DataMember(Name = "Narrative", EmitDefaultValue = false)]
        public string Narrative { get; set; }

        /// <summary>
        /// Gets or Sets InternalReference
        /// </summary>
        [DataMember(Name = "InternalReference", EmitDefaultValue = false)]
        public string InternalReference { get; set; }

        /// <summary>
        /// Gets or Sets PspReference
        /// </summary>
        [DataMember(Name = "PspReference", EmitDefaultValue = false)]
        public string PspReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProcessedTransactionsSearchCriteriaModel {\n");
            sb.Append("  ReceiptNumber: ").Append(ReceiptNumber).Append("\n");
            sb.Append("  FundCodes: ").Append(FundCodes).Append("\n");
            sb.Append("  AccountReference: ").Append(AccountReference).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  AppReference: ").Append(AppReference).Append("\n");
            sb.Append("  MopCodes: ").Append(MopCodes).Append("\n");
            sb.Append("  Narrative: ").Append(Narrative).Append("\n");
            sb.Append("  InternalReference: ").Append(InternalReference).Append("\n");
            sb.Append("  PspReference: ").Append(PspReference).Append("\n");
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
            return this.Equals(input as ProcessedTransactionsSearchCriteriaModel);
        }

        /// <summary>
        /// Returns true if ProcessedTransactionsSearchCriteriaModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ProcessedTransactionsSearchCriteriaModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProcessedTransactionsSearchCriteriaModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ReceiptNumber == input.ReceiptNumber ||
                    (this.ReceiptNumber != null &&
                    this.ReceiptNumber.Equals(input.ReceiptNumber))
                ) && 
                (
                    this.FundCodes == input.FundCodes ||
                    this.FundCodes != null &&
                    input.FundCodes != null &&
                    this.FundCodes.SequenceEqual(input.FundCodes)
                ) && 
                (
                    this.AccountReference == input.AccountReference ||
                    (this.AccountReference != null &&
                    this.AccountReference.Equals(input.AccountReference))
                ) && 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.AppReference == input.AppReference ||
                    (this.AppReference != null &&
                    this.AppReference.Equals(input.AppReference))
                ) && 
                (
                    this.MopCodes == input.MopCodes ||
                    this.MopCodes != null &&
                    input.MopCodes != null &&
                    this.MopCodes.SequenceEqual(input.MopCodes)
                ) && 
                (
                    this.Narrative == input.Narrative ||
                    (this.Narrative != null &&
                    this.Narrative.Equals(input.Narrative))
                ) && 
                (
                    this.InternalReference == input.InternalReference ||
                    (this.InternalReference != null &&
                    this.InternalReference.Equals(input.InternalReference))
                ) && 
                (
                    this.PspReference == input.PspReference ||
                    (this.PspReference != null &&
                    this.PspReference.Equals(input.PspReference))
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
                if (this.ReceiptNumber != null)
                {
                    hashCode = (hashCode * 59) + this.ReceiptNumber.GetHashCode();
                }
                if (this.FundCodes != null)
                {
                    hashCode = (hashCode * 59) + this.FundCodes.GetHashCode();
                }
                if (this.AccountReference != null)
                {
                    hashCode = (hashCode * 59) + this.AccountReference.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                if (this.StartDate != null)
                {
                    hashCode = (hashCode * 59) + this.StartDate.GetHashCode();
                }
                if (this.EndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EndDate.GetHashCode();
                }
                if (this.AppReference != null)
                {
                    hashCode = (hashCode * 59) + this.AppReference.GetHashCode();
                }
                if (this.MopCodes != null)
                {
                    hashCode = (hashCode * 59) + this.MopCodes.GetHashCode();
                }
                if (this.Narrative != null)
                {
                    hashCode = (hashCode * 59) + this.Narrative.GetHashCode();
                }
                if (this.InternalReference != null)
                {
                    hashCode = (hashCode * 59) + this.InternalReference.GetHashCode();
                }
                if (this.PspReference != null)
                {
                    hashCode = (hashCode * 59) + this.PspReference.GetHashCode();
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
