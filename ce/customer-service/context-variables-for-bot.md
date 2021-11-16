---
title: "Configure context variables for a bot | MicrosoftDocs"
description: "Use this topic to understand how you can add context variables and then configure them for Azure or Power Virtual Agents bots in Omnichannel for Customer Service."
ms.date: 11/16/2021
ms.topic: article
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
---

# Configure context variables for a bot

[!INCLUDE[cc-data-platform-banner](../includes/cc-data-platform-banner.md)]

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

Context variables enrich conversations with pre-chat data, channel data, and custom context data. These attributes can then be used to define routing rules to route conversations to different queues. This topic lists the context variables and how you can configure them for Azure or Power Virtual Agents bots in Omnichannel for Customer Service.

## Considerations

Before you configure context variables for Azure or Power Virtual Agents bots, check for the following conditions:

 - The context variable names are used as is and not changed when you author flows in Azure or Power Virtual Agents bots.
 - Use exact match to pass the value to the context variable because it is case-sensitive. Also, the value must be 4,000 characters or less so that the conversation can be successfully escalated to agents.

## Add context variables

1. Select **Add context variable** in the **Advanced settings** section of a workstream.
2. In the **Edit** pane, select **Add**, and enter **Name**. Ensure that the length of the context variable names does not exceed 200 characters.
3. Select the **Type** of variable from the dropdown list. You can choose either **Text** or **Number**.
4. Repeat steps 2 and 3 to create the required variables.

> [!Note]
> If you create custom context variables, we recommend that you don't update or delete them. If you need to update or delete the variables, make sure that they aren't used in any of the unified routing classification or assignment rules.

## Context variables for Power Virtual Agents bots

