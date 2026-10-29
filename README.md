# BIM Toolkit

A set of Revit add-ins, built step by step as a learning project.

**Status:** Step 0 - hello-world add-in (a ribbon button that shows a message box).

Supported Revit versions: 2024, 2025, 2026.

## Run Step 0

1. **Close Revit.** Revit locks the add-in file while it is running, so a build fails if it is open.
2. Open `RevitToolkit.sln` in Visual Studio 2022.
3. In the top toolbar, set the configuration to the Revit version you want to test, for example **Debug R25**.
   - `Debug R24` = Revit 2024, `Debug R25` = Revit 2025, `Debug R26` = Revit 2026
4. Press **Ctrl+Shift+B** (Build > Build Solution). The Output window should end with `Deployed to ...\Autodesk\Revit\Addins\2025`.
5. Start that version of Revit and open any project (or create a new one).
6. Look for a new **BIM Toolkit** tab on the ribbon. Click **Hello Toolkit**.

Revit may ask whether to load the add-in the first time. Choose **Always Load**.

You should see a message box showing the Revit version and your project name.

## If something goes wrong

| What you see | What to do |
| --- | --- |
| Build error: cannot find `RevitAPI.dll` | Revit is not installed in `C:\Program Files\Autodesk\Revit <year>`. Edit `RevitInstallDir` in `Toolkit.Addin.csproj`. |
| Build error: file is in use / access denied | Close Revit and build again. |
| Build works but no BIM Toolkit tab | Check that `Toolkit.addin` is in `%APPDATA%\Autodesk\Revit\Addins\<year>\` and `Toolkit.Addin.dll` is in the `Toolkit` folder next to it. |
| Revit shows an error on start | Open the Journal or the error text and send it to your helper (copy the full text). |
| Visual Studio will not open the `.sln` | Open `src\Toolkit.Addin\Toolkit.Addin.csproj` directly instead. |

## Project layout (so far)

```
RevitToolkit.sln
src/
  Toolkit.Addin/
    Toolkit.Addin.csproj   build settings for Revit 2024/2025/2026
    Toolkit.addin          manifest that tells Revit about the add-in
    App.cs                 builds the ribbon tab and button when Revit starts
    HelloCommand.cs        the code that runs when you click the button
```

More folders (Core, Revit, UI, tests) arrive in the next steps.
