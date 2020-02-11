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

# Uninstall Dynamics 365 Marketing

You can remove the Marketing application from any Dynamics 365 instance where it's installed. After removing it, you'll end up with a Marketing license that you can use on another Dynamics 365 instance, if desired.


## Uninstall Dynamics 365 Marketing services


The Marketing uninstall wizard handles most of the uninstall process. The uninstall wizard:

- Removes all services for Marketing, event management, and Dynamics 365 Connector for LinkedIn Lead Gen Forms 
- Removes the marketing insights service and its data
- Turns off user syncing from Office 365 for Dynamics 365 Marketing users.
- Frees your Dynamics 365 Marketing license for use with another Dynamics 365 instance

> [!NOTE]
> If you want to release your Marketing entitlement to use on a different instance, you do not need to uninstall any of the Marketing solutions.

To run the uninstall wizard:

1. If you have sample data installed, remove it. More information: [Manage sample data](additional-settings.md).

1. [Run the Marketing setup wizard](re-run-setup.md) for the instance where you want to uninstall the Marketing application. Make sure the correct instance is listed.

    ![Setup wizard for an existing instance with portal integration](media/fre-re-run.png "Setup wizard for an existing instance with portal integration")

1. From the **Other actions** panel, choose **Uninstall Marketing from this org**.

1. Follow the on-screen instructions to confirm and complete the uninstall.

<a name="reset-portal"></a>

## Reset any Dynamics 365 Portals connected to the uninstalled Marketing app

If the Dynamics 365 Marketing instance that you are uninstalling was connected to a Dynamics 365 Portal (for example to run marketing pages or the events website), then you need to reset the portal to release its license. After the reset, the portal still shows as configured in the Dynamics 365 admin center, but you'll be able to select it when you run the Marketing setup wizard to set up a new, copied, or restored instance.

Portals are optional, so you might not have one connected to your Marketing instance. More information: [Integrate Marketing with a CMS system or Dynamics 365 Portal](portal-optional.md)

To reset a portal:

1. Follow the instructions provided in [Reset a portal](../portals/reset-portal.md).
1. Portal reset leaves behind its website bindings, which may prevent you from reusing your portal name. Therefore, you should always delete all website bindings that are related to the portals used by your uninstalled Marketing instance. More informatation: [Create and manage website bindings](../portals/website-bindings.md)

### See also

[Open the Dynamics 365 admin center](dynamics-365-admin-center.md)  
[Keep Marketing up to date](apply-updates.md)  
[Manage Marketing instances](manage-marketing-instances.md)  
