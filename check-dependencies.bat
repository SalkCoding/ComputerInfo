@echo off
REM ComputerInfo Dependency Checker - Batch Wrapper
REM This script runs the PowerShell dependency checker

powershell.exe -ExecutionPolicy Bypass -File "%~dp0check-dependencies.ps1"
