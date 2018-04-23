Imports Microsoft.VisualBasic
Imports System.Windows
Imports System.Windows.Controls
Imports DXExample.DemoData

Namespace DXTabControl_DataBinding_SL
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub LayoutRoot_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			tabControl.ItemsSource = Invoice.GetData()
		End Sub
	End Class
End Namespace
