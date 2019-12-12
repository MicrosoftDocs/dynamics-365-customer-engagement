---
title: "Control social data for Dynamics 365 for Customer Engagement apps | MicrosoftDocs"
ms.custom: 
ms.date: 09/30/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
author: jimholtz
ms.assetid: 2746eafb-b5a1-4e20-96cc-9e17c7f49f77
caps.latest.revision: 38
ms.author: jimholtz
manager: kvivek
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - Powerplatform
---
# Control receiving social data

*This content also applies to the on-premises version.*

You can enable or disable your ability to receive social data in [!INCLUDE[pn_microsoftcrm](../includes/pn-dynamics-crm.md)] apps.  
  
## Enable or disable social engagement  
 By default, social engagement is enabled and social data is received.  
  
> [!NOTE]
>  If you disable social engagement, you can no longer create or update social data in [!INCLUDE [pn-crm-shortest](../includes/pn-crm-shortest.md)] apps. If you try to convert a social activity to a case while social engagement is disabled, you’ll get an error message. The error occurs because the **Convert To Case** action tries to update the social activity **Regarding** field. The same error occurs if you try to assign a social activity record or a social profile record to another user.  
  
1. [!INCLUDE[proc_settings_administration](../includes/proc-settings-administration.md)]  
  
2. Choose **System Settings**.  
  
3. Under **Disable Social Engagement**, select **Yes** to stop receiving social data in [!INCLUDE [pn-crm-shortest](../includes/pn-crm-shortest.md)] apps. To receive data, select **No**.  
  
4. Choose **OK**.  
  
### See also  
 [Connect to Microsoft Social Engagement](../admin/connect-microsoft-social-engagement.md)   
 [Receive social data in Microsoft Dynamics CRM](https://go.microsoft.com/fwlink/p/?LinkID=392629)
