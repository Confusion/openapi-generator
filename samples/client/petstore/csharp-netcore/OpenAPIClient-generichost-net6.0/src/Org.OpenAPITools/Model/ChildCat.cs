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

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// ChildCat
    /// </summary>
    public partial class ChildCat : ParentPet, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChildCat" /> class.
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="petType">petType (default to PetTypeEnum.ChildCat)</param>
        [JsonConstructor]
        public ChildCat(string name, PetTypeEnum petType = PetTypeEnum.ChildCat) : base(ChildCat.PetTypeEnumToJsonValue(petType))
        {
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning disable CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            if (name == null)
                throw new ArgumentNullException("name is a required property for ChildCat and cannot be null.");

            if (petType == null)
                throw new ArgumentNullException("petType is a required property for ChildCat and cannot be null.");

#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning restore CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            Name = name;
        }

        /// <summary>
        /// Defines PetType
        /// </summary>
        public enum PetTypeEnum
        {
            /// <summary>
            /// Enum ChildCat for value: ChildCat
            /// </summary>
            ChildCat = 1

        }

        /// <summary>
        /// Returns a PetTypeEnum
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static PetTypeEnum PetTypeEnumFromString(string value)
        {
            if (value == "ChildCat")
                return PetTypeEnum.ChildCat;

            throw new NotImplementedException($"Could not convert value to type PetTypeEnum: '{value}'");
        }

        /// <summary>
        /// Returns equivalent json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string PetTypeEnumToJsonValue(PetTypeEnum value)
        {
            if (value == PetTypeEnum.ChildCat)
                return "ChildCat";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Gets or Sets PetType
        /// </summary>
        [JsonPropertyName("pet_type")]
        public new PetTypeEnum PetType { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ChildCat {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PetType: ").Append(PetType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

    /// <summary>
    /// A Json converter for type ChildCat
    /// </summary>
    public class ChildCatJsonConverter : JsonConverter<ChildCat>
    {
        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ChildCat Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Utf8JsonReader childCatAllOfReader = utf8JsonReader;
            bool childCatAllOfDeserialized = Client.ClientUtils.TryDeserialize<ChildCatAllOf>(ref utf8JsonReader, jsonSerializerOptions, out ChildCatAllOf childCatAllOf);

            string name = default;
            ChildCat.PetTypeEnum petType = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string propertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (propertyName)
                    {
                        case "name":
                            name = utf8JsonReader.GetString();
                            break;
                        case "pet_type":
                            string petTypeRawValue = utf8JsonReader.GetString();
                            petType = ChildCat.PetTypeEnumFromString(petTypeRawValue);
                            break;
                        default:
                            break;
                    }
                }
            }

            return new ChildCat(name, petType);
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="childCat"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ChildCat childCat, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            writer.WriteString("name", childCat.Name);
            var petTypeRawValue = ChildCat.PetTypeEnumToJsonValue(childCat.PetType);
            if (petTypeRawValue != null)
                writer.WriteString("pet_type", petTypeRawValue);
            else
                writer.WriteNull("pet_type");

            writer.WriteEndObject();
        }
    }

}
