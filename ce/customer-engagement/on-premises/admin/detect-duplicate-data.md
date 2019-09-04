---
title: "Detect duplicate data for Dynamics 365 for Customer Engagement apps | MicrosoftDocs"
ms.custom: 
ms.date: 09/30/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
author: jimholtz
ms.assetid: 4bfccb7c-c29d-4a33-900e-3b3665fa4cf4
caps.latest.revision: 34
ms.author: jimholtz
manager: kvivek
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - Powerplatform
---
# Detect duplicate data in Customer Engagement (on-premises)


To determine whether a record is a potential duplicate, Dynamics 365 Customer Engagement (on-premises) uses duplicate detection rules. When publishing a duplicate detection rule, a matchcode is created for each existing record. A matchcode is also created when a record is created or updated. When a record is in the process of being created or updated, its matchcode can be checked automatically against the matchcodes of existing records. By default, [!INCLUDE[pn_microsoftcrm](../includes/pn-dynamics-crm.md)] apps has simple duplicate detection rules for accounts, contacts, and leads. For example, you detect duplicates by matching the record fields, such as email address, first name, and last name.  
  
Duplicate detection works by comparing generated match codes of existing records with each new record being created. These match codes are created as each new record is created. Therefore, there is potential for one or more duplicate records to be created if they are processed at the exact same moment. In addition to detecting duplicates as they are created, you should schedule duplicate detection jobs to check for other potential duplicate records.  
  
For detailed information, see <link>

## Duplicate detection rules

<Brief description goes here>

For more information: <Link to the topic> 

## Turn duplicate detection rules on or off

<Brief description goes here>

For more information: <Link to the topic> 

## Bulk duplicate detection

<Brief description goes here>

For more information: <Link to the topic> 

