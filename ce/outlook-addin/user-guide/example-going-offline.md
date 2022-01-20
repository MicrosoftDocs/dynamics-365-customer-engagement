---
title: "Example of going offline with Dynamics 365 for Outlook | MicrosoftDocs"
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
ms.assetid: f622fe69-14b3-44e0-a4eb-093959910c70
caps.latest.revision: 35
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
# Example of going offline with Dynamics 365 for Outlook
Salespeople can make critical customer information available and up-to-date on business trips with filters. By specifying only the data you need to synchronize with your laptop, you can avoid wasting valuable laptop memory, stay current with the head office, and keep information on your laptop fresh. Meanwhile, managers and co-workers are up-to-date.  
  
 Using [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)], you can set up and activate filters with criteria similar to Advanced Find by specifying the criteria for the [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] records that you want to be available when you go offline. In addition, you can change what data will be available when you synchronize by activating and deactivating the filters.  
  
 To see what data filters are being applied to your offline synchronization, in [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)], on the **File** menu, click or tap **Dynamics 365 apps** > **Go Offline** > **Manage Offline Filters**.  
  
> [!NOTE]
>  You can have more than one active filter so you can take larger, combined sets of data offline.  
  
## Select the data you need with filters  
 To leverage local data, consider a trip to regional offices in the USA in Washington and Oregon. You would want to define needed information in the [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] database that applies to customers in these states.  
  
 First, create a filter of the data for a record type. Save this filter as your “master,” and call it “My Active Accounts”, for example. Second, modify this filter to create different versions for your business needs.  
  
-   To edit an existing filter, on either tab, double-click or tap the item in the list. To keep the original data group, make a copy using **Save As**, and add additional criteria, such as “Address 1: State/Province equals WA”. Save it with a new name such as “My Accounts in Washington.”  
  
-   Using **Save As** again, change the criteria to “Address 1: State/Province equals OR”, and name your new data group “My Accounts in Oregon.”  
  
> [!IMPORTANT]
>  Before your trip, deactivate all filters, except those that apply to the customers in the first area you are visiting.  
  
## Deactivate or activate filters  
  
-   To deactivate a filter, on the **User Filters** tab, select one or more filters. On the tool bar, click or tap the **Deactivate** button (a red circle with a red square).  
  
-   To activate a filter, on the **User Filters** tab, select one or more filters and then click or tap the **Activate** button (a green circle with a green triangle).  
  
## Take your data offline and synchronize your data  
  
- In [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)], on the **Dynamics 365 apps** menu, click or tap **Go Offline**.  
  
  While you are offline, you can add new contacts and accounts or update the accounts and contacts on your laptop. When connecting to your company's network again, you can synchronize your data.  
  
> [!IMPORTANT]
>  [!INCLUDE[cc_Outlook_Offline_LocalAccess](../../includes/cc-outlook-offline-localaccess.md)]  
  
## Go back online and synchronize your data  
  
- In [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)], on the **Dynamics 365 apps** menu, click or tap **Go Online**.  
  
  Any updated data from your laptop will be synchronized with your company's [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] database. You can now deactivate and activate a new set of filters for your next visits, using the procedures explained earlier in this article.  
  
## Combine data filters to take more information with you  
 Because filters are additive, you can have more than one active filter. For example, if you are going to the Northwest United States, you can activate the Washington and Oregon data filters you created and take both sets of data with you.  
  
<a name="BMKM_MUprivacy"></a>   
## Privacy notices  
 [!INCLUDE[cc_privacy_crm_outlook1](../../includes/cc-privacy-crm-outlook1.md)]  
  
 [!INCLUDE[cc_privacy_crm_sync_to_outlook](../../includes/cc-privacy-crm-sync-to-outlook.md)]  
  
### See also  
 [Work offline with Dynamics 365 for Outlook](work-offline-dynamics-365-outlook.md)   
 [Choose records to work with offline in Dynamics 365 for Outlook](choose-records-work-offline.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]