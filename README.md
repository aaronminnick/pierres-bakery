## Pierre's Bakery
#### _by Aaron Minnick_

```
====================================================
     ---*** Welcome to Pierre's Bakery! ***---
====================================================
Today's Menu:

Bread - $5 each, every 3rd loaf is free.
1. Challah   2. Rye   3. Baguette   4. Olive Loaf

Pastry - $2 each, every 3rd pastry is $1 (3 for $5).
5. Eclair   6. Pain au Chocolat   7. Apple Turnover
====================================================

Please type a number to add the item to your order.
```

### Technologies Used:
* C#
* .NET 5

This is the week 1 independent project for the C# curriculum at [Epicodus](https://www.epicodus.com). The objective was to create a console application in C# which would allow users to order various bread and pastries and calculate the price:
* Bread is $5 a loaf, but every 3rd loaf is free.
* Pastries are $2 each or 3 for $5.

Beyond these basic requirements, we were challenged to implement class inheritance and to allow for users to continually add to their order using static class variables.

### Setup Instructions:
_(Please note, the below instructions are using gitbash on a Windows computer. Commands may vary if you are using a different OS or terminal program.)_
* You will need [.NET 5](https://dotnet.microsoft.com/en-us/download/dotnet/5.0).

* Clone this repository to your local repository (the link may be easily got using the green "Code" button on the github page):
```
$ git clone https://github.com/aaronminnick/pierres-bakery.git
```
* **Or** you may use the same button to download the files to your computer.

* Use console commands to navigate to the main project folder and dotnet run (this will build automatically):
```
$ cd PierresBakery
$ dotnet run
```
* Once the project is built, you can also launch the console app using the .exe file located in the bin folder.

### TDD
If you wish to run the unit tests, use console commands to navigate to the testing project folder and dotnet restore prior to running dotnet test:
```
$ cd PierresBakery.Tests
$ dotnet restore
$ dotnet test
```

### Known Bugs/Issues:
* None

_Thanks for reading! Please feel free to contact me with feedback!_
***
#### [License: MIT](https://opensource.org/licenses/MIT)
#### Copyright (c) 2021 Aaron Minnick
