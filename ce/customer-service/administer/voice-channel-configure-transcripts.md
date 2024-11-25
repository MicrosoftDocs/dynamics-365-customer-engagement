---
title: Configure call recording, transcription, and real-time translation 
description: Learn how to configure call recording, transcription, and real-time translation in the voice channel.
author: neeranelli
ms.author: nenellim
ms.reviwer: nenellim
ms.date: 08/29/2024
ms.topic: how-to
ms.custom: bap-template
---

# Configure call recording, transcription, and real-time translation


[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]


[!INCLUDE[pva-rebrand](../../includes/cc-pva-rebrand.md)]

As an administrator, you can enable live translation, transcription, and recording of calls. These options allow agents and supervisors to view the conversations with the customers in the language that's set as the default for them, and also transcripts of customer calls.

> [!IMPORTANT]
> - Many countries and states have laws and regulations that apply to the recording of PSTN (Public Switched Telephone Network), voice, and video calls, and may require that users first consent to the recording of their communications. It is your responsibility to use the call recording and transcription capabilities in compliance with the law. Before using call recording features, you must obtain consent from the parties of recorded communications in a manner that complies with all applicable laws for each participant.
> - If you use Copilot Studio bots as the interactive voice response (IVR) with the voice channel, the calls are transcribed in Copilot Studio even if the transcription and recording setting isn't enabled in the voice workstream.

## Enable call recording and transcription for voice
1. To enable call recording and transcription for voice, you must first configure your applications to listen to Azure Communication Services events by registering Event Grid system topics. For more information, refer to [Enable call recording and SMS services](voice-channel-configure-services.md).
   
1. In the Customer Service admin center or Contact Center admin center app, select the workstream for which you want to enable recording and transcription.

1. In the **Phone number** section, next to the pencil icon, select **Edit**.

1. On the **Voice settings** page, select the **Behaviors** tab.
   > [!div class="mx-imgBorder"]
   > ![Screenshot of Behaviors tab on the Voice settings page.](../media/voice-channel-recording-number.png)

1. In the **Transcription and recording** section, select the **Transcript and recording** dropdown menu, and then select **Transcription** or **Transcription and recording**.

1. Under **Start setting**, set the toggle to **Automatic** if you want calls to be automatically recorded and transcribed when they begin, or **Manual** if you want agents to record and transcribe their calls.

1. Set **Allow agents to pause and resume** toggle to **Yes** if you want to allow agents to control the portions of conversations that they record and transcribe.

1. Set **Allow automatic pause and resume when agent hold and un-hold the customer** toggle to **Yes** if recording and transcription must be paused when the agent puts the customer on hold and resumed when the agents takes the customer off hold.

1. Select **Save**.

## Enable real-time translation of calls

To view translated voice transcripts for calls, you must enable call recording, transcription, and real-time translation. To enable real-time translation, refer to [Enable real-time translation for agent and customer conversations](enable-real-time-translation.md#enable-real-time-translation-for-agent-and-customer-conversations)

## View call transcripts

You can view the call transcripts in Customer Service admin center or Contact Center admin center.

> [!NOTE]
> You can view call transcripts in Customer Service workspace and Contact Center workspace only. 


1. In the site map, go to manage **Users**, and then select the user whose conversations you want to view.
2. Select the **Related** tab, and then select **Conversations** from the dropdown menu.
3. Select **Closed conversations** from the dashboard dropdown menu.

   > [!div class="mx-imgBorder"]
   > ![Screenshot of closed conversation option on dashboard dropdown menu.](../media/voice-closed-conversations.png)

4. Select the conversation for which you want to access the recording and transcript.
  
   > [!div class="mx-imgBorder"]
   > ![Screenshot of closed conversation list.](../media/voice-channel-conversations-list.png)

### Storage location of your recordings and cost
 
For components within the Microsoft stack, the data doesn’t cross geographical boundaries during transit. The bring-your-own-carrier model has dependencies on third parties with components outside the Microsoft stack, and the data needs to be reviewed end-to-end. 
The components can be in a different geographic location from the Azure Communication Services location as shown in the following illustration.


:::image type="content" source="../media/vc-data-residency.png" alt-text="Storage location information" lightbox="../media/vc-data-residency-enlarged.png":::

**Legend**

| Number | Description |
|-----|-------------------|
|1 | **Session Border Controller**<br>  For Microsoft calling plans where Microsoft is the carrier, Microsoft determines the location to store data.<br> **Direct Routing**:  For the bring-your-own-carrier model, the data resides in the region where the Session Border Controller is hosted. |
|2 | **Azure Communication Services**:<br>  The data resides in the location where the Azure Communication Services subscription is acquired. |
|3 | **Microsoft Dataverse**:<br>  The Microsoft Dataverse server location, Dynamics 365 tenant, Cosmos DB, and Azure Speech Service should all be in the same location chosen during purchase. |
|4 | **Kusto**:<br> Microsoft stores the data for telemetry in Kusto, which is located either in the EMEA or the East US cluster. |


The maximum file size of a recording can be 512 MB. The data storage cost with two participants only is calculated approximately as follows, and the cost can fluctuate:

- 20-minute call recording = 10240 KB
- 20-minute call transcript = 40 KB


### Related information

[Overview of the voice channel](voice-channel.md)  
[Agent experience: View call recordings and transcripts](/dynamics365/contact-center/use/voice-channel-agent-experience)    
[Enable call recording and SMS services](voice-channel-configure-services.md)
[Supported cloud locations, languages, and locale codes](voice-channel-region-availability.md)  
[Delete call recordings](voice-channel-delete-calls.md)
  
[!INCLUDE[footer-include](../../includes/footer-banner.md)]
