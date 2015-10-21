# Wzorce i narzędzia

## Kilka pojęć

### Polimorfizm, dziedziczenie, hermetyzacja (enkapsulacja)

Filary programowania obiektowego okazują się mieć, poza oczywistymi zaletami, również pewne wady. Jeżeli chcemy tworzyć wysokiej jakości kod, musi świadomie z nich korzystać.
Warto również wiedzieć o zastosowaniach tych mechanizmów w testach automatycznych.
* Dziedziczenie - jest jednym z najbardziej problematycznych elementów programowania obiektowego jeżeli chodzi o tworzenie wysokiej jakości kodu.
Gdy jest stosowany prawidłowo (i z umiarem) nie przeszkadza w tworzeniu wysokiej jakości kodu.
Stosowany nieprawidłowo wprowadza ukryte zależności i znacząco utrudnia testowanie. 
Razem z polimorfizmem jest filarem dla testów jednostkowych - dzięki niemu możemy zastąpić implementacje produkcyjne obiektami zastępczymi.
* Polimorfizm - a dokładniej polimorfizm interfejsu - pozwala nam na zastępowanie implementacji poszczególnych metod, nie zmieniając obiecanego kontraktu.
Dzięki temu możemy zastąpić implementację produkcyjną wersją testową - zamiast odwołać się do bazy danej operować na pamięci, zwrócić spodziewany wynik itp.
* Hermetyzacja (enkapsulacja) - prawidłowo stosowana ułatwia tworzenie łatwo testowalnego, wysokiej jakości kodu.
Dzięki ukryciu wewnętrznej struktury klasy mamy możliwość wprowadzania w niej zmian bez konieczności modyfikacji konsumentów naszej klasy.
Powstały w ten sposób kontrakt testujemy jednostkowo, zgodnie z wymaganiami co do danej klasy. 

### Zbiór zasad dla OOP - SOLID

* Single responsibility principle - Klasa powinna mieć tylko jedną odpowiedzialność (nigdy nie powinien istnieć więcej niż jeden powód do modyfikacji klasy).
* Open/closed principle - Przy zmianie wymagań nie powinien być zmieniany stary działający kod, ale dodawany nowy, który rozszerza zachowania (Open for extension, closed for modification).
* Liskov substitution principle - Korzystanie z funkcji klasy bazowej musi być możliwe również w przypadku podstawienia instancji klas pochodnych.
* Interface segregation principle - Klienci nie powinni zależeć od interfejsów, których nie używają.
* Dependency inversion principle - Wysokopoziomowe moduły nie powinny zależeć od modułów niskopoziomowych - zależności między nimi powinny wynikać z abstrakcji.

[Źródło](https://pl.wikipedia.org/wiki/Solid_(programowanie_obiektowe))

### Wzorzec Inversion Of Control (IoC) i Dependency Injection (DI)

TODO

### Inne przydatne wzorce projektowe

TODO
* Facade - TODO
* Proxy - TODO
* Wrapper - TODO
* Builder - TODO

### Programowanie funkcyjne

Programowanie funkcyjne to paradygmat programowania który znacząco różni się od programowania imperatywnego (proceduralnego czy obiektowego).
Jest to przykład programowania deklaratywnego, gdzie definiujemy co chcemy uzyskać, nie koniecznie definiując w jaki sposób ma to być zrobione.
W przypadku programowania funkcyjnego program konstruuje się poprzez składanie ze sobą funkcji (podobnie jak w matematyce - podstawą teoretyczną programowania funkcyjnego jest rachunek lambda).
W założeniu każda funkcja posiada parametry wejściowe oraz wynik i wszelka komunikacja z resztą systemu powinna odbywać się przez te dwa mechanizmy.
Jeżeli funkcja w jakikolwiek inny sposób komunikuje się z resztą systemu lub światem zewnętrznym to mówimy o tzw. efektach ubocznych.
Przykładami efektów ubocznych są np. zmienne, wyświetlanie informacji na ekranie, odczyt danych z pliku itp.

TODO

## Narzędzia z których będziemy korzystać na zajęciach

### Kontener IoC / DI

TODO
* Constructor injection - TODO
* Property injection - TODO

### Kontenery IoC na platformę .NET

Do najpopularniejszych kontenerów IoC/DI na platformie .NET należą:
* [Unity Container](https://github.com/unitycontainer/unity)
* [Castle Windsor](https://github.com/castleproject/Windsor)
* [AutoFac](https://github.com/autofac/Autofac)
* [StructureMap](https://github.com/structuremap/structuremap)

Oprócz nich jest dostępnych wiele mniej popularnych kontenerów. Sporą ich listę oraz porównanie wydajności możemy znaleźć w [tym repozytorium](https://github.com/danielpalme/IocPerformance).

Na naszych zajęciach będziemy głównie korzystać z kontenera AutoFac.

### NuGet

NuGet to narzędzie do zarządzania pakietami wykorzystywane na platformie .NET.
Pozwala na zarządzanie zewnętrznymi zależnościami z uwzględnieniem akceptowanych wersji czy różnych źródeł pakietów.
NuGet jest zintegrowany z Visual Studio, w którym możemy zarządzać pakietami dla projektu / solucji (Manage NuGet Packages).
Dostępna jest również linia poleceń oparta na PowerShell (Package Manager Console) która umożliwia rozbudowane zarządzanie pakietami:
* Instalację pakietów (Install-Package)
* Aktualizację wersji pakietów (Update-Package)
* Deinstalację pakietów (Uninstall-Package)
* Wyszukiwanie pakietów i wiele innych - szczegóły dostępne są [w dokumentacji](http://docs.nuget.org/Consume/Package-Manager-Console-PowerShell-Reference)
Listę pakietów dostępnych w domyślnym repozytorium (wraz z wyszukiwarką) możemy znaleźć na [stronie projektu](https://www.nuget.org/).

### StyleCop

TODO

