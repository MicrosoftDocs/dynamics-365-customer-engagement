---
title: "ConvertRule Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the ConvertRule entity."
ms.date: 12/05/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# ConvertRule Entity Reference

Defines the settings for automatic record creation.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/convertrules(*convertruleid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/convertrules<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/convertrules(*convertruleid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/convertrules(*convertruleid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/convertrules<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/convertrules(*convertruleid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/convertrules(*convertruleid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|ConvertRules|
|DisplayCollectionName|Record Creation and Update Rules|
|DisplayName|Record Creation and Update Rule|
|EntitySetName|convertrules|
|IsBPFEntity|False|
|LogicalCollectionName|convertrules|
|LogicalName|convertrule|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|convertruleid|
|PrimaryNameAttribute|name|
|SchemaName|ConvertRule|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [AllowUnknownSender](#BKMK_AllowUnknownSender)
- [ChannelPropertyGroupId](#BKMK_ChannelPropertyGroupId)
- [ChannelPropertyGroupIdName](#BKMK_ChannelPropertyGroupIdName)
- [CheckActiveEntitlement](#BKMK_CheckActiveEntitlement)
- [CheckBlockedSocialProfile](#BKMK_CheckBlockedSocialProfile)
- [CheckDirectMessages](#BKMK_CheckDirectMessages)
- [CheckIfResolved](#BKMK_CheckIfResolved)
- [ConvertRuleId](#BKMK_ConvertRuleId)
- [Description](#BKMK_Description)
- [Name](#BKMK_Name)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdType](#BKMK_OwnerIdType)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [QueueId](#BKMK_QueueId)
- [ResolvedSince](#BKMK_ResolvedSince)
- [ResponseTemplateId](#BKMK_ResponseTemplateId)
- [SendAutomaticResponse](#BKMK_SendAutomaticResponse)
- [SourceChannelTypeCode](#BKMK_SourceChannelTypeCode)
- [SourceTypeCode](#BKMK_SourceTypeCode)
- [StateCode](#BKMK_StateCode)
- [StatusCode](#BKMK_StatusCode)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [WorkflowId](#BKMK_WorkflowId)


### <a name="BKMK_AllowUnknownSender"></a> AllowUnknownSender

|Property|Value|
|--------|-----|
|Description|Choose whether items from unknown senders should be converted to records.|
|DisplayName|Allow Unknown Sender|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|allowunknownsender|
|RequiredLevel|None|
|Type|Boolean|

#### AllowUnknownSender Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_ChannelPropertyGroupId"></a> ChannelPropertyGroupId

|Property|Value|
|--------|-----|
|Description|channel property group associated with the convert rule.|
|DisplayName|Channel Property Group|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|channelpropertygroupid|
|RequiredLevel|None|
|Targets|channelpropertygroup|
|Type|Lookup|


### <a name="BKMK_ChannelPropertyGroupIdName"></a> ChannelPropertyGroupIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|channelpropertygroupidname|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CheckActiveEntitlement"></a> CheckActiveEntitlement

|Property|Value|
|--------|-----|
|Description|Choose whether cases should be created for customers with active entitlements.|
|DisplayName|Check Active SLA|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|checkactiveentitlement|
|RequiredLevel|None|
|Type|Boolean|

#### CheckActiveEntitlement Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_CheckBlockedSocialProfile"></a> CheckBlockedSocialProfile

|Property|Value|
|--------|-----|
|Description|Information whether record needs to be created for black listed social profiles.|
|DisplayName|Check black listed social profiles|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|checkblockedsocialprofile|
|RequiredLevel|None|
|Type|Boolean|

#### CheckBlockedSocialProfile Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_CheckDirectMessages"></a> CheckDirectMessages

|Property|Value|
|--------|-----|
|Description|Information whether record needs to be created for direct messages.|
|DisplayName|Create records for private messages only|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|checkdirectmessages|
|RequiredLevel|None|
|Type|Boolean|

#### CheckDirectMessages Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_CheckIfResolved"></a> CheckIfResolved

|Property|Value|
|--------|-----|
|Description|Choose whether an item related to a resolved case should be converted to a case.|
|DisplayName|Check If Resolved|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|checkifresolved|
|RequiredLevel|None|
|Type|Boolean|

#### CheckIfResolved Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_ConvertRuleId"></a> ConvertRuleId

|Property|Value|
|--------|-----|
|Description|Unique identifier for entity instances|
|DisplayName|Convert Rule|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|convertruleid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_Description"></a> Description

|Property|Value|
|--------|-----|
|Description|Type additional information to describe the rule for creating records automatically.|
|DisplayName|Description|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|description|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_Name"></a> Name

|Property|Value|
|--------|-----|
|Description|Type a title or name of the queue for which the setting is defined.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|name|
|MaxLength|100|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|--------|-----|
|Description|Owner Id|
|DisplayName|Owner|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|ownerid|
|RequiredLevel|SystemRequired|
|Targets|systemuser|
|Type|Owner|


### <a name="BKMK_OwnerIdName"></a> OwnerIdName

|Property|Value|
|--------|-----|
|Description|Owner name of the routing rule.|
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridtype|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_OwningTeam"></a> OwningTeam

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


### <a name="BKMK_QueueId"></a> QueueId

|Property|Value|
|--------|-----|
|Description|Choose the queue that the rule is assigned to.|
|DisplayName|Queue|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|queueid|
|RequiredLevel|None|
|Targets|queue|
|Type|Lookup|


### <a name="BKMK_ResolvedSince"></a> ResolvedSince

|Property|Value|
|--------|-----|
|Description|If you want to create a new case for an item associated with a resolved case, type how long a case must remain resolved before a new case is created for the associated item.|
|DisplayName|Resolved Since|
|Format|Duration|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|resolvedsince|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_ResponseTemplateId"></a> ResponseTemplateId

|Property|Value|
|--------|-----|
|Description|Choose the email template to use to create an automatic response to the customer.|
|DisplayName|Response Email Template|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|responsetemplateid|
|RequiredLevel|None|
|Targets|template|
|Type|Lookup|


### <a name="BKMK_SendAutomaticResponse"></a> SendAutomaticResponse

|Property|Value|
|--------|-----|
|Description|Choose whether to send an automatic email response to the customer after a record is created.|
|DisplayName|Send Automatic Response|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|sendautomaticresponse|
|RequiredLevel|None|
|Type|Boolean|

#### SendAutomaticResponse Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_SourceChannelTypeCode"></a> SourceChannelTypeCode

|Property|Value|
|--------|-----|
|Description|Identifies the Dynamics 365 activity that's the source of the record.|
|DisplayName|Source Type|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|sourcechanneltypecode|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_SourceTypeCode"></a> SourceTypeCode

|Property|Value|
|--------|-----|
|Description|Source of the record.|
|DisplayName|Source Type|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|sourcetypecode|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### SourceTypeCode Options

|Value|Label|
|-----|-----|
|1|Social Monitoring|
|2|Email|



### <a name="BKMK_StateCode"></a> StateCode

|Property|Value|
|--------|-----|
|Description|Status of the Convert Rule|
|DisplayName|Status|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statecode|
|RequiredLevel|SystemRequired|
|Type|State|

#### StateCode Options

|Value|Label|DefaultStatus|InvariantName|
|-----|-----|-------------|-------------|
|0|Draft|1|Draft|
|1|Active|2|Active|



### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|--------|-----|
|Description|Reason for the status of the Convert Rule|
|DisplayName|Status Reason|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### StatusCode Options

|Value|Label|State|
|-----|-----|-----|
|1|Draft|0|
|2|Active|1|



### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the currency associated with the queue.|
|DisplayName|Currency|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|transactioncurrencyid|
|RequiredLevel|None|
|Targets|transactioncurrency|
|Type|Lookup|


### <a name="BKMK_WorkflowId"></a> WorkflowId

|Property|Value|
|--------|-----|
|Description|Shows the workflow for this rule.|
|DisplayName|Workflow|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|workflowid|
|RequiredLevel|None|
|Targets|workflow|
|Type|Lookup|

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [ComponentState](#BKMK_ComponentState)
- [ConvertRuleIdUnique](#BKMK_ConvertRuleIdUnique)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [ExchangeRate](#BKMK_ExchangeRate)
- [IsManaged](#BKMK_IsManaged)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [OverwriteTime](#BKMK_OverwriteTime)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [QueueIdName](#BKMK_QueueIdName)
- [RecordVersion](#BKMK_RecordVersion)
- [ResponseTemplateIdName](#BKMK_ResponseTemplateIdName)
- [SolutionId](#BKMK_SolutionId)
- [SupportingSolutionId](#BKMK_SupportingSolutionId)
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
- [VersionNumber](#BKMK_VersionNumber)
- [WorkflowIdName](#BKMK_WorkflowIdName)


### <a name="BKMK_ComponentState"></a> ComponentState

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Component State|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|componentstate|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### ComponentState Options

|Value|Label|
|-----|-----|
|0|Published|
|1|Unpublished|
|2|Deleted|
|3|Deleted Unpublished|



### <a name="BKMK_ConvertRuleIdUnique"></a> ConvertRuleIdUnique

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Unique Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|convertruleidunique|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


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
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

|Property|Value|
|--------|-----|
|Description|Exchange rate for the currency associated with the queue with respect to the base currency.|
|DisplayName|Exchange Rate|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|exchangerate|
|MaxValue|100000000000|
|MinValue|0.0000000001|
|Precision|10|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_IsManaged"></a> IsManaged

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Is Managed|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|ismanaged|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsManaged Options

|Value|Label|
|-----|-----|
|1|Managed|
|0|Unmanaged|

**DefaultValue**: False



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
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OverwriteTime"></a> OverwriteTime

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|For internal use only.|
|DisplayName|Record Overwrite Time|
|Format|DateOnly|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|overwritetime|
|RequiredLevel|SystemRequired|
|Type|DateTime|


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

|Property|Value|
|--------|-----|
|Description|Shows the business unit that the convert rule owner belongs to.|
|DisplayName|Owning Business Unit|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningbusinessunit|
|RequiredLevel|None|
|Targets|businessunit|
|Type|Lookup|


### <a name="BKMK_QueueIdName"></a> QueueIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|queueidname|
|MaxLength|400|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_RecordVersion"></a> RecordVersion

|Property|Value|
|--------|-----|
|Description|Record Version|
|DisplayName|Record Version|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|recordversion|
|MaxLength|50|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_ResponseTemplateIdName"></a> ResponseTemplateIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|responsetemplateidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_SolutionId"></a> SolutionId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the associated solution.|
|DisplayName|Solution|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|solutionid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_SupportingSolutionId"></a> SupportingSolutionId

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Solution|
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|supportingsolutionid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


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
|Description|Version number of the convert rule.|
|DisplayName|Version Number|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|versionnumber|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|
|RequiredLevel|None|
|Type|BigInt|


### <a name="BKMK_WorkflowIdName"></a> WorkflowIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|workflowidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [ConvertRule_ProcessSessions](#BKMK_ConvertRule_ProcessSessions)
- [ConvertRule_userentityinstancedatas](#BKMK_ConvertRule_userentityinstancedatas)
- [convertrule_convertruleitem](#BKMK_convertrule_convertruleitem)
- [ConvertRule_Annotation](#BKMK_ConvertRule_Annotation)
- [Convertrule_AsyncOperations](#BKMK_Convertrule_AsyncOperations)


### <a name="BKMK_ConvertRule_ProcessSessions"></a> ConvertRule_ProcessSessions

Same as processsession entity [ConvertRule_ProcessSessions](processsession.md#BKMK_ConvertRule_ProcessSessions) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|ConvertRule_ProcessSessions|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 110|
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_ConvertRule_userentityinstancedatas"></a> ConvertRule_userentityinstancedatas

Same as userentityinstancedata entity [ConvertRule_userentityinstancedatas](userentityinstancedata.md#BKMK_ConvertRule_userentityinstancedatas) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|userentityinstancedata|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|ConvertRule_userentityinstancedatas|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_convertrule_convertruleitem"></a> convertrule_convertruleitem

Same as convertruleitem entity [convertrule_convertruleitem](convertruleitem.md#BKMK_convertrule_convertruleitem) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|convertruleitem|
|ReferencingAttribute|convertruleid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|convertrule_convertruleitem|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_ConvertRule_Annotation"></a> ConvertRule_Annotation

Same as annotation entity [ConvertRule_Annotation](annotation.md#BKMK_ConvertRule_Annotation) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|ConvertRule_Annotation|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_Convertrule_AsyncOperations"></a> Convertrule_AsyncOperations

Same as asyncoperation entity [Convertrule_AsyncOperations](asyncoperation.md#BKMK_Convertrule_AsyncOperations) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Convertrule_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [emailtemplate_convertrule](#BKMK_emailtemplate_convertrule)
- [convertrule_queue](#BKMK_convertrule_queue)
- [lk_ConvertRule_modifiedonbehalfby](#BKMK_lk_ConvertRule_modifiedonbehalfby)
- [user_convertrule](#BKMK_user_convertrule)
- [team_convertrule](#BKMK_team_convertrule)
- [business_unit_convertrule](#BKMK_business_unit_convertrule)
- [lk_ConvertRule_createdonbehalfby](#BKMK_lk_ConvertRule_createdonbehalfby)
- [TransactionCurrency_ConvertRule](#BKMK_TransactionCurrency_ConvertRule)
- [lk_convertrule_createdby](#BKMK_lk_convertrule_createdby)
- [lk_ConvertRule_modifiedby](#BKMK_lk_ConvertRule_modifiedby)
- [workflowid_convertrule](#BKMK_workflowid_convertrule)
- [channelpropertygroup_convertrule](#BKMK_channelpropertygroup_convertrule)


### <a name="BKMK_emailtemplate_convertrule"></a> emailtemplate_convertrule

See template Entity [emailtemplate_convertrule](template.md#BKMK_emailtemplate_convertrule) One-To-Many relationship.

### <a name="BKMK_convertrule_queue"></a> convertrule_queue

See queue Entity [convertrule_queue](queue.md#BKMK_convertrule_queue) One-To-Many relationship.

### <a name="BKMK_lk_ConvertRule_modifiedonbehalfby"></a> lk_ConvertRule_modifiedonbehalfby

See systemuser Entity [lk_ConvertRule_modifiedonbehalfby](systemuser.md#BKMK_lk_ConvertRule_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_convertrule"></a> user_convertrule

See systemuser Entity [user_convertrule](systemuser.md#BKMK_user_convertrule) One-To-Many relationship.

### <a name="BKMK_team_convertrule"></a> team_convertrule

See team Entity [team_convertrule](team.md#BKMK_team_convertrule) One-To-Many relationship.

### <a name="BKMK_business_unit_convertrule"></a> business_unit_convertrule

See businessunit Entity [business_unit_convertrule](businessunit.md#BKMK_business_unit_convertrule) One-To-Many relationship.

### <a name="BKMK_lk_ConvertRule_createdonbehalfby"></a> lk_ConvertRule_createdonbehalfby

See systemuser Entity [lk_ConvertRule_createdonbehalfby](systemuser.md#BKMK_lk_ConvertRule_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_ConvertRule"></a> TransactionCurrency_ConvertRule

See transactioncurrency Entity [TransactionCurrency_ConvertRule](transactioncurrency.md#BKMK_TransactionCurrency_ConvertRule) One-To-Many relationship.

### <a name="BKMK_lk_convertrule_createdby"></a> lk_convertrule_createdby

See systemuser Entity [lk_convertrule_createdby](systemuser.md#BKMK_lk_convertrule_createdby) One-To-Many relationship.

### <a name="BKMK_lk_ConvertRule_modifiedby"></a> lk_ConvertRule_modifiedby

See systemuser Entity [lk_ConvertRule_modifiedby](systemuser.md#BKMK_lk_ConvertRule_modifiedby) One-To-Many relationship.

### <a name="BKMK_workflowid_convertrule"></a> workflowid_convertrule

See workflow Entity [workflowid_convertrule](workflow.md#BKMK_workflowid_convertrule) One-To-Many relationship.

### <a name="BKMK_channelpropertygroup_convertrule"></a> channelpropertygroup_convertrule

See channelpropertygroup Entity [channelpropertygroup_convertrule](channelpropertygroup.md#BKMK_channelpropertygroup_convertrule) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.convertrule?text=convertrule EntityType" />