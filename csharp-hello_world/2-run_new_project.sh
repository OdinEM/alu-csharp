#!/usr/bin/env bash

# Create a new directory named 2-new_project
mkdir -p 2-new_project

# Navigate into the 2-new_project directory
cd 2-new_project

# Initialize a new C# console project
dotnet new console

# Build the newly created C# project
dotnet build

# Run the newly built C# project
dotnet run
