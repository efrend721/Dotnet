# Programming Techniques Every Developer Should Know

Based on the transcript in `tmp.md` from Tim Corey's video: **"Which Programming Techniques Should Every Developer Know?"**

This document is organized as a practical roadmap. It separates:

1. **General software development knowledge**
2. **C#-specific knowledge**
3. **A suggested learning order**

---

## 1. General Knowledge Every Developer Should Have

| Topic                              | What it means                                                                                          | Why it matters                                                                                                              |
| ---------------------------------- | ------------------------------------------------------------------------------------------------------ | --------------------------------------------------------------------------------------------------------------------------- |
| Know the language, not just the UI | Learn the programming language itself instead of focusing only on a specific user interface framework. | UI technologies change. Strong language skills transfer across web, desktop, mobile, services, and other application types. |
| Debugging                          | Learn how to step through code, inspect variables, identify failures, and understand execution flow.   | A large part of real programming work is finding and fixing problems, not just writing new code.                            |
| Logging                            | Add logs to track how the application behaves, especially in production.                               | Logs help when bugs cannot be reproduced locally and you need visibility into what happened.                                |
| Data security                      | Understand how to protect application data and how data flows through the system.                      | Most applications are built around data, so protecting it is a core responsibility.                                         |
| Real security vs security theater  | Learn the difference between meaningful security and actions that only look secure.                    | Some practices add complexity without providing real protection.                                                            |
| Data access                        | Understand how applications read and write data, whether directly or through APIs.                     | Even front-end developers need to understand where data comes from and how it is accessed safely.                           |
| Database design                    | Know how databases are structured, configured, and maintained.                                         | Applications depend heavily on data, so developers need to understand the system behind it.                                 |

---

## 2. Main Ideas From the General Developer Section

| Principle                                            | Explanation                                                                                           |
| ---------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| Code knowledge is more important than UI familiarity | A developer should understand how the language works before specializing in a framework or interface. |
| Debugging is a required skill, not an optional one   | You need to know the tools and techniques used to inspect and fix broken applications.                |
| Logging is essential in real applications            | Production issues often cannot be reproduced on demand, so logs become critical evidence.             |
| Data is central to most software                     | Business systems, games, websites, and services all depend on storing, reading, and updating data.    |
| Security must be practical                           | You should understand what actually protects data and what only creates the illusion of safety.       |
| ORMs do not replace understanding                    | Tools can help, but they should not become a black box that hides how your system works.              |

---

## 3. C#-Specific Knowledge Mentioned in the Video

| C# Topic                                       | What you should know                                                       | Why it matters                                                                         |
| ---------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| Object-oriented programming                    | Classes, inheritance, interfaces, events, and encapsulation.               | Many C# application models depend on OOP concepts.                                     |
| Generics                                       | How to write and use reusable type-safe code.                              | Generics are common throughout the .NET ecosystem.                                     |
| LINQ                                           | Querying and transforming data collections.                                | LINQ is a core productivity tool in C# and appears in many real applications.          |
| Data types                                     | Understanding built-in types and how to use them correctly.                | Good type usage leads to safer and clearer code.                                       |
| Language fundamentals and advanced features    | Not just syntax, but deeper language knowledge.                            | You need more than beginner syntax to work effectively in C#.                          |
| Breakpoints                                    | Standard and advanced breakpoint usage.                                    | Strong debugging in C# depends on using Visual Studio or related tools effectively.    |
| Stepping through code                          | Knowing how execution moves line by line and method by method.             | This is essential for diagnosing behavior and bugs.                                    |
| Logging libraries                              | At least one of Serilog, NLog, or log4net.                                 | Logging is part of production-grade C# development.                                    |
| Dependency Injection                           | Built-in .NET dependency injection and how to use it across app types.     | DI is a major pattern in modern .NET development.                                      |
| appsettings.json                               | Configuration management in .NET applications.                             | Settings, connection strings, and environment-based configuration depend on it.        |
| secrets.json and environment-specific settings | Knowing where and when to store development or environment settings.       | Correct configuration handling is important for security and maintainability.          |
| NuGet                                          | Installing libraries and understanding package management.                 | NuGet is how most .NET projects consume external libraries.                            |
| Important interfaces                           | `IConfiguration`, `IDisposable`, and `ILogger`.                            | These interfaces appear often in real-world .NET projects.                             |
| Data access in C#                              | Entity Framework, Dapper, micro-ORMs, and basic ADO.NET awareness.         | C# developers regularly interact with databases and need practical data access skills. |
| SQL Server                                     | Tables, views, stored procedures, query tuning, and performance diagnosis. | C# and SQL Server are commonly used together in business systems.                      |
| Multiple user interfaces                       | Understand more than one UI model, even if you specialize in one.          | It helps you choose the right tool for the job and broadens your skill set.            |

---

## 4. C# Tools and Concepts Called Out Explicitly

