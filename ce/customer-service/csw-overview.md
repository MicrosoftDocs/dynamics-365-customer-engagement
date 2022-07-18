---
title: Overview of the Customer Service workspace application for Dynamics 365 Customer Service
description: Overview of the Customer Service workspace application for Dynamics 365 Customer Service.
ms.date: 07/05/2022
ms.topic: overview
author: lalexms
ms.author: laalexan
manager: shujoshi
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
ms.custom: 
  - dyn365-customerservice
  - intro-internal
---

# Get started with Customer Service workspace

The Dynamics 365 Customer Service workspace helps increase agent productivity for core customer service. It's a modern, customizable, high-productivity application that allows agents to work on multiple sessions at a time in a single workspace. Customer Service workspace seamlessly allows agents to manage conversations across different channels.

> [!NOTE]
> Customer Service workspace is currently not available on mobile devices.

## Introduction to Customer Service workspace

Access Customer Service workspace through the app selector where you find other Dynamics 365 apps. Or, select it in the drop-down navigation in the upper-left corner of Dynamics 365.

By default, Customer Service workspace opens in the Customer Service Agent Dashboard view. The dashboard shows your active cases, cases you can work on in queues that you're assigned to, and your open activities. You can open existing cases and activities, work on new cases and activities, and create cases and activities.

### Enhanced multisession workspace (preview)

