---
title: Data protection and privacy
description: "Protect customer privacy and remain compliant with GDPR regulations with Dynamics 365 Marketing."
ms.date: 04/21/2023
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

# Data protection and privacy

The [General Data Protection Regulation (GDPR)](https://www.ecb.europa.eu/services/data-protection/) is a European Union (EU) directive that imposes rules on companies, government agencies, non-profits, and other organizations that offer goods and services to people in the EU, or that collect and analyze data tied to EU residents. The GDPR applies no matter where you're located.

Dynamics 365 Marketing is prepared to help organizations work in compliance with the GDPR when using the system, but some development work, consultancy assistance, or both, is still necessary. As part of a comprehensive, organization-wide effort, most organizations need to review and update all their information systems to come into complete compliance.

## Learn more about the GDPR

Here are some resources where you can learn more about how to bring your Dynamics 365 systems into compliance with the GDPR:

- [Supporting Your EU GDPR Compliance Journey with Dynamics 365 Marketing](https://servicetrust.microsoft.com/ViewPage/TrustDocuments?command=Download&downloadType=Document&downloadId=b26973bd-68c3-4507-b446-61a7f1b1f1f2&docTab=6d000410-c9e9-11e7-9a91-892aae8839ad_FAQ_and_White_Papers). This white paper (downloadable PDF) will help you build a basic understanding of the GDPR and relate that to Dynamics 365 Marketing.
- [Data Protection Resources](https://servicetrust.microsoft.com/ViewPage/TrustDocuments?docTab=6d000410-c9e9-11e7-9a91-892aae8839ad_FAQ%20and%20White%20Papers). This webpage includes links to compliance guides, white papers, FAQs, security reports, penetration tests, risk assessment tools, and other resources that apply to a wide range of Microsoft products.
- [Microsoft Trust Center](https://www.microsoft.com/trustcenter). This webpage includes links to information about how new features in Microsoft 365 help you secure personal data and meet strict GDPR privacy requirements.
- [Microsoft Purview Compliance Manager](https://aka.ms/compliancemanager). This webpage includes links to information about control management, integrated task assignment, evidence collection, and audit-ready reporting tools to streamline your compliance workflow.

## Prepare Dynamics 365 Marketing for GDPR compliance

Most Dynamics 365 installations are customized to meet the specific needs of each organization that uses it. Some organizations have in-house developers, and some organizations work with external partners or consultants to implement their customizations. Either way, you must customize your Dynamics 365 Marketing system to enable its built-in GDPR compliance tools to function correctly.

Among other things, you must be able to identify all data structures (including tables, entities, and fields) that contain personal information. You should establish mechanics that allow you to easily discover, deliver, update, and/or delete this data when requested by your customer.

- For more information on how Dynamics 365 helps you with essential data tasks like discovering, managing, protecting, and reporting for your GDPR compliance see the guide [Microsoft Dynamics 365 helps enable data privacy for GDPR compliance](https://www.microsoft.com/TrustCenter/CloudServices/dynamics365/GDPR) in the [Microsoft Trust Center](https://www.microsoft.com/trustcenter).
- For details about how to use the Dynamics 365 API to implement custom GDPR-related functionality for your Dynamics 365 Marketing system, see the [Developer Guide (Marketing)](developer/marketing-developer-guide.md).
- If you're looking for a partner to help you come into compliance, try searching in our [Microsoft Solution Providers database](https://www.microsoft.com/solution-providers/search).

The rest of this article describes how to work with the GDPR compliance tools in Dynamics 365 Marketing. The instructions assume that the system has already been customized as required.

## Overview of GDPR features in Dynamics 365 Marketing

Under the GDPR, the topic of consent has become a core tenet and is included in the data protection law. Consent is understood as "any freely given, specific, informed, and unambiguous indication of the data subject's wishes by which they, by a statement or by a clear affirmative action, signifies agreement to the processing of personal data relating to them."

Dynamics 365 Marketing allows you to request, capture, and store consent. It lets you design your marketing activities to respect the consent given by your audience. It's important that you include relevant information in your marketing objects (like landing pages and email marketing message) that unambiguously informs your audience about the data you collect and the purpose of your processing. Your audience must have the option to give consent freely, make an informed decision, and be able to review, update, or revoke consent at any time.

To help you with consent management and other GDPR-related workloads, Dynamics 365 Marketing has the following capabilities:

- A default collection of hierarchical consent levels is provided out of the box, where higher levels of consent include lower levels.
- Contact records include a field that stores the level of consent each contact has granted your organization.
- You can configure each customer journey to only process contacts that have given a minimum-required level of consent.
- You can configure each lead-scoring model to only compute scores for leads associated with contacts that have given a minimum-required level of consent.
- You can create marketing pages with marketing forms that encourage contacts to grant a level of consent while being unambiguously informed. The consent is stored in each contact's record.
- You'll be able to use various mechanics in Dynamics 365 Marketing to extract all information related to a specific contact and share relevant information with that contact when requested.
- You'll be able to use mechanics to have Dynamics 365 Marketing "forget" (delete) all information about a specific contact when requested. To learn more about deleting customer data, see the [Deleting customer data](/compliance/regulatory/gdpr-dsr-Dynamics365#deleting-customer-data) section in the [Dynamics 365 Data Subject Requests for the GDPR and CCPA](/compliance/regulatory/gdpr-dsr-Dynamics365) article.
- You'll be able to find and update information about a specific contact when requested.
- You'll be able to provide means for your contacts to ask to view, retrieve, update, and delete their consent and data, and to use Dynamics 365 Marketing to model the fulfillment on your side.

The consent levels provided out of the box are just recommendations. It's up to you to decide the relevance of each level, and how you would like to use it in your marketing activities. The following table summarizes each supplied consent level and how it's typically used. Consent levels are hierarchical, so higher levels include all lower levels.

| Level | Consent level name | Description |
|-------|--------------------|-------------|
| 0 | (none) | No consent has been given by the contact. The organization shouldn't reach out to the individual or perform data processing or automated decision making until consent is given. Regardless of the given consent, individuals can submit information using an online form (landing page) provided by the organization.    |
| 1 | Consent | The individual allows the organization to reach out only to confirm consent or obtain a higher level of consent. A typical example is a re-consenting customer journey that sends an email containing a link to a subscription center page where the individual can give consent.    |
| 2 | Transactional | The individual consents to be sent transactional messages that relate to specific, existing business between the two parties. These messages can't include marketing or promotional content. Examples include bank statements, order receipts, and membership status messages.  |
| 3 | Subscriptions | The individual consents to receive messages that include offers to sign up for mailing lists or other subscribed content.   |
| 4 | Marketing | The individual agrees to receive marketing messages and promotional content. |
| 5 | Profiling | The individual allows the organization to use demographic and behavior information (such as website visits, email opens, and email clicks) for automated decision making. It's the organization's responsibility to classify which of their processing activities fall under the category of automated decision making. Examples include automatic calculation of credit limits or loan promises based on available data, and calculation mechanics using rule-based or predictive calculations. Children shall never be subject to such profiling and automated decision making. |

In addition, special privacy protection is required for minors (children), requiring additional consent by a parent or guardian.

> [!IMPORTANT]
> The accounts entity does not store any GDPR consent information&mdash;only contact entities include it. Lead-scoring models that operate on the account level aren't able to respect the consent of the contacts that belong to that account, but they can still score account leads based on interactions generated by all of those contacts. That means that you must be careful not to use automatic lead scoring for automated decision making (profiling) related to account-based leads if those decisions affect individuals. You can still use the feature to score account leads, but you must not use it for indirect contact scoring if the score is used for automated decision making. More information: [Account-based marketing](account-based-marketing.md)

### See also

[Manage user compliance settings](real-time-marketing-compliance-settings.md)  
[Use GDPR features](gdpr-use-features.md)  
[Create and deploy marketing pages](create-deploy-marketing-pages.md)  
[Set up a subscription center](set-up-subscription-center.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
