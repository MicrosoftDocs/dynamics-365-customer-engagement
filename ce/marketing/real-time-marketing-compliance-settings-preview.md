---
title: "Preview: Grow your business with multi-brand, custom preference centers"
description: Learn how to manage real-time marketing user compliance settings in Dynamics 365 Marketing.
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

# Preview: Manage user compliance settings in real-time marketing

> [!IMPORTANT]
> A preview feature is a feature that is not complete, but is made available before it’s officially in a release so customers can get early access and provide feedback. Preview features aren’t meant for production use and may have limited or restricted functionality.
> 
> Microsoft doesn't provide support for this preview feature. Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions. Preview features aren’t meant for production use, especially to process personal data or other data that are subject to legal or regulatory compliance requirements.

Managing compliance settings is key to ensuring your business processes conform with privacy laws such as the GDPR. This article gives an overview of administrator compliance setup, preference centers, and real-time marketing concepts. Currently, the features described are in preview for customers who want to familiarize themselves with them. They aren't intended for production use until they're made generally available. For information on the current generally available compliance features for real-time marketing, visit [Real-time marketing compliance settings](real-time-marketing-compliance-settings.md). For information on outbound marketing compliance visit [Use GDPR Features](gdpr-use-features.md).
>

> [!VIDEO https://www.microsoft.com/videoplayer/embed/RW137KU]

## Enabling multi-brand consent and customizable preference centers

To enable this feature, an administrator will need to navigate to **Feature switches** under the **Overview** section of **Settings** and turn on **Multi-brand consent and customizable preference centers (preview)**. A description of the feature will open describing the details of what will happen once the feature is enabled. It’s important to note that once enabled, this feature switch cannot be disabled. Existing consent data is migrated to the new consent entities described below. You can visit the **Get started** page of **Real-time marketing** to track the status of the migration. There will be no change to existing consent or journeys during the migration, and you can continue to use the system as usual during the migration.

## Real-time marketing compliance overview

At the time of setup or later, an administrator will need visit **Compliance profiles** in the **Customer engagement** section of **Settings** to define the consent model, the company address, and customize the preference center page for your end users.

### Contact point consent

A contact point is the ultimate destination for a message (for example, an email address or phone number). Real-time marketing consent is contact point based. Customer consent is stored on a per-channel basis. For example, email somebody@example.com has consented to receive commercial communications about upcoming events. This is opposed to Outbound Marketing, where consent is stored per Contact entity record.  

The primary benefit of contact point consent is that it allows for real-time marketing to orchestrate journeys across any entity and enforce consent for Leads, Customer Insights profiles, Contacts, and any other entity.

### Compliance profiles

Compliance profiles are the containers of consent settings. To start, there's a single default compliance profile, which contains three purposes: Commercial, Transactional, and Tracking.  

In some instances, customers may want to separate consent for brands or lines-of-business (LOBs) by creating separate compliance profiles for each. Compliance profiles give marketers the ability to create specific consent settings for various LOBs. For instance, if there are headquarters in different regions whose physical address should show for recipients in that region, each compliance profile can have its own address.  

Another key reason for having multiple compliance profiles would be to support different compliance requirements across regions. For example, a company that operates in the United States and France may choose to have a separate compliance profile for those two locations. Within the United States version, the commercial purpose could be set to a nonrestrictive enforcement model, because the U.S. isn't subject to GDPR regulations. Within the France version, however, they may set the commercial purpose to the restrictive enforcement model to require explicit consent before sending any commercial or promotional materials.  

### Purposes

Data Use Purpose Consent (hereafter called “purpose”) defines the specific reason for which consent is collected. It's often associated with a specific legal basis or reason – for example, consent to be contacted for commercial marketing purposes, or consent to use my data for AI processing. In Dynamics Marketing, we’re primarily concerned with three purposes consent scopes – (1) Commercial Communication, (2) Transactional Communication and (3) Tracking Consent.

Purpose consent also allows customers to create line-of-business (LOB) separation without using Dataverse business units or separate compliance profiles. Each LOB has a preference center configured for each business, and each LOB will have a set of purposes associated with it that's specific to each LOB. Each message (for example, email, text message) is tied to a single preference center and an associated purpose.

Each organization may need to define separate purposes for each of their LOBs individually – for example, the Contoso Northwest may want to manage consent independently from Contoso East. They would create a Commercial Communication Purpose for each LOB so they could manage opt-in / opt-out of Commercial Communication independently for each LOB.

### Enforcement model

There are three different enforcement models for purposes that can be chosen depending on compliance regulations:

- **Restrictive**: Only contact points that have opted-in consent records for this purpose receive communications.

- **Non-restrictive**: Contact points with either opted-in or not set consent records for this purpose receive communications.

- **Disabled**: The communications for this purpose won't be checked for consent and will be sent to the entire audience.

> [!NOTE]
> Note: Currently all SMS messages are subject to the Restrictive enforcement model even if their designated purpose has a Non-restrictive enforcement model set. This behavior will change in a future release.

### Preference centers

Each compliance profile has its own preference center. When you create a new compliance profile, a default preference center is created that you can customize with your own branding, along with adding different purposes to collect consent from that compliance profile. The unsubscribe links in emails will direct recipients to the Preference center from the compliance profile chosen on the email they received.

To learn more about preference centers, visit [Real-time marketing preference centers](real-time-marketing-preference-centers.md)

### See also

[Work with data protection and GDPR](gdpr.md)
[Use GDPR features](gdpr-use-features.md)
