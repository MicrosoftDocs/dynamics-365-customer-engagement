---
title: "Configure a Google's Business Messages channel | MicrosoftDocs"
description: "Perform the steps mentioned in this article to configure a Google Business Messages channel in Omnichannel for Customer Service."
ms.date: 10/27/2022
ms.topic: article
author: lalexms
ms.author: laalexan
---
# Configure Google's Business Messages channel

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

Many customers use social messaging channels like Google's Business Messages for their personal communication needs. Many also prefer using these messaging channels to engage with businesses. The asynchronous nature of these channels gives customers the convenience of getting their issues resolved as and when they find time, unlike real-time channels like Chat for Dynamics 365, where the session ends when the chat window is closed.

Google's Business Messages channel gives you the opportunity to capitalize on the social media trend and engage with your customers in a seamless and personalized experience.

## Prerequisites

Complete the following steps before configuring Google's Business Messages channel in Omnichannel for Customer Service.

- In Customer Service, provision the channels in your environment. More information: [Provision Omnichannel for Customer Service](omnichannel-provision-license.md)

- In Google's Business Messages, complete the following actions:

  - [Register as a partner](https://developers.google.com/business-communications/business-messages/guides/how-to/register#register_as_a_partner)
  - [Create a service account with a service account key](https://developers.google.com/business-communications/business-messages/guides/how-to/register#create_a_service_account)

  - Configure the agent:
    - [Create an agent](https://developers.google.com/business-communications/business-messages/guides/how-to/agents?method=console)
    - [Set non-local information](https://developers.google.com/business-communications/business-messages/guides/how-to/agents/non-local?method=console)
    - [Set messaging availability](https://developers.google.com/business-communications/business-messages/guides/how-to/agents/availability?method=console)
    - [Set agent- and location-level settings](https://developers.google.com/business-communications/business-messages/guides/how-to/agents/begin-conversation?method=console)
    - [Set the default locale](https://developers.google.com/business-communications/business-messages/guides/how-to/agents/localization?method=console#update-default-locale)
  
  - [Verify the agent](https://developers.google.com/business-communications/business-messages/guides/how-to/verify?method=console)

- Verify that you have permissions on the secure columns. More information: [Configure permissions to access secure columns](add-users-assign-roles.md#configure-permissions-to-access-secure-columns)

## Create a Google's Business Messages channel

1. Go to one of the admin apps, and perform the following steps.

   ### [Customer Service admin center](#tab/customerserviceadmincenter)

    1. In the site map, select **Channels** in **Customer support**. The **Channels** page appears.
    
    1. Select **Manage** for **Messaging accounts**. The **Accounts and channels** page appears.
   
    1. Select **New account**.
   
   ### [Omnichannel admin center](#tab/omnichanneladmincenter)

    - In the site map, select **Channels** under **General settings**, and on the **Accounts and channels** page, select **New account**.

1. In the **Name** field, enter the name for the account.

1. In the **Channel** dropdown menu, select **Google's Business Messages**, and then select **Next**.

1. On the **Google's Business Messages Partner account** page, in the **Partner ID** field, copy and paste the Partner ID from the **Settings** page of the Google's Business Messages app.

1. In the **Client token** field, enter the token from Google's Business Messages app. To retrieve the token, in Google's Business Messages app, on the **Settings** page, under **Webhook**, select the **Configure** link. The **Configure your webhook** page is displayed, and then you can copy the token from the **Client token** field.

1. In Omnichannel admin center, on the **Google's Business Messages Partner account** page, next to **Service Account Credentials file (JSON file)**, select **Upload**, and then select the file you downloaded from Google's Business Messages.

   > [!Note]
   > Only users with proper security permissions can use secured fields, such as **Client token** and **Security Credential**. More information: [Set up security permissions for a field](/power-platform/admin/set-up-security-permissions-field)

1. In Omnichannel, in **Configure your two-way connection with Omnichannel for Customer Service**, copy the **Google's Business Messages** URL and then, in the Business Messages app, on the **Configure your webhook** page, paste the URL in the **Webhook endpoint URL** field.

1. Select **Verify** in the Google's Business Messages app.

1. When the verification has completed, select **Save**.

1. In Google's Business Messages, select the tile for the agent profile you created, and then on the **Overview** page, select and copy the **Brand ID**, and then paste it into the **Brand ID** field in Omnichannel.

1. In Google's Business Messages, select and copy the **Agent ID**, and then paste it into the **Agent ID** field in Omnichannel.

1. In Omnichannel, select **Add** > **Save**.

## Create a workstream

1. Go to one of the admin apps, and perform the following steps:

   ### [Customer Service admin center](#tab/customerserviceadmincenter)

    - In the site map, select **Workstreams** in **Customer support**. The **All Workstreams** page appears.
   
   ### [Omnichannel admin center](#tab/omnichanneladmincenter)

    - In the site map, select **Workstreams** under **General settings**. The **All workstreams** page appears.
    
1. Select **New workstream**, and then enter a name.
1. In **Type**, select **Messaging**.
1. In the **Channel** dropdown list, select **Google's Business Messages**.
1. In the **Choose existing** dropdown list, select an existing queue to use as the fallback for the workstream.
1. Select **Create**.
1. When the workstream has been created, on the workstream page, select **Set up Google's Business Messages**.
1. Select the agent account you prefer from the list, and then select **Next**.
1. On the **Language** page, select the preferred language, and then select **Next**.
1. On the **User features** page, toggle the **File attachments** setting to **On**, and then select **Next**.
1. Select **Create channel**.

## Test the messaging for the agent in the Google's Business Messages app

In the Business Messages app, on the **Overview** page, under **Agent test URLs**, select either **Android** or **iOS**, and then select **Test**.

## Create routing rules

[Configure routing rules](configure-route-to-queue-rules.md) for the workstream you created. Select the entity as Google's Business Messages context.

For example, you can create a rule to transfer Google's Business Messages chat from a customer named Google's Business Messages to the default queue.

## Privacy notice

By enabling this feature, your data will be shared with Google and flow outside of your organization's compliance and geo boundaries (even if your organization is in a Government Cloud Community region). Consult the feature technical documentation for more information here.

Customers are solely responsible for using Dynamics 365, this feature, and any associated feature or service in compliance with all applicable laws, such as laws relating to monitoring, recording, and storing communications with their end users. This includes adequately notifying end users that their communications with agents may be monitored, recorded, or stored and, as required by applicable laws, obtaining consent from end users before using the feature with them. Customers are also encouraged to have a mechanism in place to inform their agents that their communications with end users may be monitored, recorded, or stored.


### See also

[Channels in Omnichannel for Customer Service](channels.md)  
[Use Google's Business Messages in Omnichannel](google-business-messages.md)  
[Delete a configured channel](delete-channel.md)  
[Support for live chat and asynchronous channels](card-support-in-channels.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]

