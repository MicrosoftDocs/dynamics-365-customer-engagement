// <snippetuseoutlooksdk1>


 // Set up the CRM Service.  
 CrmOutlookService outlookService = new CrmOutlookService();

 // Determine if the Outlook client is running
 if (outlookService.IsCrmClientLoaded)
 {
     if (outlookService.IsCrmDesktopClient)
     {
         // The desktop client cannot go offline
         Console.WriteLine("CRM Client Desktop URL: " +
             outlookService.ServerUri.AbsoluteUri);
         Console.WriteLine("CRM Client state: " +
             outlookService.State.ToString());
     }
     else
     {
         // See if laptop client is offline
         if (outlookService.IsCrmClientOffline)
         {
             Console.WriteLine("CRM Client Offline URL: " +
                 outlookService.ServerUri.AbsoluteUri);
             Console.WriteLine("CRM Client state: " +
                 outlookService.State.ToString());

             // Take client online
             // NOTE: GoOnline() will automatically Sync up with CRM
             // database, no need to call Sync() manually
             Console.WriteLine("Going Online...");
             outlookService.GoOnline();

             Console.WriteLine("CRM Client state: " +
                 outlookService.State.ToString());
         }
         else
         {
             Console.WriteLine("CRM Client Online URL: " +
                 outlookService.ServerUri.AbsoluteUri);
             Console.WriteLine("CRM Client state: " +
                 outlookService.State.ToString());

             // Take client offline 
             // NOTE: GoOffline triggers a synchronization of the
             // offline database with the online server.
             // If a sync is not required, you can use SetOffline().
             Console.WriteLine("Going Offline...");
             outlookService.GoOffline();

             Console.WriteLine("CRM Client state: " +
                 outlookService.State.ToString());
         }
     }
 }

// </snippetuseoutlooksdk1>