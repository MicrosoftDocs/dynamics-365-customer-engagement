---
title: Insights generated from Microsoft 365 data
description: Dynamics 365 can generate insights based on email interactions and meetings information from Microsoft 365. 
ms.date: 05/09/2022
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
---

# Insights generated from Microsoft 365 data

This article describes the insights created by Dynamics 365 applications from Microsoft 365 data and the consent required. Once the Microsoft 365 admin provides consent, a copy of your company’s Microsoft 365 data is placed in Dynamics 365 applications. Dynamics 365 can then use this copy to generate relevant insights and display them to authorized Dynamics 365 users.  

> [!IMPORTANT]
> Users can opt out, if they don't want Dynamics 365 applications to access their data.  

The following sections describe the type of consent, applications using the consent, and the insights generated. 

> [!IMPORTANT]
> The Dynamics 365 applications mentioned in the sections below is not a complete list and is subject to change in the future.


| **Consent required** | **Data used** | **Type** | **Visible to** | **Applications** | **Insights offered** |
|-------------------------|-------------------------|-------------------------|-------------------------|-------------------------|-------------------------|
| Insights for each user | A user's Microsoft 365 data. | Detailed and aggregated | Users running the Dynamics 365 application | None | None |
| Aggregated insights for other users | Aggregated Microsoft 365 data belonging to members of an org. Used to understand overall patterns and behaviors of groups. | Anonymized and aggregated | Tenant-wide, including all users in your company and authorized guest users | Dynamics 365 Customer Insights | Office Enrichment |
| Identifiable insights for other users | Microsoft 365 data about individual users. | Detailed and aggregate | Tenant-wide, including all users in your company and authorized guest users | Dynamics 365 Sales | Who Knows Whom<br /></br>Relationship Analytics |


|Details you need to know  | Insights for each user | Aggregated insights for other users | Identifiable insights for other users |
|-------------------------|-------------------------|-------------------------|-------------------------|
| Data used | A user's Microsoft 365 data. | Aggregated Microsoft 365 data belonging to members of an org. Used to understand overall patterns and behaviors of groups. | Microsoft 365 data about individual users. |
| Type | Detailed and aggregated | Anonymized and aggregated | Detailed and aggregate |
| Visible to | Users running the Dynamics 365 application | Tenant-wide, including all users in your company and authorized guest users | Tenant-wide, including all users in your company and authorized guest users |
| Applications | None | Dynamics 365 Customer Insights | Dynamics 365 Sales |
| Insights offered | None | Office Enrichment | Who Knows Whom</br>Relationship Analytics |

## Insights for each user  

A user’s Microsoft 365 data, and insights derived from this data, are visible only to the user running the Dynamics 365 application. 

Type: Detailed and aggregate 

Results visible to: User running the Dynamics 365 application. 

## Aggregated insights for other users 

Aggregated insights are generated based on Microsoft 365 data belonging to members of an org. This aggregated data is de-identified, and the insights are only made available to users in your company, including authorized guest users of Dynamics 365, and do not include data specific to individual users. It can be used to understand overall patterns and behaviors of groups.  

Type: De-identified and aggregate 

Results visible: Tenant wide 

Example and Scenario: Dynamics 365 Customer Insights: Office Enrichment 

Office Enrichment uses data from Microsoft Office 365 to enrich customer account profiles with insights about engagements through Office 365 apps. The engagement data consists of email and meeting activity, which is aggregated on the account level. 

 For example, the number of emails from a business account or the number of meetings with the account. No data about individual users is made available.		 

Applications under aggregated insights for other users 

Dynamics 365 Customer Insights: Office Enrichment 

## Identifiable insights for other users 

Microsoft 365 data about individual users, and insights derived from this data, are made available to other users in your organization. 

Type: Detailed and aggregate 

Results visible: Tenant wide 

Example and Scenario: Dynamics 365 Sales: Who Knows Whom 

A user can leverage his network of colleagues—their user data—to see who can introduce them to a sales target at an external organization. 

Applications under identifiable insights for other users 

Dynamics 365 Sales: Who Knows Whom 

Dynamics 365 Sales: Relationship Analytics	 

Microsoft 365 and Dynamics 365 each have their own service-specific licensing terms. The service-specific terms that apply depend on which service processes your data. For example, when a copy of your Microsoft 365 data is transferred to Dynamics 365, your Microsoft 365 data in that copy becomes Dynamics 365 data and the Dynamics 365 service-specific terms apply. 

 