---
title: "Control social data for Dynamics 365 Customer Engagement | MicrosoftDocs"
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
author: "rdubois-msft"
ms.assetid: 2746eafb-b5a1-4e20-96cc-9e17c7f49f77
caps.latest.revision: 38
ms.author: "rdubois"
manager: "brycho"
---
# Control receiving social data

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]<br/>[!INCLUDE[cc-applies-to-update-8-2-0](../includes/cc_applies_to_update_8_2_0.md)]

You can enable or disable your ability to receive social data in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)].  
  
## Enable or disable social engagement  
 By default, social engagement is enabled and social data is received.  
  
> [!NOTE]
>  If you disable social engagement, you can no longer create or update social data in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]. If you try to convert a social activity to a case while social engagement is disabled, you’ll get an error message. The error occurs because the **Convert To Case** action tries to update the social activity **Regarding** field. The same error occurs if you try to assign a social activity record or a social profile record to another user.  
  
1. [!INCLUDE[proc_settings_administration](../includes/proc-settings-administration.md)]  
  
2.  Choose **System Settings**.  
  
3.  Under **Disable Social Engagement**, select **Yes** to stop receiving social data in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]. To receive data, select **No**.  
  
4.  Choose **OK**.  
  
### See also  
 [Connect to Microsoft Social Engagement](../admin/connect-microsoft-social-engagement.md)   
 [Receive social data in Microsoft Dynamics CRM](http://go.microsoft.com/fwlink/p/?LinkID=392629)
