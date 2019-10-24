---
title: "Known issues and limitations | MicrosoftDocs"
description: "Learn about the known issues and limitations in Omnichannel for Customer Service."
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 07/10/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: BC3D3C77-982D-4F8F-B9DB-86854A1634F8
ms.custom: 
---

# Omnichannel for Customer Service readme (known issues and limitations)

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

The topic explains the known issues and limitations of Omnichannel for Customer Service.

> [!Important]
> We recommend updating Omnichannel for Customer Service to the latest versions for the best experience. More information: [Upgrade Omnichannel for Customer Service](administrator/upgrade-omnichannel.md)


## Closed conversations don't appear in the Closed work items stream and Closed conversations view

After you upgrade Omnichannel for Customer Service to the latest version in the sandbox or trial environment, conversations that agent closes may not appear in the **Closed work items** stream of the agent dashboard and closed conversations view.

### Workaround

As an administrator, you must activate the **SDK Message Processing Steps** associated to Omnichannel solution.

To workaround the issue, follow these steps:

1. Sign in to the Common Data Service platform.

2. Go to **Settings** > **Customizations**.

3. Select **Customize the System**.

4. Select all the Omnichannel associated plugins. See the image to select the Omnichannel associated plugins.

    > [!div class='mx-imgBorder']
    > ![Omnichannel plugins](media/oceh/omnichannel-plugins-1.PNG "Omnichannel plugins")

5. Select **Activate** from the command bar. The **Confirm Sdk Message Processing Step Activation** dialog appears. 

6. Select **Activate** to enable the plugins.

## Messages repeated in the quick replies menu

When you open the quick replies menu in the communication panel (Chat and SMS), you see the messages are repeated multiple times.

### Workaround

To workaround the issue, follow these steps:

1. Sign in to Omnichannel Administration app.
2. Select **Quick Replies** in the site map.
3. Select the messages that are repeated several times from the **Active Quick Replies** view.
4. Select **Delete**. A confirmation dialog appears asking you to confirm.
5. Select **Delete** to delete the records.

    > [!div class=mx-imgBorder]
    > ![Delete repeated messages](media/oceh/delete-quick-replies.png "Delete repeated messages")

6. Select **Save** to save the changes.

> [!Note]
> The changes you make might take up to 15 mins to reflect in the system. 

Now, sign in to Omnichannel for Customer Service app and verify if the messages are repeated in the quick replies menu.

## Customer Summary page shows default icons

If your organization is using earlier releases of chat for Dynamics 365 Customer Service, and after you upgrade to the latest version, the Customer summary page shows the default icon instead of the conversation icon instead of the conversation icon.

## Send Link button in the KB Search Page is not localized 

If you are using Omnichannel for Customer Service app, then the **Send Link** button in the **KB Search Page** control appears in english for other locales and is not localized.

## Upgrade doesn’t start if the organization name is changed

If you change the organization name, the upgrade process doesn’t start, and an internal server error is displayed. To begin the upgrade, rename the organization to its original name.

## Conversation does not open as session or as a form 
When you use Omnichannel for Customer Service with Unified Service Desk and use **IE Process** to host web applications, a conversation (work item) from the Omnichannel agent dashboard doesn't open as a session or as a form in the application management toolbar.

### Workaround

To work around the issue, follow these steps:

1. Go to `https://<orgURL>.dynamics.com/apps` and select the **Unified Service Desk Administrator** app.
2. In the sitemap, under **Basic Settings**, select **Action Calls**.
3. Select **+ New**.
4. In the **New Action Call** page, enter the details and then select **Save**.

   | Field | Value |
   |-------|-------|
   | Name  |Open Conversation from Omnichannel Agent Dashboard |
   | Hosted Control | Agent Home Page |
   | Action | RunScript |
   | Data | if(navigator.userAgent.search("Trident") >= 0)<br> {<br> window.top.notifyUSD = function(data)<br>{<br>window.open(data);<br>}<br>} |
5. In the sitemap, under **Basic Settings**, select **Events**, and select **PageLoadComplete** from the list of events.
6. In the **PageLoadComplete** page, select **Add Existing Action Call**. The **Lookup Records** pane appears on the left.
7. In the **Lookup Records** pane, enter the name of the action call you want to add. In this case, enter **Open Conversation from Omnichannel Agent Dashboard** in the search box and select the search icon. The action call appears.
8. Select the **Open Conversation from Omnichannel Agent Dashboard** action call and select **Add**, and then select **Save** to save the event.

