## cs_oppgave_03
___

Step 1: Data is loaded from a .csv file. A list of unique manufacturers (camera makers) is extracted from the field column. This list is then used to generate a selection menu.
<img src="https://github.com/VoltG3/cs_oppgave_04/blob/master/screenshot_01.png" alt="screenshot_01.png" width="100%">

Step 2: All production years available for the selected manufacturer are retrieved and mapped to build the year selection menu.
<img src="https://github.com/VoltG3/cs_oppgave_04/blob/master/screenshot_02.png" alt="screenshot_02.png" width="100%">

Step 3: Items for the selected manufacturer and year are then sorted by price, either in ascending or descending order.
<img src="https://github.com/VoltG3/cs_oppgave_04/blob/master/screenshot_03.png" alt="screenshot_03.png" width="100%">

Step 4: The program continues looping until the Q key is pressed.
<img src="https://github.com/VoltG3/cs_oppgave_04/blob/master/screenshot_04.png" alt="screenshot_04.png" width="100%">

#### Example 1
<img src="https://github.com/VoltG3/cs_oppgave_04/blob/master/screenshot_05.png" alt="screenshot_05.png" width="100%">

#### Example 2
<img src="https://github.com/VoltG3/cs_oppgave_04/blob/master/screenshot_06.png" alt="screenshot_06.png" width="100%">

#### Example 3
<img src="https://github.com/VoltG3/cs_oppgave_04/blob/master/screenshot_07.png" alt="screenshot_07.png" width="100%">

### Cheat Sheet & Remainder
Initialize the project
<img src="https://github.com/VoltG3/cs_oppgave_04/blob/master/screenshot_00.png" alt="screenshot_00.png" width="50%">

Add `.gitignore` to the project
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