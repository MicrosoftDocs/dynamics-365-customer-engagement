---
title: "UIA Extensibility in Unified Service Desk | MicrosoftDocs"
description: "Learn about UIA extensibility in Unified Service Desk."
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
# UIA Extensibility in Unified Service Desk
A `data` argument can be added to each of the different DDA `OperationHandler` methods to enable UIA extensibility. You can use this parameter to extend the DDA as needed. By default, if this parameter is null, the different methods of the DDA will follow the default behavior. You should be able to set the content of this parameter to an object. This topic describes how to extend UIA using the `data` parameter.  
  
 For each of the following activities, the `Execute` method of the corresponding activity builds the data object to be passed to the `OperationHandler` method of the DDA. A `Data` parameter is included in the following activities:  
  
- `GetControlValue`: **"Desired Pattern to use/Desired Property name to retrieve"** can be passed to the data parameter to retrieve the specified property. The property can be any one from the [UIA property list](../unified-service-desk/uia-property-list.md).  `ControlProperty` – Specifies which property the DDA should be retrieving.  
  
- `SetControlValue`: **"Desired pattern Name" (Desired Pattern to use)** shall be passed to the data parameter to perform the pattern selection. The pattern can be any one from the [UIA Pattern List](../unified-service-desk/uia-pattern-list.md).  `ControlProperty` – Specifies which property the DDA should be assigning.  
  
- `ExecuteControlValue`: **"Desired pattern Name" (Desired Pattern to use)** shall be passed to the data parameter to perform the pattern execution. The pattern can be any one from the [UIA Pattern List](../unified-service-desk/uia-pattern-list.md) later in this section.  
  
- `RegisterActionForEvent`: **"For PropertyChangedEvent"** (data property) can be used to specify the property on which the event will be triggered. The property can be any one from the [UIA property list](../unified-service-desk/uia-property-list.md) later in this section.  
  
  This is used to pass any data from workflow activity to the adapter. This data can be consumed by the DDA or by extending the DDA.  
  
### See also  
 [UIADDA](../unified-service-desk/uiadda.md)   
 [Use Data Driven Adapters (DDAs)](../unified-service-desk/use-data-driven-adapters-ddas.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]