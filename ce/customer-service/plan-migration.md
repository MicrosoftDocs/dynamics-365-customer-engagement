---
title: "Introduction to migration of entity records (Dynamics 365 Customer Service) | MicrosoftDocs"
description: "Learn how to migrate entity records from the legacy Service Scheduling to the Unified Interface Service Scheduling in Dynamics 365 Customer Service"
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 10/11/2019
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-customerservice
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
---

# Plan your migration

[!INCLUDE[cc-data-platform-banner](../includes/cc-data-platform-banner.md)]

This topic explains the considerations and best practices that you need to be aware before starting the migration.

## Considerations for migration

The following conditions need to be considered to perform migration.

- **Role privileges:** To perform the migration, you must have administrator or system customizer roles. The list of privileges that are required if you want to assign to any other roles are as follows:
    - msdyn_ursmigrationlogs
    - msdyn_ursmigrationinfo
    - msdyn_ursmigratedentitiesinfo

- **Order of migration:** Migration of the entity records follow an order. That is, when the migration of one entity record completes, then the next entity will be processed for migration.

    The order of the migration is as stated:
    1. Site
    2. User
    3. Facility/Equipment
    4. Team
    5. Resource Group
    6. Service
    7. Service Activity

- **Migration start date and end date:** Start date and end date helps you to migrate the service activities that are scheduled to happen between the date range you’ve specified (only the start date is inclusive).

    Scenario example: You’ve specified the migration end date field as **07/22/2019**.

    | Migration End date | Activity scheduled date | Activity end date | Entity record migration | Reason |
    |----------|----------|----------|---------|------------------------------------|
    | 07/22/2019 | 07/23/2019 | 07/23/2019| No | The service activity won’t be migrated as the scheduled date is beyond the end date. |
    | 07/22/2019 | 07/22/2019 at 2300 hours | 07/23/2019 at 0500 hours | No | The service activity won’t be migrated as the scheduled activity ends at a date later than the specified migration end date. |
    | 07/22/2019 | 07/22/2019 at 2359 hours | 07/22/2019 at 0500 hours | Yes | The service activity will be migrated as the activity ends before the specified migration end date. |

- **Recommendation:** For best migration experience, we recommend that you don't use Service Scheduling until the migration is completed.

- **Ignore entity records:** If you don't want to migrate certain entity records from legacy Service Scheduling to Unified Interface based Service Scheduling, then you need to add **Migration Status** attribute and set the value as **Ignore**. The records that are marked as **Ignore** won’t be migrated by the tool. The field displays the following statuses:

    | Status | Description |
    |----------------|----------------------------------------------|
    | Failed | The entity records that failed in the migration process. |
    | Ignore | The entity records that are ignored in the migration process. |
    | In Progress | The entity records that are in progress in the migration process. |
    | Migrated | The entity records that are migrated in the migration process. |
    | Not Started | The entity records that are not yet started for migration. |

- **Failed Migration for certain records:** When the migration of an entity record fails, then you can retry migration. For the retry scenario, the number of records that are displayed in the screen are the records that didn’t migrate in the first run of the migration and also, those entity records that were created after the first run.

- **New entity record:** If you create any records after you start the migration, the new entity records might not be reflected in the migration summary.

- **Custom plugins and workflows:** After the migration, if you’ve custom plugins and workflows, examine them for compatibility with the new scheduling experience.

- **Updating records during migration:** After you’ve migrated an entity record, if you update the record in the legacy service scheduling, the difference of update can’t be migrated using the tool. You must manually update the changes in the new service scheduling experience.

## Ignore entity records during migration

To ignore an entity record during migration, perform the following steps.

1. Sign in to Dynamics 365.

2. Go to **Settings** > **Customizations** > **Customize the System**.

3. Expand the entity you want to ignore, and select **Forms**. For example: **Facility/Equipment**.

4. Select the section to which you want to add the field.

5. Drag the **Migration Status** field from the **Field Explorer** pane and drop the field in the section where you want to add.

6. Select **Save**.

7. Select **Publish** to publish the customizations.

### See also

[Introduction to migration of entity records](introduction-migration-entity-records.md)

[Migrate entity records](migrate-entity-records.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]