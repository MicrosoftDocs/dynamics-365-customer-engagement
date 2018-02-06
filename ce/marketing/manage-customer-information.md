---
title: "Work with contact, account, and lead records (Dynamics 365 for Marketing) | Microsoft Docs"
description: "How to find, create and use contact, account, and lead records in Dynamics 365 for Marketing"
keywords: "contact; account; lead"
ms.date: 12/15/2017
ms.service: crm-online
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 16024056-9750-4b6f-854a-da454e2c3a3f
author: kamaybac
ms.author: kamaybac
robots: noindex,nofollow
manager: sakudes
ms.reviewer: renwe
topic-status: Drafting
---

# Manage information about your current and prospective customers

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

Three of the most important and common types of database records are contacts, accounts, and leads. These fundamental business entities are shared by most [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] apps, including [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)].

## Use contacts to manage customer people

Contacts represent individual people. They are the primary customer entity in [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]. When you run a customer journey, your target segment will include only contact records. And when you create a lead, you will also relate that lead to a contact record. Other [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] apps might treat these entities somewhat differently, instead focusing more on accounts or using leads that aren't related to any contact.

Most of your contacts will represent customers or potential customers, but you might also include partners or suppliers among your contacts, especially for events where you'll also typically include speakers, vendors, and sponsors in your contacts database.

To view, create, or edit a contact, go to **Marketing** &gt; **Customers** &gt; **Contacts**. This brings to you a standard list view, which you can use to search, sort, filter, create, and delete your contacts. Open any contact to view its details.

## Use accounts to manage customer companies

Accounts are companies that you market and sell to. They can also be partner companies or suppliers. If you use accounts, you'll usually also set up at least one contact for each of them.

> [!IMPORTANT]
> Customer journeys can only target contacts, not accounts or leads, so be sure to create contact records for everyone you want to include in your customer journeys, and then associate each of them with any relevant accounts or leads.

To view, create, or edit an account, go to **Marketing** &gt; **Customers** &gt; **Accounts**. This brings to you a standard list view, which you can use to search, sort, filter, create, and delete your accounts. Open any account to view its details.

## Use leads to register and track expressions of interest

A primary goal of [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] is to generate interest and then find, nurture, and qualify leads for salespeople. As mentioned, [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] is centered around contacts, which is the only type of customer entity that you can target by using a customer journey. When a contact shows interest in one of your products or services, you'll either generate a lead record that relates to that contact or allow a landing page to generate the lead automatically. The lead represents an expressed interest by the related contact in some specific product. A given contact might have several leads associated with it, each representing a different level of interest in a different product or offer.

Salespeople sometimes use leads differently and might therefore create leads that aren't related to any contact record and might include their own local contact information. These are sales-only leads that can't be targeted by using customer journeys in [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)].

[!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] keeps an eye on your leads and can automatically score each of them based on how they interact with your marketing initiatives. For example, the lead score might increase each time the related contact opens a relevant email, signs up for a download, or attends a sales event. After a lead reaches a "sales-ready" score threshold, it's considered marketing-qualified and is ready to be taken over by a salesperson. The salesperson might eventually promote the lead to an opportunity and then go on to close the sale. Or the salesperson might decide to send it back to marketing for further nurturing.

To view, create, or edit a lead, go to **Marketing** &gt; **Customers** &gt; **Leads**. This brings to you a standard list view, which you can use to search, sort, filter, create, and delete your leads. Open any lead to view its details. Select **New** in the command bar to create a new lead.

[!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Score and manage leads](score-manage-leads.md)
