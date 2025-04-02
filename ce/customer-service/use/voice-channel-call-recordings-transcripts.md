---
title: View call recording and transcripts for voice channel
description: Use this article to learn how to view call recordings and transcripts.
ms.date: 04/04/2025
ms.topic: how-to
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.custom: bap-template
---

# View call recordings and transcripts

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]

When conversations end in your contact center, users can view the recordings and transcripts of those conversations and the following details:
- Sentiment analysis
- Key metrics
- AI summary
- Post-call survey results
- Sessions that are part of the conversation
- AI summary on voicemails of the entire transcript

> [!NOTE]
> Many countries/regions and states have laws and regulations that apply to the recording of public switched telephone network (PSTN), voice, and video calls, and requires that users first consent to the recording of their communications. It is your responsibility to use the call recording capabilities in compliance with the law. Before using call recording features, you must obtain consent from the parties of recorded communications in a manner that complies with all applicable laws for each participant.

## Prerequisites

- Call recordings and transcripts are enabled by your administrator.
- Omnichannel agent or Omnichannel supervisor role.
- To access recordings and transcripts, users with other roles need at least read-level access to the **Activity** table
- To view conversation summaries, users with other roles need at least read-level access to the **ConversationInsights** table. Conversation 
- To view post-conversation survey data, users need read-level access to the **Customer feedback survey** table; Omnichannel Administrator role has the access by default.

## View recordings and transcripts

Customer service representatives (service representative or representative) and supervisors can view closed conversations. Service representatives can view their closed conversations from the Inbox. Supervisors can see a list of all closed conversations in the **Activities** view and filter by **Conversations**. 

Users with the System Administrator role can access conversations that are handled by other service representatives.

## Call recording and transcript controls

The **Details** tab of the **Conversation - Conversation Form** displays the call recording details.

:::image type="content" source="../media/voice-channel-recording.png" alt-text="Screenshot of call recording and transcript controls." lightbox="../media/voice-channel-recording.png:::

The **Overview** bar on the **Conversation Form** displays the following details:
- **Channel**: The type of communication conducted.
- **Status**: The state of the communication.
- **Queue**: The queue the call was conducted in.
- **Workstream**: The workstream the call was conducted in.
- **Skills**: The list of agent skills.
- **Regarding**: The link to the case or customer record.


**Recording playback**

- **Play**: Select the button to listen to the conversation audio.
- **Rewind** or **Fast-forward**: Select the buttons to either rewind in 10-second increments or fast-forward in 30-second increments.
- **Volume**: Move the slider to adjust the volume to your required level.
- **Download audio**: Download an .mp4 audio file of the complete conversation.
- **Speed**: From the dropdown menu, select the playback speed of the conversation, whether slower or faster. **Normal** is the default, and is the speed in which the conversation was recorded.
- **Conversation scroll bar**: Move the scroll bar to any point of the conversation, or listen to it from beginning to end. When you select a location in the recording visualization, the transcript also moves to the same place in the conversation.

**Summary**

- If a summary was generated at the time of call end, that summary appears.  If no summary was generated when the call ended, such as the call ended with an AI agent, then a new summary is generated when the transcript viewer appears.

> [!NOTE]
> If you open the conversation before the transcription is processed, the summary isn't available; refresh the summary when the transcription appears.


**Transcript**

- **Search**: Enter keywords in the search field to locate the required sections of the conversation.
- **Download transcript**: Open an HTML file of the conversation transcript in your browser.
  
   > [!NOTE]
   > Inline images and rendering of videos is not supported in downloaded transcripts.

The **Metrics** tab of the Conversation Form displays the following details:

- **Sentiment**: The average sentiment of the call.
- **Talking speed**: The rate of speed in which participants conversed during the call.
- **Talk to listen ratio**: The ratio in which the representative spoke versus listened to the customer.
- **Average pause**: The average amount of time in which the conversation was paused.
- **Longest customer monologue**: The longest amount of time that the customer spoke during the conversation.
- **Switches per conversation**: The number of times the conversation switched from representative to customer, and vice versa.

The Post-conversation survey tab of the Conversation Form can be enabled for all conversations in CSAC under Workspaces->Voice call experiences (note: Omnichannel Supervisor role does not have access to view surveys):

The **Sessions** tab displays details about the number of voice calls between the representative and customer, and the duration, date, and time of the conversation.

### Related information

[Agent experience of voice calls and agent dashboard](/dynamics365/contact-center/use/voice-channel-agent-experience)    
[Call a customer](voice-channel-call-customer.md)  
[View and understand call summary page in the Sales Hub app](../../sales/view-and-understand-call-summary-sales-app.md)  
