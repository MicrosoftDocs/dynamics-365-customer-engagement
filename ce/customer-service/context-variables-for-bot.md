---
title: "Configure context variables for bots | MicrosoftDocs"
description: "Use this topic to understand how you can add context variables and then configure them for Azure or Power Virtual Agents bots in Omnichannel for Customer Service."
ms.date: 08/30/2022
ms.topic: article
author: neeranelli
ms.author: nenellim
ms.collection: get-started
---

# Configure context variables for bots

This article lists the context variables for Azure and Power Virtual Agents bots, and how you can configure them in Omnichannel for Customer Service. To understand how to create context variables, see [Manage context variables](manage-context-variables.md).

## Context variables for Azure bots

The following table contains the list of context variables in Omnichannel for Customer Service that you can use for [configuring Azure bots](configure-bot-azure.md).

| Context variable type | Context variable name | Description  | How to map in Azure |
|-----|-----|-------|-------|
| [Pre-conversation survey](configure-pre-chat-survey.md) | Use the question type that you create in Omnichannel for Customer Service. | The context variables for pre-conversation answers store the customer answers for questions in the pre-conversation survey. | Use the following information to map the question type variable in Omnichannel for Customer Service with the variable type in Azure:<br><ul><li> **Single line**: String</li>**Multiple lines**: String<li>**Option set**: String</li><li>**User Consent**: Boolean</li></ul>|
| [Custom context](send-context-starting-chat.md) | Use the variable name that you create in Omnichannel for Customer Service or pass using the setContextProvider API. | These are custom context variables that can be created and passed through the live chat SDK. | [Map the user's response as a JSON](display-custom-context.md) to use custom context variable in Omnichannel for Customer Service. |
| Conversation | msdyn_ConversationId  | Use the context variable that contains the conversation ID for the ongoing conversation and can fetch and perform operations on the record in Microsoft Dataverse. |**String**: String|
|[Contact](record-identification-rule.md) | msdyn_contact_msdyn_ocliveworkitem_Customer | Use this context variable that contains the record ID for the customer (contact) record that is linked to the conversation.    | [Parse JSON to extract record ID](#parse-json-object-to-extract-record-id)  |
| [Account](record-identification-rule.md) | msdyn_account_msdyn_ocliveworkitem_Customer | Use this context variable that contains the record ID for the account record linked to the conversation. | [Parse JSON to extract record ID](#parse-json-object-to-extract-record-id)|
| [Case](record-identification-rule.md) | msdyn_incident_msdyn_ocliveworkitem | Use this context variable that contains the record ID for the case record linked to the conversation.  | [Parse JSON to extract record ID](#parse-json-object-to-extract-record-id) |
||||

> [!Note]
> Use the context variable names as defined and don't change them when you author flows in Azure or Power Virtual Agents bots. Also, be sure to use exact match to pass the value to the context variable because it is case-sensitive. If there's a mismatch, the record won't get automatically identified. More information: [Identify records automatically](record-identification-rule.md)

## Context variables for Power Virtual Agents bots

The following table contains the list of context variables available in Omnichannel for Customer Service that you can use for [configuring Power Virtual Agents bots](configure-bot-virtual-agent.md).

> [!Important]
> To be able to use the messaging and voice variables, ensure that you first [install the extension solutions](/power-virtual-agents/configuration-hand-off-omnichannel#install-extension-solutions).

| Context variable type | Context variable name | Description | How to map in Power Virtual Agents |
|-----------------------|  ---------------------| ----------- | -----------------------------------|
| [Pre-conversation survey](configure-pre-chat-survey.md) | Use the question type that you create in Omnichannel for Customer Service. | The context variables for pre-conversation answers store the customer answers for questions in the pre-conversation survey. | Use the following information to map the question type variable in Omnichannel for Customer Service with the variable type in Power Virtual Agents:<br><ul><li> **Single line**: User’s entire response</li>**Multiple lines**: User's entire response<li>**Option set**: User's entire response</li><li>**User Consent**: Boolean</li></ul> |
| [Custom context](send-context-starting-chat.md) | Use the variable name that you create in Omnichannel for Customer Service or pass using the [setContextProvider API](developer/reference/methods/setContextProvider.md). | These are custom context variables that can be created and passed through the live chat SDK. | Use the following information to map the custom context variable in Omnichannel for Customer Service with the variable type in Power Virtual Agents: <br><ul><li> **String**: User's entire response </li> **Boolean**: Boolean <li> **Number**, **Floating Number**: Number |
| Conversation | msdyn_ConversationId | Use the context variable that contains the conversation ID for the ongoing conversation and can fetch and perform operations on the record in Microsoft Dataverse. | **String**: User's entire response.  |
|  Messaging and voice variables | msdyn_CustomerType   | Use this context variable that contains the customer type for the *account* or *contact* record that's linked to the conversation.    | Select the Omnichannel for Customer Service extension solution variable.|
|  | msdyn_CustomerName | Use this context variable that contains the customer name for the *account* or *contact* record that's linked to the conversation. | Select the Omnichannel for Customer Service extension solution variable. |
|  | msdyn_CustomerId   | Use this context variable that contains the customer ID for the *account* or *contact* record that's linked to the conversation.   | Select the Omnichannel for Customer Service extension solution variable. |
|  | msdyn_CaseId | Use this context variable that contains the ID of the case record that's linked to the conversation.  | Select the Omnichannel for Customer Service extension solution variable.|
|  | msdyn_CaseTitle | Use this context variable that contains the title of the case record that's linked to the conversation.  | Select the Omnichannel for Customer Service extension solution variable. |
| Voice-only variables | CustomerPhoneNumber  | Use this context variable for the customer's phone number that's provided in the Telephony activity.  | Select the Omnichannel for Customer Service extension solution variable. |
|  | OrganizationPhoneNumber | Use this context variable for the organization's phone number that's provided in the Telephony activity.  | Select the Omnichannel for Customer Service extension solution variable. |
| Extension method name  |  va_SurveyConsent |   Use this dialog to determine if a customer has agreed to participate in surveys during the conversation. |  Use this method to escalate conversation details to Omnichannel for Customer Service.  |
| |  va_CustomerLocale |  Use this dialog to transfer the user currently talking to the bot to another bot that can speak in a different language.  | Set the code by selecting the input variable and using the correct locale code. For an example on how to set up this scenario, see [Configure the routing rule in Dynamics 365 for Customer Service](routing-rules.md) </br>.  |
|     |    |    |

## Configure context variables for Power Virtual Agents bot

In Power Virtual Agents, do the following:

1. On the **Topics** page, select **New topic**.
2. On the **Setup** tab, enter a name and description, and save the topic.
3. Select **Go to authoring canvas**.
4. Select **Add node**, choose the **Ask a question** action.
5. Edit the **Identify** field, and in the **Choose information to identify** dialog box, select an option that will match the context variable data type. For information on the data type mapping, see the information in the preceding table.
6. Edit **Save response as**, and in the **Variable Properties** dialog, update the value for **Name** with the required Omnichannel for Customer Service context variable. Make sure **Bot (any topic can access)** and **External sources can set values** are selected. The **External sources can set values** option is applicable only for getting the context variable.
    > ![Configure context variable in a topic.](media/Configure-bot-context-variable.png "Configure context variable in a topic")

7. Save and publish the changes.

At runtime, the required information is captured in the context variable that can then be used for further actions based on the workflow you configure. The bot can set the information for the context variables to link the conversation and case when the bot escalates the conversation to an agent. More information: [Link customer and case to a conversation](record-identification-rule.md#link-customer-and-case-to-conversations-when-bot-escalates-or-ends-conversations)

You can also configure the **Transfer to agent** node in the Power Virtual Agents topic to send a private message with relevant context variables to the live agent during the escalation.

The global variables that are created in Power Virtual Agents can be passed to Omnichannel for Customer Service when a conversation is escalated. For the complete list, see [Contextual variables available upon hand off](/power-virtual-agents/advanced-hand-off#contextual-variables-available-upon-hand-off).


### Parse JSON object to extract record ID

Make sure that you have the following details:

- The Omnichannel for Customer Service context variable, such as msdyn_contact_msdyn_ocliveworkitem_Customer.
- The schema details

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

Here's a sample context record.

```JavaScript
{
    "msdyn_contact_msdyn_ocliveworkitem_Customer": [
        {
            "RecordId": "<GUID>",
            "PrimaryDisplayValue": "<FullName>"
        }
    ],
    "msdyn_liveworkitemid": "<GUID>"
}
```

### See also

[Integrate a Power Virtual Agents bot](configure-bot-virtual-agent.md)  
[Integrate an Azure bot](configure-bot-azure.md)  
[Configure bots to escalate and end conversations](bot-escalate-end-conversation.md)  
[Live chat SDK reference](developer/omnichannel-reference.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
