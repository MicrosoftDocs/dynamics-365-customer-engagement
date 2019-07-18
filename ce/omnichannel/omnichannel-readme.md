---
title: "Known issues and limitations   | MicrosoftDocs"
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

1. Sign in to Dynamics 365 for Customer Engagement apps.

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

1. Sign in to Omnichannel for Customer Engagement apps.
2. Select the **Omnichannel Administration** app.
3. Select **Quick Replies** in the site map.
4. Select the messages that are repeated several times from the **Active Quick Replies** view.
5. Select **Delete**. A confirmation dialog appears asking you to confirm.
6. Select **Delete** to delete the records.

    > [!div class=mx-imgBorder]
    > ![Delete repeated messages](media/oceh/delete-quick-replies.png "Delete repeated messages")

7. Select **Save** to save the changes.

> [!Note]
> The changes you make might take up to 15 mins to reflect in the system. 

Now, sign in to Omnichannel for Customer Service app and verify if the messages are repeated in the quick replies menu.

## Customer Summary page shows default icons

If your organization is using earlier releases of chat for Dynamics 365, and after you upgrade to the latest version, the Customer summary page shows the default icon instead of the conversation icon instead of the conversation icon.

## CDS entity routing is not available in Omnichannel for Customer Service

The CDS entity routing is disabled in the latest version of Omnichannel for Customer Service. You can't route CDS entities using omnichannel routing and work-distribution.

Hence, after your upgrade:

- You can't create any new CDS entity work stream. 
- You might see existing CDS entity work stream configuration records, but these configurations are disabled and don't have any run-time impact.

## Omnichannel queue records are not available after upgrade

After you upgrade to the latest version of Omnichannel for Customer Service, your existing queue records will not be available. This is due to removal of omnichannel queue entity. The Common Data Service (CDS) queue entity will be used for omnichannel routing and work distribution.

After you upgrade, you will experience the following:

- All your existing omnichannel queue configurations will be removed. 
- All your existing active conversations will be closed and moved to CDS Transactional database.

### Workaround

You must manually configure the queues again.

To configure the queues, perform the following steps.

> [!Note]
> - If you haven't upgraded your organization to the latest version, take a note of your existing omnichannel queue record configurations before the upgrade.  
>
> - If you've already upgraded your organization to the latest version, then you can still access previous omnichannel queue records from a URL by replacing `etn=queue` with `etn=msdyn_omnichannelqueue` from queue grid page. <br>
    For example, the URL is `https://<ORG_URL>/main.aspx?appid=<APP_ID>&pagetype=entitylistetn=queue`, now replace `etn=queue` with `etn=msdyn_omnichannelqueue` in the URL. <br><br>
    `https://<ORG_URL>/main.aspx?appid=<APP_ID>&pagetype=entitylist&etn=msdyn_omnichannelqueue`.

Step 1. Create a queue. Select **Queues** and select **New** to create a new queue. Specify a value for the fields, and then select **Save**. To learn more, see [Create a new queue](administrator/queues-omnichannel.md#create-a-new-queue).

Step 2. Add users to queues. Select **Add Existing User** to add agents to the queue in the **Users (Agents)** section of the queue form. To learn more, see [Create a new queue](administrator/queues-omnichannel.md#create-a-new-queue).

Step 3: Update the routing rules. After you upgrade, the old queue records will be removed from the **Queue** field in routing rules.  Update the **Queue** field with the newly created CDS queue records. To learn more, see: [Create a routing rule](administrator/routing-rules.md#create-a-routing-rule)

   > [!Note]
   > - Repeat steps 1 to 3 for all your existing queue configurations.
   >
   > - Default queue is created automatically, and you need not reconfigure it manually.
   >
   > - After you save the configurations, it may take up to 15 mins to reflect.

Step 4: Ask supervisors to update the dashboard filters. After the upgrade, the existing queue filters on the dashboards will be removed. A a supervisors, you should reconfigure and validate your dashboard filters.

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

## Support for thrid-party channel providers with Omnichannel for Customer Service

If your organization has deployed a third-party channel provider using the Dynamics 365 Channel Integration Framework, and then you want to use Omnichannel for Customer Service in the same organization, this will result in the upgrade of the Channel Integration Framework solution.

You can continue to use the third-party channel provider in the unified interface apps such as Customer Service Hub, Sales Hub and so on. However, you can't use the third-party channel provider in the Omnichannel for Customer Service app. That is, you should not add the **Omnichannel for Customer Service** app while configuring the app list for in the channel provider.
 
## Support for automatic record linking to conversation 
While working on a session, after an agent creates a customer (contact/account) or case record using the quick create (+) option in the nav bar, it is not auto-linked to the conversation. As a workaround, the agent can perform an inline search for the newly created record and link it to the conversation.

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