| Tool or Concept                    | Notes from the video                                                                       |
| ---------------------------------- | ------------------------------------------------------------------------------------------ |
| Visual Studio debugging tools      | Learn breakpoints, advanced breakpoints, and stepping through execution.                   |
| Serilog                            | Recommended as a strong current choice because of structured logging.                      |
| NLog                               | Another useful logging option worth knowing.                                               |
| log4net                            | Also mentioned as a logging option.                                                        |
| Built-in .NET dependency injection | Should be understood and applied in multiple .NET application types.                       |
| appsettings.json                   | Central configuration file in .NET Core and newer .NET applications.                       |
| secrets.json                       | Useful for development-time secrets and configuration separation.                          |
| Environment variables              | Important as part of the .NET configuration system.                                        |
| Azure Key Vault                    | Mentioned as an integration option for configuration and secrets.                          |
| NuGet                              | Required for bringing libraries into projects and understanding package-based development. |
| `IConfiguration`                   | Used for configuration access.                                                             |
| `IDisposable`                      | Used to release resources correctly.                                                       |
| `ILogger`                          | Used for standardized logging.                                                             |
| Entity Framework                   | Mentioned as a valid ORM choice if understood well.                                        |
| Dapper                             | Highlighted as a preferred lightweight data access option.                                 |
| ADO.NET                            | Still useful to understand, though less emphasized than micro-ORMs.                        |
| SQL Server                         | Recommended as the first database a C# developer should learn well.                        |
| Other databases                    | MongoDB, Cosmos DB, MySQL, and SQLite were mentioned as useful to know after SQL Server.   |

---

## 5. What a Beginner Should Take Away

| Priority | Focus area                    | What to learn first                                                                  |
| -------- | ----------------------------- | ------------------------------------------------------------------------------------ |
| High     | Learn the language deeply     | C# syntax, methods, classes, interfaces, generics, LINQ, and data types              |
| High     | Learn debugging early         | Breakpoints, stepping through code, inspecting variables, and reading execution flow |
| High     | Learn data fundamentals       | How data is stored, accessed, secured, and modeled                                   |
| High     | Learn practical configuration | appsettings.json, secrets management, and environment-based settings                 |
| High     | Learn dependency injection    | How services are registered, injected, and organized in .NET                         |
| Medium   | Learn logging                 | Use at least one real logging library and understand structured logs                 |
| Medium   | Learn package management      | Install and manage libraries with NuGet                                              |
| Medium   | Learn data access options     | Start with one main approach, then compare ORM and micro-ORM tools                   |
| Medium   | Learn database skills         | SQL Server basics, database design, performance, and query optimization              |
| Medium   | Learn multiple UI approaches  | Do not lock yourself into only one application model                                 |

---

## 6. Suggested Learning Roadmap

| Stage | What to study                                           | Outcome                                                  |
| ----- | ------------------------------------------------------- | -------------------------------------------------------- |
| 1     | C# basics                                               | Write simple programs confidently                        |
| 2     | Object-oriented programming, interfaces, and generics   | Build reusable and maintainable code                     |
| 3     | LINQ and collections                                    | Work effectively with in-memory data                     |
| 4     | Debugging tools in Visual Studio                        | Diagnose problems instead of guessing                    |
| 5     | Logging                                                 | Add visibility into how your app behaves                 |
| 6     | Configuration with appsettings.json and related sources | Manage settings correctly across environments            |
| 7     | Dependency Injection                                    | Organize larger applications more cleanly                |
| 8     | Data access with SQL and one .NET data tool             | Build applications that read and write real data         |
| 9     | Database design and optimization                        | Understand how the data layer should be structured       |
| 10    | Additional UIs and additional databases                 | Broaden your toolbox and choose tools more intelligently |

---

## 7. Short Roadmap Checklist

| Checklist                                            | Status   |
| ---------------------------------------------------- | -------- |
| Learn C# fundamentals well                           | To study |
| Learn OOP, interfaces, inheritance, and events       | To study |
| Learn generics and LINQ                              | To study |
| Learn to debug with breakpoints and stepping         | To study |
| Learn one logging library                            | To study |
| Learn data security principles                       | To study |
| Learn how data access works                          | To study |
| Learn SQL Server basics                              | To study |
| Learn database design concepts                       | To study |
| Learn built-in .NET dependency injection             | To study |
| Learn appsettings.json and configuration flow        | To study |
| Learn NuGet package management                       | To study |
| Learn `IConfiguration`, `IDisposable`, and `ILogger` | To study |
| Learn at least one .NET data access approach         | To study |
| Learn more than one C# UI model over time            | To study |

---

## 8. Final Summary

The main message of the video is that strong developers do not stop at user interfaces or basic syntax. They build a solid foundation in the language, debugging, logging, data access, security, and database understanding. For C# developers specifically, that foundation expands into object-oriented programming, generics, LINQ, dependency injection, configuration, NuGet, logging libraries, data access tools, and SQL Server.

A practical way to use this video is as a roadmap:

- First, master the C# language itself.
- Then learn debugging, logging, and configuration.
- After that, focus on dependency injection, data access, and SQL.
- Finally, broaden your knowledge across interfaces, tools, and database technologies.

This gives you a wider toolbox and helps you choose the right tool for the job instead of relying on a single approach.
