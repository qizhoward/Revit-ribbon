using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace HelloWorld
{
    [Transaction(TransactionMode.Manual)]
    public class HelloWorld : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            var uidco = commandData.Application.ActiveUIDocument;
            var doc = uidco.Document;
            var view = new HelloView();
            view.ShowDialog();


            return Result.Succeeded;
        }
    }

}