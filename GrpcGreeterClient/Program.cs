using System.Threading.Tasks;
using Greet;
using Grpc.Net.Client;


// The port number must match the port of the gRPC server.
using var channel = GrpcChannel.ForAddress("http://localhost:5115");
var client = new UserLog.UserLogClient(channel);
var reply = await client.NewUserAsync(
                  new User { Id = 113, Name = "Krishna" , Email = "syrio.forell@gmail.com"});


Console.WriteLine("Greeting: " + reply.Message);
Console.WriteLine("Press any key to exit...");
Console.ReadKey();  