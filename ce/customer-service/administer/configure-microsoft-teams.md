---
title: Configure Microsoft Teams channel in Omnichannel for Customer Service
description: Learn about the Microsoft Teams channel and how to configure the channel in Omnichannel for Customer Service.
ms.date: 11/01/2023
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.custom: bap-template
---
# Configure Microsoft Teams channel

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

Use Microsoft Teams as an engagement channel for support of internal functions&mdash;such as technical support, human resources, and finance&mdash;to allow organizations to connect their employees with internal support personnel by using the Omnichannel Add-in for Dynamics 365 Customer Service.

## Prerequisites

Make sure that the following prerequisites are met:

- Microsoft Teams is installed in your environment. More information: [Provision Omnichannel for Customer Service](../implement/omnichannel-provision-license.md)

  > [!NOTE]
  > To enable the Microsoft Teams channel in an existing Omnichannel for Customer Service environment, you must upgrade to the latest version of Omnichannel for Customer Service. More information: [Upgrade Omnichannel for Customer Service](../implement/upgrade-omnichannel.md)

- An app is created and configured in **Teams** > **Developer Portal**:

   1. In **Teams**, open the **Developer Portal** app.

      :::image type="content" source="../media/configure-teams-developer-portal.png" alt-text="Developer Portal app in Teams.":::
   
   1. In **Developer Portal**, create a new app or import an existing one.

       :::image type="content" source="../media/configure-teams-developer-portal-apps.png" alt-text="Create a new app or import one in Developer Portal.":::

   1. If you chose to create a new app in step 2, give it a **Name**, and then select **Add**.

   1. In the **Application (client) ID** field, enter the bot ID from omnichannel, and then fill in the required fields.
      > [!NOTE]
      > You can also create a new App Registration in Azure portal, and then use the app ID for this field.

       :::image type="content" source="../media/configure-teams-developer-portal-application-id.png" alt-text="View of Application ID field in Developer Portal.":::

   1. Select **App features** under **Configure** section, and then select **bot**.

   1. Enter the bot ID from omnichannel, and then select **Save**.

   1. Select **Publish**.

   1. On the **Publish your app** page, select **Download the app package**

   1. In the site map, select **Apps**, and then select **Manage your apps**.

   1. Select **Upload your app**, and then browse to the app you downloaded in step 7 and select it.

      The Teams app is installed on your Teams desktop client, which allows you to send and receive messages in the Teams app.  

## Configure a Microsoft Teams channel<a name="configureinoac"></a>

1. In Dynamics 365, go to one of the apps, and perform the following steps.

   ### [Customer Service admin center](#tab/customerserviceadmincenter)

    1. In the site map, in **Customer support**, select **Channels**.

    1. In **Accounts**, for **Messaging accounts**, select **Manage**.
   
   ### [Omnichannel admin center (deprecated)](#tab/omnichanneladmincenter) 

    [!INCLUDE[oac-deprecation](../../includes/oac-deprecation.md)] 

    - In the site map, in **General settings**, select **Channels**.

1. On the **Accounts and channels** page, select **New account**.

1. Enter the following details:
   1. On the **Channel details** page, enter a name and select **Microsoft Teams** in **Channels**.
   1. On the **Account details** page, in **Account name**, enter the Microsoft Teams name that you use.
   1. On the **Callback information** page, copy the value in the **Bot ID** box. The Teams app uses it to update the value for the bot ID.
   1. Select **Done**. The account is added to the list.

1. To configure routing and work distribution, go to the **Workstreams** page and create a [workstream](create-workstreams.md).

1. Select the workstream that you created for the Microsoft Teams channel, and then on the workstream page, select **Set up Microsoft Teams** to configure the following options:
    1. On the **Microsoft Teams setup** page, in the **Available Microsoft Teams accounts** list, select the number that you created.

    1. On the **Language** page, select the language.

    1. On the **Behaviors** page, configure the following options:
       - [Custom automated messages](configure-automated-message.md)
       - [Post-conversation survey](configure-post-conversation-survey.md)

    1. On the **User features** page, turn on the **File attachments** toggle, and then select the following checkboxes if you want to allow agents and customers to send and receive file attachments. More information: [Enable file attachments](enable-file-attachments.md)
       - Customers can send file attachments
       - Agents can send file attachments

    1. Turn on the toggle for **Voice and video calls** (preview), and select an option in the **Calling options** dropdown list. At runtime, when agents are in conversation with customers and need to use audio or video to resolve issues, the call and video options are available to them.

        > [!NOTE]
        > Voice and video calls in Microsoft Teams is in preview, therefore, we recommend that you don't use it in production. Use it only in test and development environments.

    1. Verify the settings on the **Summary** page, and select **Finish**. The Teams channel instance is configured.

1. Configure routing rules. More information: [Configure work classification](configure-work-classification.md)

1. Configure work distribution. More information: [Work distribution settings](create-workstreams.md#configure-work-distribution)

1. Add a bot. More information [Configure a bot](create-workstreams.md#add-a-bot-to-a-workstream)

1. In **Advanced settings**, configure the following options based on your business needs:
   - [Sessions](session-templates.md)
   - [Agent notifications](notification-templates.md#out-of-the-box-notification-templates)
   - [Context variables](manage-context-variables.md#add-context-variables)
   - [Smart assist bots](../develop/smart-assist-bot.md)
   - [Quick replies](create-quick-replies.md)

## Configure Teams details

1. In the Teams app, select the ellipses (...) and then select **Developer Portal**. The **Developer Portal** page appears.

1. On the **Apps** tab,  select the app that you configured for Omnichannel for Customer Service.

1. Select **App features** under **Configure**.

1. On the **App features** page, select **Bot**, then select **Enter a bot ID**, and paste the bot ID value.

1. Select the required options, save, preview, and publish.

  > [!NOTE]
  > If you receive an error when trying to add a bot to the team, refer to [Prepare your Microsoft 365 tenant](/microsoftteams/platform/concepts/build-and-test/prepare-your-o365-tenant).


### See also

[Channels in Omnichannel for Customer Service](../use/channels.md)  
[Configure automated messages](configure-automated-message.md)  
[Use Microsoft Teams channel](../use/teams-channel.md)  
[Delete a configured channel](delete-channel.md)  
[Support for live chat and asynchronous channels](../use/channels.md)  


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
