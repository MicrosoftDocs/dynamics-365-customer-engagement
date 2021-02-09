---
title: "Context variables for a bot | MicrosoftDocs"
description: "Context variables to use when configuring a bot in Omnichannel for Customer Service."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 01/04/2021 
ms.topic: article
ms.service: dynamics-365-customerservice
---

# Context variables for a bot

[!INCLUDE[cc-data-platform-banner](../includes/cc-data-platform-banner.md)]

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

This topic lists the context variables that you can configure for a bot in Power Virtual Agents or Azure to use in Omnichannel for Customer Service.

## Context variables

The following table contains the list of variables in Omnichannel for Customer Service that can help you configure some of the context variables for a bot in [Power Virtual Agents](configure-bot-virtual-agent.md) or [Azure](configure-bot.md).

> [!IMPORTANT]
> Make sure of the following:
>
> - The context variable names are used as is and not changed when you author flows in Power Virtual Agents or Azure bots.
> - The length of the context variable names must be 200 characters or less.
> - Use exact match to pass the value to the context variable because it is case sensitive. Also,the value must be 4,000 characters or less so that the conversation can be successfully escalated to agents.

| Context variable type | Context variable name | Description | How to map in Power Virtual Agents | How to map in Azure |
|-----|-----|-------|-------|-----|
| [Pre-conversation survey](configure-pre-chat-survey.md) | Use the question type that you create in Omnichannel for Customer Service. | The context variables for pre-conversation answers store the customer answers for questions in the pre-conversation survey. | Use the following information to map the question type variable in Omnichannel for Customer Service with the variable type in Power Virtual Agents:<br><ul><li> **Single line:** User’s entire response</li>**Multiple lines:** User's entire response<li>**Option set:** User's entire response</li><li>**User Consent:** Boolean</li></ul> |Use the following information to map the question type variable in Omnichannel for Customer Service with the variable type in Azure:<br><ul><li> **Single line:** String</li>**Multiple lines:** String<li>**Option set:** String</li><li>**User Consent:** Boolean</li></ul>|
| [Custom Context](send-context-starting-chat.md) | Use the variable name that you create in Omnichannel for Customer Service or pass using the setcontext API. | These are custom context variables that can be created and passed through the Livechat SDK. | Use the following information to map the custom context variable in Omnichannel for Customer Service with the variable type in Power Virtual Agents: <br><ul><li>**String:** User's entire response</li><li>**Boolean:** Boolean</li><li>**Number, Floating Number:** Number</li></ul> |Use the following information to map the custom context variable in Omnichannel for Customer Service with the variable type in Azure: <br><ul><li>**String:** String</li><li>**Boolean:** Boolean</li><li>**Number, Floating Number:** Number</li></ul>|
| Conversation | msdyn_liveworkitemid | Use the context variable that contains the conversation ID for the ongoing conversation and can fetch and perform operations on the record in Common Data Service. | **String:** User's entire response. |**String:** String|
|[Contact](record-identification-rule.md) |msdyn_contact_msdyn_ocliveworkitem_Customer| Use this context variable that contains the record ID for the customer (contact) record that is linked to the conversation. | [Parse the JSON to extract the record ID](#parse-json-to-extract-record-id). |Parse the JSON to extract the record ID.|
| Account | msdyn_account_msdyn_ocliveworkitem_Customer |Use this context variable that contains the record ID for the account record linked to the conversation.|Parse the JSON to extract the record ID.|Parse the JSON to extract the record ID.|
| Case | msdyn_incident_msdyn_ocliveworkitem | Use this context variable that contains the record ID for the case record linked to the conversation. |Parse the JSON to extract the record ID.| Parse the JSON to extract the record ID.|
|||||

### Parse JSON to extract record ID

Perform the steps outlined in this section to parse the JSON to extract the record ID.

Make sure that you have the following details:

- The Omnichannel context variable, such as msdyn_contact_msdyn_ocliveworkitem_Customer.
- The schema details. A copy of the sample schema details is as follows.

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

"PrimaryDisplayValue" will contain the value from the attribute in the Dataverse entities. The mapping for the entity attributes is as follows:

- **Cases:** Case title
- **Contacts:** Full name
- **Accounts:** Name

The following steps explain how to configure a Power Automate flow to parse the JSON and extract the record ID and use in a Power Virtual Agents bot:

1. Go to the topic of the bot in which you want to configure the context variable, and select the add node.
2. Select **Call an action**, and select **Create a flow**.
3. Do the following in the Power Automate window that opens on a new tab:
   1. Select **Add an input** for the Power Virtual Agents Flow Template.
   2. Select **Text** for **Choose the type of user input**, and then enter the Omnichannel for Customer Service context variable name.
   3. Select **Add an action** in the add node, search for **Parse JSON**, and select it.
   4. Select **Content** box, and select the context variable name in the list that appears. It should be the same context variable name that you had entered as input in step 2.
   5. In the **Schema** box, enter the sample schema details.
   6. Select **Add an action** in the add node for Parse JSON, search for **Apply to each**, and select it.
   7. In the **Select an output from previous steps** box, select **RecordId** in the list that appears.
   8. Select **Add an action**, and do the following:
      1.  Search for **Get a record** action and select it.
      2.  Select a value in **Entity name**. For example, if the context variable is "msdyn_incident_msdyn_ocliveworkitem", then select **Cases**, and if the context variable is "msdyn_contact_msdyn_ocliveworkitem_Customer", then select **Contacts**.
      3. Select **RecordId** in **Item ID**.
4.  Save the changes, and exit from Power Automate.
5.  In Power Virtual Agents, go back to the topic you were editing, select the flow that you configured, and then save and publish.

### See also

[Integrate a Power Virtual Agents bot](configure-bot-virtual-agent.md)  
[Integrate an Azure bot](configure-bot.md)  
