/*
 * Accounts Write Data Plane
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace dp.write.transaction.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class TransactionSummaryResponse : IEquatable<TransactionSummaryResponse>
    { 
        /// <summary>
        /// Gets or Sets Hash
        /// </summary>
        [DataMember(Name="hash")]
        public string Hash { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata")]
        public Object Metadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionSummaryResponse {\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((TransactionSummaryResponse)obj);
        }

        /// <summary>
        /// Returns true if TransactionSummaryResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TransactionSummaryResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionSummaryResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Hash == other.Hash ||
                    Hash != null &&
                    Hash.Equals(other.Hash)
                ) && 
                (
                    Metadata == other.Metadata ||
                    Metadata != null &&
                    Metadata.Equals(other.Metadata)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Hash != null)
                    hashCode = hashCode * 59 + Hash.GetHashCode();
                    if (Metadata != null)
                    hashCode = hashCode * 59 + Metadata.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(TransactionSummaryResponse left, TransactionSummaryResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TransactionSummaryResponse left, TransactionSummaryResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
