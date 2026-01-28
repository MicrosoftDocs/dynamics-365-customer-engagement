---
title: Licenses and storage FAQs
description: Discover answers to common questions about licenses and storage.
ms.date: 01/27/2026
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

This article answers frequently asked questions about licenses and storage in Dynamics 365 Sales.

<a name="license-compliance"></a>
## How to ensure an organization is compliant with the Dynamics 365 licensing terms and conditions?

Review the [Dynamics 365 licensing guide](https://go.microsoft.com/fwlink/?LinkId=866544) to ensure that you have the appropriate licenses for all the Dynamics 365 features and functionalities that you're using.

## Which out-of-the-box sales apps can I use?

Depending on your license type, you can use either use the Sales Hub app or the Sales Professional app. You must not use the app that isn't included in your license, even if it's visible in your environment. Learn more about the licensing requirements in [Dynamics 365 Sales licensing guide](https://go.microsoft.com/fwlink/?LinkId=866544).

## How can I assign licenses to users?  

To assign licenses to users, see [Assign licenses to users](/microsoft-365/admin/manage/assign-licenses-to-users?view=o365-worldwide).


## FAQs about Copilot credits bundled with specific Dynamics 365 Sales licenses

Copilot Studio credits are included with specific Dynamics 365 licenses to enable AI-powered features. Learn more about the licenses that include Copilot Studio credits in the [Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/?LinkId=866544), under the "Copilot Credit Entitlements" section. 

### What are Copilot Studio credits?

Copilot Studio credits are a type of capacity that allows users to utilize AI-powered features in Dynamics 365 Sales. These credits enable sellers to leverage AI capabilities such as Copilot chat and AI agents to enhance their sales processes and improve productivity.

### How many Copilot Studio credits do I get and how often are they allocated?

Each user receives a monthly allocation of Copilot Studio credits to utilize these AI features. These credits aren't cumulative and are reset each month. For information on the specific number of credits included with your license, refer to the [Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/?LinkId=866544).

You will be notified in advance when the initial credits are allocated to your tenant. There will be no disruption to your service during this process.

### How can I track usage of the allocated credits?

You can monitor credit usage in the [Power Platform admin center](/power-platform/admin/manage-copilot-studio-messages-capacity?tabs=new).  If you have questions or don't see your credits yet, contact Microsoft support for assistance. 

### What if I need more credits?

The included credits per user are designed to cover typical usage for most organizations. If your organization exceeds the included credits, you can purchase additional Copilot Studio credits as needed. Learn more in [Manage Copilot Studio credits and capacity](/power-platform/admin/manage-copilot-studio-messages-capacity?tabs=new)

### How can I ensure that credits allocated to my tenant are used by my sales team?

Allocate the credits to the Dynamics 365 Sales environment that your sales team uses, as there is no other way to prevent other agents in your tenant from using the capacity. Learn more about capacity allocation in [Manage capacity](/power-platform/admin/manage-copilot-studio-messages-capacity?tabs=new#manage-capacity).

## Can I use the Sales Hub app irrespective of my license type?

No, the Sales Hub app and Sales Professional app are licensed separately. Based on your license type, you can use only one of these apps, even if both apps are visible in your environment. Learn more about the licensing requirements for the apps in [Dynamics 365 Sales licensing guide](https://go.microsoft.com/fwlink/?LinkId=866544).

## After I installed Sales Insights, I see a spike in the data usage. How much storage data does Sales Insights need?  

When you install Sales Insights, corresponding analytics tables are created for contacts, opportunities, leads, accounts, and activityparty tables. The storage requirement for these analytics tables is directly proportional to the amount of data in Dataverse. The tables are stored as files in the managed data lake and will be counted against your total file storage quota. For more information, see [New Microsoft Dataverse storage capacity](/power-platform/admin/capacity-storage).

## Where is my organization's data stored?  

Your organization's data is stored in the Azure datacenter location that corresponds to the region where your Dynamics 365 org is hosted. For more information about the primary and secondary datacenter locations for each region, see [Azure regional pairs](/azure/best-practices-availability-paired-regions#azure-regional-pairs).

## Which users can push data from Dynamics 365 Sales to Dataverse?

Dynamics 365 Sales data is pushed to Dataverse to generate insights like predictive scoring, relationship analytics, who knows whom, and predictive forecasting. A set of predefined [system and application users](/power-platform/admin/system-application-users) might push data from Dynamics 365 Sales to Dataverse.

## What happens to my organization data if I switch between licenses?

Your organization data is preserved when you switch from one license to the other. More information: [Move from Dynamics 365 Sales Professional to Dynamics 365 Sales Enterprise](upgrade-sales-professional-sales-enterprise.md) and [Move from Dynamics 365 Sales Enterprise edition to Dynamics 365 Sales Professional](move-sales-enterprise-sales-professional.md)

## What happens to my organization data if my license expires?

The environment is disabled, users won't be able to access it, and the data will be deleted after 30 days. However, if there are any other related licenses available in the tenant, the data is preserved.

## Why are my entities updated by some application users?

System and application users update certain entities with insights about the records. For example, lead and opportunity entities are updated by the application users to add predictive scores. Similarly, contact, opportunity, lead, and account entities are updated with relationship KPIs and analytics. More information: [Which users can push data from Dynamics 365 Sales to Dataverse?](#which-users-can-push-data-from-dynamics-365-sales-to-dataverse)

## Where can I find the Sales Professional documentation?

We've merged the documentation for all Dynamics 365 Sales apps into this documentation site. Instructions specific to Sales Professional are indicated in the content where applicable. 