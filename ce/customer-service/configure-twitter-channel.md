---
title: "Configure Twitter Direct Message channel | MicrosoftDocs"
description: "Instructions to configure a Twitter Direct Message channel in Omnichannel for Customer Service."
author: lalexms
ms.author: laalexan
manager: shujoshi
ms.date: 12/30/2020
ms.topic: article
ms.service: "dynamics-365-customerservice"
---

# Configure a Twitter Direct Message channel

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

Many customers use social messaging channels like Twitter Direct Message for their personal communication needs. Many also prefer using these messaging channels to engage with businesses. The asynchronous nature of these channels gives customers the convenience of getting their issues resolved as and when they find time, unlike real-time channels like Chat for Dynamics 365, where the session ends when the chat window is closed.

The Twitter channel gives you an incredible opportunity to capitalize on the social media trend and engage with your customers in a seamless and personalized experience.

## Prerequisites

The following are important prerequisites that you must complete before configuring the Twitter channel in Omnichannel for Customer Service.
> [!NOTE]
> To enable the Twitter channel in an existing Omnichannel for Customer Service environment, you must [upgrade to the latest version of Omnichannel for Customer Service](upgrade-omnichannel.md).

1.	Create a Twitter handle. More information: [Create and Manage a Twitter business profile](https://business.twitter.com/en/basics/create-a-twitter-business-profile.html)
2.	Enable Direct Message for your Twitter handle. More information: [Enable Direct Message](https://help.twitter.com/using-twitter/direct-messages#receive)
3.	Create a Twitter application. Apply for a developer account, not a team account. Create a Twitter developer environment. More information: [App Development](https://developer.twitter.com/docs/basics/apps/overview)
4.  Update the Twitter application permissions to read, write, and access Direct Messages. More information: [App permissions](https://developer.twitter.com/docs/basics/apps/guides/app-permissions)

After completing the prerequisites, you can add the Twitter channel for your organization by following these steps:

1. [Create a Twitter channel and add a Twitter handle](#create-a-twitter-channel-and-add-a-twitter-handle).
2. [Create routing rules](#create-routing-rules).

## Create a Twitter channel and add a Twitter handle

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
  
    > [!div class=mx-imgBorder]
    > ![Register a Twitter application](media/twitter-register-app.png "Register a Twitter application")

3.	Select **Save**. After you save the record, the **Twitter** channel is enabled. The Callback URL has been generated. The next step is to save it.

4. To save the Callback URL in the Twitter app dashboard of the developer portal, go to the Twitter developer portal > Twitter app dashboard > **Details** > **App details** > **Edit**. Copy the **Callback URL** from Omnichannel for Customer Service, and then paste it into the **Callback URLs** field.
 
  > [!div class=mx-imgBorder]
  > ![Twitter Callback information](media/twitter-callback-information.png "Twitter Callback URL")

5. Add a Twitter handle: In the **Twitter app** section, select **+ New Twitter handle** to add Twitter handle(s).

6.	On the **New Twitter handle** page, provide the following information:

    - **Name**: Not the Twitter handle, but a name that you can reference. 

7.	Select **Sign on to Twitter**. A pop-up window appears. Sign in by using the Twitter handle and password that will be added here.

    > [!NOTE]
    > If you receive a message that says pop-up windows are blocked, select to always allow them.

8.  On the **General settings** tab, provide the following information:
    
    - **Language**: Select the preferred language for your Facebook page.
    
    - **Work Stream**: Select the out-of-the-box work stream for the Twitter channel. To create a new work stream, see [Create work streams](work-streams-introduction.md).

    - **Enable file attachments for customers**: Set to **Yes** to allow customers to send file attachments to agents. Otherwise, set **No**. 

    - **Enable file attachments for agents**: Set to **Yes** to allow agents to send file attachments to customers. When the agent sends an attachment, the app uploads the attachment to Twitter and captures the media ID. Otherwise, set **No**. 
    
       To learn more about attachments, see [File attachments](enable-file-attachments.md).
       
       To learn more about uploading media in Twitter, see [Twitter developer documentation](https://developer.twitter.com/en/docs/media/upload-media/uploading-media/media-best-practices).
       
       > [!div class=mx-imgBorder]
       > ![Twitter work stream](media/twitter-create-handle.png "Twitter work stream")

9. On the **Automated messages** tab, [configure automated messages](configure-automated-message.md). 
    
10. On the **Surveys** tab, [configure a post-conversation survey](configure-post-conversation-survey.md).

11. Select **Save** to save the record. The Twitter channel setup is complete.
 
  > [!div class=mx-imgBorder]
  > ![Twitter channel enabled](media/twitter-account-complete.png "Twitter channel enabled")

  > [!NOTE]
  > You can add multiple handles to a Twitter Application channel.
 
## Create routing rules

1.	Go to **Work Distribution Management** > **Work Streams**.
2.	Open the out-of-the-box work stream or the one you created.
3.	On the **Routing rules items** tab, create a routing rule to transfer the message to an appropriate agent. Select the entity as **Twitter Engagement Context**. For example, you can create a rule to transfer Twitter chat from a customer named Twitter to the default queue.
 
  > [!div class=mx-imgBorder]
  > ![Twitter routing rule creation](media/twitter-create-routing-rule.png "Create Twitter routing rule")

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
> ![Twitter chat agent notification](media/twitter-chat-agent-notify.png "Twitter chat agent notification")

Once the Twitter social profile is linked to an user customer/contact record by the agent, subsequent Twitter conversations are linked to the customer records and the customer summary is populated. 

If the customer isn't identified by name, a new contact record can be created.

## Privacy notice

By enabling this feature, your data will be shared with Twitter and flow outside of your organization's compliance and geo boundaries (even if your organization is in a Government Cloud environment). Please consult the feature technical documentation for more information [here](https://docs.microsoft.com/azure/bot-service/bot-service-manage-channels?view=azure-bot-service-4.0).

Customers are solely responsible for using Dynamics 365, this feature, and any associated feature or service in compliance with all applicable laws, such as laws relating to monitoring, recording, and storing communications with their end-users. This includes adequately notifying end-users that their communications with agents may be monitored, recorded, or stored and, as required by applicable laws, obtaining consent from end-users before using the feature with them. Customers are also encouraged to have a mechanism in place to inform their agents that their communications with end users may be monitored, recorded, or stored.

### See also

[Understand and create work streams](work-streams-introduction.md)<br>
[Configure automated messages](configure-automated-message.md)<br> 
[Configure a post-conversation survey](configure-post-conversation-survey.md)<br>
[Create and manage routing rules](routing-rules.md)<br>
[Delete a configured channel](delete-channel.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]