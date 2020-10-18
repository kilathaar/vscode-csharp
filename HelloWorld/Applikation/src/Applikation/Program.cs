using System;
using Entitet;

namespace Applikation {
	public class Program {
		static void Main(string[] args) {
			Console.WriteLine(new Program().text());
		}

		public string text() {
			return new Text("Hello World!").ToString();
		}
	}
}
