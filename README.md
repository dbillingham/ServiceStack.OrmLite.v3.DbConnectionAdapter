ServiceStack.OrmLite.v3.DbConnectionAdapter
===========================================

Adapter for ReadConnectionExtensions and WriteConnectionExtensions

#Intro
This is an adapter class that wraps the extension methods within the ReadConnectionExtensions and WriteConnectionExtensions classes.  This makes it easier to mock these extension methods for unit testing purposes.

#How to use
Instead of:

    var db = new OrmLiteConnectionFactory("connectionString").OpenDbConnection();
    
Do:

    var db = new DbConnectionAdapter(new OrmLiteConnectionFactory("connectionString").OpenDbConnection());
    
