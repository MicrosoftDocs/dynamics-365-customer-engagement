---
title: "Grant or restrict access to deal manager - Sales Enterprise | MicrosoftDocs"
description: "As an administrator, you can grant access to the deal manager to specific security roles or to all security roles."
ms.date: 06/30/2021
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
searchScope: 
  - D365-App-msdynce_saleshub
  - D365-Entity-quote
  - D365-Entity-salesorder
  - D365-Entity-invoice
  - D365-Entity-quotedetail
  - D365-Entity-salesorderdetail
  - D365-Entity-invoicedetail
  - D365-UI-*
  - Customer Engagement
  - Dynamics 365
  - Sales
---

# Grant access to deal manager

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

By default, deal manager is enabled only for the administrators. As an administrator, you can grant access to specific security roles or to all security roles in your organization. <!--why should it be restricted? are there performance reasons? Do we have any recommendations on which roles must have access?-->

**To grant access:**

1. In the Sales Hub app, select the **Change area** icon
    ![Icon to change the work area](media/change-area-icon.png "Icon to change the work area")
    in the lower-left corner and then select **App Settings**. 
1. Under **General Settings**, select **Deal manager (preview)**.
1. Select the level of access you want to grant under **Define team access**.
    - Select **All security roles** to grant access to all users.
    - Select **Specific security roles** and add the security roles that you want to grant access to.
1. Select **Publish**.
   The deal manager workspace is now available to the selected roles. See how to [access deal manager workspace](deal-manager-overview.md#access-deal-manager-workspace).





