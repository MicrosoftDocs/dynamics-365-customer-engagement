---
title: Sales Hub Dialer features and AI capabilities
description: Learn how the Sales Hub dialer enhances sales productivity with real-time transcription, sentiment analysis, and seamless CRM integration for every call.
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.date: 02/18/2026
ms.topic: concept-article
ms.collection: bap-ai-copilot
---

# Sales Hub dialer concepts

The Sales Hub dialer is an embedded softphone feature in Dynamics 365 Sales that enables sellers to make and receive voice calls directly within the Sales Hub application. Built on Azure Communication Services, it delivers enterprise-grade reliability, integrates with sales workflows, and leverages AI-powered insights to enhance every customer interaction.

## Introduction

Sales Hub dialer is a cloud-based telephony solution designed for Dynamics 365 Sales. It allows users to place outbound calls and receive inbound calls from the public telephone network without leaving the Sales Hub. The dialer is tightly integrated with CRM records, automatically logs call activities, and provides advanced AI features such as real-time transcription, sentiment analysis, and post-call summaries. This unified experience helps sales teams streamline communication, capture critical details, and improve productivity.

## Key features of the Sales Hub dialer

The Sales Hub dialer offers a comprehensive set of telephony and AI capabilities that support modern sales teams:

- **Enterprise-grade reliability and quality**: Calls are routed through Azure’s globally distributed services, ensuring high uptime and consistent audio quality.
- **AI-driven insights**: Real-time transcription, live sentiment monitoring, and AI-generated call summaries help sellers focus on conversations and capture important information.
- **Rich call controls**: Sellers can mute, hold, resume, and transfer calls (both warm and cold transfers), and add participants for consultation.
- **Seamless CRM integration**: Calls can be initiated from any lead, contact, or opportunity record, and all call activities are automatically logged on timelines.
- **Security and compliance**: Calls are encrypted, and sensitive data in transcripts can be automatically masked to meet privacy requirements.
- **Spam protection**: Built-in spam detection and blocking help sellers avoid unwanted calls.

## Feature availability

The following table lists which capabilities are available in Public Preview and which are planned for General Availability (GA).

| Feature | Availability | Learn more |
|---|---|---|
| Click-to-call from a record | Public Preview | |
| Inbound and outbound calling | Public Preview | |
| Call hold and resume | Public Preview | |
| Warm and cold transfer | Public Preview | [Transfer and consult on voice calls](/dynamics365/customer-service/use/voice-channel-transfer-consult?tabs=enhancedvoicestack) |
| Call recording | Public Preview | [Configure call transcripts and recordings](/dynamics365/customer-service/administer/voice-channel-configure-transcripts) |
| Live call transcription | Public Preview | [Configure call transcripts and recordings](/dynamics365/customer-service/administer/voice-channel-configure-transcripts) |
| Real-time sentiment analysis | Public Preview | [Enable sentiment analysis](/dynamics365/customer-service/administer/enable-sentiment-analysis) |
| Call notes and auto-logging | Public Preview | [Take notes during conversations](/dynamics365/customer-service/use/oc-take-notes) |
| Spam call identification | Public Preview | [Block phone numbers](/dynamics365/customer-service/administer/voice-channel-block-number) |
| Post-call AI summary | Public Preview | [View call recordings and transcripts](/dynamics365/customer-service/use/voice-channel-call-recordings-transcripts) |
| Voicemail | Public Preview | [Configure voicemail](/dynamics365/customer-service/administer/voice-channel-voicemail) |
| Manual call outcome tagging | Coming soon (GA) | |
| Call queues and skills-based routing | Coming soon (GA) | [Set up queues to manage activities](/dynamics365/customer-service/administer/set-up-queues-manage-activities-cases) |
| Real-time translation | Coming soon (GA) | [Enable real-time translation](/dynamics365/customer-service/administer/enable-real-time-translation) |
| AI-generated notes and action items | Coming soon (GA) | [Enable Copilot summarization](/dynamics365/contact-center/administer/copilot-enable-summary) |
| Keyword and mention extraction | Coming soon (GA) | |

## Set up the Sales Hub dialer (admin)

As an administrator, you must complete three high-level steps to enable the Sales Hub dialer for your organization:

1. **Provision the voice channel.** In the Dynamics 365 admin center, provision the voice channel for your environment. This step uses the same configuration experience as Dynamics 365 Contact Center's voice channel.

2. **Configure telephony and phone numbers.** Assign phone numbers to your environment and configure your calling plan or telephony provider. Define which numbers are available for outbound caller ID and which numbers accept inbound calls.

3. **Enable the dialer in Sales Hub.** Turn on the Sales Hub dialer feature in your Sales Hub app settings and assign the appropriate security roles to sellers who need access.

For the complete step-by-step admin setup procedure, see the [Omnichannel onboarding guide](https://learn.microsoft.com/dynamics365/sales/configure-voice-channel).

## How the Sales Hub dialer works

The dialer is accessible from the Sales Hub navigation bar or the Sales Calls area. Users can start calls using click-to-call from CRM records or by manually entering a number. Inbound calls trigger a notification and open the call panel for immediate response. During calls, sellers have access to controls and AI features, and can take notes or mark calls as spam. After calls, activities are logged, recordings and transcripts are available, and AI-generated summaries highlight key points and action items.

## AI and conversation intelligence

The dialer leverages Dynamics 365 Conversation Intelligence to provide:

- **Live transcription**: Converts speech to text in real time for both parties.
- **Sentiment analysis**: Monitors customer sentiment throughout the call.
- **Post-call summaries**: Automatically generates summaries, action items, and highlights keywords or competitor mentions.
- **Call analytics**: Aggregates call data for managers and sellers to review performance and trends.

## Security, compliance, and administration

All calls are encrypted in transit and at rest. Administrators can configure data masking for sensitive information and manage access to call recordings. The dialer uses the same telephony platform as Dynamics 365 Contact Center, and setup involves licensing, voice channel provisioning, and enabling the dialer for users. Telephony charges may apply based on the organization’s calling plan or provider.





