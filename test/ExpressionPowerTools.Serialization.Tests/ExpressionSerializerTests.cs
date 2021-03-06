﻿using System.Linq.Expressions;
using System.Text.Json;
using ExpressionPowerTools.Serialization.Serializers;
using ExpressionPowerTools.Serialization.Tests.TestHelpers;
using Xunit;

namespace ExpressionPowerTools.Serialization.Tests
{
    public class ExpressionSerializerTests
    {
        private readonly ExpressionSerializer target = new ExpressionSerializer();

        [Fact]
        public void GivenExpressionHasSerializerWhenSerializeCalledThenShouldSerialize()
        {
            var serialized = target.Serialize(Expression.Constant(5), new SerializationState());
            Assert.NotNull(serialized);
            Assert.Equal(ExpressionType.Constant, (ExpressionType)serialized.Type);
        }

        [Fact]
        public void GivenExpressionHasSerializerWhenDeserializeCalledThenShouldDeserialize()
        {
            var json = TestSerializer.GetSerializedFragment<Constant, ConstantExpression>
                (Expression.Constant(5));
            var deserialized = target.Deserialize(json, new SerializationState());
            Assert.IsType<ConstantExpression>(deserialized);
            Assert.Equal(5, ((ConstantExpression)deserialized).Value);
        }

        [Fact]
        public void GivenExpressionHasNoSerializerWhenSerializeCalledThenShouldReturnSerializableExpression()
        {
            var serialized = target.Serialize(Expression.Goto(Expression.Label()), null);
            Assert.IsType<SerializableExpression>(serialized);
            Assert.Equal(ExpressionType.Goto, (ExpressionType)serialized.Type);
        }

        [Fact]
        public void GivenExpressionHasNoSerializerWhenDeserializeCalledThenShouldReturnNull()
        {
            var gotoNum = (int)ExpressionType.Goto;
            var json = JsonDocument.Parse($"{{\"ConstantType\":\"System.Int32\",\"Value\":5,\"Type\": {gotoNum}}}");
            var deserialized = target.Deserialize(json.RootElement, new SerializationState());
            Assert.Null(deserialized);
        }

        [Fact]
        public void GivenExpressionHasNoTypeWhenDeserializeCalledThenShouldReturnNull()
        {
            var json = JsonDocument.Parse("{\"ConstantType\":\"System.Int32\",\"Value\":5 }");
            var deserialized = target.Deserialize(json.RootElement, new SerializationState());
            Assert.Null(deserialized);
        }

        [Fact]
        public void GivenExpressionHasNullTypeWhenDeserializeCalledThenShouldReturnNull()
        {
            var json = JsonDocument.Parse("{\"ConstantType\":\"System.Int32\",\"Value\":5,\"Type\": null }");
            var deserialized = target.Deserialize(json.RootElement, new SerializationState());
            Assert.Null(deserialized);
        }
    }
}
