using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using System.Windows.Forms;

namespace FieldPROConnector
{
	class Well
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public string Country { get; set; }
		public string Field { get; set; }
		public string Area { get; set; }
		public string Uwi { get; set; }
		public double Tmd { get; set; }
		public double Tvd { get; set; }
		public double Latitude { get { return Y; } }
		public double Longitude { get { return X; } }
		public double X { get; set; }
		public double Y { get; set; }
		public double Z { get; set; }

		public override string ToString()
		{
			return this.Name;
		}

		public static WellBroker Broker
		{
			get
			{
				return new WellBroker(WebConfiguration.Current);
			}
		}
		public static string TxtHeader
		{
			get
			{
				return "NAME\tCOUNTRY\tFIELD\tAREA\tUWI\tDEPTHTMD\tDEPTHTVD\tX\tY\tZ";
			}
		}
		public string Serialize()
		{
			return Name + "\t" + Country + "\t" + Field + "\t" + Area + "\t" + Uwi + "\t" + Tmd + "\t" + Tvd + "\t" + X + "\t" + Y + "\t" + Z;
		}
		public Dictionary<String, double> CartesianCoordinates()
		{
			var a = 6378137; //WGS84 radius in meters
			var f = 1 / 298.257224; // flattening parameter
			var coordinates = new Dictionary<String, double>();
			var lat = DegToRad(this.X);
			var lon = DegToRad(this.Y);
			var h = this.Z;

			var C = 1 / Math.Sqrt(Math.Pow(Math.Cos(lat), 2) + Math.Pow(1 - f, 2) * Math.Pow(Math.Sin(lat), 2));
			var S = Math.Pow(1 - f, 2) * C;

			var x = (a * C + h) * Math.Cos(lat) * Math.Cos(lon);
			var y = (a * C + h) * Math.Cos(lat) * Math.Sin(lon);
			var z = (a * S + h) * Math.Sin(lat);

			coordinates["X"] = x;
			coordinates["Y"] = y;
			coordinates["Z"] = z;

			object[] args = { this.X, this.Y, this.Z, x, y, z };
			Slb.Ocean.Petrel.PetrelLogger.InfoOutputWindow(String.Format("CartesianCoordinates: lat={0}, lon={1}, h={2} => x={3}, y={4}, z={5}", args));

			return coordinates;
		}
		public double DegToRad(double deg)
		{
			return deg * 0.0174532925; //Deegres to radians
		}
	}
}

