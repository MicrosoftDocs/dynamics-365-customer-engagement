---
title: "msdyn_playbookinstance table/entity reference (Dynamics 365 Sales) | Microsoft Docs"
description: "Includes schema information and supported messages for the msdyn_playbookinstance table/entity."
ms.date: 02/17/2023
ms.service: dynamics-365-sales
ms.topic: "reference"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "udaykirang"
ms.author: "udag"
search.audienceType: 
  - developer
---

# msdyn_playbookinstance table/entity reference

> [!NOTE]
> Unsure about table vs. entity? See [Developers: Understand terminology in Microsoft Dataverse](/powerapps/developer/data-platform/understand-terminology).

Actual instance of a playbook template once it is launched.

**Added by**: Playbook Solution


## Messages

|Message|SDK Assembly|
|-|-|
|Assign|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|CreateMultiple|<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
|Delete|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|
|UpdateMultiple|<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|

## Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_playbookinstances|
|DisplayCollectionName|Playbooks|
|DisplayName|Playbook|
|EntitySetName|msdyn_playbookinstances|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_playbookinstances|
|LogicalName|msdyn_playbookinstance|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|msdyn_playbookinstanceid|
|PrimaryNameAttribute|msdyn_name|
|SchemaName|msdyn_playbookinstance|

<a name="writable-attributes"></a>

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_activitiesassociated](#BKMK_msdyn_activitiesassociated)
- [msdyn_activitiesclosed](#BKMK_msdyn_activitiesclosed)
- [msdyn_categoryid](#BKMK_msdyn_categoryid)
- [msdyn_estimatedclose](#BKMK_msdyn_estimatedclose)
- [msdyn_evaluateactivityclosure](#BKMK_msdyn_evaluateactivityclosure)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_playbookinstanceId](#BKMK_msdyn_playbookinstanceId)
- [msdyn_playbooktemplateid](#BKMK_msdyn_playbooktemplateid)
- [msdyn_trackprogress](#BKMK_msdyn_trackprogress)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [Regarding](#BKMK_Regarding)
- [RegardingObjectTypeCode](#BKMK_RegardingObjectTypeCode)
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


### <a name="BKMK_msdyn_activitiesassociated"></a> msdyn_activitiesassociated

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Total activities|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_activitiesassociated|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_activitiesclosed"></a> msdyn_activitiesclosed

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Completed activities|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_activitiesclosed|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_categoryid"></a> msdyn_categoryid

|Property|Value|
|--------|-----|
|Description|Select the playbook category for the playbook.|
|DisplayName|Category|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_categoryid|
|RequiredLevel|None|
|Targets|msdyn_playbookcategory|
|Type|Lookup|


### <a name="BKMK_msdyn_estimatedclose"></a> msdyn_estimatedclose

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Estimated close date for a playbook based on the estimated duration specified for the playbook template.|
|DisplayName|Estimated close|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_estimatedclose|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_evaluateactivityclosure"></a> msdyn_evaluateactivityclosure

|Property|Value|
|--------|-----|
|Description|Internal Use Only|
|DisplayName|Evaluate Activity Closure|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_evaluateactivityclosure|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_evaluateactivityclosure Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|true||
|0|false||

**DefaultValue**: 0



### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|--------|-----|
|Description|Type the name of the playbook.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_name|
|MaxLength|128|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_msdyn_playbookinstanceId"></a> msdyn_playbookinstanceId

|Property|Value|
|--------|-----|
|Description|Unique identifier for entity instances|
|DisplayName|Playbook|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_playbookinstanceid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_msdyn_playbooktemplateid"></a> msdyn_playbooktemplateid

|Property|Value|
|--------|-----|
|Description|Shows the unique ID of the playbook template associated with the playbook.|
|DisplayName|Playbook Template|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_playbooktemplateid|
|RequiredLevel|ApplicationRequired|
|Targets|msdyn_playbooktemplate|
|Type|Lookup|


### <a name="BKMK_msdyn_trackprogress"></a> msdyn_trackprogress

|Property|Value|
|--------|-----|
|Description|Select whether or not to track the progress of the playbook by creating the activities under a playbook which is in turn linked to the record type the playbook applies to.|
|DisplayName|Track progress|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_trackprogress|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|

#### msdyn_trackprogress Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Yes||
|0|No||

**DefaultValue**: 1



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


### <a name="BKMK_OwnerId"></a> OwnerId

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Owner Id|
|DisplayName|Owner|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|ownerid|
|RequiredLevel|SystemRequired|
|Targets|systemuser,team|
|Type|Owner|


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Owner Id Type|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridtype|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_Regarding"></a> Regarding

|Property|Value|
|--------|-----|
|Description|Shows the entity the playbook is launched for.|
|DisplayName|Regarding|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|regarding|
|RequiredLevel|None|
|Targets|account,contact,invoice,lead,opportunity,quote,salesorder|
|Type|Lookup|


### <a name="BKMK_RegardingObjectTypeCode"></a> RegardingObjectTypeCode

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|regardingobjecttypecode|
|RequiredLevel|None|
|Type|EntityName|


### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|--------|-----|
|Description|Status of the Playbook|
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
|1|Completed|2|Completed|



### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|--------|-----|
|Description|Playbook result|
|DisplayName|Result|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### statuscode Choices/Options

|Value|Label|State|
|-----|-----|-----|
|1|In Progress|0|
|2|Successful|1|
|3|Not Successful|1|
|4|Partially Successful|1|
|5|Not Required|1|
|6|Not Tracked|1|



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
- [msdyn_categoryidName](#BKMK_msdyn_categoryidName)
- [msdyn_playbooktemplateidName](#BKMK_msdyn_playbooktemplateidName)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningBusinessUnitName](#BKMK_OwningBusinessUnitName)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [RegardingIdName](#BKMK_RegardingIdName)
- [RegardingYomiName](#BKMK_RegardingYomiName)
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
|Description|Date and time when the playbook was started.|
|DisplayName|Started On|
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


### <a name="BKMK_msdyn_categoryidName"></a> msdyn_categoryidName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_categoryidname|
|MaxLength|128|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_playbooktemplateidName"></a> msdyn_playbooktemplateidName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_playbooktemplateidname|
|MaxLength|128|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OwnerIdName"></a> OwnerIdName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Name of the owner|
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Yomi name of the owner|
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridyominame|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier for the business unit that owns the record|
|DisplayName|Owning Business Unit|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|owningbusinessunit|
|RequiredLevel|None|
|Targets|businessunit|
|Type|Lookup|


### <a name="BKMK_OwningBusinessUnitName"></a> OwningBusinessUnitName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningbusinessunitname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OwningTeam"></a> OwningTeam

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier for the team that owns the record.|
|DisplayName|Owning Team|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningteam|
|RequiredLevel|None|
|Targets|team|
|Type|Lookup|


### <a name="BKMK_OwningUser"></a> OwningUser

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier for the user that owns the record.|
|DisplayName|Owning User|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owninguser|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_RegardingIdName"></a> RegardingIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|regardingidname|
|MaxLength|4000|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_RegardingYomiName"></a> RegardingYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|regardingyominame|
|MaxLength|4000|
|RequiredLevel|None|
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

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [msdyn_playbookinstance_OpportunityCloses](#BKMK_msdyn_playbookinstance_OpportunityCloses)
- [msdyn_playbookinstance_OrderCloses](#BKMK_msdyn_playbookinstance_OrderCloses)
- [msdyn_playbookinstance_QuoteCloses](#BKMK_msdyn_playbookinstance_QuoteCloses)


### <a name="BKMK_msdyn_playbookinstance_OpportunityCloses"></a> msdyn_playbookinstance_OpportunityCloses

**Added by**: Sales Solution

Same as the [msdyn_playbookinstance_OpportunityCloses](opportunityclose.md#BKMK_msdyn_playbookinstance_OpportunityCloses) many-to-one relationship for the [opportunityclose](opportunityclose.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|opportunityclose|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_playbookinstance_OpportunityCloses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_playbookinstance_OrderCloses"></a> msdyn_playbookinstance_OrderCloses

**Added by**: Sales Solution

Same as the [msdyn_playbookinstance_OrderCloses](orderclose.md#BKMK_msdyn_playbookinstance_OrderCloses) many-to-one relationship for the [orderclose](orderclose.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|orderclose|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_playbookinstance_OrderCloses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_playbookinstance_QuoteCloses"></a> msdyn_playbookinstance_QuoteCloses

**Added by**: Sales Solution

Same as the [msdyn_playbookinstance_QuoteCloses](quoteclose.md#BKMK_msdyn_playbookinstance_QuoteCloses) many-to-one relationship for the [quoteclose](quoteclose.md) table/entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|quoteclose|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_playbookinstance_QuoteCloses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related table. Listed by **SchemaName**.

- [msdyn_playbooktemplate_msdyn_playbookinstance](#BKMK_msdyn_playbooktemplate_msdyn_playbookinstance)
- [msdyn_playbookcategory_msdyn_playbookinstance](#BKMK_msdyn_playbookcategory_msdyn_playbookinstance)
- [msdyn_playbookinstance_opportunity](#BKMK_msdyn_playbookinstance_opportunity)
- [msdyn_playbookinstance_quote](#BKMK_msdyn_playbookinstance_quote)
- [msdyn_playbookinstance_salesorder](#BKMK_msdyn_playbookinstance_salesorder)
- [msdyn_playbookinstance_invoice](#BKMK_msdyn_playbookinstance_invoice)
- [msdyn_playbookinstance_lead](#BKMK_msdyn_playbookinstance_lead)
- [msdyn_playbookinstance_contact](#BKMK_msdyn_playbookinstance_contact)
- [msdyn_playbookinstance_account](#BKMK_msdyn_playbookinstance_account)


### <a name="BKMK_msdyn_playbooktemplate_msdyn_playbookinstance"></a> msdyn_playbooktemplate_msdyn_playbookinstance

See the [msdyn_playbooktemplate_msdyn_playbookinstance](msdyn_playbooktemplate.md#BKMK_msdyn_playbooktemplate_msdyn_playbookinstance) one-to-many relationship for the [msdyn_playbooktemplate](msdyn_playbooktemplate.md) table/entity.

### <a name="BKMK_msdyn_playbookcategory_msdyn_playbookinstance"></a> msdyn_playbookcategory_msdyn_playbookinstance

See the [msdyn_playbookcategory_msdyn_playbookinstance](msdyn_playbookcategory.md#BKMK_msdyn_playbookcategory_msdyn_playbookinstance) one-to-many relationship for the [msdyn_playbookcategory](msdyn_playbookcategory.md) table/entity.

### <a name="BKMK_msdyn_playbookinstance_opportunity"></a> msdyn_playbookinstance_opportunity

**Added by**: Sales Solution

See the [msdyn_playbookinstance_opportunity](opportunity.md#BKMK_msdyn_playbookinstance_opportunity) one-to-many relationship for the [opportunity](opportunity.md) table/entity.

### <a name="BKMK_msdyn_playbookinstance_quote"></a> msdyn_playbookinstance_quote

**Added by**: Sales Solution

See the [msdyn_playbookinstance_quote](quote.md#BKMK_msdyn_playbookinstance_quote) one-to-many relationship for the [quote](quote.md) table/entity.

### <a name="BKMK_msdyn_playbookinstance_salesorder"></a> msdyn_playbookinstance_salesorder

**Added by**: Sales Solution

See the [msdyn_playbookinstance_salesorder](salesorder.md#BKMK_msdyn_playbookinstance_salesorder) one-to-many relationship for the [salesorder](salesorder.md) table/entity.

### <a name="BKMK_msdyn_playbookinstance_invoice"></a> msdyn_playbookinstance_invoice

**Added by**: Sales Solution

See the [msdyn_playbookinstance_invoice](invoice.md#BKMK_msdyn_playbookinstance_invoice) one-to-many relationship for the [invoice](invoice.md) table/entity.

### <a name="BKMK_msdyn_playbookinstance_lead"></a> msdyn_playbookinstance_lead

**Added by**: Lead Management Solution

See the [msdyn_playbookinstance_lead](lead.md#BKMK_msdyn_playbookinstance_lead) one-to-many relationship for the [lead](lead.md) table/entity.

### <a name="BKMK_msdyn_playbookinstance_contact"></a> msdyn_playbookinstance_contact

**Added by**: System Solution Solution

See the [msdyn_playbookinstance_contact](contact.md#BKMK_msdyn_playbookinstance_contact) one-to-many relationship for the [contact](contact.md) table/entity.

### <a name="BKMK_msdyn_playbookinstance_account"></a> msdyn_playbookinstance_account

**Added by**: System Solution Solution

See the [msdyn_playbookinstance_account](account.md#BKMK_msdyn_playbookinstance_account) one-to-many relationship for the [account](account.md) table/entity.

### See also

[About the table reference](../about-entity-reference.md)<br />
[Web API Reference](/power-apps/developer/data-platform/webapi/reference/entitytypes)<br />
