---
title: "Retrieve and format rich messages  | Microsoft Docs"
description: "Learn about the MessageObject type used in the sendMessageToConversation method in Omnichannel JavaScript API."
ms.date: 10/03/2022
ms.topic: reference
author: gandhamm
ms.author: mgandham
manager: shujoshi
ms.reviewer: nenellim
---
# Retrieve and format rich messages

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

Because the Power Virtual Agents and Omnichannel for Customer Service platforms process rich messages differently, you'll need to modify the strings to get valid `MessageObject` type strings that can be sent via the `sendMessageToConversation` method to the conversation. You must process the rich message payload before sending it to the conversation, else the method will send the desired rich object payload in plain `String` format.

This articles describes how you can programmatically retrieve and format rich messages that can then be passed using the `MessageObject` type to the `sendMessageToConversation` method.

## Retrieve the rich message payload

1. In Dynamics 365, go to one of the apps, and perform the following steps.
   
   ### [Customer Service admin center](#tab/customerserviceadmincenter)
     
     1. In the site map, select **Productivity** in **Agent experience**.
     2. On the **Productivity** page, select **Manage** for **Rich messages**.

   ### [Omnichannel admin center](#tab/omnichanneladmincenter)

    - In the site map, select **Agent experience** in **Advanced settings**, and then select **Manage** for **Rich messages**.

1. From the list of all available list messages, select a rich message that you'd like to send to the conversation.

4. Select the **Details** tab and select **Copy** under the **Rich message JSON** field. 

You'll use this JSON value when you format the rich message types.

## Format rich messages

This section includes JSON samples for the rich message types available in the Apple Messages for Business channel in Omnichannel for Customer Service. More information: [Manage rich messages](../../../create-rich-messages.md)

> [!Note]
> You can't send rich messages of the Forms type to conversations.

### Apple Pay

```javascript
let applePayJSON = // <copy_and_paste_details_content>
applePayJSON.survey = { Questions: JSON.parse(applePayJSON.survey)[0].Questions, Answers: JSON.parse(applePayJSON.survey)[1].Answers };
applePayJSON.survey.Answers.AppleMessagesforBusinessJSON = JSON.parse(applePayJSON.survey.Answers.AppleMessagesforBusinessJSON);
applePayJSON.survey.Answers.AppleMessagesforBusinessJSON = JSON.stringify(applePayJSON.survey.Answers.AppleMessagesforBusinessJSON);
applePayJSON.survey = JSON.stringify(applePayJSON.survey);

// Can now send this payload using the API
Microsoft.Omnichannel.sendMessageToConversation(applePayJSON, false);

// Or take the JSON elsewhere for use in bringing your own logic
copy(applePayJSON);
```

### Authentication

```javascript
let authJSON = // <copy_and_paste_details_content>
authJSON.survey = { Questions: JSON.parse(authJSON.survey)[0].Questions, Answers: JSON.parse(authJSON.survey)[1].Answers };
authJSON.survey = JSON.stringify(authJSON.survey);

// Can now send this payload using the API
Microsoft.Omnichannel.sendMessageToConversation(authJSON, false);

// Or take the JSON elsewhere for use in bringing your own logic
copy(authJSON);
```

### Custom JSON (iMessage Application)

```javascript
let customJSON = // <copy_and_paste_details_content>
customJSON.survey = { Questions: JSON.parse(customJSON.survey)[0].Questions, Answers: JSON.parse(customJSON.survey)[1].Answers };
customJSON.survey.Answers.AppleMessagesforBusinessJSON = JSON.parse(customJSON.survey.Answers.AppleMessagesforBusinessJSON);
customJSON.survey.Answers.AppleMessagesforBusinessJSON = JSON.stringify(customJSON.survey.Answers.AppleMessagesforBusinessJSON);
customJSON.survey = JSON.stringify(customJSON.survey);

// Can now send this payload using the API
Microsoft.Omnichannel.sendMessageToConversation(customJSON, false);

// Or take the JSON elsewhere for use in bringing your own logic
copy(customJSON);
```

### List Picker

```javascript
listPickerJSON = // <copy_and_paste_details_content>
listPickerJSON.survey = { Questions: JSON.parse(lpFromDetails.survey)[0].Questions, Answers: JSON.parse(listPickerJSON.survey)[1].Answers };
listPickerJSON.survey = JSON.stringify(listPickerJSON.survey);

// Can now send this payload using the API
Microsoft.Omnichannel.sendMessageToConversation(listPickerJSON, false);

// Or take the JSON elsewhere for use in bringing your own logic
copy(listPickerJSON);
```

### Suggested Reply

```javascript
suggestedReplyJSON = // <copy_and_paste_details_content>
suggestedReplyJSON.survey = { Questions: JSON.parse(suggestedReplyJSON.survey)[0].Questions, Answers: JSON.parse(suggestedReplyJSON.survey)[1].Answers };
suggestedReplyJSON.survey = JSON.stringify(suggestedReplyJSON.survey);

// Can now send this payload using the API
Microsoft.Omnichannel.sendMessageToConversation(suggestedReplyJSON, false);

// Or take the JSON elsewhere for use in bringing your own logic
copy(suggestedReplyJSON);
```

### Time Picker

```javascript
timePickerJSON = // <copy_and_paste_details_content>
timePickerJSON.survey = { Questions: JSON.parse(timePickerJSON.survey)[0].Questions, Answers: JSON.parse(timePickerJSON.survey)[1].Answers };
timePickerJSON.survey = JSON.stringify(timePickerJSON.survey);

// Can now send this payload using the API
Microsoft.Omnichannel.sendMessageToConversation(timePickerJSON, false);

// Or take the JSON elsewhere for use in bringing your own logic
copy(timePickerJSON);
```

### Video Rich Link

```javascript
videoRichLinkJSON = // <copy_and_paste_details_content>
videoRichLinkJSON.survey = { Questions: JSON.parse(videoRichLinkJSON.survey)[0].Questions, Answers: JSON.parse(videoRichLinkJSON.survey)[1].Answers };
timePickerJSON.survey = JSON.stringify(videoRichLinkJSON.survey);

// Can now send this payload using the API
Microsoft.Omnichannel.sendMessageToConversation(videoRichLinkJSON, false);

// Or take the JSON elsewhere for use in bringing your own logic
copy(videoRichLinkJSON);
```

### Website Rich Link

```javascript
websiteRichLinkJSON = // <copy_and_paste_details_content>
websiteRichLinkJSON.survey = { Questions: JSON.parse(websiteRichLinkJSON.survey)[0].Questions, Answers: JSON.parse(websiteRichLinkJSON.survey)[1].Answers };
timePickerJSON.survey = JSON.stringify(websiteRichLinkJSON.survey);

// Can now send this payload using the API
Microsoft.Omnichannel.sendMessageToConversation(websiteRichLinkJSON, false);

// Or take the JSON elsewhere for use in bringing your own logic
copy(websiteRichLinkJSON);
```

### See also

[Live chat SDK JavaScript API reference](../../omnichannel-reference.md)  
[Omnichannel JavaScript API reference](../../omnichannel-api-reference.md)  
[sendMessageToConversation](sendMessageToConversation.md)  

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]