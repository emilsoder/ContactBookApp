using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBookApp.View_Layer
{
    public interface IMainView
    {
        object GridViewDataSource { get; set; }
        string SearchText { get; }
        void SelectCurrentRow(int selectedRowIndex);
    }
}