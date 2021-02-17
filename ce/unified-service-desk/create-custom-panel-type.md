---
title: "Create a custom panel type | MicrosoftDocs"
description: "Learn about creating a custom panel type."
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 08/23/2017
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-USD
search.audienceType: 
  - customizer
  - developer
search.app: 
  - D365CE
  - D365USD
---
# Create a custom panel type
Creating a new panel type is considered an advanced topic, and only those intimately familiar with [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] should attempt to create a new panel type.  
  
 A panel type must implement two interfaces:  
  
- [IPanel](https://docs.microsoft.com/dotnet/api/microsoft.uii.desktop.ui.controls.ipanel): This interface enables [!INCLUDE[pn_customer_care_accelerator](../includes/pn-customer-care-accelerator.md)] (CCA) support. However, as CCA by itself does not support custom panels, if you only implement this interface, you still may not use it with CCA.  
  
- [IUSDPanel](https://docs.microsoft.com/dotnet/api/microsoft.crm.unifiedservicedesk.dynamics.panellayouts.iusdpanel): This interface provides the additional functions that are needed to support custom panel types in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)].  
  
  If these two interfaces are implemented correctly, they may be used with [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] panel layouts to perform advanced layouts.  
  
### See also  
 [Panels, panel types, and panel layouts in Unified Service Desk](../unified-service-desk/panels-panel-types-panel-layouts.md)   
 [Move hosted controls between panels at runtime](../unified-service-desk/move-hosted-controls-between-panels-runtime.md)   
 [Create custom panel layout in Unified Service Desk](../unified-service-desk/create-custom-panel-layout.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]