﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Collections;

namespace VcardLib {
	using fastJSON;

	public class Vcard {
		private string _filename;
		private Dictionary<string, bool> fields;

		public Vcard(String filename) {
			this.filename = filename;
		}

		private Thought.vCards.vCard card { get; set; }

		public string filename {
			get {
				return _filename;
			}
			set {
				_filename = value;
				card = new Thought.vCards.vCard(value);

				//We take note of which
			}
		}

		public String info {
			get {
				return String.Format("{0} {1}", card.GivenName, card.FamilyName).Trim();
			}
		}

		public string toJson() {
			JSONParameters p = new JSONParameters();
			p.UseExtensions = false;
			return JSON.Instance.ToJSON(card, p);
		}
	}
}
