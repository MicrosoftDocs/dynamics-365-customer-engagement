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

All contact records include a **Data protection** section with a drop-down list labelled **Consent given**. You can read or set the consent level here. This setting only has an affect when you have enabled the GDPR features.
 
## Filter segments by consent

You can filter segments by consent level just like you can when filtering by other contact values.

## Set the minimum required consent level for a customer journey

You can set the minimal consent level for any customer journey. When set, the journey will process only contacts of that level or higher. To do this, open the journey, go to its **General** tab, and set the **Minimum consent** field to the appropriate level.

If you change the consent level of a running customer journey, the journey stops processing any contacts that don't meet that level of consent, including contacts that are already partly through the journey.

## Set the minimum required consent level for lead scoring models

You can set the minimal consent level for any lead-scoring model. When set, the model scores only leads that are associated with contacts who have granted that consent level or higher.

To do this, open the lead scoring model, go to the **Summary** tab, and set the **Minimum consent** field to the appropriate level.

## Include a consent selector in a subscription center
A subscription center is probably the best place to enable contacts to confirm and modify their consent level. To set this up:

- Set up a marketing form field that maps to the GDPR consent field of the contact entity.
- Create a marketing form of type subscription-center that includes the GDPR consent field.
- Create a marketing page of type subscription-center that includes that form.

You can now create a marketing email message that includes a link to your subscription-center page. Make sure your page explains why granting consent is important and how it provides value to the individual.

## An example of how to support data requests from your marketing audience

Under GDPR, individuals have the right to submit several types of data requests to your organization. These include requests to access, correct, erase, and transmit (in a readable format) their personal data. [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] is a very flexible and versatile system, so there are many ways to build GDPR compliance features into it. This section provides a few examples of how to do this, but the methods you choose will depend on how your organization is structured, how it uses [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)], and which types of customizations are in place.

### Set up a customer journey for accepting GDPR requests

One way to make it easy for individuals to submit GDPR requests to your organization could be to publish a page on your website that provides relevant details to your customer and includes links for each type of request (send me my data, update my data, and delete my data). Each of those links would bring the customer to a different [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] marketing page, which provides:

- Further information about the specific type of request and what the customer can expect on submitting the form.
- All the input fields required to uniquely identify the contact in your database. This is typically their email address and last name, but the actual requirements will depend on your deduplication settings.
- Any additional fields that might help your privacy officer fulfil the request (such as a field for general notes and comments, or checkboxes with special options).

Then prepare a single customer journey with three parallel pipelines, one for each request type. You could set up each pipeline as follows:

1. Start with a marketing form designed to collect information relevant to the request type. When a contact submits this form, they begin travelling on that path of the journey.
1. Continue to an activity tile, which is configured with a task-activity template that identifies the request type (update, send, or delete) and assigns a task to the security officer responsible for responding to the request. The task will include a link to the contact record, so the officer can easily go there to read the full content of the page submission.
1. End with an email message, which informs the customer that their request was received, and which provides additional links and instructions (such as a subscription center link), depending on which type of request it is.
 
The remaining subsections of this section provide some additional details about how this example solution could be completed to support each type of request.

### Respond to get-my-data requests

The following list provides a few ideas for how your organization could set up a system for responding to get-my-data requests. The solution you choose will depend on how your system is set up and which types of customizations are in place.

- Instruct your privacy officer to use the standard search functionality to identify relevant data and then use the built-in export capabilities to generate an Office document. No custom development is required to allow this, but for a heavily customized system it could prove to be impractical.
- Create a custom solution based on the dedicated API in [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] that loads all the relevant information from the back-end system and assembles it into a single, portable document. This would require some custom development, but the result could provide a faster and easier solution for your privacy officer to use. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Developer Guide (Marketing)](developer/marketing-developer-guide.md)
- Set up a custom reporting solution in [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)].
- Create a new Power BI report that loads the relevant data from your [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] organization database.

### Respond to forget-me requests

Ideally, you should prepare your system to make it easy for your privacy officer to completely delete a contact and all their related data on request. 

