using System.Net;
using System.Text;
HttpListener server = new HttpListener();
server.Prefixes.Add("http://192.168.10.94:8888/connection/");
server.Start();
while (true)
{
    var context = await server.GetContextAsync();
    var response = context.Response;
    string responseText = @"<!DOCTYPE html>
<html>
<head>
    <title> Моя первая веб-страница</title>
    <meta charset='utf-8'>
</head>
<body>
    <h1>Добро пожаловать на мою первую веб-страницу!</h1>
    <p>Это пример простого HTML-документа.</p>
</body>
</html>";
    byte[] buffer = Encoding.UTF8.GetBytes(responseText);
    response.ContentLength64 = buffer.Length;
    response.ContentType = "text/html";
    response.ContentEncoding = Encoding.UTF8;
    using Stream output = response.OutputStream;
    await output.WriteAsync(buffer);
    await output.FlushAsync();
    Console.WriteLine("Запрос обработан");
}
server.Stop();

