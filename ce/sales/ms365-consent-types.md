---
title: Microsoft 365 consent types
description: Dynamics 365 can generate insights based on email interactions and meetings information from Microsoft 365. 
ms.date: 08/23/2022
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
---

# Consent required to use Microsoft 365 data

This article describes different types of consent that a Microsoft 365 admin needs to provide to let Dynamics 365 collect and use Microsoft 365 data.

**More information:** 
- [Insights generated from Microsoft 365 data](insights-from-m365.md)
- [Provide consent to collect data from Exchange Online](provide-consent-office365.md)

The following sections include an incomplete list of Dynamics 365 applications using this data and are subject to change in the future.

| **Consent Type** | Insights for each user | Aggregated insights for other users | Identifiable insights for other users |
|-------------------------|-------------------------|-------------------------|-------------------------|
| **Data collected** | A user's Microsoft 365 data | Aggregated insights are generated based on Microsoft 365 data belonging to members of a Dynamics 365 org. This aggregated data is de-identified, and the insights are only made available to users in your company, including authorized guest users of Dynamics 365, and do not include data specific to individual users. It can be used to understand overall patterns and behaviors of groups. | Microsoft 365 data about individual users, and insights derived from this data, are made available to other users in your organization. |
| **Type of Insight** | Detailed and aggregate | De-identified and aggregate | Detailed and aggregate |
| **Results visible to** | User running the Dynamics 365 application. | Tenant wide | Tenant wide |
| **Dynamics 365 App using the consent** | None | Dynamics 365 Customer Insights: Office Enrichment<br /></br> | Dynamics 365 Sales: Who Knows Whom<br /></br> Dynamics 365 Sales: Relationship analytics |
|**Examples**|None|Office Enrichment uses data from Microsoft Office 365 to enrich customer account profiles with insights about engagements through Office 365 apps. The engagement data consists of email and meeting activity, which is aggregated on the account level.|A user can leverage their network of colleagues—their user data—to see who can introduce them to a sales target at an external organization.

Microsoft 365 and Dynamics 365 each have their own service-specific licensing terms. The service-specific terms that apply depend on which service processes your data. For example, when a copy of your Microsoft 365 data is transferred to Dynamics 365, your Microsoft 365 data in that copy becomes Dynamics 365 data and the Dynamics 365 service-specific terms apply.
