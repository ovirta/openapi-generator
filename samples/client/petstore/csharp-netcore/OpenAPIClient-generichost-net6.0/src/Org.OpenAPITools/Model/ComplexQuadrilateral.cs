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
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// ComplexQuadrilateral
    /// </summary>
    public partial class ComplexQuadrilateral : IEquatable<ComplexQuadrilateral>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComplexQuadrilateral" /> class.
        /// </summary>
        /// <param name="quadrilateralInterface">quadrilateralInterface</param>
        /// <param name="shapeInterface">shapeInterface</param>
        public ComplexQuadrilateral(QuadrilateralInterface quadrilateralInterface, ShapeInterface shapeInterface)
        {
            QuadrilateralInterface = quadrilateralInterface;
            ShapeInterface = shapeInterface;
        }

        /// <summary>
        /// Gets or Sets ComplexQuadrilateral
        /// </summary>
        public QuadrilateralInterface QuadrilateralInterface { get; set; }

        /// <summary>
        /// Gets or Sets ComplexQuadrilateral
        /// </summary>
        public ShapeInterface ShapeInterface { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, JsonElement> AdditionalProperties { get; set; } = new Dictionary<string, JsonElement>();

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ComplexQuadrilateral {\n");
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
            return OpenAPIClientUtils.compareLogic.Compare(this, input as ComplexQuadrilateral).AreEqual;
        }

        /// <summary>
        /// Returns true if ComplexQuadrilateral instances are equal
        /// </summary>
        /// <param name="input">Instance of ComplexQuadrilateral to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ComplexQuadrilateral input)
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
                if (this.AdditionalProperties != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalProperties.GetHashCode();
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

    /// <summary>
    /// A Json converter for type ComplexQuadrilateral
    /// </summary>
    public class ComplexQuadrilateralJsonConverter : JsonConverter<ComplexQuadrilateral>
    {
        /// <summary>
        /// Returns a boolean if the type is compatible with this converter.
        /// </summary>
        /// <param name="typeToConvert"></param>
        /// <returns></returns>
        public override bool CanConvert(Type typeToConvert) => typeof(ComplexQuadrilateral).IsAssignableFrom(typeToConvert);

        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ComplexQuadrilateral Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            int currentDepth = reader.CurrentDepth;

            if (reader.TokenType != JsonTokenType.StartObject)
                throw new JsonException();

            Utf8JsonReader quadrilateralInterfaceReader = reader;
            Client.ClientUtils.TryDeserialize<QuadrilateralInterface>(ref quadrilateralInterfaceReader, options, out QuadrilateralInterface quadrilateralInterface);
            Utf8JsonReader shapeInterfaceReader = reader;
            Client.ClientUtils.TryDeserialize<ShapeInterface>(ref shapeInterfaceReader, options, out ShapeInterface shapeInterface);

            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndObject && currentDepth == reader.CurrentDepth)
                    break;

                if (reader.TokenType == JsonTokenType.PropertyName)
                {
                    string propertyName = reader.GetString();
                    reader.Read();

                    switch (propertyName)
                    {
                    }
                }
            }

            return new ComplexQuadrilateral(quadrilateralInterface, shapeInterface);
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="complexQuadrilateral"></param>
        /// <param name="options"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ComplexQuadrilateral complexQuadrilateral, JsonSerializerOptions options) => throw new NotImplementedException();
    }
}
