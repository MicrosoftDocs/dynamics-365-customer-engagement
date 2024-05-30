---
title: Migrate 
description: Migrate workstreams to support voice-enabled Copilots
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to 
ms.collection: 
ms.date: 05/23/2024
ms.custom: bap-template
---

# Migrate workstreams to support voice-enabled Copilots

Voice-enabled Copilots provide enhanced interactive voice response (IVR) capabilities such as speech and Dual-Tone Multi-Frequency (DTMF) input, context variables, call transfer, speech, and DTMF customizations. To use these capabilities in the voice channel, you must create a new bot in Copilot Studio and add it to workstream that the bot is compatible with. 

If you are an existing voice channel user, make sure you migrate your workstreams for the enhanced voice bots to work.

   > [!NOTE]
   > The enhanced voice experience is available out of the box for new customers.

## Prerequisites

- You must have an Azure Communication Services resource connected to your Dynamics 365 Customer Service instance.
- Your active Azure subscription is in the same tenant as your Dynamics 365 account.
- Have at least contributor-level permissions to the Azure subscription. To check your role, open your subscription and view the **My role** column of your subscription on the Azure portal. You'll be able to deploy your Azure Communication Services resource only if you have contributor-level permissions.

## How to migrate your workstreams

1. Create and set up an event grid subscription for incoming calls. See [Enable incoming calls, call recording, and SMS services](voice-channel-connect-new-resource.md#enable-incoming-calls-call-recording-and-sms-services)
1. [Update the event subscription in Azure](/azure/communication-services/quickstarts/events/subscribe-to-events?pivots=platform-azp#update-event-subscription) for recording webhook. Copy the value in the **Recording Web Hook Endpoint** field in the **Customer Service admin center** > **Phone Numbers** > **Advanced** > **Manage Azure Communication Services (Preview)** and paste it in the **Endpoint** field.
1. Create a [new Copilot bot](/microsoft-copilot-studio/voice-get-started). When you migrate to the new voice experience, your phone numbers are updated. The existing classic voice bots aren't supported for the updated workstreams. We recommend that you update and rename your new Copilot bots similar to your previous bots. For example, if your Copilot classic bot is Returns bot, we recommend that you rename your Copilot Studio bot as Returns Bot-new.
1. Run the voice update for workstreams.
1. Test the voice update.

## Run the voice update
To update to the new voice experience, perform the following steps:

1. Go to Customer Service admin center and select **Channels** in **Customer support**.
1. Select **Manage** for **Voice update**. In the Voice update page, all the workstreams with the associated phone numbers, inbound and outbound profiles, and the corresponding migration update and test status are displayed.
1. Select the required workstream and then select **Run update**.
    > [!NOTE]
    > We recommend that you migrate all the workstreams that share a common queue and have a Copilot classic bot configured.
1. In the **Replace or remove bots** page, the Copilot Studio classic bots that are connected to channels as post call survey bots, workstream as the deflection bots, or queues as bot agents are displayed. The application doesn't display your existing Copilot Studio bots in this list.
1. Select the new Copilot Studio bot that you created to replace the classic bot.
1. Select **Run** update. The application takes at least 15 minutes to sync the changes. The application also refreshes the phone numbers associated with the workstreams in the background to be compatible with the new voice stack.
1. On the **Results** page, the application displays the status of the update.

> [!NOTE]
> Azure direct offer numbers synchronize more quickly than direct routing numbers, with calls expected to function within 15 minutes for the former, while calls to the latter can potentially fail for up to 30 minutes after the update.

## Test and revert the voice update

The test status field can be used to keep track of testing. If any call to any phone number attached to a profile or a workstream fails after 30 minutes, the application sets the **Test status** to **Failed**. You can retry the update or select the **Revert** option to go back to the original stat. There will be at least a 15 to 30 minutes downtime for the changes to sync after the revert. If the revert fails, select **Retry revert**  to try the revert again.
If roll back fails, a critical error message appears.

### See also

[Bring your own carrier](voice-channel-bring-your-own-number.md)  
[Overview of the voice channel](voice-channel.md)  
[Connect to Azure Communication Services](voice-channel-acs-resource.md)  
[Connect using a new Azure resource](voice-channel-connect-new-resource.md)  
[Set up outbound calling](voice-channel-outbound-calling.md)  
[Set up inbound calling](../voice-channel-route-queues.md)  
[Integrate third-party IVR systems with voice channel](voice-channel-contextual-transfer-external-ivr.md)  
