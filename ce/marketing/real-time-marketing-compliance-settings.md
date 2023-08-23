---
title: Grow your business with multi-brand, custom preference centers
description: Learn how to manage real-time marketing user compliance settings in Dynamics 365 Marketing.
ms.date: 07/07/2023
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

# Manage user compliance settings in real-time marketing

[!INCLUDE[consolidated-sku-rtm-only](../includes/consolidated-sku-rtm-only.md)]

Managing compliance settings is key to ensuring your business processes conform with privacy laws such as the GDPR. This article gives an overview of administrator compliance setup, preference centers, and real-time marketing concepts. For information on outbound marketing compliance, visit [Outbound marketing compliance settings](privacy-use-features.md).

> [!VIDEO https://www.microsoft.com/videoplayer/embed/RW137KU]

## Real-time marketing compliance overview

To configure real-time marketing compliance, administrators can go to **Settings** > **Customer engagement** > **Compliance profiles** to define the consent model, the company address, and customize the preference center page for your end users.

### Contact point consent

A contact point is the destination for a message. For example, an email address or phone number is a contact point. Real-time marketing consent is contact point based, which means consent is stored per destination and per channel. For example, the email `somebody@example.com` has consented to receive commercial communications about upcoming events. This is different than outbound marketing's consent model that stored consent on the contact entity. With real-time marketing's contact point consent, customers have more control over where they want to receive marketing messages from your organization.

Another benefit of contact point consent is that it allows for real-time marketing to orchestrate journeys across any entity and enforce consent for leads, Customer Insights profiles, contacts, and any other entity.

### Compliance profiles

Compliance profiles are the containers of consent settings. In some instances, customers may want to separate consent for brands or lines-of-business (LOBs) by creating separate compliance profiles for each. Compliance profiles give marketers the ability to create specific consent settings for various LOBs. For instance, if there are headquarters in different regions whose physical address should show for recipients in that region, each compliance profile can have its own address.  

Another reason for having multiple compliance profiles would be to support different compliance requirements across regions. For example, a company that operates in the United States and France may choose to have a separate compliance profile for those two locations. Within the United States version, the commercial purpose could be set to a nonrestrictive enforcement model, because the U.S. isn't subject to GDPR regulations. Within the France version, however, they may set the commercial purpose to the restrictive enforcement model to require explicit consent before sending any commercial or promotional materials.

When you create a new compliance profile, you can **Use previously captured consent**. This option is intended to facilitate transitioning from a compliance profile with a preference page to one with a preference center. It creates new contact point consent records with the same consent values for the new compliance profile to ensure that any consent previously captured applies to the new compliance profile.

### Purposes

Data Use Purpose Consent (hereafter called “purpose”) defines the specific reason for which consent is collected. It's often associated with a specific legal basis or reason – for example, consent to be contacted for commercial marketing purposes. In Dynamics 365 Marketing, there are three purposes for consent scopes: (1) Commercial Communication, (2) Transactional Communication, and (3) Tracking Consent. When a compliance profile is created, there are three purposes created by default: a Commercial, Transactional, and Tracking purpose that can be customized to meet your specific needs.

Purpose consent also allows customers to create line-of-business (LOB) separation without using Dataverse business units or separate compliance profiles. Each LOB has a preference center configured for each business, and each LOB has a set of purposes associated with it that's specific to each LOB. Each message (for example, email or text message) is tied to a single preference center and an associated purpose.

Each organization may need to define separate purposes for each of their LOBs individually – for example, Contoso Northwest may want to manage consent independently from Contoso East. They would create a Commercial Communication Purpose for each LOB so they could manage opt-in or opt-out of Commercial Communication independently for each LOB.

### Topics

Each Purpose can contain topics to add specific communications types to allow customers to refine their communications preferences. For example, Contoso Northwest may want to add topics such as "Newsletters," "Daily Deals," and "Product Announcements" to the commercial purpose to allow their customers to decide which specific topics interest them. When creating a message to send, marketers must choose a purpose and can optionally choose a topic that has been created. Recipients can then choose to opt in or out of the topics that interest them.

Messages that have a topic chosen respect the enforcement model of the parent purpose. For example, if the parent purpose has a restrictive enforcement model, a contact point must have an opt-in record for both the purpose and the topic associated with the email.

### Enforcement model

There are three enforcement models for purposes that can be chosen depending on compliance regulations:

- **Restrictive**: Only contact points that have opted-in consent records for this purpose receive communications.
- **Non-restrictive**: Contact points with either opted-in or not set consent records for this purpose receive communications.
- **Disabled**: The communications for this purpose aren't checked for consent and sent to the entire audience.

> [!NOTE]
> Currently, all SMS and custom messages are subject to the restrictive enforcement model, even if their designated purpose has a non-restrictive enforcement model set. This behavior will change in a future release.

### Preference centers

Each compliance profile has its own preference center. When you create a new compliance profile, a default preference center is created that you can customize with your own branding. You can add different topics to its purposes to collect consent from that compliance profile. The unsubscribe links in emails direct recipients to the preference center from the compliance profile chosen on the email they received.

To learn more about preference centers, visit [Real-time marketing preference centers](real-time-marketing-preference-centers.md)

> [!NOTE]
> Currently, you can deactivate a compliance profile or contact point consent record. However, deactivated profiles and contact point consent records will still be used and enforced because existing journeys or messages sent may rely on them. Should you wish to update a user's consent, go to the contact point consent record itself and change the consent value.

### See also

[Manage consent for email and text messages in real-time marketing](real-time-marketing-email-text-consent.md)
[Real-time marketing preference centers](real-time-marketing-preference-centers.md)
[Outbound marketing compliance settings](gdpr-use-features.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
