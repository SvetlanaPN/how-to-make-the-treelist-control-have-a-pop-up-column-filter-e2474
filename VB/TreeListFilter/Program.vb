﻿Imports System
Imports System.Windows.Forms

Namespace TreeListFilter
	Friend NotInheritable Class Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		Private Sub New()
		End Sub
		<STAThread> _
		Shared Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			Application.Run(New XtraForm1())
		End Sub
	End Class
End Namespace
