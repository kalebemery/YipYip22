# **YipYip (Blue Badge API Collaborative Project)**
## **Kris Prater, Kaleb Emery, Lisa Jeffers, Austin Hooker**
#### *Software Development Bootcamp @ Eleven Fifty Academy*

The final requirement to earn the Blue Badge for this program was to create an application programming interface (API) of our own design.
<br />
Our .Net Framework API Web Application provides users the ability to see properties, owners of those properties, and attractions that are in the same area as the respective properties (think Airbnb, Vrbo, etc).
<br />
#### How to install the project locally:
<br />
(This application was built and tested in Visual Studio)
<br />
<br />
1.	Go to https://github.com/kalebemery/YipYip22 
<br />
2.	On this page, make sure you are on the master branch (located directly above the blue box containing the name of the last committed changes)
<br />
3.	Once you know you are on the master branch, click the green box containing “Code” and copy the URL given in the dropdown menu, either by copying the link manually or clicking the clipboard icon. 
<br />
4.	Now you can navigate to where you’d like the project to be stored, and open your command prompt. 
<br />
5.	In your command prompt, type “git clone”, put a space after “clone”, then paste the URL you copied from Github. Press enter and the project should clone to your local computer.
<br />
6.	After the project is cloned, if there are build errors then you may have to restore NuGet packages that come along with the project. Another solution may be restarting Visual Studio.
<br />
7.	Once the project is building with no errors, go to the search bar in Visual Studio and click on Tools -> NuGet Package Manager -> Package Manager Console.
<br />
8.	Now, inside the package manager console you must change the Default project to YipYip22.Data.
<br />
9.	Next, click inside the package manager console and type “update-database” (this will seed the ‘attractions’ table)
<br />
10.	After the content is seeded, you can now test the endpoints for the API.    
<br />
<br />
-------------------------------------------------------------------------------------------------------
<br />
<br />
--Order for testing API endpoints--
<br />
<br />
Profile
<br />
1.	Post a Profile (ProfileName, Phone, Email, Rating)
<br />
<br />
Owner (*One owner for each profile)
<br />
2.	Post an Owner (ProfileName, Phone, Email, ProfileId)
<br />
<br />
Property
<br />
3.	Post a Property (Title, Address, NumOfBeds, Desc, WeekDayRate, WeekendRate, PropertyLocation, OwnerId)
<br />
<br />
*When posting a Property, the attribute PropertyLocation is an enum in our project and must be assigned one of 12 values: 
<br />
DowntownIndy = 1,
<br />
BroadRipple = 2,
<br />
Speedway = 3,
<br />
Carmel = 4,
<br />
Fishers = 5,
<br />
FountainSquare = 6,
<br />
Plainfield = 7,
<br />
Lawrence = 8,
<br />
BeachGrove = 9,
<br />
Greenwood = 10,
<br />
Avon = 11,
<br />
Brownsburg = 12
<br />
<br />
--Once those entities are created, you can then test the remaining endpoints accordingly: 
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
	Attractions – Post Attraction, Get Attractions(All), Put Attraction, Delete Attraction
<br />
-------------------------------------------------------------------------------------------------------
<br />
Additional Resources used: 
<br />
https://dbdiagram.io/d/5f315d0608c7880b65c5bcf3
<br />
https://trello.com/b/HNSxnqHJ/welcome-to-trello
<br />
https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/getting-started-with-ef-using-mvc/creating-a-more-complex-data-model-for-an-asp-net-mvc-application
<br />
https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/enum<br />
        ------------------------------------------------------------------------------------------------------- <br />
Project Created by:
<br />
@kalebemery
<br />
@ljeffers0106
<br />
@Kcprater
<br />
@AThooker