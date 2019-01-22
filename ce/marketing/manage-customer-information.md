---
title: "Work with contact, account, and lead records (Dynamics 365 for Marketing) | Microsoft Docs"
description: "How to find, create and use contact, account, and lead records in Dynamics 365 for Marketing"
keywords: contact; account; lead
ms.date: 04/25/2018
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - Dynamics 365 for Customer Engagement Version 9.x
ms.assetid: 16024056-9750-4b6f-854a-da454e2c3a3f
author: kamaybac
ms.author: kamaybac
manager: shellyha
ms.reviewer:
topic-status: Drafting
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Manage information about your current and prospective customers

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

Three of the most important and common types of database records are contacts, accounts, and leads. These fundamental business entities are shared by most [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] apps, including [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)].

## Use contacts to manage customer people

Contacts represent individual people. They are the primary customer entity in [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]. When you run a customer journey, your target segment will include only contact records. And when you create a lead, you will also relate that lead to a contact record. Other [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] apps might treat these entities somewhat differently, instead focusing more on accounts or using leads that aren't related to any contact.

Most of your contacts will represent customers or potential customers, but you might also include partners or suppliers among your contacts, especially for events where you'll also typically include speakers, vendors, and sponsors in your contacts database.

To view, create, or edit a contact, go to **Marketing** &gt; **Customers** &gt; **Contacts**. This brings to you a standard list view, which you can use to search, sort, filter, create, and delete your contacts. Open any contact to view its details.

The contacts entity is common for and shared by most [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] apps, but [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] adds several enhancements to it, including:

- **Marketing source information**: The contact **Details** tab includes a section called **Marketing**, where you can see which marketing initiatives were responsible for generating that contact.
- **Contact preferences**: The contact **Details** tab includes a section called **Contact preferences**, where you can see information about how that contact prefers to be contacted (or not contacted) by your organization. Important settings for [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] here include:
  - **Follow email**: Controls whether [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] is permitted to collect email interaction results (such as open, click and forward) for the current contact. When set to **Do not allow**, no email results will be stored for this contact.
  - **Bulk email**: Controls whether [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] is permitted to send marketing email messages from customer journeys to this contact. When set to **Do not allow**, no marketing email messages will be sent to this contact. Contacts can adjust this setting themselves using a subscription center. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Set up subscription lists and subscription centers](set-up-subscription-center.md)
  - **Email**: This setting is part of the standard contact entity (it isn't added specifically for [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)]). It controls whether any [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] app (including [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)]) can send any type of email to this contact, including both commercial and transactional messages. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Set the legal designation to identify each message as either commercial or transactional](prepare-marketing-emails.md#designation)
  - **Prefill marketing form**: Controls whether [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] is permitted to prefill form information (like name and email) on marketing pages for this contact.  When set to **Do not allow**, all marketing pages (other than subscription centers) will present an empty form to this contact, even when the contact is recognized by the system. Contacts can set this option for themselves by setting a "remember me" check box on any marketing page that is set up to include the prefill feature.

- **Data protection**: The contact **Details** tab includes a section called **Data protection**, where you can see and set the data-privacy consent level granted by this contact, and also see whether the contact is a child and, if so, who their parent or guardian is. For more information about these features, see [Data protection and the GDPR](gdpr.md).
- **Event information**: Each contact record provides the following information about events the contact has registered for or attended:
    - The contact **Details** tab includes a section called **Event information**, where you can see basic information that was collected from the contact when they registered for an event.
    - The contact **Events attended** tab provides complete details of all event registrations and check-ins associated with this contact.
- **Marketing insights**: Detailed KPIs and analytics about how this contact has interacted with your various marketing initiatives are provided on the **Contact: Insights** form view for the contact entity (available from the drop-down list above the contact name in the page heading). [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Analyze results to gain insights from your marketing activities](insights.md)

## Use accounts to manage customer companies

Accounts are companies that you market and sell to. They can also be partner companies or suppliers. If you use accounts, you'll usually also set up at least one contact for each of them.

> [!IMPORTANT]
> Customer journeys can only target contacts, not accounts or leads, so be sure to create contact records for everyone you want to include in your customer journeys, and then associate each of them with any relevant accounts or leads.

To view, create, or edit an account, go to **Marketing** &gt; **Customers** &gt; **Accounts**. This brings to you a standard list view, which you can use to search, sort, filter, create, and delete your accounts. Open any account to view its details.

## Use leads to register and track expressions of interest

A primary goal of [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] is to generate interest and then find, nurture, and qualify leads for salespeople. As mentioned, [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] is centered around contacts, which is the only type of customer entity that you can target by using a customer journey. When a contact shows interest in one of your products or services, you'll either generate a lead record that relates to that contact or allow a landing page to generate the lead automatically. The lead represents an expressed interest by the related contact in some specific product. A given contact might have several leads associated with it, each representing a different level of interest in a different product or offer.

You can associate each lead with either a contact or an account. If you choose to create account-based leads, then each account must be associated with one or more contact records because your segments and customer journeys still need to include and target contacts, not accounts. In this regard, accounts are essentially treated as collections of one or more contacts. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Account-based marketing](account-based-marketing.md).

Salespeople sometimes use leads differently and might therefore create leads that aren't related to any contact record, but you can easily customize your system to work with both types of leads. For details about how to integrate sales-driven (lead-centered) and marketing-driven (contact-centered) workflows, see [Market to leads](market-to-leads.md).

[!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] keeps an eye on your leads and can automatically score each of them based on how they interact with your marketing initiatives. For example, the lead score might increase each time the related contact opens a relevant email, signs up for a download, or attends a sales event. After a lead reaches a "sales-ready" score threshold, it's considered marketing-qualified and is ready to be taken over by a salesperson. The salesperson might eventually promote the lead to an opportunity and then go on to close the sale. Or the salesperson might decide to send it back to marketing for further nurturing.

To view, create, or edit a lead, go to **Marketing** &gt; **Customers** &gt; **Leads**. This brings to you a standard list view, which you can use to search, sort, filter, create, and delete your leads. Open any lead to view its details. Select **New** in the command bar to create a new lead.

[!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [The lead lifecycle](lead-lifecycle.md)
