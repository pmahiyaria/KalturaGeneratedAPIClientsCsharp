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
	public class ReportExportJobData : JobData
	{
		#region Constants
		public const string RECIPIENT_EMAIL = "recipientEmail";
		public const string REPORT_ITEMS = "reportItems";
		public const string FILE_PATHS = "filePaths";
		#endregion

		#region Private Fields
		private string _RecipientEmail = null;
		private IList<ReportExportItem> _ReportItems;
		private string _FilePaths = null;
		#endregion

		#region Properties
		[JsonProperty]
		public string RecipientEmail
		{
			get { return _RecipientEmail; }
			set 
			{ 
				_RecipientEmail = value;
				OnPropertyChanged("RecipientEmail");
			}
		}
		[JsonProperty]
		public IList<ReportExportItem> ReportItems
		{
			get { return _ReportItems; }
			set 
			{ 
				_ReportItems = value;
				OnPropertyChanged("ReportItems");
			}
		}
		[JsonProperty]
		public string FilePaths
		{
			get { return _FilePaths; }
			set 
			{ 
				_FilePaths = value;
				OnPropertyChanged("FilePaths");
			}
		}
		#endregion

		#region CTor
		public ReportExportJobData()
		{
		}

		public ReportExportJobData(JToken node) : base(node)
		{
			if(node["recipientEmail"] != null)
			{
				this._RecipientEmail = node["recipientEmail"].Value<string>();
			}
			if(node["reportItems"] != null)
			{
				this._ReportItems = new List<ReportExportItem>();
				foreach(var arrayNode in node["reportItems"].Children())
				{
					this._ReportItems.Add(ObjectFactory.Create<ReportExportItem>(arrayNode));
				}
			}
			if(node["filePaths"] != null)
			{
				this._FilePaths = node["filePaths"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaReportExportJobData");
			kparams.AddIfNotNull("recipientEmail", this._RecipientEmail);
			kparams.AddIfNotNull("reportItems", this._ReportItems);
			kparams.AddIfNotNull("filePaths", this._FilePaths);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case RECIPIENT_EMAIL:
					return "RecipientEmail";
				case REPORT_ITEMS:
					return "ReportItems";
				case FILE_PATHS:
					return "FilePaths";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

