---
title: "Introduction to the agent interface of Omni-channel Engagement Hub app | MicrosoftDocs"
description: "Learn about agent interface of Omni-channel Engagement Hub in the Omni-channel Engagement Hub app"
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 04/17/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 891E5572-F1D6-413C-8F2E-299AF3CC34F9
ms.custom: 
---

# Introduction to the agent interface of Omni-channel Engagement Hub

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0

[!include[cc-beta-prerelease-disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

## Components in the agent interface

When you sign in to the Omni-channel Engagement Hub app, the agent interface has the following components:

1. Session panel

2. Communication panel (Collapsed mode)

3. Application tab

4. Omni-channel Agent Dashboard

5. Navigation bar buttons

## 1. Session panel

The vertical panel on the left side is the session panel that allows you (the agent) to work on multiple customer sessions simultaneously. In addition, as an agent you can switch between sessions without losing context of the conversation and customer details. The ability to handle multiple sessions simultaneously (while preserving customer context) allows you to resolve issues faster and achieve higher productivity.

### Start and close a session

As an agent, you can press **CTRL** + **Shift** and select on a link that can open as a session. The entities' link that you can open as a session are:
   - Case
   - Account
   - Contact

You can't use the shortcut to open any other links.

You can start a session by accepting the incoming conversation or by selecting the work items from **Omni-channel Agent Dashboard**. After the session starts, the customer summary page is loaded in the form area.

You can close any session manually by selecting the **X** button next to the session title.

### Mode of Session panel

By default, the session panel is in expanded mode and it is collapsible based on your requirement. The **Home** session is default and you can't close it. The Home session shows the default **Omni-channel Agent Dashboard**.

### Title and icon of the session

By default, the title of session is name of the entity. That is, the title can be of case, account, or contact name. When you get an unauthenticated incoming conversation request, you can search and link the record in the customer or issue snapshot forms. After linking, the session title is automatically updated.

By default, the first two letters of the session title is displayed as the session icon.

 > [!div class=mx-imgBorder]
 > ![Session panel in the agent interface of Omni-channel Engagement Hub app](../../media/oceh/oceh-agent-interface-session-panel.png "Session panel in Omni-channel Engagement Hub app")

## 2. Communication panel

The communication panel is where you, as an agent, interact with your customer. When you sign in to the application, by default, the communication panel is in minimized mode. That is, the minimized communication panel appears at the bottom left side. The landing page explains some of the key features of Omni-channel Engagement Hub and the communication panel. To learn more, see [View communication panel](oceh-conversation-control.md).

 > [!div class=mx-imgBorder]
 > ![Communication panel in the collapsed mode](../../media/oceh/oceh-agent-interface-communication-panel-collapsed.png "Communication panel in the collapsed mode")

To expand the communication panel, select the arrow on the gray bar of the communication panel. Select the same arrow to again minimize the communication panel.

 > [!div class=mx-imgBorder]
 > ![Communication panel in the expanded mode](../../media/oceh/oceh-agent-interface-communication-panel-expanded.png "Communication panel in the expanded mode")

## 3. Application tab

The horizontal bar below the Dynamics 365 navigation bar is called the application tab. Every customer session has at least one that is not closable; it is called the Anchor tab. The Application tab has a **+** icon. If you select the icon, the sitemap is available as a context menu. The sitemap shows the out-of-box and custom entities. You press **Ctrl** and select any link to open it in the application tab.

> [!div class=mx-imgBorder]
> ![Omni-channel Engagement Hub sitemap appears when you select + icon in the application tab](../../media/oceh/oceh-agent-interface-sitemap.png "Omni-channel Engagement Hub sitemap in the application tab")

The sitemap displays the following record types:

- **Dashboards**

  When you sign in to the application, you see a dashboard that gives you easy-to-read information about the tasks you are working on. Several dashboards are tailored for your role. To see the other dashboards, select the drop-down list next to **Omni-channel Agent Dashboard**. Also, you can see any dashboard as your default view using the **Set As Default** option in the command bar. By default, you see **Omni-channel Agent Dashboard**, which displays information about the tasks that you work on. As an agent, when you sign in to the application, the dashboard displays the following streams:

    - My work items
    - Open work items
    - Closed work items

- **Activities**

  Activities help you keep track of all your customer communications using the **Conversation** and **Session** form types. Activities are the details of the interactions between the customer and you, such as the history of the conversation, a transcript of the conversation, session details, and more.

- **Accounts**

  Account records are used to store the information that you collect from the customer with whom you interact. That is, you store the details about the companies in the accounts. An account might have more than one contact associated with it.

- **Contacts**

  Contact records help you manage and store information about the customers you work with. Usually, multiple contacts work in the same organization, and as a result, you can associate these contacts with the account (organization).

- **Social Profiles**

  Social profiles are the profiles of the customer on social media. You use the social profiles to interact with the customer on social media and track all the conversations in Common Data Service.

- **Cases**

  Cases (tickets or incidents) are the requests, inquiries, issues, feedback, complaints, and so on about the product or service that your customers need assistance with to resolve. The cases will be routed to the queues to which you are added as an agent. You link the cases to the conversation and the details appear in the **Customer summary** form.

- **Queues**

  Queues are the route where the cases are assigned to you. Your organization creates queues and agents based on the business requirement. This ensures that you get conversations (work items) from the queues to which you are added as a member (agent). You can view and work on the conversations only to the queues you are assigned as a member (agent).

- **Knowledge articles**

  Knowledge articles are articles about the questions, issues, feedback, resolutions, best practices, and guidelines that are helpful. You can share the articles with the customers and help them to resolve the cases.

## 4. Omni-channel Agent Dashboard

   When you sign in to Omni-channel Engagement Hub, as an agent, you see the Omni-channel Agent Dashboard that shows the different work items in streams. The dashboard is present in the application tab of the **Home** session and you can't close the dashboard tab.

   > [!div class=mx-imgBorder]
   > ![Omni-channel Agent Dashboard shows My work items, Open work items, and closed work items](../../media/oceh/oceh-agent-interface-oceh-dashboard.png "Omni-channel Agent Dashboard")

  - **My work items**

    In this stream, you see the conversations (work items) that you are actively working on. Select the ellipses and select the **Open** option to open the work item in a session.

 - **Open work items**

   In this stream, you see the conversations (work items) in a waiting state from all queues that are available for you to pick. You can see the conversations (work item) for the work streams where you are added as a member. Select the ellipses and select the **Pick** option to assign the work item to yourself. When you select **Pick**, the system moves the work item from the **Open work items** stream to the **My work items** stream, and you can see the message **Work item picked successfully. Work item: < subject of work item >**. Your presence status is updated and the capacity is automatically blocked.

 - **Closed work items**

   In the **Closed work items** stream, the stream refreshes and shows you all the conversations that you've closed in the past 24 hours. To view a closed work item, select the ellipsis button (**...**) for it, and then select **Open** to view the details.

## 5. Navigation bar buttons

   The navigation bar buttons of Omni-channel Engagement Hub in the Omni-channel Engagement Hub app contains the following:

   ![Navigation bar buttons of Omni-channel Engagement Hub](../../media/oceh-navigation-bar-buttons.png "Navigation bar buttons of Omni-channel Engagement Hub")

   a. **Search.** Do a simple search for records.
    
   b. **Task flow.** Create an automated task flow between your apps and services.
    
   c. **Relationship assistant.**
    
   d. **Quick create.** Add a new record.
    
   e. **Advanced find.** Do an advanced search using filters, sorting, and criteria.
    
   f. **Settings.** Set personal options.
    
   g. **Presence.** Set presence as per your availability. Select the icon to launch the presence dialog and use the drop-down list to select a status.
    
   h. **Help.** Get the help documentation.
    
   i. **User.** See user information.

 ### Search
    
  The search option lets you search records and open a record in a new active session. You can search for the following records using the search option:
    
   - Case
   - Contact
   - Account
    
 ### Create
    
   The quick-create option provides the list of related records (entities) that you can create. The following are the record types that you can create: 
    
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
    
   ![Quick-create option in Omni-channel Engagement Hub](../../media/oceh-quick-create.png) ![Quick-create option for activities in Omni-channel Engagement Hub](../../media/oceh-quick-create-activities.png)
    
   When you select any record, the application displays a new quick create form. For example, select the **Account** record from the list. The application displays the **Quick Create: Account** form. Specify the details in the fields and save the form.

> [!div class="mx-imgBorder"]
> ![Quick create account form](../../media/oceh/oceh-quick-create-forms-account.png "Quick create account form")

> [!div class="nextstepaction"]
> [Next topic: Understand conversation states](oceh-conversation-state.md)

## See also

- [Sign in to Omni-channel Engagement Hub](oceh-sign-dynamics-365-customer-service-hub.md)
- [View communication panel](oceh-conversation-control.md)
