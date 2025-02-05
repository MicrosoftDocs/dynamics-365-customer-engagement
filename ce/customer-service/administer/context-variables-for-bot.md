---
title: Configure context variables for agents
description: Learn how you can add context variables and then configure them for Azure or Copilot Studio agents in Omnichannel for Customer Service.
ms.date: 12/14/2024
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.collection:
ms.custom: bap-template
---

# Configure context variables for agents

[!INCLUDE[pva-rebrand](../../includes/cc-pva-rebrand.md)]

[!INCLUDE[cc-rebrand-bot-agent](../../includes/cc-rebrand-bot-agent.md)]


[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]

This article lists the context variables for Azure and Copilot Studio agents, and how you can configure them in Omnichannel for Customer Service. To understand how to create context variables, see [Manage context variables](manage-context-variables.md).

## Context variables for Azure agents

The following table contains the list of context variables in Omnichannel for Customer Service that you can use for [configuring Azure agents](configure-bot-azure.md).

| Context variable type | Context variable name | Description  | How to map in Azure |
|-----|-----|-------|-------|
| [Pre-conversation survey](configure-pre-chat-survey.md) | Use the pre-conversation survey question name that you create in Omnichannel for Customer Service. | The system stores responses from the pre-conversation survey as context variables. | Use the following information to map the question name in Omnichannel for Customer Service with the variable type in Azure:<br><ul><li> **Single line**: String</li><li>**Multiple lines**: String</li><li>**Option set**: String</li><li>**User Consent**: Boolean</li></ul>|
| [Custom context](../develop/send-context-starting-chat.md) | Use the variable name that you create in Omnichannel for Customer Service or pass using the setContextProvider API. | The custom context variables that you create can be passed through the live chat SDK. | [Map the user's response as a JSON](../develop/display-custom-context.md) to use custom context variable in Omnichannel for Customer Service. |
| Conversation | msdyn_ConversationId  | Use the context variable that contains the conversation ID for the ongoing conversation and can fetch and perform operations on the record in Microsoft Dataverse. |**String**: String|
|[Contact](record-identification-rule.md) | msdyn_contact_msdyn_ocliveworkitem_Customer | Use this context variable that contains the record ID for the customer (contact) record that is linked to the conversation.    | [Parse JSON to extract record ID](#parse-json-object-to-extract-record-id)  |
| [Account](record-identification-rule.md) | msdyn_account_msdyn_ocliveworkitem_Customer | Use this context variable that contains the record ID for the account record linked to the conversation. | [Parse JSON to extract record ID](#parse-json-object-to-extract-record-id)|
| [Case](record-identification-rule.md) | msdyn_incident_msdyn_ocliveworkitem | Use this context variable that contains the record ID for the case record linked to the conversation.  | [Parse JSON to extract record ID](#parse-json-object-to-extract-record-id) |

> [!NOTE]
> Use the context variable names as defined and don't change them when you author flows in Azure or Copilot Studio agents. Also, be sure to use exact match to pass the value to the context variable because it is case-sensitive. If there's a mismatch, the record won't get automatically identified. More information: [Identify records automatically](record-identification-rule.md)

## Context variables for Copilot Studio agents

The following table contains the list of context variables available in Omnichannel for Customer Service that you can use for [configuring Copilot Studio agents](configure-bot-virtual-agent.md).

> [!IMPORTANT]
> To use the messaging and voice variables, ensure that you first [install the extension solutions](/power-virtual-agents/configuration-hand-off-omnichannel#install-extension-solutions).

| Context variable type | Context variable name | Description | How to map in Copilot Studio |
|-----------------------|  ---------------------| ----------- | -----------------------------------|
| [Pre-conversation survey](configure-pre-chat-survey.md) | Use the pre-conversation survey question name that you create in Omnichannel for Customer Service. | The system stores responses from the pre-conversation survey as context variables. | Use the following information to map the question name in Omnichannel for Customer Service with the variable type in Copilot Studio:<br><ul><li> **Single line**: User’s entire response</li><li>**Multiple lines**: User's entire response</li><li>**Option set**: User's entire response</li><li>**User Consent**: Boolean</li></ul> |
| [Custom context](../develop/send-context-starting-chat.md) | Use the variable name that you create in Omnichannel for Customer Service or pass using the [setContextProvider API](../develop/reference/methods/setContextProvider.md). | The custom context variables that you create can be passed through the live chat SDK. | Use the following information to map the custom context variable in Omnichannel for Customer Service with the variable type in Copilot Studio: <br><ul><li> **String**: User's entire response </li> **Boolean**: Boolean <li> **Number**, **Floating Number**: Number |
| Conversation | msdyn_ConversationId | Use the context variable that contains the conversation ID for the ongoing conversation and can fetch and perform operations on the record in Microsoft Dataverse. | **String**: User's entire response.  |
|  Messaging-only variables | msdyn_CustomerType   | Use this context variable that contains the customer type for the *account* or *contact* record linked to the conversation.    | Select the Omnichannel for Customer Service extension solution variable.|
|  | msdyn_CustomerName | Use this context variable that contains the customer name for the *account* or *contact* record linked to the conversation. | Select the Omnichannel for Customer Service extension solution variable. |
|  | msdyn_CustomerId   | Use this context variable that contains the customer ID for the *account* or *contact* record linked to the conversation.   | Select the Omnichannel for Customer Service extension solution variable. |
|  | msdyn_CaseId | Use this context variable that contains the ID of the case record linked to the conversation.  | Select the Omnichannel for Customer Service extension solution variable.|
|  | msdyn_CaseTitle | Use this context variable that contains the title of the case record linked to the conversation.  | Select the Omnichannel for Customer Service extension solution variable. |
| Voice-only variables **<sup>1</sup>** | CustomerPhoneNumber  | Use this context variable for the customer's phone number in the Telephony activity.  | Select the Omnichannel for Customer Service extension solution variable. |
|  | OrganizationPhoneNumber | Use this context variable for the organization's phone number in the Telephony activity.  | Select the Omnichannel for Customer Service extension solution variable. |
| Extension method name  |  va_SurveyConsent |   Use this dialog to determine if a customer has agreed to participate in surveys during the conversation. |  Use this method to escalate conversation details to Omnichannel for Customer Service.  |
| |  va_CustomerLocale |  Use this dialog to transfer the user currently talking to the agent to another agent that can speak in a different language.  | Set the code by selecting the input variable and using the correct locale code.|


**<sup> 1</sup>** To use other context variables for voice, you will need to get the values from Dataverse directly. Learn more in [Configure a sample voice agent template](/dynamics365/contact-center/administer/bot-scenario-configure).

## Configure context variables for Copilot Studio agent

To have your Copilot Studio agent read context variables from Omnichannel, do the following steps:

1. On the **Topics** page, select **Add a topic** and **from blank**.
2. Enter a name for your topic (for example, "Set context variables") and save it.
3. Add a new node to the topic, and select **Variable management > Set a variable value**
4. In your new node, under **Set variable** select **Create a new variable**.
5. Open the **Variable properties** pane by clicking the new variable name. In the pane, set the **Variable name** to match the Omnichannel context variable's name exactly (it's case sensitive). 
6. In the **Reference** section, select the ellipses (**...**) and select **Get value from this node if empty**. The Copilot Studio agent retrieves the variable value from this node at runtime.
7. In the **Usage** section, select **Global (any topic can access)** and **External sources can set values**. Copilot Studio accepts data from Omnichannel. Close the **Variable properties** pane.
8. In your node, enter a value in **To value** that matches the data type your agent expects. For example, if your agent expects a string, set Text(""). Copilot Studio falls back to the value that you set here if the data doesn't arrive in the conversation.
    > ![Configure context variable in a topic.](../media/Configure-bot-context-variable.png "Configure context variable in a topic")

9. Save and publish the changes.

During a conversation, the data from the Omnichannel context variable is set in the Copilot Studio variables and can be used in the agent's logic. 

The agent can also set Omnichannel context variables during a conversation. To set an Omnichannel variable from your Copilot Studio logic, make sure that your agent is using the correct variable name and set the value in the "To value" property in your variable management node. Copilot Studio hands off the variable to Omnichannel during transfer to a customer service representative. This is often used to link the conversation to a case when the agent escalates the conversation to a service representative. More information on how to link records in Omnichannel from this data: [Link customer and case to a conversation](record-identification-rule.md#link-customer-and-case-to-conversations-when-bot-escalates-or-ends-conversations)

The global variables that are created in Copilot Studio can be passed to Omnichannel for Customer Service when a conversation is escalated. For the complete list, see [Contextual variables available upon hand off](/power-virtual-agents/advanced-hand-off#contextual-variables-available-upon-hand-off).

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

`PrimaryDisplayValue`  contains the value from the attribute in the Dataverse entities. The mapping for the entity attributes is as follows:

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

### Related information

[Integrate a Copilot Studio agent](configure-bot-virtual-agent.md)  
[Integrate an Azure agent](configure-bot-azure.md)  
[Configure agents to escalate and end conversations](../develop/bot-escalate-end-conversation.md)  
[Live chat SDK reference](../develop/omnichannel-reference.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
