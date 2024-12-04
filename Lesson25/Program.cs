using CsvHelper;
using CsvHelper.Configuration;
using Lesson25;
using System.Globalization;

//List<Person> list = new List<Person>();
//list.Add(new Person() { Name = "Ivan", Age = 23 });
//list.Add(new Person() { Name = "Serge", Age = 19 });
//list.Add(new Person() { Name = "Mike", Age = 27 });
//list.Add(new Person() { Name = "Semen", Age = 33 });
//StreamWriter writer = new StreamWriter("output.csv");
//CsvWriter csvWriter = new CsvWriter(writer,
//    new CsvConfiguration(CultureInfo.InvariantCulture)
//    {
//        Delimiter= ";",
//        HasHeaderRecord=false,
//        HeaderValidated=null
//    });
//csvWriter.WriteRecords(list);
//writer.Close();

StreamReader reader = new StreamReader("output.csv");
CsvReader csvReader = new CsvReader(reader,
    new CsvConfiguration(CultureInfo.InvariantCulture)
    {
        Delimiter = ";",
        HasHeaderRecord = false,
        HeaderValidated = null
    });
        List < Person> records = csvReader.GetRecords<Person>().ToList();
reader.Close();
foreach (Person record in records)
{
    Console.WriteLine("Name:" + record.Name + " Age:" + record.Age);
}
