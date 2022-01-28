---
title: Create organizational units in Service Scheduling (Dynamics 365 Customer Service) | MicrosoftDocs
description: Know how to create organizational units in service scheduling in Dynamics 365 Customer Service
ms.date: 01/13/2022
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
ms.custom: 
  - dyn365-customerservice
---

# Create and manage organizational units  

Create organizational units to organize and maintain a company's business by geography, function, or other areas. You can create multiple organizational units in Service Scheduling to categorize your business by various areas.

## Create a new organizational unit

Make sure that you have the required security role or equivalent permissions. 

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Manage security roles in service scheduling](manage-security-roles.md)

1. Navigate to either on the Customer Service Hub or on Customer Service admin center (preview) app. Depending on your app, perform the following steps:
>
>  ### [Customer Service admin center (preview)](#tab/customerserviceadmincenter)
>
   > [!IMPORTANT]
   > The Customer Service admin center app is in preview. [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
   >
       1. On the Customer Service admin center (preview) site map, select **Operations > Service Scheduling**.
       2. In the **Organizational units** section, select **Manage**.

>  ### [Customer Service Hub](#tab/customerservicehub)
>
       1. On the Customer Service Hub site map, go to **Scheduling**.
       2. From the list of entity records, select **Settings > Organizational Units**.
           - The **Active Organizational Units** view is displayed. You can switch between various system views using the drop-down.
           - Select any existing organizational unit to see additional options in the command bar
     
> 2. On the command bar, select **New** to create a new organizational unit.
> 3. In the **General** section, type a **Name** for the organizational unit.
> 4. In the **Scheduling** section, Provide **Latitude** and **Longitude** for the organizational unit.
> 5. Select **Save** to save the new organizational unit. The new record is saved and activated by default.
  
 > Active organizational units can be edited, assigned, shared, or viewed from the **Active Organizational Units** system view.

   ![create organizational unit.](media/create-org-unit.png)

### See also

[Service Scheduling overview](basics-service-service-scheduling.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
