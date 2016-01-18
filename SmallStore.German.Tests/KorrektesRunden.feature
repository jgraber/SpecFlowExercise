# language: de-CH
# encoding: utf-8
Funktionalität: Korrektes Runden
	Damit jeder erhält was er verdient, muss korrekt auf 
	den nächsten 0.5er Schritt gerundet werden.

Szenariogrundriss: Werte werden korrekt gerundet
	Wenn der Eintrag <Credits> hat
	Dann wird <GerundeteCredits> angezeigt

	Beispiele: 
	| Credits | GerundeteCredits |
	| 1.1     | 1                |
	| 1.2     | 1                |
	| 1.24    | 1                |
	| 1.25    | 1.5              |
	| 1.26    | 1.5              |
	| 1.5     | 1.5              |
	| 1.51    | 1.5              |
	| 1.6     | 1.5              |
	| 1.74    | 1.5              |
	| 1.75    | 2                |
	| 2.0     | 2                |
