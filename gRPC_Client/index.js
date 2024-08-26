var PROTO_PATH = __dirname + '/protos/helloWorld.proto';

var parseArgs = require('minimist');
var grpc = require('@grpc/grpc-js');
var protoLoader = require('@grpc/proto-loader');
var packageDefinition = protoLoader.loadSync(
    PROTO_PATH,{});
var hello_proto = grpc.loadPackageDefinition(packageDefinition);

 function  main() {
  target = 'localhost:5115';

  var client =  new hello_proto.greet.UserLog(target,
                                       grpc.credentials.createInsecure());
  var user = "Krishna Pravesh"

   client.NewUser({id:1, name:"from js", email : "wick@gmail.com"}, function(err, response) {
      console.log(response.message);
     
  });

}
main();






























