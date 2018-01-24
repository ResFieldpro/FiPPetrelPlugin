using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Slb.Ocean.Petrel.UI;

namespace FieldPROConnector
{
    public partial class ImportWellsControl : UserControl
    {
        private WellsCollection wellsCollection;

        public ImportWellsControl()
        {
            InitializeComponent();

            this.btnLoadWells.Image = PetrelImages.Well;
            this.btnImportWells.Image = PetrelImages.DownArrow;
        }

        private WellsCollection GetWellsCollection()
        {
            if (wellsCollection == null)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    Application.DoEvents();
                    wellsCollection = new WellsCollection();
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }
            return wellsCollection;
        }

        private void btnLoadWells_Click(object sender, EventArgs e)
        {
            this.ResetWellsCollection();
            var collection = this.GetWellsCollection();
            this.countryComboBox.DataSource = collection.SortedCountries();
            this.areaComboBox.DataSource = collection.SortedAreas();
            this.fieldComboBox.DataSource = collection.SortedFields();
            this.UpdateWellsListBox();
        }

        private void ResetWellsCollection()
        {
            wellsCollection = null;
        }

        private void UpdateWellsListBox()
        {
            var collection = this.GetWellsCollection();
            string country = (string)this.countryComboBox.SelectedItem;
            string area = (string)this.areaComboBox.SelectedItem;
            string field = (string)this.fieldComboBox.SelectedItem;
            this.wellsListBox.DataSource = collection.FilterWells(country, area, field);
        }

        private void UpdateAreaComboBox()
        {
            var collection = this.GetWellsCollection();
            string country = (string)this.countryComboBox.SelectedItem;
            this.areaComboBox.DataSource = collection.FilterAreas(country);
        }

        private void UpdateFieldComboBox()
        {
            var collection = this.GetWellsCollection();
            string area = (string)this.areaComboBox.SelectedItem;
            this.fieldComboBox.DataSource = collection.FilterFields(area);
        }

        private void countryComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            this.UpdateAreaComboBox();
        }

        private void areaComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            this.UpdateFieldComboBox();
        }

        private void fieldComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            this.UpdateWellsListBox();
        }

        private void selectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.wellsListBox.Items.Count; i++)
                this.wellsListBox.SetItemChecked(i, true);
        }

        private void unselectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.wellsListBox.Items.Count; i++)
                this.wellsListBox.SetItemChecked(i, false);
        }

        private void btnImportWells_Click(object sender, EventArgs e)
        {
            var selectedWells = new List<Well>();
            foreach (Well item in this.wellsListBox.CheckedItems)
            {
                selectedWells.Add(item);
            }
            var wellsImporter = new WellsImporter();
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                wellsImporter.Import(selectedWells, WebConfiguration.Current);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
    }
}
