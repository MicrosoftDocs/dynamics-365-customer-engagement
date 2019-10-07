// <snippetimportorremovesampledata1>



     // Prompt user to install/uninstall sample data.
     Console.WriteLine("Would you like to:");
     Console.WriteLine("1) Install sample data for Microsoft Dynamics CRM?");
     Console.WriteLine("2) Uninstall sample data for Microsoft Dynamics CRM?");
     Console.Write("Press [1] to Install, [2] to Uninstall: ");
     String answer = Console.ReadLine();

     // Update the sample data based on the user's response.
     switch (answer)
     {
         case "1":
             Console.WriteLine("Installing sample data...");
             InstallSampleDataRequest request =
                 new InstallSampleDataRequest();
             InstallSampleDataResponse response =
                 (InstallSampleDataResponse)_serviceProxy.Execute(request);
             Console.WriteLine("Sample data successfully installed.");
             break;
         case "2":
             Console.WriteLine("Uninstalling sample data...");
             UninstallSampleDataRequest request2 =
                 new UninstallSampleDataRequest();
             UninstallSampleDataResponse response2 =
                 (UninstallSampleDataResponse)_serviceProxy.Execute(request2);
             Console.WriteLine("Sample data successfully uninstalled.");
             break;
         default:
             Console.WriteLine("Neither option was selected. No changes have been made to your records.");
             break;
     }

 }

// </snippetimportorremovesampledata1>