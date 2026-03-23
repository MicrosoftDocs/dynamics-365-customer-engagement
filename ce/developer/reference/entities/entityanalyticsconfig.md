---
title: "Entity Analytics Config (EntityAnalyticsConfig) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Entity Analytics Config (EntityAnalyticsConfig) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Entity Analytics Config (EntityAnalyticsConfig) table/entity reference (Microsoft Dynamics 365)

This entity contains information about which entities are enabled for Azure Data Lake Services integration

> [!NOTE]
> The Microsoft Dynamics 365 Entity Analytics Config (EntityAnalyticsConfig) table extends the [Microsoft Dataverse Entity Analytics Config (EntityAnalyticsConfig) table](/power-apps/developer/data-platform/reference/entities/entityanalyticsconfig).


## Messages

The following table lists the messages for the Entity Analytics Config (EntityAnalyticsConfig) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Customized columns/attributes

Microsoft Dynamics 365 modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_EntityDataSource"></a> EntityDataSource

Changes from [EntityDataSource (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/entityanalyticsconfig#BKMK_EntityDataSource)

|Property|Value|
|---|---|
|RequiredLevel|None|




### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.entityanalyticsconfig?displayProperty=fullName>
