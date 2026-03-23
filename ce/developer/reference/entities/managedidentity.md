---
title: "Managed Identity (ManagedIdentity) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Managed Identity (ManagedIdentity) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Managed Identity (ManagedIdentity) table/entity reference (Microsoft Dynamics 365)

Contains data to represent an Azure Active Directory Application used to connect to secure web-hosted resources.

> [!NOTE]
> The Microsoft Dynamics 365 Managed Identity (ManagedIdentity) table extends the [Microsoft Dataverse Managed Identity (ManagedIdentity) table](/power-apps/developer/data-platform/reference/entities/managedidentity).


## Messages

The following table lists the messages for the Managed Identity (ManagedIdentity) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Customized columns/attributes

Microsoft Dynamics 365 modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_IdentityType"></a> IdentityType

Changes from [IdentityType (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/managedidentity#BKMK_IdentityType)

|Property|Value|
|---|---|
|RequiredLevel|None|




### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.managedidentity?displayProperty=fullName>
