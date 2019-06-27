---
title: "Known issues and limitations   | MicrosoftDocs"
description: "Learn about the known issues and limitations in Omnichannel for Customer Service."
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 07/01/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: BC3D3C77-982D-4F8F-B9DB-86854A1634F8
ms.custom: 
---

# Omnichannel for Customer Service readme (known issues and limitations)

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0

The topic explains the known issues and limitations of Omnichannel for Customer Service.

> [!Important]
> We recommend updating Omnichannel for Customer Service to the latest versions for the best experience. More information: [Upgrade Omnichannel for Customer Service](administrator/upgrade-omnichannel.md)

## Customer Summary page shows default icons

If your organization is using earlier releases of chat for Dynamics 365, and after you upgrade to the latest version, the Customer summary page shows the default icon instead of the conversation icon.

## CSD entity routing conversations aren’t routed

Omnichannel routing service doesn't route the entity routing conversations as the Common Data Service entity routing is disabled.

After you upgrade: 
- You can't use any existing CDS entity channel and work stream configurations.  
- You can't create any new CDS entity work stream. 
- You can access existing CDS entity work stream configuration records, but the configurations are removed. 
- You can't route CDS entities using omnichannel routing and work-distribution.

## Existing queues don't appear in the Omnichannel queues/Dashboards view

After you upgrade, your existing queues don't appear in the Omnichannel queues/Dashboards view. The issue is due to removal of omnichannel specific queue entity, which is replaced with the Common Data Service (CDS) queue entity. The CDS queue entity will be used for omnichannel routing and work distribution.

After you upgrade, you will experience the following:

- All your existing omnichannel queue configurations is disabled. 
- All existing active conversations will be closed and moved to CDS Transactional database.

### Workaround

You must manually configure the queues again as mentioned in the below steps. 

> [!Note]
> - If you haven't upgraded your organization to the latest version, take a note of your existing omnichannel queue record configurations before the upgrade.  
>
> - If you've already upgraded your organization to the latest version, then you can still access previous omnichannel queue records from a URL by replacing `etn=queue` with `etn=msdyn_omnichannelqueue` from queue grid page. <br>
    For example, the URL is `https://<ORG_URL>/main.aspx?appid=<APP_ID>&pagetype=entitylistetn=queue`, now replace `etn=queue` with `etn=msdyn_omnichannelqueue` in the URL. <br><br>
    `https://<ORG_URL>/main.aspx?appid=<APP_ID>&pagetype=entitylist&etn=msdyn_omnichannelqueue`.

1. Select **Queues** and select **New** to create a new queue. Specify a value for the fields, and then select **Save** the queue.
2. Select **Add Existing User** to add agents to the queue in the **Users (Agents)** section of the queue form.
3. Repeat steps 3 to 5 to configure other configurations. To learn more, see [Create a new queue](administrator/queues-omnichannel.md#create-a-new-queue). After you upgrade, the old queue records will be removed from the **Queue** field in routing rules. 
4. Update the **Queue** field with the newly created CDS queue records. To learn more, see: [Create a routing rule](administrator/routing-rules.md#create-a-routing-rule)

    > [!Note]
    > - Default queue is created automatically, and you need not reconfigure it manually.
    >
    > - After you save the configurations, it may take up to 15 mins to reflect.

### Validate

As a supervisors, you must setup and validate the dashboard filters. 
- The issue impacts the existing queue filters on the dashboards as it is removed after the upgrade. 
- Supervisors need to setup the filters again on new queue records.

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

If your organization has deployed a third-party channel provider using the Dynamics 365 Channel Integration Framework, and then you want to use Omnichannel for Customer Service in the same organization, this will result in the upgrade of the Channel Integration Framework solution.

You can continue to use the third-party channel provider in the unified interface apps such as Customer Service Hub, Sales Hub and so on. However, you can't use the third-party channel provider in the Omnichannel for Customer Service app. That is, you should not add the **Omnichannel for Customer Service** app while configuring the app list for in the channel provider.
 
## Support for knowledge articles when using Edge Process in Unified Service Desk
When you use Edge Process in Unified Service Desk, agents cannot open knowledge articles from the Knowledge Base Search control.  
 
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
