using System;

namespace Entitet {
	public class Text {
		public Text(string text) {
			if (String.IsNullOrEmpty(text)) {
				throw new ArgumentException("Text måste finnas");
			}
		}
	}
}
