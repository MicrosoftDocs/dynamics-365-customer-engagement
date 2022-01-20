---
title: "Use a wizard to add and track multiple Outlook contacts in Dynamics 365 for Outlook | MicrosoftDocs"
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
ms.assetid: dda44f4b-fe64-4514-bcc1-e02d9a642bd4
caps.latest.revision: 48
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
# Use a wizard to add and track multiple Outlook contacts in Dynamics 365 for Outlook
You can track your [!INCLUDE[pn_MS_Outlook_Full](../../includes/pn-ms-outlook-full.md)] contacts in [!INCLUDE[pn_microsoft_dynamics_crm_for_outlook](../../includes/pn-microsoft-dynamics-crm-for-outlook.md)]. When you track a contact, a copy of that contact’s record is saved in [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] and synchronized with the [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] record. After your contacts are tracked, you’ll see any [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] email, task, or appointment activities associated with those contacts. If you sync [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] on your mobile device, you can also access your contact records on that device.  
  
 Tracking contacts in [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] is a manual process. You can track up to 20 contacts at one time by choosing the **Track** button or the **Set Parent** button in [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)]. If you want to add more than 20 contacts at one time, or if you want to add all your [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] contacts to [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)], you can use the **Add Contacts** wizard. The wizard can also help you set a number of options. For example, you can specify if future communications with the tracked contacts should be synchronized with [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)].  
  
> [!IMPORTANT]
>  To track contacts in [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)], your [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] email address must match your [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] email address. You can’t synchronize to or from multiple email addresses.  
  
## Step 1: Get ready  
 Before you add your [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] contacts:  
  
- For best results, make sure your [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] contact data is as complete and accurate as possible. Fill in any missing info and verify that people’s names are spelled correctly.  
  
- Because you will have the opportunity to “map” the company names in your [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] contact list to an account name in [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)], make sure the accounts have the same spelling in both applications.  
  
## Step 2: Run the wizard  
  
1. Choose **File** > **Dynamics 365 apps** > **Import Contacts** > **Add Contacts**.  
  
2. Choose **Next**.  
  
3. Confirm the folder where your [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] contacts are stored, and then choose **Next**.  
  
   > [!NOTE]
   > - The wizard determines the folder, usually called **Contacts**. You can select or clear subfolders in the **Contacts** folder.  
   >   -   If you allow someone else to manage your email (called a “delegate”), you can’t add contacts from that person’s contacts folder.  
  
4. Select how to group your contacts. The groups are:  
  
   - **Company Name**. Group the contacts by the matching account name in [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)]. The wizard lists the number of contacts associated with each account. Choose the link to verify the list of names for each account.  
  
   - **Email Domain**. Group the contacts by email domain. The email domain is the part of the address after the @ symbol. For example, in the email address someone@contoso.com, "contoso.com" is the domain. Choose the link to verify the list of names in each domain.  
  
   - **Categories**. Group the contacts by the category you use to organize contacts in [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)], if applicable. Choose the link to verify the list of names for each category.  
  
     If you don’t want to add all the groups, clear the check boxes to the left of any groups you don’t want.  
  
   > [!NOTE]
   >  The **Number of Contacts** column displays a color to indicate how many of the contacts are already linked to [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)]:  
   > 
   > - **Green**. All of the contacts are already in [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)].  
   >   - **Yellow**. More than 50% of the contacts are already in [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)].  
   >   - **Red**. At least one contact is already in [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)].  
   > 
   > [!TIP]
   >  You may find that the groupings have many variations if the company names don’t match exactly. If so, it may be best to cancel the wizard, correct the company names in [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)], and then run the wizard again.  
  
5. Verify that **Use Company Name to be the Account** is selected (recommended). Otherwise, if you want to associate an account name with each contact later in [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)], clear this check box.  
  
6. Select **Track all communications for added contacts** to track the messages, appointments, and tasks associated with these [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] contacts in [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)].  
  
7. To manually select the accounts to associate the contacts with, choose **Advanced**. In the **Set Account** column, choose the row for the contact. From the drop-down list, select one of the following:  
  
   - Leave the field blank (**Not Set**) to associate the contacts with an account later in [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)].  
  
   - Select **Use Company Name** to associate the contacts with a [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] account using the company name.  
  
   - Select **Pick Existing Account**, select an account or contact, and then choose **OK**.  
  
8. In the **Include Communication** column, clear the check box for any grouping for which you don’t want to track email messages, appointments, or tasks in [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)].  
  
9. Choose **Add Contacts**.  
  
10. Review the Summary page and view any errors, if applicable. Then choose **Close**.  
  
### See also  
 [Overview of tracking records in Dynamics 365 for Outlook](overview-tracking-records.md)   
 [Frequently asked questions about synchronizing records between Microsoft Dynamics 365 apps and Microsoft Outlook](frequently-asked-questions-synchronizing-records.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]