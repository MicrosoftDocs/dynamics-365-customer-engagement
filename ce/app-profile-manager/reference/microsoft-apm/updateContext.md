---
title: "updateContext context management API (JavaScript API Reference) for multi-session apps | MicrosoftDocs"
description: "Learn about the updateContext context management API for the multi-session apps such as Omnichannel for Customer Service and Customer Service workspace."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/25/2021
ms.topic: reference
---

# updateContext

Allows you to set the automation dictionary and enables providers to add, modify, and remove values of slugs; the updated values are then available for future macro invocations.

## Syntax

`Microsoft.Apm.getFocusedSession().updateContext(input);`

## Parameters

| Name             | Type     | Required | Description |
|------------------|----------|----------|---------------------------------------------|
| input            | object   | Yes      | JSON input properties of the session context to be updated. |
<!--| successCallback  | Function | No           | A function to call when the tab is created. Unique identifier(TabId) of the created tab is returned in the response. |
| errorCallback    | Function | No           | A function to call when the operation fails. An object with the following properties will be passed:<br />**errorCode**: Number. The error code.<br />**message**: String. An error message describing the issue.|
-->


## Return value

None.

## Example

```JavaScript
Microsoft.Apm.getFocusedSession().updateContext({"customerName":"Contoso"});
```

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
