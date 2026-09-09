---
title: Map Salesforce objects and fields to Dynamics 365 (preview)
description: Learn how to map Salesforce objects and fields to Dynamics 365 tables and columns in Dynamics 365 Activate, including auto-generated mappings, data type conversions, and validation.
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

# Step 4: Map Salesforce objects and fields to Dynamics 365 (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Object mapping defines how your Salesforce data model translates to Dynamics 365. You map each Salesforce object (table) to a Dynamics 365 table, and each Salesforce field (column) to a Dynamics 365 column. This mapping drives both the Dynamics 365 schema creation and the data migration.

[!INCLUDE [preview-note](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Prerequisites

Before you can create mappings, you must:

- Run Salesforce discovery to populate the list of objects and fields. See [Connect to Salesforce and run discovery](migrate-salesforce-to-dynamics-365-connect-salesforce.md).
- Run Dynamics 365 discovery before generating mappings. Dynamics discovery provides the live target tables, columns, relationships, data types, and writability metadata required to map Salesforce data to existing Dataverse schema. See [Connect to Dynamics 365 and run discovery](migrate-salesforce-to-dynamics-365-connect-dynamics.md).

## Open the Mapping tab

1. Open Dynamics 365 Activate and go to your project.
1. In the sidebar, select **Mapping**.

The Mapping page displays migration-eligible and out-of-scope Salesforce objects in a mapping workbench. Use the scope tabs, readiness indicators, search, and grouping controls to review the generated mappings.

Select an object to open its detail panel. From the detail panel, you can review its target table, field mappings, relationship behavior, migration wave, record filter, and other mapping settings.

## Auto-generate mappings

The application includes prebuilt standard mappings for common Salesforce objects and fields. Auto-generating mappings applies predefined mappings to supported Salesforce objects and generates proposed mappings for other migration-eligible objects and fields.

On the **Mapping** tab, select **Auto-Generate Mappings**.

The application creates:  

- Salesforce objects mapped to existing Dataverse tables.
- Salesforce objects proposed as new Dataverse tables.
- Fields matched to existing writable Dataverse columns.
- Fields proposed as new Dataverse columns.
- Fields and objects placed out of scope because they’re unsupported, system-managed, read-only, or explicitly excluded.
- Specialized mappings handled by post-load processing, such as activity parties, attachments, lifecycle status, polymorphic lookups, and record ownership.

Auto-generated mappings are proposals. Review their target, confidence, migration strategy, and scope before deployment.

## Review and adjust mappings

Auto-generated mappings are a starting point. Review them and adjust as needed before deploying the schema or running migration.

### Object-level mappings

For each discovered Salesforce object, you can:

- **Map to an existing table**: Select from tables already in your Dynamics 365 environment. Use this mapping for standard objects like Account, Contact, and Opportunity that have existing Dynamics 365 equivalents.
- **Create a new table**: Define a custom table name. The application creates this table in Dynamics 365 when you deploy the solution. Table names must start with a letter and contain only lowercase letters, numbers, and underscores.
- **Exclude from migration**: Mark objects that shouldn't be migrated, such as low-usage objects identified in the **Usage & Tech Debt** discovery category.

### Field-level mappings

For each field within an object, you can:

- **Map to an existing column**: Select from columns already defined on the target Dynamics 365 table.
- **Create a new column**: Define a custom column name. The application creates this column in Dynamics 365 when you deploy the solution.
- **Exclude from migration**: Mark fields that shouldn't be migrated.

To edit field mappings for an object:

1. On the **Mapping** page, select an object row to open its mapping details. 
1. Open the field mappings view, and then select a field to edit its target, data type, migration strategy, or transformation settings.
1. Review the field mappings listed.
1. Select a field row to change its target column or exclude it.

## Standard object mappings

The following standard objects have prebuilt mappings:

| Salesforce object | Dynamics 365 table |
|---|---|
| Account | account |
| AccountContactRelation | connection |
| Contact | contact |
| Campaign | campaign |
| CampaignMember | campaignresponse |
| Lead | lead |
| Opportunity | opportunity |
| OpportunityContactRole | connection |
| OpportunityLineItem | opportunityproduct |
| Order | salesorder |
| OrderItem | salesorderdetail |
| Quote | quote |
| QuoteLineItem | quotedetail |
| Product2 | product |
| Pricebook2 | pricelevel |
| PricebookEntry | productpricelevel |
| Task | task |
| Event | activitypointer |
| EmailMessage | email |
| Note | annotation |
| ContentDocument | annotation, including supported file content |
| Attachment | annotation or activitymimeattachment, depending on its parent |
| Conversation | msdyn_ocliveworkitem |
| Case | incident |
| CaseComment | annotation |
| Entitlement | entitlement |
| EntitlementContact | Dataverse entitlement-to-contact association |
| Knowledge article version objects | knowledgearticle | 

Some Salesforce objects require more than a direct object-to-table copy. Dynamics 365 Activate uses dedicated processing for activity participants, email and record attachments, case lifecycle status, knowledge article versions, entitlements, conversations, ownership, audit fields, and polymorphic relationships. Don’t replace these predefined mappings without understanding the associated migration behavior.  

Objects and fields that require new Dataverse schema use the solution publisher prefix configured for the project. The default prefix is `d365migr`.

## Naming conventions

The application uses the following naming conventions when it auto-generates mappings:

**Objects (tables):**

- Standard: `Account` → `account`
- Custom: `Custom_Object__c` → a generated Dataverse table that uses the configured publisher prefix

**Fields (columns):**

- Standard: `Name` → `name`
- Custom: `Custom_Field__c` → `d365migr_customfield` when you use the default prefix

The generator removes Salesforce custom suffixes such as `__c`, normalizes the logical name to lowercase, removes unsupported characters, and adds the configured publisher prefix. If generated names conflict, the application adds a numeric suffix or prompts you to select a different name.  
Review the publisher prefix before solution generation. Changing it can change the logical names proposed for new tables and columns.

## Data type conversions

When you need a new Dataverse column, the application suggests a compatible Dataverse data type based on the Salesforce field type and metadata. When you map to an existing column, the application also checks target type compatibility and whether the target column is writable.

Review generated types before deployment, especially for:

- Text length and multiline text.
- Numeric precision and scale.
- Currency and percentage values.
- Date and time behavior.
- Lookup target compatibility.
- Restricted, dependent, and multiselect picklists.
- Formula, rollup-summary, auto-number, compound address, and polymorphic lookup fields.

A proposed type match doesn't guarantee that every source value can be written without transformation.

| Salesforce type | Dynamics 365 type |
|---|---|
| Text / String | Single line of text - Plain text  |
| TextArea | Multiple lines of text - Plain text |
| LongTextArea | Multiple lines of text |
| Email | Single line of text - Email |
| Phone | Single line of text - Phone number |
| URL | Single line of text -URL |
| Picklist | Choice |
| MultiSelectPicklist | Multi-select Choice |
| Checkbox | Yes/No |
| Number | Whole number or Decimal |
| Currency | Currency |
| Date | Date only |
| DateTime | Date and time |
| Lookup | Lookup |
| MasterDetail | Lookup |
| Formula | Formula |
| Rollup | Not migrated (review required) |

> [!IMPORTANT]
> Formula and rollup fields require manual review. The application flags these fields for attention, as they might need to be recreated as Dynamics 365 calculated fields, rollup columns, or Power Automate flows.

## Validate mappings

Before deploying the solution, review the mapping readiness indicators and select **Preflight Check**.

The **Mapping** page identifies fields that are:

- Automatically mapped with high confidence.
- Proposed as new Dataverse columns.
- Low-confidence matches that need review.
- Explicitly ignored or out of scope.

Use the match-review panel to approve, reject, or change low-confidence field matches. The workbench prevents a target column from being assigned to multiple active source fields within the same object.

The preflight check verifies conditions such as:

- Availability of discovered Salesforce objects.
- Access to saved Dataverse discovery metadata.
- Formula and rollup-summary fields without a selected migration strategy.
- Source fields mapped to read-only Dataverse calculated or rollup columns.

Resolve failed checks before proceeding. Review warnings carefully; some warnings don’t block solution generation but can cause fields to be skipped or migration behavior to differ from the intended design.

## Configure advanced mapping behavior

Depending on the selected object and field, Dynamics 365 Activate provides additional mapping controls.

- **Review low-confidence matches**: Generated mappings can use exact or fuzzy matching against existing Dataverse columns. Fields below the confidence threshold appear under *Needs Review*. Approve the proposed match, select an alternative target, create a new column, or exclude the field.  
- **Configure record filters**: Use the object’s *Record Filter* settings to restrict which Salesforce records are migrated. Build conditions in the criteria editor or provide a supported SOQL  `WHERE`  clause. The filter is saved for that table and applied during migration.  
- **Configure field transformations**: For supported fields, define cleansing and transformation rules that run before values are written to Dataverse. Available operations depend on the source and target data types and can include text cleanup, casing, replacement, default handling, and other transformations.  
- **Map choices and record types**: Review Salesforce picklist values, global value sets, dependent picklists, and record-type-specific values. Map them to existing Dataverse choices or include new choices in the generated solution.  
- **Reuse mappings**: Use mapping templates and the *Reuse Hub* to apply previously reviewed mappings to another run or project. Always review reused mappings against the current Salesforce metadata and target Dataverse environment before deployment.  
- **Review relationships and specialized mappings**: Relationship fields might be implemented as native Dataverse lookups, polymorphic lookups, associations, activity parties, or dedicated post-load processing. Review predefined relationship mappings before overriding them, because replacing a native mapping with a text column can prevent the relationship from being recreated.

## Load mappings

If you need to reload saved mappings (for example, after a session refresh):

On the **Mapping** tab, select **Load Mappings**.

Select **Load Mappings** to reload the mappings saved for the selected discovery run. Mapping changes persist as you work; loading mappings refreshes the workbench from the saved configuration rather than creating a new mapping set.

## Related information

- [Connect to Salesforce and run discovery](migrate-salesforce-to-dynamics-365-connect-salesforce.md)
- [Connect to Dynamics 365 and run discovery](migrate-salesforce-to-dynamics-365-connect-dynamics.md)
- [Map Salesforce objects and fields to Dynamics 365](migrate-salesforce-to-dynamics-365-object-mapping.md)
- [Map Salesforce users to Dynamics 365 users](migrate-salesforce-to-dynamics-365-user-mapping.md)
- [Solution deployment](migrate-salesforce-to-dynamics-365-solution-deployment.md)
- [Migration and verification](migrate-salesforce-to-dynamics-365-migration-verification.md)
