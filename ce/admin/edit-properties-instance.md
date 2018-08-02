---
title: "Edit properties of a Dynamics 365 (online) instance | MicrosoftDocs"
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
ms.assetid: 3aa9c165-78b7-4c1b-a7c0-25cec0250ead
caps.latest.revision: 4
author: "jimholtz"
ms.author: "jimholtz"
manager: "brycho"
---
# Edit properties of an instance

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]<br/>[!INCLUDE[cc-applies-to-update-8-2-0](../includes/cc_applies_to_update_8_2_0.md)]

Administrators can edit properties of a [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] instance, such as the friendly name, URL, and the purpose. However, instances that are being provisioned cannot be edited, and disabled instances must be enabled before they can be edited.  
  
## Edit an instance  
  
1. [!INCLUDE[proc_office365_signin](../includes/proc-office365-signin.md)]  
  
2. [!INCLUDE[proc_office365_choose_admin_crm](../includes/proc-office365-choose-admin-crm.md)]  
  
3. Choose the **Instances** tab.  
  
4. Select the instance that you want, and then click **Edit**.  
  
5. Select any of the following field values that you want to change.  
  
   - **Name**. This is typically the name of your organization and is displayed in the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] application. After you save the change, it may take up to 5 minutes for the friendly name to appear in the application.  
  
   - **URL**. The URL is used to construct the URL for users to sign in to [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]. We recommend that you limit the length of the URL name to reduce the overall length of the URL.  
  
     > [!WARNING]
     >  There are important tasks that you must communicate to your [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] users immediately following a URL name change.  
     > 
     > - For users of the web application, send information that includes the new URL with instructions about how to bookmark it.  
     > - For users of [!INCLUDE[pn_crm_outlook_online](../includes/pn-crm-outlook-online.md)], the following two tasks must be completed in the order specified here:  
     > 
     >   1. **Synchronize offline data**. [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] users connected to this instance who work offline must synchronize by using the previous URL. If you run the Configuration Wizard and change the URL before completing this step, offline data may be lost.  
     >      2. **Run the Configuration Wizard**. After a URL name change is saved and any offline data is synchronized, users of [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] must run the Configuration Wizard to update the URL.  
  
        After a URL name change is saved, all users who access that instance must be notified of the change. Users will be able to access the instance for up to 24 hours by using the previous URL. After the 24-hour period has passed, the previous URL will not work.  
  
        Notice that interim URL names are discarded when there are multiple changes within 24 hours. For example, consider the following situation:  
  
     - The original URL of your instance is *fourthcoffeesales.crm.dynamics.com*.  
  
     - Using the instance picker, you change the URL name from *fourthcoffeesales.crm.dynamics.com* to *fourthcoffeemktg.crm.dynamics.com*.  
  
     - Within 24 hours of the URL name change, you change the URL name again, this time from *fourthcoffeemktg.crm.dynamics.com* to *fourthcoffeesalesandmktg.crm.dynamics.com*.  
  
       In this situation, the first URL name change to *fourthcoffeemktg.crm.dynamics.com* will be immediately removed from the system. The new URL, *fourthcoffeesalesandmktg.crm.dynamics.com*, will become active. Additionally, the original URL, *fourthcoffeesales.crm.dynamics.com*, will be active for up to 24 hours.  
  
   - **Purpose**. This value is used to associate the instance with a specific intent and is only displayed in the **Manage all Dynamics 365 (online) instances** page, which is accessed through the [!INCLUDE[pn_dyn_365_admin_center](../includes/pn-dyn-365-admin-center.md)]. For example, if this instance is for exclusive use by your sales and marketing departments, you can enter *Contoso Sales and Marketing* or, if the instance is for development and testing, enter a relevant name such as *Contoso Development*.  
  
   - **Security Group**. This value is used to determine the security group that includes the users who will have access to this instance of [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)]. Learn more: [Control user access to instances: security groups and licenses](../admin/add-instance-subscription.md#BKMK_man_sec_group)  
  
     > [!IMPORTANT]
     >  If you do not specify a security group, all users who have a [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] license will be added to this instance.  
  
6. Click **Save**.  
  
### See also  
 [Add an instance to your subscription](../admin/add-instance-subscription.md)   
 [Switch an instance](../admin/switch-instance.md)   
 [Manage Dynamics 365 (online) Sandbox instances](../admin/manage-sandbox-instances.md)   
 [Manage subscriptions, licenses, and user accounts](../admin/manage-subscriptions-licenses-user-accounts.md)   
 [Manage storage for Microsoft Dynamics 365 (online)](../admin/manage-storage.md)
 [User session and access management](user-session-management.md)
