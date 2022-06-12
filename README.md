# ACME coding challenge

## :wave: Welcome!

Here you will find all the details about the **ACME coding challenge** for the candidates who want to join the Winamp Dev Team!

## :blue_book: Summary

The ACME corp. need a web application to manage the stock of their products.

In order to allow the front-end team to develop a wonderful web application, we will need a strong, tested, maintainable and performant back-end API.

## :mag_right: Functional Information

The ACME products have a name, a description, a danger level, a list of pictures, a price in one currency and one universal ID.

The ACME products are stored in Warehouses.

The Warehouses have a maximum capacity of storage, a location and a friendly identifier built as follow: `{country}-{ZIP}-{incremental number of 6 digits}` (e.g: **BE-1070-000001**).

## :hammer_and_wrench: Technical Requirements

- [ ] The code should be a **Fork** of the current Github repository
- [ ] The API should be developed in **.NET 6**
- [ ] The API should expose a **Swagger UI**
- [ ] The API should propose a **paginated** result for each GET
- [ ] The API should be developed in **Domain Driven Design**
- [ ] The API should be **covered by tests** included in the project
- [ ] The API should include logs using **Serilog**
- [ ] The Database should be **PostgreSQL**
- [ ] The Database should be queried using **Entity Framework Core**
- [ ] The whole project should run using a `docker-compose.yml` file (including the database)
- [ ] **EXTRA -** The API should implement a **caching** system to increase the read performances
- [ ] **EXTRA -** The API should be protected by authentication with a **JWT Bearer token**
- [ ] **EXTRA -** The project should embed a basic CI (Build & Test) using the **Github Actions**

## Something is not clear? Any missing information?

It's alright, don't be blocked: you can take assumption to move forward. Let us know why you chose to take this direction. :wink:

# My notes

## Remarks and considerations

- At the current state the application implements and exposes a single endpoint to create a new product resource. Unfortunately I cannot manage to make it write to DB, as the request is affected by the following issue :

>System.InvalidOperationException: An exception has been raised that is likely due to a transient failure.  
---> Npgsql.NpgsqlException (0x80004005): Failed to connect to [::1]:5432  
---> System.Net.Sockets.SocketException (99): Cannot assign requested address  
...

- Being new to DDD, I followed [this reference](https://docs.microsoft.com/en-us/dotnet/architecture/microservices/) by Microsoft.
- the api and the DB container can be run with `docker-compose` (see below)
- the script `\src\Acme.Infrastructure\dbScripts\init.sql` sets up the DB when it's first launched (no seeding though)
- except for `Products`, no other DbSet are declared so far due to lack of time - but at least we see the binding with EF 6 for this entity is working (some shortcuts are still taken, e.g. dangerLevel should be an enum)
- except for some data annotation attributes in the controller's DTO, validation is lacking both in the api as well as in the domain

## Docker commands

### API docker image only

- Build a container for Acme.Api

```console
docker build -t acme.api .
```

- Run docker container for Acme.Api

```console
docker run -it --rm -p 5000:5000 --name acme_api acme.api
```

### API + DB containers

- Run both API and DB image with docker-compose file :

```console
docker-compose -f .\docker-compose.yml up
```
