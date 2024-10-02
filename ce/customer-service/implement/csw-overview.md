---
title: Overview of the Customer Service workspace application for Dynamics 365 Customer Service
description: Overview of the Customer Service workspace application for Dynamics 365 Customer Service.
ms.date: 10/02/2024
ms.topic: overview
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - admin
  - customizer
  - enduser
ms.custom: 
  - dyn365-customerservice
ms.collection: get-started
---

# Get started with Customer Service workspace

Dynamics 365 Customer Service workspace helps agents increase productivity with a browser-like, tabbed experience. Agents can use the app to work on multiple cases and conversations. It's a modern, customizable, high-productivity application that allows agents to work on multiple sessions at a time in a single workspace.

The application uses artificial intelligence in productivity tools like Smart Assist to identify similar cases and relevant articles, thereby boosting agent productivity. Features such as agent scripts and macros provide agents with guidance and resources to automate repetitive tasks to achieve a great customer experience.

For more information about licensing and system requirements, refer to [Customer Service workspace system requirements](customer-service-workspace-system-requirements.md).

**Set up Omnichannel in Customer Service workspace** 

With the Dynamics 365 Customer Service Digital Messaging add-on, the agent who work on cases can also engage with customers via channels like Live Chat, voice, and SMS without leaving the Customer Service workspace app. More information: [Set up Omnichannel for Customer Service channels in Customer Service workspace](/dynamics365/app-profile-manager/csw-enable-channels)

:::image type="content" source="../media/csw-default-overview.png" alt-text="Screenshot of the enhanced multisession Customer Service workspace":::

## Customer Service workspace sessions and tabs

Customer Service workspace allows agents to work on multiple sessions at a time in a single app while keeping the work organized.
- Agents can work on up to nine sessions and within a session, they can open up to 10 tabs.
-  A new session starts when an agent opens a case from the **Home** session or accepts an incoming conversation.
-  If the agent opens the customer record from a session, a new tab opens in the same session. 
- Agents can select the hamburger icon to access the site map. 
- When an agent opens a page from the site map, the page loads in the current focused session.

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

### Session restore (preview)

If your administrator has turned on session restore, key entities in Customer Service workspace reload automatically if your browser refreshes. Without session restore, when a browser refreshes or reconnects, Customer Service workspace only reloads the home page. 

Session restore automatically restores cases, accounts, and their associated application tabs without requiring you to manually reopen them. Focus is restored to the last session or application tab in view. After the presence is loaded, conversations, including calls and chats, are reinstated. 

For more information, refer to [Enable session restore to automatically reopen sessions and tabs (preview)](../administer/enable-session-restore.md).


### Use the Inbox

If your administrator has turned on the inbox for your profile, you can select the **Inbox** tab to view all the cases, conversations, and activities that are assigned to you. Use the inbox to work on high-velocity tasks. You can also promote inbox sessions to regular sessions when you need more time to resolve a case or complete a conversation.

The asynchronous channels available in the conversation inbox are: 
- SMS
- persistent chat
- Facebook
- WeChat
- LINE
- WhatsApp
- Microsoft Teams

For more information, refer to [Configure the inbox view](../administer/configure-inbox.md).

### Use the productivity pane with Smart Assist

When you work on a case, the productivity pane on the right side of the Customer Service workspace displays intelligence-driven suggestions to help you. The productivity pane uses Smart Assist to suggest related cases and knowledge articles that might be relevant to the case you're working on. There are also customer service representative scripts that guide you through a consistent series of steps with potentially automated actions through macros.

For more information, refer to [Productivity pane](../use/../use/csw-productivity-pane.md).

## Work with cases, activities, knowledge articles, and email templates

On the Customer Service Agent Dashboard, here are some of the actions you can do:

- View cases and activities assigned to you
- View cases available to work on
- Create, delete, and filter cases and activities from the workspace

### Customize the agent experience with Customer Service admin center

Agent experience profiles enable you to create targeted app experiences for agents and supervisors, and are an alternative to building and maintaining custom apps. With the agent experience profiles, administrators can create custom profiles with specific session templates, conversation channels, and productivity tools. These profiles can then be assigned to users.

For more information, refer to [Agent experience profiles](../administer/overview.md).

## Considerations

Here are a few things to note when you use Customer Service workspace in your organization:

- We recommend that you have only one browser instance accessing the app.
- `XRM.Navigation.openForm` and `Xrm.Navigation.navigateTo` APIs have a similar navigation as the multisession app. For example:
  - A new session is initiated if you open a form through `XRM.Navigation.openForm` from Home.
  - A new tab in the focused session is initiated if you open a form through `XRM.Navigation.openForm` from a case session.
- Opening a WebResource through `Xrm.Navigation.openWebResource` opens a new browser window but doesn't remove the navigation and command bars. You can programmatically open web resources as session tabs using the `Microsoft.Apm.createTab` method. More information: [createTab method](../develop/reference/methods/createTab.md)
- You can open sessions and tabs using Microsoft.Apm APIs. More information: [App profile manager JavaScript API Reference](../develop/microsoft-apm.md) 
- The multisession capabilities are supported in the Customer Service workspace and Omnichannel for Customer Service apps only. You won't be able to navigate across multiple sessions in a custom app or a copy of the Customer Service workspace app in your environment.

### Limitations

The following limitations apply to Customer Service workspace:
- When you switch between tabs or sessions:
  - Subgrid controls don't retain the filter or sort conditions.
  - Web resources, form components, custom pages, and third-party websites don't retain the state of the page.
  - When changing the status record in a tab, the corresponding record open in a grid or subgrid of another tab doesn't refresh automatically.
- Customer Service workspace isn't supported in mobile devices, Unified Service Desk, Microsoft Teams, and with Dynamics 365 Customer Engagement (on-premises).

## Deprecated Customer Service workspace layout

The legacy layout is deprecated and was removed in October 2023.

:::image type="content" source="../media/csw-overview-mini.png" alt-text="Screenshot of the default Customer Service workspace, with items labeled according to the legend in the table" lightbox="../media/csw-overview.png":::

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

### Training resources

Download the [Customer Service workspace in a day training](https://go.microsoft.com/fwlink/?linkid=2241180). This training provides an overview of the following topics:

  * Get familiar with sessions, tabs, and productivity tools.
  * How to create agent experience profiles, templates, agent scripts and macros.
  * How to assign agent experience profile based on security roles.
  * How to move agent experience profiles via solutions.
  * How to use multisession APIs (Microsoft.Apm).

[Migrate from Unified Service Desk to Customer Service workspace](../../unified-service-desk/admin/migrate-to-csw.md). The Unified Service Desk to Customer Service workspace Migration Playbook helps you plan and execute the transition from Unified Service Desk to Customer Service workspace.

### Related information

[Work with cases in Customer Service Hub](../use/customer-service-hub-user-guide-create-a-case.md)  
[Overview of the productivity pane](../use/csw-productivity-pane.md)  
[View the agent calendar](../use/use-agent-calendar.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
