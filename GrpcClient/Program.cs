using Grpc.Net.Client;
using GrpcGreetingService; // This should match the namespace in greet.proto

var channel = GrpcChannel.ForAddress("https://localhost:5001");
var client = new Greeter.GreeterClient(channel);
var reply = await client.SayHelloAsync(new HelloRequest { Name = "Arafat" });

Console.WriteLine($"Greeting: {reply.Message}");
