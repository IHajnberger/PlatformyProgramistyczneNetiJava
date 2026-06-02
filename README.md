# Platformy Programistyczne .Net i Java

## Temat 0 - 04.03.2026
<details>
Wprowadzenie do programowania obiektowego w języku C# poprzez zaimplementowanie programu FizzBuzz zgodnie z podanymi w instrukcji założeniami.
</details>

## Temat 1 - 11-18.03.2026
<details>
  
__Zadanie 1:__

Implementacja problemu plecakowego z użyciem algorytmu zachłannego w języku C#.

Podział plików:

- Problem.cs - zawiera listę przedmiotów wykorzystującą generator losowy oraz klasę rozwiązania probolemu, która wyświetla wynik poprzez klase result,
- Program.cs - menu programu, wyświetla głownie informacje dla użytkownika i wywołuje klasy,
- Przedmiot.cs - przypisuje dane użytkownika do odpowiednich wartości,
- Result.cs - przechowuje wynik algorytmu.

__Zadanie 2:__

Testy jednostkowe zawarte w pliku Test.cs sprawdzają poprawność działania programu, w celu sprawdzenia:
- jeśli co najmniej jeden przedmiot spełnia ograniczenia
- jeśli żaden przedmiot się nie mieści
- test konkretnej instancji
- czy algorytm nie przekracza pojemności
- wartość nie może być ujemna

__Zadanie 3:__

Dodanie GUI zaprojektowanego przy użyciu Windows Forms App, pozwala użytkownikowi wprowadzić dane, a końcowo wyświetla wszystko w 2 dedykowanych polach.

<img width="793" height="762" alt="image" src="https://github.com/user-attachments/assets/e190e619-0e23-4f4d-bfc1-7c19026cc842" />
</details>

## Temat 2 - 25.03.2026
<details>
Projekt aplikacji bazodanowej .NET

__Struktura plików:__
- Program.cs - główny plik aplikacji zawierający metodę Main, odpowiada za interakcję z użytkownikiem (menu w konsoli) oraz wywoływanie metod z warstwy serwisowej.
- Models:
  - City.cs - model reprezentujący miasto w bazie danych. Zawiera nazwę miasta oraz relację do powiązanych danych pogodowych (1:N).
  - Weather.cs - model reprezentujący dane pogodowe przechowywane w bazie. Zawiera podstawowe informacje (temperatura, wilgotność, wiatr, data) oraz klucz obcy do miasta.
- Data:
  - AppDB.cs - klasa kontekstu bazy danych, odpowiada za konfigurację połączenia z bazą SQLite oraz zarządzanie tabelami (City, Weather).
- API
  - APIService.cs - klasa odpowiedzialna za komunikację z zewnętrznym API pogodowym. Wysyła zapytania HTTP i pobiera dane w formacie JSON.
  - WeatherResponse.cs - model używany do deserializacji odpowiedzi z API. Odwzorowuje strukturę JSON zwracaną przez serwis pogodowy.
  - WeatherService.cs - warstwa logiki aplikacji. Łączy API z bazą danych — odpowiada za pobieranie danych, ich zapisywanie, odczyt oraz operacje takie jak filtrowanie, sortowanie i usuwanie.

__Logika programu:__
<img width="340" height="170" alt="image" src="https://github.com/user-attachments/assets/5b5400d0-e223-433a-bc02-cbe37f71fc0c" />
1. Pobranie pogody:
<img width="295" height="102" alt="image" src="https://github.com/user-attachments/assets/08810595-e076-471a-918b-1c6ab33ea5f4" />
2. Wyświetlenie wszystkich pobranych danych:
<img width="674" height="154" alt="image" src="https://github.com/user-attachments/assets/069b7d9e-7c4c-489e-b5a3-b4efdf4c8a48" />
3. Filtrowanie danych po temperaturze:
<img width="667" height="468" alt="image" src="https://github.com/user-attachments/assets/7c1778af-2fec-42f7-a75a-f60da13d23b7" />
4. Sortowanie po temperaturze:
<img width="344" height="152" alt="image" src="https://github.com/user-attachments/assets/c57da2d8-008b-41d3-9c01-9556793f1c41" />
5. Usuwanie danych z bazy:
<img width="716" height="389" alt="image" src="https://github.com/user-attachments/assets/f89193b8-1468-4997-ba95-c6177f63a634" />


