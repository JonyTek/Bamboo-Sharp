BambooSharp
===========

A C# wrapper for the Atlassian Bamboo REST API.

This repo is a work in progress. Currently only base functionality has been implemented.

If you feel that this Api could be of use then please contribute.

Contact: jonathontek@gmail.com

PM> Install-Package Bamboo.Sharp

```csharp
var api = new BambooApi("http://192.168.56.1:8085/rest/api/latest", "username", "password");
//create an instance of the Api

var projects = api.GetService<ProjectService>().GetProjects();
//Get a Projects object that contains all projects

var user = api.GetService<CurrentUserService>().GetUser();
//Get a User object