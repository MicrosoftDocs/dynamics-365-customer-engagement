---
title: "Introduction to the agent interface in Omni-channel Engagement Hub | MicrosoftDocs"
description: "Learn about the Omni-channel Engagement Hub agent interface in Unified Service Desk. The agent interface contains Omni-channel toolbar, session tab management toolbar, and application tab management toolbar."
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 03/07/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 7369f1e2-e536-4585-a69a-eee434a87af1
ms.custom: 
---

# Introduction to the agent interface in Omni-channel Engagement Hub

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0

[!include[cc-beta-prerelease-disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

When you sign in to Omni-channel Engagement Hub through Unified Service Desk, the Omni-channel Engagement Hub interface has the following components:

 - Omni-channel toolbar

 - Session management toolbar

 - Application management toolbar

 > [!div class=mx-imgBorder]
 >![omni-channel engagement hub agent interface](../../media/oc-usd-agent-interface.png "Omni-channel engagement hub agent interface")  

## Default global toolbar

The Omni-channel toolbar also called as default global toolbar as the components are

 - Search

 - Create

 - Settings

 - Presence

 > [!div class=mx-imgBorder]
 > ![Default global toolbar](../../media/oc-usd-global-toolbar.png "Default global toolbar")  

### Search

The **Search** button lets you search for records and open them in a new active session. You can use the **Search** button to search for the following types of records:

 - Case

 - Contact

 - Account

 - Phone call

 - Task Email
 
 > [!div class=mx-imgBorder]
 > ![omni-channel search](../../media/oc-usd-search.png "Omni-channel search")  

### Create

The **Create** button provides a list of related options (entities) so that you can access existing entities and create new entities.

### Settings

The **Settings** menu has **Debugger** and **About** options. These options provide insight into code runs and Unified Service Desk, respectively. There is also an option that opens the Best Practices Analyzer.

 > [!div class=mx-imgBorder]
 > ![omni-channel settings](../../media/oc-usd-settings.png "Omni-channel settings")  

#### Debugger

Use the **Debugger** option to gain insight into the process and code runs in the agent application.

#### About

Use the **About** option to view information about the user (agent), the agent's email ID, the Microsoft Dynamics 365 server and organization, Shell Version, and much more.

#### Best Practices Analyzer

Best practices are the guidelines about system configurations, Unified Service Desk, Internet Explorer settings, and Unified Service Desk configurations in Microsoft Dynamics 365 for Customer Engagement. Consider these guidelines our recommended way to use Unified Service Desk and serve your customers.

### Presence

Presence is the indication of your (agent) availability or status.

Presence status is updated in two ways: 
- **Manually** - You can change the status manually according to your availability.<br>Select on the presence text to view all the presence statuses and update your status manually. 

  > [!div class=mx-imgBorder]
  > ![Omni-channel presence status](../../media/oc-usd-presence.png "Omni-channel presence status")

Out-of-the-box you see the following presence statuses:

  - Offline
  - Appear away
  - Busy
  - Available
  - Do Not Disturb
 
  Also, you may see any other additional presence statuses that your administrator configured for you.

- **Automatically** - The status is set automatically based on the work item assignment. That is, when a conversation (work item) is assigned to you, the status is updated based on the capacity.

  a. When your capacity is completely utilized the presence is set to **BusyDND**.<br>
  b. When your capacity is partially utilized the presence is set to **Busy**. <br>
  c. When your capacity is not utilized the presence is set to **Available**.<br>

## Session management toolbar

Each session in the Unified Service Desk client is shown on the session tab toolbar on the main page. You can identify a session by the session name that is shown on the tab. You can switch between sessions to handle cases without affecting key performance indicators (KPIs).

> [!div class=mx-imgBorder]
> ![Omni-channel session management toolbar](../../media/oc-usd-session-management-toolbar.png "Omni-channel session management toolbar")  

## Application management toolbar

The application management toolbar lets you see all the related information for a session. For example, you can use this toolbar to open the **Omni-channel Agent Dashboard** page, search, use Customer summary, view a knowledge base (KB) article, or view case details. You can also switch between the application and session tab toolbars to effectively manage your sessions and related applications.

> [!div class=mx-imgBorder]
> ![Omni-channel application management toolbar](../../media/oc-usd-application-management-toolbar.png "Omni-channel application management toolbar") 

> [!div class="nextstepaction"]
> [Next topic: View agent dashboard and agent work items](introduction-agent-dashboard.md)

## See also

- [Sign in to Unified Service Desk – Omni-channel Engagement Hub](signin-unified-service-desk-omni-channel-engagement-hub.md)
- [View alert and toast notifications](notifications-screen-pop.md)
- [View customer summary and know everything about customers](customer360-overview-existing-challenges.md)
- [View communication panel](left-control-panel.md)
- [View call scripts, take notes, and search knowledge articles](right-control-panel.md)
- [View customer summary for an incoming conversation request](view-customer360-incoming-conversation-request.md)
