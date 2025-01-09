---
title: "Control field synchronization in Dynamics 365 Customer Engagement (on-premises)"
description: "With field synchronization, admins can set the sync direction between Outlook and Customer Engagement (on-premises)."
ms.custom: 
ms.reviewer: 

ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
ms.assetid: d570e1f0-d319-46c6-a247-00c32c78df3b
caps.latest.revision: 15
author: Mattp123
ms.author: matp
search.audienceType: 
  - admin
---
# Set synchronization direction in Dynamics 365 Customer Engagement (on-premises)

::: moniker range="op-9-1"
[!INCLUDE [cc-use-advanced-settings](../includes/cc-use-advanced-settings.md)]
::: moniker-end

With field synchronization, admins can set the sync direction between Dynamics 365 Customer Engagement (on-premises) and [!INCLUDE[pn_microsoft_dynamics_crm_for_outlook](../includes/pn-microsoft-dynamics-crm-for-outlook.md)] fields. You can control synchronization when using either [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)] synchronization or server-side synchronization ([!INCLUDE[pn_Exchange](../includes/pn-exchange.md)]).  
  
 For example, a salesperson may want to take personal notes about a contact and not want the notes to synchronize with Customer Engagement (on-premises) data available to all users. An admin can set the Personal Notes field for contacts in Outlook to not [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] with Customer Engagement (on-premises) so the salesperson’s notes will remain private.  
  
> [!TIP]
> ![Video symbol](../admin/media/video-thumbnail-4.png "Video symbol") Check out the following video: [Configurability in Synchronizing Data with Outlook or Exchange in Microsoft Dynamics CRM 2015](https://youtu.be/BMZsVUuaklo?list=PLC3591A8FE4ADBE07)  
  
## Set field synchronization between Customer Engagement (on-premises) and Outlook  
  
1. Sign in as a Customer Engagement admin. 

2. In the web app, select **Settings** > **Administration** > **System Settings** > **Synchronization** tab.
  
   For [Unified Interface](about-unified-interface.md), select Settings (![Selection rule gear button.](../admin/media/selection-rule-gear.gif "Gear button")) in the upper-right corner > **Advanced Settings** > **Settings** > **Administration** > **System Settings** > **Synchronization** tab.
  
3. Under **Synchronize Microsoft Dynamics 365 items with Outlook or Exchange**, select **synchronized fields**.  
  
4. For the fields you want to change synchronization, choose the arrows in the Sync Direction column. Each choice will change the direction.  
  
   ![Appointment fields for synchronization.](../admin/media/appointment-field-sync.png "Appointment fields for synchronization")  
  
   > [!TIP]
   >  Hover over a field name to see the fields mapped to it.  
  
5. Select **OK** > **OK** to close the open dialog boxes.  
  
   Let your users know they can view (not change) the synchronization settings. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [What fields can be synchronized between Customer Engagement (on-premises) and Outlook?](what-fields-synchronized-outlook.md)  
  
## Performance and synchronization  
 Configuring synchronization might have an impact on the time it takes to sync between [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] and Customer Engagement (on-premises). You should test your configuration before deploying to ensure satisfactory sync times.  
  
## Permissions and synchronization  
 Role-based security controls access to a specific entity type, record-based security controls access to individual records, and field-level security controls access to specific fields. All these can impact what is synchronized between Customer Engagement (on-premises) and [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] or [!INCLUDE[pn_Exchange](../includes/pn-exchange.md)].  
  
 Best practice is to review the security settings for these security methods to ensure field synchronization is processes as desired. For more information see:  
  
-   Securing roles: [Create or edit a security role](../admin/create-edit-security-role.md)  
  
-   Securing fields: [Add or remove security from a field](enable-disable-security-field.md)  
  
[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [How field security affects synchronization between Customer Engagement (on-premises) and Outlook](../admin/how-field-security-affects-synchronization-between-outlook.md) and [Security concepts](../admin/security-concepts.md)  
  
### See also  


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
