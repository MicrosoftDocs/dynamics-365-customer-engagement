---
title: "BusinessProcessFlowInstance Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the BusinessProcessFlowInstance entity."
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
# BusinessProcessFlowInstance Entity Reference

Active path associated with every Business Process Flow instance


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/businessprocessflowinstances<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|SetState|PATCH [*org URI*]/api/data/v9.0/businessprocessflowinstances(*businessprocessflowinstanceid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/businessprocessflowinstances(*businessprocessflowinstanceid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|BusinessProcessFlowInstances|
|DisplayCollectionName|Business Process Flow Instances|
|DisplayName|Business Process Flow Instance|
|EntitySetName|businessprocessflowinstances|
|IsBPFEntity|False|
|LogicalCollectionName|businessprocessflowinstances|
|LogicalName|businessprocessflowinstance|
|OwnershipType|None|
|PrimaryIdAttribute|businessprocessflowinstanceid|
|PrimaryNameAttribute||
|SchemaName|BusinessProcessFlowInstance|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [BusinessProcessFlowInstanceId](#BKMK_BusinessProcessFlowInstanceId)
- [Entity1Id](#BKMK_Entity1Id)
- [Entity1ObjectTypeCode](#BKMK_Entity1ObjectTypeCode)
- [Entity2Id](#BKMK_Entity2Id)
- [Entity2ObjectTypeCode](#BKMK_Entity2ObjectTypeCode)
- [Entity3Id](#BKMK_Entity3Id)
- [Entity3ObjectTypeCode](#BKMK_Entity3ObjectTypeCode)
- [Entity4Id](#BKMK_Entity4Id)
- [Entity4ObjectTypeCode](#BKMK_Entity4ObjectTypeCode)
- [Entity5Id](#BKMK_Entity5Id)
- [Entity5ObjectTypeCode](#BKMK_Entity5ObjectTypeCode)
- [Name](#BKMK_Name)
- [ProcessId](#BKMK_ProcessId)
- [ProcessStageId](#BKMK_ProcessStageId)
- [StateCode](#BKMK_StateCode)
- [StatusCode](#BKMK_StatusCode)
- [TraversedPath](#BKMK_TraversedPath)


### <a name="BKMK_BusinessProcessFlowInstanceId"></a> BusinessProcessFlowInstanceId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the business process flow instance.|
|DisplayName|Process Instance ID|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|businessprocessflowinstanceid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_Entity1Id"></a> Entity1Id

|Property|Value|
|--------|-----|
|Description|Unique identifier of the first entity instance.|
|DisplayName|Entity 1 ID|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|entity1id|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_Entity1ObjectTypeCode"></a> Entity1ObjectTypeCode

|Property|Value|
|--------|-----|
|Description|Object type code for the first entity of the business process flow instance.|
|DisplayName|Entity1ObjectTypeCode|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|entity1objecttypecode|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_Entity2Id"></a> Entity2Id

|Property|Value|
|--------|-----|
|Description|Unique identifier of the second entity instance.|
|DisplayName|Entity 2 ID|
|IsValidForCreate|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|entity2id|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_Entity2ObjectTypeCode"></a> Entity2ObjectTypeCode

|Property|Value|
|--------|-----|
|Description|Object type code for the second entity of the business process flow instance.|
|DisplayName|Entity2ObjectTypeCode|
|IsValidForCreate|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|entity2objecttypecode|
|RequiredLevel|None|
|Type|EntityName|


### <a name="BKMK_Entity3Id"></a> Entity3Id

|Property|Value|
|--------|-----|
|Description|Unique identifier of the third entity instance.|
|DisplayName|Entity 3 ID|
|IsValidForCreate|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|entity3id|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_Entity3ObjectTypeCode"></a> Entity3ObjectTypeCode

|Property|Value|
|--------|-----|
|Description|Object type code for the third entity of the business process flow instance.|
|DisplayName|Entity3ObjectTypeCode|
|IsValidForCreate|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|entity3objecttypecode|
|RequiredLevel|None|
|Type|EntityName|


### <a name="BKMK_Entity4Id"></a> Entity4Id

|Property|Value|
|--------|-----|
|Description|Unique identifier of the fourth entity instance.|
|DisplayName|Entity 4 Id|
|IsValidForCreate|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|entity4id|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_Entity4ObjectTypeCode"></a> Entity4ObjectTypeCode

|Property|Value|
|--------|-----|
|Description|Object type code for the fourth entity of the business process flow instance.|
|DisplayName|Entity4ObjectTypeCode|
|IsValidForCreate|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|entity4objecttypecode|
|RequiredLevel|None|
|Type|EntityName|


### <a name="BKMK_Entity5Id"></a> Entity5Id

|Property|Value|
|--------|-----|
|Description|Unique identifier of the fifth entity instance.|
|DisplayName|Entity 5 ID|
|IsValidForCreate|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|entity5id|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_Entity5ObjectTypeCode"></a> Entity5ObjectTypeCode

|Property|Value|
|--------|-----|
|Description|Object type code for the fifth entity of the business process flow instance.|
|DisplayName|Entity5ObjectTypeCode|
|IsValidForCreate|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|entity5objecttypecode|
|RequiredLevel|None|
|Type|EntityName|


### <a name="BKMK_Name"></a> Name

|Property|Value|
|--------|-----|
|Description|Type a descriptive name for the instance.|
|DisplayName|Instance Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|name|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ProcessId"></a> ProcessId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the business process flow.|
|DisplayName|Process|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|processid|
|RequiredLevel|SystemRequired|
|Targets|workflow|
|Type|Lookup|


### <a name="BKMK_ProcessStageId"></a> ProcessStageId

|Property|Value|
|--------|-----|
|Description|Unique identifier of active stage in the business process flow instance.|
|DisplayName|Active Stage ID|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|processstageid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_StateCode"></a> StateCode

|Property|Value|
|--------|-----|
|Description|Shows whether the business process flow instance is active or inactive.|
|DisplayName|State|
|IsValidForCreate|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|statecode|
|RequiredLevel|SystemRequired|
|Type|State|

#### StateCode Options

|Value|Label|DefaultStatus|InvariantName|
|-----|-----|-------------|-------------|
|0|Active|1|Active|
|1|Inactive|2|Inactive|



### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|--------|-----|
|Description|Business process flow instance's status.|
|DisplayName|Status Reason|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|SystemRequired|
|Type|Status|

#### StatusCode Options

|Value|Label|State|
|-----|-----|-----|
|1|Active|0|
|2|Finished|1|
|3|Aborted|1|



### <a name="BKMK_TraversedPath"></a> TraversedPath

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Active Path|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|traversedpath|
|MaxLength|1250|
|RequiredLevel|None|
|Type|String|

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [ActiveStageStartedOn](#BKMK_ActiveStageStartedOn)
- [CompletedOn](#BKMK_CompletedOn)
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
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_ActiveStageStartedOn"></a> ActiveStageStartedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the active stage was started.|
|DisplayName|Active Stage Started On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|activestagestartedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_CompletedOn"></a> CompletedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the process completed.|
|DisplayName|Completed On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|completedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|--------|-----|
|Description|Shows who created the record.|
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
|Description|Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.|
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
|Description|Shows who created the record on behalf of another user.|
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


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|--------|-----|
|Description|Shows who last updated the record.|
|DisplayName|Modified By|
|IsValidForForm|False|
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
|Description|Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.|
|DisplayName|Modified On|
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Shows who created the record on behalf of another user.|
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


### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|--------|-----|
|Description|Version number of the business process flow instance.|
|DisplayName|Version Number|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|versionnumber|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|
|RequiredLevel|None|
|Type|BigInt|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_businessprocessflowinstancebase_modifiedonbehalfby](#BKMK_lk_businessprocessflowinstancebase_modifiedonbehalfby)
- [lk_businessprocessflowinstancebase_createdonbehalfby](#BKMK_lk_businessprocessflowinstancebase_createdonbehalfby)
- [lk_businessprocessflowinstancebase_createdby](#BKMK_lk_businessprocessflowinstancebase_createdby)
- [lk_businessprocessflowinstancebase_modifiedby](#BKMK_lk_businessprocessflowinstancebase_modifiedby)


### <a name="BKMK_lk_businessprocessflowinstancebase_modifiedonbehalfby"></a> lk_businessprocessflowinstancebase_modifiedonbehalfby

See systemuser Entity [lk_businessprocessflowinstancebase_modifiedonbehalfby](systemuser.md#BKMK_lk_businessprocessflowinstancebase_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_businessprocessflowinstancebase_createdonbehalfby"></a> lk_businessprocessflowinstancebase_createdonbehalfby

See systemuser Entity [lk_businessprocessflowinstancebase_createdonbehalfby](systemuser.md#BKMK_lk_businessprocessflowinstancebase_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_businessprocessflowinstancebase_createdby"></a> lk_businessprocessflowinstancebase_createdby

See systemuser Entity [lk_businessprocessflowinstancebase_createdby](systemuser.md#BKMK_lk_businessprocessflowinstancebase_createdby) One-To-Many relationship.

### <a name="BKMK_lk_businessprocessflowinstancebase_modifiedby"></a> lk_businessprocessflowinstancebase_modifiedby

See systemuser Entity [lk_businessprocessflowinstancebase_modifiedby](systemuser.md#BKMK_lk_businessprocessflowinstancebase_modifiedby) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.businessprocessflowinstance?text=businessprocessflowinstance EntityType" />