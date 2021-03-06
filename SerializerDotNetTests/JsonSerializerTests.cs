using SerializerDotNet;
using System.Text;
using Xunit;

namespace SerializerDotNetTests
{
	public class JsonSerializerTests
	{
		[Fact]
		public void Serialize_Poco_NotNull()
		{
			var serializer = new JsonSerializer();
			var poco = new Poco();

			var data = serializer.Serialize(poco);

			Assert.NotNull(data);
		}

		[Fact]
		public void Deserialize_Poco_NotNull()
		{
			var serializer = new JsonSerializer();
			var data = Encoding.UTF8.GetBytes("{\"Id\":2147483647,\"Name\":\"This is POCO\"}");

			var poco = serializer.Deserialize<Poco>(data);

			Assert.NotNull(poco);
		}
	}
}
