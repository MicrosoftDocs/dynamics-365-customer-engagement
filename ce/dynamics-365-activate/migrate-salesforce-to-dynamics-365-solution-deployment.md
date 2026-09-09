---
title: Deploy the Dynamics 365 schema for migration (preview)
description: Learn how to generate and deploy a Dynamics 365 solution that creates the tables, columns, and option sets required for your Salesforce-to-Dynamics 365 migration.
ms.date: 09/09/2026
ms.update-cycle: 180-days
ms.topic: how-to
ms.service: dynamics-365-sales
ms.custom:
  - bap-template
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
---

# Step 6: Deploy the Dynamics 365 schema for migration (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Before migration, verify that the target Dataverse environment contains the tables, columns, choices, and relationships required by your mappings.  
If your mappings require new schema, Dynamics 365 Activate can generate and import a Dataverse solution. You don't need to import a solution if all selected mappings use existing, writable Dataverse schema.  
If an existing table is missing mapped columns, either deploy those columns or use a partial migration contract. A partial contract migrates only fields that you verify against the current Dataverse schema.

[!INCLUDE [preview-note](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## What solution deployment does

Solution deployment creates or extends the Dataverse schema required by the selected mappings. Depending on the mappings and current target metadata, the generated solution can include:

- **New tables**: Custom tables for Salesforce custom objects mapped to "Create new table" in the mapping phase.
- **New columns**: Custom columns for fields mapped to "Create new column".
- **Option sets**: Choice columns with values derived from Salesforce picklist values.
- **Relationships**: Lookup columns that represent Salesforce relationship fields.
- **Audit**-preservation columns
- **Table design** settings configured for newly created tables.

The generator excludes ignored fields, out-of-scope objects, components that already exist, and schema changes that Dataverse doesn’t support. Warnings in the solution preview identify components that require review or can’t be generated.

Existing Dataverse tables and columns aren’t recreated. However, the generated solution can extend an existing table when the reviewed mappings require additional schema. Depending on the selected mappings, deployment can:  

- Add custom columns to existing standard or custom tables.
- Add supported lookup relationships.
- Add new values to supported existing local choice columns.
- Add audit-preservation columns when audit-field preservation is configured.
- Reference or create global choices according to the approved picklist mappings.

Existing native columns that are already present remain in place. Review the solution preview carefully to understand which existing tables will be extended.

## Prerequisites

- Complete and validate object and field mappings. See [Map Salesforce objects and fields to Dynamics 365](migrate-salesforce-to-dynamics-365-object-mapping.md).
- Active Dynamics 365 connection (Application User with System Customizer role). See [Connect to Dynamics 365 and run discovery](migrate-salesforce-to-dynamics-365-connect-dynamics.md).

## Generate the solution

1. Open Dynamics 365 Activate and go to your project.
1. In the sidebar, select **Solution**.
1. Review the available sections:
    - **New Tables** lists Salesforce objects mapped to new Dataverse tables.
    - **Missing Columns** lists existing Dataverse tables that can be extended with more mapped columns.
    - **Already in Dynamics** lists mapped tables whose selected schema is already available.
1. Select the objects to include in the solution.
1. Configure the solution name, version, publisher prefix, and solution type.
1. Select one of the following actions:
    - **Preview Solution** to review the package contents without downloading or importing it.
    - **Download Solution ZIP** to generate a package for manual review or import.
    - **Import to Dynamics** to generate and directly import the package into the connected environment.

The application creates a Dynamics 365 solution ZIP package that contains:  

- **solution.xml**: Solution manifest with component metadata.
- **customizations.xml**: Entity and attribute definitions for all new tables, columns, and option sets.

Generation usually finishes in seconds. When it's done, the solution status shows **Generated** with a timestamp.

## Review the solution contents

Before deploying, review what the application will create:

- The **Solution Summary** section shows the count of new tables, columns, and option sets included in the solution.
- Select **View Solution Details** to see a full list of components.

Review the solution contents to confirm that:  

- The solution includes only the objects and fields you expect.
- Table and column names follow your organization's naming conventions.
- The solution doesn't overwrite any standard tables.

## Deploy the solution

1. On the **Solution Deployment** tab, select **Deploy Solution**.
1. The application imports the solution into your connected Dynamics 365 environment. A progress indicator shows the import status.
1. Wait for the deployment to complete. Typical deployment times range from a few seconds to several minutes, depending on the size of the schema.

When deployment succeeds, the status shows **Deployed** with a timestamp, and you can proceed to data migration.

> [!NOTE]
> Solution import is an asynchronous operation in Dynamics 365. The application polls the import status and updates the display in real time. Don't navigate away from the page until the status shows **Deployed** or an error.

## Handle deployment errors

If solution deployment fails:

1. Select **View Import Log** to see the detailed error from Dynamics 365.
1. Common causes of deployment failures:

    | Issue | Resolution |
    |---|---|
    | **Duplicate table or column name** | A table or column with the same name already exists in the environment. Adjust the mapping to use the existing table or column, or choose a different name. |
    | **Invalid character in name** | Table and column names must start with a letter and contain only lowercase letters, numbers, and underscores. Review the mapping and rename as needed. |
    | **Insufficient privileges** | The Application User might lack required permissions. Verify that the **System Customizer** role is assigned. |
    | **Solution size limit** | Large solutions with many components might exceed Dynamics 365 import limits. Contact your Microsoft engagement contact for assistance. |
    | **Missing relationship dependency** | Include or preinstall the referenced table, or change the relationship mapping. Some Dataverse table types can't participate in custom relationships. |
    | **Unsupported standard-table customization** | Some standard or intersect tables don't allow custom columns or relationships. Review the preview warnings and exclude or remap the unsupported component. |
    | **Existing managed component** | A component owned by another managed solution might not allow the proposed change. Review the solution layer and component ownership in the target environment. |

1. After resolving the issue, regenerate and redeploy the solution.

## Redeploy after mapping changes

If you change your object or field mappings after an initial deployment, you must regenerate and redeploy the solution:

1. Update your mappings on the **Mapping** tab.
1. Return to **Solution Deployment** and select **Generate Solution** to create an updated package.
1. Select **Deploy Solution** to import the updated solution.

An updated solution can add components or update supported solution metadata, depending on the selected objects, publisher prefix, solution identity, version, and managed or unmanaged solution type.  
Adding a new table or column doesn’t normally delete existing records. However, don’t assume that every solution update is risk-free. Changes to data types, relationships, choices, required settings, managed solution layers, or component ownership can affect existing customizations and data behavior.

Before redeployment:  

- Resync with Dynamics.
- Review the updated mappings.
- Preview the generated solution.
- Confirm that the solution name, publisher prefix, version, and managed state follow the existing solution lifecycle.
- Test the update in a nonproduction Dataverse environment.
- Back up the target environment according to your organization’s change-management policy.

## After deployment

Once the solution is deployed, your Dynamics 365 environment has the schema required for migration. You can verify the deployment by:

- Opening [Power Apps](https://make.powerapps.com) and navigating to your environment's **Tables** list to confirm the new tables and columns are present.
- Running a quick Dynamics 365 discovery in the application to refresh the schema view.

You're now ready to start data migration.

## Related information

- [Map Salesforce objects and fields to Dynamics 365](migrate-salesforce-to-dynamics-365-object-mapping.md)
- [Migration and verification](migrate-salesforce-to-dynamics-365-migration-verification.md)
- [Connect to Dynamics 365 and run discovery](migrate-salesforce-to-dynamics-365-connect-dynamics.md)
