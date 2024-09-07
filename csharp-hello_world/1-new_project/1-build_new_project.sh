#!/bin/bash

# Directory name
DIR="1-new_project"

# Create the directory if it does not exist
if [ ! -d "$DIR" ]; then
    mkdir "$DIR"
fi

# Navigate into the directory
cd "$DIR"

# Initialize a new C# project
dotnet new console

# Build the C# project
dotnet build
