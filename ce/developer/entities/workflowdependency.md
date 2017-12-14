---
title: "WorkflowDependency Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the WorkflowDependency entity."
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
# WorkflowDependency Entity Reference

Dependencies for a process.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/workflowdependencies<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/workflowdependencies(*workflowdependencyid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/workflowdependencies(*workflowdependencyid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/workflowdependencies<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|Update|PATCH [*org URI*]/api/data/v9.0/workflowdependencies(*workflowdependencyid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|WorkflowDependencies|
|DisplayCollectionName|Process Dependencies|
|DisplayName|Process Dependency|
|EntitySetName|workflowdependencies|
|IsBPFEntity|False|
|LogicalCollectionName|workflowdependencies|
|LogicalName|workflowdependency|
|OwnershipType|None|
|PrimaryIdAttribute|workflowdependencyid|
|PrimaryNameAttribute||
|SchemaName|WorkflowDependency|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [CustomEntityName](#BKMK_CustomEntityName)
- [DependentAttributeName](#BKMK_DependentAttributeName)
- [DependentEntityName](#BKMK_DependentEntityName)
- [EntityAttributes](#BKMK_EntityAttributes)
- [ParameterName](#BKMK_ParameterName)
- [ParameterType](#BKMK_ParameterType)
- [RelatedAttributeName](#BKMK_RelatedAttributeName)
- [RelatedEntityName](#BKMK_RelatedEntityName)
- [SdkMessageId](#BKMK_SdkMessageId)
- [Type](#BKMK_Type)
- [WorkflowDependencyId](#BKMK_WorkflowDependencyId)
- [WorkflowId](#BKMK_WorkflowId)


### <a name="BKMK_CustomEntityName"></a> CustomEntityName

|Property|Value|
|--------|-----|
|Description|Name of the entity used in the process.|
|DisplayName|Custom Entity|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|customentityname|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_DependentAttributeName"></a> DependentAttributeName

|Property|Value|
|--------|-----|
|Description|Name of the attribute used in the process.|
|DisplayName|Dependent Attribute Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|dependentattributename|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_DependentEntityName"></a> DependentEntityName

|Property|Value|
|--------|-----|
|Description|Name of the entity used in the process.|
|DisplayName|Dependent Entity Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|dependententityname|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_EntityAttributes"></a> EntityAttributes

|Property|Value|
|--------|-----|
|Description|Comma-separated list of attributes that will be passed to process instance.|
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|entityattributes|
|MaxLength|100000|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ParameterName"></a> ParameterName

|Property|Value|
|--------|-----|
|Description|Name of the process parameter.|
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|parametername|
|MaxLength|256|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ParameterType"></a> ParameterType

|Property|Value|
|--------|-----|
|Description|Fully qualified name of the CLR type of the local parameter.|
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|parametertype|
|MaxLength|256|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_RelatedAttributeName"></a> RelatedAttributeName

|Property|Value|
|--------|-----|
|Description|Attribute of the primary entity that specifies related entity.|
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|relatedattributename|
|MaxLength|256|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_RelatedEntityName"></a> RelatedEntityName

|Property|Value|
|--------|-----|
|Description|Name of the related entity.|
|DisplayName|Related Entity|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|relatedentityname|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_SdkMessageId"></a> SdkMessageId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the SDK message.|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|sdkmessageid|
|RequiredLevel|None|
|Targets|sdkmessage|
|Type|Lookup|


### <a name="BKMK_Type"></a> Type

|Property|Value|
|--------|-----|
|Description|Type of the process dependency.|
|DisplayName|Type|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|type|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### Type Options

|Value|Label|
|-----|-----|
|1|Sdk association|
|2|Local parameter|
|3|Primary entity|
|4|Primary entity - before SDK operation|
|5|Primary entity - after SDK operation|
|6|Related entity|
|7|Custom entity definition that workflow depends on|
|8|Attribute definition that workflow depends on|
|9|Argument Entity that workflow depends on|



### <a name="BKMK_WorkflowDependencyId"></a> WorkflowDependencyId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the process dependency.|
|DisplayName|Process Dependency|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|workflowdependencyid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_WorkflowId"></a> WorkflowId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the process with which the dependency is associated.|
|DisplayName|Process|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|workflowid|
|RequiredLevel|SystemRequired|
|Targets|workflow|
|Type|Lookup|

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
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningUser](#BKMK_OwningUser)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who created the process dependency.|
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
|Description|Date and time when the process dependency was created.|
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
|Description|Unique identifier of the delegate user who created the process dependency.|
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
|Description|Unique identifier of the user who last modified the process dependency.|
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
|Description|Date and time when the process dependency was last modified.|
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
|Description|Unique identifier of the delegate user who last modified the process dependency.|
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


### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user or team who owns the parent workflow instance.|
|DisplayName|Owner|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|ownerid|
|RequiredLevel|ApplicationRequired|
|Targets|systemuser,team|
|Type|Owner|


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


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

|Property|Value|
|--------|-----|
|Description|Unique identifier of the business unit that owns the process dependency.|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningbusinessunit|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_OwningUser"></a> OwningUser

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who owns the process dependency.|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owninguser|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
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


### <a name="BKMK_userentityinstancedata_workflowdependency"></a> userentityinstancedata_workflowdependency

Same as userentityinstancedata entity [userentityinstancedata_workflowdependency](userentityinstancedata.md#BKMK_userentityinstancedata_workflowdependency) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|userentityinstancedata|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|userentityinstancedata_workflowdependency|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [workflow_dependency_modifiedonbehalfby](#BKMK_workflow_dependency_modifiedonbehalfby)
- [workflow_dependency_createdonbehalfby](#BKMK_workflow_dependency_createdonbehalfby)
- [workflow_dependency_modifiedby](#BKMK_workflow_dependency_modifiedby)
- [sdkmessageid_workflow_dependency](#BKMK_sdkmessageid_workflow_dependency)
- [workflow_dependency_createdby](#BKMK_workflow_dependency_createdby)
- [workflow_dependencies](#BKMK_workflow_dependencies)


### <a name="BKMK_workflow_dependency_modifiedonbehalfby"></a> workflow_dependency_modifiedonbehalfby

See systemuser Entity [workflow_dependency_modifiedonbehalfby](systemuser.md#BKMK_workflow_dependency_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_workflow_dependency_createdonbehalfby"></a> workflow_dependency_createdonbehalfby

See systemuser Entity [workflow_dependency_createdonbehalfby](systemuser.md#BKMK_workflow_dependency_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_workflow_dependency_modifiedby"></a> workflow_dependency_modifiedby

See systemuser Entity [workflow_dependency_modifiedby](systemuser.md#BKMK_workflow_dependency_modifiedby) One-To-Many relationship.

### <a name="BKMK_sdkmessageid_workflow_dependency"></a> sdkmessageid_workflow_dependency

See sdkmessage Entity [sdkmessageid_workflow_dependency](sdkmessage.md#BKMK_sdkmessageid_workflow_dependency) One-To-Many relationship.

### <a name="BKMK_workflow_dependency_createdby"></a> workflow_dependency_createdby

See systemuser Entity [workflow_dependency_createdby](systemuser.md#BKMK_workflow_dependency_createdby) One-To-Many relationship.

### <a name="BKMK_workflow_dependencies"></a> workflow_dependencies

See workflow Entity [workflow_dependencies](workflow.md#BKMK_workflow_dependencies) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.workflowdependency?text=workflowdependency EntityType" />