# ComputerInfo - Step-by-Step Installation Guide

This guide provides a visual, step-by-step walkthrough for setting up the ComputerInfo project.

## Overview

The main challenge with this project is obtaining two custom UI libraries:
- **GChartLib.dll**
- **MetroSuite 2.0.dll**

Follow these steps carefully to get the project running.

---

## Step 1: Clone the Repository

```bash
git clone https://github.com/SalkCoding/ComputerInfo.git
cd ComputerInfo
```

**Result**: You should now have a folder structure like this:
```
ComputerInfo/
├── ComputerInfo/        (Project files)
├── packages/            (NuGet packages)
├── screenshot/          (Screenshots)
├── README.md
├── LICENSE
└── DEPENDENCY_GUIDE.md
```

---

## Step 2: Check Current Dependencies

Run the dependency checker to see what's missing:

**Windows:**
```bash
check-dependencies.bat
```

**PowerShell:**
```powershell
.\check-dependencies.ps1
```

**Expected Output:**
```
1. GChartLib.dll [✗ MISSING]
2. MetroSuite 2.0.dll [✗ MISSING]
3. MetroModernUI.1.4.0.0 [✓ FOUND]
4. MaterialSkin.0.2.1 [✓ FOUND]
5. System.Management.4.7.0 [✓ FOUND]
```

---

## Step 3: Obtain the Required DLLs

### Option A: Download from VB Paradise Forum

1. **Visit the forums** (German language - use browser translation):
   - **GChartLib**: http://www.vb-paradise.de/index.php/Thread/118123
   - **MetroSuite 2.0**: http://www.vb-paradise.de/index.php/Thread/81271

2. **Create a free account** (if required to download attachments)

3. **Download the DLL files**:
   - Look for download links or attachments in the first post
   - Download `GChartLib.dll`
   - Download `MetroSuite 2.0.dll`

### Option B: Request from Repository Owner

If the forum links don't work or you can't access them:

1. Go to: https://github.com/SalkCoding/ComputerInfo/issues
2. Create a new issue titled: "Request for GChartLib and MetroSuite 2.0 DLLs"
3. Explain that you need these files to build the project
4. Wait for the maintainer to respond

---

## Step 4: Create the Library Folder Structure

Create the following folder structure in your project root:

```
ComputerInfo/
├── lib/                     (CREATE THIS FOLDER)
│   ├── GChartLib/           (CREATE THIS FOLDER)
│   │   └── GChartLib.dll    (PLACE DLL HERE)
│   └── MetroSuite/          (CREATE THIS FOLDER)
│       └── MetroSuite 2.0.dll  (PLACE DLL HERE)
├── ComputerInfo/
├── packages/
└── ...
```

**Commands to create folders:**

**Windows Command Prompt:**
```cmd
mkdir lib
mkdir lib\GChartLib
mkdir lib\MetroSuite
```

**PowerShell:**
```powershell
New-Item -ItemType Directory -Path "lib\GChartLib"
New-Item -ItemType Directory -Path "lib\MetroSuite"
```

---

## Step 5: Place the DLL Files

1. **Copy `GChartLib.dll`** → `lib/GChartLib/GChartLib.dll`
2. **Copy `MetroSuite 2.0.dll`** → `lib/MetroSuite/MetroSuite 2.0.dll`

**Important**: Make sure the files are not blocked by Windows:
1. Right-click each DLL file
2. Select "Properties"
3. If you see an "Unblock" checkbox at the bottom, check it
4. Click "Apply" and "OK"

---

## Step 6: Update Project References

Open `ComputerInfo/ComputerInfo.csproj` in a text editor and update the reference paths:

**Find these lines:**
```xml
<Reference Include="GChartLib">
  <HintPath>..\..\..\Form Skins\GChartLib\GChartLib.dll</HintPath>
</Reference>
```

**Replace with:**
```xml
<Reference Include="GChartLib">
  <HintPath>..\lib\GChartLib\GChartLib.dll</HintPath>
</Reference>
```

