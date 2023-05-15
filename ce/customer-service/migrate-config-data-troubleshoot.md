---
title: Troubleshoot migration of records | MicrosoftDocs
description: Learn to troubleshoot issues with migrating data pertaining to records enabled for unified routing from source to target environments in Omnichannel for Customer Service.
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.topic: troubleshooting
ms.date: 12/20/2022
ms.custom: bap-template
---

# Troubleshoot migration of records

[!INCLUDE[ur-migration considerations](../includes/cc-ur-migration-considerations.md)]

## Revert unmanaged records 

If you see a difference in the migrated records between the source and target organizations, then you must delete the unmanaged entity records and repeat the migration process. 
In the target organization, perform the following steps:

1. For queues, revert the entities in the reverse order of the serial number (**S.No** column) that's listed in the migration article at [Migrate configuration for record queues](migrate-config-data-for-records.md#migrate-configuration-for-record-queues). Migrate the entities in this order:

    1. Assignment Configuration Step
    2. Assignment Configuration
    3. Decision ruleset
    4. Decision contract
    5. Queue


2. For workstreams, revert the entities in the reverse order of their serial number (**S.No** column) that's listed in the migration article at [Migrate configuration for record workstreams](migrate-config-data-for-records.md#migrate-configuration-for-record-workstreams). Migrate the entities in this order:
    1. Workstream capacity profile
    1. Routing configuration step
    1. Routing configuration
    1. Decision ruleset
    1. Decision contract
    1. Workstream 
    
      For intake rules, revert the entities in the reverse order of their serial number (**S.No** column) that's listed in the migration article at [Migrate configuration for intake rules](migrate-config-data-for-records.md#migrate-configuration-for-intake-rules-for-record-routing). Migrate the entities in this order:
      1. Master Entity Routing Configuration
      1. Decision ruleset
      1. Decision contract

## Next steps

1. [Migrate queues](migrate-config-data-for-records.md#migrate-configuration-for-record-queues)  
2. [Migrate intake rules](migrate-config-data-for-records.md#migrate-configuration-for-intake-rules-for-record-routing)  
3. [Migrate workstreams](migrate-config-data-for-records.md#migrate-configuration-for-record-workstreams)  

### See also

[Create a schema to export configuration data](/power-platform/admin/create-schema-export-configuration-data)  
[Overview of data migration for records](migrate-config-data-for-records-overview.md)  
[Use FetchXML query to filter records](use-fetchxml-filter-records.md)  
[Migrate configuration data for records](migrate-config-data-for-records.md)  
[Verify migration of records](migrate-config-data-verify.md)  
[Migrate configuration data for live chat](migrate-config-data-for-live-chat.md)  
[Migrate configuration data for voice channel](migrate-config-data-for-voice-channel.md)   