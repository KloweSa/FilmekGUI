# Szoftverfejlesztés gyakorlat - projekthét feladat
## FilmekGUI
A program tartalmazza a feladatleírás szerint elvárt funkciókat:
- Filmek listázása adatbázisból, képpel együtt
- Filmek adatlapjainak megtekintése, ezek módosítása, törlése
- Új film felvitele az adatbázisba
- Keresési lehetőséges cím, műfaj és megjelenési év alapján
- A műfajok külön táblában vannak tárolva, összekötve a filmek táblával a műfaj id alapján

## Hozzáadott funkciók
- Megadható a rendező neve
- Értékelések: A filmekhez egy 1-től 5-ig tartó skálán lehet megadni az értékeléseket. A már 12 "gyári" filmhez az imdb-ről kiválasztott filmek értékelései vannak használatban, habár ott 1-től 10-ig megy a skála, az 5 csillagnál nagyobb értékelések el lettek osztva 2-vel. A film adatlapján az értékelés megtalálható számmal, valamint képpel illusztrálva is
- Filmek felvételéhez, módosításához és törléséhez megfelelő jogokra van szükség. Ezt a jogot bejelentkezés után lehet használni, amíg fut a program. A Műveletek - Bejelentkezés fülön tudjuk megadni az azonosítót valamint a jelszót. Az azonosító és a jelszó is **admin**, igen tudom, nagyon kreatív

## Megjegyzések
- Mivel még sose csináltam C#-ban bármilyen bejelentkezési felületet, így a legjobb tudásom szerint próbáltam megcsinálni. Ezért nincsen semmilyen titkosítás a jelszón
- Valószínűleg nem a legjobban optimalizált program valaha, próbálkoztam
