using NUnit.Framework;
using Applikation;

namespace ApplikationTests {
	public class Tests {
		private Program program;
		[SetUp]
		public void Setup() {
			program = new Program();
		}

		[Test]
		public void borde_returnera_texten_Hello_World() {
			Assert.AreEqual("Hello World!", program.text());
		}
	}
}