---
title: "updateConversation (JavaScript API Reference) for Dynamics 365 Channel Integration Framework version 2.0 | MicrosoftDocs"
description: ""
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 02/13/2020
ms.topic: reference
ms.service: dynamics-365-customerservice
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---
# updateConversation

This method allows you to update a Conversation([msdyn_ocliveworkitem](../../../../../omnichannel/developer/reference/entities/msdyn_ocliveworkitem.md)) record.

## Syntax

`Microsoft.CIFramework.updateConversation(id, data, correlationId).then(successCallback, errorCallback)`

## Parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `id` | String(GUID) | Yes | Unique identifier of the conversation returned by `Microsoft.CIFramework.getSession` API.|
| `data` | Object | Yes | A JSON object containing key-value pairs, where key is the property of the entity and value is the value of the property you want to update in [msdyn_ocliveworkitem](https://docs.microsoft.com/dynamics365/omnichannel/developer/reference/entities/msdyn_ocliveworkitem) entity.|

## Example

```javascript
var data = {
    "subject": "Troubleshooting printer malfunction",
    "prioritycode": 2
}
var conversationId = "05145e77-ce40-ea11-a812-000d3a579805";
var jsonData = JSON.stringify(data);
Microsoft.CIFramework.updateConversation(conversationId, jsonData).then(
    function success (response) {
        var result = JSON.parse(response);
        console.log("Conversation updated with ID: " + result.id);
        //the Conversation is updated
      },
      function (error) {
          console.log(error);
          //handle errors
      }
  );
```


[!INCLUDE[footer-include](../../../../../includes/footer-banner.md)]