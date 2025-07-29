
# Containarized Microservices .Net 9

## Overview
Short summary of what it solves and its purpose.
DDD 

## Tech Stack
.NET 9, ProtoBuffers, gRPC, ASP.NET Core, React, MongoDB, RabbitMQ, Docker, etc.

## Features

✅ Microservices architecture - architectural style that provides a highly maintainable, testable, loosely coupled collection of services that are independently deployable and organized around business capabilities. Service layer is placed on top of te Domain Models. 

✅ Domain-Driven Design - guides us to focus on small, individual, nearly autonomous pieces of our domain, our process and the resulting software is more flexible. We can easily move or modify the small parts with no side effects.

✅ Communication via gRPC - a new, growing way to connect services in a cross-platform, cross-language way. 

✅  Remote Proxy - acts like a local resource while hiding the details of how to connect to a remote resource over a network. It behaves as API gateway between the client and services.

✅ Applying Functional Principles - Functional programming in C# can give you insight into how your programs will behave. Specific topics here are immutable architecture, avoiding exceptions, primitive obsession, how to handles failures and input errors, and more.

✅  Command-Query Responsibility Segregation (CQRS) - encourages you to untangle a single, unified domain model and create two models: one for handling commands, and the other one for handling queries. CQRS allows us to make different decisions for reads and writes, which in turn brings three benefits: scalability, performance, and the biggest one, simplicity. CQRS extends CQS to the architectural level.

✅  MediatR - ensures that the messages are routed to the appropriate places. So you might think of it as a little more of an in‑memory messaging system.

✅  Docker - Containers represent a higher-density kind of "virtualization" that can meet the needs of certain scenarios better than traditional hypervisors.


## Architecture
- **ArticlesClient**: Handles article-related operations, communicates with the Articles service.
- **ProfilesClient**: Manages user profiles, communicates with the Profiles service.
- **TagsClient**: Manages article tags, communicates with the Tags service.
- **TagsPhotos**: Manages photos associated with tags.
- **RemoteProxyApi**: Acts as an API gateway, routing requests to the appropriate microservices and handling cross-cutting concerns like authentication and logging.
- **ArticlesPhotos**: Manages article photos.
- **TagService**: Handles operations related to tags, such as creating, updating, and deleting tags.
- **ArticlesService**: Manages articles, including creation, updates, and retrieval.
- **Message-driven workflow**: Uses RabbitMQ for asynchronous communication between services.
- **Docker**: Containerization of microservices for easy deployment and scaling.
- **gRPC**: Used for efficient communication between microservices, leveraging ProtoBuffers for serialization.
- **Mediator**: Implements the Mediator pattern to decouple request handling and processing, allowing for better separation of concerns.
- **CQRS**: Command-Query Responsibility Segregation is applied to separate read and write operations, enhancing performance and scalability.
- **Proxy**: Acts as an API gateway, routing requests to the appropriate microservices and handling cross-cutting concerns like authentication and logging. 

## Setup
1. Clone repo
2. Set env variables
3. `docker-compose up`

## Demo
TBC

## Lessons Learned
- Use of gRPC for inter-service communication provides better performance and type safety compared to REST.
- Implementing CQRS allows for better separation of concerns and scalability.
- Using Docker for containerization simplifies deployment and scaling of microservices.
- MediatR helps in decoupling request handling and processing, making the codebase cleaner and more maintainable.
- Applying functional programming principles leads to more predictable and maintainable code.
- Remote Proxy pattern simplifies client-side interactions with microservices, providing a unified interface.
- Using RabbitMQ for message-driven workflows allows for asynchronous communication between services, improving responsiveness and scalability.
