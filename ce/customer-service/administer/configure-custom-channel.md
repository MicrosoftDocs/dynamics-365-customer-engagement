---
title: Configure custom messaging channels 
description: Learn what a custom channel is and how to configure it or bring your own channel.
ms.date: 02/20/2025
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.custom: bap-template
ms.collection:
---

# Configure custom messaging channels

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

[!INCLUDE[cc-rebrand-bot-agent](../../includes/cc-rebrand-bot-agent.md)]


> [!IMPORTANT]
> The Telegram and Kik custom messaging channels were deprecated and removed from Omnichannel for Customer Service on October 8, 2024. Learn more at [Deprecations in Customer Service](../implement/deprecations-customer-service.md).

Apart from built-in channels like chat and email, your organization can integrate custom messaging channels like Direct Line. With the custom messaging channel capability, you can:

- Bring in the channels your customers already use so that you can engage with them in familiar ways.
- Integrate line-of-business or in-house channels that are specific to your organization.
- Easily configure the administrator experience in the admin center.
- Create a single, unified agent experience.

## Prerequisites

- Have an AI agent (agent) that's built using the [Microsoft Bot Framework](https://dev.botframework.com) and registered with [Azure Bot Service](/azure/bot-service/bot-service-quickstart-registration?view=azure-bot-service-4.0&preserve-view=true). Make sure to register the agent resource as a multitenant app.
- [Connect the custom channel to the Azure bot resource](/azure/bot-service/bot-service-manage-channels?view=azure-bot-service-4.0&preserve-view=true).
- [Have the app ID](/azure/bot-service/abs-quickstart?view=azure-bot-service-4.0&tabs=userassigned#to-get-your-app-or-tenant-id&preserve-view=true).
- [Have the client secret value](/azure/bot-service/abs-quickstart?view=azure-bot-service-4.0&tabs=userassigned#to-generate-a-new-password&preserve-view=true).

## Configure a custom messaging channel

1. In the site map of Contact Center admin center or Customer Service admin center, go to **Customer support**, and then select **Channels**. 
1. In **Accounts**, for **Messaging accounts**, select **Manage**.

1. On the **Accounts and channels** page, select **New account**.

1. Enter the following information:

   - **Channel details**:
      - **Name**: Enter a name for the custom messaging account.
      - **Channel**: Select **Custom** from the list.
      - **Method**: Select **Azure bot framework** from the list, and then select **Next**.

   - **Account details**:
      - **Microsoft app ID**: Enter the app ID.
      - **Client secret**: Enter the client secret value.

1. Select **Validate**. After validation succeeds, select **Next**.

1. Under **Custom channel**, select **Add**.

1. Enter the following information:

   - **Name**: Enter a name for the custom messaging channel.
   - **Channel**: Select a messaging channel from the list.

1. Select **Add** to add the channel to the account.

   Add more custom channels to the same account if needed.

1. Select **Save and close**.

1. [Configure callback information](#configure-callback-information).

### Configure workstream and routing rules

1. In the admin center app, select **Workstreams**, and then [create a workstream](create-workstreams.md). Be sure to select **Messaging** for **Type** and **Custom** for **Channel**.

1. Select the workstream that you created for the custom channel.

1. Select **Set up Custom**.

1. On the **Custom channel** page, select the custom messaging account you created earlier.

1. On the **Language** page, select the required language.

1. On the **Behaviors** page, configure the following options:

   - [Custom automated messages](configure-automated-message.md)
   - [Post-conversation survey](configure-post-conversation-survey.md)

1. On the **User features** page, if you want customers or customer service representatives, or both, to [send file attachments](enable-file-attachments.md), turn on **File attachments** and select the appropriate options.

1. Verify the settings on the **Summary** page, and then select **Finish**.

1. [Configure routing rules](configure-work-classification.md).

### Configure callback information

1. Copy the value in **Messaging endpoint (URL)**.

1. In another browser tab or window, open your Azure bot resource on the **Azure Portal** > **Bot Channel Registration** page.

1. Paste the messaging endpoint URL in the **Messaging endpoint** field.

1. Select **Apply**, and then close the Azure portal.

1. Select **Save and close**.

## Next steps

[Test your custom messaging channel](../develop/test-custom-channel-sample-html.md)

### Related information

[Bring your own custom messaging channel using Direct Line](../develop/bring-your-own-channel.md)  
[Support for live chat and asynchronous channels](card-support-in-channels.md)  

[!INCLUDE [footer-include](../../includes/footer-banner.md)]
