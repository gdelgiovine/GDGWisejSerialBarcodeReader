This is a simple barcode reader application built using Wisej and the Web Serial API. 
It allows you to connect to a barcode scanner that supports the Web Serial API and read barcodes directly into the application.

The JavaScript code for the barcode reader is based on the Web Serial Barcode Scanner project by Niels Leenheer, 
which can be found on GitHub at the following link:
https://github.com/NielsLeenheer/WebSerialBarcodeScanner

To use this application, simply run it in a Wisej environment and click the "Connect" button to establish a connection with your barcode scanner.	
Once connected, you can start scanning barcodes, and the scanned data will be displayed in the application.
Please note that the Web Serial API is currently supported in modern browsers, so make sure to use a compatible browser for this application to work properly.	
The application is designed to be simple and easy to use, making it a convenient tool for reading barcodes in various scenarios, such as inventory management, retail, or any other situation where barcode scanning is required.
Feel free to customize and enhance the application according to your needs, and don't hesitate to explore the Web Serial API documentation for more advanced features and capabilities.
For more information on the Web Serial API and how to use it, you can refer to the official documentation provided by Mozilla:
https://developer.mozilla.org/en-US/docs/Web/API/Web_Serial_API

The tester application is written in VB.NET so the VB devs can understand the use of user control in a familiar way. The C# devs can easely migrate di tester app to C#. 
The user control source code can be used to understand the way the Wisej.NET architecture allows .NET server side code and Client Side JavaScript code can cooperate and how Wisej.NET allow to extend any control with JavaScript functions.

This application is a great starting point for anyone looking to integrate barcode scanning functionality into their Wisej applications using the Web Serial API.
License is MIT, so you are free to use, modify, and distribute the code as needed.
Only requirement is to give credit to the original author, Me (Gabriele Del Giovine) for the Wisej integration and Niels Leenheer, for the JavaScript code used in this application.

Feel free to reach out if you have any questions or need further assistance with this application. Happy coding!	