The following table contains the list of context variables in Omnichannel for Customer Service that you can use for [configuring Power Virtual Agents bot](https://docs.microsoft.com/en-us/power-virtual-agents/configuration-hand-off-omnichannel#install-extension-solutions).

> [!Important]
> To be able to use the messaging and voice variables, ensure that you first [install the extension solutions](/power-virtual-agents/configuration-hand-off-omnichannel#install-extension-solutions).

| Context variable type | Context variable name | Description | How to map in Power Virtual Agents |
|-----------------------|  ---------------------| ----------- | -----------------------------------|
| [Pre-conversation survey](configure-pre-chat-survey.md) | Use the question type that you create in Omnichannel for Customer Service. | The context variables for pre-conversation answers store the customer answers for questions in the pre-conversation survey. | Use the following information to map the question type variable in Omnichannel for Customer Service with the variable type in Power Virtual Agents:<br><ul><li> **Single line**: User’s entire response</li>**Multiple lines**: User's entire response<li>**Option set**: User's entire response</li><li>**User Consent**: Boolean</li></ul> |
| [Custom context](send-context-starting-chat.md) | Use the variable name that you create in Omnichannel for Customer Service or pass using the setContextProvider API. | These are custom context variables that can be created and passed through the live chat SDK. | Use the following information to map the custom context variable in Omnichannel for Customer Service with the variable type in Power Virtual Agents: <br><ul><li> **String**: User's entire response </li> **Boolean**: Boolean <li> **Number**, **Floating Number**: Number |
| Conversation | msdyn_ConversationId | Use the context variable that contains the conversation ID for the ongoing conversation and can fetch and perform operations on the record in Microsoft Dataverse. | **String**: User's entire response.  |
|  Messaging and voice variables | msdyn_CustomerType   | Use this context variable that contains the customer type for the *account* or *contact* record that's linked to the conversation.    | Select the Omnichannel for Customer Service extension solution variable.|
|  | msdyn_CustomerName	| Use this context variable that contains the customer name for the *account* or *contact* record that's linked to the conversation. | Select the Omnichannel for Customer Service extension solution variable. |
|  | msdyn_CustomerId   | Use this context variable that contains the customer ID for the *account* or *contact* record that's linked to the conversation.   | Select the Omnichannel for Customer Service extension solution variable. |
|  | msdyn_CaseId | Use this context variable that contains the ID of the case record that's linked to the conversation.  | Select the Omnichannel for Customer Service extension solution variable.|
|  | msdyn_CaseTitle | Use this context variable that contains the title of the case record that's linked to the conversation.  | Select the Omnichannel for Customer Service extension solution variable. |
| Voice-only variables | CustomerPhoneNumber  | Use this context variable for the customer's phone number that's provided in the Telephony activity.  | Select the Omnichannel for Customer Service extension solution variable. |
|  | OrganizationPhoneNumber | Use this context variable for the organization's phone number that's provided in the Telephony activity.  | Select the Omnichannel for Customer Service extension solution variable. |
| Extension method name  |      va_SurveyConsent |   Use this dialog to determine if a customer has agreed to participate in surveys during the conversation. |  Use this method to escalate conversation details to Omnichannel for Customer Service.    |
| |  va_CustomerLocale |  Use this dialog to transfer the user talking to the bot to another bot that might speak in a different language.  | Set the code by selecting the input variable and using the correct locale code. For an example on how to set up this scenario, see [Configure the routing rule in Dynamics 365 for Customer Service](routing-rules.md) </br>.  |
|     |    |    |

## Context variables for Azure bots

The following table contains the list of context variables in Omnichannel for Customer Service that you can use for [configuring Azure bots](configure-bot.md).

| Context variable type | Context variable name | Description  | How to map in Azure |
|-----|-----|-------|-------|
| [Pre-conversation survey](configure-pre-chat-survey.md) | Use the question type that you create in Omnichannel for Customer Service. | The context variables for pre-conversation answers store the customer answers for questions in the pre-conversation survey. | Use the following information to map the question type variable in Omnichannel for Customer Service with the variable type in Azure:<br><ul><li> **Single line**: String</li>**Multiple lines**: String<li>**Option set**: String</li><li>**User Consent**: Boolean</li></ul>|
| [Custom context](send-context-starting-chat.md) | Use the variable name that you create in Omnichannel for Customer Service or pass using the setContextProvider API. | These are custom context variables that can be created and passed through the live chat SDK. | [Map the user's response as a JSON](display-custom-context.md) to use custom context variable in Omnichannel for Customer Service. |
| Conversation | msdyn_ConversationId  | Use the context variable that contains the conversation ID for the ongoing conversation and can fetch and perform operations on the record in Microsoft Dataverse. |**String**: String|
|[Contact](record-identification-rule.md) |msdyn_contact_msdyn_ocliveworkitem_Customer| Use this context variable that contains the record ID for the customer (contact) record that is linked to the conversation.    | [Parse JSON to extract record ID](#parse-json-object-to-extract-record-id)  |
| [Account](record-identification-rule.md) | msdyn_account_msdyn_ocliveworkitem_Customer | Use this context variable that contains the record ID for the account record linked to the conversation. | [Parse JSON to extract record ID](#parse-json-object-to-extract-record-id)|
| [Case](record-identification-rule.md) | msdyn_incident_msdyn_ocliveworkitem | Use this context variable that contains the record ID for the case record linked to the conversation.  | [Parse JSON to extract record ID](#parse-json-object-to-extract-record-id) |
||||

> [!Note]
> If there's a mismatch of any of the attributes such as phone number, email address, or case number for a record, then the record won't get automatically identified. More information: [Identify records automatically](record-identification-rule.md)

### Parse JSON object to extract record ID

Make sure that you have the following details:

- The Omnichannel for Customer Service context variable, such as msdyn_contact_msdyn_ocliveworkitem_Customer.
- The schema details.

A copy of the sample schema details is as follows:

```JavaScript
        Schema: 
        {
            "type": "array",
            "items": {
                "type": "object",
                "properties": {
                    "RecordId": {
                        "type": "string"
                    },
                    "PrimaryDisplayValue": {
                        "type": "string"
                    }
                },
                "required": [
                    "RecordId",
                    "PrimaryDisplayValue"
                ]
            }
        }
```

`PrimaryDisplayValue` will contain the value from the attribute in the Dataverse entities. The mapping for the entity attributes is as follows:

- **Cases:** Case title
- **Contacts:** Full name
- **Accounts:** Name

### See also

[Integrate a Power Virtual Agents bot](configure-bot-virtual-agent.md)  
[Integrate an Azure bot](configure-bot.md)  
[Live chat SDK JavaScript API Reference](developer/omnichannel-reference.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
