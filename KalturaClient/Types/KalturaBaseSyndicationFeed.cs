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
// Copyright (C) 2006-2016  Kaltura Inc.
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
	public class KalturaBaseSyndicationFeed : KalturaObjectBase
	{
		#region Private Fields
		private string _Id = null;
		private string _FeedUrl = null;
		private int _PartnerId = Int32.MinValue;
		private string _PlaylistId = null;
		private string _Name = null;
		private KalturaSyndicationFeedStatus _Status = (KalturaSyndicationFeedStatus)Int32.MinValue;
		private KalturaSyndicationFeedType _Type = (KalturaSyndicationFeedType)Int32.MinValue;
		private string _LandingPage = null;
		private int _CreatedAt = Int32.MinValue;
		private bool? _AllowEmbed = null;
		private int _PlayerUiconfId = Int32.MinValue;
		private int _FlavorParamId = Int32.MinValue;
		private bool? _TranscodeExistingContent = null;
		private bool? _AddToDefaultConversionProfile = null;
		private string _Categories = null;
		private int _StorageId = Int32.MinValue;
		private KalturaSyndicationFeedEntriesOrderBy _EntriesOrderBy = null;
		private bool? _EnforceEntitlement = null;
		private string _PrivacyContext = null;
		private int _UpdatedAt = Int32.MinValue;
		private bool? _UseCategoryEntries = null;
		private string _FeedContentTypeHeader = null;
		#endregion

		#region Properties
		public string Id
		{
			get { return _Id; }
			set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		public string FeedUrl
		{
			get { return _FeedUrl; }
			set 
			{ 
				_FeedUrl = value;
				OnPropertyChanged("FeedUrl");
			}
		}
		public int PartnerId
		{
			get { return _PartnerId; }
			set 
			{ 
				_PartnerId = value;
				OnPropertyChanged("PartnerId");
			}
		}
		public string PlaylistId
		{
			get { return _PlaylistId; }
			set 
			{ 
				_PlaylistId = value;
				OnPropertyChanged("PlaylistId");
			}
		}
		public string Name
		{
			get { return _Name; }
			set 
			{ 
				_Name = value;
				OnPropertyChanged("Name");
			}
		}
		public KalturaSyndicationFeedStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		public KalturaSyndicationFeedType Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		public string LandingPage
		{
			get { return _LandingPage; }
			set 
			{ 
				_LandingPage = value;
				OnPropertyChanged("LandingPage");
			}
		}
		public int CreatedAt
		{
			get { return _CreatedAt; }
			set 
			{ 
				_CreatedAt = value;
				OnPropertyChanged("CreatedAt");
			}
		}
		public bool? AllowEmbed
		{
			get { return _AllowEmbed; }
			set 
			{ 
				_AllowEmbed = value;
				OnPropertyChanged("AllowEmbed");
			}
		}
		public int PlayerUiconfId
		{
			get { return _PlayerUiconfId; }
			set 
			{ 
				_PlayerUiconfId = value;
				OnPropertyChanged("PlayerUiconfId");
			}
		}
		public int FlavorParamId
		{
			get { return _FlavorParamId; }
			set 
			{ 
				_FlavorParamId = value;
				OnPropertyChanged("FlavorParamId");
			}
		}
		public bool? TranscodeExistingContent
		{
			get { return _TranscodeExistingContent; }
			set 
			{ 
				_TranscodeExistingContent = value;
				OnPropertyChanged("TranscodeExistingContent");
			}
		}
		public bool? AddToDefaultConversionProfile
		{
			get { return _AddToDefaultConversionProfile; }
			set 
			{ 
				_AddToDefaultConversionProfile = value;
				OnPropertyChanged("AddToDefaultConversionProfile");
			}
		}
		public string Categories
		{
			get { return _Categories; }
			set 
			{ 
				_Categories = value;
				OnPropertyChanged("Categories");
			}
		}
		public int StorageId
		{
			get { return _StorageId; }
			set 
			{ 
				_StorageId = value;
				OnPropertyChanged("StorageId");
			}
		}
		public KalturaSyndicationFeedEntriesOrderBy EntriesOrderBy
		{
			get { return _EntriesOrderBy; }
			set 
			{ 
				_EntriesOrderBy = value;
				OnPropertyChanged("EntriesOrderBy");
			}
		}
		public bool? EnforceEntitlement
		{
			get { return _EnforceEntitlement; }
			set 
			{ 
				_EnforceEntitlement = value;
				OnPropertyChanged("EnforceEntitlement");
			}
		}
		public string PrivacyContext
		{
			get { return _PrivacyContext; }
			set 
			{ 
				_PrivacyContext = value;
				OnPropertyChanged("PrivacyContext");
			}
		}
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
			set 
			{ 
				_UpdatedAt = value;
				OnPropertyChanged("UpdatedAt");
			}
		}
		public bool? UseCategoryEntries
		{
			get { return _UseCategoryEntries; }
			set 
			{ 
				_UseCategoryEntries = value;
				OnPropertyChanged("UseCategoryEntries");
			}
		}
		public string FeedContentTypeHeader
		{
			get { return _FeedContentTypeHeader; }
			set 
			{ 
				_FeedContentTypeHeader = value;
				OnPropertyChanged("FeedContentTypeHeader");
			}
		}
		#endregion

		#region CTor
		public KalturaBaseSyndicationFeed()
		{
		}

		public KalturaBaseSyndicationFeed(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this.Id = txt;
						continue;
					case "feedUrl":
						this.FeedUrl = txt;
						continue;
					case "partnerId":
						this.PartnerId = ParseInt(txt);
						continue;
					case "playlistId":
						this.PlaylistId = txt;
						continue;
					case "name":
						this.Name = txt;
						continue;
					case "status":
						this.Status = (KalturaSyndicationFeedStatus)ParseEnum(typeof(KalturaSyndicationFeedStatus), txt);
						continue;
					case "type":
						this.Type = (KalturaSyndicationFeedType)ParseEnum(typeof(KalturaSyndicationFeedType), txt);
						continue;
					case "landingPage":
						this.LandingPage = txt;
						continue;
					case "createdAt":
						this.CreatedAt = ParseInt(txt);
						continue;
					case "allowEmbed":
						this.AllowEmbed = ParseBool(txt);
						continue;
					case "playerUiconfId":
						this.PlayerUiconfId = ParseInt(txt);
						continue;
					case "flavorParamId":
						this.FlavorParamId = ParseInt(txt);
						continue;
					case "transcodeExistingContent":
						this.TranscodeExistingContent = ParseBool(txt);
						continue;
					case "addToDefaultConversionProfile":
						this.AddToDefaultConversionProfile = ParseBool(txt);
						continue;
					case "categories":
						this.Categories = txt;
						continue;
					case "storageId":
						this.StorageId = ParseInt(txt);
						continue;
					case "entriesOrderBy":
						this.EntriesOrderBy = (KalturaSyndicationFeedEntriesOrderBy)KalturaStringEnum.Parse(typeof(KalturaSyndicationFeedEntriesOrderBy), txt);
						continue;
					case "enforceEntitlement":
						this.EnforceEntitlement = ParseBool(txt);
						continue;
					case "privacyContext":
						this.PrivacyContext = txt;
						continue;
					case "updatedAt":
						this.UpdatedAt = ParseInt(txt);
						continue;
					case "useCategoryEntries":
						this.UseCategoryEntries = ParseBool(txt);
						continue;
					case "feedContentTypeHeader":
						this.FeedContentTypeHeader = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaBaseSyndicationFeed");
			kparams.AddIfNotNull("id", this.Id);
			kparams.AddIfNotNull("feedUrl", this.FeedUrl);
			kparams.AddIfNotNull("partnerId", this.PartnerId);
			kparams.AddIfNotNull("playlistId", this.PlaylistId);
			kparams.AddIfNotNull("name", this.Name);
			kparams.AddIfNotNull("status", this.Status);
			kparams.AddIfNotNull("type", this.Type);
			kparams.AddIfNotNull("landingPage", this.LandingPage);
			kparams.AddIfNotNull("createdAt", this.CreatedAt);
			kparams.AddIfNotNull("allowEmbed", this.AllowEmbed);
			kparams.AddIfNotNull("playerUiconfId", this.PlayerUiconfId);
			kparams.AddIfNotNull("flavorParamId", this.FlavorParamId);
			kparams.AddIfNotNull("transcodeExistingContent", this.TranscodeExistingContent);
			kparams.AddIfNotNull("addToDefaultConversionProfile", this.AddToDefaultConversionProfile);
			kparams.AddIfNotNull("categories", this.Categories);
			kparams.AddIfNotNull("storageId", this.StorageId);
			kparams.AddIfNotNull("entriesOrderBy", this.EntriesOrderBy);
			kparams.AddIfNotNull("enforceEntitlement", this.EnforceEntitlement);
			kparams.AddIfNotNull("privacyContext", this.PrivacyContext);
			kparams.AddIfNotNull("updatedAt", this.UpdatedAt);
			kparams.AddIfNotNull("useCategoryEntries", this.UseCategoryEntries);
			kparams.AddIfNotNull("feedContentTypeHeader", this.FeedContentTypeHeader);
			return kparams;
		}
		#endregion
	}
}

