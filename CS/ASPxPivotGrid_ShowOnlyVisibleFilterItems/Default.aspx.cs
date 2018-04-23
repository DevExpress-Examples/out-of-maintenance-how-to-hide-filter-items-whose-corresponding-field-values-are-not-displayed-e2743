using System;
using System.Collections.Generic;
using System.Web.UI;
using DevExpress.Web.ASPxPivotGrid;

namespace ASPxPivotGrid_ShowOnlyVisibleFilterItems {
    public partial class _Default : Page {
        protected void ASPxPivotGrid1_CustomFilterPopupItems(object sender, 
                                    PivotCustomFilterPopupItemsEventArgs e) {
            List<object> values = e.Field.GetVisibleValues();
            values.Sort();
            for (int i = e.Items.Count - 1; i >= 0; i--) {
                if (e.Items[i].IsChecked == true && values.BinarySearch(e.Items[i].Value) < 0)
                    e.Items.RemoveAt(i);
            }
        }
    }
}
