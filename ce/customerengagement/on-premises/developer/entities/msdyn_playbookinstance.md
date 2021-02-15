---
title: "msdyn_playbookinstance Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_playbookinstance entity."
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
# msdyn_playbookinstance Entity Reference

Actual instance of a playbook template once it is launched.

**Added by**: Playbook Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_playbookinstances(*msdyn_playbookinstanceid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_playbookinstances<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_playbookinstances(*msdyn_playbookinstanceid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_playbookinstances(*msdyn_playbookinstanceid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_playbookinstances<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_playbookinstances(*msdyn_playbookinstanceid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_playbookinstances(*msdyn_playbookinstanceid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

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

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

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

#### msdyn_evaluateactivityclosure Options

|Value|Label|
|-----|-----|
|1|true|
|0|false|

**DefaultValue**: False



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
|MaxLength|100|
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

#### msdyn_trackprogress Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



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
|Targets|invoice,lead,opportunity,quote,salesorder|
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

#### statecode Options

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

#### statuscode Options

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

## Read-only attributes

These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

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
|MaxLength|100|
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
|MaxLength|100|
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
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningbusinessunit|
|RequiredLevel|None|
|Targets|businessunit|
|Type|Lookup|


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

- [msdyn_playbookinstance_ActivityPointers](#BKMK_msdyn_playbookinstance_ActivityPointers)
- [msdyn_playbookinstance_SyncErrors](#BKMK_msdyn_playbookinstance_SyncErrors)
- [msdyn_playbookinstance_DuplicateMatchingRecord](#BKMK_msdyn_playbookinstance_DuplicateMatchingRecord)
- [msdyn_playbookinstance_DuplicateBaseRecord](#BKMK_msdyn_playbookinstance_DuplicateBaseRecord)
- [msdyn_playbookinstance_AsyncOperations](#BKMK_msdyn_playbookinstance_AsyncOperations)
- [msdyn_playbookinstance_MailboxTrackingFolders](#BKMK_msdyn_playbookinstance_MailboxTrackingFolders)
- [msdyn_playbookinstance_ProcessSession](#BKMK_msdyn_playbookinstance_ProcessSession)
- [msdyn_playbookinstance_BulkDeleteFailures](#BKMK_msdyn_playbookinstance_BulkDeleteFailures)
- [msdyn_playbookinstance_PrincipalObjectAttributeAccesses](#BKMK_msdyn_playbookinstance_PrincipalObjectAttributeAccesses)
- [msdyn_playbookinstance_Appointments](#BKMK_msdyn_playbookinstance_Appointments)
- [msdyn_playbookinstance_Emails](#BKMK_msdyn_playbookinstance_Emails)
- [msdyn_playbookinstance_Faxes](#BKMK_msdyn_playbookinstance_Faxes)
- [msdyn_playbookinstance_Letters](#BKMK_msdyn_playbookinstance_Letters)
- [msdyn_playbookinstance_PhoneCalls](#BKMK_msdyn_playbookinstance_PhoneCalls)
- [msdyn_playbookinstance_Tasks](#BKMK_msdyn_playbookinstance_Tasks)
- [msdyn_playbookinstance_RecurringAppointmentMasters](#BKMK_msdyn_playbookinstance_RecurringAppointmentMasters)
- [msdyn_playbookinstance_SocialActivities](#BKMK_msdyn_playbookinstance_SocialActivities)
- [msdyn_playbookinstance_Annotations](#BKMK_msdyn_playbookinstance_Annotations)
- [msdyn_playbookinstance_ServiceAppointments](#BKMK_msdyn_playbookinstance_ServiceAppointments)
- [msdyn_playbookinstance_OpportunityCloses](#BKMK_msdyn_playbookinstance_OpportunityCloses)
- [msdyn_playbookinstance_OrderCloses](#BKMK_msdyn_playbookinstance_OrderCloses)
- [msdyn_playbookinstance_QuoteCloses](#BKMK_msdyn_playbookinstance_QuoteCloses)
- [msdyn_playbookinstance_msdyn_bookingalerts](#BKMK_msdyn_playbookinstance_msdyn_bookingalerts)
- [msdyn_playbookinstance_msdyn_approvals](#BKMK_msdyn_playbookinstance_msdyn_approvals)


### <a name="BKMK_msdyn_playbookinstance_ActivityPointers"></a> msdyn_playbookinstance_ActivityPointers

**Added by**: System Solution Solution

Same as activitypointer entity [msdyn_playbookinstance_ActivityPointers](activitypointer.md#BKMK_msdyn_playbookinstance_ActivityPointers) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|activitypointer|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_playbookinstance_ActivityPointers|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_playbookinstance_SyncErrors"></a> msdyn_playbookinstance_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [msdyn_playbookinstance_SyncErrors](syncerror.md#BKMK_msdyn_playbookinstance_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_playbookinstance_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_playbookinstance_DuplicateMatchingRecord"></a> msdyn_playbookinstance_DuplicateMatchingRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_playbookinstance_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_playbookinstance_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_playbookinstance_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_playbookinstance_DuplicateBaseRecord"></a> msdyn_playbookinstance_DuplicateBaseRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_playbookinstance_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_playbookinstance_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_playbookinstance_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_playbookinstance_AsyncOperations"></a> msdyn_playbookinstance_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [msdyn_playbookinstance_AsyncOperations](asyncoperation.md#BKMK_msdyn_playbookinstance_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_playbookinstance_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_playbookinstance_MailboxTrackingFolders"></a> msdyn_playbookinstance_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [msdyn_playbookinstance_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_playbookinstance_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_playbookinstance_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_playbookinstance_ProcessSession"></a> msdyn_playbookinstance_ProcessSession

**Added by**: System Solution Solution

Same as processsession entity [msdyn_playbookinstance_ProcessSession](processsession.md#BKMK_msdyn_playbookinstance_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_playbookinstance_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_playbookinstance_BulkDeleteFailures"></a> msdyn_playbookinstance_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [msdyn_playbookinstance_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_playbookinstance_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_playbookinstance_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_playbookinstance_PrincipalObjectAttributeAccesses"></a> msdyn_playbookinstance_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [msdyn_playbookinstance_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_playbookinstance_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_playbookinstance_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_playbookinstance_Appointments"></a> msdyn_playbookinstance_Appointments

**Added by**: System Solution Solution

Same as appointment entity [msdyn_playbookinstance_Appointments](appointment.md#BKMK_msdyn_playbookinstance_Appointments) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|appointment|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_playbookinstance_Appointments|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_playbookinstance_Emails"></a> msdyn_playbookinstance_Emails

**Added by**: System Solution Solution

Same as email entity [msdyn_playbookinstance_Emails](email.md#BKMK_msdyn_playbookinstance_Emails) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|email|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_playbookinstance_Emails|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_playbookinstance_Faxes"></a> msdyn_playbookinstance_Faxes

**Added by**: System Solution Solution

Same as fax entity [msdyn_playbookinstance_Faxes](fax.md#BKMK_msdyn_playbookinstance_Faxes) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|fax|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_playbookinstance_Faxes|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_playbookinstance_Letters"></a> msdyn_playbookinstance_Letters

**Added by**: System Solution Solution

Same as letter entity [msdyn_playbookinstance_Letters](letter.md#BKMK_msdyn_playbookinstance_Letters) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|letter|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_playbookinstance_Letters|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_playbookinstance_PhoneCalls"></a> msdyn_playbookinstance_PhoneCalls

**Added by**: System Solution Solution

Same as phonecall entity [msdyn_playbookinstance_PhoneCalls](phonecall.md#BKMK_msdyn_playbookinstance_PhoneCalls) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|phonecall|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_playbookinstance_PhoneCalls|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_playbookinstance_Tasks"></a> msdyn_playbookinstance_Tasks

**Added by**: System Solution Solution

Same as task entity [msdyn_playbookinstance_Tasks](task.md#BKMK_msdyn_playbookinstance_Tasks) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|task|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_playbookinstance_Tasks|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_playbookinstance_RecurringAppointmentMasters"></a> msdyn_playbookinstance_RecurringAppointmentMasters

**Added by**: System Solution Solution

Same as recurringappointmentmaster entity [msdyn_playbookinstance_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_playbookinstance_RecurringAppointmentMasters) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|recurringappointmentmaster|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_playbookinstance_RecurringAppointmentMasters|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_playbookinstance_SocialActivities"></a> msdyn_playbookinstance_SocialActivities

**Added by**: System Solution Solution

Same as socialactivity entity [msdyn_playbookinstance_SocialActivities](socialactivity.md#BKMK_msdyn_playbookinstance_SocialActivities) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|socialactivity|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_playbookinstance_SocialActivities|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_playbookinstance_Annotations"></a> msdyn_playbookinstance_Annotations

**Added by**: System Solution Solution

Same as annotation entity [msdyn_playbookinstance_Annotations](annotation.md#BKMK_msdyn_playbookinstance_Annotations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_playbookinstance_Annotations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_playbookinstance_ServiceAppointments"></a> msdyn_playbookinstance_ServiceAppointments

**Added by**: Service Solution

Same as serviceappointment entity [msdyn_playbookinstance_ServiceAppointments](serviceappointment.md#BKMK_msdyn_playbookinstance_ServiceAppointments) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|serviceappointment|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_playbookinstance_ServiceAppointments|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_playbookinstance_OpportunityCloses"></a> msdyn_playbookinstance_OpportunityCloses

**Added by**: Sales Solution

Same as opportunityclose entity [msdyn_playbookinstance_OpportunityCloses](opportunityclose.md#BKMK_msdyn_playbookinstance_OpportunityCloses) Many-To-One relationship.

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

Same as orderclose entity [msdyn_playbookinstance_OrderCloses](orderclose.md#BKMK_msdyn_playbookinstance_OrderCloses) Many-To-One relationship.

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

Same as quoteclose entity [msdyn_playbookinstance_QuoteCloses](quoteclose.md#BKMK_msdyn_playbookinstance_QuoteCloses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|quoteclose|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_playbookinstance_QuoteCloses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_playbookinstance_msdyn_bookingalerts"></a> msdyn_playbookinstance_msdyn_bookingalerts

**Added by**: Active Solution Solution

Same as msdyn_bookingalert entity [msdyn_playbookinstance_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_playbookinstance_msdyn_bookingalerts) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bookingalert|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_playbookinstance_msdyn_bookingalerts|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_playbookinstance_msdyn_approvals"></a> msdyn_playbookinstance_msdyn_approvals

**Added by**: Active Solution Solution

Same as msdyn_approval entity [msdyn_playbookinstance_msdyn_approvals](msdyn_approval.md#BKMK_msdyn_playbookinstance_msdyn_approvals) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_approval|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_playbookinstance_msdyn_approvals|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_playbookinstance_createdby](#BKMK_lk_msdyn_playbookinstance_createdby)
- [lk_msdyn_playbookinstance_createdonbehalfby](#BKMK_lk_msdyn_playbookinstance_createdonbehalfby)
- [lk_msdyn_playbookinstance_modifiedby](#BKMK_lk_msdyn_playbookinstance_modifiedby)
- [lk_msdyn_playbookinstance_modifiedonbehalfby](#BKMK_lk_msdyn_playbookinstance_modifiedonbehalfby)
- [user_msdyn_playbookinstance](#BKMK_user_msdyn_playbookinstance)
- [team_msdyn_playbookinstance](#BKMK_team_msdyn_playbookinstance)
- [business_unit_msdyn_playbookinstance](#BKMK_business_unit_msdyn_playbookinstance)
- [msdyn_playbooktemplate_msdyn_playbookinstance](#BKMK_msdyn_playbooktemplate_msdyn_playbookinstance)
- [msdyn_playbookcategory_msdyn_playbookinstance](#BKMK_msdyn_playbookcategory_msdyn_playbookinstance)
- [msdyn_playbookinstance_opportunity](#BKMK_msdyn_playbookinstance_opportunity)
- [msdyn_playbookinstance_quote](#BKMK_msdyn_playbookinstance_quote)
- [msdyn_playbookinstance_salesorder](#BKMK_msdyn_playbookinstance_salesorder)
- [msdyn_playbookinstance_invoice](#BKMK_msdyn_playbookinstance_invoice)
- [msdyn_playbookinstance_lead](#BKMK_msdyn_playbookinstance_lead)


### <a name="BKMK_lk_msdyn_playbookinstance_createdby"></a> lk_msdyn_playbookinstance_createdby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_playbookinstance_createdby](systemuser.md#BKMK_lk_msdyn_playbookinstance_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_playbookinstance_createdonbehalfby"></a> lk_msdyn_playbookinstance_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_playbookinstance_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_playbookinstance_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_playbookinstance_modifiedby"></a> lk_msdyn_playbookinstance_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_playbookinstance_modifiedby](systemuser.md#BKMK_lk_msdyn_playbookinstance_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_playbookinstance_modifiedonbehalfby"></a> lk_msdyn_playbookinstance_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_playbookinstance_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_playbookinstance_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_playbookinstance"></a> user_msdyn_playbookinstance

**Added by**: System Solution Solution

See systemuser Entity [user_msdyn_playbookinstance](systemuser.md#BKMK_user_msdyn_playbookinstance) One-To-Many relationship.

### <a name="BKMK_team_msdyn_playbookinstance"></a> team_msdyn_playbookinstance

**Added by**: System Solution Solution

See team Entity [team_msdyn_playbookinstance](team.md#BKMK_team_msdyn_playbookinstance) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_playbookinstance"></a> business_unit_msdyn_playbookinstance

**Added by**: System Solution Solution

See businessunit Entity [business_unit_msdyn_playbookinstance](businessunit.md#BKMK_business_unit_msdyn_playbookinstance) One-To-Many relationship.

### <a name="BKMK_msdyn_playbooktemplate_msdyn_playbookinstance"></a> msdyn_playbooktemplate_msdyn_playbookinstance

See msdyn_playbooktemplate Entity [msdyn_playbooktemplate_msdyn_playbookinstance](msdyn_playbooktemplate.md#BKMK_msdyn_playbooktemplate_msdyn_playbookinstance) One-To-Many relationship.

### <a name="BKMK_msdyn_playbookcategory_msdyn_playbookinstance"></a> msdyn_playbookcategory_msdyn_playbookinstance

See msdyn_playbookcategory Entity [msdyn_playbookcategory_msdyn_playbookinstance](msdyn_playbookcategory.md#BKMK_msdyn_playbookcategory_msdyn_playbookinstance) One-To-Many relationship.

### <a name="BKMK_msdyn_playbookinstance_opportunity"></a> msdyn_playbookinstance_opportunity

**Added by**: Sales Solution

See opportunity Entity [msdyn_playbookinstance_opportunity](opportunity.md#BKMK_msdyn_playbookinstance_opportunity) One-To-Many relationship.

### <a name="BKMK_msdyn_playbookinstance_quote"></a> msdyn_playbookinstance_quote

**Added by**: Sales Solution

See quote Entity [msdyn_playbookinstance_quote](quote.md#BKMK_msdyn_playbookinstance_quote) One-To-Many relationship.

### <a name="BKMK_msdyn_playbookinstance_salesorder"></a> msdyn_playbookinstance_salesorder

**Added by**: Sales Solution

See salesorder Entity [msdyn_playbookinstance_salesorder](salesorder.md#BKMK_msdyn_playbookinstance_salesorder) One-To-Many relationship.

### <a name="BKMK_msdyn_playbookinstance_invoice"></a> msdyn_playbookinstance_invoice

**Added by**: Sales Solution

See invoice Entity [msdyn_playbookinstance_invoice](invoice.md#BKMK_msdyn_playbookinstance_invoice) One-To-Many relationship.

### <a name="BKMK_msdyn_playbookinstance_lead"></a> msdyn_playbookinstance_lead

**Added by**: Lead Management Solution

See lead Entity [msdyn_playbookinstance_lead](lead.md#BKMK_msdyn_playbookinstance_lead) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_playbookinstance?text=msdyn_playbookinstance EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]