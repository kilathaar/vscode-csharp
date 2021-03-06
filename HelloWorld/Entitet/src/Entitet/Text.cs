﻿using System;

namespace Entitet {
	public class Text {
		private readonly string text;

		public Text(string text) {
			if (String.IsNullOrEmpty(text) || String.IsNullOrWhiteSpace(text)) {
				throw new ArgumentException("Text måste finnas och får inte vara tom eller enbart mellanslag");
			}
			this.text = text;
		}

		public override string ToString() {
			return text;
		}
	}
}