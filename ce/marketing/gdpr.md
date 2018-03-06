---
title: "Work with data protection and GDPR (Dynamics 365 for Marketing) | Microsoft Docs  "
description: "Protect customer privacy and remain compliant with GDPR regulations with Dynamics 365 for Marketing"
keywords: "GDPR; data protection; privacy"
ms.date: 12/15/2017
ms.service: crm-online
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: dbc6f586-d4ba-4cdb-aa93-c1f92d61b262
author: kamaybac
ms.author: kamaybac
manager: sakudes
ms.reviewer: renwe
topic-status: Drafting
---

# Data protection and GDPR

The General Data Protection Regulation (GDPR) is a European Unction (EU) directive that requires organizations operating within the EU to respect the privacy of EU citizens and obtain explicit consent to contact them or use their personal information in any data automation or storage system. [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] is prepared to help organizations work in compliance with the GDPR when using the system, but some development work and/or consultancy assistance is still necessary. Most organizations will need to review and update all their information systems to come into complete compliance as part of a comprehensive, organization-wide effort.

## Learn more about GDPR

Here are some resources where you can learn more about how to bring your [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] systems into compliance with GDPR:

- [Microsoft Dynamics 365 and GDPR](https://docs.microsoft.com/en-us/dynamics365/get-started/gdpr/index?branch=gdpr-hub): provides links to resources, white papers, blogs, and other information related to various [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] applications and GDPR
- [Data Protection Resources](https://servicetrust.microsoft.com/ViewPage/TrustDocuments?command=Download&downloadType=Document&downloadId=0d9fa3e6-940b-4e65-a4b2-f03ccc9f074f&docTab=6d000410-c9e9-11e7-9a91-892aae8839ad_FAQ%20and%20White%20Papers): provides links to compliance guides, whitepapers, FAQs, security reports, penetration tests, risk assessment tools and other resources that apply to a wide range of Microsoft products
- [Microsoft Trust Center](https://www.microsoft.com/en-us/trustcenter): Discover how new features in Microsoft 365 help you secure personal data and meet strict GDPR privacy requirements
- [Microsoft Compliance Manager](https://aka.ms/compliancemanager): Control management, integrated task assignment, evidence collection, and audit-ready reporting tools to streamline your compliance workflow

## Prepare [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] for GDPR compliance

Most [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] installations are significantly customized to meet the specific needs of each organization that uses it. Some organizations have in-house developers, while others work with external partners or consultants to implement their customizations. Either way, you must customize your [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] system to enable its built-in GDPR compliance tools to function correctly.

Among other things, your database must be updated to identify which tables and fields contain personal information that must be easily discovered, delivered, updated, or deleted on request.

- For details about how to use the [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] API to enable GDPR functionality for your [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] system, see the [Developer Guide (Marketing)](developer/marketing-developer-guide.md).
- If you're looking for a partner to help you come into compliance, try searching in our [Microsoft Solution Providers database](https://www.microsoft.com/en-us/solution-providers/search).

The remainder of this topic describes how to work with the GDPR compliance tools in [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]. Those instructions assume that the system has already been customized as required.

## Overview of GDPR features in [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]

When GDPR is enabled, the following features are provided:
- Contact records include fields that store the levels of consent each contact has granted to your organization.
- You can set your lead-scoring models to only compute scores for leads associated with contacts that have granted the appropriate level of consent.
- You can set each customer journey to only process contacts that have granted the appropriate  level of consent.
- You can create marketing forms that enable contacts to grant various levels of consent, with submissions stored in each contact's record.
- You'll be able to extract all information related to a specific contact and share that information with that contact when requested.
- You'll be able to tell [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] to "forget" (delete) all information about a specific contact when requested.
- You'll be able to find and update information about a specific contact when requested.

The following tables summarizes each level of consent and what it means. Consent levels are hierarchical, so higher levels include all lower levels.

| Level | Consent level name | Description |
|-------|--------------------|-------------|
| 0 | (none) | The organization may not contact the individual with any type of   unsolicited communication. But the organization may provide an online form   (landing page) that an individual can open and use to register with that   organization. Landing page submissions are always recorded, but a submission   doesn't imply any consent by the individual other than to receive a request   for further consent (such as for double opt-in). Landing pages can also   include features that enable contacts to upgrade their consent level   explicitly after they are opted in.    |
| 1 | Consent | Allows the organization to contact an individual for purposes of   obtaining a higher level of consent only. A typical example is a confirmation   email for double opt-in.    |
| 2 | Transactional | Allows the organization to contact an individual with transactional   messages that relate to specific, existing business between the two parties.   These messages can't include marketing or promotional content. Examples   include bank statements, order receipts, and membership status messages.    |
| 3 | Subscriptions | Allows the organization to send messages that offer individuals a,chance to sign up for mailing lists or other subscribed content.   |
| 4 | Marketing | Allows the organization to send marketing messages to the individual,based on which subscriptions they have agreed to. |
| 5 | Profiling | Allows the organization to collect behavior-tracking data such as,website visits, email opens, and email clicks. It also allows organization to,use behavior-tracking data and demographic data to make automated decisions.,This includes automated lead scoring, customer journeys with decision points,,and predictive services. |

In addition, special privacy protection is required for minors (children), requiring additional consent by a parent or guardian.

## Enable GDPR features in [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]

GDPR features are disabled by default on new [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] installations. To enable or disable the features, go to **Settings** > **Advanced settings** > **Marketing settings** > **Data protection tools**.

## View and set the consent level for each contact

When GDPR is enabled for your site, all contact records include a **GDPR** section with a drop-down list labelled **GDPR consent**. You can read or set the consent level here.
 
## Filter segments by consent

You can filter segments by consent level just like you can when filtering by other contact values.

## Set the consent level for a customer journey

You can set the minimal consent level for any customer journey. When set, the journey will only process contacts of that level or higher. To do this, open the journey and set **Required consent** to the minimal consent level.

If you change the consent level of a running customer journey, then the journey will stop processing any contacts that don't meet that level of consent, including contacts that are already partly through the journey.

## Set the consent level for lead scoring models

You can set the minimal consent level for any lead scoring model. When set, the model will only score leads associated with contacts that have granted that consent level or higher.

To do this, open the lead scoring model, go to the **Summary** tab and choose the minimal consent level from the **Required consent** drop-down list.

## Respond to get-my-data requests

When a customer requests a copy of all data your organization has about them, do the following:

- Open the relevant contact record and use the built-in export feature.
- Create a new Power BI report that fetches all interaction data from [!INCLUDE[pn-customer-insights-full](../includes/pn-customer-insights-full.md)] .

## Respond to forget-me requests

When GDPR is enabled, then deleting a contact should have the following effects:

- The contact record is permanently (hard) deleted.
- All related interaction records stored in [!INCLUDE[pn-customer-insights-full](../includes/pn-customer-insights-full.md)] are deleted.
- All custom entities are de-linked from the contact record and all personal information is removed from them. 

Note that some of this functionality requires that your system be customized by a developer or partner, especially when it comes to clearing information from custom entities and fields.

Note also that all data entered into a forward-to-a-friend form is automatically deleted after 30 days, so no new contact or lead records are created unless a recipient of the forward chooses to register with your organization using a landing page.

## Set the default consent for marketing pages

You can assign a default consent level to a marketing page. When an individual submits that page, their contact new or existing contact record will be updated to show that level of consent, unless the current consent level is higher than this.

To set the default consent level of a marketing page, use its **Default consent** setting.

## Include a consent selector for a subscription center

A subscription center is probably the best place to enable contacts to modify their consent level. To set this up:

- Set up a marketing form field that maps to the GDPR consent field of the contact entity.
- Create a subscription-center form that includes the GDPR consent field.
- Create a subscription-center page that includes that form.


