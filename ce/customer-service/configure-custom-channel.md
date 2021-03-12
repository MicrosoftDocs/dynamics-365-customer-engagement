---
title: "Configure a custom channel, or bring your own channel | MicrosoftDocs"
description: "Learn what a custom channel is and how to configure the channel, or bring your own channel, in Omnichannel for Customer Service."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 08/06/2020
ms.topic: article
ms.service: dynamics-365-customerservice
---

# Configure a custom messaging channel, or bring your own channel

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Overview 

As an organization, you want the ability to integrate your line-of-business (in-house) messaging channels or other messaging channels with Omnichannel for Customer Service. The custom channel feature lets you do this so you can engage with customers. Here are some of the messaging channel integrations that are supported:

- [Direct Line](#bring-channels-using-direct-line)
- Telegram

### Value proposition

- Integrate line-of-business (in-house) messaging channels that are specific to your organization.

- Easily configure the administrator experience in the Omnichannel Administrator app.

- Create a single and unified agent experience in the Omnichannel for Customer Service app.

## Prerequisites

- To enable the custom messaging channel and bring your own channel, you must have channels provisioned in your environment. For information, see [Provision Omnichannel for Customer Service](omnichannel-provision-license.md).

  > [!NOTE]
  >
  > To enable the custom messaging channel in an existing environment, you must upgrade to the latest version of Omnichannel for Customer Service. For information, [Upgrade Omnichannel for Customer Service](upgrade-omnichannel.md).

## End-to-end walk-through

[Step 1: Register your messaging channel](#step-1-register-your-messaging-channel)

[Step 2: Add the messaging channel to bot channel registration](#step-2-add-the-messaging-channel-to-bot-channel-registration)

[Step 3: Create a work stream](#step-3-create-a-work-stream)

[Step 4: Create a custom messaging account](#step-4-create-a-custom-messaging-account)

## Step 1: Register your messaging channel

To integrate your messaging channel with Omnichannel for Customer Service, register your channel in **Azure Bot Service**. To learn how to register, see [Register a bot with Azure Bot Service](https://docs.microsoft.com/azure/bot-service/bot-service-quickstart-registration).

After you register, save the **Microsoft app ID** and **Client secret** values safely for future use. These two values are required to create a custom channel configuration in the Omnichannel Administrator app.  To learn more, see [Get registration password](https://docs.microsoft.com/azure/bot-service/bot-service-quickstart-registration#get-registration-password).

## Step 2: Add the messaging channel to bot channel registration

After registering your messaging channel, add the messaging channel to the bot channel registration. To learn more, see [Connect a bot to channels](https://docs.microsoft.com/azure/bot-service/bot-service-manage-channels).

## Step 3: Create a work stream

After you add the messaging channel to the Bot Channel registration in Azure Bot Service, create a work stream for the custom channel. To create a custom channel work stream, follow these steps:

1. Sign in to Omnichannel Administrator.

2. Select **Work Streams** under **Work Distribution Management**.

3. Select **+ New** to create a new work stream.

4. Specify the values for the fields.

5. Select the **Custom (preview)** option for the **Channel** field.

6. Select **Save** to save the changes.

You've created a work stream for a custom channel. To learn more, see [Create work streams](work-streams-introduction.md).

To configure other options in the work stream, see the following:

- [Skill-based routing](overview-skill-work-distribution.md)
- [Productivity tools](productivity-tools.md)
- [Smart assist](../app-profile-manager/smart-assist.md)
- [Templates](templates-overview.md)

## Step 4: Create a custom messaging account

After you create a work stream for a custom channel, you need to create a custom channel with the details of the **Microsoft app ID** and **Client secret** that you retrieved while registering your messaging channel in Azure Bot Service.

To create a custom channel, follow these steps:

1. Sign in to Omnichannel Administrator.

2. Select **Custom (preview)** under **Channels**.

3. Select **New** in the **Active Custom messaging account** view.

4. In the **New Custom messaging account** page, specify the values for the following fields:

    | Section | Field | Description | Example  value |
    |-------------|-------------------|---------------------------|--------------------------------------|
    | Account details |Name| Specify a name for the custom channel.| Contoso custom channel |
    | Account details |Microsoft app ID| Copy and paste the **Microsoft app ID** that you saved earlier from the Azure Bot Channel Registration page. <br> To learn more, see [Get registration password](https://docs.microsoft.com/azure/bot-service/bot-service-quickstart-registration#get-registration-password). | cae1d83e-8b07-4fca-8072-c2eb3444vxyz |
    | Account details |Client secret| Copy and paste the **Client secret** that you saved earlier from the Azure Bot Channel Registration page.  <br> To learn more, see [Get registration password](https://docs.microsoft.com/azure/bot-service/bot-service-quickstart-registration#get-registration-password).| |


5. Select **Validate app ID + secret**  to validate the **Microsoft app ID** and **Client secret** values. After the validation, a toast notification is displayed. Also, the **Last validated** field shows time and date. This ensures that bots are active and client secret refreshes are consumed. 

    > [!div class=mx-imgBorder]
    > ![Account details in custom channel](media/custom-channel-1.png "Account details in custom channel")

6. Select **Save** to save the changes. After you save, in the **Callback information** section, the **Message endpoint (URL)** field is generated with a URL. Copy the URL from the field.

    > [!div class=mx-imgBorder]
    > ![Callback information for custom channel](media/custom-channel-2.png "Callback information for custom channel")

7. Go to the **Azure Portal** > **Bot Channel Registration** page, paste the URL into the **Message endpoint** field, and save the changes.

8. In the **Channels** section, select **New Custom messaging channel**. The **New Custom messaging channel** page is displayed.

   After you create a **Custom messaging account**, you need to create a custom messaging channel, which is the actual channel from which Omnichannel for Customer Service agents will receive messages from the customer.

9. On the **New Custom messaging account** page, specify the values for the following fields:

    | Section | Field | Description | Example  value |
    |-------------|-------------------|---------------------------|--------------------------------------|  
    | Details | Name | Specify a name for the custom channel | Contoso channel |
    | Details | Custom Messaging Account | The **Custom messaging account** field is populated. However, you can change the value using the lookup. | Contoso custom channel |
    | Details | Channel ID | Select a channel from the list. The list might contain line-of-business (in-house) messaging or another messaging channel. | Telegram |
    | Work distribution | Work stream | Select a work stream from the lookup. | Contoso custom channel work stream |

    > [!Note]
    > A **Custom messaging account** can have multiple unique channel IDs. Don't add two or more same Channel IDs to a **Custom messaging account** because the Azure Bot Framework supports only one messaging account per App ID. For example, for **Contoso custom account**, you can't add two or more **Telegram** Channel IDs.


    > [!div class=mx-imgBorder]
    > ![General tab page for custom channel](media/custom-channel-3.png "General tab page for custom channel") 

10. Optionally, on the **Surveys** tab, [configure a post-conversation survey](configure-post-conversation-survey.md).

11. Select **Save** to save the custom messaging channel.

12. Select the back button on the browser to go to the custom messaging account page. You can see that the custom messaging channel is added in the **Channels** section.

13. Select **Save** to save the configurations.

    > [!div class=mx-imgBorder]
    > ![Summary page for custom channel](media/custom-channel-4.png "Summary page for custom channel")

## Test your channel

For more information, see the developer guide, [Bring your own custom messaging channel: Test Client HTML](bring-your-own-channel-sample-html.md).

## Bring channels using Direct Line 

If you want to help your customers using your line-of-business (in-house) messaging channels, you can use the Direct Line channel (Bot Framework method).

The Bot Framework **Direct Line** channel helps you to integrate your line-of-business (in-house) messaging channels into the Omnichannel for Customer Service app.

For more information, see the developer guide, [Bring your own custom messaging channel: Direct Line bot](bring-your-own-channel.md).

## Modify settings for a specific custom channel

1. In the Omnichannel Administration app, go to **Custom** and select the custom channel you want to modify. 

2. On the **General settings** tab, provide the following information:
    
    - **Language**: Select the preferred language for your custom channel.
    
    - **Work stream**: Select an existing work stream or create a new one.

    - **Enable file attachments for customers**: Set to **Yes** to allow customers to send file attachments to agents. Otherwise, set **No**. 

    - **Enable file attachments for agents**: Set to **Yes** to allow agents to send file attachments to customers. When the agent sends an attachment, the app sends the blob storage URL to the channel. Otherwise, set **No**. 
    
       To learn more about attachments, see [Enable file attachments](enable-file-attachments.md). 
       
       To learn more about uploading media in Direct Line, see [Azure Bot Service documentation](https://docs.microsoft.com/azure/bot-service/rest-api/bot-framework-rest-direct-line-3-0-send-activity?view=azure-bot-service-4.0). 
       
       To learn more about uploading media in Telegram, see the [Telegram Bot API](https://core.telegram.org/bots/api#available-types).

3. On the **Automated messages** tab, [configure automated messages](configure-automated-message.md).

4. On the **Surveys** tab, [configure a post-conversation survey](configure-post-conversation-survey.md).

### See also

[Extend Omnichannel for Customer Service](extend-omnichannel.md)  
[Bring your own custom messaging channel: Direct Line bot](bring-your-own-channel.md)  
[Test the custom messaging channel](bring-your-own-channel-sample-html.md)  
[Skill-based routing](overview-skill-work-distribution.md)  
[Productivity tools](productivity-tools.md)  
[Smart assist](../app-profile-manager/smart-assist.md)  
[Templates](templates-overview.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]