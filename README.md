# ApacheThriftWithWPFAndNodeJS
This is a very naive example of an Apache Thrift server running inside a WPF app accessed using a Node based Javascript Client. But, it works fine for my purpose !

### How to build the C# based Thrift server
- Step 1: Install NuGet Package for the C# library 
	- `Install-Package ApacheThrift -Version 0.12.0`
- Step 2: Generate the C# class using the Thrift `IDL` file (`ServiceContract.thrift`)
	- `thrift-0.12.0.exe --gen csharp ThriftService.thrift`
	- Add the geenrated C# file called `MyThriftService.cs` to the WPF solution
	- Implement the `ThriftServiceHandler` and build the solution.
	- Run the server by doing `F5` on the VS editor

### How to Build the Node based Javascript Thrift client 
- Use the same IDL file (`ServiceContract.thrift`) to generate a node based JS file
- Run this command (notice the `js:node` language option) - `thrift-0.12.0.exe --gen js:node ServiceContract.thrift`
- This will generate a Javascript file (under `gen-nodejs` folder) which we will use for our JS client. Copy the files in the same location as of `client.js` file
- `npm install thrift` and use in your `client.js` file
- Run the client by typing  `node client.js` on the command line from the folder path of  `client.js`.
- In our example, you should see the output on the console as well as a new Window getting created via the Thrift server running inside the WPF app. 

