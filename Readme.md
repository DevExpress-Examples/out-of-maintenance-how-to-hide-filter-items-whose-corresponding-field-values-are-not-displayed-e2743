<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128577534/10.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2743)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/ASPxPivotGrid_ShowOnlyVisibleFilterItems/Default.aspx) (VB: [Default.aspx](./VB/ASPxPivotGrid_ShowOnlyVisibleFilterItems/Default.aspx))
* [Default.aspx.cs](./CS/ASPxPivotGrid_ShowOnlyVisibleFilterItems/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/ASPxPivotGrid_ShowOnlyVisibleFilterItems/Default.aspx.vb))
<!-- default file list end -->
# How to hide filter items whose corresponding field values are not displayed
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e2743/)**
<!-- run online end -->


<p><strong>UPD: This example is obsolete</strong><strong>. </strong><strong>Starting with </strong><strong>v</strong><strong>11.2,</strong><strong> </strong><strong>simpl</strong><strong>y set the </strong><a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraPivotGridPivotGridOptionsFilterBase_ShowOnlyAvailableItemstopic"><strong><u>PivotGridOptionsFilterBase.ShowOnlyAvailableItems</u></strong></a><strong> property to </strong><strong>true</strong><strong> </strong><strong>t</strong><strong>o hide filter items whose corresponding field values are not displayed</strong><strong>.</strong></p><p>The following example shows how to hide filter items whose corresponding field values are not displayed.</p><p>In this example, the Row Header Area of the PivotGrid contains two fields: 'Category Name' and 'Product Name'. If an end-user hides a particular product category via the 'Category Name' field's filter drop-down, the corresponding products will be excluded from the filter drop-down of the 'Product Name' field. To hide filter items, the CustomFilterPopupItems event is handled.</p><p><br />
</p>

<br/>


