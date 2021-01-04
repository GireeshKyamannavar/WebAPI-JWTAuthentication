# WebAPI JSON Web Token Authentication
Implementing JWT authentication in Web API using .NET 5

Step 1: To create a new ASP.Net Core Web API application, I will use Visual Studio 2019. After opening Visual Studio 2019, I will click on “Create a new project” option.
 
 ![](https://github.com/GireeshKyamannavar/WebAPI-JWTAuthentication/blob/main/Pictures/Picture1.png)

Step 2: Create SecretKey and configure in AppSettings.
 
 ![](https://github.com/GireeshKyamannavar/WebAPI-JWTAuthentication/blob/main/Pictures/Picture2.png)

Step 3: Install Microsoft.AspNetCore.Authentication.Jwt Package from nuget.
 
 ![](https://github.com/GireeshKyamannavar/WebAPI-JWTAuthentication/blob/main/Pictures/Picture3.png)

Step 4: Add app.UseAuthentication() below app.UseRouting() in Startup.cs
 
 ![](https://github.com/GireeshKyamannavar/WebAPI-JWTAuthentication/blob/main/Pictures/Picture4.png)
 
Step 5:  Add services.AddAuthentication in Startup.cs
 
 ![](https://github.com/GireeshKyamannavar/WebAPI-JWTAuthentication/blob/main/Pictures/Picture5.png)
 
Step 6: Generate Token using user credentials.
 
![](https://github.com/GireeshKyamannavar/WebAPI-JWTAuthentication/blob/main/Pictures/Picture6.png)

Step 7: Add [Authorize] in Controller
 
![](https://github.com/GireeshKyamannavar/WebAPI-JWTAuthentication/blob/main/Pictures/Picture7.png)

Step 8: Check the API with token.
  
![](https://github.com/GireeshKyamannavar/WebAPI-JWTAuthentication/blob/main/Pictures/Picture8.png)

Step 9: Generate token using login api.
 
![](https://github.com/GireeshKyamannavar/WebAPI-JWTAuthentication/blob/main/Pictures/Picture9.png)

Step 10: Check API able to access using bearer token.
 
![](https://github.com/GireeshKyamannavar/WebAPI-JWTAuthentication/blob/main/Pictures/Picture10.png)
