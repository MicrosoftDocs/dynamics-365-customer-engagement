---
title: "Knowledge Article Template (msdyn_knowledgearticletemplate) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Knowledge Article Template (msdyn_knowledgearticletemplate) table/entity with Microsoft Dynamics 365."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Knowledge Article Template (msdyn_knowledgearticletemplate) table/entity reference

Organizational Knowledge Article Template for Internal and external creation of Knowledge Articles.

> [!NOTE]
> The Microsoft Dynamics 365 Knowledge Article Template (msdyn_knowledgearticletemplate) table extends the [Microsoft Dataverse Knowledge Article Template (msdyn_knowledgearticletemplate) table](/power-apps/developer/data-platform/reference/entities/msdyn_knowledgearticletemplate).


## Messages

The following table lists the messages for the Knowledge Article Template (msdyn_knowledgearticletemplate) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|



## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_msdyn_knowledgearticleimage_parentknowledgetemplateid"></a> msdyn_knowledgearticleimage_parentknowledgetemplateid

Many-To-One Relationship: [msdyn_knowledgearticleimage msdyn_knowledgearticleimage_parentknowledgetemplateid](msdyn_knowledgearticleimage.md#BKMK_msdyn_knowledgearticleimage_parentknowledgetemplateid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_knowledgearticleimage`|
|ReferencingAttribute|`msdyn_parententityrecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_knowledgearticleimage_parentknowledgetemplateid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.msdyn_knowledgearticletemplate?displayProperty=fullName>
