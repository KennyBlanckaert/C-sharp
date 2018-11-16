# C-sharp

## 1. Web Service in .NET with MySQL (ADO.NET Entity Framework Model)

* *`Steps Web Service`*
  * Create a new Project (here Web Service Library)
  * Add operations for your service
      * Annotate interface with `ServiceContract`
      * Annotate operation with `OperationContract`
  * Create entity classes
      * Annotate class with `DataContract`
      * Annotate properties with `DataMember`
* *`Two possible implementations`*
  * `Old Implementation`
      * Using MySql.Data.dll classes to open connection, build statements, closing the connection, and more...
      * Own-made entity classes
      * (see "old_way_implementation" folder)
  * `New Implementation`
      * Using **ADO.NET Entity Framework Model**
      * Download **Connector/Net** from MySQL website
      * Add Reference to **MySql.Data**, **MySql.Web**, **MySql.Data.Entity.EF6** and **EntityFramework**
      * (Make sure "<provider invariantName="MySql.Data.MySqlClient" type="MySql.Data.MySqlClient.MySqlProviderServices, MySql.Data.Entity.EF6, Version=6.10.8.0, Culture=neutral, PublicKeyToken=c5687fc88969c44d"></provider>" is added to the App.config file
      * Rebuild Project
      * Right Click > Add > New Item... > ADO.NET Entity Data Model > MySQL Database option
      * (see "new_way_implementation" folder)
  * *To change between these implementations, don't forget to switch Services within the app.config file*
* *`Steps Web Application`*
  * ...
* *`For Testing:`* 
  * Right-click Project > Debug > Start new instance
* *`For Use:`*
  * Create a new Project
  * Right-click project > Add > Service Reference... > Add WSDL
  * Use the instance name (in this case: SchoolService_newClient) to access the operations
