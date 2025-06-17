## cs_oppgave_04
___

Step 1: Data is loaded from a .csv file. A list of unique manufacturers is extracted from the Field column, and this list is used to generate the selection menu.
![img](https://github.com/VoltG3/cs_oppgave_04/blob/master/screenshot_01.png)

Step 2: All production years available for the selected manufacturer are retrieved and mapped to build the year-selection menu.
![img](https://github.com/VoltG3/cs_oppgave_04/blob/master/screenshot_02.png)

Step 3: The items for the selected manufacturer and year are sorted by price, in ascending or descending order.
![img](https://github.com/VoltG3/cs_oppgave_04/blob/master/screenshot_03.png)

Step 4: The program loops until the Q key is pressed.
![img](https://github.com/VoltG3/cs_oppgave_04/blob/master/screenshot_04.png)

#### Example 1
![img](https://github.com/VoltG3/cs_oppgave_04/blob/master/screenshot_05.png)

#### Example 2
![img](https://github.com/VoltG3/cs_oppgave_04/blob/master/screenshot_06.png)

#### Example 3
![img](https://github.com/VoltG3/cs_oppgave_04/blob/master/screenshot_07.png)

#### Cheat Sheet & Remainder

Initialize the project without a Git repository and then add `.gitignore` to the project
```
bin/
obj/
/packages/
riderModule.iml
/_ReSharper.Caches/
TestResults/
.idea/
*.sln.iml
*.DotSettings.user
*.log
*.tmp
*.bak
*.pid
*.cache
.DS_Store
Thumbs.db
```

Add `*.csv` file to the project and edit the `.csproj` file
```
<ItemGroup>
    <None Update="Data\**\*.*">
    	 <CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>
    </None>
</ItemGroup>
```

Add `Spectre.Console` dependencies
```
dotnet add package Spectre.Console
dotnet add package Spectre.Console.Cli
```