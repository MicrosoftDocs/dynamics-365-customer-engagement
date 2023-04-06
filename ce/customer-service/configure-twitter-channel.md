---
title: "Configure a Twitter Direct Message channel | MicrosoftDocs"
description: "Use this topic to get instructions to configure a Twitter Direct Message channel in Omnichannel for Customer Service."
ms.date: 10/27/2022
ms.topic: article
author: lalexms
ms.author: laalexan
---

# Configure a Twitter Direct Message channel

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

Many customers use social messaging channels like Twitter Direct Message for their personal communication needs. Many also prefer using these messaging channels to engage with businesses. The asynchronous nature of these channels gives customers the convenience of getting their issues resolved as and when they find time, unlike real-time channels like Chat for Dynamics 365, where the session ends when the chat window is closed.

The Twitter channel gives you an incredible opportunity to capitalize on the social media trend and engage with your customers in a seamless and personalized experience.

## Prerequisites

The following are important prerequisites that you must complete before configuring the Twitter channel in Omnichannel for Customer Service.
> [!NOTE]
> To enable the Twitter channel in an existing Omnichannel for Customer Service environment, you must [upgrade to the latest version of Omnichannel for Customer Service](upgrade-omnichannel.md).

- Create a Twitter handle. More information: [Create and Manage a Twitter business profile](https://business.twitter.com/en/basics/create-a-twitter-business-profile.html)
- Enable Direct Message for your Twitter handle. More information: [Enable Direct Message](https://help.twitter.com/using-twitter/direct-messages#receive)
- Create a Twitter application. Apply for a developer account, not a team account. Create a Twitter developer environment. More information: [App Development](https://developer.twitter.com/docs/basics/apps/overview)
- Update the Twitter application permissions to read, write, and access Direct Messages. More information: [App permissions](https://developer.twitter.com/docs/basics/apps/guides/app-permissions)
- Verify that you have permissions on the secure columns. More information: [Configure permissions to access secure columns](add-users-assign-roles.md#configure-permissions-to-access-secure-columns)

## Create a Twitter channel and add a Twitter handle

**To create a Twitter channel**

1. In Dynamics 365, go to one of the apps, and perform the following steps.

   ### [Customer Service admin center](#tab/customerserviceadmincenter)
    
    1. In the site map, in **Customer support**, select **Channels**.
    
    1. In **Accounts**, for **Messaging accounts**, select **Manage**.
   
   ### [Omnichannel admin center](#tab/omnichanneladmincenter) 

    - In the site map, in **General settings**, select **Channels**.

1. On the **Accounts and channels** page, select **New account**.

1. Enter the following details:
   
   1. On the **Channel details** page, enter a name and select **Twitter**.
   
   1. On the **Account details** page, enter the following details:
      - **Consumer API key:** Key of the Twitter application. Go to the Twitter developer portal > Twitter app dashboard > **Details** > **Keys and tokens**, and then copy the value in the **API key** field.
      - **Consumer API secret:** Application secret of the Twitter application. Go to the Twitter developer portal > Twitter app dashboard > **Details** > **Keys and tokens**, and then copy the value in the **API secret key** field.
      - **Environment name:** Environment of the Twitter application. Go to the Twitter developer portal > Dev environments > **Dev environment label** (make sure that the development environment was created under **Account Activity API**).
      
      > [!IMPORTANT]
      > The **Environment name** field cannot be a random string and must match the **Dev environment label** in the Twitter developer portal.
   
   1. On the **Callback information** page, copy the text in the **Callback URL** box. You'll use the copied information in the Twitter account.
   
   1. Select **Done**.

1. To configure routing and work distribution, you can create a [workstream](create-workstreams.md) or select an existing one.

1. Select the workstream that you've created for the Twitter channel and on the workstream page, select **Set up Twitter**, and configure the following options:
   
   1. On the **Twitter handle** page, select a handle from **Available Twitter handles**.
   
   1. On the **Language** page, select a language.
   
   1. On the **Behaviors** page, configure the following options:
      - [Custom automated messages](configure-automated-message.md)
      - [Post-conversation survey](configure-post-conversation-survey.md)
   1. On the **User features** page, set the toggle for **File attachments** to **On** and select the following checkboxes if you want to allow agents and customers to send and receive file attachments. More information: [Enable file attachments](enable-file-attachments.md).
      - Customers can send file attachments
      - Agents can send file attachments
   1. Verify the settings on the **Summary** page, and select **Finish**. The Twitter channel instance is configured.
1. Configure routing rules. More information: [Configure work classification](configure-work-classification.md).

1. Configure work distribution. More information: [Work distribution settings](create-workstreams.md#configure-work-distribution)

1. Add a bot. More information: [Configure a bot](create-workstreams.md#add-a-bot-to-a-workstream).

1. In **Advanced settings**, configure the following options based on your business needs:
   - [Sessions](../app-profile-manager/session-templates.md)
   - [Agent notifications](../app-profile-manager/notification-templates.md#out-of-the-box-notification-templates)
   - [Context variables](manage-context-variables.md#add-context-variables)
   - [Smart assist bots](smart-assist-bot.md)
   - [Quick replies](create-quick-replies.md)

#### Create a Twitter channel and add a Twitter handle in Omnichannel Administration

[!INCLUDE[cc-omnichannel-administration-deprecation-note.md](../includes/cc-omnichannel-administration-deprecation-note.md)]

> [!NOTE]
> Before starting this procedure, you must meet the [prerequisites](#prerequisites) described earlier in this topic.

1.	Go to **Channels** > **Twitter** and select **New** to create a Twitter channel.

2.	On the **New Twitter Application** page, provide the following account details:

    - **Name**: Name of the Twitter application. 

    - **Consumer API key**: Key of the Twitter application. Go to the Twitter developer portal > Twitter app dashboard > **Details** > **Keys and tokens**, and then copy the value in the **API key** field.

    - **Consumer API Secret**: Application secret of the Twitter application. Go to the Twitter developer portal > Twitter app dashboard > **Details** > **Keys and tokens**, and then copy the value in the **API secret key** field.
    
    - **Environment name**: Environment of the Twitter application. Go to the Twitter developer portal > Dev environments > **Dev environment label** (make sure that the dev environment was created under **Account Activity API**).
    
      > [!IMPORTANT]
      > The **Environment name** field cannot be a random string and must match the **Dev environment label** in the Twitter developer portal.

    More information about the Twitter app: [Setting up your Twitter app](https://developer.twitter.com/en/docs/basics/apps/overview)
  

3.	Select **Save**. After you save the record, the **Twitter** channel is enabled. The Callback URL has been generated. The next step is to save it.

4. To save the Callback URL in the Twitter app dashboard of the developer portal, go to the Twitter developer portal > Twitter app dashboard > **Details** > **App details** > **Edit**. Copy the **Callback URL** from Omnichannel for Customer Service, and then paste it into the **Callback URLs** field.
 
5. Add a Twitter handle: In the **Twitter app** section, select **New Twitter handle** to add Twitter handles.

6.	On the **New Twitter handle** page, in **Name**, enter a name that you can reference. It should not be the Twitter handle. 

7.	Select **Sign on to Twitter**. A pop-up window appears. Sign in by using the Twitter handle and password that will be added here.

    > [!NOTE]
    > If you receive a message that says pop-up windows are blocked, select to always allow them.

1.  On the **General settings** tab, provide the following information:
    
    - **Language**: Select the preferred language for your Facebook page.
    
    - **Work Stream**: Select the out-of-the-box work stream for the Twitter channel. To create a work stream, see [Create work streams](create-workstreams.md).

    - **Enable file attachments for customers**: Set to **Yes** to allow customers to send file attachments to agents. Otherwise, set **No**.

    - **Enable file attachments for agents**: Set to **Yes** to allow agents to send file attachments to customers. When the agent sends an attachment, the app uploads the attachment to Twitter and captures the media ID. Otherwise, set **No**. 
    
       To learn more about attachments, see [File attachments](enable-file-attachments.md).
       
       To learn more about uploading media in Twitter, see [Twitter developer documentation](https://developer.twitter.com/en/docs/media/upload-media/uploading-media/media-best-practices).
       
2. On the **Automated messages** tab, [configure automated messages](configure-automated-message.md). 
    
3.  On the **Surveys** tab, [configure a post-conversation survey](configure-post-conversation-survey.md).

4.  Select **Save** to save the record. The Twitter channel setup is complete.
 
  > [!NOTE]
  > You can add multiple handles to a Twitter Application channel.
 
#### Create routing rules in Omnichannel Administration

1.	Go to **Work Distribution Management** > **Work Streams**.
2.	Open the out-of-the-box work stream or the one you created.
3.	On the **Routing rules items** tab, create a routing rule to transfer the message to an appropriate agent. Select the entity as **Twitter Engagement Context**. For example, you can create a rule to transfer Twitter chat from a customer named Twitter to the default queue.
 
When you create conditions for routing rules, the **Twitter Engagement Context (Conversation)** entity enables you to set the following attributes:

  - Customer name 
  - Customer screen name
  - Followers count
  - Friends count


## Customer and agent experiences

A customer can initiate a conversation in any of the following ways:

- Twitter app on a mobile device
- Twitter app on a desktop device
- [www.twitter.com](https://twitter.com/)

If a customer initiates a conversation from the Twitter website and then later switches to the mobile device, the previous conversation persists and the customer can continue the conversation.

The agent receives the notification of the incoming chat request, along with customer details. More information: [View notifications](oc-notifications.md)

> [!div class=mx-imgBorder]
> ![Twitter chat agent notification.](media/twitter-chat-agent-notify.png "Twitter chat agent notification")

Once the Twitter social profile is linked to an user customer/contact record by the agent, subsequent Twitter conversations are linked to the customer records and the customer summary is populated. 

If the customer isn't identified by name, a new contact record can be created.

## Privacy notice

By enabling this feature, your data will be shared with Twitter and flow outside of your organization's compliance and geo boundaries (even if your organization is in a Government Cloud environment). Please consult the feature technical documentation for more information [here](/azure/bot-service/bot-service-manage-channels?view=azure-bot-service-4.0&preserve-view=true).

Customers are solely responsible for using Dynamics 365, this feature, and any associated feature or service in compliance with all applicable laws, such as laws relating to monitoring, recording, and storing communications with their end-users. This includes adequately notifying end-users that their communications with agents may be monitored, recorded, or stored and, as required by applicable laws, obtaining consent from end-users before using the feature with them. Customers are also encouraged to have a mechanism in place to inform their agents that their communications with end users may be monitored, recorded, or stored.

### See also

[Understand and create work streams](create-workstreams.md)  
[Configure automated messages](configure-automated-message.md)   
[Configure a post-conversation survey](configure-post-conversation-survey.md)  
[Create and manage routing rules](routing-rules.md)  
[Delete a configured channel](delete-channel.md)  
[Support for live chat and asynchronous channels](card-support-in-channels.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
