---
title: Use agent dashboard and call controls in the voice channel
description: Learn how you can use the agent dashboard, call controls, and make and receive customer calls.
ms.date: 06/14/2024
ms.service: dynamics-365-customerservice
ms.topic: how-to
author: gandhamm
ms.author: mgandham
ms.reviewer: nenellim
ms.custom: bap-template
---

# Use agent dashboard and call controls in the voice channel


[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

The voice channel is integrated directly with Dynamics 365 by way of the agent dashboard. The dashboard offers you a consolidated view of the calling interface, the customer summary, case history, and timeline. The dashboard helps you provide quick, effective, and proactive solutions to customer issues. The agent experience in the voice channel is similar to the chat and other channels, which reduces agent training time and costs.

## Make and receive customer calls

You can call a customer by using the phone dialer on the **Active Conversation** page or the **Launch dialer** button on the menu. More information: [Call a customer](voice-channel-call-customer.md)

When a customer calls your business, an intelligent bot receives the incoming call. The bot gathers basic information about the customer issue and then transfers the call to you for further action. You receive a notification about the incoming call on your agent desktop so you can accept it. The following section describes the call controls and other features you can use during your conversation.

## Call controls

The conversation panel in the agent dashboard includes the following call controls that you can use when you call or answer phone calls from customers.

> [!div class="mx-imgBorder"]
> ![Screenshot of call controls.](../media/voice-channel-call-controls.png)

- **Mute**: Mute your microphone so your voice isn't audible to the customer.
- **Hold**: Puts the customer on hold. The customer hears the hold music. You can keep only one caller on hold at a time. 
To avoid the recording and transcription of what you say while the customer is on hold, your administrator can enable the **Allow automatic pause and resume when agents hold and un-hold the customer** option. With this option, recording and transcription are paused when you put the customer on hold and resumed when you remove the customer from hold. If the option is disabled, you must manually pause and resume the recording and transcription.
- **Consult**: Select this option to consult with a participant. You can consult with or bring another agent or supervisor into the call. You can have a *public* consultation, where the customer is actively involved in the conversation. Or you can have a *private* consultation, where you can put the customer on hold before you talk to your peers or supervisor.

  > [!NOTE]
  > -  When you initiate a consult, you are the primary agent and the new participant has a consult role. Select **Transfer** next to the participant to transfer the call to the consulting agent or supervisor. Once the call is transferred, you're the consulting agent and can leave the call without ending the call. The consulting agent becomes the primary agent. If the primary agent leaves the call, the call ends for the customer.
  > - Consulting on a call doesn't affect the collaborating agent's capacity.
- **Transfer**: Select this option is to transfer the call to an agent, queue, a Teams user, or an external phone number. After you transfer the call, the agent to whom the call is transferred is the primary agent and you'll no longer be on the call.
    During a transfer to the queue, the customer is automatically put on hold. When you transfer a call to another agent, your number is displayed on the caller ID. The transcription and recording of transferred calls continue if the administrator enabled the [option](../administer/voice-channel-configure-transcripts.md#enable-call-recording-and-transcription-for-voice). You can disable recording from the dashboard. See: [Transfer and consult scenarios](voice-channel-transfer-consult.md)
- **Rejoin**: Select this option to rejoin the call. If you're disconnected from the call, you can rejoin the call from the Active Conversation form directly, instead of refreshing the page and then rejoining the call. Only primary agents see the **Rejoin** option. If the customer ends the call or the call is rerouted to the next available agent while you are disconnected, you'll hear a message that the customer ended the call or was rerouted on selecting **Rejoin**.
- **End**: End the call.
- **Dialpad**: Select this option to dial an extension number. If you must use the dial pad to send a response while navigating an IVR, select the dial pad icon next to the external participant in the participant list.
- **Mark spam**: [Report the incoming call as spam](#report-a-phone-number-as-spam). If you happened to accidentally mark a number as spam, you can select the **Unmark as spam** option.
- **Device settings**: Configure your microphone and speaker settings.
- **Take notes**:  Make note of important information or specific details from your conversation with the customer. It's in addition to the call recording and transcription that happen during the conversation. See [take notes specific to the conversation](../use/oc-take-notes.md).
- - **Start recording and transcript**: If your administrator enabled the recording and transcription service, you can start recording and transcription of the call.
- **Pause recording and transcription**: If you don't want to capture some details of the conversation—such as bank details, billing, or payment information—you can temporarily pause the transcription and resume it later.
- **Knowledge Articles**: Get a list of knowledge base articles pertaining to the conversation that you can use to resolve the customer issue.
- **Link to conversation**: You can link another conversation, case, customer, or knowledge article to the conversation.

  > [!NOTE]
  > The **Link to conversation** button is disabled after you end the voice call. Open account or contact on a new tab and select **Link to conversation** to link record (customer or case) to conversation.

- **Transcription**: When your administrator enables the transcription and recording service, the conversation between you and the customer is automatically transcribed in real time. This means that you don't need to take notes during the call. This feature also helps your supervisor or agent (in a call transfer) to see the call history.
   - **Hide Transcript**: You can hide the transcript if you don't want to see it during the call. Select **Show Transcript** to display the transcript again.
- **Sentiment analysis**: The transcript also powers *live* sentiment analysis. This means that you or your supervisor can instantly view and gauge the customer's mood and feeling via the sentiment icons.

## Report a phone number as spam

You can report a phone number as a spam call while you're on the call by using the call controls on the conversation panel. A notification is then sent to your administrator for review and further action.

To report a phone number as spam, select **Mark spam**.

You can add notes to help your administrator review and block numbers. After you mark a number as spam, it goes into the pending review tab on the **Blocked numbers** page.

## How to avoid call disconnection

Avoid the following actions to prevent call drops:

- Refresh your browser or select browser bookmark icons when you're in an active call. When you select refresh, and then select leave on the confirm refresh dialog, the page unloads and you're disconnected from the call. The customer hears hold music until you rejoin the call from the **My work items** section of **Omnichannel Agent Dashboard**. If you're disconnected from your browser for more than 90 seconds the call is reassigned to another agent in the queue. The call isn't reassigned if you reconnect within 90 seconds.
- Open other apps that need access to the microphone. It results in loss of your audio connection, and the customer can't hear you.
- Open the Customer Service workspace or Contact Center workspace app in more than one tab in the browser. It causes issues in agent presence.
- Close the session directly to end call. If you do, the conversation moves from active to wrap up. Then if you close the session, the state goes from wrap up to closed. So, we recommend that you go through the conversation status route and select the **End** button and then close the session to take care of the wrap-up activities.

## Share feedback on call quality

When you end a call, if your administrator has enabled the [agent call quality feedback survey](../administer/configure-end-of-call-survey.md), the application displays a survey that asks you to rate the call quality on a scale of 1 to 5. The survey can appear after every call or at a frequency set by your administrator. A response of 1 indicates an imperfect call experience and 5 indicates a perfect call.

If you specify a rating between 1 and 4, the application displays a set of predefined options such as, "I couldn't hear any sound", "Volume was low", or "the call ended unexpectedly",  that you can use to provide additional feedback about the call quality

## Best practices

- Make sure that you enabled notifications, and audio and video options in the browser.
- When your shift ends, ensure that you sign out and close your browser through which you access Customer Service workspace or Contact Center workspace. Doing so helps avoid work items being incorrectly assigned to you.
- When you face network or hardware issues, the application displays error or warning messages on the communication panel. Use the information in the messages to resolve the problems. More information: [Use diagnostic messages to troubleshoot call issues](/troubleshoot/dynamics-365/customer-service/omnichannel-for-customer-service/use-diagnostic-messages-in-call-issues)

### Related information

[Overview of the voice channel](../administer/voice-channel.md)  
[Enable voice consult with Microsoft Teams users](../administer/voice-consult-microsoft-teams-user.md)  
[Call a customer](voice-channel-call-customer.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
