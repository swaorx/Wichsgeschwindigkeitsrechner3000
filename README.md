# Wichsgeschwindigkeitsrechner3000
Berechnet sowohl die Wichsgeschwindigkeit, als auch die abgewichste Strecke in Cocklängen in Abhängigkeit der Zeit (t) bei **gleichmäßig beschleunigter Bewegung**.

# Nutzereingaben
Die folgenden Werte beruhen auf Nutzereingaben:
>- **`wichsGeschAusg`** (Ausgangsgeschwindigkeit bei t=0)
>- **a** (Beschleunigung; `double wichsBeschleunigung`)
>- **i** (Intensität; `double wichsIntensität`)
>- **`wichsZeit`** (Dauer der berechneten Wichszeit)

Zusätzlich wird die Wichsgeschwindigkeit von einem Intensitätsfaktor i beeinflusst. 
>- Für i>1 wird die Wichsung **beschleunigt**;
>- Für i<1 wird die Wichsung **verlangsamt**.

# Berechnung
Die Geschwindigkeit v(t) wird berechnet durch das Zeit-Geschwindigkeit-Gesetz der gleichmäßig beschleunigten Bewegung: 
- **v(t) = a * t + i**

Die Abmasturbierte Strecke in Cocklängen wird berechnet durch das Bewegungsgesetz der gleichmäßig beschleunigten Bewegung: 
- **s = (v(t)^2)/(2a)**

Die Funktionen können hier auf [GeoGebra](https://www.geogebra.org/calculator/vxukknrf) grafisch dargestellt werden.
