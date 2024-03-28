---
title: FAQ about Facebook channel setup
description: Review frequently asked questions (FAQ) about Facebook channel configuration in Omnichannel for Customer Service.
ms.date: 03/28/2024
ms.topic: conceptual
author: lalexms
ms.author: laalexan
ms.reviewer: shujoshi
ms.custom: bap-template
---

# FAQ about Facebook channel setup

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

This article provides answers to frequently asked questions (FAQs) about configuring the Facebook channel in Omnichannel for Customer Service.

## Why aren't agents able to receive messages that are sent on Facebook? 

If agents who use Omnichannel for Customer Service aren't receiving Facebook messages, it's likely because users lack the necessary roles or permissions. The assignment of roles or permissions may vary slightly, depending on whether the application is in production or development mode. 

**App in production mode**: 
- If this is the first time the Facebook page is being used for messaging, the customer needs to request pages_messaging permission from their Facebook app. After the request is approved, any Facebook user can send messages to their page.

- If the Facebook page is currently used for messaging with another provider and this is the first time you're trying to onboard the page to Omnichannel for Customer Service, you must have an existing Facebook page that's linked to two Facebook apps: One that's connected to your existing provider, and the other that you want to set up with Omnichannel for Customer Service.<br>

  Complete the following steps:
  1. Open the Facebook app that has the Omnichannel for Customer service webhook.
  1. In **Messenger API Settings**, find the webhook subscription properties, and then for **Page Subscriptions**, select **Messages** and **Standby**.
  1. For messages to show in omnichannel, sign in to your Facebook Page account: Go to **Manage** > **Page Access** > **Advanced Messaging**.
  1. In **Messenger receiver at Handover protocol**, set the receiver as the Facebook app that's set up with the Omnichannel for Customer Service-provided webhook.
  1. Reopen the Facebook app that has the omnichannel webhook. In **Messenger API Settings**, in the webhook subscription properties, deselect **Standby**.
  1. Resend messages from your Facebook page to verify that messages are received in Omnichannel for Customer Service.


**App in development mode**: If the Facebook app that you’re using is currently in development mode, then only those Facebook users who have roles within the app can send messages to the Facebook page. The messages can be received by or forwarded to Omnichannel for Customer Service. 

If you grant roles to an existing Facebook user, make sure the user has a Meta Developer account. They need to sign in and accept the assigned role invitation to the app from their account. 

If you're creating a test user within the Facebook app, select to automatically install the app, and select the pages_messaging permission.​

> [!div class=mx-imgBorder]
> ![Create test user with pages_messaging permission in Facebook app.](../media/facebook-test-account-configure.png "Create Facebook app test user with pages_messaging permission")

### See also

[Configure a Facebook channel](configure-facebook-channel.md)<br>
[Understand and create workstreams](create-workstreams.md)<br>
[Configure automated messages](configure-automated-message.md)<br>
[Configure a prechat survey](configure-pre-chat-survey.md)<br>
[Configure a post conversation survey](configure-post-conversation-survey.md)<br>
[Delete a configured channel](delete-channel.md)<br>
[Support for live chat and asynchronous channels](card-support-in-channels.md)
