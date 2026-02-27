---
title: Sales Hub Dialer overview
description: Learn how the Sales Hub Dialer enhances sales productivity with real-time transcription, sentiment analysis, and seamless CRM integration for every call.
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.date: 02/18/2026
ms.topic: concept-article
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Sales Hub Dialer overview

The Sales Hub Dialer is an embedded softphone feature in Dynamics 365 Sales that enables sellers to make and receive voice calls directly within the Sales Hub application. It allows users to place outbound calls and receive inbound calls from the public telephone network without leaving the Sales Hub. 

The dialer is tightly integrated with CRM records, automatically logs call activities, and provides advanced AI features such as real-time transcription, sentiment analysis, and post-call summaries. This unified experience helps sales teams streamline communication, capture critical details, and improve productivity.

## Key features of the Sales Hub Dialer

The Sales Hub Dialer offers a comprehensive set of telephony and AI capabilities that support modern sales teams:

- **Enterprise-grade reliability and quality**: Calls are routed through Azure’s globally distributed services, ensuring high uptime and consistent audio quality.
- **AI-driven insights**: Real-time transcription, live sentiment monitoring, and AI-generated call summaries help sellers focus on conversations and capture important information.
- **Rich call controls**: Sellers can mute, hold, resume, and transfer calls (both warm and cold transfers), and add participants for consultation.
- **Seamless CRM integration**: Calls can be initiated from any lead, contact, or opportunity record, and all call activities are automatically logged on timelines.
- **Security and compliance**: Calls are encrypted, and sensitive data in transcripts can be automatically masked to meet privacy requirements.
- **Spam protection**: Built-in spam detection and blocking help sellers avoid unwanted calls.

## Feature availability

The following table lists which capabilities are available in Public Preview and which are planned for General Availability (GA).

| Feature | Learn more |
|---|---|
| Click-to-call from a record | |
| Inbound and outbound calling | |
| Call hold and resume | |
| Warm and cold transfer | [Transfer and consult on voice calls](/dynamics365/customer-service/use/voice-channel-transfer-consult?tabs=enhancedvoicestack) |
| Call recording | [Configure call transcripts and recordings](/dynamics365/customer-service/administer/voice-channel-configure-transcripts) |
| Live call transcription | [Configure call transcripts and recordings](/dynamics365/customer-service/administer/voice-channel-configure-transcripts) |
| Real-time sentiment analysis | [Enable sentiment analysis](/dynamics365/customer-service/administer/enable-sentiment-analysis) |
| Call notes and auto-logging | [Take notes during conversations](/dynamics365/customer-service/use/oc-take-notes) |
| Spam call identification | [Block phone numbers](/dynamics365/customer-service/administer/voice-channel-block-number) |
| Post-call AI summary | [View call recordings and transcripts](/dynamics365/customer-service/use/voice-channel-call-recordings-transcripts) |
| Voicemail | [Configure voicemail](/dynamics365/customer-service/administer/voice-channel-voicemail) |
| Manual call outcome tagging | |
| Call queues and skills-based routing | [Set up queues to manage activities](/dynamics365/customer-service/administer/set-up-queues-manage-activities-cases) |
| Real-time translation | [Enable real-time translation](/dynamics365/customer-service/administer/enable-real-time-translation) |
| AI-generated notes and action items | [Enable Copilot summarization](/dynamics365/contact-center/administer/copilot-enable-summary) |
| Keyword and mention extraction | |

## How the Sales Hub Dialer works

You can access the dialer from the right pane of the Sales Hub app. You can start calls using click-to-call from CRM records or by manually entering a number. Inbound calls trigger a notification and open the call panel for immediate response. During calls, sellers have access to controls and AI features, and can take notes or mark calls as spam. After calls, activities are logged, recordings and transcripts are available, and AI-generated summaries highlight key points and action items.

## AI and conversation intelligence

The dialer leverages Dynamics 365 Conversation Intelligence to provide:

- **Live transcription**: Converts speech to text in real time for both parties.
- **Sentiment analysis**: Monitors customer sentiment throughout the call.
- **Post-call summaries**: Automatically generates summaries, action items, and highlights keywords or competitor mentions.
- **Call analytics**: Aggregates call data for managers and sellers to review performance and trends.

## Security, compliance, and administration

All calls are encrypted in transit and at rest. Administrators can configure data masking for sensitive information and manage access to call recordings. The dialer uses the same telephony platform as Dynamics 365 Contact Center, and setup involves licensing, voice channel provisioning, and enabling the dialer for users. Telephony charges may apply based on the organization’s calling plan or provider.

## Related information

- [Enable and configure the Sales Hub Dialer (preview)](configure-sales-hub-dialer.md)
- [Make and receive calls with the Sales Hub Dialer (preview)](make-receive-calls-sales-hub-dialer.md)



