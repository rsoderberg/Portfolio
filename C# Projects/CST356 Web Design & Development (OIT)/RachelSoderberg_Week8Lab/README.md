### CST356 Week 8 Lab - Rachel Soderberg  
#### In this lab you will incorporate the week 5 (with database and unit tests) lab work into a new MVC application that includes application users who can register and login to your application.  
##### Exercise 1  
###### 1. Create a new MVC application that includes individual user authentication. When creating the new application, choose the Visual Studio template that creates a sample (not empty) MVC application. Make sure the dialog shows that you are including individual authentication.  
###### 2. You'll probably want to name the application the same as your previous one so that you won't have to worry about namespace renaming in your new application when you copy files from your previous application.  
###### 3. Run the application and test it out by registering 1 or 2 users and logging in with their credentials. You may want to change the name of the applications database in the Web.config file before you run it. This is not necessary but makes it a bit easier to find the new application's database in VIsual Studio's SQL Server Object Explorer. To do this change both "AttachDbName" and "Initial Catalog".  
###### 4. Now explore the user related tables that were created in the applications database.  
  
##### Exercise 2  
###### 1. Start migrating your previous application to this new application by copying files from your previous application. This includes the models (entity and view) for just your second entity (person, group. pet, etc.) and not the user entity. This also includes the views and controllers related to your second entity. Keep the new models, views and controllers that were created in the new application. You can overwrite the Home controller and associated views created in the new application with the ones from your previous application. If you have other folders (data, services, etc.) don't forget to copy them over as well.  
###### 2. Remember to include the copied files into your solution after you copy them. Click on the project folder in Visual Studio, click on the "Show All Files" icon at the top of the Solution Explorer. You should see the copied files displayed. Right click on them and select "Include in Project". After you are finished with including them you can click on "Show All Files" again to hide files that you are not going to include.  
###### 3. Build your application. It should build successfully now. If you did not name your application the same, then you'll probably have some build errors involving namespaces. Let me know if you need help getting your application to build at this point.  
###### 4. Run the application and view the home page. You'll notice that you are missing the links in the navigation bar to your previous applications functions. Fixing that comes next.  
  
##### Exercise 3  
###### 1. You might want to start a second Visual Studio to view your previous application's files. This will allow you to copy and paste pieces of code from the previous application to the new one. Another way to do this is to view the previous application's code from GitHub in a browser and copy from there.  
###### 2. Open the shared layout page in your application and remove the links to About and Contact. An alternative would be to add those to the previous application's Home controller if you wish.  
###### 3. Add a link to the list view for your entity (person, group. pet, etc.) you copied from your previous application.  
###### 4. Run the application and make sure you can see the entity link.  
###### 5. Click on one of the entity link and see what happens. You'll probably get a page with the error: "No parameterless constructor defined for this object.". This is because we are using dependency injection for the controllers. Let me know if you don't see this error and need to know why. You'll now need to add SimpleInjector to your project (assuming you've done this for your previous application in an earlier lab.  
###### 6. Add the NuGet packages: SimpleInjector and SimpleInjector.Integration.Web.Mvc to your project.  
###### 7. Copy the dependency configuration code from your previous application and include it in your new application's solution. Add a call (or copy from your previous application) to your dependency injection code's setup/configuration method in your Global.asax.cs file. You'll need to add a using statement in that file as well.  
###### 8. Remove the constructors in the AccountController and the ManageController that have parameters.  
###### 9. Build and run the application. Click on one of your application functions in the navigation bar. Chances are you'll see a database/datacontext related error. We'll fix that next.  
  
##### Exercise 4  
###### 1. Copy the entity (person, group. pet, etc.) collections (look for items defined as DbSet) from your DatabaseContext source file to the source file named IdentityModels.cs under the Models folder. They will become properties of the ApplicationDbContext class. Rename the ApplicationDbContext to what you named your context before. You'll need to rename the constructor for the class and references in the static create method as well.  
###### 2. Remove the original database context source file if you had copied it from the previous application.  
###### 3. Build the application. You'll probably find a couple of more places you'll need to change the name of the context.  
###### 4. Add the following method to the DbContext class in Models/IdentityModels.cs. You'll find this method in the Week8_WebApp1 example on the class GitHub repo if you want to copy it from there.  
###### 		protected override void OnModelCreating(DbModelBuilder modelBuilder)  
###### 		{  
###### 			Database.SetInitializer(new AppDbInitializer());  
###### 			base.OnModelCreating(modelBuilder);  
###### 		}  
###### 5. Add the following class to the Models/IndentityModels.cs.  
###### 		public class AppDbInitializer : DropCreateDatabaseIfModelChanges<AppDbContext>  
###### 		{  
###### 			// intentionally left blank  
###### 		}  
###### 6. Build and run the application. You should now be able to click on your functions and they should work as before. Let me know if you run into problems here.  
  
##### Exercise 5  
###### 1. Open the file _LoginPartial.cshtml under Views/Shared. Find the conditional Razor code that renders part of the view only if the user is authenticated (logged in). Use that same conditional logic to display your entity link in the navigation bar only if the user is authenticated. You'll need to include the same "using" statement found at the top of the partial in the layout page where your function links are located.  
###### 2. Build and run the application. You should now only see the links to your functions after your login as an application user.  
###### 3. Make sure the links still work after your login.  
###### 4. Now log out and attempt to get to one of your functions by using the corresponding URL. Are you able to get to the function? We need to prohibit that.  
###### 5. Edit the controllers for all your application functions that should only be accessed by an authenticated user. Add the [Authorize] attribute to just above the class name like this:  
###### 		[Authorize]  
###### 		class PetController  
###### 6. Build and start the application. Try to go to the application functions by using the corresponding URLs. Now where do you end up? Hopefully, on the login page. Where do you end up after you successfully login? Hopefully, on the page your attempted to go to using the URL.  
  
##### Exercise 6  
###### 1. Attempt to create a user with a password that does not match the applications password policy. What does the application display?  
When I attempt to create a user with a password that does not match the application's password policy, I receive several errors depending on the input:  
- The Password must be at least 6 characters long.  
- Passwords must have at least one non letter or digit character.  
- Passwords must have at least one digit ('0'-'9').  
- Passwords must have at least one uppercase ('A'-'Z').  
###### 2. Change the password content policy so something other than what the template created. Hint: Look at the App_Start/IdentityConfig.cs file. You'll also need to change the client-side validation. Hint: Look for the model that holds the user's registration information.  
###### 3. Change the lockout policy (tries and/or wait time) and test.  
###### 4. Create a situation where the user is locked out. Find in the database where the application stores this information.  
  
##### Exercise 7  
###### 1. Move the unit tests to the new project.  
  
##### Exercise 8 (Extra Credit)  
###### 1. Create a couple more application users if you only have one. Login with one of them and create one of your entities (person, group. pet, etc.).  
###### 2. Logout and login with one of the other users you created. View the list of entities that match the entity you created in step one of this exercise. What do you see? Hopefully, the entity the other person created.  
###### 3. We don't want each user to see the other users' entities. Add the ability for your application to only display the entities for the logged in (authenticated) user. Look at Week8_WebApp1 to see how it is done there.  
