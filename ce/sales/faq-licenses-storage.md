---
title: Licenses and storage FAQs
description: Discover answers to common questions about licenses and storage.
ms.date: 10/22/2025
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

# Licenses and storage FAQs

This article answers frequently asked questions about licenses and storage in Dynamics 365 Sales, Sales premium, and Sales professional.

<a name="license-compliance"></a>
## How do I ensure that my organization is compliant with the Dynamics 365 licensing terms and conditions?

Review the [Licensing guide](https://go.microsoft.com/fwlink/?LinkId=866544&clcid=0x409) to ensure that you have the appropriate licenses for all the Dynamics 365 features and functionalities that you're using.

## What's the difference between Sales Premium and Sales Insights?

Sales Premium, like Sales Enterprise, is a type of license. Sales Insights is an add-in for Dynamics 365 Sales. Sales Premium includes all Sales Enterprise capabilities and premium Sales Insights capabilities. Sales Enterprise includes basic Sales Insights capabilities. For a detailed comparison of the capabilities in each license, go to the **Compare Dynamics 365 Sales plans** section on the [Pricing](https://dynamics.microsoft.com/sales/pricing/) page.

## Where can I find the comparison chart for Dynamics 365 Sales licenses?

The following license options are available for Dynamics 365 Sales:

- Sales Premium
- Sales Enterprise
- Sales Professional

For a detailed comparison of the capabilities available with each license, go to the **Compare Dynamics 365 Sales plans** section on the [Pricing](https://dynamics.microsoft.com/sales/pricing/) page.

## How can I assign licenses to users?  

To assign licenses to users, see [Assign licenses to users](/microsoft-365/admin/manage/assign-licenses-to-users?view=o365-worldwide).


## FAQs about Copilot credits bundled with Dynamics 365 Sales Premium licenses

### What are Copilot Studio credits?

Copilot Studio credits are a type of capacity that allows users to utilize AI-powered features in Dynamics 365 Sales Premium. These credits enable sellers to leverage AI capabilities such as Copilot chat and AI agents to enhance their sales processes and improve productivity.

### How many Copilot Studio credits do I get and how often are they allocated?

With the Sales Premium license, each user receives a monthly allocation of Copilot Studio credits to utilize these AI features. These credits aren't cumulative and reset each month. For information on the specific number of credits included with your license, refer to the [Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/?LinkId=866544&clcid=0x409).

You will be notified in advance when the initial credits are allocated to your tenant. There would be no disruption to your service during this process.

### How can I track usage of the allocated credits?

You can monitor credit usage in the [Power Platform admin center](/power-platform/admin/manage-copilot-studio-messages-capacity?tabs=new).  If you have questions or don't see your credits yet, contact Microsoft support for assistance. 

### What if I need more credits?

The included credits per user are designed to cover typical usage for most organizations. If your organization exceeds the included credits, you can purchase additional Copilot Studio credits as needed. Learn more in [Manage Copilot Studio credits and capacity](/power-platform/admin/manage-copilot-studio-messages-capacity?tabs=new)

### How can I ensure that credits allocated to my tenant are used by my sales team?

Allocate the credits to the Dynamics 365 Sales environment that your sales team uses, as there is no other way to prevent other agents in your tenant from using the capacity. Learn more about capacity allocation in [Manage capacity](/power-platform/admin/manage-copilot-studio-messages-capacity?tabs=new#manage-capacity).


## Can I use the Sales Hub app with the Sales Professional license?

No, the Sales Hub app is for the Sales Enterprise and Sales Premium customers only. Though this app may be visible in Sales Professional environments, the users aren't entitled to use it. Sales Professional users are entitled to use the Sales Professional app only.

## After I installed Sales Insights, I see a spike in the data usage. How much storage data does Sales Insights need?  

When you install Sales Insights, corresponding analytics tables are created for contacts, opportunities, leads, accounts, and activityparty tables. The storage requirement for these analytics tables is directly proportional to the amount of data in Dataverse. The tables are stored as files in the managed data lake and will be counted against your total file storage quota. For more information, see [New Microsoft Dataverse storage capacity](/power-platform/admin/capacity-storage).

## Can I add extra storage capacity to users with Sales Professional license?

No. You can't add extra storage capacity to users with Sales Professional license.

## Where is my organization's data stored?  

The following table shows where your data is stored, depending on the region where your organization is hosted.

| Region | Primary Azure datacenter location  | Secondary Azure datacenter location |
|--------|-------------------------------------|--------------------------------------|
| Asia Pacific (APJ) | South East Asia (Singapore) | East Asia (Hong Kong SAR) |
| Canada (CAN) | Canada Central (Toronto) | Canada East (Quebec City) |
| Europe, the Middle East, and Africa (EMEA) | West Europe (Netherlands) | North Europe (Ireland) |
| France (FRA) | France Central (Paris) | -- |
| Great Britain (GBR) | UK South (London) | UK West (Cardiff) |
| India (IND) | Central India (Pune) | South India (Chennai) |
| Japan (JPN) | Japan East (Tokyo, Saitama) | Japan West (Osaka) |
| North America (NAM) | East US (Virginia) | West US 2 (Washington) |
| Oceania (OCE) | Australia East (New South Wales) | Australia Southeast (Victoria) |
| South America (SAM) | Brazil South | Brazil Southeast |
| Switzerland (CHE) | Switzerland North | Switzerland West |

More information: [Azure Regional Pairs](/azure/best-practices-availability-paired-regions#azure-regional-pairs)

## Which users can push data from Dynamics 365 Sales to Dataverse?

The Dynamics 365 Sales data is pushed to Dataverse to generate insights such as, predictive scoring, relationship analytics, who knows whom, and predictive forecasting. A set of predefined system and application users are used to push data from Dynamics 365 Sales to Dataverse. For more information, see [System and application users](/power-platform/admin/system-application-users).

## What happens to my organization data if I switch from Sales Professional to Sales Enterprise or vice versa?

Your organization data is preserved when you switch from Sales Professional to Sales Enterprise or vice versa.  
More information: [Move from Dynamics 365 Sales Professional to Dynamics 365 Sales Enterprise](upgrade-sales-professional-sales-enterprise.md) and [Move from Dynamics 365 Sales Enterprise edition to Dynamics 365 Sales Professional](move-sales-enterprise-sales-professional.md)

## What happens to my organization data if my Sales Professional license expires?

The environment is disabled, users will not be able to access it, and the data will be deleted after 30 days. However, if there are any Dynamics 365 Sales related license available in the tenant, the data will be preserved.

## Why are my entities updated by some application users?

System and application users update certain entities with insights about the records. For example, lead and opportunity entities are updated by the application users to add predictive scores. Similarly, contact, opportunity, lead, and account entities are updated with relationship KPIs and analytics. More information: [Which users can push data from Dynamics 365 Sales to Dataverse?](#which-users-can-push-data-from-dynamics-365-sales-to-dataverse)

## Where can I find the Sales Professional and Sales Insights documentation?

We've merged the documentation for Sales Enterprise, Sales Professional, and Sales Insights into this unified Sales documentation. The license and role requirements section at the top of every article indicates whether the content applies to the license you have. Any bookmarks you have should automatically redirect to the corresponding pages in the new unified documentation.