</details>


## Temat 3 - 22.04.2026
<details>
Obliczenia wielowątkowe w technologii.NET

Zadanie polegało na wykonaniu aplikacji pozwalającej na porównanie wydajności obliczeń sekwencyjnych oraz równoległych na przykładzie mnożenia macierzy. Zaimplementowano dwa podejścia do wielowątkowości:
- wysokopoziomowe (biblioteka Parallel)
- niskopoziomowe (klasa Thread)

__Struktura plików:__
- Matrix.cs - klasa przechowująca macierz 
- MatrixMulti.cs - klasa odpowiedzialna za mnożenie macierzy z użyciem biblioteki Parallel
- MatrixMThreads.cs - klasa realizująca mnożenie macierzy z użyciem klasy Thread, podział pracy oraz synchronizacja wątków realizowane są ręcznie, co pozwala na większą kontrolę, ale zwiększa złożoność kodu.
- Program.cs - główna część programu odpowiedzialna za generowanie macierzy, mierzenie czasu i wyświetlenie wyników. Dane końcowe stanowią uśrednioną wartość z 6 prób.

__Wyniki:__
<img width="1047" height="626" alt="image" src="https://github.com/user-attachments/assets/8e91d19b-e007-487d-9151-dd134c566b30" />
<img width="1035" height="620" alt="image" src="https://github.com/user-attachments/assets/64f85587-1bdb-4adb-a896-5f62dd0fe0cc" />
Implementacja z użyciem Thread daje większą kontrolę nad podziałem pracy, w niektórych przypadkach osiąga porównywalne lub lepsze wyniki niż Parallel. Wynika to z mniejszego narzutu zarządzania wątkami, biblioteka Parallel wprowadza dodatkowe mechanizmy optymalizacyjne, które nie zawsze są korzyste dla prostych obliczeń. 

</details>

## Temat 4 - 13.05.2026

<details>
  
Celem laboratorium jest zapoznanie się z podstawami projektowania i implementacji aplikacji webowych w technologii ASP.NET Core. 

__Zadanie 1:__

Rozszerzenie domyślnego komponentu pogodowego w aplikacji Blazor Web App.
Dodano prognozę na 10 dni, zliczanie ciepłych dni (>15°C), filtrowanie danych przy użyciu LINQ oraz wyszukiwanie po nazwie/opisie pogody.

Zastosowano interaktywność Blazora (InteractiveServer) oraz obsługę zdarzeń przycisków i pola tekstowego.

Najważniejsze pliki:
- Components/Pages/Weather.razor - główny komponent strony pogodowej,
- Components/Layout/NavMenu.razor - dodanie linku do strony Weather w menu bocznym.

__Zadanie 2:__

Utworzenie podstrony wykorzystującej wytrenowany model ML.NET do klasyfikacji sentymentu tekstu.

Aplikacja pozwala użytkownikowi wprowadzić tekst, uruchomić analizę oraz wyświetlić przewidywaną etykietę i pewność klasyfikacji.

Najważniejsze pliki:
- Components/Pages/Analiza.razor - interfejs użytkownika dla analizy sentymentu,
- Components/Layout/NavMenu.razor - dodanie linku do podstrony analizy sentymentu,
- Components/Layout/NavMenu.razor.css - konfiguracja ikony w menu bocznym aplikacji,
- Model.consumption.cs - automatycznie wygenerowany plik ML.NET, zawiera definicje klas ModelInput i ModelOutput.
</details>

## JAVA:

<details>
  link do repozytorium od Javy:
  https://github.com/IHajnberger/PlatformyProgramistyczneNetiJava_Java
</details>
