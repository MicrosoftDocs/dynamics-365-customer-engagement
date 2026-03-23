---
title: Sales Hub Dialer overview (preview)
description: Learn how the Sales Hub Dialer enhances sales productivity with real-time transcription, sentiment analysis, and seamless CRM integration for every call.
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.date: 03/23/2026
ms.topic: concept-article
ai-usage: ai-assisted
---

# Sales Hub Dialer overview (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

The new Sales Hub Dialer is an embedded softphone in Dynamics 365 Sales that enables sellers to make and receive voice calls directly within the Sales Hub application. It allows users to place outbound calls and receive inbound calls from the public telephone network without leaving the Sales Hub. [How is the Sales Hub Dialer different from the current Teams-based dialer?](faq-sales-hub-dialer.md#what-is-sales-hub-dialer-and-how-is-it-different-from-the-current-teams-based-dialer)

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

The Sales Hub Dialer is tightly integrated with CRM records and automatically logs call activities. It provides essential features for sellers such as call transfers and consultations, participant addition, spam detection, and call history. 

## Key features of the Sales Hub Dialer

The Sales Hub Dialer offers a comprehensive set of telephony and AI capabilities that support modern sales teams:

- **Built on existing telephony infrastructure**: Leverages the same platform as Dynamics 365 Contact Center for reliable and scalable voice communication.
- **Enterprise-grade reliability and quality**: Calls are routed through Azure's globally distributed services, ensuring high uptime and consistent audio quality.
- **AI-driven insights**: Real-time transcription, live sentiment monitoring, and AI-generated call summaries help sellers focus on conversations and capture important information.
- **Rich call controls**: Sellers can mute, hold, resume, and transfer calls (both warm and cold transfers), and add participants for consultation.
- **Seamless CRM integration**: Calls can be initiated from any lead or contact record, and all call activities are automatically logged on timelines.
- **Security and compliance**: Calls are encrypted, and sensitive data in transcripts can be automatically masked to meet privacy requirements.
- **Spam protection**: Built-in spam detection and blocking help sellers avoid unwanted calls.

## Feature availability

The Sales Hub Dialer offers traditional calling functionalities such as outbound and inbound calling, click-to-call from records and views, call hold and resume, and automatic CRM logging. In addition, it provides advanced features that enhance the seller experience. The following table lists these advanced features and where to learn more about each one:

| Feature | Learn more |
|---|---|
| Warm and cold transfer | [Transfer and consult on voice calls](/dynamics365/customer-service/use/voice-channel-transfer-consult?tabs=enhancedvoicestack) |
| Call recording | [Configure call transcripts and recordings](/dynamics365/customer-service/administer/voice-channel-configure-transcripts) |
| Live call transcription | [Configure call transcripts and recordings](/dynamics365/customer-service/administer/voice-channel-configure-transcripts) |
| Real-time sentiment analysis | [Enable sentiment analysis](/dynamics365/customer-service/administer/enable-sentiment-analysis) |
| Call notes and auto-logging | [Take notes during conversations](/dynamics365/customer-service/use/oc-take-notes) |
| Spam call identification | [Block phone numbers](/dynamics365/customer-service/administer/voice-channel-block-number) |
| Post-call AI summary | [View call recordings and transcripts](/dynamics365/customer-service/use/voice-channel-call-recordings-transcripts) |
| Voicemail | [Configure voicemail](/dynamics365/customer-service/administer/voice-channel-voicemail) |

## How the Sales Hub Dialer works

You can access the dialer from the right pane of the Sales Hub app. You can start calls using click-to-call from CRM records, by searching for CRM records, or by manually entering a number. Inbound calls trigger a notification and open the call panel for immediate response. During calls, sellers have access to controls and AI features, and can take notes or mark calls as spam. After calls, activities are logged, recordings and transcripts are available, and AI-generated summaries highlight key points. Learn more in [Make and receive calls with the Sales Hub Dialer (preview)](make-receive-calls-sales-hub-dialer.md)

## AI and conversation intelligence

The dialer leverages Dynamics 365 Conversation Intelligence to provide:

- **Live transcription**: Converts speech to text in real time for both parties.
- **Sentiment analysis**: Monitors customer sentiment throughout the call.
- **In-call summaries**: Generates in-call summaries using Microsoft 365 Copilot to catch up on a live call.
- **Post-call summaries**: Automatically generates summaries.
- **Call analytics**: Aggregates call data for managers and sellers to review performance and trends.

## Security, compliance, and administration

All calls are encrypted in transit and at rest. Administrators can configure data masking for sensitive information and manage access to call recordings. The dialer uses the same telephony platform as Dynamics 365 Contact Center, and setup involves licensing, voice channel provisioning, and enabling the dialer for users. Telephony charges may apply based on the organization's calling plan or provider.

## Related information

- [Enable and configure the Sales Hub Dialer (preview)](configure-sales-hub-dialer.md)
- [Make and receive calls with the Sales Hub Dialer (preview)](make-receive-calls-sales-hub-dialer.md)

