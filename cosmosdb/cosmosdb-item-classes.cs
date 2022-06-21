// At the most foundational level, you can create a C# class that represents an item in your container that, at a minimum, contains two members
public class item
{
    public string id { get; set; }

    public string partitionKey { get; set; }
}


// You can include a rich collection of other members of other types.
public decimal money { get; set;}

public bool boolean { get; set; }

public string[] set { get; set; }

public double numbers { get; set; }

public int morenumbers { get; set; }

public ComplexClass sophisticated { get; set;}

public List<ComplexType> onetomany { get; set; }


// sample item
public class Product
{
    public string id { get; set; }
    
    public string name { get; set; }

    public string categoryId { get; set; }

    public double price { get; set; }

    public string[] tags { get; set; }
}

[JsonProperty(PropertyName = "id")]
public string InternalId { get; set; }