# ArdonaghTask
Simple recruitment task for the Ardonagh Group, by Peter White

## Documentation


1)	All in all, I spent around 4 hours on this - I wanted the back end functionality to be in a similar style to that which I’ve been doing at Good Energy, so it may seem over engineered for the task at hand.
2)	I created the solution as and ASP.NET Core Web App. I’ve actually been doing a lot of work in web forms in my previous job, but that wouldn’t be appropriate for this. I’ve used MVC before, but not for a few years now, as most of the projects I’ve been working on have had React front ends.
3)	I kept things simple, design-wise, opting for basic Bootstrap classes. I wanted the app to look reasonable, but didn’t want to spend too much time on it. The database is an EntityFramework “In Memory” one, so once the context is created, it’s just like a ‘real’ database.  The CustomerService class that sits between the controller and the repo is rather superfluous, but I’ve found some developers really don’t like the controller speaking directly to the repo. It also demonstrates Dependency Inversion.
4)	My biggest difficulty was getting back into CSS and Bootstrap after two years of using Tailwind for styling!
5)	Next steps would be to tidy up the design a little. The popup modal form has the same generic text for both adding and editing a record. It would be nice to customise the title and ‘save’ button text for each mode. Another option would be a more permanent database, probably using SQLITE. I did initially have some hardcoded records in the database, to help when adding the ‘edit’ functionality, but these were later removed as the spec didn’t call for them, and I needed to test it would work without any records. Finally, I’d like to hide the table headers when there is no data, maybe adding a “No records!” message.

