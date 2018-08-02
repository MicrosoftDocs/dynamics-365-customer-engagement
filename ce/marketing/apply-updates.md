---
title: "Find and apply updates to core and shared solutions (Dynamics 365 for Marketing) | Microsoft Docs"
description: "How to find out when an update for one or more Dynamics 365 for Marketing solutions are available and then apply the updates"
keywords: "update;solutions;administration;instances"
ms.date: 04/01/2018
ms.service:
  - "dynamics-365-marketing"
ms.custom:
  - "dyn365-admin"
  - "dyn365-marketing"
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: bbe53dc0-8d10-15f0-b970-8f6f252da6e4
author: kamaybac
ms.author: kamaybac
manager: sakudes
ms.reviewer: renwe
topic-status: Drafting
---

# Keep Marketing up to date

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)] is continuously developing and improving online services. Though we roll out updates as soon as they're ready, we don't apply them automatically to customers' systems because most customers prefer to manage this process themselves--for example, by applying and testing updates on a sandbox instance before applying them to a production system.

Read this topic to get an overview of how to update [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] and its related solutions.

## Solutions included with [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]

[!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] is implemented using several different [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] _solutions_, where a _solution_ is a type of software package that adds functionality to your [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] platform. [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] includes several solutions that are unique to the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] app, plus a few more that are available as separate apps or in other [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] app bundles.

When you install [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)], all its solutions are installed by the setup wizard. However, when it comes to keeping your system up to date, you'll need to monitor and update each of the following types of solutions separately:

- **Core [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] solutions**: These are the solutions that provide core features that are unique to [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] (including the [!INCLUDE[cc-linkedin-solution](../includes/cc-linkedin-solution.md)]). Though there are several of these, you'll be able to maintain and update them all at once using a setup wizard like the one you used to install [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] for the first time.
- **[!INCLUDE[pn-voice-of-the-customer-full](../includes/pn-voice-of-the-customer-full.md)]**: This solution enables [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] to host surveys and collect responses. It's also available as an add-on or bundle for other [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] apps. You must update this solution separately from the other solutions included with Marketing, using its own update program.
- **[!INCLUDE[pn-portals](../includes/pn-portals.md)] capabilities for [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)]**: This solution enables [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] to host interactive portals that display and collect [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] data, including the events portal and marketing pages. Like [!INCLUDE[pn-voice-of-the-customer](../includes/pn-voice-of-the-customer.md)], you must update this solution using its own update program.

## Find out when new updates are available

To find out when an update is available, regularly check the status of your apps and solutions in the [!INCLUDE[pn-dyn-365-admin-center](../includes/pn-dyn-365-admin-center.md)], as described in the following sections. It's also a good idea to participate in forums and follow blogs about [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)], where updates are likely to be announced and discussed.

## Find and apply updates for core [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] solutions

To find and apply available updates to all core [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] solutions, including the [!INCLUDE[pn-linkedin-solution-shortest](../includes/pn-linkedin-solution-shortest.md)]:

1. [Open the Dynamics 365 admin center](dynamics-365-admin-center.md).

1. Select the **Applications** tab to see a list of applications you have installed.  
    ![Open the Applications tab](media/update-app-tab.png "Open the Applications tab")

    The list shows a row marked **Dynamics 365 Marketing Application** for each entitlement (license) you have for [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]. Free entitlements (which can't be updated) show a **Status** of **Not configured**. Installed entitlements show a **Status** of **Configured** and include the name of the instance where they are installed as part of their application name.

1. Select the configured [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] entitlement that you want to update and then select the **Manage** button ![The Manage button](media/update-manage-button.png "The Manage button") in the side panel. 

1. The [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] setup wizard opens.  It shows the name of the Dynamics 365 instance you are about to update. Make sure you have chosen the right one. Look for the **Update packages** button. If the update button isn't shown, then no updates are available for the current organization and you can just quit the wizard.  
    ![Select the Update packages button](media/update-fre-update-packages-button.png "Select the Update packages button")

1. If the **Update packages** button is shown, then select it to start the update. The update starts right away, and a page opens to track the progress of the update and will tell you when it's finished.

1. Repeat this procedure for each [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] organization that you have.

## Find and apply updates for shared [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] solutions


> [!IMPORTANT]
> Always check for and apply core [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] updates (as described in the previous section) _before_ you look for shared-solution updates. This is because you will also see core-[!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] solutions listed when you follow the instructions provided in this section, but it is faster, easier, and safer to update them using the update wizard.

To update shared (non-core [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)]) solutions, including [!INCLUDE[pn-voice-of-the-customer](../includes/pn-voice-of-the-customer.md)] and [!INCLUDE[pn-portals](../includes/pn-portals.md)]:

1. [Open the Dynamics 365 admin center](dynamics-365-admin-center.md) and go to the **Instances** tab.  
    ![Open the Instances tab](media/update-instances-tab.png "Open the Instances tab")

1. If you have more than one [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] instance, then each of them is listed here. Select the instance where you have [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] installed.

1. The column next to the instance list shows information about your selected instance, including a list of solutions installed there. Select the **Manage your solutions** button ![The Manage your solutions button](media/update-manage-button.png "The Manage your solutions button") next to the **Solutions** heading here.  
    ![Select the Manage your solutions button](media/update-open-manage-solutions.png "Select the Manage your solutions button")

1. A list of solutions installed on your selected instance is shown. Look in the **Status** column for any solutions that show a value of "Upgrade available." The solutions that are relevant for Marketing are "[!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] [!INCLUDE[pn-portals](../includes/pn-portals.md)] – Base Portal" and "[!INCLUDE[pn-voice-of-the-customer-full](../includes/pn-voice-of-the-customer-full.md)]". If you have many solutions installed, then use the paging controls at the bottom to check each page for available updates.  
    ![Select a solution to update](media/update-select-solution.png "Select a solution to update")

    > [!NOTE]
    >  As mentioned at the start of this procedure, you shouldn't update core [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] solutions from here. Always run the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] update wizard first, before you start looking for shared-solution updates, to ensure that all your core [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] solutions are already shown as up-to-date in this list.

1. Select a solution marked as having an upgrade available and read the information shown in the side panel. Select the **upgrade** button ![The Upgrade button](media/update-manage-button.png "The Upgrade button") in the side panel and then follow the instructions on your screen to apply it.

1. Repeat this procedure for each solution that requires an update.

### See also

[Open the Dynamics 365 admin center](dynamics-365-admin-center.md)  
[Manage Marketing instances](manage-marketing-instances.md)  
[Uninstall Marketing](uninstall-marketing.md)
