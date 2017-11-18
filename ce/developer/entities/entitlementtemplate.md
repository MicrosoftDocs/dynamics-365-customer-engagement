---
title: "EntitlementTemplate Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the EntitlementTemplate entity."
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
# EntitlementTemplate Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Contains predefined customer support terms that can be used to created entitlements for customers.

**Added by**: Service Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/entitlementtemplates<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/entitlementtemplates(*entitlementtemplateid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/entitlementtemplates(*entitlementtemplateid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/entitlementtemplates<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|Update|PATCH [*org URI*]/api/data/v9.0/entitlementtemplates(*entitlementtemplateid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Entitlement Template<br />
**DisplayCollectionName**: Entitlement Templates<br />
**SchemaName**: EntitlementTemplate<br />
**CollectionSchemaName**: EntitlementTemplates<br />
**LogicalName**: entitlementtemplate<br />
**LogicalCollectionName**: entitlementtemplates<br />
**EntitySetName**: entitlementtemplates<br />
**PrimaryIdAttribute**: entitlementtemplateid<br />
**PrimaryNameAttribute**: name<br />
**OwnershipType**: OrganizationOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [AllocationTypeCode](#BKMK_AllocationTypeCode)
- [DecreaseRemainingOn](#BKMK_DecreaseRemainingOn)
- [Description](#BKMK_Description)
- [EndDate](#BKMK_EndDate)
- [EntitlementTemplateId](#BKMK_EntitlementTemplateId)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [KbAccessLevel](#BKMK_KbAccessLevel)
- [Name](#BKMK_Name)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [RestrictCaseCreation](#BKMK_RestrictCaseCreation)
- [SLAId](#BKMK_SLAId)
- [StartDate](#BKMK_StartDate)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TotalTerms](#BKMK_TotalTerms)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


### <a name="BKMK_AllocationTypeCode"></a> AllocationTypeCode

**Description**: Select whether the entitlement allocation is based on number of cases or number of hours.<br />
**DisplayName**: Allocation Type<br />
**LogicalName**: allocationtypecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 0 **Label**: Number of cases
- **Value**: 1 **Label**: Number of hours



### <a name="BKMK_DecreaseRemainingOn"></a> DecreaseRemainingOn

**Description**: Information about whether to decrease the remaining terms when the case is created or when it is resolved<br />
**DisplayName**: Decrease Remaining On<br />
**LogicalName**: decreaseremainingon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 0 **Label**: Case Resolution
- **Value**: 1 **Label**: Case Creation



### <a name="BKMK_Description"></a> Description

**Description**: Type additional information to describe the account, such as an excerpt from the company's website.<br />
**DisplayName**: Description<br />
**LogicalName**: description<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: TextArea<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


### <a name="BKMK_EndDate"></a> EndDate

**Description**: Enter the date and time when the entitlement ends.<br />
**DisplayName**: End Date<br />
**LogicalName**: enddate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_EntitlementTemplateId"></a> EntitlementTemplateId

**Description**: Unique identifier for entity instances<br />
**DisplayName**: Entitlement Template<br />
**LogicalName**: entitlementtemplateid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


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


### <a name="BKMK_KbAccessLevel"></a> KbAccessLevel

**Description**: Select the access someone will have to the knowledge base on the portal.<br />
**DisplayName**: KB Access Level<br />
**LogicalName**: kbaccesslevel<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 0 **Label**: Standard
- **Value**: 1 **Label**: Premium
- **Value**: 2 **Label**: None



### <a name="BKMK_Name"></a> Name

**Description**: Type a descriptive name for the entitlement template.<br />
**DisplayName**: Entitlement Template Name<br />
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


### <a name="BKMK_RestrictCaseCreation"></a> RestrictCaseCreation

**Description**: Tells whether case creation is restricted based on entitlement terms.<br />
**DisplayName**: Restrict By Entitlement Terms<br />
**LogicalName**: restrictcasecreation<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_SLAId"></a> SLAId

**Description**: Choose the service level agreement (SLA) associated with the entitlement.<br />
**DisplayName**: SLA<br />
**LogicalName**: slaid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: sla


### <a name="BKMK_StartDate"></a> StartDate

**Description**: Enter the date and time when the entitlement begins.<br />
**DisplayName**: Start Date<br />
**LogicalName**: startdate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


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
**MinValue**: -1


### <a name="BKMK_TotalTerms"></a> TotalTerms

**Description**: Type the total number of entitlement terms.<br />
**DisplayName**: Total Terms<br />
**LogicalName**: totalterms<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Decimal<br />
**MaxValue**: 100000000000<br />
**MinValue**: 0<br />
**Precision**: 2


### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

**Description**: Unique identifier of the currency associated with the contact.<br />
**DisplayName**: Currency<br />
**LogicalName**: transactioncurrencyid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: transactioncurrency


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
**MinValue**: -1

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
- [SLAIdName](#BKMK_SLAIdName)
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_CreatedBy"></a> CreatedBy

**Description**: Unique identifier of the user who created the record.<br />
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

**Description**: Unique identifier of the delegate user who created the record.<br />
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


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

**Description**: Exchange rate for the currency associated with the contact with respect to the base currency.<br />
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

**Description**: Unique identifier of the user who modified the record.<br />
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

**Description**: Unique identifier of the delegate user who modified the record.<br />
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


### <a name="BKMK_SLAIdName"></a> SLAIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: slaidname<br />
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

- [entitlementtemplate_ActivityPointers](#BKMK_entitlementtemplate_ActivityPointers)
- [EntitlementTemplate_SyncErrors](#BKMK_EntitlementTemplate_SyncErrors)
- [entitlementtemplate_AsyncOperations](#BKMK_entitlementtemplate_AsyncOperations)
- [EntitlementTemplate_MailboxTrackingFolder](#BKMK_EntitlementTemplate_MailboxTrackingFolder)
- [entitlementtemplate_UserEntityInstanceDatas](#BKMK_entitlementtemplate_UserEntityInstanceDatas)
- [entitlementtemplate_ProcessSession](#BKMK_entitlementtemplate_ProcessSession)
- [entitlementtemplate_BulkDeleteFailures](#BKMK_entitlementtemplate_BulkDeleteFailures)
- [entitlementtemplate_PrincipalObjectAttributeAccesses](#BKMK_entitlementtemplate_PrincipalObjectAttributeAccesses)
- [entitlementtemplate_Appointments](#BKMK_entitlementtemplate_Appointments)
- [entitlementtemplate_Emails](#BKMK_entitlementtemplate_Emails)
- [entitlementtemplate_Faxes](#BKMK_entitlementtemplate_Faxes)
- [entitlementtemplate_Letters](#BKMK_entitlementtemplate_Letters)
- [entitlementtemplate_PhoneCalls](#BKMK_entitlementtemplate_PhoneCalls)
- [entitlementtemplate_Tasks](#BKMK_entitlementtemplate_Tasks)
- [entitlementtemplate_RecurringAppointmentMasters](#BKMK_entitlementtemplate_RecurringAppointmentMasters)
- [entitlementtemplate_SocialActivities](#BKMK_entitlementtemplate_SocialActivities)
- [entitlementtemplate_Annotations](#BKMK_entitlementtemplate_Annotations)
- [entitlementtemplate_IncidentResolutions](#BKMK_entitlementtemplate_IncidentResolutions)
- [entitlementtemplate_ServiceAppointments](#BKMK_entitlementtemplate_ServiceAppointments)
- [entitlementtemplateid_RelationShip](#BKMK_entitlementtemplateid_RelationShip)
- [entitlementtemplate_entitlementchannel_entitlementtemplateid](#BKMK_entitlementtemplate_entitlementchannel_entitlementtemplateid)
- [entitlementtemplate_DuplicateMatchingRecord](#BKMK_entitlementtemplate_DuplicateMatchingRecord)
- [entitlementtemplate_DuplicateBaseRecord](#BKMK_entitlementtemplate_DuplicateBaseRecord)
- [entitlementtemplate_OpportunityCloses](#BKMK_entitlementtemplate_OpportunityCloses)
- [entitlementtemplate_OrderCloses](#BKMK_entitlementtemplate_OrderCloses)
- [entitlementtemplate_QuoteCloses](#BKMK_entitlementtemplate_QuoteCloses)
- [entitlementtemplate_msdyn_bookingalerts](#BKMK_entitlementtemplate_msdyn_bookingalerts)
- [entitlementtemplate_msdyn_approvals](#BKMK_entitlementtemplate_msdyn_approvals)


### <a name="BKMK_entitlementtemplate_ActivityPointers"></a> entitlementtemplate_ActivityPointers

Same as activitypointer entity [entitlementtemplate_ActivityPointers](activitypointer.md#BKMK_entitlementtemplate_ActivityPointers) Many-To-One relationship.

**ReferencingEntity**: activitypointer<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: entitlementtemplate_ActivityPointers<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_EntitlementTemplate_SyncErrors"></a> EntitlementTemplate_SyncErrors

Same as syncerror entity [EntitlementTemplate_SyncErrors](syncerror.md#BKMK_EntitlementTemplate_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: EntitlementTemplate_SyncErrors<br />
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


### <a name="BKMK_entitlementtemplate_AsyncOperations"></a> entitlementtemplate_AsyncOperations

Same as asyncoperation entity [entitlementtemplate_AsyncOperations](asyncoperation.md#BKMK_entitlementtemplate_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: entitlementtemplate_AsyncOperations<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
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


### <a name="BKMK_EntitlementTemplate_MailboxTrackingFolder"></a> EntitlementTemplate_MailboxTrackingFolder

Same as mailboxtrackingfolder entity [EntitlementTemplate_MailboxTrackingFolder](mailboxtrackingfolder.md#BKMK_EntitlementTemplate_MailboxTrackingFolder) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: EntitlementTemplate_MailboxTrackingFolder<br />
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


### <a name="BKMK_entitlementtemplate_UserEntityInstanceDatas"></a> entitlementtemplate_UserEntityInstanceDatas

Same as userentityinstancedata entity [entitlementtemplate_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_entitlementtemplate_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: entitlementtemplate_UserEntityInstanceDatas<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
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


### <a name="BKMK_entitlementtemplate_ProcessSession"></a> entitlementtemplate_ProcessSession

Same as processsession entity [entitlementtemplate_ProcessSession](processsession.md#BKMK_entitlementtemplate_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: entitlementtemplate_ProcessSession<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
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


### <a name="BKMK_entitlementtemplate_BulkDeleteFailures"></a> entitlementtemplate_BulkDeleteFailures

Same as bulkdeletefailure entity [entitlementtemplate_BulkDeleteFailures](bulkdeletefailure.md#BKMK_entitlementtemplate_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: entitlementtemplate_BulkDeleteFailures<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
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


### <a name="BKMK_entitlementtemplate_PrincipalObjectAttributeAccesses"></a> entitlementtemplate_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [entitlementtemplate_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_entitlementtemplate_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: entitlementtemplate_PrincipalObjectAttributeAccesses<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
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


### <a name="BKMK_entitlementtemplate_Appointments"></a> entitlementtemplate_Appointments

Same as appointment entity [entitlementtemplate_Appointments](appointment.md#BKMK_entitlementtemplate_Appointments) Many-To-One relationship.

**ReferencingEntity**: appointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: entitlementtemplate_Appointments<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_entitlementtemplate_Emails"></a> entitlementtemplate_Emails

Same as email entity [entitlementtemplate_Emails](email.md#BKMK_entitlementtemplate_Emails) Many-To-One relationship.

**ReferencingEntity**: email<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: entitlementtemplate_Emails<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_entitlementtemplate_Faxes"></a> entitlementtemplate_Faxes

Same as fax entity [entitlementtemplate_Faxes](fax.md#BKMK_entitlementtemplate_Faxes) Many-To-One relationship.

**ReferencingEntity**: fax<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: entitlementtemplate_Faxes<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_entitlementtemplate_Letters"></a> entitlementtemplate_Letters

Same as letter entity [entitlementtemplate_Letters](letter.md#BKMK_entitlementtemplate_Letters) Many-To-One relationship.

**ReferencingEntity**: letter<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: entitlementtemplate_Letters<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_entitlementtemplate_PhoneCalls"></a> entitlementtemplate_PhoneCalls

Same as phonecall entity [entitlementtemplate_PhoneCalls](phonecall.md#BKMK_entitlementtemplate_PhoneCalls) Many-To-One relationship.

**ReferencingEntity**: phonecall<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: entitlementtemplate_PhoneCalls<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_entitlementtemplate_Tasks"></a> entitlementtemplate_Tasks

Same as task entity [entitlementtemplate_Tasks](task.md#BKMK_entitlementtemplate_Tasks) Many-To-One relationship.

**ReferencingEntity**: task<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: entitlementtemplate_Tasks<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_entitlementtemplate_RecurringAppointmentMasters"></a> entitlementtemplate_RecurringAppointmentMasters

Same as recurringappointmentmaster entity [entitlementtemplate_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_entitlementtemplate_RecurringAppointmentMasters) Many-To-One relationship.

**ReferencingEntity**: recurringappointmentmaster<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: entitlementtemplate_RecurringAppointmentMasters<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_entitlementtemplate_SocialActivities"></a> entitlementtemplate_SocialActivities

Same as socialactivity entity [entitlementtemplate_SocialActivities](socialactivity.md#BKMK_entitlementtemplate_SocialActivities) Many-To-One relationship.

**ReferencingEntity**: socialactivity<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: entitlementtemplate_SocialActivities<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_entitlementtemplate_Annotations"></a> entitlementtemplate_Annotations

Same as annotation entity [entitlementtemplate_Annotations](annotation.md#BKMK_entitlementtemplate_Annotations) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: entitlementtemplate_Annotations<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_entitlementtemplate_IncidentResolutions"></a> entitlementtemplate_IncidentResolutions

Same as incidentresolution entity [entitlementtemplate_IncidentResolutions](incidentresolution.md#BKMK_entitlementtemplate_IncidentResolutions) Many-To-One relationship.

**ReferencingEntity**: incidentresolution<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: entitlementtemplate_IncidentResolutions<br />
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


### <a name="BKMK_entitlementtemplate_ServiceAppointments"></a> entitlementtemplate_ServiceAppointments

Same as serviceappointment entity [entitlementtemplate_ServiceAppointments](serviceappointment.md#BKMK_entitlementtemplate_ServiceAppointments) Many-To-One relationship.

**ReferencingEntity**: serviceappointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: entitlementtemplate_ServiceAppointments<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_entitlementtemplateid_RelationShip"></a> entitlementtemplateid_RelationShip

Same as entitlement entity [entitlementtemplateid_RelationShip](entitlement.md#BKMK_entitlementtemplateid_RelationShip) Many-To-One relationship.

**ReferencingEntity**: entitlement<br />
**ReferencingAttribute**: entitlementtemplateid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: entitlementtemplateid_RelationShip<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_entitlementtemplate_entitlementchannel_entitlementtemplateid"></a> entitlementtemplate_entitlementchannel_entitlementtemplateid

Same as entitlementtemplatechannel entity [entitlementtemplate_entitlementchannel_entitlementtemplateid](entitlementtemplatechannel.md#BKMK_entitlementtemplate_entitlementchannel_entitlementtemplateid) Many-To-One relationship.

**ReferencingEntity**: entitlementtemplatechannel<br />
**ReferencingAttribute**: entitlementtemplateid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: entitlementtemplate_entitlementchannel_entitlementtemplateid<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_entitlementtemplate_DuplicateMatchingRecord"></a> entitlementtemplate_DuplicateMatchingRecord

Same as duplicaterecord entity [entitlementtemplate_DuplicateMatchingRecord](duplicaterecord.md#BKMK_entitlementtemplate_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: entitlementtemplate_DuplicateMatchingRecord<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
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


### <a name="BKMK_entitlementtemplate_DuplicateBaseRecord"></a> entitlementtemplate_DuplicateBaseRecord

Same as duplicaterecord entity [entitlementtemplate_DuplicateBaseRecord](duplicaterecord.md#BKMK_entitlementtemplate_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: entitlementtemplate_DuplicateBaseRecord<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
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


### <a name="BKMK_entitlementtemplate_OpportunityCloses"></a> entitlementtemplate_OpportunityCloses

Same as opportunityclose entity [entitlementtemplate_OpportunityCloses](opportunityclose.md#BKMK_entitlementtemplate_OpportunityCloses) Many-To-One relationship.

**ReferencingEntity**: opportunityclose<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: entitlementtemplate_OpportunityCloses<br />
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


### <a name="BKMK_entitlementtemplate_OrderCloses"></a> entitlementtemplate_OrderCloses

Same as orderclose entity [entitlementtemplate_OrderCloses](orderclose.md#BKMK_entitlementtemplate_OrderCloses) Many-To-One relationship.

**ReferencingEntity**: orderclose<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: entitlementtemplate_OrderCloses<br />
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


### <a name="BKMK_entitlementtemplate_QuoteCloses"></a> entitlementtemplate_QuoteCloses

Same as quoteclose entity [entitlementtemplate_QuoteCloses](quoteclose.md#BKMK_entitlementtemplate_QuoteCloses) Many-To-One relationship.

**ReferencingEntity**: quoteclose<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: entitlementtemplate_QuoteCloses<br />
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


### <a name="BKMK_entitlementtemplate_msdyn_bookingalerts"></a> entitlementtemplate_msdyn_bookingalerts

Same as msdyn_bookingalert entity [entitlementtemplate_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_entitlementtemplate_msdyn_bookingalerts) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingalert<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: entitlementtemplate_msdyn_bookingalerts<br />
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


### <a name="BKMK_entitlementtemplate_msdyn_approvals"></a> entitlementtemplate_msdyn_approvals

Same as msdyn_approval entity [entitlementtemplate_msdyn_approvals](msdyn_approval.md#BKMK_entitlementtemplate_msdyn_approvals) Many-To-One relationship.

**ReferencingEntity**: msdyn_approval<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: entitlementtemplate_msdyn_approvals<br />
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

- [lk_entitlementtemplate_createdby](#BKMK_lk_entitlementtemplate_createdby)
- [lk_entitlementtemplate_createdonbehalfby](#BKMK_lk_entitlementtemplate_createdonbehalfby)
- [lk_entitlementtemplate_modifiedby](#BKMK_lk_entitlementtemplate_modifiedby)
- [lk_entitlementtemplate_modifiedonbehalfby](#BKMK_lk_entitlementtemplate_modifiedonbehalfby)
- [entitlementtemplate_organization](#BKMK_entitlementtemplate_organization)
- [sla_entitlementtemplate](#BKMK_sla_entitlementtemplate)
- [TransactionCurrency_entitlementtemplate](#BKMK_TransactionCurrency_entitlementtemplate)


### <a name="BKMK_lk_entitlementtemplate_createdby"></a> lk_entitlementtemplate_createdby

See systemuser Entity [lk_entitlementtemplate_createdby](systemuser.md#BKMK_lk_entitlementtemplate_createdby) One-To-Many relationship.

### <a name="BKMK_lk_entitlementtemplate_createdonbehalfby"></a> lk_entitlementtemplate_createdonbehalfby

See systemuser Entity [lk_entitlementtemplate_createdonbehalfby](systemuser.md#BKMK_lk_entitlementtemplate_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_entitlementtemplate_modifiedby"></a> lk_entitlementtemplate_modifiedby

See systemuser Entity [lk_entitlementtemplate_modifiedby](systemuser.md#BKMK_lk_entitlementtemplate_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_entitlementtemplate_modifiedonbehalfby"></a> lk_entitlementtemplate_modifiedonbehalfby

See systemuser Entity [lk_entitlementtemplate_modifiedonbehalfby](systemuser.md#BKMK_lk_entitlementtemplate_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_entitlementtemplate_organization"></a> entitlementtemplate_organization

See organization Entity [entitlementtemplate_organization](organization.md#BKMK_entitlementtemplate_organization) One-To-Many relationship.

### <a name="BKMK_sla_entitlementtemplate"></a> sla_entitlementtemplate

See sla Entity [sla_entitlementtemplate](sla.md#BKMK_sla_entitlementtemplate) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_entitlementtemplate"></a> TransactionCurrency_entitlementtemplate

See transactioncurrency Entity [TransactionCurrency_entitlementtemplate](transactioncurrency.md#BKMK_TransactionCurrency_entitlementtemplate) One-To-Many relationship.
<a name="manytomany"></a>

## Many-To-Many Relationships

Relationship details provided where the EntitlementTemplate entity is the first entity in the relationship. Listed by **SchemaName**.


### <a name="BKMK_product_entitlementtemplate_association"></a> product_entitlementtemplate_association

See product Entity [product_entitlementtemplate_association](product.md#BKMK_product_entitlementtemplate_association) Many-To-Many Relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.entitlementtemplate?text=entitlementtemplate EntityType" />