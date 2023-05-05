---
title: Compliance overview
description: Learn how to manage compliance settings in Dynamics 365 Marketing.
ms.date: 05/08/2022
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
search.audienceType: 
  - admin
  - customizer
  - enduser
---

# Manage user compliance settings

> [!IMPORTANT]
> This article applies to real-time marketing *and* outbound marketing.

Real-time and outbound marketing have distinct but related constructs for supporting consent and regulatory compliance for communications with customers. This article provides an overview of these differences along with references to more detailed information on ways to approach compliance.

## Consent data capture and storage

In real-time marketing, consent is captured and stored at the contact point. A contact point is the destination for a message (for example, an email address or phone number). Customer consent is stored on a per-channel basis. For example, the email `somebody@example.com` has consented to receive commercial communications about upcoming events.  

The primary benefit of contact point consent is that it allows real-time marketing to orchestrate journeys across any entity. Orchestrating across journeys means you can enforce consent for Leads, Customer Insights profiles, Contacts, and any other entity. This approach is opposed to outbound marketing journeys, which can only orchestrate journeys for Contact entities.

In outbound marketing, consent is captured and stored on the Contact entity in fields like `DoNotEmail` and `DoNotBulkEmail` that apply to the entire Contact record and all its email addresses. This approach doesn't allow for different consent to be captured for a contact’s multiple email addresses, phone numbers, etc.

## Compliance profiles

Compliance profiles are the hubs to manage consent and compliance in Dynamics 365 Marketing. Compliance profiles govern how consent is captured and enforced. Compliance profiles store information such as company address, the preference management experience, and related configuration. Compliance profile settings vary based on the type of compliance profile you're creating or modifying.  

Learn more: [Compliance profiles](real-time-marketing-compliance-settings-preview.md#compliance-profiles).  

## User contact preferences

There are four ways that users can manage their contact preferences: subscription centers, preference pages, external links, and preference centers.  

### Subscription centers

Outbound marketing subscription centers are marketing pages that known contacts can use to manage their communication preferences and contact details with your organization. All subscription centers include a "do not email" check box. When a contact chooses this option, the "do not bulk email" flag gets set on their contact record, and Dynamics 365 Marketing won't send any marketing email messages to that contact. Optionally, your subscription center can present several other subscription options, such as a list of available newsletters.  

Learn more: [Set up a subscription center](set-up-subscription-center.md)

Real-time marketing journeys can also use subscription centers if the journey targets contacts. Outbound subscription centers give you consent management flexibility, enabling you to create multiple subscription centers customized and branded to your needs.

Learn more: [Use outbound subscription centers in real-time journeys](real-time-marketing-outbound-subscription.md)

### Preference centers

Real-time marketing uses preference centers to enable customers to control the types of communications they wish to receive and the contact point at which they wish to receive them. Preference centers can be configured to match company branding and can include options for users to adjust the consent for various purposes that have been configured.  

Learn more: [Create real-time marketing preference centers](real-time-marketing-preference-centers.md)

### Preference pages

Real-time marketing uses preference pages as another way to manage user consent. A preference page is a web page where your customers can change their consent settings for receiving emails and text messages and for tracking. You can't create a new preference page. Instead, you can customize the language on the page for updating contact point consent as used in real-time marketing journeys. With the introduction of preference centers, existing preference pages will continue to support users updating their consent. However, moving forward, all new compliance profiles leverage the enhanced functionality of preference centers.  

Learn more: [Real-time marketing preference pages](real-time-marketing-compliance-settings.md)

### See also

[Grow your business with multi-brand, custom preference centers](real-time-marketing-compliance-settings-preview.md)
[Work with data protection and GDPR](gdpr.md)  
[Use GDPR features](gdpr-use-features.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
