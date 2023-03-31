# hvz-backend
This project is the back-end part of the case at the end of Noroff's Accelerated learning course, Full stack .NET developer.

This project is ASP.net project, where utilize Entity Framework Code First and Swagger and Swashbuckle.

## The Case
The case is to develop a assisting tool for physical game: Humans vs. Zombies. The game is adminstrated by one gamemaster and there is one player which is patient zero and will try to tag the rest of the players and thereby turn them to zombies. 

The Gamemaster can provide areas to be safezones, to give missions or supplies.

The assisting tool should help the gamemaster with the administation, setting up game, the state of the game, state of players and apply safezones, missions and supplies.

The players can join a game, see the state and info of the game, see they location and chat in different chat rooms with the rest of the players.

This tool give admin better control over the game, players can coordinate between each other, thereby giving a better flow in the game.

## The front-end
The repository can be found at: https://github.com/Noroff-assignments/hvz-frontend 

and need to read the corresponding readme to get and understanding for it. But a short resumé:

- JavaScript project
- Bootstrap
- Leaflet module for Google map integration and position
- Pusher module for chat functionality between users
- Keycloak module for handling login/sign in with tokens
- QR code module for generator and scanning

## Deployment
If want to deploy the project with or without the front-end part, there need to be made some changes in the code.

Currently there is used **Azure** for hosting and utilize the **Azure Vault** for storing user secrets. There is also created a **Keycloak** server and a **Pusher** server for chat functionality.

Two option: 
- Change the values to server info of your own
- get it out to make it possible to run local


The needed code to be change lay in Program.cs, Controllers/ChatController.cs and in the "user secrets" json file, which should contain:

- "Pusher:ApiKey"
- "Pusher:ApiId"
- "KeyCloak:KeyURI"
- "KeyCloak:IssuerURI"
- "DefaultConnection"
- "Pusher:Secret"
## Extensions for Visual Studio
- AutoMapper.Extensions.Microsoft 12.0.0
- Azure.Identity 1.8.2
- Azure.Security.KeyVault.Secrets 4.5.0
- Microsoft.AspNet.Mvc 5.2.9
- Microsoft.AspNetCore.Authentiction.JwtBearer 6.0.14
- Microsoft.EntityFrameworkCore.Design 7.0.4
- Microsoft.EntityFrameworkCore.SqlServer 7.0.4
- Microsoft.EntityFrameworkCore.Tools 7.0.4
- Microsoft.Extensions.Configuration.AzureKeyVault 3.1.24
- Microsoft.Extensions.Configuration.UserSecrets 7.0.0
- Microsoft.VisualStudio.Azure.Containers.Tools.Targets 1.17.0
- PusherServer 4.6.1
- Swashbuckle.AspNetCore 6.5.0


## Class Diagram
![Class diagram](https://user-images.githubusercontent.com/15190773/229119622-b832e417-89ce-4fd0-81c3-008f9c9f3813.png)

## Entity Relational diagram - Physical data model

![ERD - Physical data model](https://user-images.githubusercontent.com/15190773/229119646-5428d438-0753-49ac-ae2f-009349d9cd90.png)


