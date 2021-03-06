using System.Collections.Generic;

namespace Glimpse.Core.Plugin.Assist
{
    public class TabLayoutRow
    {
        private readonly List<TabLayoutCell> _cells = new List<TabLayoutCell>();

        public TabLayoutCell Cell(int cell)
        {
            var layoutCell = new TabLayoutCell(cell);
            _cells.Add(layoutCell);
            return layoutCell;
        }

        internal TabLayoutCell[] Build()
        {
            return _cells.ToArray();
        }
    }
}