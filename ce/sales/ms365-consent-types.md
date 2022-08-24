---
title: Microsoft 365 consent types
description: Learn about the types of consent Dynamics 365 needs to collect and use Microsoft 365 data to generate insights.  
ms.date: 08/24/2022
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
---

<!--It's not clear to me what, exactly, this article is about. I thought it was a discussion of consent types, but it doesn't really define the types of consent. It's not at all clear what information readers are supposed to get from the table, either. The column headings are confusing. "Type of insight" isn't a consent, for instance. Can you please clarify what readers should take away from the table and the article as a whole?-->
# Microsoft 365 consent types

Your Microsoft 365 admin needs to provide consent to let Dynamics 365 collect and use Microsoft 365 data:

- [Insights generated from Microsoft 365 data](insights-from-m365.md)
- [Provide consent to collect data from Exchange Online](provide-consent-office365.md)

The following table shows an incomplete list of Dynamics 365 applications that use the shared data. This list is subject to change.

| Consent Type | Insights for each user | Aggregated insights for other users | Identifiable insights for other users |
|-------------------------|-------------------------|-------------------------|-------------------------|
| **Data collected** | A user's Microsoft 365 data | Aggregated insights are generated based on Microsoft 365 data belonging to members of a Dynamics 365 organization. The aggregated data is de-identified. The insights are only made available to users in your company, including authorized guest users of Dynamics 365, and don't include data specific to individual users. It can be used to understand overall patterns and behaviors of groups. | Microsoft 365 data about individual users, and insights derived from this data, are made available to other users in your organization. |
| **Type of insight** | Detailed and aggregate | De-identified and aggregate | Detailed and aggregate |
| **Results visible to** | User running the Dynamics 365 application | Tenant-wide | Tenant-wide |
| **Dynamics 365 app using the consent** | None | Dynamics 365 Customer Insights: Office enrichment<br> | Dynamics 365 Sales: Who knows whom<br> Dynamics 365 Sales: Relationship analytics |
|**Examples**| None | Office enrichment uses data from Office 365 to enrich customer account profiles with insights about engagements through Office 365 apps. The engagement data consists of email and meeting activity, which is aggregated at the account level. | Users can take advantage of their network of colleagues to determine who can introduce them to a sales target at an external organization. |

Microsoft 365 and Dynamics 365 have separate, service-specific licensing terms. The service-specific terms that apply depend on which service processes your data. For example, when a copy of your Microsoft 365 data is transferred to Dynamics 365, the Microsoft 365 data in that copy becomes Dynamics 365 data and the Dynamics 365 service-specific terms apply.
