---
title: "Change auto-numbering prefixes  | MicrosoftDocs"
ms.custom: 
ms.date: 10/01/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
ms.assetid: 13aa0eb0-537f-432e-ac26-706ebd511dbd
caps.latest.revision: 39
author: jimholtz
ms.author: jimholtz
search.audienceType: 
  - admin
---
# Change auto-numbering prefixes for contracts, cases, articles, quotes, orders, invoices, campaigns, categories, and knowledge articles

::: moniker range="op-9-1"
[!INCLUDE [cc-use-advanced-settings](../includes/cc-use-advanced-settings.md)]
::: moniker-end

Contracts, cases, articles, quotes, orders, invoices, marketing campaigns, categories, and knowledge articles are automatically numbered by Dynamics 365 Customer Engagement (on-premises). If your organization has standard numbering formats, you can change the default three-character prefixes and number format to match your organization.  
  
1.  Go to **Settings** > **Administration** > **Auto-Numbering**.  
  
2.  In the **Set Auto-Numbering** dialog box, select the record type that you want to change.  
  
3.  In the **Prefix** box, enter up to three characters, symbols, or numbers.  
  
     Prefixes are system-wide and are used for all system-generated numbers for the selected record type. If you change the prefix for a record type, it won’t change the prefix of numbers that are already assigned.  
  
     The prefix of the tracking token for email messages is set in the System Settings area. More information: [System Settings dialog box - Email tab](../admin/system-settings-dialog-box-email-tab.md)  
  
4.  In the **Number** box, enter the starting number.  
  
     If you haven’t set a numbering format before, the **Number** box displays 1000. After you set the numbering format and save your settings, this field is set to read-only and you can’t modify it. If a custom auto-numbering solution was used, you won’t be able to change the number.  
  
5.  Select a suffix length.  
  
     Articles and knowledge articles don’t have suffixes. The suffix is used for records that were created while you were offline and for which the number can’t be guaranteed to be unique.  
  
6.  Click **OK** to save your settings.  
  
### See also  
 [Use solutions for your customizations](../customize/use-solutions-for-your-customizations.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]