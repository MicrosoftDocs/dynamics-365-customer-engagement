---
title: View conversation transcripts and call recordings
description: Use this article to learn how to view conversation transcripts and call recordings.
ms.date: 11/07/2025
ms.topic: how-to
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.custom: bap-template
---

# View conversation transcripts and call recordings

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]

When conversations end in your contact center, users can view the recordings and transcripts of those conversations and the following details:

- Sentiment analysis
- Key metrics
- AI summary
- Post-conversation survey results
- Sessions that are part of the conversation
- AI summary on voicemails of the entire transcript

> [!NOTE]
> Many countries/regions and states have laws and regulations that apply to the recording of public switched telephone network (PSTN), voice, and video calls, and requires that users first consent to the recording of their communications. It is your responsibility to use the call recording capabilities in compliance with the law. Before using call recording features, you must obtain consent from the parties of recorded communications in a manner that complies with all applicable laws for each participant.

## Prerequisites

- Your administrator enabled call recordings and transcripts.
- Omnichannel agent or Omnichannel supervisor role.
- To access recordings and transcripts, users with other roles need at least read-level access to the **Activity** table.
- To view conversation summaries, users with other roles need at least read-level access to the **ConversationInsights** table. 
- To view post-conversation survey data, the **Show Post Conversation Survey Results** check box must be selected in Copilot Service admin center in the **Conversation Form Settings** under Workspaces. Also, users need read-level access to the **Customer feedback survey** table; Omnichannel Administrator role has the access by default.

## View recordings and transcripts

Customer service representatives (service representative or representative) and supervisors can view closed conversations. Service representatives can view their closed conversations from the Inbox. Supervisors can see a list of all closed conversations in the **Activities** view and filter by **Conversations**.

Users with the System Administrator role can access conversations that are handled by other service representatives.

## Use recording and transcript controls

The **Details** tab of the **Conversation - Conversation Form** displays the conversation transcript and call recording details.

:::image type="content" source="../media/voice-channel-recording.png" alt-text="Screenshot of call recording and transcript controls." lightbox="../media/voice-channel-recording.png":::

### Recording playback

The information pertaining to recording playbook is available for the voice channel only.

- **Play**: Select the button to listen to the conversation audio.

- **Rewind** or **Fast-forward**: Select the buttons to either rewind in 10-second increments or fast-forward in 30-second increments.
- **Volume**: Move the slider to adjust the volume to your required level.
- **Download audio**: Download an .mp4 audio file of the complete call.
- **Speed**: From the dropdown menu, select the playback speed of the conversation, whether slower or faster. **Normal** is the default, and is the speed in which the conversation was recorded.
- **Conversation scroll bar**: Move the scroll bar to any point of the conversation, or listen to it from beginning to end. When you select a location in the recording visualization, the transcript also moves to the same place in the conversation.

### Overview

- **Channel**: The type of communication conducted.
- **Status**: The state of the communication.
- **Queue**: The queue the conversation was conducted in.
- **Workstream**: The workstream the conversation was conducted in.
- **Skills**: The list of agent skills.
- **Regarding**: The link to the case or customer record.
- **Sentiment**: The average sentiment of the conversation; values can be positive, neutral, or negative only.

### Summary

If your administrator configured Copilot to generate summaries after a conversation ends, the conversation summary appears on the form when the conversation ends. If no summary is generated when the call or chat ends, such as the call or chat ended with an AI agent, then a new summary is generated when the transcript viewer appears.

If you open the conversation before the system processes the transcription, the summary isn't available; refresh the page to view the summary when the transcription appears.

### Transcript

- **Search**: Enter keywords in the search field to locate the required sections of the conversation.

- **Download transcript**: Open an HTML file of the conversation transcript in your browser.
  
   > [!NOTE]
   > Inline images and rendering of videos isn't supported in downloaded transcripts.

### Call Metrics

The call metrics are available for the voice channel only.

- **Talking speed**: The rate of speed in which participants conversed during the call.

- **Talk to listen ratio**: The ratio in which the representative spoke versus listened to the customer.
- **Average pause**: The average amount of time in which the conversation was paused.
- **Longest customer monologue**: The longest amount of time that the customer spoke during the conversation.
- **Switches per conversation**: The number of times the conversation switched from representative to customer, and vice versa.

### Post-conversation survey

You can view the following details from the post-conversation survey:

- **CSAT**: The customer satisfaction score of the conversation. The score can be between 0 to 5.

- **`<Verbatim Customer Utterance>`**: User response in free text.
- **First Contact Resolution**: The choice must contain the **Yes** word.
- **Net Promoter Score**: The score can be between 0 to 10.

The following considerations apply:

- If a survey isn't enabled for a conversation, or not completed, the **Post-conversation survey** tab is hidden.

- If one of the three values (**CSAT**, **First Contact Resolution**, or **Net Promoter Score**) aren't collected in a survey, they're hidden.
- If the customer doesn't provide a value, the corresponding label isn't displayed in the survey results.

### Conversation Journey

The conversation journey displays details about each AI agent or representative session that were a part of the conversation. If more than one session exists or other representatives take part in the conversation, then each participant details are also displayed.

- **Conversation Id**: Displays the [conversation ID](/dynamics365/developer/reference/entities/msdyn_ocliveworkitem#BKMK_msdyn_ocliveworkitemid) of the entire conversation that could include one or more sessions.

- The system generates a [session](/dynamics365/developer/reference/entities/msdyn_ocsession) every time a new primary agent is assigned to the conversation.
- Each session header displays the start time and total duration of the session.
- The session lists the primary agent that can be an AI agent or service representative, their assignment time, and whether they joined the conversation.
- When the primary representative or AI agent leaves the session, the session ends, and the **Closure reason** is displayed with the time. Learn more about closure reasons in [Session closure reasons](/dynamics365/contact-center/extend/closure-reasons-descriptions).
- When a consult session is added to the conversation, the representative being consulted appears indented beneath the primary representative. Their join and exit times for the consult are displayed, with details about whether they accepted the consult.
- **Copilot Agent Outcome Reason**: Provides insights into why a Copilot session ended, helping you understand the outcome of each interaction.
- **Copilot Agent Client SessionId**: A unique identifier that allows you to locate the corresponding Copilot conversation transcript and access additional session details stored in Dataverse.
    Learn more in [session outcomes and reasons](oc-bot-dashboard.md#engaged-unengaged).
    
    > [!NOTE]
    > The Copilot Agent outcome reason and client session ID values are available for sessions handled by AI agents only. After the conversation ends, the system might take up to 30 minutes in displaying this information.

   :::image type="content" source="../media/closed-conversation-journey.png" alt-text="Screenshot of a conversation journey that appears in the closed conversation form." lightbox="../media/closed-conversation-journey.png":::

### Related information

[Agent experience of voice calls and agent dashboard](/dynamics365/contact-center/use/voice-channel-agent-experience)    
[Call a customer](voice-channel-call-customer.md)  
[View and understand call summary page in the Sales Hub app](../../sales/view-and-understand-call-summary-sales-app.md)  
