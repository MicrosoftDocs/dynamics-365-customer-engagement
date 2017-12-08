---
title: "AzureServiceConnection Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the AzureServiceConnection entity."
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
# AzureServiceConnection Entity Reference

Stores connection information for an Azure service


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/azureserviceconnections<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/azureserviceconnections(*azureserviceconnectionid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/azureserviceconnections(*azureserviceconnectionid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/azureserviceconnections<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|Update|PATCH [*org URI*]/api/data/v9.0/azureserviceconnections(*azureserviceconnectionid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|AzureServiceConnections|
|DisplayCollectionName|Azure Service Connections|
|DisplayName|Azure Service Connection|
|EntitySetName|azureserviceconnections|
|IsBPFEntity|False|
|LogicalCollectionName|azureserviceconnections|
|LogicalName|azureserviceconnection|
|OwnershipType|OrganizationOwned|
|PrimaryIdAttribute|azureserviceconnectionid|
|PrimaryNameAttribute|name|
|SchemaName|AzureServiceConnection|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [AccountKey](#BKMK_AccountKey)
- [AzureServiceConnectionId](#BKMK_AzureServiceConnectionId)
- [ConnectionType](#BKMK_ConnectionType)
- [Description](#BKMK_Description)
- [LastConnectionStatusCode](#BKMK_LastConnectionStatusCode)
- [LastConnectionTime](#BKMK_LastConnectionTime)
- [Name](#BKMK_Name)
- [ServiceUri](#BKMK_ServiceUri)
- [StateCode](#BKMK_StateCode)
- [StatusCode](#BKMK_StatusCode)


### <a name="BKMK_AccountKey"></a> AccountKey

|Property|Value|
|--------|-----|
|Description|Type the Azure account key.|
|DisplayName|Azure Account Key|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|accountkey|
|MaxLength|100|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_AzureServiceConnectionId"></a> AzureServiceConnectionId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the Azure service connection.|
|DisplayName|Azure Service Connection|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|azureserviceconnectionid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_ConnectionType"></a> ConnectionType

|Property|Value|
|--------|-----|
|Description|Azure service connection type|
|DisplayName|Connection Type|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|connectiontype|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|

#### ConnectionType Options

|Value|Label|
|-----|-----|
|1|Recommendation|
|2|Text Analytics|



### <a name="BKMK_Description"></a> Description

|Property|Value|
|--------|-----|
|Description|Enter a description of the Azure service connection.|
|DisplayName|Description|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|description|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_LastConnectionStatusCode"></a> LastConnectionStatusCode

|Property|Value|
|--------|-----|
|Description|Shows the status of the last connection to the Azure service.|
|DisplayName|Last Connection Status|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|lastconnectionstatuscode|
|RequiredLevel|None|
|Type|Picklist|

#### LastConnectionStatusCode Options

|Value|Label|
|-----|-----|
|1|Success|
|2|Failure|



### <a name="BKMK_LastConnectionTime"></a> LastConnectionTime

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|shows the time of the last connection to the Azure service.|
|DisplayName|Last Connection Time|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|lastconnectiontime|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_Name"></a> Name

|Property|Value|
|--------|-----|
|Description|Type a logical name for the connection.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|name|
|MaxLength|160|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_ServiceUri"></a> ServiceUri

|Property|Value|
|--------|-----|
|Description|Type the service URL for the Azure service.|
|DisplayName|Azure Service URL|
|FormatName|Url|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|serviceuri|
|MaxLength|500|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_StateCode"></a> StateCode

|Property|Value|
|--------|-----|
|Description|Shows whether the Azure service connection is active or inactive.|
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
|0|Active|1|Active|
|1|Inactive|2|Inactive|



### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|--------|-----|
|Description|Select the Azure service connection's status.|
|DisplayName|Status Reason|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### StatusCode Options

|Value|Label|State|
|-----|-----|-----|
|1|Active|0|
|2|Inactive|1|


<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [OrganizationId](#BKMK_OrganizationId)
- [OrganizationIdName](#BKMK_OrganizationIdName)


### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who created the Azure service connection.|
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


### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the Azure service connection was created.|
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
|Description|Unique identifier of the delegate user who created the Azure service connection.|
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
|Description|Unique identifier of the user who modified the Azure service connection.|
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


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the Azure service connection was last modified.|
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
|Description|Unique identifier of the delegate user who last modified the Azure service connection.|
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
|Description|Unique identifier of the organization associated with the Azure service connection.|
|DisplayName|Organization|
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

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [azureserviceconnection_topicmodel](#BKMK_azureserviceconnection_topicmodel)
- [azureserviceconnection_knowledgesearchmodel](#BKMK_azureserviceconnection_knowledgesearchmodel)
- [azureserviceconnection_advancedsimilarityrule](#BKMK_azureserviceconnection_advancedsimilarityrule)


### <a name="BKMK_azureserviceconnection_topicmodel"></a> azureserviceconnection_topicmodel

Same as topicmodel entity [azureserviceconnection_topicmodel](topicmodel.md#BKMK_azureserviceconnection_topicmodel) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|topicmodel|
|ReferencingAttribute|azureserviceconnectionid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|azureserviceconnection_topicmodel|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_azureserviceconnection_knowledgesearchmodel"></a> azureserviceconnection_knowledgesearchmodel

Same as knowledgesearchmodel entity [azureserviceconnection_knowledgesearchmodel](knowledgesearchmodel.md#BKMK_azureserviceconnection_knowledgesearchmodel) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|knowledgesearchmodel|
|ReferencingAttribute|azureserviceconnectionid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|azureserviceconnection_knowledgesearchmodel|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_azureserviceconnection_advancedsimilarityrule"></a> azureserviceconnection_advancedsimilarityrule

Same as advancedsimilarityrule entity [azureserviceconnection_advancedsimilarityrule](advancedsimilarityrule.md#BKMK_azureserviceconnection_advancedsimilarityrule) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|advancedsimilarityrule|
|ReferencingAttribute|azureserviceconnectionid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|azureserviceconnection_advancedsimilarityrule|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_azureserviceconnection_modifiedonbehalfby](#BKMK_lk_azureserviceconnection_modifiedonbehalfby)
- [lk_azureserviceconnection_modifiedby](#BKMK_lk_azureserviceconnection_modifiedby)
- [lk_azureserviceconnection_createdby](#BKMK_lk_azureserviceconnection_createdby)
- [lk_azureserviceconnection_createdonbehalfby](#BKMK_lk_azureserviceconnection_createdonbehalfby)
- [organization_azureserviceconnection](#BKMK_organization_azureserviceconnection)


### <a name="BKMK_lk_azureserviceconnection_modifiedonbehalfby"></a> lk_azureserviceconnection_modifiedonbehalfby

See systemuser Entity [lk_azureserviceconnection_modifiedonbehalfby](systemuser.md#BKMK_lk_azureserviceconnection_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_azureserviceconnection_modifiedby"></a> lk_azureserviceconnection_modifiedby

See systemuser Entity [lk_azureserviceconnection_modifiedby](systemuser.md#BKMK_lk_azureserviceconnection_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_azureserviceconnection_createdby"></a> lk_azureserviceconnection_createdby

See systemuser Entity [lk_azureserviceconnection_createdby](systemuser.md#BKMK_lk_azureserviceconnection_createdby) One-To-Many relationship.

### <a name="BKMK_lk_azureserviceconnection_createdonbehalfby"></a> lk_azureserviceconnection_createdonbehalfby

See systemuser Entity [lk_azureserviceconnection_createdonbehalfby](systemuser.md#BKMK_lk_azureserviceconnection_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_organization_azureserviceconnection"></a> organization_azureserviceconnection

See organization Entity [organization_azureserviceconnection](organization.md#BKMK_organization_azureserviceconnection) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.azureserviceconnection?text=azureserviceconnection EntityType" />