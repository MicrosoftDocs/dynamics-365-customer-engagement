---
title: Microsoft 365 consent types
description: Dynamics 365 can generate insights based on email interactions and meetings information from Microsoft 365. 
ms.date: 08/11/2022
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
---

# Consent required to use Microsoft 365 data

This article describes different types of consents that the Microsoft 365 admin needs to provide so that Dynamics 365 can collect and use Microsoft 365 data. For more information on how to provide consent, see [Provide consent to collect data from Exchange Online](provide-consent-office365.md).

The following sections include an incomplete list of Dynamics 365 applications using this data and are subject to change in the future.
 
## Insights for users 

Insights are generated based on a user’s Microsoft 365 data and are visible only to that user when they're using the Dynamics 365 application. 

**Type:** Detailed and aggregate 

**Results visible to:** User running the Dynamics 365 application.  

**Applications using insights for the org:** None yet

## Insights for the Org 

Aggregated insights are generated based on Microsoft 365 data belonging to members of an org. This aggregated data is de-identified, and the insights are only made available to users in your company, including authorized guest users of Dynamics 365, and do not include data specific to individual users. It can be used to understand overall patterns and behaviors of groups. 

**Type:** De-identified and aggregate 

**Results visible:** Tenant-wide 

**Applications using insights for the org:**

- Dynamics 365 Customer Insights: Office Enrichment 

**Example and Scenario:** Dynamics 365 Customer Insights: Office Enrichment 

Office Enrichment uses data from Microsoft Office 365 to enrich customer account profiles with insights about engagements through Office 365 apps. The engagement data consists of email and meeting activity, which is aggregated on the account level.  

For example, the number of emails from a business account or the number of meetings with the account. No data about individual users is made available.  

## Insights for Other Users 

Insights are generated based on a user's Microsoft 365 data and are made available to other users in your organization. 

**Type:** Detailed and aggregate 

**Results visible:** Tenant wide 

**Applications using insights for other users** 

- Dynamics 365 Sales: Who Knows Whom and Relationship Analytics

**Example and Scenario:** Dynamics 365 Sales: Who Knows Whom 

A user can leverage their network of colleagues—their user data—to see who can introduce them to a sales target at an external organization. 

## What happens after providing consent  

The Microsoft 365 admin can turn on one or more of these options, allowing a copy of your company’s Microsoft 365 data to be copied into Dynamics 365 applications to be used by any authorized users of your company’s Dynamics 365 applications. 

> [!NOTE]
> Microsoft 365 and Dynamics 365 each have their own service-specific licensing terms. The service-specific terms that apply depend on which service processes your data. For example, when a copy of your Microsoft 365 data is transferred to Dynamics 365, your Microsoft 365 data in that copy becomes Dynamics 365 data and the Dynamics 365 service-specific terms apply.  

If Microsoft 365 users choose to opt out, their data will not be accessible to any Dynamics 365 applications. 

When disabling these insights, it can take up to 24 hours for the data to be removed from all apps and up to 30 days for backed-up data to be removed from Microsoft 365 storage accounts. 

### See also
[Provide consent to collect data from Exchange Online](provide-consent-office365.md)

