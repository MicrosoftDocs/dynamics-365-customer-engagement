---
title: Delete Microsoft 365 emails linked by Data Enrichment
description: Delete Microsoft 365 emails linked by Data Enrichment in Dynamics 365 Sales. Follow step-by-step instructions to ensure compliance and protect user privacy.
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.date: 04/21/2026
ms.update-cycle: 90-days
ms.topic: how-to
ms.service: dynamics-365-sales
ms.collection: bap-ai-copilot
---

# Delete Microsoft 365 emails linked by Data Enrichment

To comply with privacy law requirements, you might need to delete emails linked by the AI-powered Data Enrichment feature in Dynamics 365 Sales. This requirement includes emails that the AI-powered Data Enrichment feature links to opportunity records in Dynamics 365 Sales. 

## Prerequisites

You must have read and write permissions to the following tables in the Dataverse environment:

- **msdyn_dataqualitysource**: Stores the source information for data enrichment actions, linking back to the original email.
- **msdyn_dataqualitysuggestion**: Contains suggestions for improving data quality, referencing the source entity.
- **msdyn_dataqualitylog**: Maintains logs of actions or changes related to data quality suggestions.

## Delete linked Microsoft 365 emails 

To delete Microsoft 365 emails linked by Data Enrichment, remove the links between the emails and the opportunity records. Also, delete the data enrichment suggestions and logs associated with those emails. 

Follow these steps to perform the deletion:

1. In Microsoft Graph Explorer, find the email and note its ID. You use this value to locate related Data Enrichment records.
1. In the `msdyn_dataqualitysource` table, find the source record for that email by using either of these filters:
    - `msdyn_originalsourceid` equals the email ID from Microsoft Graph.
    - `msdyn_sourceitemid` equals the email `internetMessageId`.
1. Delete the matching record in `msdyn_dataqualitysource`, and note its `msdyn_sourceid`.
1. In the `msdyn_dataqualitysuggestion` table, find records where `msdyn_dataqualitysourceid` equals the `msdyn_sourceid` from the previous step. Delete the matching suggestion records, and note their IDs.
1. In the `msdyn_dataqualitylog` table, find records where `msdyn_suggestionid` equals the suggestion IDs from the previous step. Delete all matching log records.