# A simple REST API with C#

This project was created based on amazing tutorial by Julio Casal
The tutorial can be watched on link below:
https://www.youtube.com/watch?v=ZXdFisA_hOY

It's really a wonderfull tutorial!!!

## :milky_way: The journey

#### :baby: Entity, Repository, Controller GET
- [X] Introduction
- [X] Adding an entity
- [X] Ading an in-memory repository
- [X] Creating the controller
- [X] Implemeting GET all items
- [X] Implemeting GET single item
- [X] Returning a 404 NotFound status code

#### :child: Dependency Injection, DTOSs
- [X] Introduction
- [X] What is dependency injection?
- [X] Extracting the repository interface
- [X] Injecting the repository into the controller
- [X] Registering the repository as a singleton
- [X] Adding a Data Transfer Object DTO
- [X] Creating the AsDto extension method

#### :boy: POST, PUT, DELETE
- [X] Introduction
- [X] Implementing POST
- [X] Adding validations via data annotations
- [X] Implemeting PUT
- [X] Implementing DELETE

#### :adult: Persisting Entities with MongoDB
- [ ] Introduction
- [ ] Using Postman
- [ ] Creating a MongoDB repository
- [ ] Using the MongoDB.Driver NuGet package
- [ ] Implementing MongoDB Create
- [ ] Running the MongoDB Docker container
- [ ] Configuring MongoDB connection settings
- [ ] Registering the MongoClient singleton
- [ ] Testing the MongoDB integration
- [ ] Exploring the created database in VS Code
- [ ] Implemeting MongoDB Get, Update and Delete

#### :bearded_person: Tasks, Async and Await
- [ ] Introduction
- [ ] Using the Async suffix
- [ ] Using tasks in the repository
- [ ] Using async and await
- [ ] Returning completed tasks
- [ ] Using tasks in the controller
- [ ] Testing async methods in Postman

#### :white_haired_man: Secrets and Health Checks
- [ ] Introduction
- [ ] Enabling authentication in MongoDB
- [ ] Using the .NET Secret Manager
- [ ] Using the MongoDB credentials in the service
- [ ] Introduction to Health Checks
- [ ] Adding an endpoint for health checks
- [ ] Adding a MongoDB health check
- [ ] Adding checks for readiness and liveness
- [ ] Customizing the health check response
- [ ] Exploring other health check NuGet packages

#### :older_adult: Docker
- [ ] Introduction
- [ ] What is Docker?
- [ ] Removing https redirection
- [ ] Generating a Dockerfile in VS Code
- [ ] Building the Docker image
- [ ] Adding a Docker network
- [ ] Running the containers in the Docker network
- [ ] Running the REST API in Docker
- [ ] Pushing the container image to Docker Hub
- [ ] Exploring the image in Docker Hub
- [ ] Pulling the image back to the local box

#### :older_man: Kubernetes
- [ ] Introduction
- [ ] What is Kubernetes?
- [ ] Enabling a Kubernetes cluster in Docker Desktop
- [ ] Installing the Kubernetes extension for VS Code
- [ ] Declaring the REST API Kuberentes deployment
- [ ] Creating a secret in Kubernetes
- [ ] Declaring health probes
- [ ] Declaring the REST API Kubernetes service
- [ ] Creating the REST API resources in Kubernetes
- [ ] Declaring the MongoDB Kubernetes StatefulSet
- [ ] Declaring the MongoDB Kubernetes service
- [ ] Creating the MongoDB resources in Kubernetes
- [ ] Testing the REST API hosted in Kubernetes
- [ ] Exploring the Kubernetes self-healing capability
- [ ] Scaling Kubernetes pods
- [ ] Adding logs via ILogger
- [ ] Getting a new image version into Kubernetes
- [ ] Load balancing requests across pods

#### :mage: Unit Testing and TDD
- [ ] Introduction
- [ ] What is unit testing?
- [ ] What is test driven development?
- [ ] Restructuring files and directories
- [ ] Creating the xUnit test project
- [ ] Building multiple projects in VS Code
- [ ] Adding NuGet packages for unit testing
- [ ] Testing GetItemAsync unexisting item
- [ ] Using the AAA pattern
- [ ] Stubbing dependencies via Moq
- [ ] Running tests in VS Code
- [ ] Using the .NET Core Test Explorer extension
- [ ] Testing GetItemAsync existing item
- [ ] Using FluentAssertions
- [ ] Testing GetItemsAsync
- [ ] Testing CreateItemAsync
- [ ] Testing UpdateItemAsync
- [ ] Testing DeleteItemAsync
- [ ] Refactoring and catching regressions
- [ ] Using TDD to test a yet to be created method
- [ ] Going back to green by fixing the failing test
- [ ] Testing the new controller method in Postman

