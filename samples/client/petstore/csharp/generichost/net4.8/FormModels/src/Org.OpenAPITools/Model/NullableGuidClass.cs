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
    /// NullableGuidClass
    /// </summary>
    public partial class NullableGuidClass : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NullableGuidClass" /> class.
        /// </summary>
        /// <param name="uuid">uuid</param>
        [JsonConstructor]
        public NullableGuidClass(Option<Guid?> uuid = default)
        {
            UuidOption = uuid;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Uuid
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Guid?> UuidOption { get; private set; }

        /// <summary>
        /// Gets or Sets Uuid
        /// </summary>
        /* <example>72f98069-206d-4f12-9f12-3d1e525a8e84</example> */
        [JsonPropertyName("uuid")]
        public Guid? Uuid { get { return this.UuidOption; } set { this.UuidOption = new Option<Guid?>(value); } }

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
            sb.Append("class NullableGuidClass {\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
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
    /// A Json converter for type <see cref="NullableGuidClass" />
    /// </summary>
    public class NullableGuidClassJsonConverter : JsonConverter<NullableGuidClass>
    {
        /// <summary>
        /// Deserializes json to <see cref="NullableGuidClass" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override NullableGuidClass Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<Guid?> uuid = default;

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
                        case "uuid":
                            uuid = new Option<Guid?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (Guid?)null : utf8JsonReader.GetGuid());
                            break;
                        default:
                            break;
                    }
                }
            }

            return new NullableGuidClass(uuid);
        }

        /// <summary>
        /// Serializes a <see cref="NullableGuidClass" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="nullableGuidClass"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, NullableGuidClass nullableGuidClass, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, nullableGuidClass, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="NullableGuidClass" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="nullableGuidClass"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, NullableGuidClass nullableGuidClass, JsonSerializerOptions jsonSerializerOptions)
        {
            if (nullableGuidClass.UuidOption.IsSet)
                if (nullableGuidClass.UuidOption.Value != null)
                    writer.WriteString("uuid", nullableGuidClass.UuidOption.Value.Value);
                else
                    writer.WriteNull("uuid");
        }
    }
}
