---
title: "Configure Bing maps (Dynamics 365 Customer Engagement) | MicrosoftDocs"
ms.custom: ""
ms.date: 09/30/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: f9729664-561c-4758-86ce-7216d68075d9
caps.latest.revision: 63
ms.author: "matp"
author: "matp"
manager: "brycho"
---
# Configure Bing maps

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

 Bing Maps can be displayed in Dynamics 365 Customer Engagement forms for the account, contact, lead, quote, order, invoice, competitor, and system user forms. You can remove the Bing Maps area in the form editor or add it back by using the **Bing Maps** button on the **Insert** tab of the form editor.  
  
 To enable Bing Maps the system setting **Show Bing Maps on forms** must be enabled.  
  
|Tab|Property|Description|  
|---------|--------------|-----------------|  
|**General**|**Label**|**Required**: A label to display for the Bing Maps.|  
||**Display label on the form**|Whether the label should be displayed.|  
||**Select an address to use with the Bing Maps control**|Choose which address should be used to provide data for the map.|  
||**Visible by default**|Showing the Bing maps is optional and can be controlled using scripts. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Visibility options](../customize/visibility-options-legacy.md)|  
|**Formatting**|**Select the number of columns the control occupies**|When the section containing the Bing Maps has more than one column you can set the field to occupy up to the number of columns that the section has.|  
||**Select the number of rows the control occupies**|You can control the height of the Bing Maps by specifying a number of rows.|  
||**Automatically expand to use available space**|You can allow the Bing Maps height to expand to available space.|  
