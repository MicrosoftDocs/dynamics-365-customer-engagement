---
title: "ACCSelector Tag | MicrosoftDocs"
description: "Learn about the AccSelector tag uses the IAccessible interface from Microsoft Active Accessibility (MSAA) to access controls that allow multiple selections, such as in a list box or combo box."
author: mh-jaya
ms.author: v-jmh
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
# ACCSelector Tag
The `AccSelector` tag uses the [IAccessible](https://msdn.microsoft.com/library/accessibility.iaccessible\(v=vs.110\).aspx) interface from Microsoft Active Accessibility (MSAA) to access controls that allow multiple selections, such as in a list box or combo box. The tag has a name property to define the user-accessible (friendly) name for a control. The [GetControlValue](https://docs.microsoft.com/dotnet/api/microsoft.uii.hostedapplicationtoolkit.datadrivenadapter.operationtype.getcontrolvalue) on an `AccSelector` returns the value of the selected item.  
  
### See also  
 [Win DDA](../unified-service-desk/windda.md)   
 [Use Data Driven Adapters (DDAs)](../unified-service-desk/use-data-driven-adapters-ddas.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]