---
title: "Troubleshoot email campaigns (Dynamics 365 Marketing) | Microsoft Docs"
description: "Troubleshooting and frequently asked questions for email campaigns in Dynamics 365 Marketing."
ms.date: 02/12/2021
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
ms.reviewer: renwe
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Troubleshoot email campaigns

## What types of lookup fields are supported?

Dynamics 365 Marketing uses the [same lookup types as other Dynamics 365 Customer Engagement apps](../customerengagement/on-premises/customize/types-of-fields.md#different-types-of-lookups). When creating an email template containing [dynamic content](dynamic-email-content.md) that will be used in customer journeys, however, you should make note of what entity type any **Customer** lookup field is referring to.

**Customer** lookup fields may reference a *contact* or an *account* entity, but not both. For example, you might create an email template containing the following dynamic content:
- "Hello {{contact.contact_contact_parentcustomerid.firstname}}”

The email's dynamic content references a *contact* entity. If you create a customer journey with segment members comprised of *contact* and *account* entities from **Customer** lookup fields, the above email template will only deliver to the *contact* entities. Any *account* entities in the segment will be blocked. 

To avoid blocked emails, the customer journey should filter segment members by the relationship to the *contact* entity or the *account* entity so that each segment member can be sent to the email template with the appropriate dynamic content.