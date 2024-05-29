---
title: Migrate to enhanced voice stack
description: Learn how to migrate to the enhanced voice stack
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to .
ms.collection: 
ms.date: 05/23/2024
ms.custom: bap-template
---


# Migrate to vNext

You can upgrade your existing voice stack to the enhanced voice stack with minimal disruptions to your contact center operations. With the enhanced voice stack, you can connect to the Copilot Studio bot with enhanced interactive voice response capabilities, including speech and Dual-Tone Multi-Frequency (DTMF) input, context variables, call transfer, speech and DTMF customization.

## Prerequisites

- You must have an Azure Communication Services resource connected to your Dynamics 365 Customer Service instance.
- Your active Azure subscription is in the same tenant as your Dynamics 365 account.
- Your role has **Contributor** privileges.

## Migration steps

1. Create and setup an event grid subscription for incoming calls. See [Enable incoming calls, call recording, and SMS services](config-acs-voice.md#enable-incoming-calls-call-recording-and-sms-services)
1. [Update the event subscription in Azure](/azure/communication-services/quickstarts/events/subscribe-to-events?pivots=platform-azp#update-event-subscription) for recording webhook. Copy the value in the **Recording Web Hook Endpoint** field in the **Customer Service admin center** > **Phone Numbers** > **Advanced** > **Manage Azure Communication Services (Preview)** and paste it in the **Endpoint** field.
1. Classic bots aren't compatible with the updated voice stack. Therefore, you should copy your classic bots to the voice Copilot bots.  To avoid confusion, we suggest naming your existing classic bots and the newly migrated Copilot bots in a similar manner.
1. [Run the voice update](#run-the-voice-update).
1. Test the voice update.

## Run the voice update
To update to the new voice experience, perform the following steps:

1. Go to Customer Service admin center and select **Channels** in **Customer support**.
1. Select **Manage** for **Voice update**. In the Voice update page, all the workstreams with the associated phone numbers, inbound and outbound profiles, and the corresponding migration update and test status are displayed.
1. Select the required workstream and then select **Run update**.
    > [!NOTE]
    > We recommend that you migrate all the workstreams that share a common queue and have a Copilot classic bot configured.
1. In the **Replace or remove bots** page, the Copilot Studio classic bots that are connected to channels as post call survey bots, workstream as the deflection bots, or queues as a bot agents are displayed.
1. Select the new Copilot Studio bot that you’ve created to replace the classic bot.
1. Select **Run** update. The application takes at least 15 minutes to sync the changes. The application also refreshes the phone numbers associated with the workstreams in the background to be compatible with the new voice stack.
1. On the **Results** page, the application displays the update status and if the update has succeeded or failed.

> [!NOTE]
> Azure direct offer numbers synchronize more quickly than direct routing numbers, with calls expected to function within 15 minutes for the former, while calls to the latter can potentially fail for up to 30 minutes after the update.

## Test and revert the voice update

The test status field can be used to keep track of testing.  If any call to any phone number attached to a profile or a workstream fails after 30 minutes, the application sets the **Test status** to **Failed**. You can retry the update or select the **Revert** option to go back to the original stat. There will be at least a 15 to 30 minutes downtime for the changes to sync after the revert. If the revert fails, select **Retry revert**  to try the revert again.
If roll back fails, a critical error message appears.


> - 

## Next steps

<!--Remove all the comments in this template before you sign-off or merge to the main branch.-->
