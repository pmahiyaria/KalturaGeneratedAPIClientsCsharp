// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platfroms allow them to do with
// text.
//
// Copyright (C) 2006-2015  Kaltura Inc.
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
//
// You should have received a copy of the GNU Affero General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.
//
// @ignore
// ===================================================================================================
using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaTranscriptAsset : KalturaAttachmentAsset
	{
		#region Private Fields
		private float _Accuracy = Single.MinValue;
		private KalturaNullableBoolean _HumanVerified = (KalturaNullableBoolean)Int32.MinValue;
		private KalturaLanguage _Language = null;
		#endregion

		#region Properties
		public float Accuracy
		{
			get { return _Accuracy; }
			set 
			{ 
				_Accuracy = value;
				OnPropertyChanged("Accuracy");
			}
		}
		public KalturaNullableBoolean HumanVerified
		{
			get { return _HumanVerified; }
			set 
			{ 
				_HumanVerified = value;
				OnPropertyChanged("HumanVerified");
			}
		}
		public KalturaLanguage Language
		{
			get { return _Language; }
			set 
			{ 
				_Language = value;
				OnPropertyChanged("Language");
			}
		}
		#endregion

		#region CTor
		public KalturaTranscriptAsset()
		{
		}

		public KalturaTranscriptAsset(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "accuracy":
						this.Accuracy = ParseFloat(txt);
						continue;
					case "humanVerified":
						this.HumanVerified = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
						continue;
					case "language":
						this.Language = (KalturaLanguage)KalturaStringEnum.Parse(typeof(KalturaLanguage), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaTranscriptAsset");
			kparams.AddIfNotNull("accuracy", this.Accuracy);
			kparams.AddIfNotNull("humanVerified", this.HumanVerified);
			kparams.AddIfNotNull("language", this.Language);
			return kparams;
		}
		#endregion
	}
}

