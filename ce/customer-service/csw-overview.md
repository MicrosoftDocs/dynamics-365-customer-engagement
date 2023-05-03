---
title: "Overview of the Customer Service workspace application for Dynamics 365 Customer Service | MicrosoftDocs"
description: "Overview of the Customer Service workspace application for Dynamics 365 Customer Service."
ms.date: 05/03/2023
ms.topic: overview
author: lalexms
ms.author: laalexan
search.audienceType: 
  - admin
  - customizer
  - enduser
ms.custom: 
  - dyn365-customerservice
  - intro-internal
---

# Get started with Customer Service workspace

Dynamics 365 Customer Service workspace helps agents increase productivity with a browser-like, tabbed experience. Agents can use the app to work on multiple cases and conversations. It's a modern, customizable, high-productivity application that allows agents to work on multiple sessions at a time in a single workspace. 

The application uses artificial intelligence in productivity tools like Smart Assist to identify similar cases and relevant articles, thereby boosting agent productivity. Features such as agent scripts and macros provide agents with guidance and resources to automate repetitive tasks to achieve a great customer experience.

For more information about licensing and system requirements, see [Customer Service workspace system requirements](customer-service-workspace-system-requirements.md)

**Set up Omnichannel in Customer Service workspace** 

You can set up your Customer Service workspace environment so that agents who work on cases can also engage with customers via channels like Live Chat, voice, and SMS without leaving the app, by using the  Dynamics 365 Customer Service Digital Messaging add-on. More information: [Set up Omnichannel for Customer Service channels in Customer Service workspace](/dynamics365/app-profile-manager/csw-enable-channels)


:::image type="content" source="media/csw-default-overview.png" alt-text="Screenshot of the enhanced multisession Customer Service workspace"::: 


## Customer Service workspace sessions and tabs

Customer Service workspace allows agents to work on multiple sessions at a time in a single app while keeping the work organized.
Agents can work on up to nine sessions and within a session, they can open up to 10 tabs. A new session is launched when an agent opens a case from the **Home** session or accepts an incoming conversation. If the agent opens the customer record from a session, a new tab opens in the same session. Agents can select the hamburger icon to access the sitemap. When you open a page from the sitemap, it will load in the current focused session.

### Navigate sessions and tabs

 The following table gives an overview of the multisession navigation:

| Action | Result |
| ------------ |------------- |
| Open a record from the Home session | Record opens in a new session. |
| Open a record from the Global search | Record opens in a new session. |
| Open a record from the retrieved search records | Record opens in a focused session. |
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

When you work on a case, the productivity pane on the right side of the Customer Service workspace displays intelligence-driven suggestions to help you. The productivity pane uses Smart Assist to suggest related cases and knowledge articles that could be relevant. You'll also see agent scripts that guide you through a consistent series of steps with potentially automated actions through macros.

More information: [Productivity pane](csw-productivity-pane.md)

## Work with cases, activities, knowledge articles, and email templates

On the Customer Service Agent Dashboard, here are some of the actions you can do:

- View cases and activities assigned to you
- View cases available to work on
- Create, delete, and filter cases and activities from the workspace

### Customize the agent experience with Customer Service admin center

Agent experience profiles enable you to create targeted app experiences for agents and supervisors, and are an alternative to building and maintaining custom apps. With the agent experience profiles, administrators can create custom profiles with specific session templates, conversation channels, and productivity tools. These profiles can then be assigned to users.

More information: [Agent experience profiles](/dynamics365/app-profile-manager/overview)

## Considerations

Here are a few things to note when you use Customer Service workspace in your organization:

- We recommend that you have only one browser instance accessing the app.
- `XRM.Navigation.openForm` and `Xrm.Navigation.navigateTo` APIs will behave the same as the multisession navigation. For example:
    - A new session is initiated if you open a form through `XRM.Navigation.openForm` from Home.
    - A new tab in the focused session is initiated if you open a form through `XRM.Navigation.openForm` from a case session.
- Opening a WebResource through `Xrm.Navigation.openWebResource` will open a new browser window but will not remove the navigation and command bars. You can programmatically open web resources as session tabs using `Microsoft.Apm.createTab` method. More information: [createTab method](../app-profile-manager/reference/microsoft-apm/createTab.md) 
- You can open sessions and tabs using Microsoft.Apm APIs. More information: [App profile manager JavaScript API Reference](../app-profile-manager/reference/microsoft-apm.md)

### Limitations

The following limitations apply to Customer Service workspace:
- When you switch between tabs or sessions:
     - Sub grid controls don't retain the filter or sort conditions.
     - Web resources, form components, and third-party websites don't retain the state of the page.
- Customer Service workspace isn't supported in mobile devices, Unified Service Desk, and with Dynamics 365 Customer Engagement (on-premises).

## Deprecated Customer Service workspace layout

The legacy layout has been deprecated and will be removed in October 2023.

:::image type="content" source="media/csw-overview-mini.png" alt-text="Screenshot of the default Customer Service workspace, with items labeled according to the legend in the table" lightbox="media/csw-overview.png":::


### Turn on legacy layout (deprecated)

You can enable the legacy layout in one of the following ways:

### [Customer Service admin center](#tab/customerserviceadmincenter)

 1. In Customer Service admin center, select **Miscellaneous** in **Operations**.
 1. Select **Manage** for **New and upcoming features**.
 1. Clear the **Multisession Layout improvements** and then select **Save**.


### [Browser developer tools](#tab/broswerdevtools)

 1. With Customer Service workspace open, press the F12 key to open the developer tools window.
 1. In the console window, type the following command and press **Enter**. `Xrm.Utility.getGlobalContext().saveSettingValue("msdyn_MultisessionLayoutImprovements",false)`
 1. Refresh the app page.

---

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
[View the agent calendar](use-agent-calendar.md)  
[Migrate from Unified Service Desk to Customer Service workspace](../unified-service-desk/admin/migrate-to-csw.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
