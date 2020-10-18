using NUnit.Framework;
using System;
using Entitet;

namespace EntitetTests {
	public class Tests {
		private Text text;
		[SetUp]
		public void Setup() {
		}

		[Test]
		public void borde_göra_undantag_när_sträng_är_null() {
			Assert.Throws<ArgumentException>(() => new Text(null));
		}

		[Test]
		public void borde_göra_undantag_när_sträng_är_tom() {
			Assert.Throws<ArgumentException>(() => new Text(""));
		}

		[Test]
		public void borde_göra_undantag_när_sträng_är_enbart_mellanslag() {
			Assert.Throws<ArgumentException>(() => new Text("   "));
		}
	}
}