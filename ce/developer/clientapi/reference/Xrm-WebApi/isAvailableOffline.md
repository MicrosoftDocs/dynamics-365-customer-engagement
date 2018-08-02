---
title: "isAvailableOffline (Client API reference) in Dynamics 365 Customer Engagement| MicrosoftDocs"
ms.date: 12/18/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: "Dynamics 365 (online)"
ms.assetid: ea9eacc0-2e31-49f4-a329-dcdf430a5a7e
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# isAvailableOffline (Client API reference)

[!INCLUDE[](../../../../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[./includes/isAvailableOffline-description.md](./includes/isAvailableOffline-description.md)] 

## Syntax

`Xrm.WebApi.offline.isAvailableOffline(entityLogicalName);`

## Parameters

<table style="width:100%">
<tr>
<th>Name</th>
<th>Type</th>
<th>Required</th>
<th>Description</th>
</tr>
<tr>
<td>entityLogicalName</td>
<td>String</td>
<td>Yes</td>
<td>Logical name of the entity. For example: &quot;account&quot;.</td>
</tr>

</table>

## Return Value

**Type**: Boolean.

**Description**: true if the entity is present in user’s profile and is currently available for use in offline mode; otherwise false.

[Xrm.WebApi.offline](offline.md)

[Xrm.WebApi](../xrm-webapi.md)




