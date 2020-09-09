' <snippetimportorremovesampledata1>



     ' Prompt user to install/uninstall sample data.
     Console.WriteLine("Would you like to:")
     Console.WriteLine("1) Install sample data for Microsoft Dynamics CRM?")
     Console.WriteLine("2) Uninstall sample data for Microsoft Dynamics CRM?")
     Console.Write("Press [1] to Install, [2] to Uninstall: ")
     Dim answer As String = Console.ReadLine()

     ' Update the sample data based on the user's response.
     Select Case answer
         Case "1"
             Console.WriteLine("Installing sample data...")
             Dim request As New InstallSampleDataRequest()
             Dim response As InstallSampleDataResponse = CType(_serviceProxy.Execute(request), InstallSampleDataResponse)
             Console.WriteLine("Sample data successfully installed.")
         Case "2"
             Console.WriteLine("Uninstalling sample data...")
             Dim request2 As New UninstallSampleDataRequest()
             Dim response2 As UninstallSampleDataResponse = CType(_serviceProxy.Execute(request2), UninstallSampleDataResponse)
             Console.WriteLine("Sample data successfully uninstalled.")
         Case Else
             Console.WriteLine("Neither option was selected. No changes have been made to your records.")
     End Select

 End Using

' </snippetimportorremovesampledata1>