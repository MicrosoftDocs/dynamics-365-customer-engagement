---
title: Set up business units and compliance profiles to support multi-brand businesses
description: Learn how to set up business units and compliance profiles to support multi-brand businesses.
ms.date: 05/08/2023
ms.custom: 
  - dyn365-marketing
ms.topic: reference
author: alfergus
ms.author: alfergus
search.audienceType: 
  - admin
  - customizer
  - enduser
---

# Set up business units and compliance profiles to support multi-brand businesses

[!INCLUDE[consolidated-sku-rtm-only](../includes/consolidated-sku-rtm-only.md)]

Dynamics 365 Marketing provides robust and configurable techniques to manage branding and compliance needs across multi-brand businesses. The approach to take depends on several factors including privacy, compliance, data access, and convenience. This article outlines some approaches, including their pros and cons.  

## Business units vs. compliance profiles

In general, a business unit’s primary function is to control access to records based on who is using the app and who owns each record. Business units are mapped to an organization's departments or divisions, so if your organization is structured around departments or divisions that have separate products, customers, and segments, you might want to create business units.

For organizations that have strict data access policies across lines of business, business units ensure that users can only access the information available to the business unit they're a part of. Business units are also hierarchical, so there are ways to share certain information across business units. In addition, there are important differences between how business units work with real-time and outbound marketing. To learn more about business units, visit [Use business units to control access to Marketing records](business-units.md).

A compliance profile, on the other hand, is intended to allow companies to set up different compliance regimes, particularly in instances where data access is shared across lines of business. For instance, a company with multiple brands that are shared across a common marketing organization may want to build specific compliance profiles for each brand but leverage the same underlying contacts and leads for marketing and transactional communications.  

Compliance profiles allow each brand to have its own set of purposes and topics related to that brand, as well as branded preference centers and email collateral. To learn more about compliance profiles, data use purposes (generally known as “purposes), and topics, visit [Real-time marketing compliance settings](real-time-marketing-compliance-settings.md).

The data model allows the flexibility to build a hierarchy depending upon your needs:

- One business unit can have multiple compliance profiles
- One compliance profile can have multiple purposes

A customer receiving communications can opt in or opt out of individual purposes.

## Use only business units with individual compliance profiles

Using individual business units with their own compliance profiles is most appropriate when specific business units or bands operate fully independently and shouldn’t share any information about contacts, leads, compliance settings, etc.

For example, Contoso Metal Products and Contoso Electronics are two business units in the Contoso enterprise. Each has its own marketing department, and the products are independent. In addition, the business units shouldn’t share any information about their prospects or customers.

In this instance Contoso should set up a specific business unit for each. This enables the marketing departments at each to manage their compliance settings independently, without any overlap or concerns around data crossing boundaries. Each would have its own segments, journeys, emails, and other settings.

## Use only compliance profiles without business units

An organization that wishes to share leads and contacts across different business units or brands could avoid setting up Dynamics 365 Marketing business units and instead rely on compliance profiles to manage customer consent.

For example, Contoso Sportswear and Contoso Workwear are two brands in the Contoso enterprise. While each has distinct customers, there's also overlap between the customers and Contoso wants to facilitate cross-selling to grow their brand loyalty among customers.

In this circumstance Contoso could opt to create distinct compliance profiles for each brand without segregating the underlying data with business units. This allows Contoso and its brands to accomplish key objectives:

- Create distinctly branded email messages and preference centers for the two brands
- Share communication purposes across compliance profiles, enabling customers to opt in or opt out from either all Contoso communications or individual brand communications
- Administer their marketing solution with the common marketing team
- Create customer segments and journeys for either an individual brand or across brands

## Use brand profiles and multiple compliance settings

For complex organizations or those managing compliance across multiple jurisdictions and regulatory approaches, it may make sense to leverage both business units and compliance profiles within a business unit.

For example, Contoso Sportswear may have a division in Germany and a division in the United States, while Contoso Workwear only operates in the United States. Due to different regulatory needs, Contoso Germany needs to keep its data separate from any Contoso operations in the United States. Due to this, Contoso Germany may want to have its own business unit with its own compliance profile to send sportswear communications to its German customers.

In addition, Contoso would create a separate business unit to support Contoso’s United States sportswear division and its workwear division with two compliance profiles, as described in the previous section.

The organizational approach supports critical data isolation requirements while also enabling Contoso United States to take advantage of cross-brand marketing opportunities as appropriate.

### See also

[Work with data protection and GDPR](gdpr.md)  
[Use GDPR features](gdpr-use-features.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