- For a non-customized system, your privacy officer can just use the standard search function to find the contact and then hard-delete the contact. The system will automatically unlink and remove all related interaction data stored in [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] back-end systems (such as [!INCLUDE[pn-customer-insights-full](../includes/pn-customer-insights-full.md)]).
- If you have custom fields or entities, then you must further customize your system to make sure it deletes all related personal data from related records and/or unlinks them from the contact record such that all personal information is removed. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Developer Guide (Marketing)](developer/marketing-developer-guide.md)


> [!NOTE]
> All data entered into a forward-to-a-friend form is automatically deleted after 30 days, so no new contact or lead records are created unless a recipient of the forward chooses to register with your organization using a landing page.

### Respond to update-my-data requests

One way to prepare your system to handle update-my-data requests could be to set up the following:

1. For the update-my-data landing page, be sure to include both the required contact fields and a general comment field where the customer can describe their request if needed.
1. Prepare a subscription center page that has as many editable contact fields as would be safe to provide. This would enable each customer to update their own information as much as possible.
1. For the marketing email message sent to the contact after submitting the form, include a link to that subscription center and include information about what to do if the customer wants to update information that is not included on that form.

As mentioned earlier, when a privacy officer receives the task generated by the customer journey, they can click the included link to open the relevant contact record, open the insights for that record and then go to the **Marketing form interactions** tab, where they can read the full content of the form submission (for example, as a tooltip for the relevant **Form submission** value in the **Form visited list**). If needed, the privacy officer can contact the customer directly to resolve any of the special requests (such as to update data not provided on the subscription center form).
 
### Secure and control access to personal information

Part of the GDP regulations is a requirement that your organization take steps to secure and control access to personal information that is stored in your database. You can use the standard field-level, form-level, and entity-level security controls in [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] to make sure only those users that are authorized to access this data, and who know how to handle it legally, will be able to access it. Here are some examples of data that you may need to protect:

- **Contact records:** Contact records contain many types of basic, personal data, such as names, addresses, email, phone numbers, and more. You can control access to these records by assigning entity permissions as part of each security role definition.
- **Marketing insights:** Marketing insights can include details such as website browsing records, form submissions, event attendance, and more.  Some, but not necessarily all, users that have access to contact records may be granted access to view this information. You can control this access by assigning security groups at the form level.
- **Fields with especially sensitive information:** Your contact records may include data fields with especially sensitive information, such as financial, medical, or political-affiliation details. Some, but not necessarily all, users that have access to contact records may be granted access to view this information. You can control this access by assigning security groups at the field level.

For more information about how to work with the security groups and other security features in [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)], see [Manage security, users, and teams](../admin/manage-security-users-and-teams.md).

## Demonstrate GDPR compliance

From time to time, you may be asked to demonstrate that your organization complies with the GDPR regulations. [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] provides several tools to help you do this.

### View a history of consent-level changes for each contact

Each time a contact uses a subscription center to change their consent level, [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] logs the event. You can view the history of consent-level changes by doing the following:

1. Open the target contact record.
1. Select the **Related** tab to open a drop-down list of related record types.
1. Select **GDPR consent change records** from the drop-down list. A list of GDPR consent change records opens as a new tab for the contact record.

The list only shows changes made by the contact using the subscription center. If a user from your organization changes the level directly using the contact record (such as to respond to a request given over the phone), that event is not recorded in the log. To record such a change, the user must also open the **GDPR consent change records** tab and select the **Add new GDPR consent record** button. A form opens that the user can use to enter details about the consent-level change.
 
You can export this list from here, if needed, by selecting the **Export** button in the list command bar.

## Enable auditing to log all record changes

[!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] can keep a record of all database changes, who made them, and when. You can use this to show when GDPR consent was changed for each contact and by whom. The auditing system is usually disabled by default, so you'll need to set it up if you want to use it log your GDPR consent changes (and other information). When setting up the system, you'll be able to choose which types of events you want to audit on which type of records.

You can access the auditing features by opening the **[!INCLUDE[pn-custom-app-module](../includes/pn-custom-app-module.md)]** application and then going to **Settings** > **System** > **Auditing** to open the **Audit** page. From there, you can access the auditing settings and review the audit record.

This feature is part of the standard functionality of [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)]. For information about how auditing works, how to set it up, and and how to review the log, see [Audit data and user activity for security and compliance](../admin/audit-data-user-activity.md).