---
title: "MessageObject in Omnichannel JavaScript API Reference | Microsoft Docs"
description: "Learn abou the MessageObject in Omnichannel JavaScript API Reference."
ms.date: 10/01/2022
ms.topic: reference
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.reviewer: nenellim
---
# MessageObject

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

The following MessageObject can be used via the [sendMessageToConversation](sendMessageToConversation.md) method to allow the user to send rich messages directly within an open conversation within the Omnichannel for Customer Service app.

Because Power Virtual Agents and Omnichannel for Customer Service platforms handle rich message processing differently, some string modification is necessary to get valid MessageObject strings that can be sent via the `sendMessageToConversation` method in the JavaScript Agent SDK. 

> [!Note]
> - You must process the rich message payload before sending the rich messages to conversation, otherwise the method will send the desired rich object payload in String format.
> - Sending the Forms rich message is not currently supported.

## Retrieve the rich message payload

1. Open Customer Service admin center with a Dynamics 365 user that has the Omnichannel Administrator role configured.

2. Select **Productivity** under **Agent experience**, and then select **Manage** next to **Rich messages**. The list of all available list messages is displayed.

3. Select a rich message that you'd like to send using the Afterwards all of the organization's configured rich messages should be available, click the one which you would like to send using th `sendMessageToConversation` method.

4. Select the **Details** tab and select **Copy** under the **Rich message JSON** field. 

You'll use this value in the examples provided in the following section.

## Formatting

### Example 1: Apple Pay

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

### Example 2: Authentication

```javascript
let authJSON = // <copy_and_paste_details_content>
authJSON.survey = { Questions: JSON.parse(authJSON.survey)[0].Questions, Answers: JSON.parse(authJSON.survey)[1].Answers };
authJSON.survey = JSON.stringify(authJSON.survey);

// Can now send this payload using the API
Microsoft.Omnichannel.sendMessageToConversation(authJSON, false);

// Or take the JSON elsewhere for use in bringing your own logic
copy(authJSON);
```

### Example 3: Custom JSON (iMessage Application)

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

### Example 4: List picker

```javascript
listPickerJSON = // <copy_and_paste_details_content>
listPickerJSON.survey = { Questions: JSON.parse(lpFromDetails.survey)[0].Questions, Answers: JSON.parse(listPickerJSON.survey)[1].Answers };
listPickerJSON.survey = JSON.stringify(listPickerJSON.survey);

// Can now send this payload using the API
Microsoft.Omnichannel.sendMessageToConversation(listPickerJSON, false);

// Or take the JSON elsewhere for use in bringing your own logic
copy(listPickerJSON);
```

### Example 5: Suggested reply

```javascript
suggestedReplyJSON = // <copy_and_paste_details_content>
suggestedReplyJSON.survey = { Questions: JSON.parse(suggestedReplyJSON.survey)[0].Questions, Answers: JSON.parse(suggestedReplyJSON.survey)[1].Answers };
suggestedReplyJSON.survey = JSON.stringify(suggestedReplyJSON.survey);

// Can now send this payload using the API
Microsoft.Omnichannel.sendMessageToConversation(suggestedReplyJSON, false);

// Or take the JSON elsewhere for use in bringing your own logic
copy(suggestedReplyJSON);
```

### Example 6: Time picker

```javascript
timePickerJSON = // <copy_and_paste_details_content>
timePickerJSON.survey = { Questions: JSON.parse(timePickerJSON.survey)[0].Questions, Answers: JSON.parse(timePickerJSON.survey)[1].Answers };
timePickerJSON.survey = JSON.stringify(timePickerJSON.survey);

// Can now send this payload using the API
Microsoft.Omnichannel.sendMessageToConversation(timePickerJSON, false);

// Or take the JSON elsewhere for use in bringing your own logic
copy(timePickerJSON);
```

### Example 7: Video rich link

```javascript
videoRichLinkJSON = // <copy_and_paste_details_content>
videoRichLinkJSON.survey = { Questions: JSON.parse(videoRichLinkJSON.survey)[0].Questions, Answers: JSON.parse(videoRichLinkJSON.survey)[1].Answers };
timePickerJSON.survey = JSON.stringify(videoRichLinkJSON.survey);

// Can now send this payload using the API
Microsoft.Omnichannel.sendMessageToConversation(videoRichLinkJSON, false);

// Or take the JSON elsewhere for use in bringing your own logic
copy(videoRichLinkJSON);
```

### Example 8: Website rich link

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
[sendMessageToConversation](reference/methods/sendMessageToConversation.md)

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]