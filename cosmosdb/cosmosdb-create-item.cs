// To create a new item, we must first create a new variable in C# code of the Product type
Product saddle = new()
{
    id = "027D0B9A-F9D9-4C96-8213-C8546C4AAE71",
    categoryId = "26C74104-40BC-4541-8EF5-9892F7F03D72",
    name = "LL Road Seat/Saddle",
    price = 27.12d,
    tags = new string[] 
    {
        "brown",
        "weathered"
    }
};


// Asynchronously invoke the CreateItemAsync<> method passing in the generic Product type and the new item variable into the constructor
try
{
    ItemResponse<Product> response = await container.CreateItemAsync<Product>(saddle);
}
catch (CosmosException ex) when (ex.StatusCode == HttpStatusCode.Conflict)
{
    // Add logic to handle conflicting ids
}
catch (CosmosException ex) 
{
    // Add general exception handling logic
}


// This invocation of the method will create the new item, but you will not have any metadata about the result of the operation. 
// Alternatively, you can store the result of the operation in a variable of type ItemResponse<>.
HttpStatusCode status = response.StatusCode;
double requestUnits = response.RequestCharge;

Product item = response.Resource;

