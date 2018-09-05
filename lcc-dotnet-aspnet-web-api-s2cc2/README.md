
# Building Services with ASP.NET Web API Local Code Challenges

## Current Challenge

In this challenge, you'll configure a default route for the Issue Tracker API.

### Tasks

Here are the tasks that you need to complete for this code challenge. If you get stuck completing any of these tasks, see below for a list of detailed tasks.

* Configure a default route named "DefaultApi"
* For the route template, define three segments
  * For the first segment, use the literal string "api"
  * For the second segment, define a route parameter named "controller"
  * And for the third segment, define a route parameter named "id"
* Configure the `id` route parameter to be optional

## Project Overview

As you complete the code challenges in this course, you'll be working on a simple API for creating, reading, updating, and deleting user issues. When completed, this API could be used as the back-end for a simple issue tracker client.

The provided Visual Studio solution includes an empty ASP.NET project, a shared class library project, and a test project. The shared class library project contains Entity Framework related classes (repository, database context, database initializer, and two model classes) to enable data persistence. The test project contains a collection of unit tests that will verify if your code implements all of the necessary requirements for each code challenge.

__Note: When opening the Visual Studio solution for the first time, you'll be prompted with a security warning, for each project. Visual Studio does this to ensure that you're aware of the risks of executing code from untrusted sources. Go ahead and click the "OK" button to continue with opening the project.__

## Getting Started

Once you've downloaded the files for the code challenge, extract the ZIP file, and open into Visual Studio 2017 the [IssueTracker.sln](src/IssueTracker.sln) file located in the "src" folder.

Each code challenge will include instructions listing the specific tasks that you need to complete. To help determine when you've successfully completed all of the tasks, you can use Visual Studio's Test Explorer window to run all of the provided unit tests. If all of the tests pass, you're ready to upload your solution! If a one or more tests fail, review the error messages for hints on how you can resolve the issues.

Some of the challenges are purely setup or configuration related, so there won't necessarily be something that you easily manually test by debugging the application. For those challenges, you'll have to rely solely upon the provided unit tests to check if you've successfully completed all of the required tasks. Other challenges will have you adding a controller or adding/updating action methods. For those challenges, you can manually debug the application using a browser or a tool like [Postman](https://www.getpostman.com/), in addition to running the provided unit tests.

As a convenience, the root of the "IssueTracker" ASP.NET project contains a [gulp script](https://gulpjs.com/) that you can run using Visual Studio's Task Runner Explorer window. The gulp script contains a "default" task that will restore NuGet packages (if necessary), build the solution, run the unit tests, and if all of the tests pass, create a ZIP file of your solution. You'll find the "project.zip" file in the root folder (the folder that contains the README.md file). Upload this file when you're ready to complete the challenge.

## Detailed Tasks

Before referring to these detailed tasks, you should try to complete the code challenge using the above list of less detailed tasks. Doing that will help increase your retention of the material. If you do get stuck, this list of detailed tasks should help to clarify what needs to be done in order to complete the code challenge. **You've got this!**

* In the WebApiConfig class' `Register` method, call the `HttpConfiguration.Routes.MapHttpRoute` method to configure a default route named "DefaultApi"
* For the route template, define three segments
  * For the first segment, use the literal string "api"
  * For the second segment, define a route parameter named "controller"
  * And for the third segment, define a route parameter named "id"
  * The completed route template will look like "api/{controller}/{id}"
* Configure the `id` route parameter to be optional
  * To do this, set the `HttpConfiguration.Routes.MapHttpRoute` method's `defaults` parameter to an anonymous object with an `id` property set to the value `RouteParameter.Optional`
