---
title: "The Outlook email address should be the same as the Dynamics 365 apps email address | MicrosoftDocs"
ms.custom: 
ms.date: 01/11/2016
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 apps 
  - Dynamics 365 apps (on-premises)
  - Dynamics CRM 2013
  - Dynamics CRM 2015
  - Dynamics CRM 2016
  - Dynamics CRM Online
ms.assetid: 9f79a729-3141-47bc-a238-ea7abfc4ff7c
caps.latest.revision: 19
author: mduelae
ms.author: mkaur
manager: kvivek
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Outlook
---
# The Outlook email address should be the same as the Dynamics 365 apps email address
You’re seeing the following error message:  
  
 **“To track emails and perform synchronization, your Outlook email address should be the same as your email address in Microsoft Dynamics 365 apps.”**  
  
 This message is common when you have multiple [!INCLUDE[pn_MS_Outlook_Full](../../includes/pn-ms-outlook-full.md)] email addresses or have access to more than one [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] organization. For example, your company may use multiple [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] organizations for testing or upgrade purposes.  
  
 You may also see this error message if you are configuring [!INCLUDE[pn_microsoft_dynamics_crm_for_outlook](../../includes/pn-microsoft-dynamics-crm-for-outlook.md)], but you don’t have an [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] email address, or you haven’t set the primary email address field in [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)].  
  
 To fix this, start by finding the primary Outlook email address:  
  
## Find the primary Outlook email address  
  
1. In [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)], choose **File**.  
  
2. Under **Account Information**, choose **Account Settings**, and then select **Account Settings** from the list.  
  
    In the **Account Settings** dialog box, you’ll see a check mark next to the primary email address. Make a note of the exact address.  
  
   > [!IMPORTANT]
   >  You must use the exact email address that you see in the **Account Settings** dialog box. For example, the following email addresses are not equivalent:  
   > 
   >  nanderson@contoso.com  
   > 
   >  nancy.anderson@contoso.com  
  
   Then, pick **one** of the following methods.  
  
## Change the email address in Dynamics 365 apps to match the Outlook address  
  
1. [!INCLUDE[proc_permissions_system_admin_and_customizer](../../includes/proc-permissions-system-admin-and-customizer.md)]  
  
   #### Check your security role  
  
   1. [!INCLUDE[proc_follow_steps_in_link](../../includes/proc-follow-steps-in-link.md)]  
  
   2. [!INCLUDE[proc_dont_have_correct_permissions](../../includes/proc-dont-have-correct-permissions.md)]  
  
2. [!INCLUDE[proc_settings_security](../../includes/proc-settings-security.md)]  
  
3. Choose **Users**.  
  
4. Under **Enabled Users**, choose a user.  
  
5. In the **Primary Email** field, enter the [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] email address. Make sure you use the primary [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] email address. Most people have just one [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] email address. This should probably be a company email address and not a personal email address.  
  
6. Save the changes.  
  
## Change the email address in Outlook to match the address in Dynamics 365 apps  
  
1. In [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)], choose the **File** menu.  
  
2. Under **Account Information**, choose **Add Account**, and then enter the account information.  
  
3. Restart [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)].  
  
   You’ll need to set the new email account to be the default account.  
  
4. In [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)], choose the **File** menu.  
  
5. Under **Account Information**, choose **Account Settings > Account Settings…**  
  
6. Select the new account, and then choose **Set as Default**.  
  
7. Choose **Close**.


[!INCLUDE[footer-include](../../includes/footer-banner.md)]