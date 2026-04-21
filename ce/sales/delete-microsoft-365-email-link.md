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

1. Retrieve the email record's ID from Microsoft Graph by using Graph Explorer.
1. In the `msdyn_dataqualitysource` table, find the record corresponding to the email using one of the following methods:
    - Query the table with a filter on `msdyn_originalsourceid` as the ID of the email retrieved from Microsoft Graph. 
    - Alternatively, you can also query on `msdyn_sourceitemid` with `internetMessageId` of the email. 
    
1. After you retrieve the `msdyn_dataqualitysource` record, use the record ID (`msdyn_dataqualitysourceid`) to delete the corresponding record. Note the ID of the deleted record for the next step.

1. Query `msdyn_dataqualitysuggestion` with a filter on `msdyn_dataqualitysourceid` as the ID retrieved in step 3. After you successfully retrieve the record, delete the corresponding suggestion record. Note the ID of the deleted suggestion record for the next step.
1. Query `msdyn_dataqualitylog` with a filter on `msdyn_dataqualitysuggestionid` as the IDs retrieved in step 4. After you successfully retrieve the records, delete the corresponding log records. 