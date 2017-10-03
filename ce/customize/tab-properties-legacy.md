---
title: "Tab properties (Dynamics 365 Customer Engagement) | MicrosoftDocs"
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
ms.assetid: e0790865-c5a4-4e86-bce2-584af2b8ed93
caps.latest.revision: 63
ms.author: "rdubois"
manager: "brycho"
---
# Tab properties 

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

 In the body of a Dynamics 365 Customer Engagement form, tabs provide horizontal separation. Tabs have a label that can be displayed. If the label is displayed tabs can be expanded or collapsed to show or hide their content by choosing the label.  
  
 Tabs contain up to three columns and the width of each column can be set to a percentage of the total with. When you create a new tab, each column is pre-populated with a section.  
  
 The following table shows properties that may be set for tabs in the form.  
  
|Tab|Property|Description|  
|---------|--------------|-----------------|  
|**Display**|**Name**|**Required**: The unique name for the tab that is used when referencing it in scripts. The name can contain only alphanumeric characters and underscores.|  
||**Label**|**Required**: The localizable label for the tab visible to users.|  
||**Show the label of this tab on the Form**|When the label is displayed people can click it to toggle whether the tab is expanded or collapsed. Choose whether you want to show the label.|  
||**Expand this tab by default**|The tab state can toggle between expanded or collapsed using form scripts or by people clicking the label. Choose the default state for the tab.|  
||**Visible by default**|Showing the tab is optional and can be controlled using scripts. Choose whether to make the tab visible. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Visibility options](../customize/visibility-options-legacy.md)|  
||**Lock the tab on the form**|This will prevent the tab from accidentally being removed and prevents people from modifying the contents.<br /><br /> Removing a tab will not only remove the tab, but also any script event handlers defined for the tab or fields within the tab. Recreating all this work could be a substantial effort.<br /><br /> Someone wanting to remove this tab would need to change this setting before removing it.|  
|**Formatting**|**Layout**|Tabs may have up to three columns. Use these options to set the number of tabs and what percentage of the total width they should fill.|  
|**Events**|**Form Libraries**|Specify any [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] web resources that will be used in the tab `TabStateChange` event handler.<br /><br />|  
||**Event Handers**|Configure the functions from the libraries that should be called for the tab `TabStateChange` event. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Configure Event Handlers](../customize/configure-event-handlers-legacy.md)|  
  
