---
title: "Uninstall Dynamics 365 Marketing (Dynamics 365 Marketing) | Microsoft Docs"
description: "How to remove Dynamics 365 Marketing from a Dynamics 365 instance"
keywords: uninstall;solutions;administration;instances
ms.date: 08/14/2019
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
ms.assetid: 76871891-d62c-4496-81f6-60b31bf5e3e6
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

# Uninstall Marketing

You can remove Marketing from any Dynamics 365 instance where you have installed it. After removing it, you'll end up with a free Marketing entitlement (license) that you can install on another Dynamics 365 instance if needed.

The uninstall process has up to three steps:

1. Uninstall the Marketing services by running the uninstall wizard.
1. Reset all Dynamics 365 Portals that were connected to the Marketing (if any).
1. Clean up the Marketing solutions in Dynamics 365.

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

## Remove Marketing solutions in Dynamics 365

The uninstall wizard removes the Marketing services from your Dynamics 365 server, but it leaves several solutions on your instance. You should clean these up to help keep your instance lean and running smoothly.

### Step 1: Stop all live entities and remove data dependencies

Before you remove any solutions, start by stopping all live entities, including:

- Customer journeys
- Marketing email messages
- Marketing pages
- Content settings
- Lead-scoring models
- Segments

Customer journeys can introduce data dependencies if they include launch-workflow and/or updated-record tiles. These dependencies may prevent you from uninstalling one or more solutions. To remove these:

- Delete all customer journeys that you can (you may be prevent from deleting journeys in any state other than **Draft**)
- If you have any customer journeys that you can't delete, do one of the following:
  - Wait for the journeys to transition into the **Expired** state (this will happen automatically 30 days after your stop them) and then delete them.
  - If you don't have any updated-record tiles left in any of your journeys, then you can proceed without deleting the rest of your journeys provided you do delete all workflows that are referenced by launch-workflow tiles in your remaining journeys.
- If you've customized your instance by adding any of the custom controls provided by Dynamics 365 Marketing (such as the marketing calendar) to other entities, then remove these cusomizations.

### Step 2: Remove the solutions

To remove the solutions:

1. Open the **Settings** menu ![The Settings menu icon](media/settings-icon.png "The Settings menu icon") at the top of the page and select **Advanced settings**. The advanced-settings area then opens in a new browser tab. Note that this area uses a horizontal navigator at the top of the page instead of a side navigator.

1. Navigate to **Settings** > **Customization** > **Solutions** to manage your installed solutions.

1. Find each the solutions listed in the [Solution uninstall order for removing Dynamics 365 Marketing](solution-uninstall-order.md) document and remove them, one at a time, in the order listed there. (Some of the items listed may not be present on your instance, so just skip these.) To remove a solution, select its check box, and then select **Delete** on the command bar. More information: [Install, update, or remove a preferred solution](https://docs.microsoft.com/power-platform/admin/install-remove-preferred-solution)

    > [!IMPORTANT]
    > You must follow the order exactly as it appears in the [Solution uninstall order](solution-uninstall-order.md) document.

    > [!NOTE]
    > The [Solution uninstall order](solution-uninstall-order.md) document lists the uninstall order for the latest version of Dynamics 365 Marketing. If you are uninstalling an earlier version, then just skip over any solution listed here that you don't see on your installation.

    > [!NOTE]
    > The [Solution uninstall order](solution-uninstall-order.md) document is only available in English, but the solution names and uninstall order are the same for all languages. The other text there just summarizes the procedure described here.

1. If you see any other "anchor" solutions that start with "MicrosoftDynamics_", then you can delete these too. They are probably left over from an earlier version that you upgraded.

1. If you're no longer using the [!INCLUDE [cc-linkedin-solution](../includes/cc-linkedin-solution.md)], then also remove the LinkedInLeadGenIntegration solution.

1. If you're no longer using Dynamics 365 Portals or Voice of the Customer functionality, you can also delete their related solutions.

### See also

[Open the Dynamics 365 admin center](dynamics-365-admin-center.md)  
[Keep Marketing up to date](apply-updates.md)  
[Manage Marketing instances](manage-marketing-instances.md)  
