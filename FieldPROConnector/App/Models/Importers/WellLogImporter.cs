using Slb.Ocean.Petrel;
using Slb.Ocean.Petrel.DomainObject.Well;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace FieldPROConnector
{
    class WellLogImporter
    {
        private string[] importedFiles = new string[0];

        public List<WellLogFile> GetWellLogFiles(BoreholeCollection wells)
        {
            var files = new List<WellLogFile>();
            BoreholePropertyCollection bhPropertyColl = wells.BoreholePropertyCollection;
            DictionaryBoreholeProperty dicProperty = DictionaryBoreholeProperty.NullObject;
            dicProperty = WellsImporter.FindDictionaryProperty(bhPropertyColl, "FIELDPRO ID");

            foreach (Borehole well in wells)
            {
                string id = well.PropertyAccess.GetPropertyValue<string>(dicProperty);
                if (!String.IsNullOrEmpty(id.Trim()))
                {
                    files.AddRange(WellLogFile.Broker.GetAllOfWell(id.Trim()));
                }
            }
            return files;
        }
        public void ImportFile(string f, bool skipImported)
        {
            if (skipImported && importedFiles.Contains(f)) { return; }
            string[] lastImportedFiles;
            object[] importedObjects;
            WellRoot wellRoot = WellRoot.Get(PetrelProject.PrimaryProject);
            PetrelSystem.FileFormats.ShowImportDialog(
                PetrelSystem.FileFormats.WellKnownFileFormats.WellLog,
                Path.GetDirectoryName(f),
                wellRoot.BoreholeCollection,
                out lastImportedFiles,
                out importedObjects);
            importedFiles = importedFiles.Concat(lastImportedFiles).ToArray();
            foreach (var path in importedFiles)
            {
                PetrelLogger.InfoOutputWindow("Imported File: " + path);
            }
        }
    }
}