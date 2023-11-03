using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apoc.Model
{
    public interface IInternalParameter
    {
        /// <summary>
        /// Allgemeine Beitragsbemessungsgrenze in der allgemeinen 
        /// Rentenversicherung in Euro
        /// </summary>
        public double BBGRV { get; set; }

        /// <summary>
        /// Beitragssatz des Arbeitnehmers in der allgemeinen gesetzlichen 
        /// Rentenversicherung(4 Dezimalstellen)
        /// </summary>
        public double RVSATZAN { get; set; }

        /// <summary>
        /// Teilbetragssatz der Vorsorgepauschale für die Rentenversicherung 
        /// (2 Dezimalstellen)
        /// </summary>
        public double TBSVORV { get; set; }

        /// <summary>
        /// Beitragsbemessungsgrenze in der gesetzlichen 
        /// Krankenversicherung und der sozialen Pflegeversicherung in Euro
        /// </summary>
        public double BBGKVPV { get; set; }

        /// <summary>
        /// Beitragssatz des Arbeitnehmers zur Krankenversicherung 
        /// (5 Dezimalstellen)
        /// </summary>
        public double KVSATZAN { get; set; }

        /// <summary>
        /// Beitragssatz des Arbeitgebers zur Krankenversicherung unter 
        /// Berücksichtigung des durchschnittlichen Zusatzbeitragssatzes für die
        /// Ermittlung des Arbeitgeberzuschusses(5 Dezimalstellen)
        /// </summary>
        public double KVSATZAG { get; set; }

        /// <summary>
        /// Beitragssatz des Arbeitgebers zur Pflegeversicherung 
        /// (5 Dezimalstellen)
        /// </summary>
        public double PVSATZAG { get; set; }

        /// <summary>
        /// Beitragssatz des Arbeitnehmers zur Pflegeversicherung 
        /// (5 Dezimalstellen)
        /// </summary>
        public double PVSATZAN { get; set; }

        /// <summary>
        /// Erster Grenzwert in Steuerklasse V/VI in Euro
        /// </summary>
        public double W1STKL5 { get; set; }

        /// <summary>
        /// Zweiter Grenzwert in Steuerklasse V/VI in Euro
        /// </summary>
        public double W2STKL5 { get; set; }

        /// <summary>
        /// Dritter Grenzwert in Steuerklasse V/VI in Euro
        /// </summary>
        public double W3STKL5 { get; set; }

        /// <summary>
        /// Grundfreibetrag in Euro
        /// </summary>
        public double GFB { get; set; }

        /// <summary>
        /// Freigrenze für den Solidaritätszuschlag in Euro
        /// </summary>
        public double SOLZFREI { get; set; }

        /// <summary>
        /// Auf einen Jahreslohn hochgerechnetes RE4 in Euro, Cent (2 Dezimalstellen)
        /// </summary>
        /// <seealso cref="InputParameter.RE4" />
        public double ZRE4J { get; set; }

        /// <summary>
        /// Auf einen Jahreslohn hochgerechnetes VBEZ in Euro, Cent (2 Dezimalstellen)
        /// </summary>
        /// <seealso cref="InputParameter.VBEZ"/>
        public double ZVBEZJ { get; set; }

        /// <summary>
        /// Auf einen Jahreslohn hochgerechneter LZZFREIB in Euro, Cent (2 Dezimalstellen)
        /// </summary>
        /// <seealso cref="InputParameter.LZZFREIB"/>
        public double JLFREIB { get; set; }

        /// <summary>
        /// Auf einen Jahreslohn hochgerechneter LZZHINZU in Euro, Cent (2 Dezimalstellen)
        /// </summary>
        /// <seealso cref="InputParameter.LZZHINZU"/>
        public double JLHINZU { get; set; }

        /// <summary>
        /// Nummer der Tabellenwerte für Versorgungsparameter
        /// </summary>
        public int J { get; set; }

        /// <summary>
        /// Bemessungsgrundlage für den Versorgungsfreibetrag in Cent
        /// </summary>
        public double VBEZB { get; set; }

        /// <summary>
        /// Maßgeblicher maximaler Versorgungsfreibetrag in Euro
        /// </summary>
        public double HFVB { get; set; }

        /// <summary>
        /// Zuschlag zum Versorgungsfreibetrag in Euro
        /// </summary>
        public double FVBZ { get; set; }

        /// <summary>
        /// Versorgungsfreibetrag in Euro, Cent (2 Dezimalstellen)
        /// </summary>
        public double FVB { get; set; }

        /// <summary>
        /// Versorgungsfreibetrag in Euro, Cent(2 Dezimalstellen) für die 
        /// Berechnung der Lohnsteuer für den sonstigen Bezug
        /// </summary>
        public double FVBSO { get; set; }

        /// <summary>
        /// Zuschlag zum Versorgungsfreibetrag in Euro für die 
        /// Berechnung der Lohnsteuer beim sonstigen Bezug
        /// </summary>
        public double FVBZSO { get; set; }

        /// <summary>
        /// Maßgeblicher maximaler Zuschlag zum Versorgungsfreibetrag in Euro, 
        /// Cent(2 Dezimalstellen)
        /// </summary>
        public double HFVBZ { get; set; }

        /// <summary>
        /// Maßgeblicher maximaler Zuschlag zum Versorgungsfreibetrag in Euro, 
        /// Cent(2 Dezimalstellen) für die Berechnung der Lohnsteuer für den sonstigen Bezug
        /// </summary>
        public double HFVBZSO { get; set; }

        /// <summary>
        /// Bemessungsgrundlage für den Versorgungsfreibetrag in Cent für den sonstigen Bezug
        /// </summary>
        public double VBEZBSO { get; set; }

        /// <summary>
        /// Merker für Berechnung Lohnsteuer für mehrjährige Tätigkeit
        /// <list>
        ///     <item>
        ///         <term>0</term>
        ///         <description>normale Steuerberechnung</description>
        ///     </item>
        ///     <item>
        ///         <term>1</term>
        ///         <description>Steuerberechnung für mehrjährige Tätigkeit</description>
        ///     </item>
        ///     <item>
        ///         <term>2</term>
        ///         <description>Ermittlung der Vorsorgepauschale ohne Entschädigungen i.S.d. § 24 Nummer 1 EStG</description>
        ///     </item>
        /// </list>
        /// </summary>
        public int KENNVMT { get; set; }

        /// <summary>
        /// Altersentlastungsbetrag in Euro, Cent (2 Dezimalstellen)
        /// </summary>
        public double ALTE { get; set; }

        /// <summary>
        /// Nummer der Tabellenwerte für Parameter bei Altersentlastungsbetrag
        /// </summary>
        public int K { get; set; }

        /// <summary>
        /// Bemessungsgrundlage für Altersentlastungsbetrag in Euro, Cent (2 Dezimalstellen)
        /// </summary>
        public double BMG { get; set; }

        /// <summary>
        /// Maximaler Altersentlastungsbetrag in Euro
        /// </summary>
        public double HBALTE { get; set; }

        /// <summary>
        /// Auf einen Jahreslohn hochgerechnetes RE4 in Euro, Cent (2 Dezimalstellen) 
        /// nach Abzug der Freibeträge nach § 39b Absatz 2 Satz 3 und 4 EStG
        /// </summary>
        public double ZRE4 { get; set; }

        /// <summary>
        /// Auf einen Jahreslohn hochgerechnetes RE4, ggf. nach Abzug der Entschädigungen 
        /// i.S.d. § 24 Nummer 1 EStG in Euro, Cent (2 Dezimalstellen)
        /// </summary>
        public double ZRE4VP { get; set; }

        /// <summary>
        /// Auf einen Jahreslohn hochgerechnetes VBEZ abzüglich FVB in Euro, 
        /// Cent (2 Dezimalstellen)
        /// </summary>
        public double ZVBEZ { get; set; }

        /// <summary>
        /// Arbeitnehmer-Pauschbetrag/Werbungskosten-Pauschbetrag in Euro
        /// </summary>
        public double ANP { get; set; }

        /// <summary>
        /// Kennzahl für die Einkommensteuer-Tarifarten:
        /// <list>
        ///     <item>
        ///         <term>1</term>
        ///         <description>Grundtarif</description>
        ///     </item>
        ///     <item>
        ///         <term>2</term>
        ///         <description>Splittingverfahren</description>
        ///     </item>
        /// </list>
        /// </summary>
        public int KZTAB { get; set; }

        /// <summary>
        /// Sonderausgaben-Pauschbetrag in Euro
        /// </summary>
        public double SAP { get; set; }

        /// <summary>
        /// Summe der Freibeträge für Kinder in Euro
        /// </summary>
        public double KFB { get; set; }

        /// <summary>
        /// Vorsorgepauschale mit Teilbeträgen für die Rentenversicherung 
        /// sowie die gesetzliche Kranken- und soziale Pflegeversicherung nach 
        /// fiktiven Beträgen oder ggf. für die private Basiskrankenversicherung und 
        /// private Pflege-Pflichtversicherung in Euro, Cent (2 Dezimalstellen)
        /// </summary>
        public double VSP { get; set; }

        /// <summary>
        /// Vorsorgepauschale mit Teilbeträgen für die Rentenversicherung 
        /// sowie der Mindestvorsorgepauschale für die Kranken- und 
        /// Pflegeversicherung in Euro, Cent (2 Dezimalstellen)
        /// </summary>
        public double VSPN { get; set; }

        /// <summary>
        /// Zwischenwert 1 bei der Berechnung der Vorsorgepauschale 
        /// in Euro, Cent (2 Dezimalstellen)
        /// </summary>
        public double VSP1 { get; set; }

        /// <summary>
        /// Zwischenwert 2 bei der Berechnung der Vorsorgepauschale 
        /// in Euro, Cent (2 Dezimalstellen)
        /// </summary>
        public double VSP2 { get; set; }

        /// <summary>
        /// Vorsorgepauschale mit Teilbeträgen für die gesetzliche Kranken- 
        /// und soziale Pflegeversicherung nach fiktiven Beträgen oder ggf. für 
        /// die private Basiskrankenversicherung und private 
        /// Pflege-Pflichtversicherung in Euro, Cent (2 Dezimalstellen)
        /// </summary>
        public double VSP3 { get; set; }

        /// <summary>
        /// Höchstbetrag der Mindestvorsorgepauschale für die Kranken- und 
        /// Pflegeversicherung in Euro, Cent (2 Dezimalstellen)
        /// </summary>
        public double VHB { get; set; }

        /// <summary>
        /// Zu versteuerndes Einkommen in Euro, Cent (2 Dezimalstellen)
        /// </summary>
        public double ZVE { get; set; }

        /// <summary>
        /// Zu versteuerndes Einkommen gem. § 32a Absatz 1 und 5 EStG in 
        /// Euro, Cent (2 Dezimalstellen)
        /// </summary>
        public double X { get; set; }

        /// <summary>
        /// Gem. § 32a Absatz 1 EStG (6 Dezimalstellen)
        /// </summary>
        public double Y { get; set; }

        /// <summary>
        /// Tarifliche Einkommensteuer in Euro
        /// </summary>
        public double ST { get; set; }

        /// <summary>
        /// Rechenwert in Gleitkommadarstellung
        /// </summary>
        public double RW { get; set; }

        /// <summary>
        /// Zwischenfeld zu X für die Berechnung der Steuer nach § 39b Absatz 2 Satz 7 EStG in Euro
        /// </summary>
        public double ZZX { get; set; }

        /// <summary>
        /// Zwischenfeld zu X für die Berechnung der Steuer nach § 39b Absatz 2 Satz 7 EStG in Euro
        /// </summary>
        public double ZX { get; set; }

        /// <summary>
        /// Zwischenfeld zu X für die Berechnung der Steuer nach § 39b Absatz 2 Satz 7 EStG in Euro
        /// </summary>
        public double HOCH { get; set; }

        /// <summary>
        /// Zwischenfeld zu X für die Berechnung der Steuer nach § 39b Absatz 2 Satz 7 EStG in Euro
        /// </summary>
        public double VERGL { get; set; }

        /// <summary>
        /// Tarifliche Einkommensteuer auf das 1,25-fache ZX in Euro
        /// </summary>
        public double ST1 { get; set; }

        /// <summary>
        /// Tarifliche Einkommensteuer auf das 0,75-fache ZX in Euro
        /// </summary>
        public double ST2 { get; set; }

        /// <summary>
        /// Differenz zwischen ST1 und ST2 in Euro
        /// </summary>
        public double DIFF { get; set; }

        /// <summary>
        /// Mindeststeuer für die Steuerklassen V und VI in Euro
        /// </summary>
        public double MIST { get; set; }

        /// <summary>
        /// Feste Tabellenfreibeträge (ohne Vorsorgepauschale) in Euro, Cent (2 Dezimalstellen)
        /// </summary>
        public double ZTABFB { get; set; }

        /// <summary>
        /// Zwischenfeld zur Ermittlung der Steuer auf Vergütungen für mehrjährige Tätigkeit in Euro
        /// </summary>
        public double STOVMT { get; set; }

        /// <summary>
        /// Jahreslohnsteuer in Euro
        /// </summary>
        public double LSTJAHR { get; set; }

        /// <summary>
        /// Jahreswert, dessen Anteil für einen Lohnzahlungszeitraum 
        /// in UPANTEIL errechnet werden soll, in Cent
        /// </summary>
        public double JW { get; set; }

        /// <summary>
        /// Auf den Lohnzahlungszeitraum entfallender Anteil von 
        /// Jahreswerten auf ganze Cent abgerundet
        /// </summary>
        public double ANTEIL1 { get; set; }

        /// <summary>
        /// Jahreswert der berücksichtigten Beiträge zur privaten 
        /// Basis-Krankenversicherung und privaten Pflege-Pflichtversicherung 
        /// (ggf. auch die Mindestvorsorgepauschale) in Cent
        /// </summary>
        public double VKV { get; set; }

        /// <summary>
        /// Jahressteuer nach § 51a EStG, aus der Solidaritätszuschlag und 
        /// Bemessungsgrundlage für die Kirchenlohnsteuer ermittelt werden, in Euro
        /// </summary>
        public double JBMG { get; set; }

        /// <summary>
        /// Solidaritätszuschlag auf die Jahreslohnsteuer in Euro, Cent (2 Dezimalstellen)
        /// </summary>
        public double SOLZJ { get; set; }

        /// <summary>
        /// Zwischenwert für den Solidaritätszuschlag auf die Jahreslohnsteuer 
        /// in Euro, Cent (2 Dezimalstellen)
        /// </summary>
        public double SOLZMIN { get; set; }

        /// <summary>
        /// Zwischenfelder der Jahreslohnsteuer in Cent
        /// </summary>
        public double LSTSO { get; set; }

        /// <summary>
        /// Zwischenfelder der Jahreslohnsteuer in Cent
        /// </summary>
        public double LSTOSO { get; set; }

        /// <summary>
        /// Bemessungsgrundlage des Solidaritätszuschlags zur Prüfung der
        /// Freigrenze beim Solidaritätszuschlag für sonstige Bezüge(ohne
        /// Vergütung für mehrjährige Tätigkeit) in Euro
        /// </summary>
        public double SOLZSBMG { get; set; }

        /// <summary>
        /// Zu versteuerndes Einkommen für die Ermittlung der
        /// Bemessungsgrundlage des Solidaritätszuschlags zur Prüfung der
        /// Freigrenze beim Solidaritätszuschlag für sonstige Bezüge(ohne
        /// Vergütung für mehrjährige Tätigkeit) in Euro, Cent(2 Dezimalstellen)
        /// </summary>
        public double SOLZSZVE { get; set; }

        /// <summary>
        /// Bemessungsgrundlage des Solidaritätszuschlags für die Prüfung der
        /// Freigrenze beim Solidaritätszuschlag für die Vergütung für
        /// mehrjährige Tätigkeit in Euro
        /// </summary>
        public double SOLZVBMG { get; set; }

        /// <summary>
        /// Zwischenfelder der Jahreslohnsteuer in Cent
        /// </summary>
        public double LST1 { get; set; }

        /// <summary>
        /// Zwischenfelder der Jahreslohnsteuer in Cent
        /// </summary>
        public double LST2 { get; set; }

        /// <summary>
        /// Zwischenfelder der Jahreslohnsteuer in Cent
        /// </summary>
        public double LST3 { get; set; }
    }
}
