---
title: Create or change a resource group (Dynamics 365 Customer Service) | MicrosoftDocs
description: Create or change a resource group in Dynamics 365 Customer Service
ms.date: 09/15/2017
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 5e461837-29ca-4d76-9231-cbf7423c5c7d
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

# Create or change a resource group (Customer Service)

Use resource groups to group users, facilities, and equipment as part of the selection rules for a service.

> [!IMPORTANT]
> Service scheduling has been deprecated. For more information, see [Important changes coming](https://docs.microsoft.com/dynamics365/get-started/whats-new/customer-engagement/important-changes-coming).
  
1. [!INCLUDE[proc_settings_bus_management](../includes/proc-settings-bus-management.md)]  
  
2. Click **Resource Groups**.  
  
3. On the Actions toolbar, click **New**.  
  
4. In the **Resource Groups** form, enter information in the following fields:  
  
   - **Name**  
  
        You must enter a name for the resource group. [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] does not check that the name is unique.  
  
   - **Business Unit**  
  
        To locate and select a business unit, click the **Lookup** button ![Lookup button](../customer-service/media/crm-ua-lookup-v4.gif "Lookup button").  
  
   - **Description**  
  
        You can add a detailed description of this resource group, including the criteria that you used to determine which resources to add to the resource group.  
  
5. Click **Save**.  
  
    After you save the record, **Resources** appears under **Common**.  
  
6. Click **Resources**, and then on the Actions toolbar, click **Add Resources**.  
  
7. In the **Look Up** dialog box, select the users, facilities/equipment, teams, or other resource groups to add to this resource group.  
  
    Adding other resource groups to a resource group is a good way to manage large numbers of resources. For example, you could add the resource groups of "senior technicians" and "junior technicians" to a resource group of "technicians."  
  
8. Click **OK** to add the selected resources to the resource group.  
  
9. Click **Save** or **Save and Close**.  
  
## Edit a resource group  
  
1. [!INCLUDE[proc_settings_bus_management](../includes/proc-settings-bus-management.md)]
  
2. Click **Resource Groups**.  
  
3. Open the resource group you want to change.  
  
4. In the **Resource Groups** form, change the information.  
  
5. Click **Save** or **Save and Close**.  
  
> [!NOTE]
>  Resource groups are published automatically when you save and close the form. If the new resource group doesn’t appear in the list of available resource groups for a service, or if changes are not appearing, you can manually publish the change by clicking **Publish** on the **Resource Groups** page.  
> 
>  To remove a resource, select the resource you want to remove from the resource group. On the Actions toolbar, click **More Actions**, and then click **Remove Resources**.  
> 
> [!INCLUDE[cc_solution_recommendation](../includes/cc-solution-recommendation.md)]  
  
 


[!INCLUDE[footer-include](../includes/footer-banner.md)]
