---
title: "UI Automation Inspector in Unified Service Desk for Dynamics 365 Customer Engagement| MicrosoftDocs"
description: "Learn about UII Inspector to support the generation of bindings for the UIADDA."
ms.custom:
  - dyn365-USD
ms.date: 08/23/2017
ms.reviewer: ""
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 (on-premises)"
  - "Dynamics CRM 2013"
  - "Dynamics CRM 2015"
  - "Dynamics CRM 2016"
ms.assetid: 8c3e2962-56df-427c-98bf-7fc4fb395749
caps.latest.revision: 7
author: kabala123
ms.author: kabala
manager: sakudes
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
