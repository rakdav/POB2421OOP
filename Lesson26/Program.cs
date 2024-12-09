using Lesson26;
using System.Xml.Serialization;
Product product1 = new Product()
{
    Name = "Хлеб",
    Category="Белый",
    Period=8,
    Manufactorer="Хлебпром",
    Price=40
};
Product product2 = new Product()
{
    Name="Молоко",
    Category="15%",
    Period=5,
    Manufactorer="Молокозавод",
    Price=39
};
Product product3 = new Product()
{
    Name = "Сметана",
    Category = "20%",
    Period = 10,
    Manufactorer = "Молокозавод",
    Price = 75
};
List<Product> products = new List<Product>();
products.Add(product1);
products.Add(product2);
products.Add(product3);
XmlSerializer xmlSerializer = 
    new XmlSerializer(typeof(List<Product>));
FileStream stream = new FileStream("products.xml",
    FileMode.Create);
xmlSerializer.Serialize(stream, products);
stream.Close();
