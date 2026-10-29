using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace Toolkit.Addin
{
    /// <summary>
    /// A command is a class that runs when the user clicks a ribbon button.
    /// Manual means "I will open my own transactions when I change the model".
    /// This command only reads, so it opens none.
    /// </summary>
    [Transaction(TransactionMode.Manual)]
    public class HelloCommand : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiApp = commandData.Application;

            // The active document is the project that is open right now. It can be null.
            Document doc = uiApp.ActiveUIDocument?.Document;

            string revitVersion = uiApp.Application.VersionNumber;
            string projectName = doc != null ? doc.Title : "(no project open)";

            TaskDialog.Show(
                "BIM Toolkit",
                "Hello from your first add-in!\n\n" +
                "Revit version: " + revitVersion + "\n" +
                "Active project: " + projectName);

            return Result.Succeeded;
        }
    }
}
