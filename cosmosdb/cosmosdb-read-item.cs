// First, we need the unique id of the item. Here, we store that id in a variable of the same name.
string id = "027D0B9A-F9D9-4C96-8213-C8546C4AAE71";

// Second, we need to create a variable of type PartitionKey with the string value at the partition key path for the item we are seeking.
string categoryId = "26C74104-40BC-4541-8EF5-9892F7F03D72";
PartitionKey partitionKey = new (categoryId);

// Invoke the asynchronous and generic ReadItemAsync<> method, which will return an item of the given generic type, Product
Product saddle = await container.ReadItemAsync<Product>(id, partitionKey);


// Access properties of the saddle variable and print them to the console much like any local variable
string formattedName = $"New Product [${saddle}]";
Console.WriteLine(formattedName);