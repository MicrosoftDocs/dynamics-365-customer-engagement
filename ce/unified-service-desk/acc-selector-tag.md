---
title: "ACCSelector Tag | MicrosoftDocs"
ms.custom: ""
ms.date: "2016-08-01"
ms.reviewer: ""
ms.service: "usd"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 (on-premises)"
  - "Dynamics CRM 2013"
  - "Dynamics CRM 2015"
  - "Dynamics CRM 2016"
ms.assetid: 1dad1353-6b70-42b9-95b6-3893bb022bad
caps.latest.revision: 8
author: "KumarVivek"
ms.author: "kvivek"
manager: "jdaly"
---
# ACCSelector Tag
The `AccSelector` tag uses the [IAccessible](https://msdn.microsoft.com/library/accessibility.iaccessible\(v=vs.110\).aspx) interface from Microsoft Active Accessibility (MSAA) to access controls that allow multiple selections, such as in a list box or combo box. The tag has a name property to define the user-accessible (friendly) name for a control. The [GetControlValue](https://docs.microsoft.com/dotnet/api/microsoft.uii.hostedapplicationtoolkit.datadrivenadapter.operationtype.getcontrolvalue) on an `AccSelector` returns the value of the selected item.  
  
### See also  
 [Win DDA](../unified-service-desk/windda.md)   
 [Use Data Driven Adapters (DDAs)](../unified-service-desk/use-data-driven-adapters-ddas.md)