---
title: "Use agent dashboard and call controls in the voice channel | MicrosoftDocs"
description: "Use this topic to understand how the agent can use the agent dashboard, use call controls, and also make and receive customer calls in Omnichannel for Customer Service."
ms.date: 03/09/2022
ms.service: dynamics-365-customerservice
ms.topic: article
author: gandhamm
ms.author: mgandham
manager: shujoshi
---

# Use agent dashboard and call controls in the voice channel

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

One of the main value propositions of the Omnichannel for Customer Service voice channel is that it's integrated directly with Dynamics 365; this integration is presented by way of the agent dashboard. The dashboard offers the agent a consolidated view of the calling interface, the customer summary, case history, and timeline. This helps the agent provide quick, effective, and proactive solutions to customer issues. At the same time, the agent experience in the voice channel is similar to the chat, SMS, and other social channels, thereby reducing any agent training time and costs.

## Make and receive customer calls

You can call a customer either using the phone dialer on the customer summary page or the launch dialer button on the Omnichannel for Customer Service menu bar. More information: [Call a customer](voice-channel-call-customer.md)

When a customer calls your business, the incoming call is received by an intelligent bot. The bot gathers basic information about the customer issue and then transfers the call to you for further action. You'll receive a notification about the incoming call on your agent desktop so you can accept it. The following section describes the call controls and other features you can use during your conversation.

## Call controls

The conversation panel in the agent dashboard includes the following call controls that you can use when you call or answer phone calls from customers.

> [!div class="mx-imgBorder"]
> ![Screenshot of call controls](./media/voice-channel-call-controls.png)

- **Mute**: Select to mute your microphone so your voice isn't audible to the customer.
- **Hold**: Select to put the customer on hold; the customer hears the hold music.
- **Consult**: Select to consult or bring in another agent or supervisor into the call. You can have a *public* consultation where the customer is actively involved in the conversation. You can also have a *private* consultation where you can put the customer on hold before you talk to your peers or supervisor.
- **Transfer (to agent or queue)**: Select to transfer the call to another agent or queue. During a transfer to queue, the customer is automatically put on hold.
- **End**: Select to end the call.
- **Show number pad**: Select to open the number pad, so you can dial an extension number, when required.
- **Mark number as spam**: Select to [report the incoming call as spam](#report-a-phone-number-as-spam). If you happened to accidentally mark a number as spam, you can select the **Unmark as spam** option.
- **Device settings**: Configure your microphone and speaker settings.
- **Take notes**: You can take any important or specific notes regarding your conversation with the customer. Note that this is in addition to the call recording and transcription that happen during the conversation.
- **Pause recording and transcription**: If you don't want to capture some details of the conversation, such as bank details, billing, or payment information, you can temporarily pause the transcription and later resume it.
- **Knowledge Articles**: Select this option to get a list of knowledge base articles pertaining to the conversation that you can use to resolve the customer issue.
- **Link to conversation**: You can link another conversation, case, or knowledge article to the conversation.
- **Transcription**: When transcription and recording service is enabled by your administrator, all of the conversation between you and the customer is automatically transcribed in real time, which means that the you as an agent don't need to take notes during the call. This feature also helps your supervisor or agent (in case of a call transfer) to see the call history.
- **Sentiment analysis**: The transcript also powers *live* sentiment analysis. This means that you or your supervisor can instantly view and gauge the customer mood and feeling via the sentiment icons.

## Report a phone number as spam

When you receive a phone call and want to report the number as spam while on the call, you can do so immediately via the call controls on your conversation panel. A notification is then sent to your administrator for review and further action.

To report a phone number as spam, select the ellipsis to open more actions, and then select **Mark number as spam**.

You can add notes to help your administrator review and block numbers. After you mark a number as spam, it goes into the pending review tab on the **Blocked numbers** page.

## Consult with Microsoft Teams users

If your administrator has enabled the option for you to consult with subject matter experts (SMEs) through Microsoft Teams, you can contact them by navigating to the Teams tab in the **Consult** section of the communication panel. Your supervisor can monitor the calls and after the call ends, the call recording and transcript of the conversation with the Microsoft Teams user is saved in Dynamics 365 for reporting and compliance.

Do the following steps to consult while you're on a call:

1. Select the **Consult** option, and go to the **Teams** tab in the **Consult** section that appears.

2. Use the search option to search for an SME. The results are filtered by the name and live presence in Microsoft Teams.

3. Select **Add** for the SME you want to consult. The SME will receive a call in Microsoft Teams.

4. Optionally, you can transfer the call to the SME.

## Use chat consult with other agents and transfer calls

You can use the chat consult option to contact another agent and consult with them for questions that you might have when you are on a call with a customer.

**To use chat consult and transfer the call**

1. On the call window, select the consult option. The **Consult** pop-up dialog appears.

1. Search for the agent that you want to chat with and select chat for the required agent. A consult notification appears for the secondary agent that you select.

1. When the secondary accepts the consult request, a consult pane appears for you and the secondary agent. You can send exchange your messages in this consult pane. More information: [Consult experience](oc-conversation-control.md#consult-with-agent-or-supervisor)

1. If you want to transfer the call to the secondary agent, select the transfer option on the call window. A notification goes to the secondary agent and the call is transferred after the agent accepts the transfer request. The secondary agent becomes the primary agent and you will be disconnected from the call and consult pane with no option to send any further messages.

### See also

[Overview of the voice channel](voice-channel.md)  
[Enable voice consult with Microsoft Teams users](voice-consult-microsoft-teams-user.md)  
[Make and receive your first call](voice-channel-first-call.md)  
[Call a customer](voice-channel-call-customer.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
