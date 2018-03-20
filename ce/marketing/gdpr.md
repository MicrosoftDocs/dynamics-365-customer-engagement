---
title: "Work with data protection and GDPR (Dynamics 365 for Marketing) | Microsoft Docs  "
description: "Protect customer privacy and remain compliant with GDPR regulations with Dynamics 365 for Marketing"
keywords: "GDPR; data protection; privacy"
ms.date: 04/01/2018
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

# Data protection and the GDPR

The [General Data Protection Regulation (GDPR)](http://ec.europa.eu/justice/data-protection/reform/index_en.htm) is a European Union (EU) directive that imposes new rules on companies, government agencies, non-profits, and other organizations that offer goods and services to people in the EU, or that collect and analyze data tied to EU residents. The GDPR applies no matter where you are located.

[!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] is prepared to help organizations work in compliance with the GDPR when using the system, but some development work, consultancy assistance, or both, is still necessary. As part of a comprehensive, organization-wide effort, most organizations need to review and update all their information systems to come into complete compliance.

## Learn more about the GDPR

Here are some resources where you can learn more about how to bring your [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] systems into compliance with the GDPR:

- [Microsoft Dynamics 365 and GDPR](https://docs.microsoft.com/dynamics365/get-started/gdpr/index). This webpage includes  links to resources, white papers, blogs, and other information related to various [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] applications and the GDPR.
- [Data Protection Resources](https://servicetrust.microsoft.com/ViewPage/TrustDocuments?docTab=6d000410-c9e9-11e7-9a91-892aae8839ad_FAQ%20and%20White%20Papers). This webpage includes links to compliance guides, white papers, FAQ, security reports, penetration tests, risk assessment tools and other resources that apply to a wide range of Microsoft products.
- [Microsoft Trust Center](https://www.microsoft.com/trustcenter). This webpage includes links to information about how new features in Microsoft 365 help you secure personal data and meet strict GDPR privacy requirements.
- [Microsoft Compliance Manager](https://aka.ms/compliancemanager). This webpage includes links to information about control management, integrated task assignment, evidence collection, and audit-ready reporting tools to streamline your compliance workflow.

## Prepare [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] for GDPR compliance

Most [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] installations are customized to meet the specific needs of each organization that uses it. Some organizations have in-house developers, and some organizations work with external partners or consultants to implement their customizations. Either way, you must customize your [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] system to enable its built-in GDPR compliance tools to function correctly.

Among other things, you must be able to identify all data structures (including tables, entities, and fields) that contain personal information. You should establish mechanics that allow you to easily discover, deliver, update, and/or delete this data when requested by your customer. 
- For more information on how Dynamic 365 helps you with essential data tasks like discovering, managing, protecting, and reporting for your GDPR compliance see the guide [Microsoft Dynamics 365 helps enable data privacy for GDPR compliance](https://www.microsoft.com/en-us/TrustCenter/CloudServices/dynamics365/GDPR) in the [Microsoft Trust Center](https://www.microsoft.com/trustcenter).
- For details about how to use the [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] API to implement custom GDPR related functionality for your [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] system, see the [Developer Guide (Marketing)](developer/marketing-developer-guide.md).
- If you're looking for a partner to help you come into compliance, try searching in our [Microsoft Solution Providers database](https://www.microsoft.com/solution-providers/search).

The remainder of this topic describes how to work with the GDPR compliance tools in [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]. The instructions assume that the system has already been customized as required.

## Overview of GDPR features in [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]

Under the GDPR, the topic of consent has become a core tenant and is included in the data protection law. Consent is understood as "any freely given, specific, informed and unambiguous indication of the data subject's wishes by which he or she, by a statement or by a clear affirmative action, signifies agreement to the processing of personal data relating to him or her."

[!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] allows you to request, capture, and store consent. It lets you design your marketing activities to respect the consent given by your audience. It is important that you include relevant information in your marketing objects (like landing pages and email marketing message) that unambiguously informs your audience about the data you collect and the purpose of your processing. Your audience must have the option to give consent freely, make an informed decision, and be able to review, update or revoke consent at any time.

To help you with consent management and other GDPR related workloads, [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] has the following capabilities:

- A default collection of hierarchical consent levels is provided out of the box, where higher levels of consent include lower levels.
- Contact records include a field that stores the level of consent each contact has granted to your organization.
- You can configure each customer journey to only process contacts that have  given a minimum required level of consent.
-  You can configure each lead-scoring model to only compute scores for leads associated with contacts that have given a minimum required level of consent.
- You can create marketing pages with marketing forms that encourage contacts to grant a level of consent while being unambiguously informed. The consent is stored in each contact's record.
- You’ll be able to use various mechanics in [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] to extract all information related to a specific contact and share relevant information with that contact when requested.
- You'll be able to use mechanics to have [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] "forget" (delete) all information about a specific contact when requested.
- You'll be able to find and update information about a specific contact when requested.
- You'll be able to provide means for your contacts to request to view, retrieve, update, and delete their consent and data, and to use [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] to model the fulfillment on your side.

The consent levels provided out of the box are just recommendations. It is up to you to decide the relevance of each level, and how you would like to use it in your marketing activities. The following table summarizes each of supplied consent level and how it is typically used. Consent levels are hierarchical, so higher levels include all lower levels.


| Level | Consent level name | Description |
|-------|--------------------|-------------|
| 0 | (none) | No consent has been given by the contact. The organization should not reach out to the individual or perform data processing or automated decision making until consent is given. Regardless of the given consent, individuals can submit information using an online form (landing page) provided by the organization.    |
| 1 | Consent | The individual allows the organization to reach out only to confirm consent or obtain a higher level of consent. A typical example is a re-consenting customer journey that sends an email containing a link to a subscription center page where the individual can provide consent.    |
| 2 | Transactional | The individual consents to be sent transactional messages that relate to specific, existing business between the two parties. These messages can't include marketing or promotional content. Examples include bank statements, order receipts, and membership status messages.  |
| 3 | Subscriptions | The individual consents to receive messages that include offers to sign up for mailing lists or other subscribed content.   |
| 4 | Marketing | The individual agrees to receive marketing messages and promotional content. |
| 5 | Profiling | The individual allows the organization to use demographic and behavior information (such as website visits, email opens, and email clicks) for automated decision making. It is the organization's responsibility to classify which of their processing activities fall under the category of automated decision making. Examples include automatic calculation of credit limits or loan promises based on available data, and calculation mechanics using rule-based or predictive calculations. Children shall never be subject to such profiling and automated decision making. |

In addition, special privacy protection is required for minors (children), requiring additional consent by a parent or guardian.

## Enable GDPR features in [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]

By default, GDPR features such as consent management are disabled on new [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] installations. To enable or disable the features, go to **Settings** > **Advanced settings** > **Marketing settings** > **Data protection tools**.

## View and set the consent level for each contact

All contact records include a **GDPR** section with a drop-down list labelled **GDPR consent**. You can read or set the consent level here. This setting only has an affect when you have enabled the GDPR features.
 
## Filter segments by consent

You can filter segments by consent level just like you can when filtering by other contact values.

## Set the minimum required consent level for a customer journey

You can set the minimal consent level for any customer journey. When set, the journey will process only contacts of that level or higher. To do this, open the journey and set **Required consent** to the minimal consent level.

If you change the consent level of a running customer journey, the journey stops processing any contacts that don't meet that level of consent, including contacts that are already partly through the journey.

## Set the minimum required consent level for lead scoring models

You can set the minimal consent level for any lead-scoring model. When set, the model scores only leads that are associated with contacts who have granted that consent level or higher.

To do this, open the lead scoring model, go to the **Summary** tab, and choose the minimal consent level from the **Required consent** drop-down list.

## Include a consent selector in a subscription center
A subscription center is probably the best place to enable contacts to confirm and modify their consent level. To set this up:

- Set up a marketing form field that maps to the GDPR consent field of the contact entity.
- Create a marketing form of type subscription-center that includes the GDPR consent field.
- Create a marketing page of type subscription-center that includes that form.

You can now create a marketing email message that includes a link to your subscription-center page. Make sure your page explains why granting consent is important and how it provides value to the individual.

## An example of how to support data requests from your marketing audience
Under GDPR, individuals have the right to submit several types of data requests to your organization. These include requests to access, correct, erase, and transmit (in a readable format) their personal data. A user-friendly way to support this could be to create a marketing page that provides a request form, and then set up a customer journey that reacts to page submissions by generating tasks for your privacy officer. You could proceed as follows:

1. Create a marketing form that enables an individual to enter their contact information and provides a drop-down list with the following options:
    - Please send me all the data you have about me.
    - Please let me update my data.
    - Please forget me and remove all the data you have about me.
1. Create a branded landing page that includes the form.
1. Create a customer journey that starts with the landing page, followed by an activity tile that generates GDPR tasks for your privacy officer. Each generated activity should include the ID of a contact that submitted the form and also specify the type of request selected by that contact.

## Respond to get-my-data requests

When a customer requests a copy of all data your organization has about them, you could do one of the following:
- Open the relevant contact record and use out-of-the-box search functionality to identify relevant data. Then use the built-in export capabilities or build a custom reporting solution.
- Create a new Power BI report that loads the relevant data from [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)].
- Create a custom solution based on the dedicated API in [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] that lets you load all the relevant interactions from the back-end system. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Developer Guide (Marketing)](developer/marketing-developer-guide.md)

## Respond to forget-me requests

When a customer requests to be forgotten, you must identify the relevant data and then delete it using the out-of-the-box functionality in [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)]. Proceed as follows:

- Identify the contact and relevant related data.
- Consider deleting the record permanently (a so-called _hard delete_).
- On deleting the contact record, all related interaction data stored in [!INCLUDE[pn-customer-insights-full](../includes/pn-customer-insights-full.md)] will automatically be unlinked and removed.
- If you have any custom entities, then you must also delete all related personal data from them and/or unlink them from the contact record such that all personal information is removed.

Note that some of this functionality requires that your system be customized by a developer or partner, especially when it comes to clearing information from custom entities and fields.

Note also that all data entered into a forward-to-a-friend form is automatically deleted after 30 days, so no new contact or lead records are created unless a recipient of the forward chooses to register with your organization using a landing page.