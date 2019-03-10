var thrift = require('thrift');
var svc = require('./MyThriftService');
	
const transport = thrift.TBufferedTransport;
const protocol = thrift.TBinaryProtocol;
	
var connection = thrift.createConnection('localhost', 9090, {
		transport : transport,
		protocol : protocol
	});
	
connection.on('error', function(err) {
	  console.log(err);
	});
	
	// // Create a service client with the connection
var client = thrift.createClient(svc,connection);
//console.log(client);

	client.GetSum(1,1, function(err, response) {
	  console.log("1+1=" + response);
	});

	client.GetHelloMessage("Angshuman", function(err, response) {
		console.log(response);
	  });

	  client.OpenWindow("Angshuman", function(err, response) {
		console.log(err);
	  });
	
