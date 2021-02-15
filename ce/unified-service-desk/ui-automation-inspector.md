---
title: "UI Automation Inspector in Unified Service Desk | MicrosoftDocs"
description: "Learn about UII Inspector to support the generation of bindings for the UIADDA."
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
# UI Automation Inspector in Unified Service Desk
The [!INCLUDE[pn_uii_acronym](../includes/pn-uii-acronym.md)] Inspector is extended to support the generation of bindings for the UIADDA. This topic describes the logic used to build the binding.  
  
## Logic to build the binding  
  
-   Control Identification is based on the following properties:  
  
    -   `AutomationId`  
  
    -   `Name`  
  
    -   `ClassName`  
  
    -   `IsEnabled`  
  
-   Only the `AndCondition` grouping clause will be used for the generation, because specific properties are used for generation.  
  
-   The `MatchCount` attribute will be generated based on the necessity of the control binding.  
  
> [!NOTE]
>  The `AutomationId` and `Name` properties are dynamic in a few applications and in few scenarios; in those cases, the property needs to be removed from the binding and `MatchCount` needs to be manually updated to set the bindings.  
  
### See also  
 [UIADDA](../unified-service-desk/uiadda.md)   
 [Use Data Driven Adapters (DDAs)](../unified-service-desk/use-data-driven-adapters-ddas.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]