---
title: "AccSelector tag | MicrosoftDocs"
description: "Learn about the AccSelector tag to access controls that allow multiple selections such as a list box or combo box."
ms.date: 06/27/2024
ms.topic: article
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
search.audienceType: 
  - customizer
  - developer
ms.custom: evergreen
---
# AccSelector tag
The `AccSelector` tag uses the [IAccessible](https://msdn.microsoft.com/library/accessibility.iaccessible\(v=vs.110\).aspx) interface from Microsoft Active Accessibility (MSAA) to access controls that allow multiple selections, such as in a list box or combo box. The tag has a name property to define the user-accessible (friendly) name for a control. The [GetControlValue](/dotnet/api/microsoft.uii.hostedapplicationtoolkit.datadrivenadapter.datadrivenadapterbase.getcontrolvalue) on an `AccSelector` returns the value of the selected item.  
  
### See also  
 [Win DDA](../unified-service-desk/windda.md)   
 [Use Data Driven Adapters (DDAs)](../unified-service-desk/use-data-driven-adapters-ddas.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
