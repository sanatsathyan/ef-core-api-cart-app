Commands run for installation of Packages:
`dotnet add package Microsoft.EntityFrameworkCore.Tools -v 3.1.0`
`dotnet add package Microsoft.EntityFrameworkCore.SqlServer -v 3.1.0`
===========================================================================================================================

To use dotnet ef scaffolding command, dotnet-ef must be installed globally using the following command
`dotnet tool install --global dotnet-ef --version 3.0.0`
===========================================================================================================================

Command to do ef scaffolding
`dotnet ef dbcontext scaffold "Data Source=localhost;Initial Catalog=sampledatabase;Integrated Security=True" Microsoft.EntityFrameworkCore.SqlServer -o Models`
===========================================================================================================================
