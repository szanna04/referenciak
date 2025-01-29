# Cherry picking ZH - Pontozólap
Név: Szerdahelyi Anna Mária<br>
Neptun: P20QE5<br>
*Megjegyzések: A Githubra feltöltött, majd klónozott repository-ban lévő solutionre verziókezelési hibát jelzett a VS, azonban a Moodleben lévő tömörített fájl akadályok nélkül lefutott. Ezenkívül a monitor felnagyítása a Windows Forms-ban megjelenítési gondokat okozott, amely kiküszöbölésére a tesztelés közben került sor, így a képernyőképeken látható méretkülönbségek ennek köszönhetőek.*

**Projekt leírása:**<br>
A projektem egy filmadabázis kezelésének megkönnyítésére szolgál. A Windows Forms alkalmazásban lehetőség van a filmek szűrésére különböző paraméterek alapján. Ezenkívül a legfontosabb adatok kiemelésre kerültek textboxok segítségével. Az alkalmazáshoz tartozik egy API, amely lehetővé teszi az összes film megjelenítését, egy film 2 paraméterének módosítását, egy film lekérését egy adott argumentum alapján, illetve törlést az azonosító alapján. Továbbá létrehoztam egy weboldalt is, ahol egy gombnyomással megjeleníthetők a filmek, és lehetőség van új filmek hozzáadására az adatbázishoz. <br>

