// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

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
using System.Text.Json.Serialization.Metadata;
using Org.OpenAPITools.Client;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// BananaReq
    /// </summary>
    public partial class BananaReq : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BananaReq" /> class.
        /// </summary>
        /// <param name="lengthCm">lengthCm</param>
        /// <param name="sweet">sweet</param>
        [JsonConstructor]
        public BananaReq(decimal lengthCm, Option<bool?> sweet = default)
        {
            LengthCm = lengthCm;
            SweetOption = sweet;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets LengthCm
        /// </summary>
        [JsonPropertyName("lengthCm")]
        public decimal LengthCm { get; set; }

        /// <summary>
        /// Used to track the state of Sweet
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> SweetOption { get; private set; }

        /// <summary>
        /// Gets or Sets Sweet
        /// </summary>
        [JsonPropertyName("sweet")]
        public bool? Sweet { get { return this.SweetOption; } set { this.SweetOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BananaReq {\n");
            sb.Append("  LengthCm: ").Append(LengthCm).Append("\n");
            sb.Append("  Sweet: ").Append(Sweet).Append("\n");
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
    /// A Json converter for type <see cref="BananaReq" />
    /// </summary>
    public class BananaReqJsonConverter : JsonConverter<BananaReq>
    {
        /// <summary>
        /// Deserializes json to <see cref="BananaReq" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override BananaReq Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<decimal?> lengthCm = default;
            Option<bool?> sweet = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "lengthCm":
                            lengthCm = new Option<decimal?>(utf8JsonReader.TokenType == JsonTokenType.Null ? null : utf8JsonReader.GetDecimal());
                            break;
                        case "sweet":
                            sweet = new Option<bool?>(utf8JsonReader.TokenType == JsonTokenType.Null ? null : utf8JsonReader.GetBoolean());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!lengthCm.IsSet)
                throw new ArgumentException("Property is required for class BananaReq.", nameof(lengthCm));

            if (lengthCm.IsSet && lengthCm.Value == null)
                throw new ArgumentNullException(nameof(lengthCm), "Property is not nullable for class BananaReq.");

            if (sweet.IsSet && sweet.Value == null)
                throw new ArgumentNullException(nameof(sweet), "Property is not nullable for class BananaReq.");

            return new BananaReq(lengthCm.Value!.Value!, sweet);
        }

        /// <summary>
        /// Serializes a <see cref="BananaReq" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="bananaReq"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, BananaReq bananaReq, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, bananaReq, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="BananaReq" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="bananaReq"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, BananaReq bananaReq, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteNumber("lengthCm", bananaReq.LengthCm);

            if (bananaReq.SweetOption.IsSet)
                writer.WriteBoolean("sweet", bananaReq.SweetOption.Value!.Value);
        }
    }

    /// <summary>
    /// The BananaReqSerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata | JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(BananaReq))]
    public partial class BananaReqSerializationContext : JsonSerializerContext { }
}
