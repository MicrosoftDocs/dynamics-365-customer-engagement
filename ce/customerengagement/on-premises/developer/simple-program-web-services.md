---
title: "Run a simple program using web services (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "Learn to run a simple program using Dynamics 365 Customer Engagement web services."
ms.custom: 
ms.date: 03/29/2019
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: get-started-article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: f5a975da-2fe5-4fc3-88d3-59c39d6b4477
caps.latest.revision: 47
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Run a simple program using Customer Engagement web services

This topic shows you how to compile and run a  program that creates an account record, retrieves the record, updates the record, and then prompts to see if you would like the record deleted.  

## Prerequisites

- Download the [Sample: Quick start for Microsoft Dynamics 365 Customer Engagement](sample-quick-start.md)
- You must be able to sign in to [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)].  
- [!INCLUDE [pn-visual-studio-short](../includes/pn-visual-studio-short.md)] 
- [!INCLUDE [pn-net-framework462-long](../includes/pn-net-framework462-long.md)]

### Compile and run the Quick Start sample

1. Extract the downloaded file and open the \C#\QuickStart.csproj
2. Open the \C#\QuickStart.csproj file in [!INCLUDE[pn-visual-studio-short](../includes/pn-visual-studio-short.md)].  
3. Right click the **QuickStart** project in the solution explorer and select **Manage NuGet Packages...*
4. Select the **Microsoft.CrmSdk.CoreAssemblies** package and update to the latest stable version.
5. Press **F5** to compile and run the program.  
6. Enter the following information at the prompts:


   |                                                        Prompt                                                         |                                                                                                                                                                                                                                                                                             Description                                                                                                                                                                                                                                                                                              |
   |-----------------------------------------------------------------------------------------------------------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
   |                                  Enter a CRM server name and port [crm.dynamics.com]                                  |                                                                  Type the name of your Dynamics 365 Server. The default is [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] (crm.dynamics.com) in North America.<br /><br /> Example: myservername<br /><br /> Example: myprefix.myservername:5500<br /><br /> Example: crm5.dynamics.com<br /><br /> Do not include the name of your organization or Internet protocol (http or https). You will be prompted for that later.                                                                  |
   |                         Is this server configured for Secure Sockets Layer (https) (y/n) [n]                          |                                                                                                                                                                           Type **y** if the URL you use to access [!INCLUDE[pn_crm_2016_shortest](../includes/pn-crm-2016-shortest.md)] begins with https://, otherwise type **n**. [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] users do not see this prompt.                                                                                                                                                                            |
   | Is this organization provisioned in [!INCLUDE[pn_MS_Online_Services](../includes/pn-ms-online-services.md)] (y/n) [n] |                                                                                                                                                                           Type **y** if this is a [!INCLUDE[pn_MS_Online_Services](../includes/pn-ms-online-services.md)] provisioned organization. Otherwise, type **n**.<br /><br /> Only [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] users see this prompt.                                                                                                                                                                           |
   |                                                 Enter domain\username                                                 | For [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)], type your network domain and user name separated by a backslash (\\). For [!INCLUDE [pn-crm-op-edition](../includes/pn-crm-onprem.md)], enter your [!INCLUDE[pn_Windows_Live_ID](../includes/pn-windows-live-id.md)].<br /><br /> On-premises/IFD Example: mydomain\tadams<br /><br /> Online Example: terryadams@somedomain.onmicrosoft.com<br /><br /> If you just press \<Enter> for the user name, the program will look for and use saved credentials. If there are no saved credentials, the program will fail. |
   |                                                    Enter password                                                     |                                                                                                                                                                                                                       Type your password. The characters will show as “\*” in the window. Your password is securely saved in the Microsoft Credential Manager for later reuse.                                                                                                                                                                                                                       |
   |                                       Specify an organization number (1-n) [1]                                        |                                                                                                                                                                                                                       From the list of organizations shown that you belong to, type the corresponding number. The default is 1, indicating the first organization in the list.                                                                                                                                                                                                                       |
   |                                  Do you want these entity records deleted? (y/n) [y]                                  |                                                                                                                                                                              Type **y** for yes and **n** for no. After the program runs, demonstrating create, retrieve, and update of an account record, you can delete the record that was created, or you can leave it so that you can view it in the application.                                                                                                                                                                               |
   |                                                  Press Enter to exit                                                  |                                                                                                                                                                                                                                                                                   Press Enter to exit the program.                                                                                                                                                                                                                                                                                   |

## Next Steps

After running the QuickStart program or most other SDK console-based samples, the server, organization, and user name information you entered when prompted is saved in an XML configuration file for re-use the next time you run a sample. This removes the need to enter that information again as you run additional samples. After the first time, the console prompts are as follows.


|                          Prompt                          |                                                                                                                                                         Description                                                                                                                                                         |
|----------------------------------------------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Specify the saved server configuration number (1-x) [x]: |                                                                Enter zero (0) to create a new server configuration and follow the prompts as shown in the table above. Otherwise, enter the number of a saved configuration as shown in the displayed list.                                                                 |
|                     Enter Password:                      |                                                                                Type your password. The characters will show as “\*” in the window. If your password has been saved from a previous sample run, you will not see this prompt.                                                                                |
|   Do you want these entity records deleted? (y/n) [y]    | Type **y** for yes and **n** for no. After the program runs, demonstrating create, retrieve and update of an account record, you can delete the record that was created, or you can leave it so that you can view it in the Web application or [!INCLUDE[pn_crm_for_outlook_full](../includes/pn-crm-for-outlook-full.md)]. |
|                   Press Enter to exit                    |                                                                                                                                              Press Enter to exit the program.                                                                                                                                               |

 If you would like to add or modify the functionality of this QuickStart program, you can modify the code in the CRUDOperations.cs file.  

 For more information about the helper code files that the QuickStart and many other SDK samples use, refer to the helper source code that handles saving and re-using the server configuration information located under the "SDK Helper Code" folder of the QuickStart sample.  

 A second sample project, named **QuickStart with Simplified Connection**, is included in the [!INCLUDE[pn_Visual_Studio](../includes/pn-visual-studio.md)] solution. This second sample shows a simplified method to connect to the Dynamics 365 Customer Engagement (on-premises) Organization service but is otherwise similar to the first QuickStart sample. This sample does not use any helper code to establish a web service connection.  

### See also  
 [Tutorials for Learning Dynamics 365 Customer Engagement (on-premises)](tutorials-resources-sdk.md)   
 [Sample: Quick Start for Dynamics 365 Customer Engagement](sample-quick-start.md)   
 [Sample: Simplified Connection Quick Start using Dynamics 365 Customer Engagement (on-premises)](/powerapps/developer/data-platform/xrm-tooling/sample-simplified-connection-quick-start)   
 [Write Code for Dynamics 365 Customer Engagement (on-premises)](extend-dynamics-365-server.md)   
 [Sample Code Directory for Dynamics 365 Customer Engagement (on-premises)](sample-code-directory.md)   
 [Build a .NET Business Application in 60 Minutes with xRM and SharePoint](https://www.microsoftpdc.com/2009/PR33)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]