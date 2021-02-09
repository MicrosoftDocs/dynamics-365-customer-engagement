---
title: "Manage applications in Omnichannel for Customer Service app | MicrosoftDocs"
description: "Learn how to manage applications using the application tab panel in Omnichannel for Customer Service app."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 08/03/2020
ms.topic: article
ms.service: dynamics-365-customerservice
---

# Manage applications in Omnichannel for Customer Service

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

The horizontal bar below the navigation bar is called the application tab panel. Every customer session has at least one application that is not closable; it is called an **anchor** tab. In the following image, **Omnichannel Agent Dashboard** is the anchor tab.

The application tab has a **+** icon. If you select the icon, a menu  appears that lists the out-of-the-box and custom entities. Also, you can access any third-party line-of-business applications that are extended within the Omnichannel for Customer Service app. Select the option from the list to open it in the application tab.

> [!div class=mx-imgBorder]
> ![Omnichannel for Customer Service sitemap appears when you select **+** in the application tab](media/oceh-agent-interface-sitemap.png "Omnichannel for Customer Service sitemap in the application tab")

## Open an application

You can open an application in the application tab panel in the following ways:

- Use the application tab menu.
- Use the **Ctrl + click** gesture.

### Use the application tab menu

On the application tab panel, select **+** to view the menu that has a list of out-of-the-box and custom entities. Selecting an option from the menu opens the application in the application tab panel. The application opens in the current active session.

> [!div class=mx-imgBorder]
> ![App tab menu](media/oceh-app-tab-select-icon.png "App tab menu")

### Use gesture (Ctrl + click) to open an application

Use a combination of keyboard and mouse-click gesture to start an application. You can press **Ctrl** and select a link to open it in a new application tab. The application opens in the current active session.

## Work with applications

Every session has an application tab that is called the Anchor tab. A session can have a maximum of one Anchor tab and there is no close option on the application tab. When you are working on an Omnichannel conversation request, the customer summary page is the default anchor tab.

When you switch sessions or between applications in the current session, your unsaved changes are not lost and you can continue to work on them.

For example, you are working on a case by entering the title of the case. Before saving the form, you open an account record in a new application tab. Now, the application focus changes to the account record. However, the unsaved changes are preserved for you to continue working on the form.

You can close an application tab manually by selecting the close icon on the application tab. After closing the application tab, the focus moves to the next available application tab on the left.

You can switch between applications by selecting the application tab title.

### Title of the application tab

The title of the application tab is the name of the entity. For example, dashboard names, case, contact, account names, and so on. For third-party applications, the name appears as configured by your administrator.

> [!div class=mx-imgBorder]
> ![App tab title](media/oceh-app-tab-title.png "App tab title")

### See also

[Create personal quick replies](create-personal-quick-replies.md)  
[View agent dashboard and conversations (work items)](oc-agent-dashboard.md)  
[Manage sessions](oc-manage-sessions.md)  
[Understand conversation states](oc-conversation-state.md)  
[View communication panel](oc-conversation-control.md)  