**Hozott anyagok:**<br>
  A hozott anyagaim közé tartozik egy, az órán is használt adatbázis scaffoldja. Ezenkívül a weboldalhoz előre elkészített js fájl, valamint egy útmutatást adó markdown a feladat lehetséges megoldásáról.
  ![hozott](https://github.com/user-attachments/assets/103ff0ba-977c-44ae-a9c3-819582020a99)
## Windows Forms Application
### User Interface
- 1x2p Az alkalmazásból a kilépés csak megerősítő kérdés után lehetséges<br>
Az alkalmazás bezárás esetén egy felugró ablakban megerősítést kér. Nem válasz esetén nem lépünk ki az alkalmazásból, igen válasz esetén leáll a program futása.
  ![closing](https://github.com/user-attachments/assets/a2c3e45c-3ec6-48fe-8f63-3fce9019719e)
  ![closing2](https://github.com/user-attachments/assets/fbbda9c1-e79f-42cd-adb0-f6471a6a63f2)
  ![closing3](https://github.com/user-attachments/assets/65ce31d2-eaa2-40b7-972c-f3f54919701e)
- 1x2p Anchorok alkalmazása: az alkalmazás egészében meg van oldva, hogy az ablak átméretezésekor ki legyen használva a rendelkezésre álló terület
  ![anchor](https://github.com/user-attachments/assets/52c82b25-f425-4e96-8cd9-8bdf0c592817)
  ![anchor2](https://github.com/user-attachments/assets/b8e7009f-2f9c-4451-9d3c-3bd587a4261e)
  ![anchor3](https://github.com/user-attachments/assets/f3dedc08-599b-4215-a920-fb552c2dfb15)
  ![anchor4](https://github.com/user-attachments/assets/a6f1f070-661f-4e0a-9ba7-96db3fc42ee2)
#### *Részpontszám: 4p*
### Tábla adatainak megjelenítése ListBox-ban
- 1x2p Adatok megjelenítése
  ![nameszures](https://github.com/user-attachments/assets/4f925fc8-f755-4416-a273-295163f2a02a)
- 2x2p Ha az adatok tetszőleges módszerrel, pl. TextBox-on keresztül szűrhetőek<br>
A filmek kategóriáját lehet szűrni egy textboxt segítsévégel:
  ![genreszures](https://github.com/user-attachments/assets/11a11c8c-a1ac-4d19-b338-909adc091702)
A filmek címének begépelésével szűrhetőek a kategóriák is:
  ![nameszures](https://github.com/user-attachments/assets/47cf49c1-30cb-4580-89a1-8bc74f8a4c56)
#### *Részpontszám: 6p*
### Tábla adatainak megjelenítése DataGridView-ban
- 1x2p Adatok megjelenítése
   ![forms](https://github.com/user-attachments/assets/959849d9-5f52-4bd8-9b76-e4ef203e06fa)

#### *Részpontszám: 2p*
### Adatkötés BindingSource -on keresztül
- 1x2p Működő BindingSource
  ![binding](https://github.com/user-attachments/assets/41f999df-faf6-4fb9-a37e-9a217c9270d4)
  ![anchor4](https://github.com/user-attachments/assets/6f92f0b4-d492-4adb-b2a1-4524c252f408)
- 3x1p Egy BindingSource-ra egy gyűjemény megjelenítésére alkalmas vezérlő (ListÍBox, ComboBox, DataGridVIew) mellett más adatkötött vezérlő is van kötve, mint TextBox, DateTimePicker, ComboBox idegen kulcs értékének beállítására, stb.<br>
A szűréskor lehetőségünk van kiválasztani a listboxban megjelenő adatokat, amelyek megjelennek a datagridviewban. Ezek legfontosabb adatai (cím, megjelenési év, kategória) külön megjelennek a nekik szánt textboxokban is.
  ![genreszures](https://github.com/user-attachments/assets/0366a17e-2c93-481e-a073-f8045c816304)
  ![nameszures](https://github.com/user-attachments/assets/ee7ef6f0-e509-40c8-b8eb-3879fa195b40)
  ![textboxkotes](https://github.com/user-attachments/assets/aed31f8d-f67a-4ce2-a223-f03fcd146872)
#### *Részpontszám: 5p*
### **Eddigi részpontszám: 17p**
## ASP .NET
- 1x2p program.cs beállítása wwwroot mappában tárolt statikus tartalmak megosztására<br>
A solution explorerben látszik a wwwroot mappa létrehozása, a benne található fájlok, valamint a képernyő jobb oldalán a Program.cs fájl, ahol lehetővé tettem a statikus tartalmak megosztását.
  ![root](https://github.com/user-attachments/assets/b4f1377b-64d0-477a-bc78-f611fea4f768)
#### *Részpontszám: 2p*
### API végpontok
- 1x3p Teljes SQL tábla adatainak szolgáltatása API végponton keresztül
  ![allfilms](https://github.com/user-attachments/assets/356259a0-bc9d-453a-a52a-05eb5bf3a9e2)
  ![allfilms2](https://github.com/user-attachments/assets/c69d53ec-e116-46be-9cd7-147164dc7219)
- 2x2p SQL tábla egy választható rekordjának szolgáltatása API végponton keresztül<br>
Egy film lekérdezése az azonosítójának segítségével:
  ![getbyid](https://github.com/user-attachments/assets/35a58d35-32c5-435b-960c-e669a777324c)
  ![getbyid2](https://github.com/user-attachments/assets/b8c3cab4-1212-438f-9613-2720c2272157)
Egy film lekérdezése a címének segítségével:
  ![getbytitle](https://github.com/user-attachments/assets/13611e6b-d50c-489e-9dce-6976cccda83e)
  ![getbytitle2](https://github.com/user-attachments/assets/37390102-49bc-4857-a985-1e040fdeabc6)
- 1x3p SQL tábla egy választható rekordjának törlése
  ![delete](https://github.com/user-attachments/assets/9fbfb415-73e9-4887-9456-4b54028ded9c)
  ![delete2](https://github.com/user-attachments/assets/c8cb0185-eceb-4669-b3de-2fabb84f415a)
- 1x5p Új rekord felvétele HttpPost metóduson keresztül SQL táblába
  ![postfilm](https://github.com/user-attachments/assets/25f4d640-b6c4-4b35-b70b-3cd301fd4120)
  ![postfilm2](https://github.com/user-attachments/assets/cdb15acb-05f0-4a29-adcc-ba8976d66962)
- 2x3p Rekord módosítása HttpPost metóduson keresztül SQL táblában<br>
Egy film elérhetőségének módosítása:
  ![postavailable](https://github.com/user-attachments/assets/98607f13-9c0d-4131-bbbe-cc389aa91084)
  ![postavailable2](https://github.com/user-attachments/assets/0acb0fba-4a23-4f1d-aa7e-43c9eb3f5554)
Egy film megjelenési évének módosítása:
  ![postrelease](https://github.com/user-attachments/assets/cf7d80f9-f11a-4670-959d-f0cca9bce813)
  ![postrelease2](https://github.com/user-attachments/assets/d9a773ec-65e7-4142-af13-933949bbc8ed)
#### *Részpontszám: 21p*
### **Eddigi részpontszám: 40p**
## Weboldal
- 1x1p A weboldalnak van egy értelmezhető struktúrája<br>
Az index.html nyitóoldalán legfelül megtalálható a cím, alatta egy gomb, aminek megnyomásával betöltödnek az adatbázisban lévő filmek a táblázatba. Az oldal alján egy új film felvételéhez találhatók beviteli mezők és egy gomb.
 ![indexstart](https://github.com/user-attachments/assets/9b216d16-280a-40a6-80dc-30cfd2969686)
- 1x1p A weboldal dinamikus tartalommal tölthető fel adatbázison keresztül
  ![dinamikus](https://github.com/user-attachments/assets/c41631ee-675c-4deb-aa3f-e2779b9a3159)
- 1x1p A weboldal használ legalább 20 sor értelmes css-t<br>
  A main.css elnevezésű fájlban 22 sor található, ami alapján az index.html meg lett formázva. Azonban egy sajnálatos gépelési hiba miatt (backgorund-color: #808080;) 2 sor nem működik, de a kritériumként szereplő 20 sor ezek levonása után is éppenhogy, de megvan.
  ![css](https://github.com/user-attachments/assets/84146d2e-9046-46c9-9703-6ce5af2d2efc)
  ![csshiba](https://github.com/user-attachments/assets/b2111a99-5ef0-4701-a0eb-e3611990df25)
- 1x1p A weboldal javascriptet használ API végpont által szolgáltatott adatok betöltésére, hozott anyagként
  ![js](https://github.com/user-attachments/assets/f4d413cd-a034-4fcd-93b3-1e91ec1b1f16)
  ![hozott](https://github.com/user-attachments/assets/b36c8717-5fa6-43f4-ad80-0512ca3d6b18)
- 1x1p A weboldal javascriptje más funkciót is ellát, mint az adatok betöltése<br>
A hozott js fájl a betöltésen kívül egyéb funkcionalitást is ellát: lehetőségünk van felvenni egy új filmet az adatbázisba. Az első három képen egy sikeres filmfelvételt láthatunk, ahol az új film firssítés után látszik is a táblázatban. Az utolsó képen egy hibaüzenet jelenik meg a felugró ablakon, hiszen a mezők kitöltése nélkül próbáltunk meg hozzáadni egy filmet.
  ![indexpost](https://github.com/user-attachments/assets/101380ae-4426-45f1-b0b5-cd5d130e243c)
  ![indexpost2](https://github.com/user-attachments/assets/04f8738c-cbc1-4829-bba6-1e7e44b5b215)
  ![indexpost3](https://github.com/user-attachments/assets/4ffd6356-9507-4ae2-bdef-746bea9d29f9)
  ![hiba](https://github.com/user-attachments/assets/b47283c3-2e78-404f-835c-26f739455ddb)
#### *Részpontszám: 5p*
### **Eddigi részpontszám: 45p**
## Egyéb, extra
- 2x1p Scaffold-DbContext használata (ajándék)
  A scaffold sikeresen lefutott a solution mindkét projectjében és létrejöttek a "JokeModels" mappák.
  Használt scaffold: Scaffold-DbContext "Data Source=bit.uni-corvinus.hu;Initial Catalog=FunnyDatabase;User ID=vendeg;Password=12345;Encrypt=False" Microsoft.EntityFrameworkCore.SqlServer -OutputDir JokeModels
  ![scaffold](https://github.com/user-attachments/assets/7f70eeca-9a06-4e1f-b8a9-31395669548c)
#### *Részpontszám: 2p*
### **Eddigi részpontszám: 47p**
# **Összpontszám: 47p**
