---
title: Recalculate SLAs in terminal status in Dynamics 365 Customer Service
description: Learn how to configure recalculation of SLAs that reach the terminal status in Dynamics 365 Customer Service.
ms.date: 03/08/2023
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
search.audienceType: 
  - admin
  - customizer
  - enduser
ms.custom: 
  - bap-template
  - dyn365-customerservice
  - intro-internal
---

# Recalculate SLAs in terminal status

By default, SLAs in the terminal status are not reevaluated on case reactivation. But if you want SLAs to be recalculated, such as when a case is reactivated, you can enable the recalculate SLA setting in the service configuration settings. When you enable the setting, the applicable when and success criteria for the SLA will be evaluated again when the case is reactivated.

## Enable recalculation of SLAs on reaching terminal status

You can enable the recalculation of SLAs that reach the terminal status in the Customer Service admin center or Customer Service Hub app.

1. Go to one of the apps, and perform the following steps.

   ### [Customer Service admin center](#tab/customerserviceadmincenter)

    1. In the site map, select **Service Terms** in **Operations**.
    1. In the **Other SLA Settings** section, select **Manage**.                                                                         
        
        The **Service Configuration Settings** view is displayed. 

   ### [Customer Service Hub](#tab/customerservicehub)

    1. In the site map, Go to **Service Management**.
    1. From the list of entity records, select **Service Configuration Settings** in **Service Terms**.      

        The **Service Configuration Settings** view is displayed.            

2. In **Recalculate SLA on terminal status**, set the toggle to yes, and select **Save**.

    :::image type="content" source="media/sla-recalculate.png" alt-text="Enable recalculate SLA on reaching terminal status.":::

### See also

[Define service-level agreements](define-service-level-agreements.md)  
[Apply SLAs](apply-slas.md#apply-slas) 
[Enable records for SLA](enable-entities-service-level-agreements.md)  
