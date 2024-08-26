---
title: "Knowledge Article Image (msdyn_knowledgearticleimage) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Knowledge Article Image (msdyn_knowledgearticleimage) table/entity with Microsoft Dynamics 365."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Knowledge Article Image (msdyn_knowledgearticleimage) table/entity reference



> [!NOTE]
> The Microsoft Dynamics 365 Knowledge Article Image (msdyn_knowledgearticleimage) table extends the [Microsoft Dataverse Knowledge Article Image (msdyn_knowledgearticleimage) table](/power-apps/developer/data-platform/reference/entities/msdyn_knowledgearticleimage).


## Messages

The following table lists the messages for the Knowledge Article Image (msdyn_knowledgearticleimage) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|


## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

### <a name="BKMK_msdyn_parententityrecordidIdType"></a> msdyn_parententityrecordidIdType

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_parententityrecordididtype`|
|RequiredLevel|None|
|Type|EntityName|


## Customized columns/attributes

Microsoft Dynamics 365 modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_msdyn_ParentEntityRecordID"></a> msdyn_ParentEntityRecordID

Changes from [msdyn_ParentEntityRecordID (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/msdyn_knowledgearticleimage#BKMK_msdyn_ParentEntityRecordID)

|Property|Value|
|---|---|
|Targets|msdyn_knowledgearticletemplate|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_msdyn_knowledgearticleimage_parentknowledgetemplateid"></a> msdyn_knowledgearticleimage_parentknowledgetemplateid

One-To-Many Relationship: [msdyn_knowledgearticletemplate msdyn_knowledgearticleimage_parentknowledgetemplateid](msdyn_knowledgearticletemplate.md#BKMK_msdyn_knowledgearticleimage_parentknowledgetemplateid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_knowledgearticletemplate`|
|ReferencedAttribute|`msdyn_knowledgearticletemplateid`|
|ReferencingAttribute|`msdyn_parententityrecordid`|
|ReferencingEntityNavigationPropertyName|`msdyn_parententityrecordid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.msdyn_knowledgearticleimage?displayProperty=fullName>