**Find these lines:**
```xml
<Reference Include="MetroSuite 2.0">
  <HintPath>..\..\..\Form Skins\MetroSuite\MetroSuite 2.0.dll</HintPath>
</Reference>
```

**Replace with:**
```xml
<Reference Include="MetroSuite 2.0">
  <HintPath>..\lib\MetroSuite\MetroSuite 2.0.dll</HintPath>
</Reference>
```

---

## Step 7: Restore NuGet Packages

### Using Visual Studio:
1. Open `ComputerInfo.sln` in Visual Studio
2. Right-click on the solution in Solution Explorer
3. Select "Restore NuGet Packages"
4. Wait for the packages to download

### Using Command Line:
```bash
nuget restore ComputerInfo.sln
```

---

## Step 8: Build the Project

### Using Visual Studio:
1. Press `Ctrl+Shift+B` or go to Build → Build Solution
2. Check the Output window for any errors
3. If successful, you'll see: "Build succeeded"

### Using MSBuild:
```bash
msbuild ComputerInfo.sln /p:Configuration=Release
```

---

## Step 9: Run the Application

### From Visual Studio:
- Press `F5` to run with debugging
- Press `Ctrl+F5` to run without debugging

### From File Explorer:
Navigate to:
```
ComputerInfo/ComputerInfo/bin/Debug/ComputerInfo.exe
or
ComputerInfo/ComputerInfo/bin/Release/ComputerInfo.exe
```

Double-click `ComputerInfo.exe`

---

## Step 10: Verify Installation

Run the dependency checker again to confirm everything is set up:

```bash
check-dependencies.bat
```

**Expected Output:**
```
1. GChartLib.dll [✓ FOUND]
2. MetroSuite 2.0.dll [✓ FOUND]
3. MetroModernUI.1.4.0.0 [✓ FOUND]
4. MaterialSkin.0.2.1 [✓ FOUND]
5. System.Management.4.7.0 [✓ FOUND]

✓ All dependencies are satisfied!
```

---

## Troubleshooting

### Problem: "Could not load file or assembly 'GChartLib'"

**Solution:**
1. Verify the DLL is in the correct location: `lib/GChartLib/GChartLib.dll`
2. Check that the `.csproj` file has the correct `<HintPath>`
3. Make sure the DLL is unblocked (Properties → Unblock)
4. Clean and rebuild the solution

### Problem: "Build failed" with reference errors

**Solution:**
1. Close Visual Studio
2. Delete `bin` and `obj` folders in the `ComputerInfo/ComputerInfo/` directory
3. Reopen Visual Studio
4. Restore NuGet packages
5. Rebuild the solution

### Problem: Application crashes on startup

**Solution:**
1. Run as Administrator (some hardware info requires elevated privileges)
2. Check Windows Event Viewer for detailed error messages
3. Ensure .NET Framework 4.8 is installed
4. Verify all DLLs are present and unblocked

### Problem: Forum links don't work

**Solution:**
1. Try using a VPN (some regions may block access)
2. Use web.archive.org to find cached versions of the forum pages
3. Create a GitHub issue requesting the DLL files from the repository owner
4. Consider using alternative libraries (requires code changes)

---

## Next Steps

Once the application is running:

1. **Explore the tabs**: CPU, Memory, Storage, GPU, Motherboard, OS
2. **Adjust refresh rate**: Use the dropdown to change update frequency
3. **View detailed storage info**: Click the "Detail" button on Storage tab
4. **Monitor in real-time**: Enable auto-refresh for live updates

---

## Need Help?

- **English Documentation**: [DEPENDENCY_GUIDE.md](./DEPENDENCY_GUIDE.md)
- **Korean Documentation**: [DEPENDENCY_GUIDE_KR.md](./DEPENDENCY_GUIDE_KR.md)
- **README**: [README.md](./README.md)
- **GitHub Issues**: https://github.com/SalkCoding/ComputerInfo/issues

---

**Thank you for using ComputerInfo!** 🎉
