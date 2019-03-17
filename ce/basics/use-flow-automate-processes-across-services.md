---
title: "Use Microsoft Flow to automate processes across services (Dynamics 365 for Customer Engagement) | MicrosoftDocs"
ms.custom: 
ms.date: 01/31/2019
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: 7aebc737-667f-44d1-bb05-e4573be1e0b2
caps.latest.revision: 7
applies_to: 
  - Dynamics 365 for Customer Engagement apps
  - Dynamics 365 for Customer Engagement Version 9.x
author: Mattp123
ms.author: matp
search.audienceType: 
  - enduser
search.app: 
  - D365CE
---
# Use Microsoft Flow to automate processes across services

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Microsoft Flow lets you create automated processes between your favorite apps and services. From within [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)], you can run a Flow on one or more records. Also, you can open Microsoft Flow from [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] to view, edit, or create new flows.  
  
> [!NOTE]
>  To manage and run Microsoft Flow from [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)], Microsoft Flow must be enabled in System Settings for you organization. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Enable embedded Flow in your organization](../admin/enable-embedded-flow-in-your-organization.md)  
  
## Manage your flows  
 Connect with Microsoft Flow from [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] to manage your flows.  
  
1. On the Actions toolbar, select **Flows**.  
  
   ![Create, see, or run a flow.](../basics/media/embedflow-create.png "Create, see, or run a flow.")  
  
2. The following options appear:  
  
   -   Select **Create a flow** to open a new browser tab and direct you to the Microsoft Flow site. On the Microsoft Flow page, select Continue to use an existing template or select X to close choose or create a different one.  
  
   -   Select **See your flows** to open a new browser tab and direct you to the Microsoft Flow site where any flows in the Flow environment are displayed.  
  
   -   Select **Login to flow** to connect with Microsoft Flow and display available flows for you to run. This only appears if you aren’t currently signed in to Microsoft Flow.  
  
   -   Select a flow to run. See [Run an embedded flow from Dynamics 365 for Customer Engagement apps](#Flow_run).  
  
<a name="Flow_run"></a>   
## Run an embedded flow from [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]  
 You can run a flow from views, forms, and Advanced Find.  
  
1. Select the records that you want to run the flow on. Notice that you won’t see any flows run until you select one or more records or have a record open.  
  
2. On the Actions toolbar, select **Flows**, and then under **Run** select the flow that you want to run.  
  
    Flows that include actions for entities associated with your current location in the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] app appear under Run on the Flow menu. Only flows with the **When a record is selected** trigger for an account record will appear in the **Active Accounts** view.  
  
   > [!TIP]
   >  If you don’t see any flows under Run, click **Login to flow**.  
  
   ![Run a flow from Dynamics 365 for Customer Engagement apps](../basics/media/embedflow-run.png "Run a flow from Dynamics 365 for Customer Engagement apps")  
  
3. If required, input additional information. Then, follow the instructions on your screen to run the flow.  

## Known issues
### Flow commands do not respond from your mobile device
When you tap a Flow command, such as **Login to Flows**, **Create a Flow**, or **See your Flows**, from your mobile device, the command does not respond.

This occurs when your [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] instance has the [!INCLUDE [pn-crm-9-0-0-online](../includes/pn-crm-9-0-0-online.md)], and your device has an earlier version of [!INCLUDE [pn-dyn-365-phones](../includes/pn-dyn-365-phones.md)] or [!INCLUDE [pn-dyn-365-tablets](../includes/pn-dyn-365-tablets.md)]. To work around this issue, remove the current app, and install the latest app. [Install Dynamics 365 for Customer Engagement appsfor phones and tablets](https://docs.microsoft.com/dynamics365/customer-engagement/mobile-app/install-dynamics-365-for-phones-and-tablets)

  
### See Also  
 [Enable embedded Flow in your organization](../admin/enable-embedded-flow-in-your-organization.md)   
 <!--[It’s all part of the (business) process](It%E2%80%99s%20all%20part%20of%20the%20\(business\)%20process.md)   
 [Navigate with tiles](Navigate%20with%20tiles.md)-->
