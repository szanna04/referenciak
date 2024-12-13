# Cherry picking ZH - Pontozólap
Név: Szerdahelyi Anna Mária<br>
Neptun: P20QE5<br>
*Megjegyzések: A Githubra feltöltött, majd klónozott repository-ban lévő solutionre verziókezelési hibát jelzett a VS, azonban a Moodleben lévő tömörített fájl akadályok nélkül lefutott. Ezenkívül a monitor felnagyítása a Windows Forms-ban megjelenítési gondokat okozott, amely kiküszöbölésére a tesztelés közben került sor, így a képernyőképeken látható méretkülönbségek ennek köszönhetőek.*

**Projekt leírása:**<br>
A projektem egy filmadabázis kezelésének megkönnyítésére szolgál. A Windows Forms alkalmazásban lehetőség van a filmek szűrésére különböző paraméterek alapján. Ezenkívül a legfontosabb adatok kiemelésre kerültek textboxok segítségével. Az alkalmazáshoz tartozik egy API, amely lehetővé teszi az összes film megjelenítését, egy film 2 paraméterének módosítását, egy film lekérését egy adott argumentum alapján, illetve törlést az azonosító alapján. Továbbá létrehoztam egy weboldalt is, ahol egy gombnyomással megjeleníthetők a filmek, és lehetőség van új filmek hozzáadására az adatbázishoz.
**Hozott anyagok:**<br
  A hozott anyagaim közé tartozik egy, az órán is használt adatbázis scaffoldja. Ezenkívül a weboldalhoz előre elkészített js fájl, valamint egy útmutatást adó markdown a feladat lehetséges megoldásáról.
  ![hozott](https://github.com/user-attachments/assets/6b9ff7a5-ac8b-4ad0-b6f9-70dcbc850115)
## Windows Forms Application
### User Interface
- 1x2p Az alkalmazásból a kilépés csak megerősítő kérdés után lehetséges<br>
Az alkalmazás bezárás esetén egy felugró ablakban megerősítést kér. Nem válasz esetén nem lépünk ki az alkalmazásból, igen válasz esetén leáll a program futása.
  ![closing](https://github.com/user-attachments/assets/e08ff6b3-3901-4d6f-8f69-322da53bedfe)
  ![closing2](https://github.com/user-attachments/assets/5fd88af3-2df7-49f5-9726-f675af3feb6f)
  ![closing3](https://github.com/user-attachments/assets/95009197-c043-4a87-8c8b-4c951705f5d5)
- 1x2p Anchorok alkalmazása: az alkalmazás egészében meg van oldva, hogy az ablak átméretezésekor ki legyen használva a rendelkezésre álló terület
  ![anchor](https://github.com/user-attachments/assets/44dce421-3384-4f0b-9425-44a68604a739)
  ![anchor2](https://github.com/user-attachments/assets/b58f1d1e-0d7b-4cf7-acb6-09ec52c73f75)
  ![anchor3](https://github.com/user-attachments/assets/8089cfbc-105c-4e68-aab2-228860c49e67)
  ![anchor4](https://github.com/user-attachments/assets/066eb068-7e80-4e96-84ad-1e035e02497f)
#### *Részpontszám: 4p*
### Tábla adatainak megjelenítése ListBox-ban
- 1x2p Adatok megjelenítése
  ![nameszures](https://github.com/user-attachments/assets/a085c9a2-8d53-42fe-bf38-b6344eeec876)
- 2x2p Ha az adatok tetszőleges módszerrel, pl. TextBox-on keresztül szűrhetőek<br>
A filmek kategóriáját lehet szűrni egy textboxt segítsévégel:
  ![genreszures](https://github.com/user-attachments/assets/53a4824f-a800-45ae-b915-540593932641)
A filmek címének begépelésével szűrhetőek a kategóriák is:
  ![nameszures](https://github.com/user-attachments/assets/39a3d51d-35a3-4ae4-a39f-51b82dd72ca4)
#### *Részpontszám: 6p*
### Tábla adatainak megjelenítése DataGridView-ban
- 1x2p Adatok megjelenítése
  ![forms](https://github.com/user-attachments/assets/8342f37c-c9d2-487e-bf77-6af9fa644f35)
#### *Részpontszám: 2p*
### Adatkötés BindingSource -on keresztül
- 1x2p Működő BindingSource
  ![binding](https://github.com/user-attachments/assets/6d16dffa-babd-4b24-b5cd-b7a058336dfb)
  ![anchor4](https://github.com/user-attachments/assets/4a88b8dc-b8bb-45b6-8873-10aa21e79c8c)
- 3x1p Egy BindingSource-ra egy gyűjemény megjelenítésére alkalmas vezérlő (ListÍBox, ComboBox, DataGridVIew) mellett más adatkötött vezérlő is van kötve, mint TextBox, DateTimePicker, ComboBox idegen kulcs értékének beállítására, stb.<br>
A szűréskor lehetőségünk van kiválasztani a listboxban megjelenő adatokat, amelyek megjelennek a datagridviewban. Ezek legfontosabb adatai (cím, megjelenési év, kategória) külön megjelennek a nekik szánt textboxokban is.
  ![nameszures](https://github.com/user-attachments/assets/d4ae511f-5b2b-44c5-8ce1-1efea716cc83)
  ![genreszures](https://github.com/user-attachments/assets/54beb081-73d9-4e7a-b096-44f8cafc65e5)
  ![textboxkotes](https://github.com/user-attachments/assets/675c0df6-3213-46ac-bc28-d34524ebca9d)
#### *Részpontszám: 5p*
### **Eddigi részpontszám: 17p**
## ASP .NET
- 1x2p program.cs beállítása wwwroot mappában tárolt statikus tartalmak megosztására<br>
A solution explorerben látszik a wwwroot mappa létrehozása, a benne található fájlok, valamint a képernyő jobb oldalán a Program.cs fájl, ahol lehetővé tettem a statikus tartalmak megosztását.
  ![image](https://github.com/user-attachments/assets/6fa606f0-39ce-4942-a968-a56169befd87)
#### *Részpontszám: 2p*
### API végpontok
- 1x3p Teljes SQL tábla adatainak szolgáltatása API végponton keresztül
  ![allfilms](https://github.com/user-attachments/assets/24f4ad6c-d85f-4c62-850a-4160fdd4e33c)
  ![allfilms2](https://github.com/user-attachments/assets/e913e195-64a5-4842-b29c-755e91a858ca)
- 2x2p SQL tábla egy választható rekordjának szolgáltatása API végponton keresztül<br>
Egy film lekérdezése az azonosítójának segítségével:
  ![getbyid](https://github.com/user-attachments/assets/dd1f5629-84b2-49b0-b616-cd5db454cdab)
  ![getbyid2](https://github.com/user-attachments/assets/7b4ca959-9a36-4fb9-9a59-c7052418229e)
Egy film lekérdezése a címének segítségével:
  ![getbytitle](https://github.com/user-attachments/assets/8bc397cf-3f93-4162-a287-a3bdd8b7ee76)
  ![getbytitle2](https://github.com/user-attachments/assets/6fe8e1e6-4945-4f08-ba4c-0dafcb9e4651)
- 1x3p SQL tábla egy választható rekordjának törlése
  ![delete](https://github.com/user-attachments/assets/0889300c-0045-48f3-90b1-30560247016a)
  ![delete2](https://github.com/user-attachments/assets/571081c0-c165-4f66-bc37-750d47ea6fad)
- 1x5p Új rekord felvétele HttpPost metóduson keresztül SQL táblába
  ![postfilm](https://github.com/user-attachments/assets/836bdb68-0194-4788-b2de-88244ecc1376)
  ![postfilm2](https://github.com/user-attachments/assets/11a10ca3-a48f-4feb-a29f-b669352597ff)
- 2x3p Rekord módosítása HttpPost metóduson keresztül SQL táblában<br>
Egy film elérhetőségének módosítása:
  ![postavailable](https://github.com/user-attachments/assets/119aa87e-340b-4f02-ba94-b6db63b84ee8)
  ![postavailable2](https://github.com/user-attachments/assets/0a0dac88-2c0f-40dc-a70a-dea13ca79279)
Egy film megjelenési évének módosítása:
  ![postrelease](https://github.com/user-attachments/assets/250b5510-4eb4-4ba3-855a-e83d8033b88f)
  ![postrelease2](https://github.com/user-attachments/assets/004802ef-8fd8-4030-9e7e-48cae0fbc219)
#### *Részpontszám: 21p*
### **Eddigi részpontszám: 40p**
## Weboldal
- 1x1p A weboldalnak van egy értelmezhető struktúrája<br>
Az index.html nyitóoldalán legfelül megtalálható a cím, alatta egy gomb, aminek megnyomásával betöltödnek az adatbázisban lévő filmek a táblázatba. Az oldal alján egy új film felvételéhez találhatók beviteli mezők és egy gomb.
  ![indexstart](https://github.com/user-attachments/assets/b0735d00-6a8c-43d2-91de-0f4fad707edf)
- 1x1p A weboldal dinamikus tartalommal tölthető fel adatbázison keresztül
  ![dinamikus](https://github.com/user-attachments/assets/d0b08ad4-253f-485a-a3e8-94ec357c1cf0)
- 1x1p A weboldal használ legalább 20 sor értelmes css-t<br>
  A main.css elnevezésű fájlban 22 sor található, ami alapján az index.html meg lett formázva. Azonban egy sajnálatos gépelési hiba miatt (backgorund-color: #808080;) 2 sor nem működik, de a kritériumként szereplő 20 sor ezek levonása után is éppenhogy, de megvan.
  ![csshiba](https://github.com/user-attachments/assets/c7109f34-bd57-4b1a-800d-b08c28c3f051)
  ![css](https://github.com/user-attachments/assets/45f09f40-6421-41bc-9732-a850528a8d61)
- 1x1p A weboldal javascriptet használ API végpont által szolgáltatott adatok betöltésére, hozott anyagként
  ![js](https://github.com/user-attachments/assets/71560c9d-03bb-401f-a27e-1c5b4c6dd1c8)
  ![hozott](https://github.com/user-attachments/assets/c2ba160f-94fc-4b5b-90b6-f592a39e5fba)
- 1x1p A weboldal javascriptje más funkciót is ellát, mint az adatok betöltése<br>
A hozott js fájl a betöltésen kívül egyéb funkcionalitást is ellát: lehetőségünk van felvenni egy új filmet az adatbázisba. Az első három képen egy sikeres filmfelvételt láthatunk, ahol az új film firssítés után látszik is a táblázatban. Az utolsó képen egy hibaüzenet jelenik meg a felugró ablakon, hiszen a mezők kitöltése nélkül próbáltunk meg hozzáadni egy filmet.
  ![indexpost](https://github.com/user-attachments/assets/9d62f0bf-6841-4409-b12d-e33525c4e306)
  ![indexpost2](https://github.com/user-attachments/assets/6f1b72e1-10e2-4ff8-bc3c-1d7a992fa72a)
  ![indexpost3](https://github.com/user-attachments/assets/fffd6563-161e-4c56-ae5a-b2197cd03920)
  ![hiba](https://github.com/user-attachments/assets/034817b3-5a4f-414a-980f-4b510bc527ff)

#### *Részpontszám: 5p*
### **Eddigi részpontszám: 45p**
## Egyéb, extra
- 2x1p Scaffold-DbContext használata (ajándék)
  A scaffold sikeresen lefutott a solution mindkét projectjében és létrejöttek a "JokeModels" mappák.
  Használt scaffold: Scaffold-DbContext "Data Source=bit.uni-corvinus.hu;Initial Catalog=FunnyDatabase;User ID=vendeg;Password=12345;Encrypt=False" Microsoft.EntityFrameworkCore.SqlServer -OutputDir JokeModels
  ![scaffold](https://github.com/user-attachments/assets/1364c91f-037a-4bd7-8e0a-d4322f8a5eb0)
#### *Részpontszám: 2p*
### **Eddigi részpontszám: 47p**
# **Összpontszám: 47p**
