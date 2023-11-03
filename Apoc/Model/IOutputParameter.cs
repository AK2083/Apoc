using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apoc.Model
{
    public interface IOutputParameter
    {
        /// <summary>
        /// Für den Lohnzahlungszeitraum einzubehaltende Lohnsteuer in Cent
        /// </summary>
        public decimal LSTLZZ { get; set; }

        /// <summary>
        /// Für den Lohnzahlungszeitraum berücksichtigte Beiträge des 
        /// Arbeitnehmers zur privaten Basis-Krankenversicherung und privaten 
        /// Pflege-Pflichtversicherung (ggf. auch die Mindestvorsorgepauschale) 
        /// in Cent beim laufenden Arbeitslohn. Für Zwecke der 
        /// Lohnsteuerbescheinigung sind die einzelnen Ausgabewerte 
        /// außerhalb des eigentlichen Lohnsteuerberechnungsprogramms zu 
        /// addieren; hinzuzurechnen sind auch die Ausgabewerte VKVSONST.
        /// </summary>
        public double VKVLZZ { get; set; }

        /// <summary>
        /// Für den Lohnzahlungszeitraum einzubehaltender 
        /// Solidaritätszuschlag in Cent
        /// </summary>
        public double SOLZLZZ { get; set; }

        /// <summary>
        /// Bemessungsgrundlage für die Kirchenlohnsteuer in Cent
        /// </summary>
        public double BK { get; set; }

        /// <summary>
        /// Für den Lohnzahlungszeitraum berücksichtigte Beiträge des 
        /// Arbeitnehmers zur privaten Basis-Krankenversicherung und privaten
        /// Pflege-Pflichtversicherung(ggf.auch die Mindestvorsorgepauschale)
        /// in Cent bei sonstigen Bezügen. Der Ausgabewert kann auch negativ 
        /// sein.Für tarifermäßigt zu besteuernde Vergütungen für mehrjährige
        /// Tätigkeiten enthält der PAP keinen entsprechenden Ausgabewert.
        /// </summary>
        public double VKVSONST { get; set; }

        /// <summary>
        /// Lohnsteuer für sonstige Bezüge (ohne Vergütung für mehrjährige 
        /// Tätigkeit) in Cent
        /// </summary>
        public double STS { get; set; }

        /// <summary>
        /// Solidaritätszuschlag für sonstige Bezüge (ohne Vergütung für 
        /// mehrjährige Tätigkeit) in Cent
        /// </summary>
        public double SOLZS { get; set; }

        /// <summary>
        /// Bemessungsgrundlage der sonstigen Bezüge (ohne Vergütung für 
        /// mehrjährige Tätigkeit) für die Kirchenlohnsteuer in Cent
        /// </summary>
        public double BKS { get; set; }

        /// <summary>
        /// Lohnsteuer für die Vergütung für mehrjährige Tätigkeit in Cent
        /// </summary>
        public double STV { get; set; }

        /// <summary>
        /// Solidaritätszuschlag für die Vergütung für mehrjährige Tätigkeit in 
        /// Cent
        /// </summary>
        public double SOLZV { get; set; }

        /// <summary>
        /// Bemessungsgrundlage der Vergütung für mehrjährige Tätigkeit für 
        /// die Kirchenlohnsteuer in Cent
        /// </summary>
        public double BKV { get; set; }
    }
}
