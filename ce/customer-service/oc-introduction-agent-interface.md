---
title: "Introduction to the agent interface of Omnichannel for Customer Service app | MicrosoftDocs"
description: "Learn about agent interface of Omnichannel for Customer Service app"
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 12/27/2019
ms.topic: article
ms.service: dynamics-365-customerservice
---

# Introduction to the agent interface of Omnichannel for Customer Service

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

The Omnichannel for Customer Service app for Dynamics enables organizations to instantly connect and engage with their customers via channels like Chat for Dynamics 365 Customer Service and SMS. The app provides context rich multi-tasking experience across different customer sessions.

## Value propositions of Omnichannel for Customer Service app

- **Unified experience:** The app provides unified and consistent single-view experience for the agents to view conversation details, Customer information, and access Line-of-Business applications from within the Omnichannel for Customer Service app.

- **Multi-session and application management:** The app enables agents to handle multiple sessions and manage contextual applications (app tab panel) related to the sessions with ease, which in-turn leads to less errors, faster case resolution, and customer satisfaction.

- **Deployment and upgrade:** The app is available as a web application (thin client), which makes the maintenance easy and the upgrades are seamless.

- **Extensibility:** The app is built on the Unified Interface framework, which makes easy for the developers and system customizers to customize and extend the app.

## High-level feature capabilities for the agents

As an agent, you might engage with several customers simultaneously across different channels but managing all the customer sessions is a challenge, especially switching between the sessions while understanding the context of the engagement. Omnichannel for Customer Service provides a consistent experience regardless of the support channel and organizations can maximize agent productivity.

The Omnichannel for Customer Service provides key capabilities like:

- Agent dashboard
- Multi-session
- Application tabs associated with sessions
- Customer summary
- Communication panel
- Presence management
- Notifications
- Consult with agents and/or supervisors
- Transfer conversation to another agent or queue
- Capture notes specific to the conversation

 > [!div class=mx-imgBorder]
 > ![Interface of Omnichannel for Customer Service app](media/oceh-oc-agent-interface-tier1-dashboard.png "Interface of Omnichannel for Customer Service app") 

## Components in the agent interface

When you sign in to the Omnichannel for Customer Service app, the agent interface has the following components:

1. Session panel

2. Communication panel

3. Application tab panel

4. Unified Interface application area

5. Search, quick create, and presence

 > [!div class=mx-imgBorder]
 > ![Session panel in the agent interface of Omnichannel for Customer Service app](media/oceh-interface.png "Session panel in Omnichannel for Customer Service app") 


## 1. Session panel

The vertical panel on the left side is the session panel that allows you (the agent) to work on multiple customer sessions simultaneously. In addition, as an agent you can switch between sessions without losing context of the conversation and customer details. The ability to handle multiple sessions simultaneously (while preserving customer context) allows you to resolve issues faster and achieve higher productivity.

 > [!div class=mx-imgBorder]
 > ![Session panel in the agent interface of Omnichannel for Customer Service app](media/oceh-agent-interface-session-panel.png "Session panel in Omnichannel for Customer Service app")

## 2. Communication panel

The communication panel is where you, as an agent, interact with your customer. When you sign in to the application, by default, the communication panel is in hidden mode. That is, the communication panel appears on the left side next to the session panel only when you accept an incoming conversation request. To learn more, see [View communication panel](oc-conversation-control.md).

 > [!div class=mx-imgBorder]
 > ![Communication panel in the agent interface of Omnichannel for Customer Service app](media/oceh-communication-panel.png "Communication panel in Omnichannel for Customer Service app")

## 3. Application tab panel

The horizontal bar below the navigation bar is called the application tab panel. Every customer session has at least one that is not closable; it is called a Anchor tab. The Application tab has a **+** icon. If you select the icon, the menu that has options that are made available by your administrator. The menu shows the out-of-box and custom entities. Also, you can access any third-party Line-of-Business applications that is extended within Omnichannel for Customer Service app. Select the option from the list to open it in the application tab.

> [!div class=mx-imgBorder]
> ![Omnichannel for Customer Service sitemap appears when you select + icon in the application tab](media/oceh-agent-interface-sitemap.png "Omnichannel for Customer Service sitemap in the application tab")

## 4. Unified Interface application area

 When you sign in to Omnichannel for Customer Service, as an agent, in the application area, you see a dashboard that is set as default by your administrator. If set as default, Omnichannel Agent Dashboard shows the different work items in streams, and the dashboard is present in the application tab of the **Home** session and you can't close the dashboard tab.

   > [!div class=mx-imgBorder]
   > ![Omnichannel Agent Dashboard shows My work items, Open work items, and closed work items](media/oceh-agent-interface-oceh-dashboard.png "Omnichannel Agent Dashboard")

   The dashboard shows the following work item streams:
    - **My work items**
    - **Open work items**
    - **Closed work items**

   To learn more, see [View agent dashboard and conversations (work items)](oc-agent-dashboard.md).

## 5. Search, quick create, and presence

   Search, quick create, and presence are the options present in the nav bar.

   ![Navigation bar buttons of Omnichannel for Customer Service](media/oceh-navigation-bar-buttons.png "Navigation bar buttons of Omnichannel for Customer Service")

   a. **Search.** Do a simple search for records using the advanced search option and open the record in a application tab. Advanced Search is also called as Categorized Search.

   b. **Quick create.** Add a new record. The quick-create option provides the list of related records (entities) that you can create. The following are the record types that you can create:
    
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
    
     ![Quick-create option in Omnichannel for Customer Service](media/oceh-quick-create.png) ![Quick-create option for activities in Omnichannel for Customer Service](media/oceh-quick-create-activities.png)
    
     When you select any record, the application displays a new quick create form. For example, select the **Account** record from the list. The application displays the **Quick Create: Account** form. Specify the details in the fields and save the form.
    
   > [!div class="mx-imgBorder"]
   > ![Quick create account form](media/oceh-quick-create-forms-account.png "Quick create account form")

   c. **Presence.** Set presence as per your availability. Select the icon to launch the presence dialog and use the drop-down list to select a status. To learn more, see [Manage presence status](oc-manage-presence-status.md).

## See also

- [Manage sessions](oc-manage-sessions.md)
- [Manage applications](oc-manage-applications.md)
- [Understand conversation states](oc-conversation-state.md)
- [Sign in to Omnichannel for Customer Service](oc-sign-in-omnichannel.md)
- [View communication panel](oc-conversation-control.md)
- [View agent dashboard and conversations (work items)](oc-agent-dashboard.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]