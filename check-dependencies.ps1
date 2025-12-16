# ComputerInfo Dependency Checker
# This script checks if all required dependencies are properly installed

Write-Host "================================================" -ForegroundColor Cyan
Write-Host "  ComputerInfo Dependency Checker" -ForegroundColor Cyan
Write-Host "================================================" -ForegroundColor Cyan
Write-Host ""

$allGood = $true
$projectRoot = $PSScriptRoot

# Check for required DLL files
Write-Host "Checking for required DLL files..." -ForegroundColor Yellow
Write-Host ""

# Define expected library locations
$gchartLibPath = Join-Path $projectRoot "lib\GChartLib\GChartLib.dll"
$metroSuitePath = Join-Path $projectRoot "lib\MetroSuite\MetroSuite 2.0.dll"

# Alternative paths (in case user placed them in different location)
$altGchartLibPath = Join-Path $projectRoot "..\..\..\Form Skins\GChartLib\GChartLib.dll"
$altMetroSuitePath = Join-Path $projectRoot "..\..\..\Form Skins\MetroSuite\MetroSuite 2.0.dll"

# Check GChartLib
Write-Host "1. GChartLib.dll" -NoNewline
if (Test-Path $gchartLibPath) {
    Write-Host " [✓ FOUND]" -ForegroundColor Green
    Write-Host "   Location: $gchartLibPath" -ForegroundColor Gray
} elseif (Test-Path $altGchartLibPath) {
    Write-Host " [✓ FOUND]" -ForegroundColor Green
    Write-Host "   Location: $altGchartLibPath" -ForegroundColor Gray
    Write-Host "   Note: Using original path. Consider moving to lib folder." -ForegroundColor Yellow
} else {
    Write-Host " [✗ MISSING]" -ForegroundColor Red
    Write-Host "   Expected at: $gchartLibPath" -ForegroundColor Gray
    $allGood = $false
}
Write-Host ""

# Check MetroSuite 2.0
Write-Host "2. MetroSuite 2.0.dll" -NoNewline
if (Test-Path $metroSuitePath) {
    Write-Host " [✓ FOUND]" -ForegroundColor Green
    Write-Host "   Location: $metroSuitePath" -ForegroundColor Gray
} elseif (Test-Path $altMetroSuitePath) {
    Write-Host " [✓ FOUND]" -ForegroundColor Green
    Write-Host "   Location: $altMetroSuitePath" -ForegroundColor Gray
    Write-Host "   Note: Using original path. Consider moving to lib folder." -ForegroundColor Yellow
} else {
    Write-Host " [✗ MISSING]" -ForegroundColor Red
    Write-Host "   Expected at: $metroSuitePath" -ForegroundColor Gray
    $allGood = $false
}
Write-Host ""

# Check NuGet packages
Write-Host "Checking NuGet packages..." -ForegroundColor Yellow
Write-Host ""

$packagesPath = Join-Path $projectRoot "packages"
$requiredPackages = @(
    "MetroModernUI.1.4.0.0",
    "MaterialSkin.0.2.1",
    "System.Management.4.7.0"
)

foreach ($package in $requiredPackages) {
    $packagePath = Join-Path $packagesPath $package
    Write-Host "3. $package" -NoNewline
    if (Test-Path $packagePath) {
        Write-Host " [✓ FOUND]" -ForegroundColor Green
    } else {
        Write-Host " [✗ MISSING]" -ForegroundColor Red
        Write-Host "   Run 'nuget restore' or 'Restore NuGet Packages' in Visual Studio" -ForegroundColor Gray
        $allGood = $false
    }
}
Write-Host ""

# Check .NET Framework
Write-Host "Checking .NET Framework..." -ForegroundColor Yellow
Write-Host ""

$dotNetPath = "HKLM:\SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full"
if (Test-Path $dotNetPath) {
    $release = (Get-ItemProperty $dotNetPath).Release
    if ($release -ge 528040) {
        Write-Host "4. .NET Framework 4.8 [✓ INSTALLED]" -ForegroundColor Green
    } else {
        Write-Host "4. .NET Framework 4.8 [✗ NOT FOUND]" -ForegroundColor Red
        Write-Host "   Please install .NET Framework 4.8 or later" -ForegroundColor Gray
        $allGood = $false
    }
} else {
    Write-Host "4. .NET Framework [✗ UNABLE TO DETECT]" -ForegroundColor Yellow
    Write-Host "   Please ensure .NET Framework 4.8 is installed" -ForegroundColor Gray
}
Write-Host ""

# Summary
Write-Host "================================================" -ForegroundColor Cyan
if ($allGood) {
    Write-Host "  ✓ All dependencies are satisfied!" -ForegroundColor Green
    Write-Host "  You can now build and run the project." -ForegroundColor Green
} else {
    Write-Host "  ✗ Some dependencies are missing!" -ForegroundColor Red
    Write-Host ""
    Write-Host "  Please refer to:" -ForegroundColor Yellow
    Write-Host "  - DEPENDENCY_GUIDE.md (English)" -ForegroundColor Yellow
    Write-Host "  - DEPENDENCY_GUIDE_KR.md (한국어)" -ForegroundColor Yellow
    Write-Host "  - README.md for installation instructions" -ForegroundColor Yellow
}
Write-Host "================================================" -ForegroundColor Cyan
Write-Host ""

# Pause to allow user to read the output
Read-Host "Press Enter to exit"
