
using Google.Protobuf.WellKnownTypes;
using Greet;
using Grpc.Core;
using GrpcGreeter;

namespace GrpcGreeter.Services;

public class GreeterService : UserLog.UserLogBase
{
    private readonly ILogger<GreeterService> _logger;
    public GreeterService(ILogger<GreeterService> logger)
    {
        _logger = logger;
    }

   /* public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
    {
        Console.WriteLine("SayHello() method called..");
        Console.WriteLine(request.Name);    
        return Task.FromResult(new HelloReply
        {
            Message = "Hey yo, " + request.Name
        });
    }*/

    public override Task<Response> NewUser(User user,ServerCallContext context)
    {
        Console.WriteLine("Inside new user method.");
        Console.WriteLine("User: "+user.Name);
        Console.WriteLine("email: " + user.Email);
        return Task.FromResult(new Response
        {
            Message = $"new user with id: {user.Id} received."
        });

    }

}


//syntax = "proto3";

//package greet;

//// The greeting service definition.
//service Greeter
//{
//    // Sends a greeting
//    rpc SayHello (HelloRequest) returns (HelloReply);
//}

//// The request message containing the user's name.
//message HelloRequest
//{
//  string name = 1;
//}

//// The response message containing the greetings
//message HelloReply
//{
//  string message = 1;
//}


//syntax = "proto3";

//option csharp_namespace = "GrpcGreeter";

//package greetoo;

//// The greeting service definition.
//service Greetere
//{
//    // Sends a greeting
//    rpc SayHello (HelloRequest) returns (HelloReply);
//}

//// The request message containing the user's name.
//message HelloRequest
//{
//  string name = 1;
//}

//// The response message containing the greetings.
//message HelloReply
//{
//  string message = 1;
//}
