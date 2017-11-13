---
title: "Manage access to Dynamics 365 Customer Engagement apps by using security roles | MicrosoftDocs"
description: ""
keywords: ""
ms.date: 10/25/2017
ms.service: crm-online
ms.custom: 
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: c00f867d-78f0-4f3e-a716-f7b25f9d343a
ms.author: shujoshi
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 11
topic-status: Drafting
---

# Manage access to apps by using security roles

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

You can choose what users see and access from My Apps or the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] home page by giving app access to specific security roles. Users will have access to apps based on the security roles they are assigned to.  
  
1.  Go to **Settings** > **My Apps**.  
  
2.  In the lower right corner of the app tile you want to manage access for, select the **More options** button (**...**), and then select **Manage Roles**.  
  
3.  Enter the following in the **Manage Roles** dialog box:  
  
    a. **App URL Suffix**. The URL  you chose while creating the app is shown here by default. Enter another app URL suffix, if required. This is optional, and is used to create an easy-to-remember URL for the app. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create or edit an app](../customize/create-edit-app.md).
    
    You cannot export or import the App URL suffix through a solution at this time. 
    
    b. **Roles**. Choose whether you want to give app access to all security roles or selected roles. If you choose **Give access only to these roles**, select the specific security roles.  

      ![Manage security roles for the app](../customize/media/app-manage-roles.png "Manage security roles for the app")

    c. Select **Save**.  
  
4.  Refresh the **My Apps** page.  
  
5.  Go to the **Apps Being Edited** view, and publish the app again.  
  
### See also  
 [Design custom business apps by using the app designer](design-custom-business-apps-using-app-designer.md)
