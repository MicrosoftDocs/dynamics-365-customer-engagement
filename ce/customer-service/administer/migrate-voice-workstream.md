---
title: Migrate workstreams to support voice-enabled Copilots
description: Migrate workstreams to support voice-enabled Copilots.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to 
ms.collection: 
ms.date: 08/29/2024
ms.custom: bap-template
---

# Migrate workstreams to support voice-enabled Copilots

Voice-enabled Copilots provide enhanced interactive voice response (IVR) capabilities such as speech and Dual-Tone Multi-Frequency (DTMF) input, context variables, call transfer, speech, and DTMF customizations. To use these capabilities in the voice channel, you must create a new bot in Copilot Studio and add it to a workstream that the Copilot is compatible with. 

If you have an existing voice channel deployment, make sure you migrate your existing workstreams for the voice-enabled Copilots to work. Any new workstreams that you create are automatically compatible with the Copilots.

   > [!NOTE]
   > - For new voice configurations, the enhanced voice experience is available out of the box.
   > - [Data Loss Prevention](/power-platform/admin/wp-data-loss-prevention) isn't supported in the enhanced voice experience. 

## Prerequisites

- You must have an Azure Communication Services resource connected to your Dynamics 365 Customer Service instance.
- Your active Azure subscription is in the same tenant as your Dynamics 365 account.
- Have at least contributor-level permissions to the Azure subscription. To check your role, open your subscription and view the **My role** column of your subscription on the Azure portal. You must have contributor-level permissions to deploy your Azure Communication Services resource.

## How to migrate your voice workstreams

1. Create and set up an Event Grid subscription for incoming calls. For more information, refer to [Enable call incoming calls, call recording, and SMS services](voice-channel-configure-services.md).
1. [Update the event subscription in Azure](/azure/communication-services/quickstarts/events/subscribe-to-events?pivots=platform-azp#update-event-subscription) for recording webhook. Copy the value in the **Recording Web Hook Endpoint** field in the **Customer Service admin center** > **Phone Numbers** > **Advanced** > **Manage Azure Communication Services (Preview)** and paste it in the **Endpoint** field.
1. Create a [Copilot bot](/microsoft-copilot-studio/voice-build-from-template). When you migrate to the enhanced voice experience, your phone numbers are updated. The existing classic voice bots aren't supported for the updated workstreams. We recommend that you update and rename your new Copilot bots similar to your previous bots. For example, if your classic bot is named as "Returns bot", rename your voice enabled Copilot as "Returns Bot-new".
1. Run the voice update.
1. Test the voice update.

## Run the voice update

To update to the new voice experience, perform the following steps:

1. Go to Customer Service admin center and select **Channels** in **Customer support**.
1. Select **Manage** for **Voice update**. On the **Voice update** page, all the workstreams with the associated phone numbers, inbound and outbound profiles, and the corresponding migration update and test status are displayed.
1. Select the required workstream and then select **Run update**. You can select multiple workstreams to update at once. The application displays the **Replace or remove bots** page with the classic bots connected to channels either as the post call survey bot, workstream as the deflection bot, or queues as a bot agent.
    > [!NOTE]
    > - We recommend that you migrate all the workstreams that share a common queue and contain a classic bot configured.
    > - On the **Replace or remove bots** page, only those classic bots are displayed that are attached to workstreams in which route-to-queues rules are configured.
1. Select the voice-enabled Copilot that you created to replace the classic bot in the **Replacement** drop down. The application doesn't display your existing classic bots in this list.
1. Select **Run** update. The application takes at least 15 minutes to sync the changes. The application also refreshes the phone numbers associated with the workstreams in the background to be compatible with the new voice experience. The application displays the status of the update on the **Results** page.

> [!NOTE]
> Azure direct offer numbers synchronize more quickly than direct routing numbers, with calls expected to function within 15 minutes for the former, while calls to the latter can take up to 30 minutes to start functioning after the update.

## Test and revert the voice update

The test status field can be used to keep track of testing. If any call to any phone number attached to a profile or a workstream fails after 30 minutes, the application sets the **Test status** to **Failed**. You can retry the update or select the **Revert** option to go back to the original state. Expect at least 15 to 30 minutes of down time for the changes to sync after the revert. If the revert fails, select **Retry revert**  to try the revert again.
If rollback fails, the application displays a critical message to contact Microsoft Support.

### Related information

[Bring your own carrier](voice-channel-bring-your-own-number.md)  
[Overview of the voice channel](voice-channel.md)  
[Connect to Azure Communication Services](voice-channel-acs-resource.md)  
[Connect using a new Azure resource](voice-channel-connect-new-resource.md)  
[Set up outbound calling](voice-channel-outbound-calling.md)  
[Set up inbound calling](../voice-channel-route-queues.md)  
[Integrate third-party IVR systems with voice channel](voice-channel-contextual-transfer-external-ivr.md)  
