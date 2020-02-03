---
title: "Re-run the setup wizard (Dynamics 365 Marketing) | Microsoft Docs  "
description: "How to run the setup wizard so you can update, uninstall, or modify an existing Dynamics 365 Marketing instance"
keywords: administration;admin center
ms.date: 06/17/2019
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
ms.assetid: 2ab8ed2d-0e3e-4b8c-9b05-8d61190206e9
author: kamaybac
ms.author: kamaybac
manager: shellyha
ms.reviewer:
topic-status: Drafting
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Re-run the Marketing setup wizard

In addition to helping you install Dynamics 365 Marketing for the first time, the setup wizard can also help you modify, maintain, or update your installation. You can do all of the following by re-running the setup wizard:

- Check for and apply [updates](apply-updates.md)
- Add or remove [portals integration](portal-optional.md)
- Configure an integrated portal
- Fix installation issues
- Connect a disconnected instance to marketing services
- Clean up after a [copy or restore operation](manage-marketing-instances.md)
- [Uninstall](uninstall-marketing.md) Marketing

To re-run the Marketing setup wizard:

1. Sign into Dynamics 365 Marketing as a user with admin privileges.

1. Go to **Settings** > **Advanced settings** > **Other settings** > **Application management**.  
    ![Open the Dynamics 365 admin center](media/settings-app-management.png "Open the Dynamics 365 admin center")

1. Select **Go to the Dynamics 365 admin center**.

1. Select the **Applications** tab to see a list of applications you have installed.  
    ![Open the Applications tab](media/update-app-tab.png "Open the Applications tab")

    The list shows a row marked **Dynamics 365 Marketing Application** for each entitlement (license) you have for Dynamics 365 Marketing. Installed entitlements show a **Status** of **Configured** and include the name of the instance where they are installed as part of their application name.

1. Select the configured entitlement that you want to manage and then select the **Manage** button ![The Manage button](media/update-manage-button.png "The Manage button") in the side panel. 

1. The Marketing setup wizard opens.  It shows the name of the Dynamics 365 Marketing instance you selected.  
    ![Setup wizard running on an existing Marketing instance](media/fre-re-run.png "Setup wizard running on an existing Marketing instance")

    If an update is available, then you'll see a notice and an **Install** button at the top of the page. More information: [Keep Marketing up to date](apply-updates.md)

    The following links can be available in the **Other actions** panel:

    - **Configure your portal**: This link is only shown if you have a Dynamics 365 Portal integrated with your selected Marketing instance. Select this link to go to the portal configuration where you can, among other things, restart the portal or remove it from your Marketing instance. More information: [Administer your portal](../portals/manage-portal.md)
    - **Take me to the app**: Brings you to Dynamics 365 Marketing.
    - **Uninstall Marketing from this org**: Removes Marketing from the selected instance. More information: [Uninstall Marketing](uninstall-marketing.md)

    If your selected Marketing instance isn't currently integrated with a Dynamics 365 Portal, then you can set this up by selecting **Use Dynamics 365 Portals** in the main area of the window. More information: [Integrate Marketing with a CMS system or Dynamics 365 Portal](portal-optional.md)
