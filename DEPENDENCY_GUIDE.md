# Dependency Guide for ComputerInfo

## Overview
This project requires two custom UI libraries that need to be manually obtained and installed:
1. **GChartLib** - Modern chart visualization library
2. **MetroSuite 2.0** - Modern Windows 8 style controls

## Issue Background
The project references these libraries from local paths that are not included in the repository. This guide will help you obtain and install these dependencies.

## Required Dependencies

### 1. GChartLib
**Purpose**: Provides modern chart and circular progress controls for displaying system metrics.

**Original Source**: 
- VB Paradise Forum: http://www.vb-paradise.de/index.php/Thread/118123-GChartLib-Pr%C3%A4sentiert-Daten-auf-eine-neue-moderne-Art/#59da2a65195c6_1

**Used In**:
- Storage usage circular progress indicators (`GCircularProgress`)
- Memory tracking charts (`GChartLib`)

### 2. MetroSuite 2.0
**Purpose**: Provides Metro/Modern UI controls for Windows Forms.

**Original Source**:
- VB Paradise Forum: http://www.vb-paradise.de/index.php/Thread/81271-metrocontrols-update-01-11-holt-euch-den-modernen-windows-8-style/

**Used In**:
- Metro-styled labels (`MetroLabel`)
- Metro-styled tracking charts (`MetroTracker`, `MetroTrackerPath`)
- Various UI components throughout the application

## Installation Methods

### Method 1: Download from Original Sources (Recommended if accessible)

1. **Access the Forums**:
   - Visit the VB Paradise forum links above
   - You may need to create a free account to download attachments
   - Note: These are German language forums

2. **Download the Libraries**:
   - Download `GChartLib.dll` from the GChartLib thread
   - Download `MetroSuite 2.0.dll` from the MetroSuite thread

3. **Create Library Directory Structure**:
   ```
   Create a "lib" folder in the project root:
   ComputerInfo/
   ├── lib/
   │   ├── GChartLib/
   │   │   └── GChartLib.dll
   │   └── MetroSuite/
   │       └── MetroSuite 2.0.dll
   ```

4. **Update Project References**:
   - Open `ComputerInfo/ComputerInfo.csproj` in a text editor
   - Update the reference paths:
   
   Change:
   ```xml
   <Reference Include="GChartLib">
     <HintPath>..\..\..\Form Skins\GChartLib\GChartLib.dll</HintPath>
   </Reference>
   ```
   To:
   ```xml
   <Reference Include="GChartLib">
     <HintPath>..\lib\GChartLib\GChartLib.dll</HintPath>
   </Reference>
   ```
   
   Change:
   ```xml
   <Reference Include="MetroSuite 2.0">
     <HintPath>..\..\..\Form Skins\MetroSuite\MetroSuite 2.0.dll</HintPath>
   </Reference>
   ```
   To:
   ```xml
   <Reference Include="MetroSuite 2.0">
     <HintPath>..\lib\MetroSuite\MetroSuite 2.0.dll</HintPath>
   </Reference>
   ```

### Method 2: Alternative Solutions

If you cannot access the original sources, consider these alternatives:

1. **Contact the Repository Owner**:
   - The original author may have copies of these libraries
   - Create an issue in the GitHub repository requesting the DLL files

2. **Use Alternative Libraries** (Requires Code Changes):
   - For charts: Consider using **LiveCharts** or **OxyPlot**
   - For Metro UI: Use the existing **MetroFramework** (already included)
   - Note: This will require significant code refactoring

## Verification

After installation, verify the setup:

1. Open the solution in Visual Studio
2. Build the project (Ctrl+Shift+B)
3. Check for reference errors in the Error List
4. If successful, you should see "Build succeeded" with no errors

## Troubleshooting

### "Could not load file or assembly 'GChartLib'" or similar errors

**Solution**: 
- Verify the DLL files are in the correct location
- Ensure the `.csproj` file has the correct HintPath
- Try cleaning the solution (Build → Clean Solution) and rebuilding

### "The type or namespace name 'GChartLib' could not be found"

**Solution**:
- Verify the DLL files are valid .NET assemblies
- Check that the target framework version is compatible (.NET Framework 4.8)
- Ensure the DLL files are not blocked (Right-click → Properties → Unblock)

### Forum Access Issues

**Solution**:
- Use a translation tool (e.g., Google Translate) for German content
- Create a free account on VB Paradise forum
- Search for alternative hosting/mirrors of these libraries

## Additional Resources

- **MetroFramework**: Already included via NuGet packages (no action needed)
- **MaterialSkin**: Already included via NuGet packages (no action needed)
- **Project Documentation**: See README.md for general project information

## Contributing

If you successfully obtain these libraries, please consider:
1. Documenting your process
2. Sharing alternative sources (with proper licensing)
3. Contributing to make these dependencies easier to obtain for future users

## License Considerations

Both libraries appear to be freely distributed on the forum, but please:
- Respect the original authors' licenses
- Do not redistribute without permission
- Credit the original authors in your projects
