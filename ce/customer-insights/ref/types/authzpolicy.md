---
title: AuthorizationPolicy Type Definition (Microsoft Dynamics 365 for Customer Insights) | MicrosoftDocs
description: Shared Access Signature (SAS) is a security technology that allows granting limited access rights to a secured resource.
keywords: Customer Insights; type; Authorization policy; Shared Access Signature (SAS)
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 07/26/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 35d30272-51cf-4701-9a21-b07252af1e3f
---

AuthorizationPolicy Type Definition
===============================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Customer Insights supports authorization (authZ) through the use of Shared Access Signatures (SAS). SAS is a security technology that allows granting limited access rights to a secured, Azure-based resource. These rights are represented by a URI that encompasses in its query parameters all of the information necessary for authenticated access to the specified resource. Customer Insights applications often use SAS to gain limited access to blob storage. SAS provides for limits to resource access in the following ways:
* Granualr access to the allowed operations: query, read, create, update, delete, etc.
* The time period that the access is granted
* The range of IP addresses that the requests can originate from
* The internet protocol(s) used in the request

For more information about how SAS is used in Azure, see [Using Shared Access Signatures](https://docs.microsoft.com/azure/storage/storage-dotnet-shared-access-signature-part-1).

## Properties

Property names appended with asterisks* are required.

|**Property**|**JSON type**|**Description**|
| --------------- | ---------- | ------------- |
|policyName*|string|Name of the policy|
|permissions*|string[]|One or more permissions associated with the policy: [“Read” \| ”Write” \| ”Manage”]|
|primaryKey|string (base64)|Primary key associated with the policy|
|secondaryKey|string (base64)|Secondary key associated with the policy|


## JSON Example
```{json}
{ 
    "PolicyName":"TestPolicy2", 
    "Permissions":["Read", "Write"], 
    "PrimaryKey":"cHJpbWFyeVRlc3RSZWFk", 
    "SecondaryKey":"c2Vjb25kYXJ5VGVzdFJlYWQ=", 
}
```
