using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using WebDataLoader;
using System.Data;

namespace FieldPROConnector {
	class WebImporterWrapper: WebImporter
	{
		string WebServer;
		string WebServerU;
		string WebServerP;
		public WebImporterWrapper(string WebServer, string WebServerU, string WebServerP)
		{
			this.WebServer = WebServer;
			this.WebServerU = WebServerU;
			this.WebServerP = WebServerP;
		}
		public WebImporterWrapper(WebConfiguration cfg)
		{
			this.WebServer = cfg.WebServer;
			this.WebServerU = cfg.WebServerU;
			this.WebServerP = cfg.WebServerP;
		}
		public bool TestWebServer()
		{
			return base.TestWebServer(WebServer);
		}
		public DataTable LoadWells()
		{
			return base.LoadWells(WebServer, WebServerU, WebServerP);
		}
		public int UploadWells(string datafile, string migfile)
		{
			return base.UploadData(WebServer, WebServerU, WebServerP, datafile, migfile);
		}
	}
}
