---
title: "getPrimaryAttributeValue (Client API reference) in Dynamics 365 for Customer Engagement| MicrosoftDocs"
ms.date: 10/31/2017
ms.service: crm-online
ms.topic: reference
applies_to: Dynamics 365 for Customer Engagement (online)
ms.assetid: 1a66f93d-a47c-4316-91f1-dcf5d09f9d19
author: KumarVivek
ms.author: kvivek
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# getPrimaryAttributeValue (Client API reference)

[!INCLUDE[](../../../../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[./includes/getPrimaryAttributeValue-description.md](./includes/getPrimaryAttributeValue-description.md)]

## Syntax

`formContext.data.entity.getPrimaryAttributeValue();`

## Return Value

**Type**: String.

**Description**: The name of the entity.

## Remarks

Each entity has one string attribute that is designated as the <xref:Microsoft.Xrm.Sdk.Metadata.EntityMetadata.PrimaryNameAttribute>. The value for this attribute is used when links to the record are displayed.



