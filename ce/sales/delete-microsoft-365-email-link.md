---
title: Delete Microsoft 365 emails linked by Data Enrichment
description: Learn how to delete Microsoft 365 emails linked by Data Enrichment in Dynamics 365 Sales.
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.date: 02/16/2026
ms.update-cycle: 90-days
ms.topic: how-to
ms.service: dynamics-365-sales
ms.collection: bap-ai-copilot
---

# Delete Microsoft 365 emails linked by Data Enrichment

To comply with the privacy law requirements, you might have to delete a user's data after they leave the organization or for other reasons. This includes emails that AI-powered Data Enrichment feature has linked to opportunity records in Dynamics 365 Sales. 

## Prerequisites

You must have read/write permissions to the following tables in the Dataverse environment:

- msdyn_dataqualitysource 
- msdyn_dataqualitysuggestion 
- msdyn_dataqualitylog

## Delete linked Microsoft 365 

Deleting linked emails involves removing the links between the emails and the opportunity records, as well as deleting the associated records in the Dataverse tables used by Data Enrichment.

1. Retrieve the ID of email record to be deleted from Microsoft Graph by using Graph Explorer. 
1. Find the msdyn_dataqualitysource record corresponding to email.
1. Query the entity with filter on msdyn_originalsourceid as ID of the email retrieved in step 2 from MS graph 

Alternatively, you can also query on msdyn_sourceitemid with internetMessageId of the email 

Once the msdyn_dataqualitysource record is retrieved, you can use the ID of the record (msdyn_dataqualitysourceid) and delete the corresponding record 

msdyn_dataqualitysuggestion has lookup to msdyn_dataqualitysource as an attribute msdyn_dataqualitysourceid. Please query msdyn_dataqualitysuggestion with filter on msdyn_dataqualitysourceid as ID retrieved in step 3. After successful retrieve, please delete corresponding suggestion record (note ID of suggestion records for next step) 

msdyn_dataqualitylog has lookup to msdyn_dataqualitysuggestion in attribute msdyn_dataqualitysuggestionid. Please query msdyn_dataqualitylog with filter on msdyn_dataqualitysuggestionid as IDs retrieved in step 4. After successful retrieve, please delete corresponding log records.  