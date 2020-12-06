## Klient TCP

Projekt Aplikacji okienowej na laboratoria z przedmiotu Inżynieria Oprogramowania.
Aplikacja komunikuje się ze zbudowanym wcześniej serwerem TCP.
[Kod Serwera](https://github.com/bartoszCzarnecki/SerwerTCP)

## Technologie i Architektura Aplikacji

# WPF

Technologia Windows Presentation Foundation to jedno z najlepszych rozwiązań do tworzenia aplikacji okienkowych napisanych w języku C# działających pod kontrolą systemu Windows.

# MVVM

MVVM (Model-View-ViewModel) jest to wzorzec architektoniczny trójwarstowy, którego głównym celem jest wyraźne oddzielenie warstw (szczególnie Widoku od warstwy pośredniej – ViewModelu).

- View - widoki, które znajdują się w plikach o rozszerzeniu XAML.
- ViewModel - warstwa środkowa, jest pośrednikiem pomiędzy widokiem i modelem. Z ViewModel-a mamy kontrolę nad widokiem.
- Model - ostatnia warstwa, zapewnia dostęp do danych.

# Caliburn Micro

Caliburn Micro jest frameworkiem, który upraszcza budowanie aplikacji WPF w architekturze MVVM.
