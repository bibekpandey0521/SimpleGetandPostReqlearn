using Microsoft.Extensions.Primitives;
using System.IO;



var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.Run(async (HttpContext context) =>
//{

//    if (1 == 1)
//    {
//        context.Response.StatusCode = 200;
//    }
//    else
//    {
//        context.Response.StatusCode = 400;
//    }
//    //context.Response.StatusCode = 500;
//    await context.Response.WriteAsync("Hello");
//    await context.Response.WriteAsync("World");





//});

//app.Run(async (HttpContext context) =>
//{

//    //await context.Response.WriteAsync("Hello");
//    context.Response.Headers["MyKey"] = "my Value";
//    context.Response.Headers["Servers"] = "My Server";
//    //context.Response.Headers["Content-Type"] = "text/html";
//    await context.Response.WriteAsync("<h1>Hello</h1>");
//    await context.Response.WriteAsync("World");
//});

//app.Run(async (HttpContext context) =>
//{
//    string path = context.Request.Path;

//    //if(path == "/path1")
//    //{
//    //    context.Response.Headers["Content-Type"] = "text/html";
//    //    await context.Response.WriteAsync($"<p>{path}</p>");
//    //}
//    //else
//    //{
//    //    context.Response.Headers["Content-Type"] = "text/html";
//    //    await context.Response.WriteAsync($"<p>{path}</p>");
//    //}
//    context.Response.Headers["Content-Type"] = "text/html";
//    await context.Response.WriteAsync($"<p>{path}</p>");
//});

//app.Run(async (HttpContext context) =>
//{
//    string path = context.Request.Path;
//    string method = context.Request.Method;



//if(method == "GET")
//{

//}
//else
//{

//}



//    context.Response.Headers["Content-Type"] = "text/html";
//    await context.Response.WriteAsync($"<p>{path}</p>");
//    await context.Response.WriteAsync($"<p>{method}</p>");
//});

//app.Run(async (HttpContext context) => {

//    context.Response.Headers["Content-type"] = "text/html";
//    if(context.Request.Method == "GET")
//    {
//        if (context.Request.Query.ContainsKey("id"))
//        {
//           string id =  context.Request.Query["id"];
//            await context.Response.WriteAsync($"<p>{id}</p>");
//        }
//    }
//context.Response.Headers["Content-type"] = "text/html";

//});

//app.Run(async (HttpContext context) =>
//{
//    context.Response.Headers["Content-type"] = "text/html";

//    if (context.Request.Headers.ContainsKey("User-Agent"))
//    {
//        string userAgent = context.Request.Headers["User-Agent"];
//        await context.Response.WriteAsync($"<p>{userAgent}</p>");
//    }
//});


//app.Run(async (HttpContext context) =>
//{
//    context.Response.Headers["Content-type"] = "text/html";
//    if (context.Request.Headers.ContainsKey("AuthorizationKey"))
//    {
//        string auth = context.Request.Headers["AuthorizationKey"];
//        await context.Response.WriteAsync($"<p>{auth}</p>");
//    }
//});

app.Run(async (HttpContext context) => {
    StreamReader reader = new StreamReader(context.Request.Body);
    string body = await reader.ReadToEndAsync();

    Dictionary<string,StringValues> queryDict = Microsoft.AspNetCore.WebUtilities.QueryHelpers.ParseQuery(body);

    if (queryDict.ContainsKey("firstName")) 
    {
        string firstName = queryDict["firstName"][0];
        await context.Response.WriteAsync(firstName);
        //foreach(var item in queryDict["firstName"])
        //{

        //}
    }
});

app.Run();
