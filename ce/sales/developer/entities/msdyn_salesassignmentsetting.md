---
title: "msdyn_salesassignmentsetting table/entity reference"
description: "Includes schema information and supported messages for the msdyn_salesassignmentsetting table/entity."
ms.date: 02/27/2024
ms.service: "dynamics-365-sales"
ms.topic: "reference"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "lavanyakr01"
ms.author: lavanyakr
ms.reviewer: lavanyakr
search.audienceType: 
  - developer
---

# msdyn_salesassignmentsetting table/entity reference

> [!NOTE]
> Unsure about table vs. entity? See [Developers: Understand terminology in Microsoft Dataverse](/powerapps/developer/data-platform/understand-terminology).



**Added by**: Assignment Rules Solution


## Messages

|Message|Web API Operation|SDK class or method|
|-|-|-|
|BulkRetain|This message is to be executed only by Dataverse to trigger registered plug-ins and flows.||
|Create|POST /msdyn_salesassignmentsettings<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|CreateMultiple|<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType />|<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
|Delete|DELETE /msdyn_salesassignmentsettings(*msdyn_salesassignmentsettingid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|IsValidStateTransition|<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|PurgeRetainedContent|This message is to be executed only by Dataverse to trigger registered plug-ins and flows.||
|Retain|This message is to be executed only by Dataverse to trigger registered plug-ins and flows.||
|Retrieve|GET /msdyn_salesassignmentsettings(*msdyn_salesassignmentsettingid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET /msdyn_salesassignmentsettings<br />See [Query Data](/powerapps/developer/data-platform/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RollbackRetain|This message is to be executed only by Dataverse to trigger registered plug-ins and flows.||
|SetState|PATCH /msdyn_salesassignmentsettings(*msdyn_salesassignmentsettingid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH /msdyn_salesassignmentsettings(*msdyn_salesassignmentsettingid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|
|UpdateMultiple|<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType />|<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
|ValidateRetentionConfig|This message is to be executed only by Dataverse to trigger registered plug-ins and flows.||

## Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_salesassignmentsettings|
|DisplayCollectionName|msdyn_salesassignmentsettings|
|DisplayName|Sales Assignment Setting|
|EntitySetName|msdyn_salesassignmentsettings|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_salesassignmentsettings|
|LogicalName|msdyn_salesassignmentsetting|
|OwnershipType|OrganizationOwned|
|PrimaryIdAttribute|msdyn_salesassignmentsettingid|
|PrimaryNameAttribute|msdyn_name|
|SchemaName|msdyn_salesassignmentsetting|

<a name="writable-attributes"></a>

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_customownerfield](#BKMK_msdyn_customownerfield)
- [msdyn_defaultcapacity](#BKMK_msdyn_defaultcapacity)
- [msdyn_enabledtime](#BKMK_msdyn_enabledtime)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_opportunityroutingenabled](#BKMK_msdyn_opportunityroutingenabled)
- [msdyn_reassignmentbatchcount](#BKMK_msdyn_reassignmentbatchcount)
- [msdyn_reassignmentbatchsize](#BKMK_msdyn_reassignmentbatchsize)
- [msdyn_roundrobinscope](#BKMK_msdyn_roundrobinscope)
- [msdyn_RuleInfoEnabled](#BKMK_msdyn_RuleInfoEnabled)
- [msdyn_salesassignmentsettingId](#BKMK_msdyn_salesassignmentsettingId)
- [msdyn_verboselogging](#BKMK_msdyn_verboselogging)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


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


### <a name="BKMK_msdyn_customownerfield"></a> msdyn_customownerfield

|Property|Value|
|--------|-----|
|Description|The logical name of the custom owner field used for assignment|
|DisplayName|Custom Owner Field|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_customownerfield|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_defaultcapacity"></a> msdyn_defaultcapacity

|Property|Value|
|--------|-----|
|Description|Defines default value indicating records a seller can work on at a given point in time.|
|DisplayName|Default Capacity|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_defaultcapacity|
|MaxValue|2147483647|
|MinValue|1|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_enabledtime"></a> msdyn_enabledtime

|Property|Value|
|--------|-----|
|DateTimeBehavior|TimeZoneIndependent|
|Description|The field  denotes the time when the feature was enabled|
|DisplayName|EnabledTime|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_enabledtime|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|--------|-----|
|Description|The name of the custom entity.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_name|
|MaxLength|100|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_msdyn_opportunityroutingenabled"></a> msdyn_opportunityroutingenabled

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Opportunity routing|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_opportunityroutingenabled|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|

#### msdyn_opportunityroutingenabled Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Yes||
|0|No||

**DefaultValue**: 1



### <a name="BKMK_msdyn_reassignmentbatchcount"></a> msdyn_reassignmentbatchcount

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Reassignment batch count|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_reassignmentbatchcount|
|MaxValue|1000|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_reassignmentbatchsize"></a> msdyn_reassignmentbatchsize

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Reassignment batch size|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_reassignmentbatchsize|
|MaxValue|1000|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_roundrobinscope"></a> msdyn_roundrobinscope

|Property|Value|
|--------|-----|
|Description|Round robin scope evaluated during distribution|
|DisplayName|RoundRobinScope|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_roundrobinscope|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|

#### msdyn_roundrobinscope Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|0|Organization||
|1|AssingmentRule||



### <a name="BKMK_msdyn_RuleInfoEnabled"></a> msdyn_RuleInfoEnabled

|Property|Value|
|--------|-----|
|Description|RuleInfoEnabled|
|DisplayName|RuleInfoEnabled|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_ruleinfoenabled|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_RuleInfoEnabled Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Yes||
|0|No||

**DefaultValue**: 0



### <a name="BKMK_msdyn_salesassignmentsettingId"></a> msdyn_salesassignmentsettingId

|Property|Value|
|--------|-----|
|Description|Unique identifier for entity instances|
|DisplayName|Sales Assignment Setting|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_salesassignmentsettingid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_msdyn_verboselogging"></a> msdyn_verboselogging

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Verbose Logging|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_verboselogging|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|

#### msdyn_verboselogging Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Yes||
|0|No||

**DefaultValue**: 0



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


### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|--------|-----|
|Description|Status of the Sales Assignment Setting|
|DisplayName|Status|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statecode|
|RequiredLevel|SystemRequired|
|Type|State|

#### statecode Choices/Options

|Value|Label|DefaultStatus|InvariantName|
|-----|-----|-------------|-------------|
|0|Active|1|Active|
|1|Inactive|2|Inactive|



### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|--------|-----|
|Description|Reason for the status of the Sales Assignment Setting|
|DisplayName|Status Reason|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### statuscode Choices/Options

|Value|Label|State|
|-----|-----|-----|
|1|Active|0|
|2|Inactive|1|



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

## Read-only columns/attributes

These columns/attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [OrganizationId](#BKMK_OrganizationId)
- [OrganizationIdName](#BKMK_OrganizationIdName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_CreatedBy"></a> CreatedBy

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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
|RequiredLevel|SystemRequired|
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

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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
|RequiredLevel|SystemRequired|
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

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OrganizationId"></a> OrganizationId

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier for the organization|
|DisplayName|Organization Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|organizationid|
|RequiredLevel|None|
|Targets|organization|
|Type|Lookup|


### <a name="BKMK_OrganizationIdName"></a> OrganizationIdName

**Added by**: Active Solution Solution

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


### <a name="BKMK_VersionNumber"></a> VersionNumber

**Added by**: Active Solution Solution

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



## Related information

[Dataverse table/entity reference](../about-entity-reference.md)  
[Web API Reference](/power-apps/developer/data-platform/webapi/reference/entitytypes)