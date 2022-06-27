saddle.price = 35.00d;
await container.UpsertItemAsync<Product>(saddle);
saddle.tags = new string[] { "brown", "new", "crisp" };

await container.UpsertItemAsync<Product>(saddle);