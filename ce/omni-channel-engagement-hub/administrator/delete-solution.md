---
title: "Delete Omni-channel solutions | MicrosoftDocs"
description: "Learn how to delete a Omni-channel solution from the Microsoft Dynamics 365 for Customer Engagement organization."
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 05/08/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 9DD734AE-8137-427C-A4BE-F4B2A0E58C00
ms.custom: 
---

# Delete Omni-channel solutions

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

When you upgrade Omni-channel Engagement Hub to the latest release, certain managed solutions appear in the **Solutions** page of your Customer Engagement organization. After the upgrade is complete, you must delete the solution from the previous release if the upgrade does not delete.

This topic describes how to delete the solution from the previous releases from your Customer Engagement organization.

## Delete OmnichannelCustomerServiceHub solution

1. Sign in to [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] organization as system administrator.

    > [!Note]
    > When you sign in to a different app in the Customer Engagement organization, then select the default Customer Engagement app and perform the steps 2 and 3.

2. On the nav bar select the down arrow button, and choose **Settings** > **Solutions**.

3. On the **Solutions** page, select the **OmnichannelCustomerServiceHub** solution and then choose **Delete**. 

4. A confirmation message appears prompting you to uninstall the managed solution. Choose **OK**. 

    > [!div class=mx-imgBorder]
    > ![Delete Omni-channel Solution](../media/oceh-admin-delete-solution.png "Delete Omni-channel Solution")  

You have deleted the **OmnichannelCustomerServiceHub** solution from your Customer Engagement organization.

## See also

- [Upgrade Omni-channel Engagement Hub](upgrade-omni-channel.md)
- [Omni-channel Engagement Hub on Unified Service Desk](omni-channel-engagement-hub-unified-service-desk.md)
- [Deploy Unified Service Desk - Omni-channel Engagement Hub package](omni-channel-engagement-hub-package.md)
