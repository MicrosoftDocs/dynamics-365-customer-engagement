---
title: "EntitlementTemplate Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the EntitlementTemplate entity."
ms.date: 04/02/2019
ms.service: "crm-online"
ms.topic: "reference"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "KumarVivek"
ms.author: "kvivek"
manager: "annbe"
search.audienceType: 
  - developer

---
# EntitlementTemplate Entity Reference

Contains predefined customer support terms that can be used to created entitlements for customers.

**Added by**: Service Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/entitlementtemplates<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/entitlementtemplates(*entitlementtemplateid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/entitlementtemplates(*entitlementtemplateid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/entitlementtemplates<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|Update|PATCH [*org URI*]/api/data/v9.0/entitlementtemplates(*entitlementtemplateid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|EntitlementTemplates|
|DisplayCollectionName|Entitlement Templates|
|DisplayName|Entitlement Template|
|EntitySetName|entitlementtemplates|
|IsBPFEntity|False|
|LogicalCollectionName|entitlementtemplates|
|LogicalName|entitlementtemplate|
|OwnershipType|OrganizationOwned|
|PrimaryIdAttribute|entitlementtemplateid|
|PrimaryNameAttribute|name|
|SchemaName|EntitlementTemplate|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [AllocationTypeCode](#BKMK_AllocationTypeCode)
- [DecreaseRemainingOn](#BKMK_DecreaseRemainingOn)
- [Description](#BKMK_Description)
- [EndDate](#BKMK_EndDate)
- [EntitlementTemplateId](#BKMK_EntitlementTemplateId)
- [entitytype](#BKMK_entitytype)
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

|Property|Value|
|--------|-----|
|Description|Select whether the entitlement allocation is based on number of cases or number of hours.|
|DisplayName|Allocation Type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|allocationtypecode|
|RequiredLevel|None|
|Type|Picklist|

#### AllocationTypeCode Options

|Value|Label|
|-----|-----|
|0|Number of cases|
|1|Number of hours|



### <a name="BKMK_DecreaseRemainingOn"></a> DecreaseRemainingOn

|Property|Value|
|--------|-----|
|Description|Information about whether to decrease the remaining terms when the case is created or when it is resolved|
|DisplayName|Decrease Remaining On|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|decreaseremainingon|
|RequiredLevel|None|
|Type|Picklist|

#### DecreaseRemainingOn Options

|Value|Label|
|-----|-----|
|0|Case Resolution|
|1|Case Creation|



### <a name="BKMK_Description"></a> Description

|Property|Value|
|--------|-----|
|Description|Type additional information to describe the account, such as an excerpt from the company's website.|
|DisplayName|Description|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|description|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_EndDate"></a> EndDate

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the date and time when the entitlement ends.|
|DisplayName|End Date|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|enddate|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_EntitlementTemplateId"></a> EntitlementTemplateId

|Property|Value|
|--------|-----|
|Description|Unique identifier for entity instances|
|DisplayName|Entitlement Template|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|entitlementtemplateid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_entitytype"></a> entitytype

**Added by**: Service Patch Solution

|Property|Value|
|--------|-----|
|Description|Entity type for which the entitlement template applies|
|DisplayName|Entity Type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|entitytype|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|

#### entitytype Options

|Value|Label|
|-----|-----|
|0|Case|
|192350000|Work Order|



### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|--------|-----|
|Description|Sequence number of the import that created this record.|
|DisplayName|Import Sequence Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|importsequencenumber|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_KbAccessLevel"></a> KbAccessLevel

|Property|Value|
|--------|-----|
|Description|Select the access someone will have to the knowledge base on the portal.|
|DisplayName|KB Access Level|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|kbaccesslevel|
|RequiredLevel|None|
|Type|Picklist|

#### KbAccessLevel Options

|Value|Label|
|-----|-----|
|0|Standard|
|1|Premium|
|2|None|



### <a name="BKMK_Name"></a> Name

|Property|Value|
|--------|-----|
|Description|Type a descriptive name for the entitlement template.|
|DisplayName|Entitlement Template Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|name|
|MaxLength|100|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time that the record was migrated.|
|DisplayName|Record Created On|
|Format|DateOnly|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|overriddencreatedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_RestrictCaseCreation"></a> RestrictCaseCreation

|Property|Value|
|--------|-----|
|Description|Tells whether case creation is restricted based on entitlement terms.|
|DisplayName|Restrict By Entitlement Terms|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|restrictcasecreation|
|RequiredLevel|None|
|Type|Boolean|

#### RestrictCaseCreation Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_SLAId"></a> SLAId

|Property|Value|
|--------|-----|
|Description|Choose the service level agreement (SLA) associated with the entitlement.|
|DisplayName|SLA|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|slaid|
|RequiredLevel|None|
|Targets|sla|
|Type|Lookup|


### <a name="BKMK_StartDate"></a> StartDate

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the date and time when the entitlement begins.|
|DisplayName|Start Date|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|startdate|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Time Zone Rule Version Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|timezoneruleversionnumber|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_TotalTerms"></a> TotalTerms

|Property|Value|
|--------|-----|
|Description|Type the total number of entitlement terms.|
|DisplayName|Total Terms|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|totalterms|
|MaxValue|100000000000|
|MinValue|0|
|Precision|2|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the currency associated with the contact.|
|DisplayName|Currency|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|transactioncurrencyid|
|RequiredLevel|None|
|Targets|transactioncurrency|
|Type|Lookup|


### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

|Property|Value|
|--------|-----|
|Description|Time zone code that was in use when the record was created.|
|DisplayName|UTC Conversion Time Zone Code|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|utcconversiontimezonecode|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|

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

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who created the record.|
|DisplayName|Created By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedByName"></a> CreatedByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedByYomiName"></a> CreatedByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the record was created.|
|DisplayName|Created On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who created the record.|
|DisplayName|Created By (Delegate)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedOnBehalfByName"></a> CreatedOnBehalfByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdonbehalfbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedOnBehalfByYomiName"></a> CreatedOnBehalfByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdonbehalfbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

|Property|Value|
|--------|-----|
|Description|Exchange rate for the currency associated with the contact with respect to the base currency.|
|DisplayName|Exchange Rate|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|exchangerate|
|MaxValue|100000000000|
|MinValue|0.0000000001|
|Precision|10|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who modified the record.|
|DisplayName|Modified By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedByYomiName"></a> ModifiedByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the record was modified.|
|DisplayName|Modified On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who modified the record.|
|DisplayName|Modified By (Delegate)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedOnBehalfByName"></a> ModifiedOnBehalfByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedOnBehalfByYomiName"></a> ModifiedOnBehalfByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|--------|-----|
|Description|Unique identifier for the organization|
|DisplayName|Organization Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|organizationid|
|RequiredLevel|SystemRequired|
|Targets|organization|
|Type|Lookup|


### <a name="BKMK_OrganizationIdName"></a> OrganizationIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|organizationidname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_SLAIdName"></a> SLAIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|slaidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_TransactionCurrencyIdName"></a> TransactionCurrencyIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|transactioncurrencyidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|--------|-----|
|Description|Version Number|
|DisplayName|Version Number|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|versionnumber|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|
|RequiredLevel|None|
|Type|BigInt|

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [entitlementtemplate_ActivityPointers](#BKMK_entitlementtemplate_ActivityPointers)
- [EntitlementTemplate_SyncErrors](#BKMK_EntitlementTemplate_SyncErrors)
- [entitlementtemplate_AsyncOperations](#BKMK_entitlementtemplate_AsyncOperations)
- [EntitlementTemplate_MailboxTrackingFolder](#BKMK_EntitlementTemplate_MailboxTrackingFolder)
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

**Added by**: System Solution Solution

Same as activitypointer entity [entitlementtemplate_ActivityPointers](activitypointer.md#BKMK_entitlementtemplate_ActivityPointers) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|activitypointer|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|entitlementtemplate_ActivityPointers|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_EntitlementTemplate_SyncErrors"></a> EntitlementTemplate_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [EntitlementTemplate_SyncErrors](syncerror.md#BKMK_EntitlementTemplate_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|EntitlementTemplate_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_entitlementtemplate_AsyncOperations"></a> entitlementtemplate_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [entitlementtemplate_AsyncOperations](asyncoperation.md#BKMK_entitlementtemplate_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|entitlementtemplate_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_EntitlementTemplate_MailboxTrackingFolder"></a> EntitlementTemplate_MailboxTrackingFolder

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [EntitlementTemplate_MailboxTrackingFolder](mailboxtrackingfolder.md#BKMK_EntitlementTemplate_MailboxTrackingFolder) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|EntitlementTemplate_MailboxTrackingFolder|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_entitlementtemplate_ProcessSession"></a> entitlementtemplate_ProcessSession

**Added by**: System Solution Solution

Same as processsession entity [entitlementtemplate_ProcessSession](processsession.md#BKMK_entitlementtemplate_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|entitlementtemplate_ProcessSession|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_entitlementtemplate_BulkDeleteFailures"></a> entitlementtemplate_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [entitlementtemplate_BulkDeleteFailures](bulkdeletefailure.md#BKMK_entitlementtemplate_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|entitlementtemplate_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_entitlementtemplate_PrincipalObjectAttributeAccesses"></a> entitlementtemplate_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [entitlementtemplate_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_entitlementtemplate_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|entitlementtemplate_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_entitlementtemplate_Appointments"></a> entitlementtemplate_Appointments

**Added by**: System Solution Solution

Same as appointment entity [entitlementtemplate_Appointments](appointment.md#BKMK_entitlementtemplate_Appointments) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|appointment|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|entitlementtemplate_Appointments|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_entitlementtemplate_Emails"></a> entitlementtemplate_Emails

**Added by**: System Solution Solution

Same as email entity [entitlementtemplate_Emails](email.md#BKMK_entitlementtemplate_Emails) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|email|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|entitlementtemplate_Emails|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_entitlementtemplate_Faxes"></a> entitlementtemplate_Faxes

**Added by**: System Solution Solution

Same as fax entity [entitlementtemplate_Faxes](fax.md#BKMK_entitlementtemplate_Faxes) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|fax|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|entitlementtemplate_Faxes|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_entitlementtemplate_Letters"></a> entitlementtemplate_Letters

**Added by**: System Solution Solution

Same as letter entity [entitlementtemplate_Letters](letter.md#BKMK_entitlementtemplate_Letters) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|letter|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|entitlementtemplate_Letters|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_entitlementtemplate_PhoneCalls"></a> entitlementtemplate_PhoneCalls

**Added by**: System Solution Solution

Same as phonecall entity [entitlementtemplate_PhoneCalls](phonecall.md#BKMK_entitlementtemplate_PhoneCalls) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|phonecall|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|entitlementtemplate_PhoneCalls|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_entitlementtemplate_Tasks"></a> entitlementtemplate_Tasks

**Added by**: System Solution Solution

Same as task entity [entitlementtemplate_Tasks](task.md#BKMK_entitlementtemplate_Tasks) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|task|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|entitlementtemplate_Tasks|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_entitlementtemplate_RecurringAppointmentMasters"></a> entitlementtemplate_RecurringAppointmentMasters

**Added by**: System Solution Solution

Same as recurringappointmentmaster entity [entitlementtemplate_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_entitlementtemplate_RecurringAppointmentMasters) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|recurringappointmentmaster|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|entitlementtemplate_RecurringAppointmentMasters|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_entitlementtemplate_SocialActivities"></a> entitlementtemplate_SocialActivities

**Added by**: System Solution Solution

Same as socialactivity entity [entitlementtemplate_SocialActivities](socialactivity.md#BKMK_entitlementtemplate_SocialActivities) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|socialactivity|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|entitlementtemplate_SocialActivities|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_entitlementtemplate_Annotations"></a> entitlementtemplate_Annotations

**Added by**: System Solution Solution

Same as annotation entity [entitlementtemplate_Annotations](annotation.md#BKMK_entitlementtemplate_Annotations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|entitlementtemplate_Annotations|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_entitlementtemplate_IncidentResolutions"></a> entitlementtemplate_IncidentResolutions

Same as incidentresolution entity [entitlementtemplate_IncidentResolutions](incidentresolution.md#BKMK_entitlementtemplate_IncidentResolutions) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|incidentresolution|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|entitlementtemplate_IncidentResolutions|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_entitlementtemplate_ServiceAppointments"></a> entitlementtemplate_ServiceAppointments

Same as serviceappointment entity [entitlementtemplate_ServiceAppointments](serviceappointment.md#BKMK_entitlementtemplate_ServiceAppointments) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|serviceappointment|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|entitlementtemplate_ServiceAppointments|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_entitlementtemplateid_RelationShip"></a> entitlementtemplateid_RelationShip

Same as entitlement entity [entitlementtemplateid_RelationShip](entitlement.md#BKMK_entitlementtemplateid_RelationShip) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|entitlement|
|ReferencingAttribute|entitlementtemplateid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|entitlementtemplateid_RelationShip|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_entitlementtemplate_entitlementchannel_entitlementtemplateid"></a> entitlementtemplate_entitlementchannel_entitlementtemplateid

Same as entitlementtemplatechannel entity [entitlementtemplate_entitlementchannel_entitlementtemplateid](entitlementtemplatechannel.md#BKMK_entitlementtemplate_entitlementchannel_entitlementtemplateid) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|entitlementtemplatechannel|
|ReferencingAttribute|entitlementtemplateid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|entitlementtemplate_entitlementchannel_entitlementtemplateid|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_entitlementtemplate_DuplicateMatchingRecord"></a> entitlementtemplate_DuplicateMatchingRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [entitlementtemplate_DuplicateMatchingRecord](duplicaterecord.md#BKMK_entitlementtemplate_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|entitlementtemplate_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_entitlementtemplate_DuplicateBaseRecord"></a> entitlementtemplate_DuplicateBaseRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [entitlementtemplate_DuplicateBaseRecord](duplicaterecord.md#BKMK_entitlementtemplate_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|entitlementtemplate_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_entitlementtemplate_OpportunityCloses"></a> entitlementtemplate_OpportunityCloses

**Added by**: Sales Solution

Same as opportunityclose entity [entitlementtemplate_OpportunityCloses](opportunityclose.md#BKMK_entitlementtemplate_OpportunityCloses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|opportunityclose|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|entitlementtemplate_OpportunityCloses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_entitlementtemplate_OrderCloses"></a> entitlementtemplate_OrderCloses

**Added by**: Sales Solution

Same as orderclose entity [entitlementtemplate_OrderCloses](orderclose.md#BKMK_entitlementtemplate_OrderCloses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|orderclose|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|entitlementtemplate_OrderCloses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_entitlementtemplate_QuoteCloses"></a> entitlementtemplate_QuoteCloses

**Added by**: Sales Solution

Same as quoteclose entity [entitlementtemplate_QuoteCloses](quoteclose.md#BKMK_entitlementtemplate_QuoteCloses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|quoteclose|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|entitlementtemplate_QuoteCloses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_entitlementtemplate_msdyn_bookingalerts"></a> entitlementtemplate_msdyn_bookingalerts

**Added by**: Active Solution Solution

Same as msdyn_bookingalert entity [entitlementtemplate_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_entitlementtemplate_msdyn_bookingalerts) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bookingalert|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|entitlementtemplate_msdyn_bookingalerts|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_entitlementtemplate_msdyn_approvals"></a> entitlementtemplate_msdyn_approvals

**Added by**: Active Solution Solution

Same as msdyn_approval entity [entitlementtemplate_msdyn_approvals](msdyn_approval.md#BKMK_entitlementtemplate_msdyn_approvals) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_approval|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|entitlementtemplate_msdyn_approvals|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

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

**Added by**: System Solution Solution

See systemuser Entity [lk_entitlementtemplate_createdby](systemuser.md#BKMK_lk_entitlementtemplate_createdby) One-To-Many relationship.

### <a name="BKMK_lk_entitlementtemplate_createdonbehalfby"></a> lk_entitlementtemplate_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_entitlementtemplate_createdonbehalfby](systemuser.md#BKMK_lk_entitlementtemplate_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_entitlementtemplate_modifiedby"></a> lk_entitlementtemplate_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_entitlementtemplate_modifiedby](systemuser.md#BKMK_lk_entitlementtemplate_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_entitlementtemplate_modifiedonbehalfby"></a> lk_entitlementtemplate_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_entitlementtemplate_modifiedonbehalfby](systemuser.md#BKMK_lk_entitlementtemplate_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_entitlementtemplate_organization"></a> entitlementtemplate_organization

**Added by**: System Solution Solution

See organization Entity [entitlementtemplate_organization](organization.md#BKMK_entitlementtemplate_organization) One-To-Many relationship.

### <a name="BKMK_sla_entitlementtemplate"></a> sla_entitlementtemplate

**Added by**: System Solution Solution

See sla Entity [sla_entitlementtemplate](sla.md#BKMK_sla_entitlementtemplate) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_entitlementtemplate"></a> TransactionCurrency_entitlementtemplate

**Added by**: System Solution Solution

See transactioncurrency Entity [TransactionCurrency_entitlementtemplate](transactioncurrency.md#BKMK_TransactionCurrency_entitlementtemplate) One-To-Many relationship.
<a name="manytomany"></a>

## Many-To-Many Relationships

Relationship details provided where the EntitlementTemplate entity is the first entity in the relationship. Listed by **SchemaName**.


### <a name="BKMK_product_entitlementtemplate_association"></a> product_entitlementtemplate_association

See product Entity [product_entitlementtemplate_association](product.md#BKMK_product_entitlementtemplate_association) Many-To-Many Relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.entitlementtemplate?text=entitlementtemplate EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]