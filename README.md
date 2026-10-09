# Calculator

A console calculator for basic arithmetic. You can add, subtract, multiply, and divide two numbers in a loop until you quit.

## Requirements

- [.NET 10 SDK](https://dotnet.microsoft.com/download)

## Clone and set up

```bash
git clone https://github.com/dsarney/calculator
cd calculator
```

Restore dependencies (optional — `dotnet build` / `dotnet run` will do this for you):

```bash
dotnet restore
```

## Run

```bash
dotnet run --project src/Calculator
```

The app prompts for an operation, then two numbers, prints the result, and repeats until you quit.

| Input        | Action           |
| ------------ | ---------------- |
| `+`          | Add              |
| `-`          | Subtract         |
| `*`          | Multiply         |
| `/`          | Divide           |
| `q` / `quit` | Exit the program |

Division by zero is rejected with an error message; invalid operations or numbers are rejected and you are prompted again.

## Run the tests

```bash
dotnet test
```

## Build a binary (optional)

```bash
dotnet build
```
