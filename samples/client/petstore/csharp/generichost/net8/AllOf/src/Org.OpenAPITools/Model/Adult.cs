// <auto-generated>
/*
 * Example
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
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
using Org.OpenAPITools.Client;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// A representation of an adult
    /// </summary>
    public partial class Adult : Person, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Adult" /> class.
        /// </summary>
        /// <param name="children">children</param>
        /// <param name="firstName">firstName</param>
        /// <param name="lastName">lastName</param>
        [JsonConstructor]
        public Adult(Option<List<Child>?> children = default, Option<string?> firstName = default, Option<string?> lastName = default) : base(firstName, lastName)
        {
            ChildrenOption = children;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Children
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<Child>?> ChildrenOption { get; private set; }

        /// <summary>
        /// Gets or Sets Children
        /// </summary>
        [JsonPropertyName("children")]
        public List<Child>? Children { get { return this.ChildrenOption; } set { this.ChildrenOption = new(value); } }

        /// <summary>
        /// The discriminator
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public new string Type { get; } = "Adult";

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Adult {\n");
            sb.Append("  ").Append(base.ToString()?.Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Children: ").Append(Children).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="Adult" />
    /// </summary>
    public class AdultJsonConverter : JsonConverter<Adult>
    {
        /// <summary>
        /// Deserializes json to <see cref="Adult" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Adult Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<List<Child>?> children = default;
            Option<string?> firstName = default;
            Option<string?> lastName = default;
            Option<string?> type = default;

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
                        case "children":
                            children = new Option<List<Child>?>(JsonSerializer.Deserialize<List<Child>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "firstName":
                            firstName = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "lastName":
                            lastName = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "$_type":
                            type = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (children.IsSet && children.Value == null)
                throw new ArgumentNullException(nameof(children), "Property is not nullable for class Adult.");

            if (firstName.IsSet && firstName.Value == null)
                throw new ArgumentNullException(nameof(firstName), "Property is not nullable for class Adult.");

            if (lastName.IsSet && lastName.Value == null)
                throw new ArgumentNullException(nameof(lastName), "Property is not nullable for class Adult.");

            if (type.IsSet && type.Value == null)
                throw new ArgumentNullException(nameof(type), "Property is not nullable for class Adult.");

            return new Adult(children, firstName, lastName);
        }

        /// <summary>
        /// Serializes a <see cref="Adult" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="adult"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Adult adult, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, adult, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="Adult" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="adult"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, Adult adult, JsonSerializerOptions jsonSerializerOptions)
        {
            if (adult.ChildrenOption.IsSet && adult.Children == null)
                throw new ArgumentNullException(nameof(adult.Children), "Property is required for class Adult.");

            if (adult.FirstNameOption.IsSet && adult.FirstName == null)
                throw new ArgumentNullException(nameof(adult.FirstName), "Property is required for class Adult.");

            if (adult.LastNameOption.IsSet && adult.LastName == null)
                throw new ArgumentNullException(nameof(adult.LastName), "Property is required for class Adult.");

            if (adult.ChildrenOption.IsSet)
            {
                writer.WritePropertyName("children");
                JsonSerializer.Serialize(writer, adult.Children, jsonSerializerOptions);
            }
            if (adult.FirstNameOption.IsSet)
                writer.WriteString("firstName", adult.FirstName);

            if (adult.LastNameOption.IsSet)
                writer.WriteString("lastName", adult.LastName);

            writer.WriteString("$_type", adult.Type);
        }
    }
}
