# FELADAT LEÍRÁS:
Írjon programot, amely tartalmaz egy ```INegyzet<T>``` absztrakt osztályt, feladata legyen a ```Negyzet<T>``` template osztály függvény fejeinek az összegyűjtése. A következő két absztrakt osztályt is “implementálja”:
* ```ITrapez<T>```, amelyből a ```Trapez<T>``` osztály származik le,
* illetve az ```IParalelogramma<T>``` absztrakt osztályt, amelyből a ```Paralelogramma<T>``` származik le.

A program tartalmazzon egy template ősosztályt ```Negyszog<T>``` néven. Az ősosztálynak legyen két adattagja, amelyben az alapot és a magasságot tárolja, hiszen minden négyszögnek van minimum egy oldala és egy magassága, tehát ez közös bennük. Mindezek mellett az ősosztálynak legyen még egy paraméteres konstruktora, melynek feladata az osztály adattagjainak az inicializálása. Továbbá az ősosztály tartalmazzon egy virtuális ```Kiir()``` nevezetű metódust, amely a kimeneten látható felső két sort
írja ki a konzolra.
A programban az egyik leszármazott osztály legyen a ```Negyzet<T>```, amely a ```Negyszog<T>``` osztályból származik le, illetve a fentebb felsorolt absztrakt osztályból. Ennek az osztálynak a feladat, hogy kiszámolja tetszőleges típussal (generikus), a négyzet kerületét, területét és átlóját. Ezeket a feladatokat
ellátó metódusoknak a visszatérési értéke is tetszőleges típusú (generikus) legyen. Az osztály utolsó metódusa legyen a felüldefiniált (override) ```Kiir()``` metódus, amely kiírja a négyzet kerületét, területét és átlóját.
A következő leszármaztatott osztály a ```Trapez<T>```, amely szintén a ```Negyszog<T>``` osztályból származik le, továbbá a fentebb említett absztrakt osztályból. A trapéznak legyen két egyenlő szárhossza, illetve egy felső alaphossz, amellyel a következőekben számol. Az osztálypéldányának feladata tetszőleges
típussal kiszámolni a trapéz kerületét és területét. Valamint felhasználva az ősosztály ```Kiir()``` metódusát felüldefiniálva (override), írja ki a trapéz kerületét és területét.
Az utolsó ```Paralelogramma<T>``` template osztály a ```Negyszog<T>``` osztályból és a fentebb említett absztrakt osztályból származik le. Az osztály feladat a Paralelogramma területének kiszámolása. Továbbá a kiszámolt terület kiírása a konzolra. Minden négyszögnek adjunk egy nevet és a konzolos kiíratásnál írjuk ki az adott négyszög nevét. Példányosítás során a ```Negyszog<int>``` osztályt kezdetben integer 
típussal példányosítsuk, illetve a ```Negyzet<int>``` osztályt is és mindkét osztálynak 12-t adjunk értékül, majd a ```Negyzet<int>``` osztály objektumát szüntessük meg és hozzunk létre egy újabb objektumot, ahol már a ```Negyzet<double>``` osztályt double típussal használjuk, mivel az ```Atlo()``` függvény csak ilyen típussal képes dolgozni. A ```Trapez<double>``` osztály, illetve a ```Paralelogramma<double>``` osztály
példányosítását double típussal végezzük.
***FIGYELEM! A leírásban, valamint az UML osztálydiagram ábrán hibás elemhasználat szerepelhet (elem ebben az esetben lehet: osztály, absztrakt osztály, interfész)! Jól gondolja át a C#-ban kezelendő öröklődés mechanizmusát, mint például a több osztályból történő származtatás / kiterjesztés lehetősége. A feladatot úgy oldja meg, hogy az UML ábrán szereplő elemkapcsolatok ne sérüljenek, ha szükségét látja, akkor hajtson végre elemcserét!***
![Osztály diagram](https://cloud.githubusercontent.com/assets/25847600/25776118/d8ee99c8-32b5-11e7-93bf-5f3941624bd7.png)
![Egy lehetséges kimenet](https://cloud.githubusercontent.com/assets/25847600/25776117/d8e98bea-32b5-11e7-9a40-83406b79d8e0.png)

