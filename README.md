# Package Express - Branching Assignment

A commented C# console app that calculates a shipping quote using branching.

Run `dotnet run` in this directory with the .NET 8 SDK installed.

The program requests weight, width, height, and length. Weight over 50 ends the program immediately. Dimensions whose sum exceeds 50 also end the program. Otherwise the quote is width * height * length * weight / 100, displayed as dollars with two decimal places.

Example: weight 40, width 10, height 12, length 11 produces $528.00.

Positive decimal measurements are supported. Invalid or non-positive input is prompted again. Exactly 50 is allowed for weight and the dimension sum.
