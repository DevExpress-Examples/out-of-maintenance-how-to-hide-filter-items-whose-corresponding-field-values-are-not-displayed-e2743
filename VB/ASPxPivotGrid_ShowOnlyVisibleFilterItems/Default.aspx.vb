Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Web.UI
Imports DevExpress.Web.ASPxPivotGrid

Namespace ASPxPivotGrid_ShowOnlyVisibleFilterItems
	Partial Public Class _Default
		Inherits Page
		Protected Sub ASPxPivotGrid1_CustomFilterPopupItems(ByVal sender As Object, _
				ByVal e As PivotCustomFilterPopupItemsEventArgs)
			Dim values As List(Of Object) = e.Field.GetVisibleValues()
			values.Sort()
			For i As Integer = e.Items.Count - 1 To 0 Step -1
				If CType(e.Items(i).IsChecked, Boolean) = True AndAlso _
					values.BinarySearch(e.Items(i).Value) < 0 Then
					e.Items.RemoveAt(i)
				End If
			Next i
		End Sub
	End Class
End Namespace
