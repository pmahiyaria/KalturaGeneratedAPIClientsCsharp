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
// Copyright (C) 2006-2020  Kaltura Inc.
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
using Kaltura.Enums;
using Kaltura.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Kaltura.Types
{
	public class SearchComparableCondition : SearchCondition
	{
		#region Constants
		public const string COMPARISON = "comparison";
		#endregion

		#region Private Fields
		private SearchConditionComparison _Comparison = null;
		#endregion

		#region Properties
		[JsonProperty]
		public SearchConditionComparison Comparison
		{
			get { return _Comparison; }
			set 
			{ 
				_Comparison = value;
				OnPropertyChanged("Comparison");
			}
		}
		#endregion

		#region CTor
		public SearchComparableCondition()
		{
		}

		public SearchComparableCondition(JToken node) : base(node)
		{
			if(node["comparison"] != null)
			{
				this._Comparison = (SearchConditionComparison)StringEnum.Parse(typeof(SearchConditionComparison), node["comparison"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaSearchComparableCondition");
			kparams.AddIfNotNull("comparison", this._Comparison);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case COMPARISON:
					return "Comparison";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

