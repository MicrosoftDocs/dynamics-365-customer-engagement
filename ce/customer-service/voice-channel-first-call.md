---
title: "Make and receive your first phone call in the voice channel | MicrosoftDocs"
description: "Learn how to use the first-run experience of the voice channel in Omnichannel for Customer Service."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 08/13/2021
ms.topic: article
ms.service: dynamics-365-customerservice
ROBOTS: NOINDEX,NOFOLLOW
---


# Preview: Get your first phone call

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

> [!IMPORTANT]
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]
>
> [!INCLUDE[cc-preview-features-send-us-feedback](../includes/cc-preview-features-send-us-feedback.md)]

When you want to try the voice channel for the first time in your org, the system sets it up for you to have the first-run experience. The tasks in this section take you through the automatic setup steps.

> [!NOTE]
> If you want to run the first phone call with a bot experience, the bot must be configured in Power Virtual Agents, published, and registered in Azure. The bot must be enabled for the environment in which you try the phone call. You might need to sign into [Power Virtual Agents](https://powerva.microsoft.com/environments) and select the right environment. More information: [Working with environments in Power Virtual Agents](/power-virtual-agents/environments-first-run-experience).

## Set up voice demo

1. In the **Omnichannel admin center (preview)** app, go to the Home page.

    ![Omnichannel admin center home page.](media/image9.png "Omnichannel admin center home page.")

1. On the **Try out live chat and voice calls** page, select **Set up voice demo**. You're directed to the setup page. The demo set up is automatic; however, you can watch the progress on the **We're setting up your voice demo** page.

    > [!Note]
    > If someone in your org has already tried the first run experience, you'll see **Try voice** instead of **Set up voice demo**.

    ![Setting up the voice demo.](media/image10.png)

1.  After the demo is set up, the **Try out voice** page displays the option to **Open voice demo** and the settings that have been configured.

    ![Try out voice.](media/image11.png)

## Try out voice

1. On the **Try out voice** page, select **Open voice demo**.

    ![Voice call demo.](media/image12.png)

1. On the **Voice call demo** page, select **Open agent experience**. The Omnichannel for Customer Service app opens on a new tab.

2. Follow the instructions that appear on the **Voice call demo** page to try the agent and customer experience.

3. Use a phone to initiate a call to the number listed on the **Voice call demo** page.

    > [!IMPORTANT]
    > In the Omnichannel for Customer Service app, when the call comes in, you may be prompted for microphone permissions. Select **Allow** on the pop-up window.

    ![Allow browser to use microphone.](media/image13.png)

1. Select **Accept** on the incoming phone call to receive the call as an agent, and try the following through the call controls:

    - Mute and hold

    - See live call transcription and sentiment

    - Take notes (in the overflow)

    - Consult and transfer if other Omnichannel for Customer Service agents are signed in to the same environment

## View the demo settings

Perform the following steps to see the settings that have been automatically configured by the system for the voice demo:

1. On the **Try out live chat and voice calls** page, select **Try voice**.

2. On the page that appears, select **View** for each step to see the settings that have been automatically configured as part of the demo.

3. If you select **View** in the **Workstream, Phone number acquisition, or Voice channel** area, the workstream, routing rule, and work distribution settings that were configured as part of the demo setup are displayed.

4. If you select **View** in the **Queue** area, the queue information is displayed.


### See also

[Overview of the voice channel](voice-channel.md)  
