---
title: "Configure matching strategy | MicrosoftDocs"
ms.custom: ""
ms.date: "05/01/2017"
ms.reviewer: ""
ms.service: "LinkedIn"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: "Dynamics 365 (online)"
ms.assetid: 4140669d-2155-4f43-a4fc-253b67e42f7d
author: "saurabh-kudesia"
ms.author: "mhart"
manager: "sakudes"
---
# Connect Dynamics 365 (online) and LinkedIn
Before we can sync leads from LinkedIn campaign accounts to a Dynamics 365 organization, a LinkedIn member with access to LinkedIn Campaign Manager is required to authorize their LinkedIn accounts in Dynamics 365 (online). In Dynamics 365 (online), this user requires at least a LinkedIn Lead Gen Forms Connector Salesperson security role. 
For more information about assigning security roles to users, see [TechNet: Create users and assign Microsoft Dynamics 365 (online) security roles](https://technet.microsoft.com/en-us/library/jj191623.aspx).
## Authorize Dynamics 365 to sync data from the LinkedIn Campaign Manager
1.	In Dynamics 365, go to **Sales > LinkedIn Lead Gen Forms > LinkedIn User Profile**.
2.	To add a new LinkedIn User Profile record, click **New** and provide a Name before clicking **Save**.
3.	To add LinkedIn accounts to this user profile, click **Authorize**.
4.	Enter the credentials for your LinkedIn profile and click **Sign In**. </br>
(![Sign In](media/Add-credentials-to-linked-profile.png "Add credentials to LinkedIn profile")) </br>
5.	In the permissions pop-up dialog, click **Allow**. </br>
(![Allow permissions](media/LinkedIn-permission-popup-dialog.png "LinkedIn permission popup dialog")) </br>
6.	Check and confirm the Dynamics 365 organization you want to sync your LinkedIn data to.</br>
(![LinkedIn permission popup dialogs](media/Confirm-dynamics-365-organization-to-sync-linkedin-data.png "LinkedIn permission popup dialog")) </br>
 
After successful authorization, the LinkedIn accounts show on the **LinkedIn User Profile** record. It may take a few seconds to get the accounts, and you can review the details of the **LinkedIn Account**s in the form. Try refreshing the view if you don’t see the accounts.

LinkedIn form submissions are now synced automatically to Dynamics 365. It might take a few minutes to complete, and you’ll be able to see the data in Dynamics 365.
Optionally, you can trigger an on-demand sync of LinkedIn form submissions after authorizing a profile by clicking **Sync submissions**.

[Image missing]

## See Also
