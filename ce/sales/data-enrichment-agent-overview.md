---
title: Data Enrichment Agent overview
description: Learn how the Data Enrichment Agent in Dynamics 365 Sales automates updating and enriching customer data based on recent interactions.
ms.date: 01/19/2026
ms.update-cycle: 180-days
ms.topic: overview
ms.service: dynamics-365-sales
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-description
  - ai-seo-date:08/04/2025
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Data Enrichment Agent overview

Data Enrichment Agent helps sellers and managers maintain accurate and complete opportunity data. Incomplete or outdated opportunity records can lead to missed sales, inaccurate forecasting, and inefficient deal reviews. The Data Enrichment Agent addresses this challenge by automatically analyzing recent email interactions and suggesting updates to opportunity records. This proactive approach reduces manual data entry, improves pipeline confidence, and supports more effective deal reviews and forecasting.

## How the Data Enrichment Agent works

1. **Filters opportunity records**: The agent applies the criteria defined by the admin to select relevant opportunity records for analysis.

1. **Analyze recent changes**: The agent scans emails exchanged between sellers and customers to gather context about selected opportunities. It can also leverage data from the Sales Close Agent - Research (if configured) to enhance its understanding of the opportunity.
1. **Identify missing or outdated fields**: It compares the information in the emails and Sales Close Agent - Research data with the existing opportunity records to identify any discrepancies or gaps.
1 . **Suggest updates**: The agent generates suggestions for updating opportunity fields, such as estimated close date and budget amount, and associating relevant emails. Alternatively, an admin can configure the agent to automatically update the records without any manual intervention. 
1. **Review and apply updates**: Sellers can review the suggested updates and choose to apply them to the opportunity records with a single click. In cases where automatic updates are enabled, the sellers can still review the changes made by the agent and revert them if necessary.

## Set up and use the Data Enrichment Agent


## Responsible AI


