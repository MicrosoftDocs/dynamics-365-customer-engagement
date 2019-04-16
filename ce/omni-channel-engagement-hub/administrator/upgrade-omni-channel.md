---
title: Upgrade Omni-channel Engagement Hub | MicrosoftDocs
description: Understand how you can upgrade Omni-channel Engagement Hub
keywords: Omni-channel Engagement Hub; Upgrade Omni-channel Engagement Hub
author: anjgupta
ms.author: anjgup
manager: shujoshi
applies_to: 
ms.date: 2/8/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 75ee8553-b3bb-4780-a03e-45b2b09c12c2
ms.custom: 
---

# Upgrade Omni-channel Engagement Hub

Upgrade to the latest version of Omni-channel Engagement Hub to unlock the benefits of new features. You can now upgrade to the latest release of Omni-channel Engagement Hub from the application management page in **Dynamics 365 Admin Center**.

See [What's new in Omni-channel Engagement Hub](https://go.microsoft.com/fwlink/?linkid=2083527) to know about the new features in the latest release.

Follow these steps to upgrade Omni-channel app.

1. Log in to [Dynamics 365 Admin Center](https://admin.microsoft.com/adminportal/home#/homepage).

2. Select **Manage Instances** and navigate to your org in the **Manage Omni-channel Instances** page. 
3. Check for upgrade in your org. 

    > [!div class=mx-imgBorder] 
    > ![Omni-channel users](../media/upgrade-oc.png)

    The system looks for an upgrade and displays the message **Upgrade is available** when either one or both the solutions have an upgrade pending.

    > [!NOTE]
    > This option doesn't appear if there is no upgrade available for the org. 

      - When an upgrade is available </br>
        Select the **Upgrade** button to upgrade your org to the latest version.

        > [!div class=mx-imgBorder] 
        > ![Omni-channel users](../media/upgrade-available.png)

        The system begins the upgrade and the message **Upgrade in progress** is displayed.
         
        > [!div class=mx-imgBorder] 
        > ![Omni-channel users](../media/upgrade-progress.png)

      - When the upgrade is completed successfully </br>
        Your org is upgraded to the latest version and the message **Upgrade is successful** is displayed.

        > [!div class=mx-imgBorder] 
        > ![Omni-channel users](../media/upgrade-complete.png)

        > [!NOTE]
        > If the upgrade fails for one or more solutions, the system displays the message **Upgrade error**. Open the instance and select **Upgrade** to retry.


### See also

[Manage updates in Dynamics 365](../../admin/manage-updates.md)

[Pre-requisites and system requirements of Omni-channel Engagement Hub - Preview](../system-requirements-omni-channel-engagement-hub.md)

[Provision Omni-channel Engagement Hub](omni-channel-provision-license.md)
