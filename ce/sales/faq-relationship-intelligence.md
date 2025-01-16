---
title: Relationship intelligence FAQs
description: Get answers to frequently asked questions about relationship analytics and health, and who knows whom.
ms.date: 01/16/2025
ms.topic: troubleshooting
author: udaykirang
ms.author: udag
ms.reviewer: udag
ms.owner: shujoshi
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:03/11/2024
---

# Relationship intelligence FAQs

This article answers frequently asked questions about relationship analytics and health, and who knows whom in Dynamics 365 Sales and Sales premium.

## Relationship analytics and health

### Which data is used to generate relationship insights?

**Basic insights:**

Uses email, phone call, and appointments sent or received in Dynamics 365.

**Enhanced insights:**

Uses email, phone call, and appointments sent or received in Dynamics 365 and Exchange ([if server-side synchronization is enabled](configure-email.md)).

### What is the frequency of KPI updates?

**Basic insights:** 

Updated in near real-time&mdash;as soon as a related activity is marked as completed in Dynamics 365.  

**Enhanced insights:**

Updated every 24 hours. ​  

### What are the signals in relationship health?
​
Relationship health looks at activity, recency, engagement, and sentiment of activities between sellers and customers.

### Can I influence the relationship health score?​

An administrator can influence the relationship health score by changing the weight of activity types and the expected level of communications with customers. More information: [Configure relationship analytics and health](configure-relationship-analytics.md)

### How are similar won deals identified? <a name="similar-won-deals-fields"></a> 
 
Dynamics 365 Sales uses AI models to determine the factors that affect the identification of similar won deals. The factors may differ from organization to organization based on custom and out-of-the-box fields.

To view the fields that determine the similar won deals at that point in time, select the information icon corresponding to any section heading and a side pane opens with the field information.

:::image type="content" source="media/faq-sa-about-relationship-analytics-side-pane-fields.png" alt-text="Screenshot of the relationship analytics side pane.":::

## Who knows whom

### Why am I not seeing some of my colleagues in the who knows whom suggestions?

If you know that a colleague has interacted with a customer but their information is not shown in Who Knows Whom widget, it could be due to the following reasons:

**Basic insights:** 

Displays up to five colleagues who contacted the customer the most through emails and appointments in Dynamics 365. Colleagues who contacted the customer by phone and those who had fewer interactions through emails and appointments aren't listed.

**Enhanced insights:**

It's possible that those colleagues aren't part of your Dynamics 365 org.

[Which colleagues show up as connections?](#which-colleagues-show-up-as-connections)

### How long does it take for suggestions to appear?

**Basic insights:** Who knows whom suggestions are available out-of-the-box if the email and appointment data is available in Dynamics 365.

**Enhanced insights:** After your Microsoft 365 admin provides consent, you'll start seeing the results within a day. However, the suggestions may not be complete right away because the data is processed in batches over a period of four days.  

### Which colleagues show up as connections?

**Basic insights:** Colleagues who have contacted the customer the most through emails and appointments in Dynamics 365.

**Enhanced insights:** Colleagues who have contacted the customer the most through emails and appointments in Dynamics 365 and Exchange (if server-side synchronization is enabled).

### How are the connections weighted?

**Basic insights:** Uses only frequency. The connections are weighted based on the number of interactions through emails and appointments in Dynamics 365. Top five users who have interacted the most with the contact or lead are displayed.  

**Enhanced insights:** Uses frequency and recency. If your administrator has enabled Exchange integration, the connections are weighted based on recent and frequent interactions through emails or appointments. 

Every seller will see the same set of introducers for a contact or lead. 

### How frequently is the data collected?

**Basic insights:** Collected in near real-time&mdash;as soon as a related activity is marked as completed in Dynamics 365.  

**Enhanced insights:** After you enable server-side synchronization, Exchange data is synchronized based on the sync frequency set by your admin. Learn more about [synchronization frequency](/power-platform/admin/frequently-asked-questions-synchronizing-records-dynamics-365-and-outlook?source=recommendations#how-often-are-records-synchronized-through-server-side-sync).


### What is the source for who knows whom data?

**Basic insights:** Emails and appointments sent and received in Dynamics 365.

**Enhanced insights** Emails and meeting information in Dynamics 365 and Exchange is the source data. Exchange data is used only if [server-side synchronization is enabled](configure-email.md). [Learn more about how connections weighted](#how-are-the-connections-weighted)

### Where are the insights from Exchange generated?

If server-side synchronization is enabled, the Exchange data is collected and stored in Dynamics 365. Insights are then generated from the stored data in Dynamics 365.  

> [!IMPORTANT]
> Microsoft 365 and Dynamics 365 each have their own service-specific licensing terms. The service-specific terms that apply depend on which service processes your data. For example, when a copy of your Microsoft 365 data is transferred to Dynamics 365, your Microsoft 365 data in that copy becomes Dynamics 365 data and the Dynamics 365 service-specific terms apply.

