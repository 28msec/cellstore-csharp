using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Information about an operation outcome
  /// </summary>
  [DataContract]
  public class Outcome {
    
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
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Outcome {\n");
      
      sb.Append("  Success: ").Append(Success).Append("\n");
      
      sb.Append("  Description: ").Append(Description).Append("\n");
      
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
