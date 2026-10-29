using System.Reflection;
using Autodesk.Revit.UI;

namespace Toolkit.Addin
{
    /// <summary>
    /// The entry point of the add-in. Revit creates one instance of this class when it starts,
    /// because Toolkit.addin names it in the FullClassName line.
    /// </summary>
    public class App : IExternalApplication
    {
        private const string TabName = "BIM Toolkit";

        // Revit calls this once, while it is starting up. We use it to build our ribbon tab.
        public Result OnStartup(UIControlledApplication application)
        {
            try
            {
                application.CreateRibbonTab(TabName);
            }
            catch (Autodesk.Revit.Exceptions.ArgumentException)
            {
                // The tab already exists (for example if another add-in made it). That is fine.
            }

            RibbonPanel panel = application.CreateRibbonPanel(TabName, "Getting Started");

            // A button needs: an internal name, the text shown on it,
            // the path of the DLL, and the full name of the command class to run.
            string dllPath = Assembly.GetExecutingAssembly().Location;
            var buttonData = new PushButtonData(
                "HelloButton",
                "Hello\nToolkit",
                dllPath,
                typeof(HelloCommand).FullName)
            {
                ToolTip = "Shows a message box to prove the add-in is installed correctly."
            };

            panel.AddItem(buttonData);

            return Result.Succeeded;
        }

        // Revit calls this when it closes. Nothing to clean up yet.
        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }
    }
}
