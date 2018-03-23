---
title: "Uninstall Dynamics 365 for Marketing (Dynamics 365 for Marketing) | Microsoft Docs"
description: "How to remove Dynamics 365 for Marketing from a Dynamics 365 instance"
keywords: "uninstall;solutions;administration;instances"
ms.date: 04/01/2018
ms.service: crm-online
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 76871891-d62c-4496-81f6-60b31bf5e3e6
author: kamaybac
ms.author: kamaybac
manager: sakudes
ms.reviewer: renwe
topic-status: Drafting
---

# Uninstall [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] from a [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] instance

You can remove [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] from any [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] instance where you have installed it. After removing it, you'll end up with a free [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] entitlement (license) that you can install on another [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] instance if needed.

To uninstall [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)]:

1. [Open the Dynamics 365 admin center](dynamics-365-admin-center.md).

1. Select the **Applications** tab to see a list of applications you have installed.  
    ![Open the Applications tab](media/update-app-tab.png "Open the Applications tab")

    The list shows a row marked **Dynamics 365 Marketing Application** for each entitlement (license) you have for [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]. Free entitlements (which can't be uninstalled) show a **Status** of **Not configured**. Installed entitlements show a **Status** of **Configured** and include the name of the instance where they are installed as part of their application name.

1. Select the configured [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] entitlement that you want to uninstall and then select the **Manage** button ![The Manage button](media/update-manage-button.png "The Manage button") in the side panel. 

1. The [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] setup wizard opens.  It shows the name of the Dynamics 365 instance you are about to uninstall. Make sure you have chosen the right one.  
    ![Choose the Uninstall Marketing link](media/uninstall-wizard.png "Choose the Uninstall Marketing link")

1. Under **Other actions**, select **Uninstall Marketing from this org**.

1. Follow the instructions on your screen to confirm and complete the uninstall.

### See also

[Open the Dynamics 365 admin center](dynamics-365-admin-center.md)  
[Keep Marketing up to date](apply-updates.md)  
[Manage Marketing instances](manage-marketing-instances.md)  