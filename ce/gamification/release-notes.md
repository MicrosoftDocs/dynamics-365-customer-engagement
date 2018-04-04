---
title: "Learn about what's new in Microsoft Dynamics 365 - Gamification and the issues addressed by the team. | Microsoft Docs"
description: "Learn about new features, improved capabilities, fixed issues in Dynamics 365 - Gamification."
keywords: "what's new, release notes, fixed issues, dynamics 365 gamification"
ms.date: 03/19/2018
ms.service: gamification
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: d94c2bbe-b73d-4369-9100-e5d1a096409a
author: m-hartmann
ms.author: mhart
manager: sakudes
topic-status: Drafting
---

# What's new in Dynamics 365 - Gamification

Welcome to [!INCLUDE[pn_gamification](../includes/pn-gamification.md)]. Here's a list of features we've added or updated, and a list of issues we've resolved.  

If you are new to [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest.md)], see [Keep your employees engaged and productive by using Gamification](increase-employee-productivity.md).

The two core components of [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest.md)] are the solution, which is [installed from AppSource](https://go.microsoft.com/fwlink/p/?linkid=830919) and integrated in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-2016-shortest.md)], and [the web portal](https://go.microsoft.com/fwlink/p/?linkid=830344), where all the fun happens.

## Update 2018.2.11

### New or improved features

- The shortcut to help articles is now accessible when using a keyboard for navigation.

- Images throughout the solution and web portal now have proper alt text.

- Additional information about certain fields and controls are now accessible when using a keyboard for navigation.

- Screen readers now read the label of a checkbox when selected.

#### Solution

- Newly assigned Game Manager roles in Dynamics 365 now [sync automatically](understand-security-roles.md#available-security-roles) with the Gamification web portal. Administrators don't need to manually trigger an update of the user data after updating the solution to at least version 2018.2.11.

## Update 2018.2.9

### Resolved issues

- Screen readers now read labels of radio buttons and checkboxes when configuring KPIs in a Unified Interface app. 

- Screen readers now treat navigation elements consistently in all web applications.

- Buttons in Gamification settings can no longer be selected when they're disabled.

- Drop-down menus on the KPI form in Unified Interface apps now shows proper values to choose from.

- To avoid server timeout, the user synchronization workflow now has more time to complete. 

## Update 2017.10

### New or improved features

#### Solution

- This update introduces significant changes to user management for [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest.md)]. Instead of the [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest.md)] web portal, security roles for users are now managed the same way they're managed in Dynamics 365 Customer Engagement.  
The Dynamics 365 (online) security role **KPI manager** is now called **Game manager**. If a user has the Game Manager security role assigned in Dynamics 365, they get promoted to game manager in [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest.md)] and can continue to create and edit KPIs in Dynamics 365.
To promote a user to a Commissioner role in [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest.md)], a global admin of Dynamics 365 is required to assign the user the **Global Admin** or **Dynamics 365 Service Admin** role in the [Dynamics 365 Admin Center](https://portal.office.com). 
[!include[](../includes/proc-more-information.md)] [Available security roles](understand-security-roles.md)

- Administrators can now connect multiple Dynamics 365 (online) organizations from the same Office 365 tenant to the same [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest.md)] web portal. This maintains a shared experience across organizations. [!include[](../includes/proc-more-information.md)] [Set up a connection to a Dynamics 365 (online) organization](manage-gamification-in-dynamics-365-online.md)


#### Web portal

- [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest.md)] now supports multiple Dynamics 365 (online) organizations in the same Office 365 tenant. Game managers and players can select the organization when they select the game they want to work with. Badges and awards are based on the player's profile and shared across all connected organizations.


### Resolved issues

- Duplicates in player data records sometimes caused an issue with an aggregation worker. Duplicates are now deleted automatically to mitigate this issue.

## Update 2017.05

### New or improved features

#### Solution

- Simplified the steps to activate the [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest.md)] web portal and connect it with [!INCLUDE[pn_crm_shortest](../includes/pn-crm-2016-shortest.md)]. [!INCLUDE[proc_more_information](../includes/proc-more-information-md.md)]
[Activate Gamification in Dynamics 365](manage-gamification-in-dynamics-365-online.md)

- Introduced a KPI type, **User activity tracking**, to award points based on a user's activity in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-2016-shortest.md)].

- Introduced **Delta settings**, a scoring condition for KPIs that is based on the difference (the delta) between two attributes.

- Introduced **Scoring behavior**, a setting for configuring the time at which points are assigned for a given KPI. By default, points are always assigned based on the current state of the record. [!INCLUDE[proc_more_information](../includes/proc-more-information-md.md)]
[Configure and edit KPIs in Dynamics 365](configure-kpis.md)

#### Web portal

- Added Stream TV backgrounds.

- Updated the experience for **Game setup** and for creating and editing **Stream TV**.


### Resolved issues

- Improved the reliability of user data synchronization between [!INCLUDE[pn_crm_shortest](../includes/pn-crm-2016-shortest.md)] and [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest.md)].

- Improved the reliability of sending KPI data to [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest.md)].


