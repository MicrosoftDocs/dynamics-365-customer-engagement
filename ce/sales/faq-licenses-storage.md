---
title: Licenses and storage FAQs
description: Discover answers to common questions about licenses and storage.
ms.date: 03/12/2025
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
  - references_regions
---

# Licenses and storage FAQs

This article answers frequently asked questions about licenses and storage in Dynamics 365 Sales, Sales premium, and Sales professional.

<a name="license-compliance"></a>
## How to ensure an organization is compliant with the Dynamics 365 licensing terms and conditions?

Review the [Licensing guide](https://go.microsoft.com/fwlink/?LinkId=866544&clcid=0x409) to ensure that you have the appropriate licenses for all the Dynamics 365 features and functionalities that you're using.

## Where can I find Dynamics 365 Sales licenses comparison chart?

For a detailed comparison of the capabilities available with each license, go to the compare plans section on the [Pricing](https://www.microsoft.com/dynamics-365/products/sales/pricing) page.

## Which licenses can I use to access the Sales Hub app?

You can use Sales Enterprise, Sales Premium, and Microsoft Relationship Sales licenses to access the Sales Hub app. Sales Professional users are entitled to use the Sales Professional app only. Though the Sales Hub app might be visible in Sales Professional environments, the users aren't entitled to use it.

## How can I assign licenses to users?  

To assign licenses to users, see [Assign licenses to users](/microsoft-365/admin/manage/assign-licenses-to-users?view=o365-worldwide).

## Can I add extra storage capacity to users with Sales Professional license?

No. You can't add extra storage capacity to users with Sales Professional license.

## After I installed Sales Insights, I see a spike in the data usage. How much storage data does Sales Insights need?  

When you install Sales Insights, corresponding analytics tables are created for contacts, opportunities, leads, accounts, and activityparty tables. The storage requirement for these analytics tables is directly proportional to the amount of data in Dataverse. The tables are stored as files in the managed data lake and will be counted against your total file storage quota. For more information, see [New Microsoft Dataverse storage capacity](/power-platform/admin/capacity-storage).

## Where is my organization's data stored?  

Your organization's data is stored in the Azure datacenter location that corresponds to the region where your Dynamics 365 org is hosted. For more information about the primary and secondary datacenter locations for each region, see[Azure regional pairs](/azure/best-practices-availability-paired-regions#azure-regional-pairs).

## Which users can push data from Dynamics 365 Sales to Dataverse?

Dynamics 365 Sales data is pushed to Dataverse to generate insights like predictive scoring, relationship analytics, who knows whom, and predictive forecasting. A set of predefined [system and application users](/power-platform/admin/system-application-users) might push data from Dynamics 365 Sales to Dataverse.

## What happens to my organization data if I switch between licenses?

Your organization data is preserved when you switch from one license to the other. More information: [Move from Dynamics 365 Sales Professional to Dynamics 365 Sales Enterprise](upgrade-sales-professional-sales-enterprise.md) and [Move from Dynamics 365 Sales Enterprise edition to Dynamics 365 Sales Professional](move-sales-enterprise-sales-professional.md)

## What happens to my organization data if my license expires?

The environment is disabled, users won't be able to access it, and the data will be deleted after 30 days. However, if there are any other related licenses available in the tenant, the data is preserved.

## Why are my entities updated by some application users?

System and application users update certain entities with insights about the records. For example, lead and opportunity entities are updated by the application users to add predictive scores. Similarly, contact, opportunity, lead, and account entities are updated with relationship KPIs and analytics. More information: [Which users can push data from Dynamics 365 Sales to Dataverse?](#which-users-can-push-data-from-dynamics-365-sales-to-dataverse)

## Where can I find the Sales Professional and Sales Insights documentation?

We've merged the documentation for Sales Enterprise, Sales Professional, and Sales Insights into this unified Sales documentation. The license and role requirements section at the top of every article indicates whether the content applies to the license you have. Any bookmarks you have should automatically redirect to the corresponding pages in the new unified documentation.
