---
title: "Troubleshoot migration of configuration data for records based on unified routing | MicrosoftDocs"
description: "Learn to troubleshoot issues with migrating data pertaining to records enabled for unified routing from source to target environments in Omnichannel for Customer Service."
ms.date: 12/15/2022
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.reviewer: nenellim
---

# Troubleshoot migration of configuration data for records

[!INCLUDE[ur-migration considerations](../includes/cc-ur-migration-considerations.md)]

- If you see a difference in the migrated records between the source and target organizations, then you must revert the entity records and then repeat the migration process. Revert the entity records for queues, intake rules, and workstreams as follows:
    - For queues, revert the entities in the reverse order of their serial number&ndash;Assignment Configuration Step, Assignment Configuration, Decision ruleset, Decision contract, and Queue. More information: [Migrate configuration for record queues](export-import-config-data-for-records.md#migrate-configuration-for-record-queues)
    - For intake rules, revert the entities in the reverse order of their serial number&ndash;Master Entity Routing Configuration, Decision ruleset, and Decision contract. More information: [Migrate configuration for intake rules](export-import-config-data-for-records.md#migrate-configuration-for-intake-rules-for-record-routing)
    - For workstreams, revert the entities in the reverse order of their serial number&ndash;Workstream capacity profile, Routing configuration step, Routing configuration, Decision ruleset, Decision contract, and Workstream. More information: [Migrate configuration for record workstreams](export-import-config-data-for-records.md#migrate-configuration-for-record-workstreams)
### See also

[Create a schema to export configuration data](/power-platform/admin/create-schema-export-configuration-data)  
[Export and import configuration for live chat](export-import-config-data-for-live-chat.md)  