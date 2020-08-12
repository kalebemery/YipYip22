# **YipYip (Blue Badge API Collaborative Project)**
## **Kris Prater, Kaleb Emery, Lisa Jeffers, Austin Hooker**
#### *Software Development Bootcamp @ Eleven Fifty Academy*

The final requirement to earn the Blue Badge for this program was to create an application programming interface (API) of our own design. Our .Net Framework API Web Application provides users the ability to see properties, owners of those properties, and attractions that are in the same area as the respective properties (think Airbnb, Vrbo, etc).
<br />
#### How to install the project locally:
<br />
<i>(This application was built and tested in Visual Studio)</i>
<br />
<br />
1.	Go to https://github.com/kalebemery/YipYip22 
<br />
2.	On this page, make sure you are on the master branch (located directly above the blue box containing the name of the last committed changes)
<br />
3.	Once you know you are on the master branch, click the green box containing “Code” and copy the URL given in the dropdown menu, either by copying the link manually or clicking the clipboard icon. 
<img src="https://user-images.githubusercontent.com/66280480/89951164-e6df7d00-dbf8-11ea-8209-9c967092f45f.png" align="left" width="500" height="180"/>
<br />
<br />
<br />
<br />
<br />
<br />
<br />
4.	Now you can navigate to where you’d like the project to be stored, and open your command prompt. 
<br />
5.	In your command prompt, type “git clone”, put a space after “clone”, then paste the URL you copied from Github. Press enter and the project should clone to your local computer.
<br />
6.	After the project is cloned, if there are build errors then you may have to restore NuGet packages that come along with the project. Another solution may be restarting Visual Studio.
<br />
7.	Once the project is building with no errors, go to the search bar in Visual Studio and click on Tools -> NuGet Package Manager -> Package Manager Console.
<br />
8.	Now, inside the package manager console you must change the Default project to YipYip22.Data (see image below).
<br />
9.	Next, click inside the package manager console and type “update-database” (this will seed the ‘attractions’ table)
<img src="https://user-images.githubusercontent.com/66280480/89951889-383c3c00-dbfa-11ea-8a21-c2b1ad79f50f.png" align="left" width="600" height="120"/>
<br />
<br />
<br />
<br />
<br />
<br />
10.	After the content is seeded, you can now run the API.    
<br />
11.	If the solution builds with an error, clean the solution, rebuild it, and try starting it again.
<br />
------------------------------------------------------------------------------------------------------------------------------------------
<br />
<br />
<b>Using Postman</b>
<br />
<i>(or similar API testing tool)</i>
 <br />
 - Click the "New" button to create a new request.
 <br />
 - Copy the url from the API you are running, and paste it into the request area for Postman.
 <br />
 - To start testing the API, you must first register an account
 <br />
  - To do this, paste the url as mentioned in the step above, then add /api/Account/Register (i.e. http://localhost:44312/api/Account/Register)
  <br />
  - Next, you have to enter the appropriate information into the "Body" of the Post request (make sure the dropdown menu next to the URL reads "Post")
  <br />
  - After clicking on body, click on "x-www-form-urlencoded" just below it and input your information in the given form
  <br />
  The "Key" inputs must be the same as you see in the picture below, the "Value" inputs can differ but must follow input procedures (i.e. email must be written in an email format, Password must have certain amount of characters, etc.)
  <img src="https://user-images.githubusercontent.com/66280480/89943350-0cb25500-dbec-11ea-9726-e85d4ee03006.png" align="left" width="500" height="200"/>
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
  - After you have registered for an account successfully, it is time to get a token for authorization.
  - Change your url and body to look like this "http://localhost:44312/token" (make sure the dropdown next to the URL reads "Post"): 
  <img src="https://user-images.githubusercontent.com/66280480/89945628-a29baf00-dbef-11ea-86e6-5116a0839cf5.png" align="left" width="500" height="200"/>
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
  - Postman should return to you an access token. You have to copy this access token and put it in the Authorization -> Bearer Token text bar given when making a request.
  <img src="https://user-images.githubusercontent.com/66280480/89946677-476abc00-dbf1-11ea-9e4b-854eab1b0257.png" align="left" width="500" height="200"/>
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
   - Now you can populate your tables and test these endpoints. (Order is important: create Profile first, then Owner, then Property) 
   - Don't forget to use your token on each request and make sure you are in the body section when inputing information
<br />
---------------------------------------------------------------------------------------------------------------------------------------------------
<br />
<br />
<b>Order for testing API endpoints</b>
<br />
<br />
1. Profile
<br />
Post a Profile (ProfileName, Phone, Email, Rating)
<br />
<img src="https://user-images.githubusercontent.com/66280480/89949264-a16d8080-dbf5-11ea-99f4-ee93aceffa4b.png" align="left" width="500" height="200"/>
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
2. Owner (*One owner for each profile)
<br />
Post an Owner (ProfileName, Phone, Email, ProfileId)
<br /> *to obtain a Profile Id, you must perform a GET on the Profile url from above
<br />
<img src="https://user-images.githubusercontent.com/66280480/89950094-e6de7d80-dbf6-11ea-8662-cc1bf72438a2.png" align="left" width="500" height="200"/>
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
3. Property
<br />
Post a Property (Title, Address, NumOfBeds, Desc, WeekDayRate, WeekendRate, PropertyLocation, OwnerId)
<br />
*When posting a Property, the attribute PropertyLocation is an enum in our project and must be assigned one of 12 values(you can either write the number or spell out the location):
<img src="https://user-images.githubusercontent.com/66280480/89948374-fe683700-dbf3-11ea-908b-a23653ed05e1.png" align="left" width="500" height="200"/>
<br/>
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<img src="https://user-images.githubusercontent.com/66280480/89950481-ae8b6f00-dbf7-11ea-9d99-4313ce9d4666.png" align="left" width="500" height="250"/>
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<b>Once those entities are created, you can then test the remaining endpoints accordingly</b>: 
<br />
<br />
Property - Get Property (All), Get Property by Id(brings in the attractions that are in the same area), Put Property, Delete Property 
<br />
<br />
	Profile – Get Profile (All), Get Profile by Id, Put Profile
<br />
<br />
	Owner – Get Owner by Id(brings in whatever properties that Owner possesses), Put Owner, Delete Owner
<br />
<br />
	Attractions – Post Attraction, Get Attractions(All), Put Attraction, Delete Attraction
<br />
---------------------------------------------------------------------------------------------------------------------------------------------------
<br />
<b>Additional Resources used</b>: 
<br />
https://dbdiagram.io/d/5f315d0608c7880b65c5bcf3
<br />
https://trello.com/b/HNSxnqHJ/welcome-to-trello
<br />
https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/getting-started-with-ef-using-mvc/creating-a-more-complex-data-model-for-an-asp-net-mvc-application
<br />
https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/enum
<br />
https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions/mvc-music-store/mvc-music-store-part-6
<br />
---------------------------------------------------------------------------------------------------------------------------------------------------
<br />
<b>Project Created by</b>:
<br />
@kalebemery
<br />
@ljeffers0106
<br />
@Kcprater
<br />
@AThooker
