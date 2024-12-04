---
title: Prepare your organization to store conversation intelligence data in Dataverse 
description: Learn how to prepare your organization to store conversation intelligence data in Dataverse.
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.topic: conceptual 
ms.collection: 
ms.date: 01/16/2024
ms.custom: 
  - bap-template
  - ai-seo-date: 01/11/2024
  - ai-gen-docs-bap
  - ai-gen-title
  - ai-gen-desc
content_well_notification: AI-contribution
ai-usage: ai-assisted
---

# Prepare your organization to store conversation intelligence data in Dataverse 

During the first quarter of 2024, sales conversation intelligence data will be migrated from its current storage location (Microsoft-provided storage) to each customers' Dataverse organization. This section describes why this migration is important and how admins can prepare their organizations for this migration.

Sales conversation intelligence data is the general term used for any outputs generated from the processing of phone calls made through the embedded Teams dialer within Dynamics 365. This data includes files, such as the audio recording file or transcript file, and all the insights collected during a call. Examples of insights include:

- Sentiment

- Tracked keywords

- Asked questions  

- Summary suggestions

> [!IMPORTANT]
> During the migration, no data will be transferred outside of your tenant.  

## Why the migration is important?

- Moving the data into Dataverse allows you to meet the highest data management standards:
  - Data encryption using [Customer Managed Key(CMK)](/power-platform/admin/customer-managed-key)
  - Management of customer data using [Lockbox](/power-platform/admin/about-lockbox).

- The migration also allows for granular control over the conversation intelligence data:
  - Orgs can now allow access to specific types of data only for specific security roles. For example, the admin can assign privileges to the ‘sentiment’ entity in Dataverse only for sales managers.
  - This granular control also allows for deletion of specific types of data while retaining others. For example, the admin can store sentiment data for only one month, while storing the transcript of the call for one year, and by this maximizing the Dataverse storage capacity.

- Having conversation intelligence stored in Dataverse also allows organizations and non-Microsoft apps to consume the data per the organization’s needs:
  - For example, organizations can create tailored dashboards and visualizations based on the data.
  - Furthermore, the admin can allow non-Microsoft apps to access the conversation intelligence data and to provide extensible services based on it.

## Storage location before and after the migration 

The following table describes the storage location of conversation intelligence data before and after the change: 

| Current configuration | Type of data | Before migration | After migration |
|:----------------|:-------------|:------------------|:--------------------|
| Microsoft-provided storage | Files (recording, transcript) | Microsoft-provided storage | Organization’s Dataverse <sup>1,3</sup> |
| Microsoft-provided storage | Conversation intelligence insights | Microsoft-provided storage | Organization’s Dataverse <sup>1,3</sup> |
| Your own Azure blob storage | Files (recording, transcript) | Your own Azure blob storage | Your own Azure blob storage <sup>2</sup> |
| Microsoft-provided storage | Conversation intelligence insights | Microsoft-provided storage | Organization’s Dataverse <sup>1</sup> |

<sup>1</sup> After the data is successfully migrated, it will be deleted from the Microsoft-provided storage.  
<sup>2</sup> No change. This data isn't migrated.  
<sup>3</sup> Data of calls older than 90 days won't be migrated. 


After the successful migration of existing data, data from new calls will be automatically saved to Dataverse. 

## Actions you need to take 

For all organizations: 

1. Check the solution version (mandatory). Make sure you have the latest version of the conversation intelligence solution (msdyn_Conversation_Intelligence version 9.0.1.1139 or higher) installed in your organization. 

1. Provide access to new Dataverse entities (mandatory): 
   Make sure the relevant security roles have the read and write privileges to the new [conversation intelligence tables in Dataverse](conversation-intelligence-data-storage.md#how-data-is-structured-in-dataverse). 

1. Make sure that you have sufficient storage space in Dataverse (mandatory): 

    1. Find the number of calls currently in storage: 

        1. Sign in to the [Conversation intelligence app](https://sales.ai.dynamics.com/) as an administrator. 

        1. Navigate to the System monitoring page. 

        1. Set the time filter to **All time**. 

        1. Note the number of total calls. 

    1. Calculate the amount of storage space required: 

        1. Database storage: Multiply the number of calls by 160 KB. 

        1. File storage (only relevant for orgs previously using Microsoft-provided storage): Multiply the number of calls by 0.93 MB. 

        For example: if you had 20,000 calls, and you previously used the Microsoft-provided storage, you'll need to have 3.2 GB of DB storage and 18.6 GB of file storage for the migrated data. 

> [!NOTE]
> The above numbers are based on average call duration and number of insights per call. Actual sizes may vary. 
 
## Set a retention policy (optional):  

Previously, conversation intelligence data was automatically deleted according to the retention policy set by the admin in the conversation intelligence settings. By default, data saved into Dataverse doesn't have an automatic retention policy like this. If you want to set a retention policy for your conversation intelligence data in Dataverse, see [Manage data retention policies (preview)](/power-apps/maker/data-platform/data-retention-manage). 


## Set up Service principal (mandatory for Azure blob storage)

To allow conversation intelligence access to your blob storage in a more secure way, you need to set up a service principal. For more information, see [Set up own storage for call recordings](create-azure-repo.md)
