# BlazorCRUD.NetCore


I hope this message finds you well. As requested, please find below the complete instructions for setting up and running your .NET program with Blazor and multi-layer architecture, along with a SQL Server database to store data.

### Prerequisites 
Before getting started, please ensure that the following prerequisites are met:
- Visual Studio 2022
- .NET Core SDK 7
- SQL Server 2019

### Clone the repository: 
Clone the repository from the GitHub link provided in the readme.md file and extract it to a folder of your choice.

### Open the solution: 
Navigate to the extracted folder and open the solution file using Visual Studio.

### Build the solution: 
Once the solution is opened, build the solution by selecting `Build Solution` option under `Build` menu.

Configure the database connection string: Open the `appsettings.json` file and update the ConnectionStrings section with your SQL Server credentials.


```bash
{ "ConnectionStrings": { "DefaultConnection": "Server=<ServerName>;Database=<DatabaseName>;User Id=<Username>;Password=<Password>;" } } 
```

### Run the migrations: 
Open the Package Manager Console and run the following command to apply the database migrations:
  
  
```bash
add-migration <Name>  => add-migration init
```
```bash
Update-Database 
```

### Run the application: 
Press `F5` or click on the `Start` button to run the application. Your .NET program with Blazor and multi-layer architecture, along with a SQL Server database to store data, should now be up and running.


## 🛠 Skills
ASP.Net Core 7, Blazor Web Assembly, SQL Server 2019, HTML, CSS, Bootstrap ,...

### More Details
- In case you face any issues or have any questions, feel free to reach out to us.


- I hope you found the aforementioned instructions helpful. In addition to the steps mentioned earlier, I have also included some additional information that might   be useful for you:

- he solution consists of multiple projects, each serving a specific purpose. The Project.Core project contains all the business logic and domain models. The         Project.Infrastructure project contains all the data access logic and repositories. The Project.WebUI project contains all the UI logic using Blazor.

- The solution is designed using multi-layer architecture, which has the benefit of separating concerns and promoting better code organization. This will make it     easier for future developers to maintain and scale the application, as well as make testing and debugging more efficient.

- The SQL Server database is used to store all application data. It's important to note that in order to use SQL Server with the application, you must have SQL       Server installed on your machine. If you don't already have SQL Server, you can download it from the Microsoft website.

### Authors
-[@Saeed Rajabi](https://github.com/ArkaSoftwareTeam/BlazorCRUD.NetCore)
