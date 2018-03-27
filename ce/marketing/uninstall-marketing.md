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

The uninstall process has three steps:
1. Prepare to uninstall by removing sample data and customer journeys.
1. Uninstall the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] services by running the uninstall wizard.
1. Clean up the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] solutions in [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)].

## Prepare to uninstall
Before you uninstall any [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] components, start by removing any sample data and data dependencies from your [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] instance by doing the following:

1. Remove the sample data if you have installed it. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Manage sample data](additional-settings.md).
1. Remove all customer journeys that include launch-workflow and/or record-updated tiles because these introduce data dependencies that can interfere with the uninstall. You might consider just deleting all your journeys if you don't need them anymore. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Create automated campaigns with customer journeys](customer-journeys-create-automated-campaigns.md)

## Uninstall the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] services
The [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] uninstall wizard manages most of the uninstall process by doing the following:

- Removes all [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)], event management, and [!INCLUDE[cc-linkedin-solution](../includes/cc-linkedin-solution.md)] services from your [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] application server.
- Removes your [!INCLUDE[pn-customer-insights-full](../includes/pn-customer-insights-full.md)] hub and its data.
- Turns off user syncing from [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] for [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)]-only users.
- Frees your [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] entitlement (license) for use with another [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] instance if needed.

To run the uninstall wizard:

1. [Open the Dynamics 365 admin center](dynamics-365-admin-center.md).

1. Select the **Applications** tab to see a list of applications you have installed.  
    ![Open the Applications tab](media/update-app-tab.png "Open the Applications tab")

    The list shows a row marked **Dynamics 365 Marketing Application** for each entitlement (license) you have for [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]. Free entitlements (which can't be uninstalled) show a **Status** of **Not configured**. Installed entitlements show a **Status** of **Configured** and include the name of the instance where they are installed as part of their application name.

1. Select the configured [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] entitlement that you want to uninstall and then select the **Manage** button ![The Manage button](media/update-manage-button.png "The Manage button") in the side panel. 

1. The [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] setup wizard opens.  It shows the name of the Dynamics 365 instance you are about to uninstall. Make sure you have chosen the right one.  
    ![Choose the Uninstall Marketing link](media/uninstall-wizard.png "Choose the Uninstall Marketing link")

1. Under **Other actions**, select **Uninstall Marketing from this org**.

1. Follow the instructions on your screen to confirm and complete the uninstall.

## Remove [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] solutions in [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)]
The uninstall wizard removes the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] services from your [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] server, but leaves behind several solutions on your instance. You should clean these up to help keep your instance lean and running smoothly.

To remove the services:

1. Use the app selector to go to the [!INCLUDE[pn-custom-app-module](../includes/pn-custom-app-module.md)] app.  
    ![The app-selector menu](media/nav-apps-custom-ill.png "The app-selector menu")

1. Go to **Settings** > **Customizations** > **Solutions** in the custom app to view the list of solutions installed there.

1. Find each of the following solutions and remove them, one at a time, in the order listed here. To remove a solution, select its check box and then choose **Delete** from the command bar. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Install, update, or remove a preferred solution](../admin/install-remove-preferred-solution.md)
    - MicrosoftDynamics_MktEmailTemplates
    -  MicrosoftDynamics_MktIntegration
    -  MicrosoftDynamics_MktPageTemplates
    -  MicrosoftDynamics_MktLeadGenLink
    -  MicrosoftDynamics_MktConsentManagement
    -  MicrosoftDynamics_MktQuotaInfo
    -  MicrosoftDynamics_MktLeadManagement
    -  MicrosoftDynamics_MktPortalsLink
    -  MicrosoftDynamics_MktVocLink
    -  MicrosoftDynamics_MktEvtMgmtLink
    -  MicrosoftDynamics_Marketing
    -  MicrosoftDynamics_MarketingAnchorSolution
    -  MicrosoftDynamics_EvtMgmtVocLink
    -  MicrosoftDynamics_EvtMgmtPortalsLink
    -  MicrosoftDynamics_EventManagement
    -  MicrosoftDynamics_EventManagementAnchorSolution
    -  LinkedInLeadGenIntegration

1. If you are no longer using portal or [!INCLUDE[pn-voice-of-the-customer](../includes/pn-voice-of-the-customer.md)] functionality, then you can delete their related solutions too.

### See also

[Open the Dynamics 365 admin center](dynamics-365-admin-center.md)  
[Keep Marketing up to date](apply-updates.md)  
[Manage Marketing instances](manage-marketing-instances.md)  