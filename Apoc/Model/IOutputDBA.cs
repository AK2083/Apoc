using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apoc.Model
{
    public interface IOutputDBA
    {
        /// <summary>
        /// Verbrauchter Freibetrag bei Berechnung des laufenden Arbeitslohns, in Cent
        /// </summary>
        public double VFRB { get; set; }

        /// <summary>
        /// Verbrauchter Freibetrag bei Berechnung des voraussichtlichen Jahresarbeitslohns, in Cent
        /// </summary>
        public double VFRBS1 { get; set; }

        /// <summary>
        /// Verbrauchter Freibetrag bei Berechnung der sonstigen Bezüge, in Cent
        /// </summary>
        public double VFRBS2 { get; set; }

        /// <summary>
        /// Für die weitergehende Berücksichtigung des Steuerfreibetrags nach 
        /// dem DBA Türkei verfügbares ZVE über dem Grundfreibetrag bei der 
        /// Berechnung des laufenden Arbeitslohns, in Cent
        /// </summary>
        public double WVFRB { get; set; }

        /// <summary>
        /// Für die weitergehende Berücksichtigung des Steuerfreibetrags 
        /// nach dem DBA Türkei verfügbares ZVE über dem Grundfreibetrag bei 
        /// der Berechnung der sonstigen Bezüge, in Cent
        /// </summary>
        public double WVFRBM { get; set; }

        /// <summary>
        /// Für die weitergehende Berücksichtigung des Steuerfreibetrags 
        /// nach dem DBA Türkei verfügbares ZVE über dem Grundfreibetrag 
        /// bei der Berechnung des voraussichtlichen Jahresarbeitslohns, 
        /// in Cent
        /// </summary>
        public double WVFRBO { get; set; }
    }
}
