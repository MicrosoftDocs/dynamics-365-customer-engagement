---
title: Make and receive calls with the Sales Hub dialer
description: Learn how to use the Sales Hub dialer in Dynamics 365 Sales to place outbound calls, handle inbound calls, use in-call AI features, and review post-call summaries.
ms.date: 03/01/2026
ms.topic: how-to
ms.collection: bap-ai-copilot
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
---

# Make and receive calls with the Sales Hub dialer (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

The **Sales Hub dialer** is an embedded softphone in Dynamics 365 Sales that lets sellers make outbound calls and receive inbound calls directly within the Sales Hub application. Built on Azure Communication Services—the same cloud telephony platform used by Dynamics 365 Contact Center—the dialer delivers enterprise-grade reliability, advanced AI-powered conversation intelligence, and seamless CRM integration so that every call is automatically logged and enriched with insights.

Key capabilities include:

- **Click-to-call** from any lead, contact, or opportunity record.
- **Inbound call handling** with automatic caller identification and screen pop.
- **Full call controls** including hold, resume, mute, warm transfer, and cold transfer.
- **Real-time transcription and sentiment analysis** powered by Conversation Intelligence.
- **AI-generated post-call summaries** with action items and keyword highlights.
- **Spam call detection** to block unwanted callers.
- **Automatic call logging** as Phone Call activities on record timelines.

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

## Prerequisites

Before sellers can use the Sales Hub dialer, the following requirements must be met:

- **Licensing**: A Dynamics 365 Sales Enterprise or Sales Premium license is required. Conversation Intelligence features may require additional Sales Insights or Copilot licensing.
- **Admin setup**: An administrator must provision and configure the voice channel in your Dynamics 365 environment and enable the dialer for Sales Hub. For detailed admin setup instructions, see [Set up the Sales Hub dialer](#set-up-the-sales-hub-dialer-admin).
- **Telephony**: A calling plan or telephony provider (for example, a Microsoft Teams Calling Plan) must be configured for outbound and inbound PSTN calling. Telephony charges apply based on your provider's rates.
- **Hardware**: A computer with a microphone, speakers or headset, and a supported browser.

> [!NOTE]
> **Telephony costs:** The Sales Hub dialer is included with Dynamics 365 Sales, but outbound and inbound PSTN calls incur telephony charges from your calling plan or provider. Azure Communication Services usage for call routing, recording, and transcription may incur additional charges after GA. Refer to your licensing guide for details.

## Place an outbound call

As a seller, you can start an outbound call in two ways:

1. To call a lead, contact, or opportunity, open the record and select the **phone icon** next to the phone number field. The dialer pane opens and automatically dials the number.

2. To call a number not in CRM, open the dialer from the Sales navigation bar, enter the phone number using the keypad, and select **Call**.

The dialer uses your assigned phone number as the outbound caller ID.

## Answer an inbound call

When a customer calls your sales phone number, a toast notification appears in Dynamics 365 Sales, regardless of where you are in the app.

1. To accept the call, select **Accept** on the notification. The call panel opens and connects you to the caller through your browser using voice over IP.

2. To decline the call, select **Decline**. The call routes to voicemail if voicemail is configured.

If the caller is a known contact or lead, the system automatically identifies them and links the call to their record.

## Use in-call controls and features

Once connected on a call, the dialer provides the following controls and tools.

### Manage the call

- To mute or unmute your microphone, select the **Mute** button in the call panel.
- To place the customer on hold, select **Hold**. Select **Resume** to return to the conversation.
- To end the call, select **End call**.

### Transfer a call

You can transfer an active call to another user or external phone number.

1. Select **Transfer** in the call panel.
2. Search for a user in your organization's directory or enter an external phone number.
3. Choose one of the following options:
   - **Warm transfer**: Speak with the recipient privately before completing the transfer.
   - **Cold transfer**: Transfer the call immediately without speaking to the recipient first.

### View live transcription and sentiment

If Conversation Intelligence is enabled for your organization, the call panel displays:

- **Real-time transcription** — The conversation is transcribed as it happens, converting speech to text in near real time.
- **Sentiment indicator** — An AI-powered meter shows the customer's sentiment (positive, neutral, or negative) as the conversation progresses.

These features help you gauge customer mood and capture details during complex discussions.

### Take notes during the call

To capture key details or next steps, type your notes in the **Notes** area of the call panel. These notes are saved to the call activity when the call ends.

### Mark a call as spam

If an inbound call is unwanted, select **Mark as Spam** in the call panel. This labels the number and helps the system filter future calls from that number.

## Review post-call information

When a call ends, the Sales Hub dialer automatically captures and enriches the call record.

### View the call log

The system saves the call as a completed Phone Call activity in Dynamics 365 Sales. The call record includes:

- Call duration and timestamps
- Participants (customer phone number and seller)
- Notes and call outcome tags you applied during the call

The call appears on the **Timeline** of the associated lead, contact, or opportunity record.

### Review the AI-generated summary

If call recording and post-call summarization are enabled, the call record includes:

- **Call recording** — Select the recording to play back the conversation.
- **Full transcript** — Read the complete text of the conversation.
- **AI-generated summary** — Review key points, action items, decision points, sentiment timeline, and detected keywords automatically extracted by conversation intelligence.

### Create follow-up actions

Based on the AI-generated summary, review any identified action items—such as "send a product catalog" or "schedule a demo"—and manually create follow-up tasks. At GA, the dialer will support automatic AI-powered task creation based on call content.

## Related content

- [Configure call transcripts and recordings](/dynamics365/customer-service/administer/voice-channel-configure-transcripts)
- [Enable sentiment analysis](/dynamics365/customer-service/administer/enable-sentiment-analysis)
- [Transfer and consult on voice calls](/dynamics365/customer-service/use/voice-channel-transfer-consult?tabs=enhancedvoicestack)
- [Block phone numbers](/dynamics365/customer-service/administer/voice-channel-block-number)
- [Configure voicemail](/dynamics365/customer-service/administer/voice-channel-voicemail)












