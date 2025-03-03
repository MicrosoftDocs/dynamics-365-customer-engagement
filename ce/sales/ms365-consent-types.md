---
title: Microsoft 365 consent types
description: Learn about the types of consent Dynamics 365 needs to collect and use Microsoft 365 data to generate insights.  
ms.date: 02/27/2025
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
---


# Microsoft 365 consent types

Your Microsoft 365 admin needs to provide consent to let Dynamics 365 collect, store, and use Microsoft 365 data. This article describes the different consent types required by Dynamics 365 to generate insights. For more information about the insights generated by Dynamics 365 Sales, see [Insights generated from Microsoft 365 data](insights-from-m365.md).

> [!IMPORTANT]
> Microsoft 365 and Dynamics 365 each have their own service-specific licensing terms. The service-specific terms that apply depend on which service processes your data. For example, when a copy of your Microsoft 365 data is transferred to Dynamics 365, your Microsoft 365 data in that copy becomes Dynamics 365 data and the Dynamics 365 service-specific terms apply.

The following table lists the consent types and the list of Dynamics 365 applications that use the shared Microsoft 365 data. The list of applications is subject to change.

> [!NOTE]
> Depending on the Dynamics 365 application that you use and the insights you need, you can request the Microsoft 365 admin to provide the appropriate consent. More information: [Provide consent to collect data from Microsoft 365](provide-consent-office365.md)


|**Consent Type**|**Possible insights**|**Type of insight**|**Results visible to** |**Dynamics 365 app using the consent**|
|-------------------------|-------------------------|-------------------------|-------------------------|-------------------------|
| Insights for each user | Personal insights can be generated based on users’ Microsoft 365 data.| Detailed and aggregate | User running the Dynamics 365 application | None yet|
|Aggregated insights for other users|Aggregated insights are generated based on Microsoft 365 data belonging to members of a Dynamics 365 organization. The aggregated data is de-identified. The insights are only made available to users in your company, including authorized guest users of Dynamics 365, and don't include data specific to individual users. It can be used to understand overall patterns and behaviors of groups.|De-identified and aggregate|Users across the tenant|Dynamics 365 Customer Insights: Office enrichment <br> Example: Office enrichment uses data from Office 365 to enrich customer account profiles with insights about engagements through Office 365 apps. The engagement data consists of email and meeting activity, which is aggregated at the account level. More information: [Enrich customer profiles with data from Microsoft Office 365](/dynamics365/customer-insights/enrichment-office)
|Identifiable insights for other users | Microsoft 365 data about individual users, and insights derived from this data, are made available to other users in your organization. |Detailed and aggregate | Users across the tenant| Dynamics 365 Sales: Who knows whom<br> Dynamics 365 Sales: Relationship analytics <br> Example: Users can take advantage of their network of colleagues to determine who can introduce them to a sales target at an external organization. More information: [Relationship insights generated from Microsoft 365 data](insights-from-m365.md)  |


