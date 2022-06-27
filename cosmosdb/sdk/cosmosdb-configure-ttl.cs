[JsonProperty(PropertyName = "ttl", NullValueHandling = NullValueHandling.Ignore)]
public int? ttl { get; set; }
saddle.ttl = 1000;

await container.UpsertItemAsync<Product>(saddle);