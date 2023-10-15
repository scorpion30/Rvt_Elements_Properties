using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace Rvt_Elements_Properties
{
    [TransactionAttribute(TransactionMode.ReadOnly)]
    public class ElementsProperties : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            TaskDialog.Show("INTRO", "Elements Properties_AN");
            return Result.Succeeded;
        }
    }
}
