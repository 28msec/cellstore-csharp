using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace CellStore.Model
{

    /// <summary>
    /// Information about an operation outcome
    /// </summary>
    [DataContract]
    public class Outcome :  IEquatable<Outcome>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Outcome" /> class.
        /// </summary>
        public Outcome()
        {
            
        }

        
        /// <summary>
        /// Whether the requests succeeded or failed.
        /// </summary>
        /// <value>Whether the requests succeeded or failed.</value>
        [DataMember(Name="success", EmitDefaultValue=false)]
        public bool? Success { get; set; }
  
        
        /// <summary>
        /// A description of the error, if any.
        /// </summary>
        /// <value>A description of the error, if any.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Outcome {\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            
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
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Outcome);
        }

        /// <summary>
        /// Returns true if Outcome instances are equal
        /// </summary>
        /// <param name="obj">Instance of Outcome to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Outcome other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Success == other.Success ||
                    this.Success != null &&
                    this.Success.Equals(other.Success)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (this.Success != null)
                    hash = hash * 57 + this.Success.GetHashCode();
                
                if (this.Description != null)
                    hash = hash * 57 + this.Description.GetHashCode();
                
                return hash;
            }
        }

    }
}
