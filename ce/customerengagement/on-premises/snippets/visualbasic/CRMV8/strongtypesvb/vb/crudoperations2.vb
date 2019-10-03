' <snippetcrudoperations2>


 Catch ex As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
     Console.WriteLine("The application terminated with an error.")
     Console.WriteLine("Timestamp: {0}", ex.Detail.Timestamp)
     Console.WriteLine("Code: {0}", ex.Detail.ErrorCode)
     Console.WriteLine("Message: {0}", ex.Detail.Message)
     Console.WriteLine("Inner Fault: {0}", If(Nothing Is ex.Detail.InnerFault, "No Inner Fault", "Has Inner Fault"))
 Catch ex As TimeoutException
     Console.WriteLine("The application terminated with an error.")
     Console.WriteLine("Message: {0}", ex.Message)
     Console.WriteLine("Stack Trace: {0}", ex.StackTrace)
     Console.WriteLine("Inner Fault: {0}", If(Nothing Is ex.InnerException.Message, "No Inner Fault", ex.InnerException.Message))
 Catch ex As Exception
     Console.WriteLine("The application terminated with an error.")
     Console.WriteLine(ex.Message)

     ' Display the details of the inner exception.
     If ex.InnerException IsNot Nothing Then
         Console.WriteLine(ex.InnerException.Message)

         Dim fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault) = TryCast(ex.InnerException,  _
             FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault))
         If fe IsNot Nothing Then
             Console.WriteLine("Timestamp: {0}", fe.Detail.Timestamp)
             Console.WriteLine("Code: {0}", fe.Detail.ErrorCode)
             Console.WriteLine("Message: {0}", fe.Detail.Message)
             Console.WriteLine("Trace: {0}", fe.Detail.TraceText)
             Console.WriteLine("Inner Fault: {0}", If(Nothing Is fe.Detail.InnerFault, "No Inner Fault", "Has Inner Fault"))
         End If
     End If

' </snippetcrudoperations2>