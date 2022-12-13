---
title: "Configure call recording, transcription, and real-time translation | MicrosoftDocs"
description: "Learn how to configure call recording, transcription, and real-time translation in the voice channel in Omnichannel for Customer Service."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 08/18/2022
ms.topic: article

---

# Configure call recording, transcription, and real-time translation

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

As an administrator, you can enable live translation, transcription and recording of calls, which allows agents and supervisors to view the conversations with the customers in the language that's set as the default for them, and also transcripts of customer calls.

> [!NOTE]
> Many countries and states have laws and regulations that apply to the recording of PSTN (Public Switched Telephone Network), voice, and video calls, and may require that users first consent to the recording of their communications. It is your responsibility to use the call recording and transcription capabilities in compliance with the law. Before using call recording features, you must obtain consent from the parties of recorded communications in a manner that complies with all applicable laws for each participant.


## Enable call recording and transcription for voice

1. In Customer Service admin center or Omnichannel admin center, select the workstream for which you want to enable recording and transcription.

1. In the **Phone number** section, next to the pencil icon, select **Edit**.

1. On the **Voice settings** page, select the **Behaviors** tab.
   > [!div class="mx-imgBorder"]
   > ![Screenshot of Behaviors tab on the Voice settings page.](./media/voice-channel-recording-number.png)

1. In the **Transcription and recording** section, select the **Transcript and recording** dropdown menu, and then select **Transcription** or **Transcription and recording**.

2. Under **Start setting**, set the toggle to **Automatic** if you want calls to be automatically recorded and transcribed when they begin, or **Manual** if you want agents to record and transcribe their calls.

3. Set **Allow agents to pause and resume** if you want to allow agents to control the portions of conversations that they record and transcribe.

4. Select **Save**.

## Enable real-time translation of calls

To view translated voice transcripts for calls, you must enable call recording, transcription, and real-time translation. To enable real-time translation, see [Enable real-time translation for agent and customer conversations](enable-real-time-translation.md#enable-real-time-translation-for-agent-and-customer-conversations)

## View call transcripts

You can view the call transcripts in Customer Service admin center or Omnichannel admin center.

1. In Customer Service admin center or Omnichannel admin center, go to manage **Users**, and then select the user whose conversations you want to view.
2. Select the **Related** tab, and then select **Conversations** from the dropdown menu.
3. Select **Closed conversations** from the dashboard dropdown menu.

   > [!div class="mx-imgBorder"]
   > ![Screenshot of closed conversation option on dashboard dropdown menu.](./media/voice-closed-conversations.png)

4. Select the conversation for which you want to access the recording and transcript.
  
   > [!div class="mx-imgBorder"]
   > ![Screenshot of closed conversation list.](./media/voice-channel-conversations-list.png)

## Delete call recordings

1. In Customer Service admin center, select the **Advanced Find** icon displayed on the menu.
1. On the **Advanced Find** page, select **Recordings** in the **Look for** dropdown list. More information: [Create, edit, or save an Advanced Find](/dynamics365/customerengagement/on-premises/basics/save-advanced-find-search)
1. Select the required recording.
1. Select the **Delete** icon.

Alternatively, you can delete the recordings from the [msdyn_ocrecording](developer/reference/entities/msdyn_ocrecording.md) entity by using the [DELETE](/power-apps/developer/data-platform/webapi/update-delete-entities-using-web-api) request.


### Storage location of your recordings and cost

The maximum file size of a recording can be 512 MB. The voice recording and transcript data resides in the following locations:

- **Data at rest**: Is stored in Dataverse wherever your Dynamics instance is located.
- **Data in transit**: For components within the Microsoft stack, we strive to ensure that data doesn’t cross geographical boundaries during transit. The bring-your-own-carrier model has dependencies on third parties, and therefore, data needs to be reviewed end-to-end and will include components outside the Microsoft stack.

The data storage costs with two participants only is calculated approximately as follows and the cost can fluctuate:

- 20-minute call recording = 10240 KB
- 20-minute call transcript = 40 KB

### See also

[Overview of the voice channel](voice-channel.md)  
[Agent experience: View call recordings and transcripts](voice-channel-agent-experience.md)  
[Enable call recording and SMS services](voice-channel-connect-existing-resource.md#enable-call-recording-and-sms-services)  
[Supported cloud locations, languages, and locale codes](voice-channel-region-availability.md)  
  
[!INCLUDE[footer-include](../includes/footer-banner.md)]
