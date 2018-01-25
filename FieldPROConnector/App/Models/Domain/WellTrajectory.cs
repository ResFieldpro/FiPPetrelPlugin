using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using System.Windows.Forms;
using Slb.Ocean.Petrel.DomainObject.Well;

namespace FieldPROConnector
{
    class WellTrajectory
    {
        public WellTrajectory()
        {

        }
        public WellTrajectory(TrajectoryRecord r)
        {
            MD = r.MD;
            inclination = r.Inclination;
            azimuth = r.Azimuth;
        }
        private double inclination;
        private double azimuth;

        public int ID { get; set; }
        public double MD { get; set; }
        public double VD { get; set; }
        public double Inclination
        {
            get { return inclination; }
            set
            {
                if (value < -360.0 || value > 360.0)
                {
                    throw new System.ArgumentException("Inclination should be -360 ~ +360", value.ToString());
                };
                inclination = value;
            }
        }
        public double Azimuth
        {
            get { return azimuth; }
            set
            {
                if (value < -360.0 || value > 360.0)
                {
                    throw new System.ArgumentException("Azimuth should be -360 ~ +360", value.ToString());
                };
                azimuth = value;
            }
        }
        public double NS { get; set; }
        public double EW { get; set; }

        public double MD_Meters
        {
            get
            {
                return MD * 0.3048; //Feet to meters
            }
        }

        public double Inclination_Radians
        {
            get
            {
                return Inclination * 0.0174532925; //Deegres to radians
            }
        }

        public double Azimuth_Radians
        {
            get
            {
                return Azimuth * 0.0174532925; //Deegres to radians
            }
        }

        public static WellTrajectoryBroker Broker
        {
            get
            {
                return new WellTrajectoryBroker(WebConfiguration.Current);
            }
        }
        public static string TxtHeader
        {
            get
            {
                return "MD\tInclination\tAzimuth\tWE\tNS\tTVD\tWELL\tNAME";
            }
        }
        string FormatDouble(double v)
        {
            return v.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture);
        }
        public string Serialize(string well)
        {
            return FormatDouble(MD) + "\t"
                + FormatDouble(Inclination_Radians) + "\t"
                + FormatDouble(Azimuth_Radians) + "\t"
                + FormatDouble(EW) + "\t"
                + FormatDouble(NS) + "\t"
                + FormatDouble(VD) + "\t"
                + well + "\t" + "PETREL";
        }

        public TrajectoryRecord TrajectoryRecord()
        {
            return new TrajectoryRecord(MD_Meters, Inclination_Radians, Azimuth_Radians);
        }
    }
}