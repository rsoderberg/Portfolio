### CST356 Lab 3 - Rachel Soderberg  
### (Built on top of Lab 2)  
##### Exercise 1  
###### 1. Create a new MVC project like you have done before in the previous labs.   
###### 2. Add the EntityFramework NuGet package to the newly created project.  
###### 3. Create a project folder named "Data" and then a folder under "Data" named "Entities".  
###### 4. Create a "User" entity under the "Entities" folder with an int property named "Id" that has an attribute of [Key]. What does the [Key] attribute tell Entity Framework?  
The key attribute tells Entity Framework that the property is the primary key in the database.  
###### 5. Add a class under your "Data" folder that inherits from DbContext.  
###### 6. Add a DbSet collection to the new DbContext class for the "User" entity.  
###### 7. Configure a connection string for your database in web.config. What are connection strings used for?  
The connection strings are used to specify a LocalDB database with the name given (in this case AppDbContext).  
###### 8. Create actions and corresponding views for listing and creating Users as you did in the last lab.  
###### 9. Use your DbContext class to retrieve and add Users in the actions.  
###### 10. Run the application and make sure it functions as expected. Add Users and view them in the list.  
###### 11. Open "Server Explorer" in Visual Studio and view the "User" table created by the EntityFramework.  
###### 12. Add another property to your User entity.  
###### 13. Rerun the application. Look for the newly created property in the "User" table using "Server Explorer".  
###### 14. The Users you added in step 10 are now gone. Why did they disappear?  
The Users added in step 10 are gone because the table had to be recreated to show the newly added column and we did not migrate the data to the new schema.  
  
##### Exercise 2  
###### 1. Add a UserViewModel. Use the view model in place of the User entity model in your User actions and views. Why would we use view models rather than the entity models in the controllers and views? Why would we use view models rather than the entity models in the controllers and views?  
We use view models instead of the entity models in the controllers and views because we want to maintain a separation of concerns (SOLID) and the controller should be kept lightweight.  
###### 2. Feel free to copy the "Map" utility functions from the Week 4 example app.  
###### 3. Run the application to make sure it is still functioning as expected.  
###### 4. Implement the Details, Delete and Edit functions that are accessible at the end of each User in the User list.  
  
##### Exercise 3  
###### 1. Add another entity to your application that is "related" to the User entity. Remember to add a DbSet collection for your new entity to your DbContext class.  
###### 2. In the User list view, add another action for viewing a list of the new entity you added.  
###### 3. Create actions and corresponding views for listing and creating your new entity. Use view models rather than interacting in directly with the new entity model.  
###### 4. Run the application:  
######      a. Test to see if you can access the list for your new entity from the User list.  
######      b. Test to see if you can create an instance of your new entity from the list for your new entity.  
  
##### Exercise 4 (Extra Credit)  
###### 1. Implement the Details, Delete and Edit function for your new entity.  