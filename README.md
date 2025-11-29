# FileBaseApps Sandbox

A small C# sandbox for experimenting with file-based utilities and code metrics.

## Project Structure

- `CodeMetrix.cs`: C# source focused on computing simple code metrics (e.g., line counts, file stats) across the workspace. Intended to be run or compiled to inspect project files.
- `FileBaseApps.cs`: C# entry point and/or helpers for file-based app demos (reading/writing files, scanning directories, etc.).
- `global.json`: .NET SDK pinning file to ensure consistent SDK version across environments.
- `RunFileBaseApps.bat`: Convenience script to build/run demos from Windows CMD. PowerShell usage is shown below.

## Prerequisites

- .NET SDK (recommended: the version pinned in `global.json`)
- Windows with PowerShell (`pwsh.exe`) or CMD

## Quick Start (PowerShell)

```powershell
# From the project folder
# Restore and build
dotnet restore
dotnet build

# Run a specific C# file as a top-level program (if applicable)
# If these files are part of a project, use 'dotnet run' instead.
# For single-file execution via 'scriptcs' style you’d need a project; otherwise compile to an exe:

# Example: compile CodeMetrix.cs
csc CodeMetrix.cs -out:CodeMetrix.exe
./CodeMetrix.exe

# Example: compile FileBaseApps.cs
csc FileBaseApps.cs -out:FileBaseApps.exe
./FileBaseApps.exe

# If this is a .NET project, simply:
dotnet run
```

## Quick Start (CMD)

```bat
REM Restore and build
dotnet restore
dotnet build

REM Run via the batch script if configured
RunFileBaseApps.bat
```

## Notes

- If `CodeMetrix.cs` and `FileBaseApps.cs` are part of a single project, prefer using `dotnet run` over compiling individual files.
- Ensure the .NET SDK version matches the one in `global.json` to avoid build/runtime differences.
- Update this README as the scope of utilities grows (e.g., add usage flags, input/output examples).
