---
title: FAQs about the new Sales Hub Dialer (preview)
description: Learn about the new Sales Hub Dialer with answers to frequently asked questions covering its features, differences from the Teams-based dialer, licensing, roadmap, and more.
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.date: 02/18/2026
ms.topic: concept-article
ai-usage: ai-assisted
---

# Frequently Asked Questions about the Sales Hub Dialer (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

This article provides answers to frequently asked questions about the new Sales Hub Dialer, a modern voice calling solution embedded within Dynamics 365 Sales. The Sales Hub Dialer offers enhanced telephony features, AI-driven conversation intelligence, and seamless CRM integration to help sales teams connect with customers more effectively.

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

## What is the new Sales Hub dialer, and how is it different from the current Teams-based dialer?

The new Sales Hub dialer is a modern, embedded softphone (voice calling) feature built directly into Dynamics 365 Sales Hub, allowing sellers to make outbound calls and receive inbound calls right from the Sales application. While the current Microsoft Teams-based dialer connects calls through the Teams client, the new Sales Hub dialer is built on Microsoft's cloud telephony infrastructure (the same platform used by Dynamics 365 Contact Center's voice channel). It offers enterprise-grade reliability and advanced voice features that extend beyond the basic call functionality. Learn more about the key capabilities in the [Sales Hub Dialer overview (preview)](sales-hub-dialer-overview.md).

## Do I need additional licenses to use the new Sales Hub dialer?

The new Sales Hub dialer is included at no additional cost with specific Dynamics 365 Sales licenses. Learn more about the exact license required in the [Dynamics 365 licensing guide](https://go.microsoft.com/fwlink/?LinkId=866544). Microsoft provides a special "\$0 voice service plan" to ensure that the new dialer's capabilities are enabled for customers with specific Dynamics 365 Sales licenses. 

For organizations already using Dynamics 365 Sales with the appropriate licenses, enabling the new dialer simply involves some configuration steps (for example, provisioning the voice channel in your environment and assigning phone numbers to sellers) but no new paid license is needed. Learn more about the configuration steps in the [Enable and configure the Sales Hub Dialer (preview)](configure-sales-hub-dialer.md).

> [!NOTE]
> If you don't have the appropriate Dynamics 365 Sales license, contact your Microsoft account representative or consult the licensing documentation for details on enabling voice capabilities in your environment.

## What are the differences between the new Sales Hub dialer and the current Teams-based dialer?

The new Sales Hub dialer retains all the core calling abilities of the Teams-based dialer (like making calls from Sales records and basic call logging), but it adds significant enhancements. Below are key differences and benefits of the new dialer compared to the existing Teams dialer: 

| Capability | New Sales Hub Dialer | Current Teams-based Dialer |
|---|---|---|
| **Voice Platform** | Built on Contact Center's robust cloud telephony platform with high reliability and quality. | Uses Teams calling infrastructure, requiring Teams Phone setup for each seller. |
| **Call Features** | Supports inbound and outbound calls, call transfer (warm/cold), adding participants, call hold/resume, and call queues. | Supports making and receiving calls from Sales Hub with limited advanced call controls (no native call queue or built-in IVR). |
| **Call Recording & Intelligence** | Built-in call recording with speaker-separated tracks, spam call detection, and automatic call logging to CRM. | Conversation intelligence (transcripts, KPIs) only with Sales Insights enabled; uses older-generation AI models. |
| **AI Assistance** | Live transcription, sentiment analysis, real-time and post-call summaries integrated in the dialer. | No real-time or post-call summaries; sellers must manually review transcripts and notes. |
| **Experience** | Consistent calling experience across Sales and Customer Service apps. | Dependent on Teams app integration, which can introduce workflow friction. |


## Can organizations have both the old (Teams) and new dialer active at the same time for different seller personas?

Yes, organizations can run both the Teams dialer and the new Sales Hub dialer in parallel, configuring them for different groups of sellers as needed. This means you can enable the new dialer for certain teams or roles (who will benefit from the advanced features and AI capabilities) while allowing other users to continue using the existing Teams-based dialer if they rely on native Teams calling or aren't ready to switch immediately. 

Administrators can manage this by assigning appropriate roles or app experiences to different users. For example, sellers who need Teams-native integration (perhaps those primarily making internal Teams calls or those not using call intelligence features) can continue with the Teams dialer, while other sellers can use the new Sales Hub dialer with the latest voice features and conversation intelligence. Both dialers can be configured in the same environment concurrently, enabling a gradual migration. This flexibility ensures that no user loses functionality during rollout. 

## Are the features between the old dialer and new dialer going to be the same? Are there any features that I would not get from the old dialer?

**Answer:** After General Availability (GA), the new Sales Hub dialer provides an overall greater set of functionalities compared to the Teams-based dialer for calling within Dynamics 365 Sales. In addition, it introduces new capabilities, improved reliability, and advanced AI features that are meant to improve the seller experience.   
However, there are a small number of behavioral differences that customers should be aware of during and after the transition. 

### What stays the same (feature parity)

The new Sales Hub dialer supports all core calling scenarios that sellers rely on today, including:
- Outbound calling from Leads, Contacts, Accounts, and Opportunities
- Inbound call handling within Dynamics 365 Sales including Record Identification
- Click-to-call from records and views
- Automatic creation and logging of Phone Calls in Dynamics 365

These scenarios ensure sellers can continue their day-to-day calling workflows without loss of basic functionality when moving from the Teams-based dialer to the new Sales Hub dialer.

### What is better in the new Sales Hub dialer?

The new Sales Hub dialer is built on the Dynamics 365 Contact Center voice platform, rather than the Microsoft Teams client. This architectural change delivers the following benefits:
- Improved reliability and stability
- Uses enterprise-grade cloud telephony infrastructure designed for high call volumes and critical scenarios
- Reduces issues related to dropped calls, inconsistent call quality, and client dependency
- Advanced calling capabilities (not available in the Teams-based dialer)
- Call Transfer and Consult
- Add participants to a call
- Dedicated service numbers (instead of individual user numbers)
- Ability to download call transcripts and recordings
- Improved Conversation Intelligence and AI (Using the latest LLM models)
- Native call recording
- Real-time transcription and sentiment analysis
- In-call and post-call AI summaries
- AI-generated notes and follow-up action items
- Keyword and intent detection
- Compliance and enterprise readiness
- Speaker-separated recordings
- Metadata tagging for recordings
- Bring Your Own Telephony support

### Known differences and trade-offs

The move to a service-number-based architecture and dialer introduces a few intentional changes:
- **No dual ringing across Teams and Dynamics 365:** The Teams-based dialer uses user phone numbers and supports dual ringing; the new Sales Hub dialer uses service numbers, so calls ring inside Dynamics 365 Sales only. To ensure sellers do not miss calls, browser and in-app desktop notifications are supported and recommended.
- **Mobile calling experience:** The Teams-based dialer benefits from native Teams mobile apps; the new Sales Hub dialer currently supports calling through the web and desktop Sales Hub experience. 

These differences result from moving away from a Teams-client-dependent model to a scalable, AI-ready voice platform that supports advanced routing, recording, and intelligence capabilities.