Now, if you open the conversation (work item) from the Omnichannel agent dashboard, the conversation opens as a session or as a form in the application management toolbar.

## Agents receive delayed notification when the chat ends
A customer ends the chat by selecting the Close (**X**) button on the chat widget. After the customer closes the chat, there's a delay before the agent receives the notification of the customer ending the conversation.

## Support for emojis 
Emojis are not supported in the customer chat widget.

## Context variable duplication and delete dependency check

While creating a context variable, the system does not perform duplication detection in the work stream. Also, while deleting a context variable, the system does not perform dependency check.

## Available presence configuration

Default work streams shipped out of the box for all channels do not have allowable presence preconfigured. Administrators should configure available presence manually.

## Refresh queue configuration to reflect the addition of new user
When you add a user to a queue, the sub grid doesn’t reflect the new member automatically. You are required to refresh the sub grid by selecting the **Refresh** button to see the new user in the list of queue members.

## Support for third-party channel providers with Omnichannel for Customer Service

If your organization has deployed a third-party channel provider using the Dynamics 365 Channel Integration Framework, and then you want to use Omnichannel for Customer Service in the same organization, this will result in the upgrade of the Channel Integration Framework solution.

You can continue to use the third-party channel provider in the unified interface apps such as Customer Service Hub, Sales Hub and so on. However, you can't use the third-party channel provider in the Omnichannel for Customer Service app. That is, you should not add the **Omnichannel for Customer Service** app while configuring the app list for in the channel provider.
 
## Support for automatic record linking to conversation 
While working on a session, after an agent creates a customer (contact/account) or case record using the quick create (+) option in the nav bar, it is not auto-linked to the conversation. As a workaround, the agent can perform an inline search for the newly created record and link it to the conversation.

## Authentication error for different agent credentials
If an agent is signed in to Office 365 or Common Data Service through a different username in the browser (Internet Explorer or Edge) than the one used for USD sign-in, an authentication error is shown and the user is not allowed to sign in. As a workaround, the user should sign out from all other accounts on the browser and try signing back in.

## Transfer to queue does not show a message for the initiating agent 
When an agent initiates a transfer, the initiating agent becomes a consulting agent without any user interface message. However, the session tab name shows the **Consult** tag because the initiating agent is added to the same conversation as a consulting agent to enable smooth transition.

## Support for Notes when customer is not linked to a conversation
You as an agent, cannot launch and capture notes for a session where customer is not linked to the conversation. As a workaround, link the conversation to a customer (contact) and then try launching the notes control for capturing the notes.

## Queue support for notifications
The agents are shown one notification at a time. If a new notification arrives before the agents either accepts or rejects the conversation (work item), the incoming conversation will not be assigned to the agent.

## Cases Work Distribution Flow is not saved successfully
The updates you do to the out-of-the-box **Cases Work Distribution Flow** for unified routing of case entity records might fail due to authentication issues.

### Workaround
Authorize Common Data Service native connector in the flow before you save it.

More information: [Update cases work distribution flow](administrator/entity-channel.md#step-4-update-cases-work-distribution-flow)

## Entity records aren't distributed to agents

Entity records routing doesn't route and distribute case records to the agents. 

The case entity record won't be automatically distributed to the agents when the option - **Automatically move records to the owner's default queue when a record is created or assigned** is enabled in the case entity customization page.

### Workaround
You must clear the checkbox to automatically distribute the case records.

> [!div class=mx-imgBorder]
> ![Automatic record movement to the agent's default queue](media/route-owner-queue.png "Automatic record movement to the agent's default queue")

## Sitemap entry for "Entity Records" node is not localised for non-English languages

In Omnichannel Administration application, the sitemap entry under the channels area for "Entity Records" node is not localised for non-English languages. The string appears in English language only for all language organiations

## Routing rules subgrid in entity records errors out intermittently 

You might see the routing rules subgrid under an entity records channel error out intermittenly with this error "You do not have permission to access these records. Contact your administrator for help." The issue is seen very rarely. 

### Workaround
Refresh the page to load the routing rules subgrid without an error, and continue with routing rules configuration



