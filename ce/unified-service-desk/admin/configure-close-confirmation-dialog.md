---
title: "Performance enhancement for CRM entity page loads | MicrosoftDocs"
description: "Learn to configure the close confirmation window to prevent the accidental closure of Unified Service Desk."
keywords: ""
ms.date: 08/03/2018
ms.service:
  - "dynamics-365-customerservice"
ms.custom:
  - "dyn365-USD, dyn365-admin"
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 (on-premises)"
  - "Dynamics CRM 2013"
  - "Dynamics CRM 2015"
  - "Dynamics CRM 2016"
ms.assetid: 30FC4B2F-99BD-4CB9-8792-C6062FC051C3
author: kabala123
ms.author: kabala
manager: shujoshi
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
---

# How to configure close confirmation window to prevent accidental closure of Unified Service DeskPerformance enhancement for CRM entity page loads

## Accidental closure of Unified Service Desk

At contact centers, one of the key measure is the Customer Satisfaction (CSAT) where the agents are thriving to increase the CSAT score by solving the customer problems. When you (agent) are working on an important case or attending a customer call using [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)], it may happen that you accidentally closed [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. Perhaps, you may lose all the unsaved work or the customer call is terminated due to the closure of [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. The sudden closure of [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] impacts your productivity and also leads to low CSAT score.

## How to avoid the accidental closure of Unified Service Desk

To avoid the accidental closure of [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)], the close confirmation window feature is introduced, which shows an **Confirm** window with a message.  
  
  ![Close confirmation window in Unified Service Desk](../../unified-service-desk/media/usd-close-confirm-window.PNG "Close confirmation window in Unified Service Desk")

> [!NOTE]
> By default, the close confirmation window is enabled and to disable, Unified Service Desk 

## Enable/Disable Close Confirmation window

By default, Internet Explorer pooling is disabled. To enable pooling, a System Administrator must configure the option on the **Active UII Options** page and set it to **true**.

To enable Internet Explorer pooling:

1. Sign in to [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)].

2. [!INCLUDE[proc_settings_usd](../../includes/proc-settings-usd.md)]

3. Choose **Options**.  

4. click **New** on the **Active UII Options** page.

5. Choose **Others** for the **Global Option** field.

6. Type **InternetExplorerPooling** for the **Name** field.

7. Set **true** for the **Value** field.

8. Click **Save**.

   ![Enable InternetExplorerPooling option](../../unified-service-desk/media/crm-itpro-usd-options-internetexplorerpooling.PNG "Enable InternetExplorerPooling option")

## See also

[Manage Options for Unified Service Desk](../../unified-service-desk/admin/manage-options-unified-service-desk.md)
 
