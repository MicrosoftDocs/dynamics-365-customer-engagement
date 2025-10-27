---
title: Stay compliant with privacy regulations
description: Set up and configure the Sales Qualification Agent to automate research, engagement, and outreach in Dynamics 365 Sales with AI-powered assistance for effective sales processes.
ms.date: 09/24/2025
ms.topic: conceptual
ms.service: dynamics-365-sales
content_well_notification:
  - AI-contribution
ms.custom: bap-template
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Stay compliant with privacy regulations

Regional privacy laws like the GDPR (EU), CAN-SPAM (US), CCPA (California), HIPAA (US healthcare), and others govern sending commercial communications. These regulations protect privacy and ensure that people only receive relevant and expected communications.

The Consent Management system for Dynamics 365 Sales is built on the same consent framework originally developed for Customer Insights – Journeys. You can now manage consent centrally for both the applications. Consent data is shared between Dynamics 365 Sales and Customer Insights – Journeys, so a single opt-out or preference update can be honored across both the applications. However, you can also configure separate compliance profiles and purposes for each application when distinct regulatory or business requirements apply. Learn more about consent management, compliance profiles, and purposes in [Consent management overview](/dynamics365/customer-insights/journeys/real-time-marketing-compliance-settings).

> [!NOTE]
> The consent settings you configure apply only to emails sent by the Sales AI agents, such as the Sales Qualification Agent and Opportunity Research Agent. 

**Why does compliance matter?**

Following these regulations helps you avoid legal penalties, improves user experience, and increases email engagement and deliverability. If you don't comply, your messages can be blocked or sent to spam.

**How to stay compliant?**

Use a consent management system to track and honor user preferences. To stay compliant, you can:

- Use the built-in consent center in Dynamics 365 Sales or Customer Insights – Journeys, which supports real-time consent capture and enforcement.
- Integrate your existing consent management system using the extensibility features of Customer Insights – Journeys.

## Understand the default consent setup

The built-in consent management system includes the following default compliance profiles:

- **Commercial Purpose**: Used for sending promotional emails and newsletters.
- **Transactional Purpose**: Used for sending order confirmations or service updates.

By default, both purposes are set to be non-restrictive, meaning that emails can be sent unless the recipient has explicitly opted out. You can modify these settings based on your organization's requirements.
 
## Configure consent management for your organization

Create your own compliance profile so that you can define the purpose for collecting and processing data and add topics that match your organization’s communication categories. You can also customize the Preference Center form&mdash;shown when users select **Unsubscribe**&mdash;to reflect your brand and give customers clear options to manage their preferences.

To learn how to customize preference centers, compliance profiles and purposes, go to [Customize your preference centers](dynamics365/customer-insights/journeys/real-time-marketing-preference-centers).

> [!TIP]
> If your target region's regulations allow it, leave the **Commercial Purpose** profile as a **Non-Restrictive** enforcement model, which permits sending emails unless the contact has opted out.
 
## Import consent data

After you set up consent management, ensure that your existing consent data is imported into the Consent Center to maintain compliance with user preferences. You can import the consent data either using [load consent](/dynamics365/customer-insights/journeys/real-time-marketing-migrate-consent) feature or a [cloud flow](dynamics365/customer-insights/journeys/consent-record-creation).


## View and edit consent for a contact

As Sales Qualification Agent sends outreach emails to leads

To view and edit consent for a specific contact or lead, open the lead or contact record in Dynamics 365 Sales. Navigate to the **Communication** tab to view the consent status for all purposes and for compliance profiles associated with the lead or contact. You can also update the consent status directly from this view. For example, you can change an existing opt-in to opt-out or update preferences for specific communication channels. Any changes made here will be honored across all integrated applications, including Customer Insights – Journeys.