# language: de-CH
# encoding: utf-8
Funktionalität: Korrektes Runden
	Damit jeder erhält was er verdient, muss korrekt auf 
	den nächsten 0.5er Schritt gerundet werden.

@mytag
Szenario: Ganze Zahlen werden nicht gerundet
	Angenommen der Eintrag enthält 1 Credit
	Wenn das Protokoll angeschaut wird
	Dann wird dem Benutzer 1 Credit angezeigt

Szenario: Nachkommastellen werden korrekt aufgerundet
	Angenommen der Eintrag enthält 1.25 Credit
	Wenn das Protokoll angeschaut wird
	Dann wird dem Benutzer 1.5 Credit angezeigt
