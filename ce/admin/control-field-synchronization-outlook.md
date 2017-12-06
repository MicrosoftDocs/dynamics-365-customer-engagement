---
title: "Control field synchronization between Dynamics 365 Customer Engagement and Outlook | MicrosoftDocs"
ms.custom: ""
ms.date: 08/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: d570e1f0-d319-46c6-a247-00c32c78df3b
caps.latest.revision: 15
author: "jimholtz"
ms.author: "jimholtz"
manager: "brycho"
---
# Control field synchronization with Outlook

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]<br/>[!INCLUDE[cc-applies-to-update-8-2-0](../includes/cc_applies_to_update_8_2_0.md)]

With field synchronization, admins can set the sync direction between [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] and [!INCLUDE[pn_microsoft_dynamics_crm_for_outlook](../includes/pn-microsoft-dynamics-crm-for-outlook.md)] fields. You can control synchronization when using either [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)] synchronization or server-side synchronization ([!INCLUDE[pn_Exchange](../includes/pn-exchange.md)]).  
  
 For example, a salesperson may want to take personal notes about a contact and not want the notes to synchronize with [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] data available to all users. You can set the Personal Notes field for contacts in Outlook to not [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] with [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] so the salesperson’s notes will remain private.  
  
> [!TIP]
> ![Video symbol](../admin/media/video-thumbnail-4.png "Video symbol") Check out the following video: [Configurability in Synchronizing Data with Outlook or Exchange in Microsoft Dynamics CRM 2015](http://youtu.be/BMZsVUuaklo?list=PLC3591A8FE4ADBE07)  
  
## Set field synchronization between Dynamics 365 and Outlook  
  
1.  In the web app, in the upper-right corner of the screen, click the **Settings** button ![User profile Settings button](../outlook-app/media/priv-user.gif "User profile Settings button") > **Options**.  
  
2.  In the **Set Personal Options** dialog box, choose the **Synchronization** tab.    
  
3.  Choose **synchronized fields**.  
  
4.  For the fields you want to change synchronization, choose the arrows in the Sync Direction column. Each choice will change the direction.  
  
 ![Appointment fields for synchronization](../admin/media/appointment-field-sync.png "Appointment fields for synchronization")  
  
    > [!TIP]
    >  Hover over a field name to see the fields mapped to it.  
  
5.  Choose **OK** > **OK** to close the open dialog boxes.  
  
 Let your users know they can view (not change) the synchronization settings. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [What fields can be synchronized between Dynamics 365 and Outlook?](what-fields-synchronized-outlook.md)  
  
## Performance and synchronization  
 Configuring synchronization might have an impact on the time it takes to sync between [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] and [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]. You should test your configuration before deploying to ensure satisfactory sync times.  
  
## Permissions and synchronization  
 Role-based security controls access to a specific entity type, record-based security controls access to individual records, and field-level security controls access to specific fields. All these can impact what is synchronized between [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] and [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] or [!INCLUDE[pn_Exchange](../includes/pn-exchange.md)].  
  
 Best practice is to review the security settings for these security methods to ensure field synchronization is processes as desired. For more information see:  
  
-   Securing roles: [Create or edit a security role](../admin/create-edit-security-role.md)  
  
-   Securing fields: [Add or remove security from a field](enable-disable-security-field.md)  
  
[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [How field security affects synchronization between Dynamics 365 and Outlook](../admin/how-field-security-affects-synchronization-between-outlook.md) and [Security concepts for Microsoft Dynamics 365](../admin/security-concepts.md)  
  
### See also  
