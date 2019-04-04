<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/ASPxPivotGrid_ShowOnlyVisibleFilterItems/Default.aspx) (VB: [Default.aspx](./VB/ASPxPivotGrid_ShowOnlyVisibleFilterItems/Default.aspx))
* [Default.aspx.cs](./CS/ASPxPivotGrid_ShowOnlyVisibleFilterItems/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/ASPxPivotGrid_ShowOnlyVisibleFilterItems/Default.aspx.vb))
<!-- default file list end -->
# How to hide filter items whose corresponding field values are not displayed


<p><strong>UPD: This example is obsolete</strong><strong>. </strong><strong>Starting with </strong><strong>v</strong><strong>11.2,</strong><strong> </strong><strong>simpl</strong><strong>y set the </strong><a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraPivotGridPivotGridOptionsFilterBase_ShowOnlyAvailableItemstopic"><strong><u>PivotGridOptionsFilterBase.ShowOnlyAvailableItems</u></strong></a><strong> property to </strong><strong>true</strong><strong> </strong><strong>t</strong><strong>o hide filter items whose corresponding field values are not displayed</strong><strong>.</strong></p><p>The following example shows how to hide filter items whose corresponding field values are not displayed.</p><p>In this example, the Row Header Area of the PivotGrid contains two fields: 'Category Name' and 'Product Name'. If an end-user hides a particular product category via the 'Category Name' field's filter drop-down, the corresponding products will be excluded from the filter drop-down of the 'Product Name' field. To hide filter items, the CustomFilterPopupItems event is handled.</p><p><br />
</p>

<br/>


