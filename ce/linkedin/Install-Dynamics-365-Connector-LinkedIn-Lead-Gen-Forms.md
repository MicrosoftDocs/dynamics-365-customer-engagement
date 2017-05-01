---
title: "Install Dynamics 365 Connector LinkedIn Lead Gen Forms | MicrosoftDocs"
ms.custom: ""
ms.date: "05/01/2017"
ms.reviewer: ""
ms.service: "LinkedIn"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: "Dynamics 365 (online)"
ms.assetid: 1f4ee997-8460-4f6c-a77e-138e850ecd97
author: "saurabh-kudesia"
ms.author: "mhart"
manager: "sakudes"
---
# Install the Microsoft Dynamics 365 Connector LinkedIn Lead Gen Forms from AppSource
The Dynamics 365 Connector for LinkedIn Lead Gen Forms capabilities are a solution for Microsoft Dynamics 365 (online), hosted on [Microsoft AppSource](https://appsource.microsoft.com/en-us/product/dynamics-crm/mscrm.6f943d2a-83cd-4c0c-8314-ef7d066a9a65-preview?flightCodes=Dyn@m1c$) that a system administrator needs to install before pulling lead data from LinkedIn to Dynamics 365.
><b>Important</b></br>
You can only benefit from this connector when you use LinkedIn Lead Gen in your campaigns on LinkedIn. 

## Prerequisites
* To install the solution, you’ll need global admin permissions in Office 365 and system administrator or customizer permissions in Microsoft Dynamics 365 (online).
* The capabilities in this solution require the December 2016 update for Microsoft Dynamics 365 (online).
* To sync leads from LinkedIn and run campaigns on LinkedIn, you need access a LinkedIn account which can manage sponsored content using the Campaign Manager in LinkedIn. More information: [LinkedIn: Campaign Manager Overview](https://www.linkedin.com/help/lms/answer/5696), [LinkedIn: Creating an Account for Campaigns](https://www.linkedin.com/help/lms/topics/8121/8122/5749), [LinkedIn: Adding, Editing, and Removing User Permissions on Advertising Accounts](https://www.linkedin.com/help/lms/answer/5753)
* We recommend using the latest version of Edge, Chrome, Firefox or Safari.

## Download and Install the solution from AppSource
1.	Get the app package from [Microsoft AppSource](https://appsource.microsoft.com/en-us/product/dynamics-crm/mscrm.6f943d2a-83cd-4c0c-8314-ef7d066a9a65-preview?flightCodes=Dyn@m1c$).
2.	Sign in to your Microsoft Dynamics 365 (online) system admin account.
3.	Click <b>Try</b> to start installing the solution.
4.	Review and accept the disclaimer and the terms to add Dynamics 365 Connector for LinkedIn Lead Gen Forms to Microsoft Dynamics 365 (online). 
It takes a few minutes to install the solution. Please wait 10-15 minutes after installing the solution and then proceed further. 
><b>Tip</b> </br>
To monitor the status of the installation or remove a managed solution, go the [Office 365 admin center](https://portal.office.com/). More information: [TechNet: Use the Office 365 admin center to manage your Dynamics 365 (online) subscription in Dynamics 365](https://technet.microsoft.com/library/dn973004.aspx).

5.	In Dynamics 365, go to <b>Settings > Customization > Solutions</b> and click **LinkedIn Lead Gen Forms Connector** to see the solution details. 
![LinkedIn Lead Gen Forms Connector solution detail](media/Solution-details.png.png "LinkedIn Lead Gen Forms Connector solution details")
6.	Click **Authorize** to open a new browser tab where you need to **Accept** the needed permissions to complete the installation of Dynamics 365 Connector for LinkedIn Lead Gen Forms. You need to be a global admin in this Office 365 tenant to authorize S2S inbound. For more information about S2S, see [MSDN: Build web applications using Server-to-Server (S2S) authentication](https://msdn.microsoft.com/en-us/library/mt790168.aspx)

The solution creates new security roles: 
-	**LinkedIn Lead Gen Forms Administrator**: Configures Lead Matching Strategies, LinkedIn Field Mapping, and configures the solution settings for Dynamics 365 Connector for LinkedIn Lead Gen Forms.
-	**LinkedIn Lead Gen Forms Salesperson**: Can authorize LinkedIn user profiles to sync data to Dynamics 365, view details about the synced submissions. 

Assign these security roles to users to have them find the **LinkedIn Lead Gen** menu item in Dynamics 365 (online). To learn how to assign a security role to users, see [TechNet: Create users and assign Microsoft Dynamics 365 (online) security roles](https://technet.microsoft.com/en-us/library/jj191623.aspx#BKMK_AssignSecurity).
For more information about installing or removing a solution, see [TechNet: Install or remove a preferred solution](https://technet.microsoft.com/en-us/library/dn878909.aspx).
## See also
