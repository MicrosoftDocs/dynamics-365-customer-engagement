---
title: Create organizational units in Service Scheduling (Dynamics 365 Customer Service) | MicrosoftDocs
description: Know how to create organizational units in service scheduling in Dynamics 365 Customer Service
ms.date: 04/04/2022
ms.topic: article
author: neeranelli
ms.author: nenellim
search.audienceType: 
  - admin
  - customizer
  - enduser
ms.custom: 
  - dyn365-customerservice
---

# Create and manage organizational units  

## Introduction

Create organizational units to organize and maintain a company's business by geography, function, or other areas. You can create multiple organizational units in Service Scheduling to categorize your business by various areas.

## Create a new organizational unit

Make sure that you have the required security role or equivalent permissions. 

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Manage security roles in service scheduling](manage-security-roles.md)

You can create a new organizational unit in the Customer Service admin center or Customer Service Hub app.

1. Go to one of the apps, and perform the following steps.

   ### [Customer Service admin center](#tab/customerserviceadmincenter)

    1. In the site map, select **Service Scheduling** in **Operations**. The **Service Scheduling** page appears.
    1. In the **Organizational units** section, select **Manage**.                                                                         
        
        The **Active Organizational Units** view is displayed. You can switch between various system views using the drop-down list.  

   ### [Customer Service Hub](#tab/customerservicehub)

    1. In the site map, go to **Scheduling**.
    1. From the list of entity records, select **Organizational units** in **Settings**.                                                              
       
       The **Active Organizational Units** view is displayed. You can switch between various system views using the drop-down list.  
     
 2. On the command bar, select **New** to create a new organizational unit.
 3. In the **General** section, type a **Name** for the organizational unit.
 4. In the **Scheduling** section, Provide **Latitude** and **Longitude** for the organizational unit.
 5. Select **Save** to save the new organizational unit. The new record is saved and activated by default.
  
  Active organizational units can be edited, assigned, shared, or viewed from the **Active Organizational Units** system view.
  
   ![create organizational unit.](media/org_units.png)

### See also

[Service Scheduling overview](basics-service-service-scheduling.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
