---
title: "getClientUrl (Client API reference) in Dynamics 365 for Customer Engagement apps | MicrosoftDocs"
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
# getClientUrl (Client API reference)

[!INCLUDE[](../../../../../includes/cc_applies_to_update_9_0_0.md)]

Returns the base URL that was used to access the application.

## Syntax

```JavaScript
var globalContext = Xrm.Utility.getGlobalContext();
globalContext.getClientUrl();
``` 

## Return Value

**Type**: String

**Description**: The values returned will resemble those listed in the following table.


|             Value              |                                    Client                                     |
|--------------------------------|-------------------------------------------------------------------------------|
| https://[org].crm.dynamics.com |                   Dynamics 365 for Customer Engagement apps                   |
|    http(s)://[server]/[org]    |                Dynamics 365 for Customer Engagement (on-premises) apps                |
|     http://localhost:2525      | Dynamics 365 for Outlook with Offline Access when offline |

### Related topics

[Xrm.Utility.getGlobalContext](../getGlobalContext.md)