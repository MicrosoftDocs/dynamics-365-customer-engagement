---
title: Create a simple selection rule (Dynamics 365 Customer Service) | MicrosoftDocs
description: See how to create a simple selection rule in Dynamics 365 Customer Service
ms.date: 09/15/2017
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 53a455a1-a107-4a70-9971-c6a5d59fda7a
author: lalexms
ms.author: laalexan
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
ms.custom: 
  - dyn365-customerservice
search.app: 
  - D365CE
  - D365FS
---

# Create a selection rule to determine how resources are selected for service activities (Customer Service)

Before you can add a resource to a service, you must define a selection rule to determine how resources are selected for service activities. 

> [!IMPORTANT]
> Service scheduling has been deprecated. For more information, see [Important changes coming](https://docs.microsoft.com/dynamics365/get-started/whats-new/customer-engagement/important-changes-coming).
  
You can create a simple rule that selects resources from a list, and nest selection rules and sub-rules to create compound and complex rules. A compound rule selects a combination of resources, and a complex tree of selection rules selects from groups of equivalent resources.  
  
You can also add resources to existing selection rules.

> [!NOTE]
> This procedure assumes that no selection rules have been created previously for this service.  
  
1. [!INCLUDE[proc_permissions_mgr_vp_sys_admin_sys_cust](../includes/proc-permissions-mgr-vp-sys-admin-sys-cust.md)]  
  
    #### Check your security role  
  
   - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  
  
   - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  
  
2. [!INCLUDE[proc_settings_bus_management](../includes/proc-settings-bus-management.md)]  
  
3. Click **Services**.  
  
4. In the list of services, open the service to which you want to add a selection rule.  
  
5. On the **Service** form, click **Required Resources**, and then double-click or double-tap the first selection rule in the right pane.  
  
    Selection rules appear in the tree beside the **Selection Rule** button ![Selection rule button](../customer-service/media/crm-ua-selection-rule-folder.gif "Selection rule button").  
  
6. In the **Edit a Selection Rule** dialog box, enter the following information:  
  
   - **Quantity**  
  
        Select the number of resources required for the service. If you select **All**, all the selected resources are included in the service activity.  
  
   - **Description**  
  
        Enter any additional information about the scheduling rule you want to include.  
  
   - **Selection Site**  
  
        This option defines whether the resources must all be from the same site or if they can be from any site in the business unit. This option is available only in the top-level selection rule.  
  
7. Click **OK**.  
  
8. Under **Common Tasks**, you can add resources:  
  
   -   To add individual users, facilities, equipment or teams to the selection rule, click **Add Resources**.  
  
        In the **Look Up Records** dialog box, select the records you want to add. You can add as many records as you want, and they can be a mix of individual users, facilities, equipment, and teams.  
  
   -   To add resource groups to the selection rule, click **Add Resource Groups**.  
  
        In the **Look Up Records** dialog box, select the records you want to add. You can add as many records as you want.  
  
   > [!TIP]
   >  If you select multiple users in the **Look Up Records** dialog box and click **OK**, the **Save the selection as a Resource Group** dialog box opens. If you want to create a resource group from the selected resources, click **Yes, save the selection as a resource group with the name**, enter a name in the box, and then click **OK**. The new resource group appears in the selection tree.  
  
9. Click **OK**.  
  
10. Click **Save** or **Save and Close**.  
  
> [!TIP]
>  After you set up the selection rule, create a service activity for the service rule and check the search results to verify that the results are what you expect.  
  
### See also     
 [Schedule a service activity](../customer-service/schedule-service-activity-cs-app.md)  
 [Create or change a resource group](create-edit-resource-group.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
