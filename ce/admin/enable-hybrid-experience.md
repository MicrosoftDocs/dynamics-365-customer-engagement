---
title: "Enable the hybrid experience | MicrosoftDocs"
ms.custom: ""
ms.date: 08/22/2018
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 17408cd1-e85e-4a96-b975-0c032d036467
caps.latest.revision: 4
author: "jimholtz"
ms.author: "jimholtz"
manager: "kvivek"
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - Powerplatform
---
# Enable the hybrid experience

Most of the core functionalities of sales and customer service have moved to the [Unified Interface](about-unified-interface.md) experience. Some of the features that are not yet on Unified Interface can now be accessed in the Unified Interface client. 

The following features are not yet present in the Unified Interface but can be enabled for display as legacy dialogs in the Unified Interface through the hybrid experience.

- [Advanced Find](../basics/save-advanced-find-search.md) 
- [Bulk edit](manage-your-data.md)
- [Merge records](../basics/merge-duplicate-records-accounts-contacts-leads.md)
- [Record sharing](../basics/assign-record-user-team.md)
- All options under **Set Personal Options** (![Settings gear](media/settings-gear-icon.png "Settings gear"))

These features are enabled through a setting in System Settings.

1. Go to **Settings** > **Administration** > **System Settings**.  
2. Select the **General** tab.  
3. Set **Enable embedding of certain legacy dialogs in Unified Interface browser client** to **Yes**.

![Enable hybrid experience](media/hybrid-system-settings.png "Enable hybrid experience")

When you enable the hybrid experience, commands appear on the command bar. For example, when you select an account, **Edit**, **Merge**, and **Share** commands are available.

![Commands on command bar](media/hybrid-edit-merge-share.png "Commands on command bar")

You can select **Share** to share this account with another user or team.

![Share account](media/hybrid-share-account.png "Share account")

If you disable the hybrid experience, these commands are not available in the command bar.

![Commands not on command bar](media/hybrid-no-edit-merge-share.png "Commands not on command bar")

### See also  
 [Unified Interface](about-unified-interface.md)