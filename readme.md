# How to run

## Prerequisites
- Docker
- .NET 8 SDK

### How to build
- docker build -t backend-challenge .

### How to run
- docker-compose build
- docker-compose up

### How to stop
- docker container stop myapp

### Connecting to the Postgres DB within docker image
- docker exec -it {container_id} psql -U myuser -d mydatabase
    - example: docker exec -it 0583d60c3664 psql -U myuser -d mydatabase
    - notice that that 'myuser' and 'mydatabase' shouldn't change in this command
    - you can check the 'clientes' table content by running: `SELECT * FROM clientes;
    - 5 clientes should be there

### Localhost DB setup