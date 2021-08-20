# A simple REST API with C#

This project was created based on amazing tutorial by Julio Casal

The tutorial can be watched on link below:
https://www.youtube.com/watch?v=ZXdFisA_hOY

It's really a wonderfull tutorial!!!

## :gear: To run app

First, make sure you already have a volume set for the app. If it exists, remove this volume.
```bash
  docker volume ls
  # In my example, it returned a volume name as below
  #DRIVER              VOLUME NAME
  #local               mongo-gamer-data


  # Then we can remove this volume
  docker volume rm mongo-gamer-data
```

We to want to create a new volume.
Let's start a container with a new volume and configurations
```bash
  docker run -d --rm --name mongo-gamer-api -p 27017:27017 -v mongo-gamer-data:/data/db -e MONGO_INITDB_ROOT_USERNAME=mongoadmin -e MONGO_INITDB_ROOT_PASSWORD=pass mongo
```

Now, we can run app using F5

---
## :milky_way: The journey

### :baby: Entity, Repository, Controller GET
- [X] Introduction
- [X] Adding an entity
- [X] Ading an in-memory repository
- [X] Creating the controller
- [X] Implemeting GET all items
- [X] Implemeting GET single item
- [X] Returning a 404 NotFound status code

### :child: Dependency Injection, DTOSs
- [X] Introduction
- [X] What is dependency injection?
- [X] Extracting the repository interface
- [X] Injecting the repository into the controller
- [X] Registering the repository as a singleton
- [X] Adding a Data Transfer Object DTO
- [X] Creating the AsDto extension method

### :boy: POST, PUT, DELETE
- [X] Introduction
- [X] Implementing POST
- [X] Adding validations via data annotations
- [X] Implemeting PUT
- [X] Implementing DELETE

### :adult: Persisting Entities with MongoDB
- [X] Introduction
- [X] Using Postman
- [X] Creating a MongoDB repository
- [X] Using the MongoDB.Driver NuGet package
- [X] Implementing MongoDB Create
- [X] Running the MongoDB Docker container
- [X] Configuring MongoDB connection settings
- [X] Registering the MongoClient singleton
- [X] Testing the MongoDB integration
- [X] Exploring the created database in VS Code
- [X] Implemeting MongoDB Get, Update and Delete

### :bearded_person: Tasks, Async and Await
- [X] Introduction
- [X] Using the Async suffix
- [X] Using tasks in the repository
- [X] Using async and await
- [X] Returning completed tasks
- [X] Using tasks in the controller
- [X] Testing async methods in Postman

### :white_haired_man: Secrets and Health Checks
- [X] Introduction
- [X] Enabling authentication in MongoDB
- [X] Using the .NET Secret Manager
- [X] Using the MongoDB credentials in the service
- [X] Introduction to Health Checks
- [X] Adding an endpoint for health checks
- [X] Adding a MongoDB health check
- [X] Adding checks for readiness and liveness
- [X] Customizing the health check response
- [X] Exploring other health check NuGet packages

### :older_adult: Docker
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

### :older_man: Kubernetes
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

### :mage: Unit Testing and TDD
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

