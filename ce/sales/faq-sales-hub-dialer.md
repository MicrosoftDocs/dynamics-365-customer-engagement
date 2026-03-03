---
title: FAQs about Sales Hub Dialer (preview)
description: Learn about Sales Hub Dialer with answers to frequently asked questions covering its features, differences from the Teams-based dialer, licensing, roadmap, and more.
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.date: 02/18/2026
ms.topic: concept-article
ai-usage: ai-assisted
---

# Frequently asked questions about Sales Hub Dialer (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

This article provides answers to frequently asked questions about Sales Hub Dialer, a modern voice calling solution embedded within Dynamics 365 Sales. Sales Hub Dialer offers enhanced telephony features, AI-driven conversation intelligence, and seamless CRM integration to help sales teams connect with customers more effectively.

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

## What is Sales Hub Dialer and how is it different from the current Teams-based dialer?

Sales Hub Dialer is a modern, embedded softphone (voice calling) feature built directly into Dynamics 365 Sales Hub, so sellers can make outbound calls and receive inbound calls right from the Sales application. While the current Microsoft Teams-based dialer connects calls through the Teams client, Sales Hub Dialer is built on Microsoft's cloud telephony infrastructure (the same platform used by Dynamics 365 Contact Center's voice channel). It offers enterprise-grade reliability and advanced voice features that extend beyond the basic call functionality. Learn more about the key capabilities in the [Sales Hub Dialer overview (preview)](sales-hub-dialer-overview.md).

## Do I need additional licenses to use Sales Hub Dialer?

Sales Hub Dialer is included at no extra cost with specific Dynamics 365 Sales licenses. Learn more about the exact license you need in the [Dynamics 365 licensing guide](https://go.microsoft.com/fwlink/?LinkId=866544). Microsoft provides a special "\$0 voice service plan" to ensure that the new dialer's capabilities are enabled for customers with specific Dynamics 365 Sales licenses. 

For organizations already using Dynamics 365 Sales with the appropriate licenses, enabling the new dialer simply involves some configuration steps (for example, provisioning the voice channel in your environment and assigning phone numbers to sellers) but doesn't require a new paid license. Learn more about the configuration steps in the [Enable and configure Sales Hub Dialer (preview)](configure-sales-hub-dialer.md).

> [!NOTE]
> If you don't have the appropriate Dynamics 365 Sales license, contact your Microsoft account representative or consult the licensing documentation for details about enabling voice capabilities in your environment.

## What are the differences between Sales Hub Dialer and the current Teams-based dialer?

Sales Hub Dialer retains all the core calling abilities of the Teams-based dialer, such as making calls from Sales records and basic call logging, but it adds significant enhancements. The following table highlights the key differences and benefits of the new dialer compared to the existing Teams dialer: 

| Capability | Sales Hub Dialer | Current Teams-based Dialer |
|---|---|---|
| **Voice Platform** | Built on Contact Center's robust cloud telephony platform with high reliability and quality. | Uses Teams calling infrastructure, requiring Teams Phone setup for each seller. |
| **Call Features** | Supports inbound and outbound calls, call transfer (warm/cold), adding participants, call hold/resume, and call queues. | Supports making and receiving calls from Sales Hub with limited advanced call controls (no native call queue or built-in IVR). |
| **Call Recording & Intelligence** | Built-in call recording with speaker-separated tracks, spam call detection, and automatic call logging to CRM. | Conversation intelligence (transcripts, KPIs) only with Sales Insights enabled; uses older-generation AI models. |
| **AI Assistance** | Live transcription, sentiment analysis, real-time and post-call summaries integrated in the dialer. | No real-time or post-call summaries; sellers must manually review transcripts and notes. |
| **Experience** | Consistent calling experience across Sales and Customer Service apps. | Dependent on Teams app integration, which can introduce workflow friction. |


## Can organizations have both the old (Teams) and new dialer active at the same time for different seller personas?

Yes, organizations can run both the Teams dialer and Sales Hub Dialer in parallel, and they can configure them for different groups of sellers. You can enable the new dialer for certain teams or roles so they benefit from the advanced features and AI capabilities. Other users can continue using the existing Teams-based dialer if they rely on native Teams calling or aren't ready to switch immediately. 

Administrators can manage this setup by assigning appropriate roles or app experiences to different users. For example, sellers who need Teams-native integration - such as those primarily making internal Teams calls or those not using call intelligence features - can continue with the Teams dialer. Other sellers can use Sales Hub Dialer with the latest voice features and conversation intelligence. You can configure both dialers in the same environment concurrently, which enables a gradual migration. This flexibility ensures that no user loses functionality during rollout. 

## Are the features between the old dialer and new dialer going to be the same? Are there any features that I wouldn't get from the old dialer?

**Answer:** After general availability (GA), Sales Hub Dialer provides an overall greater set of functionalities compared to the Teams-based dialer for calling within Dynamics 365 Sales. In addition, it introduces new capabilities, improved reliability, and advanced AI features that enhance the seller experience.   
However, there are a small number of behavioral differences that customers should be aware of during and after the transition. 

### What stays the same (feature parity)

Sales Hub Dialer supports all core calling scenarios that sellers rely on today, including:
- Outbound calling from Leads, Contacts, Accounts, and Opportunities
- Inbound call handling within Dynamics 365 Sales including Record Identification
- Click-to-call from records and views
- Automatic creation and logging of Phone Calls in Dynamics 365

These scenarios ensure sellers can continue their day-to-day calling workflows without losing basic functionality when they move from the Teams-based dialer to Sales Hub Dialer.

### What's better in Sales Hub Dialer?

Sales Hub Dialer uses the Dynamics 365 Contact Center voice platform instead of the Microsoft Teams client. This architectural change brings the following benefits:
- Improved reliability and stability.
- Uses enterprise-grade cloud telephony infrastructure designed for high call volumes and critical scenarios.
- Reduces problems with dropped calls, inconsistent call quality, and client dependency.
- Advanced calling capabilities that aren't available in the Teams-based dialer, such as:
    - Call Transfer and Consult.
    - Add participants to a call.
    - Dedicated service numbers instead of individual user numbers.
    - Ability to download call transcripts and recordings.
    - Improved Conversation Intelligence and AI by using the latest LLM models.
    - Native call recording.
    - Real-time transcription and sentiment analysis.
    - In-call and post-call AI summaries.
    - Compliance and enterprise readiness.
    - Speaker-separated recordings.
    - Bring Your Own Telephony support.

### Known differences and trade-offs

The move to a service-number-based architecture and dialer introduces a few intentional changes:
- **No dual ringing across Teams and Dynamics 365:** The Teams-based dialer uses user phone numbers and supports dual ringing. Sales Hub Dialer uses service numbers, so calls ring inside Dynamics 365 Sales only. To make sure sellers don't miss calls, browser and in-app desktop notifications are supported and recommended.
- **Mobile calling experience:** The Teams-based dialer use the native Teams mobile app. Sales Hub Dialer currently supports calling through the web and desktop Sales Hub experience only.  

These differences come from moving away from a Teams-client-dependent model to a scalable, AI-ready voice platform that supports advanced routing, recording, and intelligence capabilities.
