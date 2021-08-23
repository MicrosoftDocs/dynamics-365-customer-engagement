---
title: "updateContext (JavaScript API Reference) for multi-session apps | MicrosoftDocs"
description: "Learn about the updateContext API for the multi-session apps such as Omnichannel for Customer Service and Customer Service workspace."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/25/2021
ms.topic: reference
---

# updateContext

Creates an app tab in a focused Session and returns the unique identifier of the created tab.

## Syntax

`Microsoft.Apm.createTab(tabInput).then(successCallback, errorCallback);`

## Parameters

| **Name**         | **Type** | **Required** | **Description**   |
|------------------|----------|--------------|-----------------------------------------------------------------------------------------------------------------------|
| tabInput            | AppTabInput   | Yes     | JSON input |
| successCallback  | Function | No           | A function to call when the tab is created. Unique identifier(TabId) of the created tab is returned in the response. |
| errorCallback    | Function | No           | A function to call when the operation fails. An object with the following properties will be passed:<br />**errorCode**: Number. The error code.<br />**message**: String. An error message describing the issue.|

The structure of the JSON `Input` parameter is shown below.

```json

```

## Returns

Promise string with the value as created tab ID.

## Example

```JavaScript

```

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
