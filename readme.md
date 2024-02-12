# How to run

## Prerequisites
- Docker
- .NET 8 SDK

### How to build
- docker build -t backend-challenge .

### How to run
- docker run -d -p 8080:80 --name myapp backend-challenge

### How to stop
- docker container stop myapp