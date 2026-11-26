---
title: "Sdk Message Processing Step (SdkMessageProcessingStep) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Sdk Message Processing Step (SdkMessageProcessingStep) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Sdk Message Processing Step (SdkMessageProcessingStep) table/entity reference (Microsoft Dynamics 365)

Stage in the execution pipeline that a plug-in is to execute.

> [!NOTE]
> The Microsoft Dynamics 365 Sdk Message Processing Step (SdkMessageProcessingStep) table extends the [Microsoft Dataverse Sdk Message Processing Step (SdkMessageProcessingStep) table](/power-apps/developer/data-platform/reference/entities/sdkmessageprocessingstep).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_msdynmkt_sdkmessageprocessingstep_eventmetadata_sd"></a> msdynmkt_sdkmessageprocessingstep_eventmetadata_sd

Many-To-One Relationship: [msdynmkt_eventmetadata_sdkmessageprocessingstep msdynmkt_sdkmessageprocessingstep_eventmetadata_sd](msdynmkt_eventmetadata_sdkmessageprocessingstep.md#BKMK_msdynmkt_sdkmessageprocessingstep_eventmetadata_sd)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_eventmetadata_sdkmessageprocessingstep`|
|ReferencingAttribute|`msdynmkt_sdkmessageprocessingstepid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_sdkmessageprocessingstep_eventmetadata_sd`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.sdkmessageprocessingstep?displayProperty=fullName>
