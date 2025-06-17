## cs_oppgave_04
___

Step 1: Data is loaded from a .csv file. A list of unique manufacturers is extracted from the Field column, and this list is used to generate the selection menu.
![img](https://github.com/VoltG3/cs_oppgave_04/blob/master/screenshot_02.png)

Step 2: All production years available for the selected manufacturer are retrieved and mapped to build the year-selection menu.
<img src="https://github.com/VoltG3/cs_oppgave_04/blob/master/screenshot_02.png" alt="screenshot_02.png" width="100%">

Step 3: The items for the selected manufacturer and year are sorted by price, in ascending or descending order.
<img src="https://github.com/VoltG3/cs_oppgave_04/blob/master/screenshot_03.png" alt="screenshot_03.png" width="100%">

Step 4: The program loops until the Q key is pressed.
<img src="https://github.com/VoltG3/cs_oppgave_04/blob/master/screenshot_04.png" alt="screenshot_04.png" width="100%">

#### Example 1
<img src="https://github.com/VoltG3/cs_oppgave_04/blob/master/screenshot_05.png" alt="screenshot_05.png" width="100%">

#### Example 2
<img src="https://github.com/VoltG3/cs_oppgave_04/blob/master/screenshot_06.png" alt="screenshot_06.png" width="100%">

#### Example 3
<img src="https://github.com/VoltG3/cs_oppgave_04/blob/master/screenshot_07.png" alt="screenshot_07.png" width="100%">

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