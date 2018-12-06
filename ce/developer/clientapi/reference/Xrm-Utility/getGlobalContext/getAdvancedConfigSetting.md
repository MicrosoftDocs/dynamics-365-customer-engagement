---
title: "getAdvancedConfigSetting (Client API reference) in Dynamics 365 for Customer Engagement| MicrosoftDocs"
ms.date: 10/31/2017
ms.service: crm-online
ms.topic: reference
applies_to: Dynamics 365 for Customer Engagement (online)
ms.assetid: 89123cde-7c66-4c7d-94e4-e287285019f8
author: KumarVivek
ms.author: kvivek
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# getAdvancedConfigSetting (Client API reference)

[!INCLUDE[](../../../../../includes/cc_applies_to_update_9_0_0.md)]

Returns information about the advanced configuration settings for the organization. 

## Syntax

```JavaScript
var globalContext = Xrm.Utility.getGlobalContext();
globalContext.getAdvancedConfigSetting(setting);
```

## Parameters

|Name |Type |Required |Description |
|---|---|---|---|
|setting |String |Yes |Name of the configuration setting. <br/>Only the following two configuration settings are supported: **"MaxChildIncidentNumber"** and **"MaxIncidentMergeNumber"** |

## Return Value

Returns the advanced configuration setting value.

### Related topics

[Xrm.Utility.getGlobalContext](../getGlobalContext.md)



