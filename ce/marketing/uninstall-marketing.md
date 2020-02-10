---
title: "Uninstall Dynamics 365 Marketing (Dynamics 365 Marketing) | Microsoft Docs"
description: "How to remove Dynamics 365 Marketing from a Dynamics 365 instance"
keywords: uninstall;solutions;administration;instances
ms.date: 02/10/2020
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
ms.assetid: 76871891-d62c-4496-81f6-60b31bf5e3e6
author: alfergus
ms.author: alfergus
manager: shellyha
ms.reviewer:
topic-status:
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Uninstall Marketing

You can remove Marketing from any Dynamics 365 instance where you have installed it. After removing it, you'll end up with a free Marketing entitlement (license) that you can install on another Dynamics 365 instance if needed.

To uninstall Marketing and reuse the entitlement, complete the following steps:

1. Uninstall the Marketing services by running the uninstall wizard.
1. Reset all Dynamics 365 Portals that were connected to the Marketing (if any).

> [!NOTE]
> If you want to release your Marketing entitlement to use for a different instance, you do not need to uninstall the Marketing solutions.

## Uninstall the Marketing services
The Marketing uninstall wizard manages most of the uninstall process. It:

- Removes all Marketing, event management, and Dynamics 365 Connector for LinkedIn Lead Gen Forms services from your Dynamics 365 application server.
- Removes your marketing-insights service and its data.
- Turns off user syncing from Office 365 for Marketing-only users.
- Frees your Dynamics 365 Marketing entitlement (license) for use with another Dynamics 365 instance if needed.

To run the uninstall wizard:

1. If you have sample data installed, remove it. More information: [Manage sample data](additional-settings.md).

1. [Launch the Marketing setup wizard](re-run-setup.md) for the instance you want to uninstall Marketing from. Make sure the correct instance (organization) is shown.

    ![Setup wizard for an existing instance with portal integration](media/fre-re-run.png "Setup wizard for an existing instance with portal integration")

1. From the **Other actions** panel, choose **Uninstall Marketing from this org**.

1. Follow the instructions on your screen to confirm and complete the uninstall.

<a name="reset-portal"></a>

## Reset any Dynamics 365 Portals connected to the uninstalled Marketing app

If the Dynamics 365 Marketing instance that you are uninstalling was integrated with a Dynamics 365 Portal (for example to run marketing pages and the events website) then you must reset the portal to release its license. After the reset, the portal will still be shown as "configured" in the Dynamics 365 admin center, but you will now be able to select it when you run the Marketing setup wizard to set up a new, copied, or restored instance.

Portals are optional, so you might not have one connected to your Marketing instance. For more information about how Dynamics 365 Marketing uses portals, see [Integrate Marketing with a CMS system or Dynamics 365 Portal](portal-optional.md).

To reset a portal being used by Marketing:

1. Follow the instructions provided in [Reset a portal](../portals/reset-portal.md).
1. Portal reset leaves behind its website bindings, which may prevent you from reusing your portal name. Therefore, you should always delete all website bindings that are related to the portals used by your uninstalled Marketing instance. See [Create and manage website bindings](../portals/website-bindings.md) for instructions.

### See also

[Open the Dynamics 365 admin center](dynamics-365-admin-center.md)  
[Keep Marketing up to date](apply-updates.md)  
[Manage Marketing instances](manage-marketing-instances.md)  
