---
title: "Enable change tracking to control data synchronization  | MicrosoftDocs"
ms.custom: 
ms.date: 10/01/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
ms.assetid: 3fa9c316-9dc9-4b28-9abf-43a3fce5b01d
caps.latest.revision: 5
author: jimholtz
ms.author: jimholtz
search.audienceType: 
  - admin
---
# Enable change tracking to control data synchronization

::: moniker range="op-9-1"
[!INCLUDE [cc-use-advanced-settings](../includes/cc-use-advanced-settings.md)]
::: moniker-end

Large Dynamics 365 Customer Engagement (on-premises) organizations that synchronize their data with external data sources can now enable entities for change tracking. You can export or retrieve a selected set of Customer Engagement (on-premises) data, and then keep the external data warehouse in sync.  
  
 By selecting, or deselecting, change tracking for specific entities you can reduce the load on your server resources and save processing time when extracting Customer Engagement (on-premises) data and synchronizing it to an external store. You can enable change tracking for both system and custom entities.  
  
1. [!INCLUDE[proc_customization_customize_system](../includes/proc-customization-customize-system.md)]  
  
2. Select an entity, and under **Data Services**, select the **Change Tracking** check box.  
  
   ![Select Change Tracking for an entity](../admin/media/change-tracking.PNG "Select Change Tracking for an entity")  
  
### See also  
 [](../admin/manage-your-data.md "Manage your data")


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]