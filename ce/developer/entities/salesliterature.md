---
title: "SalesLiterature Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the SalesLiterature entity."
ms.date: 10/31/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# SalesLiterature Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Storage of sales literature, which may contain one or more documents.

**Added by**: Sales Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Associate|[Associate and disassociate entities](../webapi/associate-disassociate-entities-using-web-api.md) |<xref:Microsoft.Xrm.Sdk.Messages.AssociateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Associate*>|
|Create|POST [*org URI*]/api/data/v9.0/salesliteratures<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/salesliteratures(*salesliteratureid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Disassociate|[Associate and disassociate entities](../webapi/associate-disassociate-entities-using-web-api.md) |<xref:Microsoft.Xrm.Sdk.Messages.DisassociateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Disassociate*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/salesliteratures(*salesliteratureid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/salesliteratures<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|Update|PATCH [*org URI*]/api/data/v9.0/salesliteratures(*salesliteratureid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

**DisplayName**: Sales Literature<br />
**DisplayCollectionName**: Sales Literature<br />
**SchemaName**: SalesLiterature<br />
**CollectionSchemaName**: SalesLiteratures<br />
**LogicalName**: salesliterature<br />
**LogicalCollectionName**: salesliteratures<br />
**EntitySetName**: salesliteratures<br />
**PrimaryIdAttribute**: salesliteratureid<br />
**PrimaryNameAttribute**: name<br />
**OwnershipType**: OrganizationOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [Description](#BKMK_Description)
- [EmployeeContactId](#BKMK_EmployeeContactId)
- [EntityImage](#BKMK_EntityImage)
- [ExpirationDate](#BKMK_ExpirationDate)
- [HasAttachments](#BKMK_HasAttachments)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsCustomerViewable](#BKMK_IsCustomerViewable)
- [KeyWords](#BKMK_KeyWords)
- [LiteratureTypeCode](#BKMK_LiteratureTypeCode)
- [Name](#BKMK_Name)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [ProcessId](#BKMK_ProcessId)
- [SalesLiteratureId](#BKMK_SalesLiteratureId)
- [StageId](#BKMK_StageId)
- [SubjectId](#BKMK_SubjectId)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [TraversedPath](#BKMK_TraversedPath)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


### <a name="BKMK_Description"></a> Description

**Description**: Type additional information to describe the sales literature, such as the intended audience or primary messages.<br />
**DisplayName**: Description<br />
**LogicalName**: description<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


### <a name="BKMK_EmployeeContactId"></a> EmployeeContactId

**Description**: Choose the user who is responsible for maintaining or updating the sales literature.<br />
**DisplayName**: Employee Contact<br />
**LogicalName**: employeecontactid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_EntityImage"></a> EntityImage

**Description**: The default image for the entity.<br />
**DisplayName**: Entity Image<br />
**LogicalName**: entityimage<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Image<br />
**IsPrimaryImage**: False<br />
**MaxHeight**: 144<br />
**MaxWidth**: 144


### <a name="BKMK_ExpirationDate"></a> ExpirationDate

**Description**: Enter the expiration date or last day the sales literature can be distributed.<br />
**DisplayName**: Expiration Date<br />
**LogicalName**: expirationdate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_HasAttachments"></a> HasAttachments

**Description**: Tells whether the sales literature has one or more attachments.<br />
**DisplayName**: Has Attachments<br />
**LogicalName**: hasattachments<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

**Description**: Sequence number of the import that created this record.<br />
**DisplayName**: Import Sequence Number<br />
**LogicalName**: importsequencenumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_IsCustomerViewable"></a> IsCustomerViewable

**Description**: Select whether the sales literature can be distributed to prospects and customers or is for internal use only.<br />
**DisplayName**: Customer Viewable<br />
**LogicalName**: iscustomerviewable<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_KeyWords"></a> KeyWords

**Description**: Type one or more topics or keywords that can be used to search for the sales literature.<br />
**DisplayName**: Key Words<br />
**LogicalName**: keywords<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100000


### <a name="BKMK_LiteratureTypeCode"></a> LiteratureTypeCode

**Description**: Select a category or type to help others identify the intended use of the sales literature.<br />
**DisplayName**: Type<br />
**LogicalName**: literaturetypecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 0 **Label**: Presentation
- **Value**: 1 **Label**: Product Sheet
- **Value**: 2 **Label**: Policies And Procedures
- **Value**: 3 **Label**: Sales Literature
- **Value**: 4 **Label**: Spreadsheets
- **Value**: 5 **Label**: News
- **Value**: 6 **Label**: Bulletins
- **Value**: 7 **Label**: Price Sheets
- **Value**: 8 **Label**: Manuals
- **Value**: 9 **Label**: Company Background
- **Value**: 100001 **Label**: Marketing Collateral



### <a name="BKMK_Name"></a> Name

**Description**: Type a descriptive title for the sales literature.<br />
**DisplayName**: Title<br />
**LogicalName**: name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

**Description**: Date and time that the record was migrated.<br />
**DisplayName**: Record Created On<br />
**LogicalName**: overriddencreatedon<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_ProcessId"></a> ProcessId

**Description**: Contains the id of the process associated with the entity.<br />
**DisplayName**: Process Id<br />
**LogicalName**: processid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_SalesLiteratureId"></a> SalesLiteratureId

**Description**: Unique identifier of the sales literature.<br />
**DisplayName**: Sales Literature<br />
**LogicalName**: salesliteratureid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_StageId"></a> StageId

**Description**: Contains the id of the stage where the entity is located.<br />
**DisplayName**: Stage Id<br />
**LogicalName**: stageid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_SubjectId"></a> SubjectId

**Description**: Choose the subject for the sales literature to relate the item to a product or business group. Administrators can configure subjects under Business Management in the Settings area.<br />
**DisplayName**: Subject<br />
**LogicalName**: subjectid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: subject


### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

**Description**: For internal use only.<br />
**DisplayName**: Time Zone Rule Version Number<br />
**LogicalName**: timezoneruleversionnumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

**Description**: Choose the local currency for the record to make sure budgets are reported in the correct currency.<br />
**DisplayName**: Currency<br />
**LogicalName**: transactioncurrencyid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: transactioncurrency


### <a name="BKMK_TraversedPath"></a> TraversedPath

**Description**: A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.<br />
**DisplayName**: Traversed Path<br />
**LogicalName**: traversedpath<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 1250


### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

**Description**: Time zone code that was in use when the record was created.<br />
**DisplayName**: UTC Conversion Time Zone Code<br />
**LogicalName**: utcconversiontimezonecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [EmployeeContactIdName](#BKMK_EmployeeContactIdName)
- [EmployeeContactIdYomiName](#BKMK_EmployeeContactIdYomiName)
- [EntityImage_Timestamp](#BKMK_EntityImage_Timestamp)
- [EntityImage_URL](#BKMK_EntityImage_URL)
- [EntityImageId](#BKMK_EntityImageId)
- [ExchangeRate](#BKMK_ExchangeRate)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [OrganizationId](#BKMK_OrganizationId)
- [OrganizationIdName](#BKMK_OrganizationIdName)
- [SubjectIdName](#BKMK_SubjectIdName)
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_CreatedBy"></a> CreatedBy

**Description**: Shows who created the record.<br />
**DisplayName**: Created By<br />
**LogicalName**: createdby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_CreatedByName"></a> CreatedByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedByYomiName"></a> CreatedByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedOn"></a> CreatedOn

**Description**: Date and time when the record was created.<br />
**DisplayName**: Created On<br />
**LogicalName**: createdon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

**Description**: Shows who created the record on behalf of another user.<br />
**DisplayName**: Created By (Delegate)<br />
**LogicalName**: createdonbehalfby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_CreatedOnBehalfByName"></a> CreatedOnBehalfByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdonbehalfbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedOnBehalfByYomiName"></a> CreatedOnBehalfByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdonbehalfbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_EmployeeContactIdName"></a> EmployeeContactIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: employeecontactidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_EmployeeContactIdYomiName"></a> EmployeeContactIdYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: employeecontactidyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_EntityImage_Timestamp"></a> EntityImage_Timestamp

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: entityimage_timestamp<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: BigInt<br />
**MaxValue**: 9223372036854775807<br />
**MinValue**: -9223372036854775808<br />


### <a name="BKMK_EntityImage_URL"></a> EntityImage_URL

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: entityimage_url<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Url<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_EntityImageId"></a> EntityImageId

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: entityimageid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

**Description**: Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.<br />
**DisplayName**: Exchange Rate<br />
**LogicalName**: exchangerate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Decimal<br />
**MaxValue**: 100000000000<br />
**MinValue**: 0.0000000001<br />
**Precision**: 10


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

**Description**: Shows who last updated the record.<br />
**DisplayName**: Modified By<br />
**LogicalName**: modifiedby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedByYomiName"></a> ModifiedByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

**Description**: Date and time when the record was modified.<br />
**DisplayName**: Modified On<br />
**LogicalName**: modifiedon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Description**: Shows who last updated the record on behalf of another user.<br />
**DisplayName**: Modified By (Delegate)<br />
**LogicalName**: modifiedonbehalfby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_ModifiedOnBehalfByName"></a> ModifiedOnBehalfByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedonbehalfbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedOnBehalfByYomiName"></a> ModifiedOnBehalfByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedonbehalfbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OrganizationId"></a> OrganizationId

**Description**: Unique identifier for the organization<br />
**DisplayName**: Organization Id<br />
**LogicalName**: organizationid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Lookup<br />
**Targets**: organization


### <a name="BKMK_OrganizationIdName"></a> OrganizationIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: organizationidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_SubjectIdName"></a> SubjectIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: subjectidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_TransactionCurrencyIdName"></a> TransactionCurrencyIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: transactioncurrencyidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_VersionNumber"></a> VersionNumber

**Description**: Version Number<br />
**DisplayName**: Version Number<br />
**LogicalName**: versionnumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: BigInt<br />
**MaxValue**: 9223372036854775807<br />
**MinValue**: -9223372036854775808<br />

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [SalesLiterature_SyncErrors](#BKMK_SalesLiterature_SyncErrors)
- [SalesLiterature_SharepointDocumentLocation](#BKMK_SalesLiterature_SharepointDocumentLocation)
- [SalesLiterature_SharepointDocument](#BKMK_SalesLiterature_SharepointDocument)
- [SalesLiterature_AsyncOperations](#BKMK_SalesLiterature_AsyncOperations)
- [salesliterature_MailboxTrackingFolders](#BKMK_salesliterature_MailboxTrackingFolders)
- [userentityinstancedata_salesliterature](#BKMK_userentityinstancedata_salesliterature)
- [SalesLiterature_ProcessSessions](#BKMK_SalesLiterature_ProcessSessions)
- [SalesLiterature_BulkDeleteFailures](#BKMK_SalesLiterature_BulkDeleteFailures)
- [salesliterature_principalobjectattributeaccess](#BKMK_salesliterature_principalobjectattributeaccess)
- [sales_literature_items](#BKMK_sales_literature_items)


### <a name="BKMK_SalesLiterature_SyncErrors"></a> SalesLiterature_SyncErrors

Same as syncerror entity [SalesLiterature_SyncErrors](syncerror.md#BKMK_SalesLiterature_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: SalesLiterature_SyncErrors<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_SalesLiterature_SharepointDocumentLocation"></a> SalesLiterature_SharepointDocumentLocation

Same as sharepointdocumentlocation entity [SalesLiterature_SharepointDocumentLocation](sharepointdocumentlocation.md#BKMK_SalesLiterature_SharepointDocumentLocation) Many-To-One relationship.

**ReferencingEntity**: sharepointdocumentlocation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: SalesLiterature_SharepointDocumentLocation<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_SalesLiterature_SharepointDocument"></a> SalesLiterature_SharepointDocument

Same as sharepointdocument entity [SalesLiterature_SharepointDocument](sharepointdocument.md#BKMK_SalesLiterature_SharepointDocument) Many-To-One relationship.

**ReferencingEntity**: sharepointdocument<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: SalesLiterature_SharepointDocument<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_SalesLiterature_AsyncOperations"></a> SalesLiterature_AsyncOperations

Same as asyncoperation entity [SalesLiterature_AsyncOperations](asyncoperation.md#BKMK_SalesLiterature_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: SalesLiterature_AsyncOperations<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_salesliterature_MailboxTrackingFolders"></a> salesliterature_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [salesliterature_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_salesliterature_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: salesliterature_MailboxTrackingFolders<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_userentityinstancedata_salesliterature"></a> userentityinstancedata_salesliterature

Same as userentityinstancedata entity [userentityinstancedata_salesliterature](userentityinstancedata.md#BKMK_userentityinstancedata_salesliterature) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: userentityinstancedata_salesliterature<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_SalesLiterature_ProcessSessions"></a> SalesLiterature_ProcessSessions

Same as processsession entity [SalesLiterature_ProcessSessions](processsession.md#BKMK_SalesLiterature_ProcessSessions) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: SalesLiterature_ProcessSessions<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 110

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_SalesLiterature_BulkDeleteFailures"></a> SalesLiterature_BulkDeleteFailures

Same as bulkdeletefailure entity [SalesLiterature_BulkDeleteFailures](bulkdeletefailure.md#BKMK_SalesLiterature_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: SalesLiterature_BulkDeleteFailures<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_salesliterature_principalobjectattributeaccess"></a> salesliterature_principalobjectattributeaccess

Same as principalobjectattributeaccess entity [salesliterature_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_salesliterature_principalobjectattributeaccess) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: salesliterature_principalobjectattributeaccess<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_sales_literature_items"></a> sales_literature_items

Same as salesliteratureitem entity [sales_literature_items](salesliteratureitem.md#BKMK_sales_literature_items) Many-To-One relationship.

**ReferencingEntity**: salesliteratureitem<br />
**ReferencingAttribute**: salesliteratureid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: sales_literature_items<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_salesliteraturebase_createdby](#BKMK_lk_salesliteraturebase_createdby)
- [lk_salesliterature_createdonbehalfby](#BKMK_lk_salesliterature_createdonbehalfby)
- [lk_salesliteraturebase_modifiedby](#BKMK_lk_salesliteraturebase_modifiedby)
- [lk_salesliterature_modifiedonbehalfby](#BKMK_lk_salesliterature_modifiedonbehalfby)
- [organization_sales_literature](#BKMK_organization_sales_literature)
- [processstage_salesliteratures](#BKMK_processstage_salesliteratures)
- [system_user_sales_literature](#BKMK_system_user_sales_literature)
- [TransactionCurrency_SalesLiterature](#BKMK_TransactionCurrency_SalesLiterature)
- [subject_sales_literature](#BKMK_subject_sales_literature)


### <a name="BKMK_lk_salesliteraturebase_createdby"></a> lk_salesliteraturebase_createdby

See systemuser Entity [lk_salesliteraturebase_createdby](systemuser.md#BKMK_lk_salesliteraturebase_createdby) One-To-Many relationship.

### <a name="BKMK_lk_salesliterature_createdonbehalfby"></a> lk_salesliterature_createdonbehalfby

See systemuser Entity [lk_salesliterature_createdonbehalfby](systemuser.md#BKMK_lk_salesliterature_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_salesliteraturebase_modifiedby"></a> lk_salesliteraturebase_modifiedby

See systemuser Entity [lk_salesliteraturebase_modifiedby](systemuser.md#BKMK_lk_salesliteraturebase_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_salesliterature_modifiedonbehalfby"></a> lk_salesliterature_modifiedonbehalfby

See systemuser Entity [lk_salesliterature_modifiedonbehalfby](systemuser.md#BKMK_lk_salesliterature_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_organization_sales_literature"></a> organization_sales_literature

See organization Entity [organization_sales_literature](organization.md#BKMK_organization_sales_literature) One-To-Many relationship.

### <a name="BKMK_processstage_salesliteratures"></a> processstage_salesliteratures

See processstage Entity [processstage_salesliteratures](processstage.md#BKMK_processstage_salesliteratures) One-To-Many relationship.

### <a name="BKMK_system_user_sales_literature"></a> system_user_sales_literature

See systemuser Entity [system_user_sales_literature](systemuser.md#BKMK_system_user_sales_literature) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_SalesLiterature"></a> TransactionCurrency_SalesLiterature

See transactioncurrency Entity [TransactionCurrency_SalesLiterature](transactioncurrency.md#BKMK_TransactionCurrency_SalesLiterature) One-To-Many relationship.

### <a name="BKMK_subject_sales_literature"></a> subject_sales_literature

See subject Entity [subject_sales_literature](subject.md#BKMK_subject_sales_literature) One-To-Many relationship.
<a name="manytomany"></a>

## Many-To-Many Relationships

Relationship details provided where the SalesLiterature entity is the first entity in the relationship. Listed by **SchemaName**.

- [productsalesliterature_association](#BKMK_productsalesliterature_association)
- [competitorsalesliterature_association](#BKMK_competitorsalesliterature_association)
- [campaignactivitysalesliterature_association](#BKMK_campaignactivitysalesliterature_association)
- [campaignsalesliterature_association](#BKMK_campaignsalesliterature_association)


### <a name="BKMK_productsalesliterature_association"></a> productsalesliterature_association

See product Entity [productsalesliterature_association](product.md#BKMK_productsalesliterature_association) Many-To-Many Relationship.

### <a name="BKMK_competitorsalesliterature_association"></a> competitorsalesliterature_association

**IntersectEntityName**: competitorsalesliterature<br />
**Entity1LogicalName**: salesliterature<br />

- **Entity1IntersectAttribute**: salesliteratureid
- **Entity1NavigationPropertyName**: competitorsalesliterature_association
- **Entity1AssociatedMenuConfiguration**:

  - **Behavior**: DoNotDisplay
  - **Group**: Details
  - **Label**: 
  - **Order**: 

**Entity2LogicalName**: [competitor](competitor.md)<br />

- **Entity2IntersectAttribute**: competitorid
- **Entity2NavigationPropertyName**: competitorsalesliterature_association
- **Entity2AssociatedMenuConfiguration**:

  - **Behavior**: DoNotDisplay
  - **Group**: Details
  - **Label**: 
  - **Order**: 

**IsCustomizable**: False<br />

### <a name="BKMK_campaignactivitysalesliterature_association"></a> campaignactivitysalesliterature_association

See campaignactivity Entity [campaignactivitysalesliterature_association](campaignactivity.md#BKMK_campaignactivitysalesliterature_association) Many-To-Many Relationship.

### <a name="BKMK_campaignsalesliterature_association"></a> campaignsalesliterature_association

See campaign Entity [campaignsalesliterature_association](campaign.md#BKMK_campaignsalesliterature_association) Many-To-Many Relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.salesliterature?text=salesliterature EntityType" />