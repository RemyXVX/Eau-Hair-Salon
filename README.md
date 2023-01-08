# Eau Claire's Salon

#### By **Remy Flores**

#### **Eau Claire's Salon**

## Technologies Used
* VSCode
* GitBash
* C#
* .NET6 SDK
* MSTest
* WindowPowershell
* Razor
* CSS
* HTML
* MySQL Server
* MySQL Workbench

## Description
_Creating A website for our amazing client Claire. They will be able to create work profiles for all future stylist and update/edit all current ones. On top of that, being able to keep trak of all the clients each stylists takes on._

## Webpage
* [https://github.com/RemyXVX/Eau-Hair-Salon]

## Setup/Installation Requirements
* _Chrome web browser for best compatiblity_
* _Have a prompt and editor to apply changes, like VSCode and Gitbash_

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[Download here for VScode](https://code.visualstudio.com/download)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[Download here for Gitbash](https://git-scm.com/downloads)

* _Installation of .Net 6.0 and C# for applied language_

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[Download here](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)

* _Aftward, download MySQL Server & Workbench_

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[Download here](https://dev.mysql.com/downloads/mysql/)

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(more information on how to setup MySQL Server & Workbench, see [here](https://www.youtube.com/watch?v=u96rVINbAUI&ab_channel=WebDevSimplified))

* _From there download repo for **Eau Claire's Salon**_

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[Copy here](https://github.com/RemyXVX/Eau-Hair-Salon)

## Step by step breakdown on how to run application: ##
<br>

<big>copy by running:</big>

```
git clone "[https://github.com/RemyXVX/Eau-Hair-Salon.git]"
````

<big>I would recommend also setting up your work envirnoment after cloning by:</big>

```
$dotnet build
```
<big>Once we have the program settled, I would add an '_appsetting.json_' file like:</big>
```
$touch appsetting.json

and then add to the file:

{
  "ConnectionStrings": 
  {
    "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-DATABASE-NAME-HERE];uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}
```

<big>Afterwards,</big>

```
$dotnet run
```

<big>Now we can double check for errors in our code addressed it by the errors that follow<br>

## Known Bugs
* _Testing is still being done. Will come back with an errors or bugs_

## License
* **SEE LICENSE [HERE](./LICENSE.txt)** 