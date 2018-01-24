using System;
using System.Windows.Forms;
using Slb.Ocean.Petrel;
using Slb.Ocean.Petrel.UI;
using Slb.Ocean.Petrel.UI.Tools;

namespace FieldPROConnector
{
    /// <summary>
    /// This class contains registration methods and Click eventhandlers for the
    /// Petrel Menu extension.
    /// </summary>
    public static class FieldPROMenu
    {
        public static void AddNewMenuItemsUnderTools()
        {
            PetrelMenuItem FieldPROConnector1 = new PetrelMenuItem("FIELDPRO Connector", Resource1.fieldpro.ToBitmap());
            PetrelButtonTool ChangeDatabaseConnection1 = new PetrelButtonTool("eFieldpro connection...", FieldPROMenu.ChangeDatabaseConnection1_ToolClick);
            FieldPROConnector1.AddTool(ChangeDatabaseConnection1);

				PetrelButtonTool ImportFromFieldPRO1 = new PetrelButtonTool("FIELDPRO Import/Export ...", FieldPROMenu.ImportFromFieldPRO1_ToolClick);
            FieldPROConnector1.AddTool(ImportFromFieldPRO1);

            Slb.Ocean.Petrel.UI.Tools.WellKnownMenus.Tools.AddTool(FieldPROConnector1);
        }

        #region Toolbutton click eventhandlers

        private static void ChangeDatabaseConnection1_ToolClick(object sender, EventArgs args)
        {
            var w = new DBConfigurationDialogUI();
            PetrelSystem.ShowModeless(w);
        }

        private static void ImportFromFieldPRO1_ToolClick(object sender, EventArgs args)
        {
            var w = new FieldPROConnectorDialog();
            PetrelSystem.ShowModeless(w);
        }

        #endregion

    }

}