---
title: "Display hosted controls in the custom panel layout | MicrosoftDocs"
description: "Learn about specifying the custom panel layout as the display group for your hosted controls by using a syntax."
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
# Display hosted controls in the custom panel layout
After you have created and loaded a custom panel layout in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)], you will need to specify the custom panel layout as the display group for your hosted controls. This is done using a special syntax:  
  
```  
PanelLayoutControlName/NameOfPanelInsideControl  
```  
  
 In the above syntax:  
  
- **PanelLayoutControlName**: This is the name of your custom panel layout hosted control.  
  
    > [!NOTE]
    >  Do not specify the **Display Name** of your custom panel layout control. If this parameter is not specified, it is assumed to be your main panel layout. A main panel layout is the only panel layout hosted control located on the **MainWorkArea** display group. The **MainWorkArea** display group is defined as USDDeckTabPanel, but loading more than one control on this panel is generally not desirable.  
  
- **NameOfPanelInsideControl**: This is the name of the panel inside your custom panel layout. See [Panel types](../unified-service-desk/panels-panel-types-panel-layouts.md#PanelTypes) for the various panels that might be referenced here.  
  
  For example, if you want to configure a hosted control and display it on the MainPanel of your custom panel layout (MyUSDCustomPanelLayout), you will specify the following for as the Display Group value for the new hosted control: **MyUSDCustomPanelLayout/MainPanel**  
  
### See also  
 [Create custom panel layout in Unified Service Desk](../unified-service-desk/create-custom-panel-layout.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]