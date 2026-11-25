# Správce úkolů (v paměti)

Jednoduchá konzolová aplikace napsaná v C# (.NET), která umožňuje zapisovat úkoly a zobrazovat je jako bodový seznam. Veškerá data se uchovávají pouze v operační paměti po dobu běhu programu.

## Funkce

* **Zápis úkolu (`1`)** – přidá nový textový úkol do seznamu (prázdné vstupy jsou odmítnuty, přebytečné mezery na začátku a konci se oříznou).
* **Výpis úkolů (`2`)** – vypíše uložené úkoly ve formě bodového seznamu (`•`). Pokud žádný úkol neexistuje, zobrazí odpovídající hlášku.
* **Ukončení (`0`)** – ukončí běh aplikace.

## Požadavky

* Nainstalované [.NET SDK](https://dotnet.microsoft.com/download) (doporučeno .NET 6.0 nebo novější).

## Spuštění

1. Vytvoř nový konzolový projekt a vlož kód do souboru `Program.cs`:
   ```bash
   dotnet new console -n SpravceUkolu
   cd SpravceUkolu