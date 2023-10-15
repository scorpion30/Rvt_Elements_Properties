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
    internal class Conver : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            TaskDialogResult Answer = TaskDialog.Show("User Chating", "Did you have your Breakfast?", TaskDialogCommonButtons.Yes | TaskDialogCommonButtons.No);
            while (Answer == TaskDialogResult.No)
            {
                if (Answer == TaskDialogResult.Yes)
                {
                    TaskDialog.Show("RVT Reply", "Good Job!!");
                }
                else if (Answer == TaskDialogResult.No)
                {
                    TaskDialog.Show("RVT Reply", "Are You Kidding !! Go Eat:(");
                    Answer = TaskDialog.Show("User Chating", "Did you have your Breakfast?", TaskDialogCommonButtons.Yes | TaskDialogCommonButtons.No);
                }
            }


            return Result.Succeeded;
        }
    }
}
