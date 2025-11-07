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

The Consent Management system for Dynamics 365 Sales is built on the same consent framework originally developed for Customer Insights – Journeys. While Customer Insights – Journeys license is not required to use consent management in Dynamics 365 Sales, if you have both applications, you can take advantage of the following benefits:

- Manage consent centrally for both the applications, provided that they are in the same environment.
- Share consent data between Dynamics 365 Sales and Customer Insights – Journeys, so a single opt-out or preference update can be honored across both the applications.
- Configure separate compliance profiles and purposes for each application when distinct regulatory or business requirements apply.

Learn more about consent management, compliance profiles, and purposes in [Consent management overview](/dynamics365/customer-insights/journeys/real-time-marketing-compliance-settings).

> [!NOTE]
> The consent settings you configure apply only to emails sent by the sales AI agents, such as the Sales Qualification Agent and Sales Close Agent. 

**Why does compliance matter?**

Following the privacy regulations helps you avoid legal penalties, improves user experience, and increases email engagement and deliverability. If you don't comply, your messages can be blocked or sent to spam.


## Understand the default consent setup

The built-in consent management system includes a default compliance profile with two purposes:

- **Commercial Purpose**: Used for sending promotional emails and newsletters.
- **Transactional Purpose**: Used for sending order confirmations or service updates.

By default, commercial purposes is set to be non-restrictive for email communications, meaning that emails can be sent unless the recipient has explicitly opted out. Transactional purposes is set to disabled by default, meaning that the emails can always be sent. You can modify these settings based on your organization's requirements.

> [!TIP]
> If your target region's regulations allow it, leave the **Commercial Purpose** profile as a **Non-Restrictive** enforcement model. 
 
## Set up consent management for your organization

You can create your own compliance profile so that you can define the purpose for collecting and processing data and add topics that match your organization’s communication categories. You can also customize the Preference Center form&mdash;shown when users select **Unsubscribe**&mdash;to reflect your brand and give customers clear options to manage their preferences. 

The following considerations apply when setting up consent management in Dynamics 365 Sales:

- Consent is captured and stored at the contact point level. A contact point is the destination for a message, such as an email address or phone number. Each contact point can have its own consent status for different purposes. Dynamics 365 Sales currently supports email contact points only.

- The consent settings you configure apply only to emails sent by the sales AI agents, such as the Sales Qualification Agent and Sales Close Agent. 

To set up consent management, follow these steps:

The instructions to set up consent management in Dynamics 365 Sales are similar to those in Customer Insights – Journeys, except for the change in navigation paths in the Sales Hub app. The following steps outline the process and provide links to the relevant Customer Insights – Journeys documentation for detailed instructions.

1. Create a compliance profile. Go to **App Settings** > **General Settings** > **Compliance Profiles** in the Sales Hub app. Follow the instructions in [Set up a compliance profile](/dynamics365/customer-insights/journeys/real-time-marketing-compliance-settings#set-up-a-compliance-profile).
1. Create necessary purposes and topics within the compliance profile. Follow the instructions in [purposes](dynamics365/customer-insights/journeys/real-time-marketing-compliance-settings#purposes) and [topics](dynamics365/customer-insights/journeys/real-time-marketing-compliance-settings#topics).
1. Customize the Preference Center. Follow the instructions in [Creating preference centers](/dynamics365/customer-insights/journeys/real-time-marketing-preference-centers)
1. Import consent data if you have existing consent records. Go to **Sales** > **Consent Management** in the Sales Hub app. Use one of the following methods to import consent data: 
    1. If you have consent data in lead or contact records, import the consent data using the [load consent](/dynamics365/customer-insights/journeys/real-time-marketing-migrate-consent) feature.
    1. If you have consent data in an external system, use a [cloud flow](dynamics365/customer-insights/journeys/consent-record-creation).

## View and edit consent for a contact point

To view and edit consent for a specific contact point, open a lead record in Dynamics 365 Sales. Select the **Communication** tab to view the consent status for all purposes and for compliance profiles associated with the contact point. You can also update the consent status directly from this view. For example, you can change an existing opt-in to opt-out or update preferences for specific communication channels. Any changes made here will be honored across all integrated applications, including Customer Insights – Journeys.

:::image type="content" source="media/lead-communication-tab.png" alt-text="Screenshot of the Communication tab on a lead record showing consent status for different purposes.":::

## How consent is respected by sales AI agents

While configuring the agents, you can specify the compliance profile, purpose, and topic to be used for email communications sent by the agents. When a sales AI agent, such as the Sales Qualification Agent or Sales Close Agent, prepares to send an email, it checks the consent status of the contact point (email, in this case) against the relevant compliance profile and purpose. If the lead or contact has opted out of the specific purpose associated with the email, the agent will not send the email to that lead or contact.

- To configure consent settings for Sales Qualification Agent, refer to [Configure email settings for the Sales Qualification Agent](sales-qualification-agent-email-instruction-validation.md). 
- To configure consent settings for Sales Close Agent, refer to [Configure email settings for the Sales Close Agent (preview)](sales-close-agent-email-instruction-validation.md).

After consent is set up and configured, emails sent by the sales AI agents will include an **Unsubscribe** link that directs recipients to the Preference Center. Recipients can manage their communication preferences and opt out of specific topics as needed.

## Related information

- [Add a contactability grid control to custom forms](/dynamics365/customer-insights/journeys/contactability-control-custom-forms)
- [Consent management for business units](/dynamics365/customer-insights/journeys/real-time-marketing-consent-business-units)