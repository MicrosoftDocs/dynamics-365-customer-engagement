---
title: "Virtual Resource Group Resource (virtualresourcegroupresource) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Virtual Resource Group Resource (virtualresourcegroupresource) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Virtual Resource Group Resource (virtualresourcegroupresource) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Virtual Resource Group Resource (virtualresourcegroupresource) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /virtualresourcegroupresources<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /virtualresourcegroupresources(*virtualresourcegroupresourceid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /virtualresourcegroupresources(*virtualresourcegroupresourceid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveEntityChanges`<br />Event: True | |<xref:Microsoft.Xrm.Sdk.Messages.RetrieveEntityChangesRequest>|
| `RetrieveMultiple`<br />Event: True |`GET` /virtualresourcegroupresources<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Update`<br />Event: True |`PATCH` /virtualresourcegroupresources(*virtualresourcegroupresourceid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /virtualresourcegroupresources(*virtualresourcegroupresourceid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Virtual Resource Group Resource (virtualresourcegroupresource) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Virtual Resource Group Resource** |
| **DisplayCollectionName** | **Virtual Resource Group Resources Collection** |
| **SchemaName** | `virtualresourcegroupresource` |
| **CollectionSchemaName** | `virtualresourcegroupresources` |
| **EntitySetName** | `virtualresourcegroupresources`|
| **LogicalName** | `virtualresourcegroupresource` |
| **LogicalCollectionName** | `virtualresourcegroupresources` |
| **PrimaryIdAttribute** | `virtualresourcegroupresourceid` |
| **PrimaryNameAttribute** |`name` |
| **TableType** | `Virtual` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [businessunit](#BKMK_businessunit)
- [constraintbasedgroupid](#BKMK_constraintbasedgroupid)
- [name](#BKMK_name)
- [resourceentitylogicalname](#BKMK_resourceentitylogicalname)
- [resourceentityname](#BKMK_resourceentityname)
- [resourcegroupId](#BKMK_resourcegroupId)
- [virtualresourcegroupresourceId](#BKMK_virtualresourcegroupresourceId)

### <a name="BKMK_businessunit"></a> businessunit

|Property|Value|
|---|---|
|Description||
|DisplayName|**Business Unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`businessunit`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_constraintbasedgroupid"></a> constraintbasedgroupid

|Property|Value|
|---|---|
|Description||
|DisplayName|**constraintbasedgroupid**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`constraintbasedgroupid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_name"></a> name

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_resourceentitylogicalname"></a> resourceentitylogicalname

|Property|Value|
|---|---|
|Description|**Entity type logical name of resource**|
|DisplayName|**Entity type logical name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`resourceentitylogicalname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_resourceentityname"></a> resourceentityname

|Property|Value|
|---|---|
|Description|**Entity type of resource**|
|DisplayName|**Entity Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`resourceentityname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_resourcegroupId"></a> resourcegroupId

|Property|Value|
|---|---|
|Description|**Unique identifier for Resource Group associated with virtualresourcegroupresource.**|
|DisplayName|**resourcegroup**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`resourcegroupid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|constraintbasedgroup|

### <a name="BKMK_virtualresourcegroupresourceId"></a> virtualresourcegroupresourceId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**virtualresourcegroupresource**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`virtualresourcegroupresourceid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_constraintbasedgroup_virtualresourceg"></a> constraintbasedgroup_virtualresourceg

One-To-Many Relationship: [constraintbasedgroup constraintbasedgroup_virtualresourceg](constraintbasedgroup.md#BKMK_constraintbasedgroup_virtualresourceg)

|Property|Value|
|---|---|
|ReferencedEntity|`constraintbasedgroup`|
|ReferencedAttribute|`constraintbasedgroupid`|
|ReferencingAttribute|`resourcegroupid`|
|ReferencingEntityNavigationPropertyName|`resourcegroupId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

