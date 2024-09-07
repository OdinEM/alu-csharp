#!/usr/bin/env bash

# Create the project directory
mkdir -p 2-new_project

# Navigate into the project directory
cd 2-new_project

# Initialize a new C# console project
dotnet new console

# Build the newly created project
dotnet build

# Run the newly created project
dotnet run
