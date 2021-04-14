---
title: "How to close queue itema - sample code| Microsoft Docs"
description: "Sample code to close or deactivate queue items"
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 04/15/2021
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-customerservice
search.audienceType: 
  - developer
  - customizer
search.app: 
  - D365CE
  - D365CS
ms.reviewer: nenellim
---
# How to close queue items

You can use the following sample code to trigger the closure of queue items Omnichannel for Customer Service. You can modify the sample code to suit the needs of your organization.

   ```csharp
    static void Main(string[] args)
    {
        // e.g. https://yourorg.crm.dynamics.com
        string url = "<your environment url>";
        // e.g. you@yourorg.onmicrosoft.com
        string userName = "<your user name>";
        // e.g. y0urp455w0rd 
        string password = "<your password>";
    
        string conn = $@"
        Url = {url};
        AuthType = OAuth;
        UserName = {userName};
        Password = {password};
        AppId = 51f81489-12ee-4a9e-aaae-a2591f45987d;
        RedirectUri = app://58145B91-0C36-4500-8554-080854F2AC97;
        LoginPrompt=Auto;
        RequireNewInstance = True";

        using (var svc = new CrmServiceClient(conn))
        {

            WhoAmIRequest request = new WhoAmIRequest();
    
            WhoAmIResponse response = (WhoAmIResponse)svc.Execute(request);
    
            Console.WriteLine("Your UserId is {0}", response.UserId);
    
            try
            {
                //Provide queueitem id as the second parameter which has to be deactivated.
                svc.UpdateStateAndStatusForEntity("queueitem", new Guid("6f15a7f0-8788-eb11-a812-000d3a593524"), 1, 2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }
    }
   ```