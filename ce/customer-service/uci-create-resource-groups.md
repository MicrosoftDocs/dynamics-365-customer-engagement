---
title: Create resource groups | Microsoft Docs
description: How to create resource groups in Unified Interface-based Scheduling Service for Dynamics 365 Customer Service.
ms.date: 04/04/2022
ms.topic: article
author: lalexms
ms.author: laalexan
search.audienceType: 
  - admin
  - customizer
  - enduser
ms.custom: 
  - dyn365-customerservice
---

# Create resource groups


Use resource groups to group users, facilities, and equipment as part of the selection rules for a service.

## Create a resource group

Before you begin, make sure you have the Scheduler Manager role or equivalent permissions.

1. Navigate to the Customer Service admin center or Customer Service Hub app, and perform the following steps:

   ### [Customer Service admin center](#tab/customerserviceadmincenter)

    1. In the site map, select **Service Scheduling** in **Operations**. The **Service Scheduling** page appears.
    1. In the **Resource group** section, select **Manage**.
        
        The **Local Resource Groups** view is displayed. You can switch between various system views using the drop-down list.  

   ### [Customer Service Hub](#tab/customerservicehub)

    1. In the site map, go to **Scheduling**.
    1. From the list of entity records, select **Resource Groups** in **Scheduling**.
       
       The **Local Resource Groups** view is displayed. You can switch between various system views using the drop-down list.

2. Select **New**. 

3. In the Resource Groups form, enter information in the following fields: 

    - **Name**: You must enter a name for the resource group. The application does not check that the name is unique.

    - **Business Unit**: To locate and select a business unit, select the Lookup button.
  
    - **Description**: You can add a detailed description of this resource group, including the criteria that you used to determine which resources to add to the resource group. 

   ![New Resource Group.](media/uci-new-resource-group.png "Add details for a new resource group")
  
4. Select **Save**.
    After you save the record, **Resources** appears under **Common**. 

5. Select **Resources**, and then on the **Actions** toolbar, select **Add Resources**. 

6. In the **Look Up** dialog box, select the users, facilities/equipment, teams, or other resource groups to add to this resource group.

    Adding other resource groups to a resource group is a good way to manage large numbers of resources. For example, you could add the resource groups of "senior technicians" and "junior technicians" to a resource group of "technicians."

   ![Add Resources.](media/uci-add-resource.png "Add other resources to your Resource Group")
    
7. Select **OK** to add the selected resources to the resource group.

8. Select **Save** or **Save and Close**.

## Edit a resource group

1. Navigate to either on the Customer Service Hub or on Customer Service admin center app. Depending on your app, perform the following steps:

   ### [Customer Service admin center](#tab/customerserviceadmincenter)

    1. In the site map, select **Service scheduling** in **Operations**.
    1.  In the **Resource group** section, select **Manage**.
        
        The **Local Resource Groups** view is displayed. You can switch between various system views using the drop-down list.  

   ### [Customer Service Hub](#tab/customerservicehub)

    1. In the site map, go to **Scheduling**.
    1. From the list of entity records, select **Resource Groups** in **Scheduling**.
      
      The **Local Resource Groups** view is displayed. You can switch between various system views using the drop-down list.

3. Open the resource group you want to change, and then in the **Resource Groups** form, change the information. 

4. Select **Save** or **Save and Close**. 

   ![Edit Resource Group.](media/uci-change-resource.png "Edit the resources in your Resource Group")
   
### See also  

[Unified Interface-based service scheduling overview](uci-scheduling-overview.md)

[Create or edit a service](uci-create-edit-service.md)

[Add facilities and equipment](uci-add-facilities-equipment.md)

[Schedule a service activity](uci-schedule-service-activity.md)

[Use sites to manage your service locations](uci-create-sites.md)

[Navigate the service calendar](uci-navigate-service-calendar.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
