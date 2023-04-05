---
title: "Overview of the Customer Service workspace application for Dynamics 365 Customer Service | MicrosoftDocs"
description: "Overview of the Customer Service workspace application for Dynamics 365 Customer Service."
ms.date: 04/05/2023
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

The Dynamics 365 Customer Service workspace app helps increase agent productivity with a browser-like tabbed experience that lets agents work on multiple cases and conversations using the same app. It's a modern, customizable, high-productivity application that allows agents to work on multiple sessions at a time in a single workspace. 

The application uses artificial intelligence in productivity tools like Smart Assist to identify similar cases and relevant articles, thereby boosting agent productivity. Features such as agent scripts and macros provide agents guidance and resources to automate repetitive tasks to achieve a great customer experience.

For more information about licensing and system requirements, see [Customer Service workspace system requirements](customer-service-workspace-system-requirements.md)

**Set up Omnichannel in Customer Service workspace** 

You can set up your Customer Service workspace environment so that agents working on cases can also engage with customers via channels like Live Chat, voice, and SMS without leaving the app, by using the  Dynamics 365 Customer Service Digital Messaging add-on. More information: [Set up Omnichannel for Customer Service channels in Customer Service workspace](/dynamics365/app-profile-manager/csw-enable-channels)


:::image type="content" source="media/csw-default-overview.png" alt-text="Screenshot of the enhanced multisession Customer Service workspace"::: 


## Customer Service workspace sessions and tabs

Customer Service workspace allows agents to work on multiple sessions at a time in a single app while keeping the work organized.
Agents can work on up to nine sessions and within a session, they can open up to ten tabs. A new session is launched, when an agent opens a case from the **Home** session or the agent accepts an incoming conversation. If the agent opens the customer record from a session, a new tab opens in the same session. 

### Navigate sessions and tabs

 The following table gives an overview of the multisession navigation:

| Action | Result |
| ------------ |------------- |
| Open a record from the Home session | Record opens in a new session. |
| Open a record from the Global search | Record opens in a new session. |
| Open a record from the retrieved search records | Record opens in a focussed session. |
| Open a record using the Quick Create notification | Record opens in a new session |
| Create a new record | Record opens in a new session |
| Open a record from the timeline | Record opens in a new tab in the focused session |
| Open a record from a form lookup | Record opens in a new tab in the focused session |
| Open a view from the Sitemap | View opens in a new tab in the focused session |
| Open a dashboard from the Sitemap | Dashboard opens in a new tab in the focused session|


### Use the Inbox

If your administrator has turned on the inbox for your profile, you can select the **Inbox** tab to view all the cases, conversations, and activities that are assigned to you. Use the inbox to work on high-velocity tasks. You can also promote inbox sessions to regular sessions when you need more time to resolve a case or complete a conversation.

The asynchronous channels available in the conversation inbox are: SMS, persistent chat, Facebook, Twitter, WeChat, LINE, WhatsApp, and Microsoft Teams.

More information: [Configure the inbox view](configure-inbox.md)

### Use the productivity pane with Smart Assist

While you're working on a case, the productivity pane on the right side of the Customer Service workspace displays intelligence-driven suggestions to help you. The productivity pane uses Smart Assist to suggest related cases and knowledge articles that could be relevant. You'll also see agent scripts that guide you through a consistent series of steps with potentially automated actions through macros.

More information: [Productivity pane](csw-productivity-pane.md)

### Customize the agent experience with Customer Service admin center

Agent experience profiles enable you to create targeted app experiences for agents and supervisors, and are an alternative to building and maintaining custom apps. With the agent experience profiles, administrators can create custom profiles with specific session templates, conversation channels, and productivity tools. These profiles can then be assigned to users.

More information: [Agent experience profiles](/dynamics365/app-profile-manager/overview)

### View the agent calendar 

View your working, no-working hours, and any scheduled time-off requests on **My schedule**.

More information: [View the agent calendar (preview)](use-agent-calendar.md)

## Considerations

Here are a few things to note when you use Customer Service workspace in your organization:

-We recommend that you have only one browser instance accessing the app.
-  The results of navigation actions when you use the app or the `XRM.Navigation.openForm` and `Xrm.Navigation.navigateTo` APIs are the same.
- You can open sessions and tabs using Microsoft.Apm APIs. For more information: [App profile manager JavaScript API Reference](../app-profile-manager/reference/microsoft-apm.md)

### Limitations

The following limitations apply to Customer Service workspace:
- When you switch between tabs or sessions:
     - Sub grid controls don't retain the filter or sort conditions.
     - Web resources, form components, and third-party websites don't retain the state of the page.
- Customer Service workspace isn't supported in mobile devices, Unified Service Desk, and with Dynamics 365 Customer Engagement (on-premises).

## Deprecated Customer Service workspace layout

The legacy layout has been deprecated and will be removed in October 2023.

:::image type="content" source="media/csw-overview.png" alt-text="Screenshot of the default Customer Service workspace, with items labeled according to the legend in the table" lightbox="media/csw-overview.png":::

1. Select the Home icon to return to the Customer Service Agent Dashboard view.
1. The session pane shows all the sessions you've opened. Select the icons to navigate between sessions.
1. Select the + icon in the tab bar to open more workspaces in a new tab. If you hold the Ctrl key while you select a case or an activity, the case or activity opens in a new tab, too. Select a tab to navigate between sessions.
1. Select the arrow to choose a different view.
1. Select a case or an activity to open a new session. The session replaces your current view with the case form.
1. Select the back arrow in the upper-left corner of the form to get back to your previous view. To open the case or activity in a new tab, hold the Ctrl key while you select it.
1. Select the arrow to view a different dashboard.

### Turn on legacy layout (deprecated)
1.	With Customer Service workspace open, press the F12 key to open the developer tools window.
2.	In the console window, enter the following command: `Xrm.Utility.getGlobalContext().saveSettingValue("msdyn_MultiSessionLayoutImprovements",false)`
3.	Refresh the app page.

### Turn off the close session dialog

1. With Customer Service workspace open, press the F12 key to open the developer tools window.
1. In the console window, enter the following command: `Xrm.Utility.getGlobalContext().saveSettingValue("msdyn_SuppressSessionCloseWarning",true)`
1. Refresh the app page.

### Turn on legacy navigation (deprecated)

> [!NOTE]
> The legacy navigation is deprecated and will be removed in a future release.

1. With Customer Service workspace open, press the F12 key to open the developer tools window.
1. In the console window, type the following command and press **Enter**: `Xrm.Utility.getGlobalContext().saveSettingValue("msdyn_MultisessionNavigationImprovements",false)`
1. Refresh the app page.

### See also

[Work with cases in Customer Service Hub](customer-service-hub-user-guide-create-a-case.md)  
[Work with activities in Customer Service Hub](customer-service-hub-user-guide-manage-timeline-activities.md)  
[Overview of the productivity pane](csw-productivity-pane.md)  
[Migrate from Unified Service Desk to Customer Service workspace](../unified-service-desk/admin/migrate-to-csw.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
