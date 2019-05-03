---
title: "Manage applications in Omni-channel Engagement Hub app | MicrosoftDocs"
description: "Learn how to manage applications using the application tab panel in Omni-channel Engagement Hub app"
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 05/03/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: FC58E398-050E-4281-B613-FAA378E2E981
ms.custom: 
---

# Manage sessions in Omni-channel Engagement Hub

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0

[!include[cc-beta-prerelease-disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

The horizontal bar below the Dynamics 365 navigation bar is called the application tab panel. Every customer session has at least one application that is not closable; it is called a Anchor tab.

The Application tab has a **+** icon. If you select the icon, a menu  appears that lists the out-of-box and custom entities. Also, you can access any third-party Line-of-Business applications that is extended within Omni-channel Engagement Hub app. Select the option from the list to open it in the application tab.

> [!div class=mx-imgBorder]
> ![Omni-channel Engagement Hub sitemap appears when you select + icon in the application tab](../../media/oceh/oceh-agent-interface-sitemap.png "Omni-channel Engagement Hub sitemap in the application tab")

## Open an application

You can open an application in the application tab panel in the following ways:

- Use the application tab menu
- Use gestures.

### Use the application tab menu

On the application tab panel, select **+** icon to view the menu that has a list of out-of-the-box and custom entities. Selecting an option from the menu opens the application in the application tab panel. The application opens in the current active session.

> [!div class=mx-imgBorder]
> ![App tab menu](../../media/oceh/oceh-app-tab-select-icon.png "App tab menu")

### Use gestures to open an application

Use a combination of keyboard and mouse-click gesture to start an application. You can press **Ctrl** and select on a link to open in a new application tab. The application opens in the current active session.

## Work with applications

Every session has a application tab which is called Anchor tab. A session can have a maximum of one Anchor tab and there will be no close option on the application tab. When you are working on a Omni-channel conversation request, then customer summary page is the default anchor tab.

When you switch sessions or between applications in the current session, unsaved changes are not lost and you can continue to work on them.

For example, you are working on a case by entering the title of the case. Before saving the form, you open an account record in a new application tab. Now, the application focus changes to the account record. However, the unsaved changes is preserved for you to continue working on the form.

You can close an application tab manually by selecting the close icon on the application tab. After closing the application tab, the focus moves to the next available application tab in the left-side.

You can switch between applications by selecting the application tab title.

### Title of the application tab

The title of the application tab will the name of the Customer Engagement entity. For example, dashboard names, Case, Contact, Account names and so on. Third-party applications, the name appears as configured by your administrator.

> [!div class=mx-imgBorder]
> ![App tab title](../../media/oceh/oceh-app-tab-title.png "App tab title")


> [!div class="nextstepaction"]
> [Next topic: View agent dashboard and work items](oceh-omni-channel-agent-dashboard.md)

## See also

- [Manage sessions](oceh-manage-sessions.md)
- [Understand conversation states](oceh-conversation-state.md)
- [View communication panel](oceh-conversation-control.md)
