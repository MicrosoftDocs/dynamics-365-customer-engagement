---
title: "Add an activity to a campaign using in-app marketing (Dynamics 365 for Sales) | MicrosoftDocs"
description: "Add planning and campaign activities to a campaign to make it successful."
keywords: "Campaign Activities, Campaign, Quick Campaign, Distribute"
ms.date: 05/01/2018
ms.service: crm-online
ms.custom: 
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 8b0e36fe-695d-44bb-9fe3-de3819bc894d
author: shubhadaj
ms.author: shujoshi
manager: sakudes
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 51
topic-status: Drafting
---

# Add an activity to a campaign using in-app marketing (Sales)

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Make your marketing campaigns successful by creating, distributing, and assigning planning and campaign activities in [!INCLUDE[pn_dynamics_crm](../includes/pn-microsoftcrm.md)]. Planning activities are those you want to perform before you launch the campaign, and campaign activities are those you want to manage as part of the campaign. Examples of planning and campaign activities you can add include:  
  
-   Identify advertising channels and supporting materials  
  
-   Contact media channels to reserve time or space for advertising  
  
-   Create or refine target marketing lists  
  
-   Contact a design agency to request creation of collateral pieces and advertising materials  
  
 By default, a campaign targets an activity to the group of marketing lists that you select for the campaign. If you want to run a campaign activity on a subset of your marketing lists, you can distribute the activity to certain members instead.  
  
<a name="Collapsed1"></a>   
## Add a planning activity to a campaign  
  
1. [!INCLUDE[proc_marketing_campaigns](../includes/proc-marketing-campaigns.md)]  
  
2.  In the campaign record you want to add the planning activity to, on the nav bar, click the down arrow ![User profile security option More Options button](../sales-enterprise/media/user-profile-security-options.gif "User profile security option More Options button") next to the campaign you're working on and then click **Planning Activities**.  
  
3.  To add a new activity, click **Add New Activity**, and then select the type of activity you want to create.  
  
     -OR-  
  
     To add an existing activity, click **Add Existing Activity**. In the inline lookup field, search for and select the activity.  
  
4.  In the new activity form, add or change information in the text boxes.  
  
5.  When you're ready to save your data, click **Save**.  
  
## Add a campaign activity to a campaign  
  
1. [!INCLUDE[proc_marketing_campaigns](../includes/proc-marketing-campaigns.md)]  
  
2.  In the campaign record you want to add the campaign activity to, on the nav bar, click the down arrow ![User profile security option More Options button](../sales-enterprise/media/user-profile-security-options.gif "User profile security option More Options button") next to the campaign you're working on and then click **Campaign Activities**.  
  
3.  Click **Add New Campaign Activity**.  
  
4.  Type in all the information you can, and then click **Save**. This creates the campaign activity so you can do more things with it, like add marketing lists.  
  
5.  To add a marketing list, click **+**. In the **Look Up Records** box, type in your search and click the **Search** button, select one or more marketing lists, and click **Add**.  
  
6.  To distribute the new campaign activity, on the command bar, click **Distribute Campaign Activity**.  
  
7.  In the activity form, type or modify information in the text boxes, and click **Distribute**.  
  
8.  Choose who will own the activities, and click **Distribute**.  
  
    > [!NOTE]
    > 1.  You can only distribute campaign activities of type "mail merge" to marketing lists that contain the same type of record. For example, if one marketing list contains accounts and a second marketing list contains leads, the mail merge campaign activity will fail. Create a separate mail merge campaign activity for each group of marketing lists with the same record type. 
    > 2.  When you distribute a campaign activity or run a quick campaign, and if a contact, account, or lead in the target audience (typically specified in a marketing list) doesn't have data in the Email, Fax, Address, or Primary Phone fields, respective activities like Email, Phone, Letter, and Fax won't be created for that contact, account or lead. 
    > 3. You can add a campaign activity to a campaign as well as a campaign template. However, only non-template campaigns allow distributing campaign activities to the marketing list contacts associated with the campaign.
  
9. After all the distributed activities are closed, you can close the campaign activity. To close the campaign activity, open the campaign activity record, and on the command bar, click **Close Campaign Activity**. Set an appropriate status for the activity, and click **OK**.  
  
10. When the activity is completed, update the campaign activity record with the actual costs. Open the campaign activity and update the **Actual Cost** field. This can help guide you in planning future campaign activities.  
  
  
### See Also  
 [Get started with in-app marketing](../sales-enterprise/get-started-app-marketing-sales.md)   
 [Create a marketing list using in-app marketing](../sales-enterprise/create-marketing-list-using-app-marketing-sales.md)   
 [Create or edit a campaign using in-app marketing](../sales-enterprise/create-edit-campaign-using-app-marketing-sales.md)   
 [Create a quick campaign using in-app marketing](../sales-enterprise/create-quick-campaign-using-app-marketing-sales.md)   
 [Add a marketing list, sales literature, or product to a campaign using in-app marketing](../sales-enterprise/add-marketing-list-sales-literature-product-campaign-using-app-marketing-sales.md)   
 [Track a marketing campaign response using in-app marketing](../sales-enterprise/track-marketing-campaign-response-using-app-marketing-sales.md)   