If you or your administrator has [turned on the enhanced multisession workspace](#turn-on-the-enhanced-multisession-workspace-preview), your view is as seen in the following screenshot.

:::image type="content" source="media/csw-overview-enhanced.png" alt-text="Screenshot of the enhanced multisession Customer Service workspace, with items labeled according to the legend in the table":::

| Label | Description |
| ------------ | ------------- |
| 1 | Select the icon to open the site map. |
| 2 | Select the **Home** tab to return to the Customer Service Agent Dashboard view. |
| 3 | Select the [**Inbox**](#use-the-inbox) tab to view all the cases and conversations that are assigned to you. You'll only see the inbox if it's turned on for your profile. |
| 4 | Each open session has a tab in the tab row. Select a tab to navigate between sessions. |
| 5 | Select a case or an activity to open a new session. The session opens in a new tab in the workspace window. |
| 6 | Select the arrow to choose a different view. |
| 7 | Select the arrow to view a different dashboard. |

### Default multisession workspace

If your or your administrator hasn't turned on the enhanced multisession workspace, your view is as seen in the following screenshot.

:::image type="content" source="media/csw-overview.png" alt-text="Screenshot of the default Customer Service workspace, with items labeled according to the legend in the table":::

| Label | Description|
| ------------ | ------------- |
| 1 | Select the **Home** icon to return to the Customer Service Agent Dashboard view. |
| 2 | The session pane shows all the sessions you've opened. Select the icons to navigate between sessions. |
| 3 | Select the **+** icon in the tab bar to open more workspaces in a new tab. If you hold the Ctrl key while you select a case or an activity, the case or activity opens in a new tab, too. Select a tab to navigate between sessions. |
| 4 | Select the arrow to choose a different view. |
| 5 | Select a case or an activity to open a new session. The session replaces your current view with the case form. Select the back arrow in the upper-left corner of the form to get back to your previous view. To open the case or activity in a new tab, hold the Ctrl key while you select it. |
| 6 | Select the arrow to view a different dashboard. |

## Customize Customer Service workspace

You can use your browser's developer tools to customize some aspects of the Customer Service workspace.

### Turn on the enhanced multisession workspace (preview)

1. With Customer Service workspace open, press the F12 key to open the developer tools window.
1. In the console window, type the following command and press Enter: `Xrm.Utility.getGlobalContext().saveSettingValue("msdyn_MultiSessionLayoutImprovements",true)`
1. Refresh the app page.

> [!NOTE]
> If you turn on the enhanced multisession workspace, the enhanced experience applies in both Customer Service workspace and Omnichannel for Customer Service.

### Turn off the close session dialog

1. With Customer Service workspace open, press the F12 key to open the developer tools window.
1. In the console window, type the following command and press Enter: `Xrm.Utility.getGlobalContext().saveSettingValue("msdyn_SuppressSessionCloseWarning",true)`
1. Refresh the app page.

### Turn on legacy navigation (deprecated)

> [!NOTE]
> The legacy navigation is deprecated and will be removed in a future release.

1. With Customer Service workspace open, press the F12 key to open the developer tools window.
1. In the console window, type the following command and press Enter: `Xrm.Utility.getGlobalContext().saveSettingValue("msdyn_MultisessionNavigationImprovements",false)`
1. Refresh the app page.

## Navigate Customer Service workspace

From the **Home** session, you can:

- Select a record in a view, a dashboard, or a queue to open the record in a new session tab.
- Select a case or a customer in a case. These records open in a new tab.
- Create a new record in a view. Select **New** to open the entity form in a new session.
- Select the global search to open the search feature in a new tab.

In a session that's open, you can:

- Select a related record from a form to open the record in a new tab in the same session.
- Select a related record from the timeline to open the record in a new tab in the same session.
- Create a record from the timeline to open the entity form in a new tab in the same session.
- Select **New** to create a record from a form. The entity form opens in a new session.
- Search for and select a record from an existing session and open the record in a new tab.

    If you select a record or a session that's already open, it's highlighted instead of opening multiple times.

## Work with cases

:::image type="content" source="media/bulkEditCases.png" alt-text="Screenshot that shows multiple cases selected and items labeled according to a table below the screenshot.":::

| Label | Description|
| ------------ | ------------ |
| 1 | Select the top check mark to select all cases in the view, or select individual check boxes to group cases for bulk editing. |
| 2 | Associate child cases with selected cases. |
| 3 | Merge selected cases. |
| 4 | Edit selected cases. |
| 5 | Delete selected cases. |
| 6 | Apply a routing rule to route selected cases to a queue. |
| 7 | Open the menu for more actions including Assign, Add to Queue, Run Report, Email a Link, Share, Follow, and Unfollow cases. |

### Edit case data

Let's explore the fields you can edit on the **Summary** tab.

:::image type="content" source="media/CaseSummary.png" alt-text="Screenshot of the Customer Service workspace case Summary tab, with items labeled according to a table below the screenshot.":::

| Label | Description |
| ------------ | ------------- |
| 1 | You can update the Case Title, Customer, Subject, Priority, Case Status, Product, and Description. |
| 2 | Case Number, Origin, and Created On are set when the case is created. You can't change these attributes. You can change the Case Owner. |
| 3 | Select the plus sign (+) on the timeline to expand the menu of timeline actions. |

Let's explore the fields you can edit on the **Additional Details** or **Details** tab.

:::image type="content" source="media/CaseAddtlDetails.png" alt-text="Screenshot of the Customer Service workspace case Additional Details tab, with items labeled according to a table below the screenshot.":::

| Label | Description |
| ------------ | ------------- |
| 1 | You can set Service Level Agreement (SLA) attributes so that customer support managers can measure the overall success of the support organization against its goals. |
| 2 | Associate a Parent Case, classify the case Type, and apply a support Entitlement. |
| 3 | Sort and export the list of associated knowledge articles. |
| 4 | View and export the list of similar cases. |
| 5 | View, add associations, and export child cases. |
| 6 | View and export the list of merged cases. |

## Work with activities

:::image type="content" source="media/bulkEditActivities.png" alt-text="Screenshot that shows multiple activities selected and items labeled according to a table below the screenshot.":::

| Label | Description|
| ------------ | -------------|
| 1 | Select the top check mark to select all activities in the view, or select individual check boxes to group activities for bulk editing.|
| 2 | Edit selected activities. |
| 3 | Delete selected activities. |
| 4 | Open the menu for more actions including Mark Complete, Cancel, Set Regarding, Assign, Email a Link, Add to Queue, and Run Report. |

## Create and search knowledge articles

Expand the Customer Service workspace site map and select **Knowledge Articles** or **Knowledge Search**. Intelligent knowledge suggestions are displayed in the productivity pane while you're working on a case.

Learn more about how to [create and manage knowledge articles](customer-service-hub-user-guide-knowledge-article.md).

## Use email templates and signatures

Expand the Customer Service workspace site map and select **Email Templates** or **Email Signatures**.

Learn more about how to create [email templates](/power-apps/user/email-template-create.md) and [email signatures](/power-apps/user/email-signature.md).

## Use the Inbox

If your administrator has turned on the inbox for your profile, you can select the **Inbox** tab to view all the cases, conversations, and activities that are assigned to you. Use the inbox to work on high-velocity tasks. You can also promote inbox sessions to regular sessions when you need more time to resolve a case or complete a conversation.

The following asynchronous channels are available in the conversation inbox: SMS, persistent chat, Facebook, Twitter, WeChat, LINE, WhatsApp, and Teams.

The inbox conversation view looks as seen in the following screenshot.

:::image type="content" source="media/inbox-csw.png" alt-text="Screenshot of the Customer Service workspace inbox conversation view.":::

The inbox case view looks as seen in the following screenshot.

:::image type="content" source="media/inbox-case.png" alt-text="Screenshot of the Customer Service workspace inbox case view.":::

Learn how to [configure the inbox view](/../../dynamics-365-customer-engagement-pr/ce/app-profile-manager/app-profile-manager.md#configure-the-inbox-view).

## Use the productivity pane with Smart Assist

While you're working on a case, the productivity pane on the right side of the Customer Service workspace displays intelligence-driven suggestions to help you. The productivity pane uses Smart Assist to suggest related cases and knowledge articles that could be relevant. You'll also see agent scripts that guide you through a consistent series of steps with potentially automated actions through macros.

:::image type="content" source="media/productivity-pane-overview.png" alt-text="Screenshot of the productivity pane with Smart Assist suggestions.":::

Learn more about using the [productivity pane](csw-productivity-pane.md).

### See also

[Work with cases in Customer Service Hub](customer-service-hub-user-guide-create-a-case.md)  
[Work with activities in Customer Service Hub](customer-service-hub-user-guide-manage-timeline-activities.md)  
[Overview of the productivity pane](csw-productivity-pane.md)  
[Migrate from Unified Service Desk to Customer Service workspace](../unified-service-desk/admin/migrate-to-csw.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
