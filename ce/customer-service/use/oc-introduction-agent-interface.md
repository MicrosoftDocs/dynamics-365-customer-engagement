---
title: Introduction to agent interface
description: Learn about the agent interface in the Omnichannel for Customer Service app and the capabilities that it offers to agents.
ms.date: 08/30/2024
ms.topic: article
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.collection: get-started
---

# Introduction to the agent interface of Omnichannel for Customer Service

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

> [!IMPORTANT]
> The Omnichannel for Customer Service agent-facing app is deprecated, and we recommend that you start using [Customer Service workspace](../implement/csw-overview.md). Learn more in [Deprecations](../implement/deprecations-customer-service.md#omnichannel-for-customer-service-agent-facing-app-is-deprecated-and-removed-as-of-june-2024).

The Omnichannel for Customer Service app for Dynamics enables organizations to instantly connect and engage with their customers via channels like Chat for Dynamics 365 Customer Service and SMS. The app provides context rich multitasking experience across different customer sessions.

## Value propositions of Omnichannel for Customer Service app

- **Unified experience:** The app provides unified and consistent single-view experience for the agents to view conversation details, Customer information, and access Line-of-Business applications from within the Omnichannel for Customer Service app.

- **Multiple session and application management:** The app enables agents to handle multiple sessions and manage contextual applications (app tab panel) related to the sessions with ease, which in turn leads to less errors, faster case resolution, and customer satisfaction.

- **Deployment and upgrade:** The app is available as a web application (thin client), which makes the maintenance easy and the upgrades are seamless.

- **Extensibility:** The app is built on the Unified Interface framework, which makes easy for the developers and system customizers to customize and extend the app.

## High-level feature capabilities for the agents

As an agent, you might engage with several customers simultaneously across different channels but managing all the customer sessions is a challenge, especially switching between the sessions while understanding the context of the engagement. Omnichannel for Customer Service provides a consistent experience regardless of the support channel and organizations can maximize agent productivity.

Omnichannel for Customer Service provides the following key capabilities:

- Agent dashboard
- Multiple sessions
- Application tabs associated with sessions
- Active Conversation
- Communication panel
- Presence management
- Notifications
- Consult with agents and/or supervisors
- Transfer conversation to another agent or queue
- Capture notes specific to the conversation

 > [!div class=mx-imgBorder]
 > ![Interface of Omnichannel for Customer Service app.](../media/oceh-oc-agent-interface-tier1-dashboard.png "Interface of Omnichannel for Customer Service app") 

## Components in the agent interface

When you start a chat session in Omnichannel for Customer Service, the agent interface has the following components:

- Communication panel

- Application tab panel

- Unified Interface application area

- Search, quick create, and presence

 > [!div class=mx-imgBorder]
 > ![Session panel in Omnichannel for Customer Service app.](../media/oceh-interface.png "Session panel in Omnichannel for Customer Service app") 

## Communication panel

The communication panel is where you, as an agent, interact with your customer. When you sign in to the application, by default, the communication panel is in hidden mode. That is, the communication panel appears on the left side next to the session panel only when you accept an incoming conversation request. To learn more, see [View communication panel](oc-conversation-control.md).

 > [!div class=mx-imgBorder]
 > ![Communication panel in the agent interface of Omnichannel for Customer Service app.](../media/oceh-communication-panel.png "Communication panel in Omnichannel for Customer Service app")

## Application tab panel

The horizontal bar below the navigation bar is called the application tab panel. Every customer session has at least one that is not closable. The Application tab has a **+** icon. If you select the icon, the menu that has options that are made available by your administrator. The menu shows the out-of-box and custom entities. Also, you can access any third-party applications that are extended within Omnichannel for Customer Service app. Select the option from the list to open it in the application tab.

> [!div class=mx-imgBorder]
> ![Omnichannel for Customer Service sitemap appears when you select + icon in the application tab.](../media/oceh-agent-interface-sitemap.png "Omnichannel for Customer Service sitemap in the application tab")

## Unified Interface application area

 When you sign in to Omnichannel for Customer Service, as an agent, in the application area, you see a dashboard that is set as default by your administrator. If set as default, Omnichannel Agent Dashboard shows the different work items in streams, and the dashboard is present in the application tab of the **Home** session and you can't close the dashboard tab.

   > [!div class=mx-imgBorder]
   > ![Omnichannel Agent Dashboard shows My work items, Open work items, and closed work items.](../media/oceh-agent-interface-oceh-dashboard.png "Omnichannel Agent Dashboard")

   The dashboard shows the following work items:
    - **My work items**
    - **Open work items**
    - **Closed work items**

   To learn more, see [View agent dashboard and conversations (work items)](oc-agent-dashboard.md).

## Search, quick create, and presence

   Search, quick create, and presence are the options present in the nav bar.

   ![Navigation bar buttons of Omnichannel for Customer Service.](../media/oceh-navigation-bar-buttons.png "Navigation bar buttons of Omnichannel for Customer Service")

   - **Search:** Do a simple search for records using the advanced search option and open the record in an application tab. Advanced Search is also called Categorized Search.

   - **Quick create:** Add a new record. This option provides the list of related records that you can create. The following are the record types that you can create:
    
       - Activities
       - Appointment
       - Email
       - Phone Call
       - Task
       - Account
       - Case
       - Contact
       - Knowledge Article
    
     Select the expand button next to Activities to create different activities.
    
     ![Quick-create option in Omnichannel for Customer Service.](../media/oceh-quick-create.png) ![Quick-create option for activities in Omnichannel for Customer Service](../media/oceh-quick-create-activities.png)
    
     When you select any record, the application displays a new quick create form. For example, select the **Account** record from the list. The application displays the **Quick Create: Account** form. Specify the details in the fields and save the form.
    
   > [!div class="mx-imgBorder"]
   > ![Quick create account form.](../media/oceh-quick-create-forms-account.png "Quick create account form")

   - **Presence:** Set presence as per your availability. Select the icon to launch the presence dialog and use the dropdown list to select a status. To learn more, see [Manage presence status](oc-manage-presence-status.md).

### Related information

- [Manage sessions](oc-manage-sessions.md)
- [Manage applications](oc-manage-applications.md)
- [Understand conversation states](oc-conversation-state.md)
- [Sign in to Omnichannel for Customer Service](oc-sign-in-omnichannel.md)
- [View communication panel](oc-conversation-control.md)
- [View agent dashboard and conversations (work items)](oc-agent-dashboard.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
