using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FieldPROConnector
{
    class WellsCollection
    {
        const string ALL = "<All>";

        public List<Well> Wells { get; set; }
        public HashSet<string> Countries { get; set; }
        public HashSet<string> Fields { get; set; }
        public HashSet<string> Areas { get; set; }

        public WellsCollection()
        {
            Wells = Well.Broker.GetAll();
            Countries = new HashSet<string>();
            Fields = new HashSet<string>();
            Areas = new HashSet<string>();

            foreach (Well w in Wells)
            {
                Countries.Add(w.Country);
                Fields.Add(w.Field);
                Areas.Add(w.Area);
            }
        }

        private List<string> SortedItems(HashSet<string> items)
        {
            var sortedItems = items.OrderBy(x => x.ToString()).ToList();
            sortedItems.Insert(0, ALL);
            return sortedItems;
        }

        public List<string> SortedAreas()
        {
            return SortedItems(Areas);
        }

        public List<string> SortedFields()
        {
            return SortedItems(Fields);
        }

        public List<string> SortedCountries()
        {
            return SortedItems(Countries);
        }

        public List<Well> FilterWells(string country, string area, string field)
        {
            return Wells.Where(x => ((area == ALL) || (area == x.Area)) && ((field == ALL) || (field == x.Field)) && ((country == ALL) || (country == x.Country))).ToList();
        }

        public List<string> FilterAreas(string country)
        {
            string[] areas = Wells.Where(x => (country == ALL) || (country == x.Country)).Select(x => x.Area).Distinct().ToArray();
            return SortedItems(new HashSet<string>(areas));
        }

        public List<string> FilterFields(string area)
        {
            string[] fields = Wells.Where(x => (area == ALL) || (area == x.Area)).Select(x => x.Field).Distinct().ToArray();
            return SortedItems(new HashSet<string>(fields));
        }
    }
}    

