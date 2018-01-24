using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Slb.Ocean.Petrel.Data.Persistence;
using Slb.Ocean.Petrel.Data;
using Slb.Ocean.Core;
using System.Data.Odbc;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Text.RegularExpressions;
using System.Security.Principal;
using System.Web.Services.Description;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Net;
using WebDataLoader;

namespace FieldPROConnector
{
	class WebConfiguration
	{
		private static WebConfiguration current;
		public static readonly string DBConfigurationKey = @"Software\RESNET\FieldPROConnector";
		public static readonly string WebServerKey = "WebServer";
		public static readonly string WebServerUKey = "WebServerU";
		public static readonly string WebServerPKey = "WebServerP";
		public string WebServer { get; set; }
		public string WebServerU { get; set; }
		public string WebServerP { get; set; }
		public static string Base64Encode(string plainText)
		{
			var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
			return System.Convert.ToBase64String(plainTextBytes);
		}
		public static string Base64Decode(string base64EncodedData)
		{
			try
			{
				var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
				return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
			}
			catch (Exception)
			{
				return "";
			}

		}
		private WebConfiguration() { }
		public static WebConfiguration Current
		{
			get
			{
				if (current == null)
				{
					current = ReadFromRegistry();
				}
				return current;
			}
		}
		private static WebConfiguration ReadFromRegistry()
		{
			var dcInfo = new WebConfiguration();
			var root = Registry.CurrentUser.CreateSubKey(DBConfigurationKey);
			dcInfo.WebServer = (string)root.GetValue(WebServerKey, "");

			if (!string.IsNullOrEmpty(dcInfo.WebServer) && dcInfo.WebServer.Substring(dcInfo.WebServer.Length - 1) != "/")
				dcInfo.WebServer += "/";

			dcInfo.WebServerU = (string)root.GetValue(WebServerUKey, "");
			dcInfo.WebServerP = Base64Decode((string)root.GetValue(WebServerPKey, ""));
			return dcInfo;
		}
		public bool TestConnection(bool notify)
		{
			Cursor.Current = Cursors.WaitCursor;
			WebImporter wi = new WebImporter();
			bool bok = wi.TestWebServer(this.WebServer);
			if (notify)
			{
				if (!bok)
				{
					MessageBox.Show("Cannot connect to the server!");
				}
				else
				{
					MessageBox.Show("Connection Successful!");
				}
			}
			return bok;
		}
		public void WriteToRegistry()
		{
			var root = Registry.CurrentUser.CreateSubKey(DBConfigurationKey);
			root.SetValue(WebServerKey, WebServer);
			root.SetValue(WebServerUKey, WebServerU);
			root.SetValue(WebServerPKey, Base64Encode(WebServerP));
		}
	}
}