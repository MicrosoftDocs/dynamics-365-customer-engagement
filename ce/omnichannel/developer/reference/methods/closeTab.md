---
title: "closeTab (Omnichannel for Customer Service Session API reference) | MicrosoftDocs"
description: 
author: platkat
ms.author: ktaylor
manager: shujoshi
ms.date: 10/05/2020
ms.topic: article
---
# closeTab

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

Provides the functionality  to close a tab in the focused session. It expects the unique id of the tab as a parameter.

## Syntax

`Microsoft.Apm.closeTab(tabId);`

## Parameters

| Parameter | Type | Description |
| ---- | ---- | ---- |
| tabId | string | - Unique id of the tab to be closed | 

## Return Value

Boolean representing the close status of the tab.

## Example

```javascript
Microsoft.Apm.closeTab("tab-id-8").then((response)=>{
    console.log(response)
}, (error)=>{
    console.log(error)
});
```

## See also

[JavaScript API reference for live chat SDK](../../omnichannel-reference.md)
