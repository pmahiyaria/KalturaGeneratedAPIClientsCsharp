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
using Kaltura.Enums;
using Kaltura.Request;

namespace Kaltura.Types
{
	public class CEError : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string PARTNER_ID = "partnerId";
		public const string BROWSER = "browser";
		public const string SERVER_IP = "serverIp";
		public const string SERVER_OS = "serverOs";
		public const string PHP_VERSION = "phpVersion";
		public const string CE_ADMIN_EMAIL = "ceAdminEmail";
		public const string TYPE = "type";
		public const string DESCRIPTION = "description";
		public const string DATA = "data";
		#endregion

		#region Private Fields
		private string _Id = null;
		private int _PartnerId = Int32.MinValue;
		private string _Browser = null;
		private string _ServerIp = null;
		private string _ServerOs = null;
		private string _PhpVersion = null;
		private string _CeAdminEmail = null;
		private string _Type = null;
		private string _Description = null;
		private string _Data = null;
		#endregion

		#region Properties
		public string Id
		{
			get { return _Id; }
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
		public string Browser
		{
			get { return _Browser; }
			set 
			{ 
				_Browser = value;
				OnPropertyChanged("Browser");
			}
		}
		public string ServerIp
		{
			get { return _ServerIp; }
			set 
			{ 
				_ServerIp = value;
				OnPropertyChanged("ServerIp");
			}
		}
		public string ServerOs
		{
			get { return _ServerOs; }
			set 
			{ 
				_ServerOs = value;
				OnPropertyChanged("ServerOs");
			}
		}
		public string PhpVersion
		{
			get { return _PhpVersion; }
			set 
			{ 
				_PhpVersion = value;
				OnPropertyChanged("PhpVersion");
			}
		}
		public string CeAdminEmail
		{
			get { return _CeAdminEmail; }
			set 
			{ 
				_CeAdminEmail = value;
				OnPropertyChanged("CeAdminEmail");
			}
		}
		public string Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		public string Description
		{
			get { return _Description; }
			set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
			}
		}
		public string Data
		{
			get { return _Data; }
			set 
			{ 
				_Data = value;
				OnPropertyChanged("Data");
			}
		}
		#endregion

		#region CTor
		public CEError()
		{
		}

		public CEError(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = propertyNode.InnerText;
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(propertyNode.InnerText);
						continue;
					case "browser":
						this._Browser = propertyNode.InnerText;
						continue;
					case "serverIp":
						this._ServerIp = propertyNode.InnerText;
						continue;
					case "serverOs":
						this._ServerOs = propertyNode.InnerText;
						continue;
					case "phpVersion":
						this._PhpVersion = propertyNode.InnerText;
						continue;
					case "ceAdminEmail":
						this._CeAdminEmail = propertyNode.InnerText;
						continue;
					case "type":
						this._Type = propertyNode.InnerText;
						continue;
					case "description":
						this._Description = propertyNode.InnerText;
						continue;
					case "data":
						this._Data = propertyNode.InnerText;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaCEError");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("browser", this._Browser);
			kparams.AddIfNotNull("serverIp", this._ServerIp);
			kparams.AddIfNotNull("serverOs", this._ServerOs);
			kparams.AddIfNotNull("phpVersion", this._PhpVersion);
			kparams.AddIfNotNull("ceAdminEmail", this._CeAdminEmail);
			kparams.AddIfNotNull("type", this._Type);
			kparams.AddIfNotNull("description", this._Description);
			kparams.AddIfNotNull("data", this._Data);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case PARTNER_ID:
					return "PartnerId";
				case BROWSER:
					return "Browser";
				case SERVER_IP:
					return "ServerIp";
				case SERVER_OS:
					return "ServerOs";
				case PHP_VERSION:
					return "PhpVersion";
				case CE_ADMIN_EMAIL:
					return "CeAdminEmail";
				case TYPE:
					return "Type";
				case DESCRIPTION:
					return "Description";
				case DATA:
					return "Data";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

