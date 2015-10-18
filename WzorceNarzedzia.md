# Wzorce i narzędzia

## Kilka pojęć

### Polimorfizm, dziedziczenie, hermetyzacja (enkapsulacja)

TODO

### Zbiór zasad dla OOP - SOLID

TODO

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

### Kontenery IoC na platformę .NET

Do najpopularniejszych kontenerów IoC/DI na platformie .NET należą:
* [Unity Container](https://github.com/unitycontainer/unity)
* [Castle Windsor](https://github.com/castleproject/Windsor)
* [AutoFac](https://github.com/autofac/Autofac)
* [StructureMap](https://github.com/structuremap/structuremap)

Oprócz nich jest dostępnych wiele mniej popularnych kontenerów. Sporą ich listę oraz porównanie wydajności możemy znaleźć w [tym repozytorium](https://github.com/danielpalme/IocPerformance).

Na naszych zajęciach będziemy głównie korzystać z kontenera AutoFac.

### NuGet

TODO

### StyleCop

TODO

