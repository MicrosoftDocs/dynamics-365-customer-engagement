---
title: "Enable custom calculation of SLA KPIs in Dynamics 365 Customer Service | MicrosoftDocs"
description: "Learn how to perform custom calculation of SLAs KPIs in Dynamics 365 Customer Service."
ms.date: 03/03/2022
ms.topic: article
author: Soumyasd27
ms.author: sdas
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
  - intro-internal
---

# Enable custom calculation of SLA KPIs

## Introduction

By default, service-level agreements (SLAs) in the terminal status are not reevaluated on case reactivation. But if you want SLAs to be recalculated, such as when a case is reactivated, you can enable the recalculate SLA setting in the service configuration settings. When you enable the setting, the applicable when and success criteria for the SLA will be evaluated again when the case is reactivated. 

## Enable recalculation of SLAs on reaching terminal status

You can enable the recalculation of SLAs that reach the terminal status in the Customer Service admin center (preview) or Customer Service Hub app.

1. Go to one of the apps, and perform the following steps.

   ### [Customer Service admin center (preview)](#tab/customerserviceadmincenter)

   > [!IMPORTANT]
   > The Customer Service admin center app is in preview. [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]

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
[How SLAs are applied](define-service-level-agreements.md#how-is-the-sla-applied)  
[Enable records for SLA](enable-entities-service-level-agreements.md)  
