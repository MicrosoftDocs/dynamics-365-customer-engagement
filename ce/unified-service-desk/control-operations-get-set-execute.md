---
title: "Control Operations (Get, Set, Execute) | MicrosoftDocs"
description: "The operations on a control are executed based on the patterns the automation element exhibits. This topic describes the operations that can be performed on the controls and the default behavior of these operations for the various controls."
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
# Control Operations (Get, Set, Execute)
The operations on a control are executed based on the patterns the automation element exhibits. This topic describes the operations that can be performed on the controls and the default behavior of these operations for the various controls.  
  
 The following operations can be performed on the identified controls:  
  
- Get Control Type  
  
- Set Control Type  
  
- Execute Control Type  
  
  The following table shows the default behavior of these operations for various controls:  
  
|Sl. number|Control type|Get|Set|Execute|  
|----------------|------------------|---------|---------|-------------|  
|1|Button|Gets the name|-|Invokes|  
|2|Calendar|Gets the selected date (not the default date)|-|-|  
|3|Checkbox|Gets the toggle status|-|Toggles|  
|4|Combobox|Gets the selected item name (in multiple selection returns, it returns separated names)|-|Expands or collapses|  
|5|Datagrid|Gets the selected item name (in multiple selection returns, it returns separated names)|-|-|  
|6|Datailtem|Gets the selected item name.|Selects the item|-|  
|7|document|Gets the text|-|-|  
|8|Edit|Gets the text|Sets the text|Selects the text|  
|9|Group|Gets the text|-|Expands or collapses|  
|10|headercontrol|-|-|-|  
|11|headeritem|Gets the text|-|Invokes|  
|12|hyperlink|Gets the text|-|Invokes|  
|13|Image|-|Selects the item|Invokes|  
|14|List|Gets the selected item name (in multiple selection returns, it returns separated names)|-|-|  
|15|Listitem|Gets the selected item name|Selects the item|Invokes, expands or toggles|  
|16|Menu|-|-|-|  
|17|Menubar|-|-|Expands or collapses|  
|18|Menuitem|Gets the text|-|Invokes, expands or toggles|  
|19|Pane|-|-|-|  
|20|progressbar|Gets the range|Sets the range (if possible)|-|  
|21|radiobutton|Selects the item|Selects the item|-|  
|22|scrollbar|Gets the range|Sets the range|-|  
|23|Separator|-|-|-|  
|24|slidercontrol|Gets the range|Sets the range|-|  
|25|spinner|Gets the range|Sets the range|-|  
|26|splitbutton|-|-|Invokes, expands or toggles|  
|27|statusbar|-|-|-|  
|28|Tab|-|-|-|  
|29|Tabitem|Gets the selection status|Selects the tab|-|  
|30|Table|-|-|-|  
|31|Text|Gets the text|-|-|  
|32|Thumb|-|-|-|  
|33|Titlebar|-|-|-|  
|34|Toolbar|-|-|Expands or collapses|  
|35|Tooltip|Gets the text|-|-|  
|36|Tree|Gets the text|Selects the item|-|  
|37|Treeitem|Gets the text|Selects the item|Invokes, expands or toggles|  
|38|window|-|-|-|  
  
### See also  
 [UIADDA](../unified-service-desk/uiadda.md)   
 [Use Data Driven Adapters (DDAs)](../unified-service-desk/use-data-driven-adapters-ddas.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]