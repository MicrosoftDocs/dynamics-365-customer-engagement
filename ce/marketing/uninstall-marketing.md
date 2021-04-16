---
title: "Uninstall Dynamics 365 Marketing (Dynamics 365 Marketing) | Microsoft Docs"
description: "How to remove Dynamics 365 Marketing from a Dynamics 365 instance."
ms.date: 02/10/2020
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
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
- Turns off user syncing from Microsoft 365 for Dynamics 365 Marketing users
- Frees your Dynamics 365 Marketing license for use with another Dynamics 365 instance

> [!NOTE]
> If you want to release your Marketing entitlement to use on a different instance, you do not need to uninstall any of the Marketing solutions.

To run the uninstall wizard:

1. If you have sample data installed, remove it. More information: [Manage sample data](additional-settings.md).

1. [Run the Marketing setup wizard](re-run-setup.md) for the instance where you want to uninstall the Marketing application. Make sure the correct instance is listed.

    > [!div class="mx-imgBorder"]
    > ![Setup wizard for an existing instance with portal integration](media/fre-re-run3.png)

1. From the **Other actions** panel, choose **Uninstall Marketing from this org**.

1. Follow the on-screen instructions to confirm and complete the uninstall.

<a name="reset-portal"></a>

## Reset any Power Apps portals connected to the uninstalled Marketing app

If the Dynamics 365 Marketing instance that you are uninstalling was connected to a Power Apps portal (for example to run marketing pages or the events website), then you need to reset the portal to release its license. After the reset, the portal still shows as configured in the Power Platform admin center, but you'll be able to select it when you run the Marketing setup wizard to set up a new, copied, or restored instance.

Portals are optional, so you might not have one connected to your Marketing instance. More information: [Integrate Marketing with a CMS system or Power Apps portal](portal-optional.md)

To reset a portal:

1. Follow the instructions provided in [Reset a portal](/powerapps/maker/portals/admin/reset-portal).
1. Portal reset leaves behind its website bindings, which may prevent you from reusing your portal name. Therefore, you should always delete all website bindings that are related to the portals used by your uninstalled Marketing instance. More information: [Create and manage website bindings](/powerapps/maker/portals/configure/website-bindings)

### See also

[Open the Power Platform admin center](power-platform-admin-center.md)  
[Keep Marketing up to date](apply-updates.md)  
[Manage Marketing environments](manage-marketing-environments.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]