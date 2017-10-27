' <snippetuseoutlooksdk1>


 ' Set up the CRM Service.  
 Dim outlookService As New CrmOutlookService()

 ' Determine if the Outlook client is running
 If outlookService.IsCrmClientLoaded Then
     If outlookService.IsCrmDesktopClient Then
         ' The desktop client cannot go offline
         Console.WriteLine("CRM Client Desktop URL: " &amp; outlookService.ServerUri.AbsoluteUri)
         Console.WriteLine("CRM Client state: " &amp; outlookService.State.ToString())
     Else
         ' See if laptop client is offline
         If outlookService.IsCrmClientOffline Then
             Console.WriteLine("CRM Client Offline URL: " &amp; outlookService.ServerUri.AbsoluteUri)
             Console.WriteLine("CRM Client state: " &amp; outlookService.State.ToString())

             ' Take client online
             ' NOTE: GoOnline() will automatically Sync up with CRM
             ' database, no need to call Sync() manually
             Console.WriteLine("Going Online...")
             outlookService.GoOnline()

             Console.WriteLine("CRM Client state: " &amp; outlookService.State.ToString())
         Else
             Console.WriteLine("CRM Client Online URL: " &amp; outlookService.ServerUri.AbsoluteUri)
             Console.WriteLine("CRM Client state: " &amp; outlookService.State.ToString())

             ' Take client offline 
             ' NOTE: GoOffline triggers a synchronization of the
             ' offline database with the online server.
             ' If a sync is not required, you can use SetOffline().
             Console.WriteLine("Going Offline...")
             outlookService.GoOffline()

             Console.WriteLine("CRM Client state: " &amp; outlookService.State.ToString())
         End If
     End If
 End If

' </snippetuseoutlooksdk1>