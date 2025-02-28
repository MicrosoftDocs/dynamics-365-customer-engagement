---
title: Configure a Facebook channel
description: Learn how to configure a Facebook channel and corresponding Facebook pages.
ms.date: 02/20/2025
ms.topic: how-to
author: lalexms
ms.author: laalexan
ms.reviewer: laalexan
ms.custom: bap-template
---

# Configure Facebook channel

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

[!INCLUDE[cc-rebrand-bot-agent](../../includes/cc-rebrand-bot-agent.md)]


Many customers use social messaging channels like Facebook for their personal communication needs. Many also prefer using messaging channels to engage with businesses. The asynchronous nature of these channels gives customers the convenience of getting their issues resolved as and when they find time. This ability contrasts with real-time channels like Chat for Dynamics 365 Customer Service, where the session ends when the chat window closes.

> [!NOTE]
> If you use access tokens in Facebook, refresh them on a 60-day schedule or as required because the tokens might randomly expire. More information: [Facebook access tokens](https://developers.facebook.com/docs/pages/access-tokens)

## Prerequisites

Make sure that the following prerequisites are met:

- Create a Facebook page. More information: [Create and Manage a Page](https://www.facebook.com/help/135275340210354/?helpref=hc_fnav)
- Enable Messenger. More information: [Messaging](https://www.facebook.com/help/994476827272050/?helpref=hc_fnav)
- Create a Facebook application. More information: [App Development](https://developers.facebook.com/docs/apps/)
- Sign in to the [developer site on Facebook](https://developers.facebook.com/) or create an account, and then complete the following steps:
   1. Select **My Apps**, and then select **Create app**.
   1. On the **What do you want your app to do?** page, select **Other**, and then select **Next**.
   1. On the **Select an app type** page, select **Business**, and then type your app's name and contact email address.
   1. On the **Add products to your app** page, select **Messenger**, and then select **Set up**.
   1. On the Messenger settings page, select **Add or remove Pages**, and then add the Facebook page you created. After you add the page, the Page ID and the option to generate a token appear.
- If you're using a test environment, set up test accounts in Facebook so that customer service representatives (service representatives or representatives) can send and receive messages in Omnichannel for Customer Service: Go to **App Roles** > **Roles** > **Testers (Add Testers)**.
- Values for application ID and application secret from the **App ID** and **App Secret** fields in the Facebook application > **Settings** > **Basic**.

## Roles and permissions

The following Facebook roles and permissions are required for integrating your Facebook app with Omnichannel for Customer Service.

- Facebook users who don’t have a role in the Facebook app must have the `pages_messaging` permission to send messages to a Facebook page from Omnichannel for Customer Service. The app owner must provide the `pages_messaging` permission for users to be able to send messages. More information: [pages_messaging](https://developers.facebook.com/docs/permissions/reference/pages_messaging/)

- If the Facebook app that you’re using is in development mode, only those Facebook users who have roles within the app can send messages to the Facebook page. The messages can be received by or forwarded to Omnichannel for Customer Service. More information: [App roles](https://developers.facebook.com/docs/development/build-and-test/app-roles/)

- For Omnichannel for Customer Service to be able to retrieve the customer’s username from Facebook, the customer must request for Business Asset User Profile Access in their Facebook app. More information: [Business Asset User Profile Access](https://developers.facebook.com/docs/features-reference/business-asset-user-profile-access)
- 
## Privacy notice

If you enable this feature, your data is shared with Facebook and flows outside of your organization's compliance and geo boundaries (even if your organization is in a Government Community Cloud region). Learn more in [Connect an AI agent to Facebook](/azure/bot-service/bot-service-channel-connect-facebook?preserve-view=true&view=azure-bot-service-4.0).

Customers are solely responsible for using Dynamics 365, this feature, and any associated feature or service in compliance with all applicable laws, such as laws that relate to monitoring, recording, and storing communications with their end users. This responsibility includes adequately notifying end users that their communications with service representatives might be monitored, recorded, or stored and, as required by applicable laws, obtaining consent from end users before using the feature with them. Customers are also encouraged to have a mechanism in place to inform their representatives that their communications with end users may be monitored, recorded, or stored.

## Configure a Facebook channel

To configure a Facebook channel, the following steps are required:

1. Create a Facebook channel account.

1. Configure a Facebook workstream and work distribution settings.

### Create the Facebook channel account

1. In the site map of Customer Service admin center, in **Customer support**, select **Channels**.
1. In **Accounts**, for **Messaging accounts**, select **Manage**.

1. On the **Accounts and channels** page, select **New account**.

1. Enter the following details:

   1. On the **Channel details** page, enter a name and select Facebook in **Channels**.

   1. On the **Add account** page, in the **Application ID** and **Application secret** fields, specify the Facebook App ID and App secret that you copied from the Facebook application.

   1. On **Add Facebook Pages to this account**, do the following steps:

   1. Select **Add**, and in the **Add Facebook Page** pane, enter the following details:
      - **Page name:** Name of the Facebook page.
      - **Page ID:** ID of the Facebook page. To get the page ID, go to your Facebook page, select About, and copy the value in the Page ID field.
      - **Page access token:** Specify the Page access token of the Facebook application. To get the page access token, go to your Facebook application and then go to **Messenger** > **Settings**. In the **Access Tokens** section, select the page, and copy the value in the **Page Access Token** field.
      - On the **Callback information** page, the **Callback URL** and **Verify token** fields are populated automatically when you save the settings. Use the information to configure webhooks in the Facebook application. The values for the fields aren't generated if the Facebook page is reused across multiple instances of the channel.

1. Navigate back to the **Facebook Application Messenger settings** page, and then add the callback URL.

1. Select **Add subscriptions for the page**, and then on the **Edit page subscriptions** page, select **messages**.

1. Save your changes.

1. Open Customer Service admin center, and then go to **Channels** > **Messaging Accounts** > **Your FB Account**.

1. On the **Account settings** page, select the **Facebook Pages** tab, and then verify that the **Provisioning state** shows as **Running**.

### Create a Facebook workstream

1. To configure routing and work distribution, perform the steps outlined in [create a workstream](create-workstreams.md).

1. Select the workstream you created for the Facebook channel and on the workstream page, select **Set up Facebook**, and do the following steps:
   
   1. In the **Facebook Page** area, select a page from the list.
   
   1. On the **Language** page, select the language to use.
   
   1. On the **Behaviors** page, configure the following options:
      - Custom automated messages
      - [Post-conversation survey](configure-post-conversation-survey.md)
   1. On the **User features** page, configure the following options:
      - **File attachments:** When set to yes for both customer and representative, they can send and receive file attachments. Learn more in [Enable file attachments](enable-file-attachments.md). The availability and support of media is dependent on the Facebook application settings. Learn more in [Facebook updates](https://developers.facebook.com/docs/messenger-platform/europe-updates).
      - **Facebook message tag:** Set to **Yes** to enable your representatives to message customers after 24 hours pass. When set to **No**, representatives are unable to respond to customers after 24 hours unless the customer sends another message.

      If you enable the Facebook human agent message tag during an active conversation between the representative and customer, the representative must close the conversation and reopen it to communicate with the latter customer 24 hours of inactivity. Representatives can start conversations with customers for up to seven days.

      To use the Facebook human agent message tag, you must also turn it on in the Facebook app. Learn more in [Facebook Developer Tools](https://developers.facebook.com/tools/).  
   1. Review the **Summary** page, and select **Create**. The channel instance is configured.

1. Configure routing rules. Learn more in [Configure work classification](configure-work-classification.md).

1. Configure work distribution. Learn more in [Work distribution settings](create-workstreams.md#configure-work-distribution).

1. Optionally, you can add an AI agent. Skip this step if only human agents handle your conversations. Learn more in [Configure an agent](create-workstreams.md#add-a-bot-to-a-workstream).

1. In **Advanced settings**, configure the following options based on your business needs:
   - [Sessions](session-templates.md)
   - [Agent notifications](notification-templates.md#out-of-the-box-notification-templates)
   - [Context variables](manage-context-variables.md#add-context-variables)
   - [Smart assist bots](../develop/smart-assist-bot.md)
   - [Quick replies](create-quick-replies.md)

## Customer experience

A customer can start a conversation in any of the following ways:

- Messenger on the Facebook page
- [www.messenger.com](https://www.messenger.com/)
- Messenger app on a mobile device
- Messenger widget on a custom website

If a customer starts a conversation from the Facebook page and then later switches to the mobile device, the previous conversation persists, and the customer can continue the conversation.

The representative receives the notification of the incoming conversation request. Learn more in [Use Facebook channel](../use/facebook.md).

After the Facebook social profile is linked to a customer or contact record by the representative, subsequent Facebook conversations are linked to the customer records, and the customer summary is populated.

If the customer isn't identified based on name, a new contact record can be created.

The customer can send attachments only if you enable them. When the option isn't enabled for the customers, they can still attempt to send the file. However, representatives don't receive the file and an error displays.

> [!div class=mx-imgBorder]
> ![Customer sending file.](../media/fb-customer1.png "Customer sending file")

### Related information

[Facebook channel setup FAQ](facebook-channel-setup-faq.md)<br>
[Understand and create workstreams](create-workstreams.md)<br>  
[Configure automated messages](configure-automated-message.md)<br> 
[Configure a prechat survey](configure-pre-chat-survey.md)<br> 
[Configure a post conversation survey](configure-post-conversation-survey.md)<br>
[Delete a configured channel](delete-channel.md)<br>
[Support for live chat and asynchronous channels](card-support-in-channels.md)

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
