using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using WebDataLoader;
using System.Data;
using System.IO;

namespace FieldPROConnector
{
    class WebImporterWrapper : WebImporter
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
        //helpers:
        public bool TestWebServer()
        {
            return base.TestWebServer(WebServer);
        }
        //loaders:
        public DataTable LoadWells()
        {
            return base.LoadWells(WebServer, WebServerU, WebServerP);
        }
        public DataTable LoadMonthlyProduction(string uwi)
        {
            return base.LoadMonthlyProduction(WebServer, WebServerU, WebServerP, uwi);
        }
        public DataTable LoadDailyProduction(string uwi)
        {
            return base.LoadDailyProduction(WebServer, WebServerU, WebServerP, uwi);
        }
        //uploaders:
        public static string AssemblyDirectory
        {
            get
            {
                string codeBase = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
                UriBuilder uri = new UriBuilder(codeBase);
                string path = Uri.UnescapeDataString(uri.Path);
                return Path.GetDirectoryName(path);
            }
        }
        public int UploadWells(string datafile)
        {
            string migfile = AssemblyDirectory + "\\Petrelwells.mig";
            return base.UploadData(WebServer, WebServerU, WebServerP, datafile, migfile);
        }
        public int UploadTraj(string datafile)
        {
            string migfile = AssemblyDirectory + "\\Petreltraj.mig";
            return base.UploadData(WebServer, WebServerU, WebServerP, datafile, migfile);
        }
    }
}