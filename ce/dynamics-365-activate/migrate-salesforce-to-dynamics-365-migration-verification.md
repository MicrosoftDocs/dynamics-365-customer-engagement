---
title: Migrate data and verify results (preview)
description: Learn how to run a data migration from Salesforce to Dynamics 365, monitor migration progress, handle errors, and verify that all records were migrated successfully.
ms.date: 09/09/2026
ms.update-cycle: 180-days
ms.topic: how-to
ms.service: dynamics-365-sales
ms.custom:
  - bap-template
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: zobanyai
ms.collection: bap-ai-copilot
---

# Step 7: Migrate data and verify results (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Learn how to run and verify a data migration from Salesforce to Dynamics 365. Validate migration readiness, select migration modes, monitor progress, resolve errors, and confirm that records migrated successfully.

Dynamics 365 Activate provides two levels of verification:  

- **Run reconciliation** on the Migration page compares Salesforce and Dataverse record counts for a completed migration run.
- **Dashboard verification** evaluates migrated objects across the project and can perform configurable record sampling with field-by-field comparisons.  

[!INCLUDE [preview-note](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Prerequisites

Before starting migration, confirm that you completed the following tasks:

- Salesforce and Dynamics 365 discovery are complete and connections are active.
- Object and field mappings are complete and validated. See [Map Salesforce objects and fields to Dynamics 365](migrate-salesforce-to-dynamics-365-object-mapping.md).
- All required Dataverse solution components are deployed. See [Deploy the Dynamics 365 schema for migration](migrate-salesforce-to-dynamics-365-solution-deployment.md).
- Selected objects have a **Verified** or accepted **Partial** contract status.
- The Dataverse application user has the privileges required to create, update, append, assign, and relate records for the selected workloads.
- User mappings are reviewed if you plan to preserve Salesforce **Created By** or **Modified By** values.
- Record filters, transformations, choice mappings, and audit-field settings are reviewed.

> [!IMPORTANT]
> Always perform migration on a **non-production Dynamics 365 environment** first. Validate results thoroughly before migrating to a production environment. Migration outcomes depend on source data quality, and the customer remains responsible for post-migration testing and reconciliation.

## Understand migration modes

The application supports three migration modes:

| Mode | Availability | Description |
|---|---|----|
| **Trial 100** | First migration | Migrates up to 100 records from the table. Use this mode to validate mappings, transformations, choices, lookups, and target behavior before running a full migration. |
| **Full migration** | First migration or a subsequent migration | Processes all records in scope for the table. If a record has the same migration identity as a previously migrated record, the existing record is updated. Otherwise, a new record is created. |
| **Delta** | Subsequent migrations | Processes Salesforce records that changed after the table's most recent successful migration in the project. |

Resume is a recovery action for an entire run, not a migration mode for individual tables. It's available for stopped or failed runs. When you resume a run, the migration continues and skips objects that are already complete.

If you select Delta for a table without a previous successful migration, Dynamics 365 Activate warns you that it runs a full migration instead. Complete an initial full migration before using Delta for subsequent migrations.


## Review the consent summary

Before migration starts, the **Migration Preview** shows:

- Selected Salesforce objects and their target Dataverse tables.
- Number of mapped fields for each object.
- Estimated Salesforce record counts.
- The effective number of records that the migration process handles.
- Trial limits of up to 100 records per table.
- Estimated duration for supported runs.
- Warnings for large migrations.
- Warnings when a selected Delta table has no previous migration history and runs as Full.

Review the Data Migration Consent section. It identifies whether the selected tables run as Trial, Full, Delta, or a mixture of modes.

Select the checkbox to confirm that you understand the operation writes data to the connected Dynamics environment. Then select **Confirm & Start Migration**. For a resumable run, select **Confirm & Resume**.

## Start migration

1. Open the project and select **Migration**.
1. Confirm that the solution and migration-contract prerequisites show as complete.
1. Under **Migration Settings**, configure audit-field preservation if required.
1. If you want to preserve Salesforce user attribution, review or create the Salesforce-to-Dataverse user mappings.
1. Under **Objects to Migrate**, select the tables to include.
1. Select **Trial 100**, **Full**, or **Delta** for each table, according to its migration history.
1. Select **Validate** and review the preflight results.
1. Select **Start Migration**.
1. Review the preview, acknowledge the consent statement, and select **Confirm & Start Migration**.

For the bulk migration path, Dynamics 365 Activate extracts data from Salesforce, stages it in the project's configured Azure Blob Storage, and loads it into Dataverse. The staging location can be Microsoft-managed storage or customer-owned Bring Your Own Storage.

Migration execution continues in the background. You can close the browser and return later to review the run, but browser notifications and live progress are available only while the page is open.

## Monitor migration progress

The **Migration Status** section shows:

- Processed and total record counts.
- Completed object count.
- Individual record error count.
- Overall percentage and current object.
- Elapsed time, estimated remaining time, and final duration.
- Delta watermark or trial row limit, when applicable.

The following table describes the possible migration statuses for each object:

| Status | Description |
|---|---|
| **Pending** | The object is queued and hasn't started yet. |
| **In Progress** | Records are being extracted from Salesforce and loaded into Dynamics 365. |
| **Completed** | All records for this object were migrated successfully. |
| **Completed with Errors** | Most records were migrated, but some records failed validation. |
| **Failed** | The object migration failed. Review the error log for details. |
| **Skipped** | The object was excluded from migration or was already completed in a previous run. |

The page shows a summary counter for total records migrated, in progress, completed, and failed.

### Migration order (dependency waves)

The application migrates objects in **dependency order**: parent objects are migrated before child objects that reference them. For example, Account is migrated before Contact (which has a lookup to Account). This order ensures that relationship (lookup) fields can be properly resolved.

The application determines the dependency order automatically during the mapping phase based on your object relationships.

## Handle migration errors

If some records fail:

1. On the **Migration** tab, select the object that has errors.
1. Select **View Error Log** to see a list of failed records with error details.
1. Common error types:

   | Error type | Description and resolution |
   |---|---|
   | **Validation error** | A record value doesn't meet a Dynamics 365 constraint (for example, a required field is blank or a value is too long). Review the source data in Salesforce, correct the data, and re-run the migration for the affected object. |
   | **Lookup resolution failure** | A lookup field references a parent record that doesn't exist in Dynamics 365. This error can occur if the parent object wasn't included in the migration scope. Add the parent object to the migration scope and re-run. |
   | **Duplicate detection** | A record already exists in Dynamics 365 and the duplicate detection rules blocked the import. Review duplicates in Dynamics 365 and consider disabling duplicate detection rules during migration. |
   | **Permission error** | The Application User lacks the required create or write permission on the target table. Grant the necessary privileges and re-run. |

1. After resolving the root cause, you can resume migration from where it stopped:  
    Select **Resume Migration** to continue processing only the objects with errors or that are still pending.

## Stop a migration

To stop a running migration:

1. On the **Migration** tab, select **Stop Migration**.
1. In the dialog, confirm that you want to stop the migration.

The current in-progress batch finishes before the migration stops. Any object that was already completed retains its migrated records. You can resume from where you stopped by selecting **Resume Migration**.

## Verify migration results

After migration finishes, verify that all records migrated correctly.

### Run reconciliation

Reconciliation compares the number of records in Salesforce with the number of records in Dynamics 365 for each migrated object.

1. On the **Migration** tab, select **Run Reconciliation**.
1. The application queries both Salesforce and Dynamics 365 for record counts per object.
1. Review the reconciliation results:

   | Result | Description |
   |---|---|
   | **Matched** | Record counts are equal between Salesforce and Dynamics 365. |
   | **Mismatched** | Record counts differ. Review the error log for skipped or failed records. |
   | **Pending** | Reconciliation hasn't run yet for this object. |

### Manual verification in Dynamics 365

In addition to record count reconciliation, perform spot checks in Dynamics 365:

- Open several migrated records and verify that field values are correct.
- Check that lookup relationships resolve correctly (for example, that a Contact's parent Account is properly linked).
- Verify that option set values (picklists) appear correctly in the Dynamics 365 UI.
- Run sample reports in Dynamics 365 Sales or Customer Service and confirm that data appears as expected.

> [!IMPORTANT]
> Post-migration validation and reconciliation are your responsibility. Don't use migrated data in production until you complete thorough testing and validation.

## Related information

- [Map Salesforce objects and fields to Dynamics 365](migrate-salesforce-to-dynamics-365-object-mapping.md)
- [Deploy the Dynamics 365 schema for migration](migrate-salesforce-to-dynamics-365-solution-deployment.md)
- [Set up Bring Your Own Storage for migration data](migrate-salesforce-to-dynamics-365-byos.md)
- [Clean up after a Salesforce migration](migrate-salesforce-to-dynamics-365-cleanup.md)
- [Overview of Dynamics 365 Activate](migrate-salesforce-to-dynamics-365-overview.md)
