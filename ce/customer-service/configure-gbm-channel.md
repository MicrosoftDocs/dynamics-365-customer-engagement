---
title: "Configure a Google Business Messages channel in Omnichannel for Customer Service | MicrosoftDocs"
description: "Perform the steps mentioned in this topic to configure a Google Business Messages channel in Omnichannel for Customer Service."
ms.date: 07/11/2022
ms.topic: article
author: lalexms
ms.author: laalexan
manager: shujoshi
---
# Configure a Google Business Messages channel

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

> [!Important]
> Support for the Omnichannel Administration app ended on April 30, 2022. We recommend that you use the Omnichannel admin center or Customer Service admin center app to configure the latest features, such as unified routing and voice channel. More information: [Omnichannel administration app is deprecated](deprecations-customer-service.md#omnichannel-administration-app-is-deprecated)

## Overview of the Google Business Messages channel

Many customers use social messaging channels like Google Business Messages for their personal communication needs. Many also prefer using these messaging channels to engage with businesses. The asynchronous nature of these channels gives customers the convenience of getting their issues resolved as and when they find time, unlike real-time channels like Chat for Dynamics 365, where the session ends when the chat window is closed.

The Google Business Messages channel gives you an incredible opportunity to capitalize on the social media trend and engage with your customers in a seamless and personalized experience.

## Prerequisites

The following are important prerequisites that you must complete before configuring the Google Business Messages channel in Omnichannel for Customer Service.

- In Customer Service, you must have channels provisioned in your environment. More information: [Provision Omnichannel for Customer Service](/omnichannel-provision-license.md)
- [Register as a partner](https://developers.google.com/business-communications/business-messages/guides/how-to/register#register_as_a_partner)

In Google, complete the following actions:
·	[Create a service account with a service account key](https://developers.google.com/business-communications/business-messages/guides/how-to/register#create_a_service_account)
·	[Create an agent](https://developers.google.com/business-communications/business-messages/guides/how-to/agents?method=console)
·	[Set non-local information](https://developers.google.com/business-communications/business-messages/guides/how-to/agents/non-local?method=console)
·	[Set messaging availability](https://developers.google.com/business-communications/business-messages/guides/how-to/agents/availability?method=console)
·	[Set agent- and location-level settings](https://developers.google.com/business-communications/business-messages/guides/how-to/agents/begin-conversation?method=console)
·	[Set the default locale](https://developers.google.com/business-communications/business-messages/guides/how-to/agents/localization?method=console#update-default-locale)
·	[Verify the agent](https://developers.google.com/business-communications/business-messages/guides/how-to/verify?method=console)

## End-to-end walkthrough

1. [Register Google Business Messages](#register-google-business-messages)
2. [Create a new agent profile in Google Business Messages](#create-a-new-agent-profile-in-google-business-messages)
3. [Create a workstream in Omnichannel admin center](#create-a-workstream-in-omnichannel-admin-center)
4. [Create Google Business Messages](#create-google-business-messages)
5. [Test the messaging for the agent in the Google Business Messages app](#test-the-messaging-for-the-agent-in-the-google-business-messages-app)

## Register Google Business Messages

You can connect Google Business Messages with Omnichannel for Customer Service by completing the following steps to create a webhook from Omnichannel.

1. In Omnichannel admin center, on the left side pane, select **Channels**, and then select **AdminAccount**.
1. Select **Add account**. The **Add account** page is displayed.
1. In the **Name** field, enter the name for the account.
1. In the **Channel** dropdown menu, select **Google Business Messages**, and then select **Next**.
1. On the **Google Business Messages Partner account** page, in the **Partner ID** field, copy and paste the Partner ID from the **Settings** page of the Google Business Messages app.
1. In the **Client token** field, enter the token from the Google Business Messages app. The token is found on the **Configure your webhook** page of the Google Business Messages app.
  > [!Note]
  > Only users with proper security permissions can use secured fields, such as **Client token** and **Credential**. More information: [Set up security permissions for a field](/power-platform/admin/set-up-security-permissions-field)

1. In Omnichannel, on the **Configure your two-way connection with Omnichannel for Customer Service**, copy the **Google Business Messages** URL and then, in the Google Business Messages app, on the **Configure your webhook** page, paste the URL in the **Webhook endpoint URL** field.
1. Select **Verify** in the Google Business Messages app.
1. When the verification has completed, select **Save**.

## Create a new agent profile in Google Business Messages
1. In Google Business Messages, on the **Welcome to Business Communications** page, select the **Create agent** tile.
1. On the **New Business Messages agent** page, select the **Brand** from the dropdown list, and then enter the name in the **Agent name** field.
1. Select **Create agent**.
1. When created, the agent name displays as a new tile. Select the tile, and then on the **Overview** page, select and copy the **Brand ID**, and then paste it into the **Brand ID** field in Omnichannel.
1. In Google Business Messages, select and copy the **Agent ID**, and then paste it into the **Agent ID** field in Omnichannel.
1. In Omnichannel, select **Add** > **Save**.

## Create a workstream in Omnichannel admin center
1. In Omnichannel admin center, select **Workstreams** under **General settings**.
1. Select **New workstream**, and then enter a name.
1. In **Type**, select **Messaging**.
1. In the **Channel** dropdown list, select **Google Business Messages**.
1. In the **Choose existing** dropdown list, select an existing queue to use as the fallback for the workstream.
1. Select **Create**.

## Set up Google Business Messages
1. When the workstream has been created, on the workstream page, select **Set up Google Business Messages**.
1. Select the agent account you prefer from the list, and then select **Next**.
1. On the **Language** page, select the preferred language, and then select **Next**.
1. On the **User features** page, toggle the **File attachments** setting to **On**, and then select **Next**.
1. Select **Create channel**.

## Test the messaging for the agent in the Google Business Messages app
In the Google Business Messages app, on the **Overview** page, under **Agent test URLs**, select either **Android** or **iOS**, and then select **Test**.
