// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
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
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;
using Org.OpenAPITools.Client;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// OuterComposite
    /// </summary>
    public partial class OuterComposite : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OuterComposite" /> class.
        /// </summary>
        /// <param name="myBoolean">myBoolean</param>
        /// <param name="myNumber">myNumber</param>
        /// <param name="myString">myString</param>
        [JsonConstructor]
        public OuterComposite(Option<bool?> myBoolean = default, Option<decimal?> myNumber = default, Option<string> myString = default)
        {
            MyBooleanOption = myBoolean;
            MyNumberOption = myNumber;
            MyStringOption = myString;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of MyBoolean
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> MyBooleanOption { get; private set; }

        /// <summary>
        /// Gets or Sets MyBoolean
        /// </summary>
        [JsonPropertyName("my_boolean")]
        public bool? MyBoolean { get { return this.MyBooleanOption; } set { this.MyBooleanOption = new Option<bool?>(value); } }

        /// <summary>
        /// Used to track the state of MyNumber
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<decimal?> MyNumberOption { get; private set; }

        /// <summary>
        /// Gets or Sets MyNumber
        /// </summary>
        [JsonPropertyName("my_number")]
        public decimal? MyNumber { get { return this.MyNumberOption; } set { this.MyNumberOption = new Option<decimal?>(value); } }

        /// <summary>
        /// Used to track the state of MyString
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> MyStringOption { get; private set; }

        /// <summary>
        /// Gets or Sets MyString
        /// </summary>
        [JsonPropertyName("my_string")]
        public string MyString { get { return this.MyStringOption; } set { this.MyStringOption = new Option<string>(value); } }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, JsonElement> AdditionalProperties { get; } = new Dictionary<string, JsonElement>();

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OuterComposite {\n");
            sb.Append("  MyBoolean: ").Append(MyBoolean).Append("\n");
            sb.Append("  MyNumber: ").Append(MyNumber).Append("\n");
            sb.Append("  MyString: ").Append(MyString).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="OuterComposite" />
    /// </summary>
    public class OuterCompositeJsonConverter : JsonConverter<OuterComposite>
    {
        /// <summary>
        /// Deserializes json to <see cref="OuterComposite" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override OuterComposite Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<bool?> myBoolean = default;
            Option<decimal?> myNumber = default;
            Option<string> myString = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "my_boolean":
                            myBoolean = new Option<bool?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (bool?)null : utf8JsonReader.GetBoolean());
                            break;
                        case "my_number":
                            myNumber = new Option<decimal?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (decimal?)null : utf8JsonReader.GetDecimal());
                            break;
                        case "my_string":
                            myString = new Option<string>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (myBoolean.IsSet && myBoolean.Value == null)
                throw new ArgumentNullException(nameof(myBoolean), "Property is not nullable for class OuterComposite.");

            if (myNumber.IsSet && myNumber.Value == null)
                throw new ArgumentNullException(nameof(myNumber), "Property is not nullable for class OuterComposite.");

            if (myString.IsSet && myString.Value == null)
                throw new ArgumentNullException(nameof(myString), "Property is not nullable for class OuterComposite.");

            return new OuterComposite(myBoolean, myNumber, myString);
        }

        /// <summary>
        /// Serializes a <see cref="OuterComposite" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="outerComposite"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, OuterComposite outerComposite, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, outerComposite, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="OuterComposite" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="outerComposite"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, OuterComposite outerComposite, JsonSerializerOptions jsonSerializerOptions)
        {
            if (outerComposite.MyStringOption.IsSet && outerComposite.MyString == null)
                throw new ArgumentNullException(nameof(outerComposite.MyString), "Property is required for class OuterComposite.");

            if (outerComposite.MyBooleanOption.IsSet)
                writer.WriteBoolean("my_boolean", outerComposite.MyBooleanOption.Value.Value);

            if (outerComposite.MyNumberOption.IsSet)
                writer.WriteNumber("my_number", outerComposite.MyNumberOption.Value.Value);

            if (outerComposite.MyStringOption.IsSet)
                writer.WriteString("my_string", outerComposite.MyString);
        }
    }
}
