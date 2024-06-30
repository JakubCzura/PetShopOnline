### Simple demo application to show an idea how to implement authentication/authorization in microservices architecture using api gateway.

### Description
The project consists of three microservices: <br>
ApiGateway,<br>
AuthService,<br>
UserService.<br>

The purpose of the implementation is to send requests to ApiGateway that will communicate with AuthService and UserService.

I used Yarp library to create ApiGateway: https://github.com/microsoft/reverse-proxy.

### Examples
How it works? ApiGateway should transform requests for specified microservices.

#### AuthService example:
Request sent to ApiGateway `https://localhost:7202/auth/v1.0/auth/secret` will be forwarded to AuthService as `https://localhost:7170/api/v1.0/auth/secret`.