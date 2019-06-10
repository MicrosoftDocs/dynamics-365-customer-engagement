---
title: "Known issues and limitations   | MicrosoftDocs"
description: "Learn about the known issues and limitations in Omni-channel Engagement Hub."
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 05/03/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: BC3D3C77-982D-4F8F-B9DB-86854A1634F8
ms.custom: 
---

# Omni-channel Engagement Hub - Preview readme (known issues and limitations)

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0

[!include[cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

The topic explains the known issues and limitations of Omni-channel Engagement Hub.

> [!Important]
> We recommend updating Omni-channel Engagement Hub to the latest versions for the best experience. More information: [Upgrade Omni-channel Engagement Hub](administrator/upgrade-omni-channel.md)

## Dashboards don't appear in Omni-channel Engagement Hub active dashboards view

When you use the Omni-channel Engagement Hub app on Unified Service Desk or on web, the **Active Omnichannel Agent Dashboard** view doesn't show certain dashboards like Tier 1 Dashboard, Tier 2 Dashboard, Knowledge Manager, and My Knowledge Dashboard.

### Workaround

As a system customizer or administrator, you must manually add these dashboards using app designer.

To work around the issue, follow these steps:

1. Go to `https://<orgURL>.dynamics.com/apps`.
2. Select the ellipsis (**...**) button in the **Omni-channel Engagement Hub - Preview** app tile. <br>
    ![Sign in to Omni-channel Engagement Hub](media/oceh-sign-in.png "Sign in to Omni-channel Engagement Hub")
3. Select **OPEN IN APP DESIGNER**. The App Designer opens in a new tab.
4. Select **Dashboards** in the canvas area. The **Components** pane in the right side shows the list of **Classic Dashboards** and **Interactive Dashboards**.
5. Select the following dashboards under **Interactive Dashboards**.<br>
    - Knowledge Manager
    - My Knowledge Dashboard
    - Tier 1 Dashboard
    - Tier 2 Dashboard <br>
    ![Add dashboards in the app designer canvas area](media/oceh-app-designer-add-dashboard.png "Add dashboards")
6. Select **Save** and then select **Publish**.

## Upgrade doesn’t start if the organization name is changed

If you change the organization name, the upgrade process doesn’t start, and an internal server error is displayed. To begin the upgrade, rename the organization to its original name.

## Conversation does not open as session or as a form 
When you use Omni-channel Engagement Hub with Unified Service Desk and use **IE Process** to host web applications, a conversation (work item) from the Omni-channel agent dashboard doesn't open as a session or as a form in the application management toolbar.

### Workaround

To work around the issue, follow these steps:

1. Go to `https://<orgURL>.dynamics.com/apps` and select the **Unified Service Desk Administrator** app.
2. In the sitemap, under **Basic Settings**, select **Action Calls**.
3. Select **+ New**.
4. In the **New Action Call** page, enter the details and then select **Save**.

   | Field | Value |
   |-------|-------|
   | Name  |Open Conversation from Omni-channel Agent Dashboard |
   | Hosted Control | Agent Home Page |
   | Action | RunScript |
   | Data | if(navigator.userAgent.search("Trident") >= 0)<br> {<br> window.top.notifyUSD = function(data)<br>{<br>window.open(data);<br>}<br>} |
5. In the sitemap, under **Basic Settings**, select **Events**, and select **PageLoadComplete** from the list of events.
6. In the **PageLoadComplete** page, select **Add Existing Action Call**. The **Lookup Records** pane appears on the left.
7. In the **Lookup Records** pane, enter the name of the action call you want to add. In this case, enter **Open Conversation from Omni-channel Agent Dashboard** in the search box and select the search icon. The action call appears.
8. Select the **Open Conversation from Omni-channel Agent Dashboard** action call and select **Add**, and then select **Save** to save the event.

Now, if you open the conversation (work item) from the Omni-channel agent dashboard, the conversation opens as a session or as a form in the application management toolbar.

## Agents receive delayed notification when the chat ends
A customer ends the chat by selecting the Close (**X**) button on the chat widget. After the customer closes the chat, there's a delay before the agent receives the notification of the customer ending the conversation.

## Support for emojis
Emojis are not supported for the customer chat widget.

## Context variable support for duplicate and delete dependency check

While creating a context variable, the system does not perform duplicate detection in the work stream. Also, while deleting a context variable, the system does not perform a check for dependency.

## Available presence configuration

Default work streams shipped out of the box for all channels do not have allowable presence preconfigured. Administrators should configure available presence manually.

## Screen pop decline or time out 
When an agent declines the screen pop or when the screen pop times out, the work distribution mechanism puts a 2-minute pause on the agent’s clock and doesn’t allocate any new conversations to the agent for that time period.

## Queue configuration 
When you add a user to a queue, the sub grid doesn’t reflect the new member automatically. You are required to refresh the sub grid by selecting the **Refresh** button to see the new user in the list of queue members.

## Support for multiple channel providers
If your organization has deployed a third-party channel provider using the Dynamics 365 Channel Integration Framework, and then you want to use Omni-channel Engagement Hub in the same organization, the Omni-channel solution overrides the Channel Integration Framework solution because there is no support for multiple channel providers.
 
## Support for knowledge articles when using Edge Process in Unified Service Desk
When you use Edge Process in Unified Service Desk, agents cannot open knowledge articles from the Knowledge Base Search control.  
 
## Support for automatic record linking to conversation 
After an agent creates a customer (contact/account) or case record using the quick create (+) option when in a session, it is not auto-linked to the conversation. As a workaround, the agent can search for the newly created record using omni-channel search and link it to the conversation manually.

## Authentication error for different agent credentials
If an agent is signed in to Office 365 or Dynamics 365 through a different username in the browser (Internet Explorer or Edge) than the one used for USD sign-in, an authentication error is shown and the user is not allowed to sign in. As a workaround, the user should sign out from all other accounts on the browser and try signing back in.

## Transfer to queue does not show a message for the initiating agent 
When an agent initiates a transfer, the initiating agent becomes a consulting agent without any user interface message. However, the session tab name shows the **Consult** tag because the initiating agent is added to the same conversation as a consulting agent to enable smooth transition.

## Support for Notes when customer is not linked to a conversation
You as an agent, cannot launch and capture notes for a session where customer is not linked to the conversation. As a workaround, link the conversation to a customer (contact) and then try launching the notes control for capturing the notes.

## Wait time count down in notification
When you receive notification, the wait time in the notification doesn't show the time lapse. However, the notification will timeout after the default wait time period. The default wait time is 120 seconds.

## Queue support for notifications
The agents are shown one notification at a time. If a new notification arrives before the agents either accepts or rejects the conversation (work item), the incoming conversation will not be assigned to the agent.
