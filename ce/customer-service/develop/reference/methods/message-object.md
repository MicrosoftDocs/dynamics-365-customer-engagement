---
title: Retrieve and format rich messages
description: Learn about the MessageObject type used in the sendMessageToConversation method in Omnichannel JavaScript API.
ms.date: 10/10/2025
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
---

# Retrieve and format rich messages

[!INCLUDE[pva-rebrand](../../../../includes/cc-pva-rebrand.md)]

The Copilot Studio and Dynamics 365 for Customer Service platforms differ slightly in how they support rich media messages based on channel and rich media message type. This article describes how you can support rich media messages in Copilot Studio.

## Retrieve bot JSON for Apple Messages for Business

1. In the site map of Copilot Service admin center, select **Productivity** in **Agent experience**.
1. On the **Productivity** page, select **Manage** for **Rich messages**.
1. From the list of all available list messages, select a rich message that you'd like to send to the conversation.
1. For Apple Messages for Business rich messages, use the **Microsoft.Omnichannel.sendMessageToConversation** API to send JSON files.
 
## Retrieve bot JSON for Live Chat forms, Live Chat custom JSON, and WhatsApp suggested replies

1. In the site map of Copilot Service admin center, select **Productivity** in **Agent experience**.
1. On the **Productivity** page, select **Manage** for **Rich messages**.
1. Find the rich media message you want a bot to send, and if it has JSON available, it appears under the **Copilot Studio Bot JSON** column. Select **View JSON**, and the specific channel type to copy the JSON.

  IMAGE COMING SOON

1. For Live Chat and WhatsApp rich media templates, you can paste the JSON directly into an adaptive card node in Copilot Studio.
   
## JSON samples for rich messages for Apple Messages for Business

This section includes JSON samples for the rich message types available in the Apple Messages for Business channel in Omnichannel for Customer Service. More information: [Manage rich messages](../../../administer/create-rich-messages.md)

> [!Note]
> You can't send Forms type rich messages to conversations.

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

### Suggested reply

```javascript
suggestedReplyJSON = // <copy_and_paste_details_content>
suggestedReplyJSON.survey = { Questions: JSON.parse(suggestedReplyJSON.survey)[0].Questions, Answers: JSON.parse(suggestedReplyJSON.survey)[1].Answers };
suggestedReplyJSON.survey = JSON.stringify(suggestedReplyJSON.survey);

// Can now send this payload using the API
Microsoft.Omnichannel.sendMessageToConversation(suggestedReplyJSON, false);

// Or take the JSON elsewhere for use in bringing your own logic
copy(suggestedReplyJSON);
```

### Time picker

```javascript
timePickerJSON = // <copy_and_paste_details_content>
timePickerJSON.survey = { Questions: JSON.parse(timePickerJSON.survey)[0].Questions, Answers: JSON.parse(timePickerJSON.survey)[1].Answers };
timePickerJSON.survey = JSON.stringify(timePickerJSON.survey);

// Can now send this payload using the API
Microsoft.Omnichannel.sendMessageToConversation(timePickerJSON, false);

// Or take the JSON elsewhere for use in bringing your own logic
copy(timePickerJSON);
```

### Video rich link

```javascript
videoRichLinkJSON = // <copy_and_paste_details_content>
videoRichLinkJSON.survey = { Questions: JSON.parse(videoRichLinkJSON.survey)[0].Questions, Answers: JSON.parse(videoRichLinkJSON.survey)[1].Answers };
timePickerJSON.survey = JSON.stringify(videoRichLinkJSON.survey);

// Can now send this payload using the API
Microsoft.Omnichannel.sendMessageToConversation(videoRichLinkJSON, false);

// Or take the JSON elsewhere for use in bringing your own logic
copy(videoRichLinkJSON);
```

### Website rich link

```javascript
websiteRichLinkJSON = // <copy_and_paste_details_content>
websiteRichLinkJSON.survey = { Questions: JSON.parse(websiteRichLinkJSON.survey)[0].Questions, Answers: JSON.parse(websiteRichLinkJSON.survey)[1].Answers };
timePickerJSON.survey = JSON.stringify(websiteRichLinkJSON.survey);

// Can now send this payload using the API
Microsoft.Omnichannel.sendMessageToConversation(websiteRichLinkJSON, false);

// Or take the JSON elsewhere for use in bringing your own logic
copy(websiteRichLinkJSON);
```
## Configure bots to send Live Chat suggested replies and cards/carousels

Copilot Studio supports suggested replies and basic cards out of the box. Learn more in [Send a message - Microsoft Copilot Studio](../microsoft-copilot-studio/authoring-send-message).

> [!Note]
> Copilot Studio refers to suggested replies as quick replies.

### Related information

[Live chat SDK JavaScript API reference](../../omnichannel-reference.md)  
[Omnichannel JavaScript API reference](../../omnichannel-api-reference.md)  
[sendMessageToConversation](sendMessageToConversation.md)  

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
