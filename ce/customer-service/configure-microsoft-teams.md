---
title: "Configure Microsoft Teams channel in Omnichannel for Customer Service | MicrosoftDocs"
description: "Learn about the Microsoft Teams channel and how to configure the channel in Omnichannel for Customer Service."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 12/30/2020
ms.topic: article
ms.service: "dynamics-365-customerservice"
---
# Configure a Microsoft Teams channel

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Microsoft Teams channel

Using Microsoft Teams as an engagement channel for support of internal functions&mdash;such as technical support, human resources, and finance&mdash;allows organizations to connect their employees with internal support personnel by using the Omnichannel Add-in for Dynamics 365 Customer Service.

## Prerequisites

Make sure that the following prerequisites are met:

- Teams is provisioned in your environment. More information: [Provision Omnichannel for Customer Service](omnichannel-provision-license.md)

  > [!NOTE]
  > To enable the Teams channel in an existing Omnichannel for Customer Service environment, you must upgrade to the latest version of Omnichannel for Customer Service. More information: [Upgrade Omnichannel for Customer Service](upgrade-omnichannel.md)

- An app is created and configured in **Teams** > **App Studio**.

<a name="configureteams"></a>

## Configure a Microsoft Teams channel in Omnichannel for Customer Service

### Create a Teams channel

1. In Omnichannel Administration under **Channels**, select **Teams**. The **New Teams Channel** page appears.

2. In **Step 1: Account details**, enter the following details:

   - **Name:** Specify a name for the channel.
   - **Owner:** Accept the default value, or specify a different value.

3. In **Step 2: Work distribution**, select the out-of-the-box work stream for Teams. Alternatively, you can create a [work stream](work-streams-introduction.md) for Teams and associate it with the Teams channel.

4. Select **Save**. The Teams channel is saved.

5. In **Step 3: Callback information**, copy the value that's displayed in **Bot ID**.

    > [!div class=mx-imgBorder]
    > ![Create a Teams channel](media/teams-channel.png "Create a Teams channel")

6. Optionally, on the **Automated messages** tab, [configure automated messages](configure-automated-message.md).
7. Optionally, on the **Surveys** tab, [configure a post-conversation survey](configure-post-conversation-survey.md).

### Configure Teams details

1. In the Teams app, go to **App Studio** > **Manifest editor**, and then select the app that you configured for Omnichannel for Customer Service.

2. Select the ellipsis (...), and then select **Edit**.

3. Select **Bots** > **Edit**, and then paste the **Bot ID** value in the box that appears under **Connect to a different Bot id**.

4. Make sure that you've configured the options in **App details**.

5. Select **Test and distribute**, and then select **Install** to test your app.

### Modify settings for a specific Teams account

1. In the Omnichannel Administration app, go to **Microsoft Teams** and select the account you want to modify. 

2. On the **General settings** tab, provide the following information:

    - **Language**: Select the preferred language for your Teams account.

    - **Work stream**: Select an existing work stream or create a new one.

    - **Enable file attachments for customers**: Set to **Yes** to allow customers to send file attachments to agents. Otherwise, set **No**.

    - **Enable file attachments for agents**: Set to **Yes** to allow agents to send file attachments to customers. When the agent attempts to send an attachment, the app requests the customer's consent. The attachment is stored in the customer's OneDrive. Otherwise, set **No**.  

       To learn more about attachments, see [Enable file attachments](enable-file-attachments.md).

       To learn more about uploading media in Microsoft Teams, see [Microsoft Teams documentation](https://docs.microsoft.com/microsoftteams/platform/resources/bot-v3/bots-files).

3. On the **Automated messages** tab, [configure automated messages](configure-automated-message.md).

4. On the **Surveys** tab, [configure a post-conversation survey](configure-post-conversation-survey.md).

### See also

[Channels in Omnichannel for Customer Service](channels.md)  
[Configure automated messages](configure-automated-message.md)  
[Use a Microsoft Teams channel](teams-channel.md)  
[Delete a configured channel](delete-channel.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]