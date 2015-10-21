# Wzorce i narzędzia

## Kilka pojęć

### Polimorfizm, dziedziczenie, hermetyzacja (enkapsulacja)

Filary programowania obiektowego okazują się mieć, poza oczywistymi zaletami, również pewne wady. Jeżeli chcemy tworzyć wysokiej jakości kod, musimy świadomie z nich korzystać.
Warto również wiedzieć o zastosowaniach tych mechanizmów w testach automatycznych.
* Dziedziczenie - jest jednym z najbardziej problematycznych elementów programowania obiektowego jeżeli chodzi o tworzenie wysokiej jakości kodu.
Gdy jest stosowane prawidłowo (i z umiarem) nie przeszkadza w tworzeniu wysokiej jakości kodu.
Stosowane nieprawidłowo wprowadza ukryte zależności i znacząco utrudnia testowanie. 
Razem z polimorfizmem jest filarem testów jednostkowych - dzięki niemu możemy zastąpić implementacje produkcyjne obiektami zastępczymi.
* Polimorfizm - a dokładniej polimorfizm interfejsu - pozwala nam na zastępowanie implementacji poszczególnych metod, nie zmieniając obiecanego kontraktu.
Dzięki temu możemy zastąpić implementację produkcyjną wersją testową - zamiast odwołać się do bazy danych operować na pamięci, zwrócić spodziewany wynik itp.
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

Inversion of Control - odwrócenie sterowania - wzorzec, podejście w projektowaniu oprogramowania mający na celu taką implementację klas, aby nie były one same odpowiedzialne za wybór narzędzi wymaganych do wykonania jakiejś funkcjonalności (na przykład użycie konkretnej bilioteki dostępu do systemu plików), lecz raczej oddanie tego wyboru i sterowania innym zewnętrznym wobec niej komponentom. 
Dzięki wykorzystaniu IoC działanie modułu może skupiać się na zadaniach dla których zostały napisane, nie zakładając niczego na temat szczegółow implementacyjnych systemów zewnętrznych.
Może być realizowane za pomocą różnych, konkrentych mechanizmów takich jak: Dependency Injection, Callbacki, serice locatory.

Dependency injection - wstrzykiwanie zależności - jedna z form IoC polegająca na zaimplementowaniu koncepcji IoC w odniesieniu do zarządzania zależnościami. Odbywa się to poprzez budowania obiektu proprzez dostarczaniu mu okroślonych implentacji 
wymaganych przez niego interfejsów. W roli 'budowniczych' najczęściej występują tak zwane kontenery opisane niżej, a dobrą analogią tłumaczącą ten wzorzec może być zwykłe wywołanie metody, czy funkcje wyższego rzędu w językach funkcyjnych.

### Inne przydatne wzorce projektowe

Wiele wzorców projektowych umożliwia tworzenie wysokiej jakości, testowanego oprogramowania.
Spośród nich jest kilka, które szczególnie często przydają się przy tworzeniu testowalnego kodu, a także do tworzenia do niego testów.

* Facade - wzorzec strukturalny. Służy do ujednolicenia dostępu do złożonego systemu poprzez wystawienie uproszczonego, uporządkowanego interfejsu programistycznego, który ułatwia jego użycie.

* Proxy - wzorzec strukturalny. Polega na utworzeniu obiektu zastępującego inny obiekt. Stosowany jest w celu kontrolowanego tworzenia na żądanie kosztownych obiektów oraz kontroli dostępu do nich.

* Adapter / wrapper - strukturalny wzorzec projektowy, którego celem jest umożliwienie współpracy dwóm klasom o niekompatybilnych interfejsach. Adapter przekształca interfejs jednej z klas na interfejs drugiej klasy.

* Builder -  kreacyjny wzorzec projektowy, którego celem jest rozdzielenie sposobu tworzenia obiektów od ich reprezentacji. Innymi słowy proces tworzenia obiektu podzielony jest na kilka mniejszych etapów a każdy z tych etapów może być implementowany na wiele sposobów. 

[Źródło](https://pl.wikipedia.org)

### Programowanie funkcyjne

Programowanie funkcyjne to paradygmat programowania który znacząco różni się od programowania imperatywnego (proceduralnego czy obiektowego).
Jest to przykład programowania deklaratywnego, gdzie definiujemy co chcemy uzyskać, nie koniecznie definiując w jaki sposób ma to być zrobione.
W przypadku programowania funkcyjnego program konstruuje się poprzez składanie ze sobą funkcji (podobnie jak w matematyce - podstawą teoretyczną programowania funkcyjnego jest rachunek lambda).
W założeniu każda funkcja posiada parametry wejściowe oraz wynik i wszelka komunikacja z resztą systemu powinna odbywać się przez te dwa mechanizmy.
Jeżeli funkcja w jakikolwiek inny sposób komunikuje się z resztą systemu lub światem zewnętrznym to mówimy o tzw. efektach ubocznych.
Przykładami efektów ubocznych są np. zmienne, wyświetlanie informacji na ekranie, odczyt danych z pliku itp.

## Narzędzia z których będziemy korzystać na zajęciach

### Kontener IoC / DI

Kontener w ogólności to struktura danych służąca do przchowania zbioru elementów, jej wewnętrzna struktura może zależeleć od jej wykorzystania.
W kontekście wstrzykiwania zależności, kontener to podsystem, posiadający metadane opisujące w jaki sposób tworzyć obiekty określonych typów.
Potrafi budować złożone hierarchie obiektów poprzez rekurencyjne roziwiązywanie zaleźności oraz ich wstrzykiwanie.

Formy wstrzykiwania zaleśności.
* Constructor injection - sposób zadeklarowania klasy i późniejszej inicjalizacji jej instancji, polegający na wyspecyfikownaiu w konstruktorze wszystkich zależności wymaganych przez klasę.
Skutkuje to faktem, że na etapie tworzenia obiektu danego typu wszystkie zależności muszą zostać uzupełnione i dostępne, nie mają one również domyślnych (neutralnych) wartości 
* Property injection - w tym podejściu klasa definiuje swoje zależności jako własności. W większości przypadków skutkuje to ich opcjonalnością, gdyż nie są one wymagane przez konstruktor.
Umożliwia róznieź modelowanie cyklicznych zależności pomiędzy komponentami


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
* Instalację pakietów (`Install-Package`)
* Aktualizację wersji pakietów (`Update-Package`)
* Deinstalację pakietów (`Uninstall-Package`)
* Wyszukiwanie pakietów i wiele innych - szczegóły dostępne są [w dokumentacji](http://docs.nuget.org/Consume/Package-Manager-Console-PowerShell-Reference)
Listę pakietów dostępnych w domyślnym repozytorium (wraz z wyszukiwarką) możemy znaleźć na [stronie projektu](https://www.nuget.org/).

Pakiety zainstalowane w naszym projekcie możemy sprawdzić w pliku `packages.config` który dodawany jest automatycznie do projektu przy instalacji pierwszego pakietu.
Domyślnie pakiety pobierane są do folderu `packages` znajdującego się w tym samym folderze co nasza solucja.
