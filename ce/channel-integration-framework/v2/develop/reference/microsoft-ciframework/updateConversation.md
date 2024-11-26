---
title: "updateConversation (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0 | MicrosoftDocs"
description: "Learn about updateConversation (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0."
ms.date: 11/18/2022
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---
# updateConversation (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0

This method allows you to update a Conversation([msdyn_ocliveworkitem](/dynamics365/customer-service/developer/reference/entities/msdyn_ocliveworkitem)) record.

## Syntax

`Microsoft.CIFramework.updateConversation(id, data, correlationId).then(successCallback, errorCallback)`

## Parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `id` | String(GUID) | Yes | Unique identifier of the conversation returned by `Microsoft.CIFramework.getSession` API.|
| `data` | Object | Yes | A JSON object containing key-value pairs, where key is the property of the entity and value is the value of the property you want to update in [msdyn_ocliveworkitem](/dynamics365/customer-service/developer/reference/entities/msdyn_ocliveworkitem) entity.|

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
