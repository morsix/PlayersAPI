# PlayersWebApp Demo

You can see the live demo of the application [live demo](http://tight-knowledge.surge.sh/)

This project is hosted on [surge](https://surge.sh/)
The API this application consumes is hosted on [Azure](https://playersapi20190603104754.azurewebsites.net/api/values) (pointing to the values controller) 

# PlayersApi
This is a .Net Core 2.1 Web API project. It contains server-side pagination and filtering for a list of football players.

Third-party:

- Entity Framework Core
- Automapper
- XUnit
- Moq


# How to run locally

- clone this repo
- open in Visual Studio 2017 by double clicking on the solution file.
- run on IIS Express(which should be available in Visual Studio)

# Important
The default port for Angular is :4200 and the dafult port for the .NET CORE API is :44316. If you're using diffrent ports make sure to configure both the applications like this:

- change the API_URL in Angular ('players.service.ts') to match the port of the API

```
private readonly API_URL = 'https://localhost:44316/api/';

```

- change the link in Startup.cs to match the port angular is running on

```
builder => builder.WithOrigins("http://localhost:4200")
                                .AllowAnyHeader()
                                .AllowAnyMethod());
```





