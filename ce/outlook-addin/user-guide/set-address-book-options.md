---
title: "Set address book options in Dynamics 365 for Outlook | MicrosoftDocs"
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
ms.assetid: b35f1f81-1cf0-4768-ae66-8c61bcf9a88b
caps.latest.revision: 45
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
# Set address book options in Dynamics 365 for Outlook
With [!INCLUDE[pn_microsoft_dynamics_crm_for_outlook](../../includes/pn-microsoft-dynamics-crm-for-outlook.md)], when you compose an email message or set up a meeting, you can search for a [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] contact directly from the **To** field of the email message or appointment. By default, only the contacts that are synchronized with Dynamics 365 for Outlook and other record types that you own (such as accounts and leads) appear in the address book. Use this process if you want to synchronize all Dynamics 365 apps contacts, including contacts that you don’t own or to synchronize additional record types that you don’t own.  
  
> [!NOTE]
>  The address book synchronizes with [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] automatically when you start [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)], and then once every 24 hours.  
  
1. In [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)], choose **File**, and then choose **Dynamics 365 apps** > **Options**.  
  
2. In the **Set Personal Options** dialog box, choose the **Address Book** tab.  
  
   > [!NOTE]
   >  This tab is not available in the [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] web application.  
  
3. For **Contacts**, select one of the following:  
  
   - **Match only against contacts synchronized to [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)]**. This option is selected by default. Leave as is if you only want to be able to access the contacts that are synchronized through the online synchronization filters. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Choose the records to synchronize between Dynamics 365 apps and Outlook or Exchange](choose-records-synchronize-exchange.md)  
  
   - **Match all contacts in [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)]**. Select this option if you want all [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] contacts to be available in the address book.  
  
4. For **Other record types**, select one of the following:  
  
   - **Do not match**. Select this option if you do not want to sync other record types, such as accounts or leads.  
  
   - **Match only the items I own**.  This is the default option. Leave as is if you don’t want to sync additional record types that you don’t own.  
  
   - **Match all items in [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)]**. Select this option if you want to sync all record types, including record types you don’t own.  
  
5. If your address book is slow or if there are record types you want to exclude from your address book, under **Change the record types being synchronized to your Address Book**, choose the **Select or change the values for this field** button ![Ellipsis button](../media/ellipsis-button.gif "Ellipsis button").  
  
6. Add or remove record types, and then choose **OK**.  
  
7. To save your changes and close the dialog box, choose **OK**.  
  
### See also  
 [Choose the records to synchronize between Dynamics 365 apps and Outlook or Exchange](choose-records-synchronize-exchange.md)   
 [Track Outlook contacts in Dynamics 365 for Outlook](track-outlook-contacts.md)   
 [Frequently asked questions about synchronizing records between Microsoft Dynamics 365 apps and Microsoft Outlook](frequently-asked-questions-synchronizing-records.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]