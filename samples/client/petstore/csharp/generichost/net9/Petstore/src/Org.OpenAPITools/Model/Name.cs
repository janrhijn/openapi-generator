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
    /// Model for testing model name same as property name
    /// </summary>
    public partial class Name : IEquatable<Name>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Name" /> class.
        /// </summary>
        /// <param name="varName">varName</param>
        /// <param name="property">property</param>
        /// <param name="snakeCase">snakeCase</param>
        /// <param name="var123Number">var123Number</param>
        [JsonConstructor]
        public Name(int varName, Option<string> property = default, Option<int?> snakeCase = default, Option<int?> var123Number = default)
        {
            VarName = varName;
            PropertyOption = property;
            SnakeCaseOption = snakeCase;
            Var123NumberOption = var123Number;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets VarName
        /// </summary>
        [JsonPropertyName("name")]
        public int VarName { get; set; }

        /// <summary>
        /// Used to track the state of Property
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> PropertyOption { get; private set; }

        /// <summary>
        /// Gets or Sets Property
        /// </summary>
        [JsonPropertyName("property")]
        public string Property { get { return this.PropertyOption; } set { this.PropertyOption = new(value); } }

        /// <summary>
        /// Used to track the state of SnakeCase
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> SnakeCaseOption { get; }

        /// <summary>
        /// Gets or Sets SnakeCase
        /// </summary>
        [JsonPropertyName("snake_case")]
        public int? SnakeCase { get { return this.SnakeCaseOption; } }

        /// <summary>
        /// Used to track the state of Var123Number
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> Var123NumberOption { get; }

        /// <summary>
        /// Gets or Sets Var123Number
        /// </summary>
        [JsonPropertyName("123Number")]
        public int? Var123Number { get { return this.Var123NumberOption; } }

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
            sb.Append("class Name {\n");
            sb.Append("  VarName: ").Append(VarName).Append("\n");
            sb.Append("  Property: ").Append(Property).Append("\n");
            sb.Append("  SnakeCase: ").Append(SnakeCase).Append("\n");
            sb.Append("  Var123Number: ").Append(Var123Number).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return OpenAPIClientUtils.compareLogic.Compare(this, input as Name).AreEqual;
        }

        /// <summary>
        /// Returns true if Name instances are equal
        /// </summary>
        /// <param name="input">Instance of Name to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Name input)
        {
            return OpenAPIClientUtils.compareLogic.Compare(this, input).AreEqual;
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
                if (SnakeCase != null)
                    hashCode = (hashCode * 59) + SnakeCase.GetHashCode();

                if (Var123Number != null)
                    hashCode = (hashCode * 59) + Var123Number.GetHashCode();

                hashCode = (hashCode * 59) + AdditionalProperties.GetHashCode();

                return hashCode;
            }
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
    /// A Json converter for type <see cref="Name" />
    /// </summary>
    public class NameJsonConverter : JsonConverter<Name>
    {
        /// <summary>
        /// Deserializes json to <see cref="Name" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Name Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<int?> varName = default;
            Option<string> property = default;
            Option<int?> snakeCase = default;
            Option<int?> var123Number = default;

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
                        case "name":
                            varName = new Option<int?>(utf8JsonReader.TokenType == JsonTokenType.Null ? null : utf8JsonReader.GetInt32());
                            break;
                        case "property":
                            property = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "snake_case":
                            snakeCase = new Option<int?>(utf8JsonReader.TokenType == JsonTokenType.Null ? null : utf8JsonReader.GetInt32());
                            break;
                        case "123Number":
                            var123Number = new Option<int?>(utf8JsonReader.TokenType == JsonTokenType.Null ? null : utf8JsonReader.GetInt32());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!varName.IsSet)
                throw new ArgumentException("Property is required for class Name.", nameof(varName));

            if (varName.IsSet && varName.Value == null)
                throw new ArgumentNullException(nameof(varName), "Property is not nullable for class Name.");

            if (property.IsSet && property.Value == null)
                throw new ArgumentNullException(nameof(property), "Property is not nullable for class Name.");

            if (snakeCase.IsSet && snakeCase.Value == null)
                throw new ArgumentNullException(nameof(snakeCase), "Property is not nullable for class Name.");

            if (var123Number.IsSet && var123Number.Value == null)
                throw new ArgumentNullException(nameof(var123Number), "Property is not nullable for class Name.");

            return new Name(varName.Value.Value, property, snakeCase, var123Number);
        }

        /// <summary>
        /// Serializes a <see cref="Name" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="name"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Name name, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, name, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="Name" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="name"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, Name name, JsonSerializerOptions jsonSerializerOptions)
        {
            if (name.PropertyOption.IsSet && name.Property == null)
                throw new ArgumentNullException(nameof(name.Property), "Property is required for class Name.");

            writer.WriteNumber("name", name.VarName);

            if (name.PropertyOption.IsSet)
                writer.WriteString("property", name.Property);

            if (name.SnakeCaseOption.IsSet)
                writer.WriteNumber("snake_case", name.SnakeCaseOption.Value.Value);

            if (name.Var123NumberOption.IsSet)
                writer.WriteNumber("123Number", name.Var123NumberOption.Value.Value);
        }
    }
}
