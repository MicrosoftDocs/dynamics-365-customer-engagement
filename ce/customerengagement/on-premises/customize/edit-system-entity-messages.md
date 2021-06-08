---
title: "Edit system entity messages with Dynamics 365 Customer Engagement (on-premises) | MicrosoftDocs"
description: "Learn how to edit system entity messages"
ms.custom: 
ms.date: 11/03/2018
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - powerapps
author: Mattp123
ms.assetid: 3ccbd8de-8d6f-4058-87f7-15463667cfc6
caps.latest.revision: 41
ms.author: matp
manager: kvivek
search.audienceType: 
  - customizer

---
# Edit system entity messages

[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Edit system entity messages in Power Apps](/powerapps/maker/common-data-service/edit-system-entity-messages)

<a name="BKMK_EditSystemEntityMessages"></a>   

 The default display name of some system entities is used in user interface text and error messages. If you change the display name, you should also update any messages that use the default display name. For example, if you change the display name from “Account” to “Company,” you could still see an error message using the old name.  
  
 In the solution explorer, below the entity, if you see a **Messages** node you can edit certain text that includes references to the original entity display name. Editing this text is straightforward. Open the message to see a form with three fields:  
  
|Field|Description|  
|-----------|-----------------|  
|**Default Display String**|Shows the original text.|  
|**Custom Display String**|Edit this text to change the display string.|  
|**Comment**|Optional. Include a comment about what you changed and why.|  
  
 Some of the message text may have placeholders in them. These placeholders are numbers with brackets on either side. For example: {0}. These placeholders allow for text to be inserted  in the message. If you edit messages, make sure that you keep these placeholders. 
 
### See also
[Create or edit an entity](create-edit-entities.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]