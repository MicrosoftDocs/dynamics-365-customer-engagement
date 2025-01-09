---
title: "Show or hide form elements in Dynamics 365 Customer Engagement (on-premises)"
description: "Form elements such as tabs, sections, fields, iFrames, and web resources have the option to be shown or hidden. Control this using scripts or business rules."
ms.custom: 
ms.reviewer: 

ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - powerapps
author: Mattp123
ms.assetid: 7b9e8dc2-229c-455f-ae18-49e8d879ff71
caps.latest.revision: 63
ms.author: matp
search.audienceType: 
  - customizer
---
# Show or hide form elements

[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Show or hide model-driven app form elements](/powerapps/maker/model-driven-apps/visibility-options-legacy)

 Several types of form elements have the option to be shown or hidden by default. Tabs, sections, fields, iFrames, and web resources all provide this option. Using form scripts or business rules the visibility of these elements can be controlled to create a dynamic form to provide a user interface that adapts to conditions in the form.  
  
> [!NOTE]
>  Hiding form elements is not a recommended way to enforce security. There are several ways people can view all the elements and data in the form when elements are hidden. 
  
 Rather than designing forms that depend on scripts to control visibility of options, consider whether a business process flow, a dialog, or switching to a different form may be better suited to meet your requirements. If you do use scripts, make sure that any element that might be hidden is hidden by default. Only show it with scripts when your logic calls for it. This way it will not be displayed in presentations that do not support scripts.  

### See also

[Create business rules and recommendations to apply logic in a form](create-business-rules-recommendations-apply-logic-form.md) <br />
[formContext.ui.tabs (Client API reference)](/powerapps/developer/model-driven-apps/clientapi/reference/formContext-ui-tabs) <br />
[formContext.ui.sections (Client API reference)](/powerapps/developer/model-driven-apps/clientapi/reference/formContext-ui-sections) <br />
[setVisible (Client API reference)](/powerapps/developer/model-driven-apps/clientapi/reference/controls/setVisible)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
