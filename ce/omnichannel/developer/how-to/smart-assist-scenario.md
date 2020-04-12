---
title: "Implement a custom scenario for smart assist bot | MicrosoftDocs"
description: ""
author: susikka
ms.author: susikka
manager: shujoshi
ms.date: 04/10/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---
# Implement a custom scenario for smart assist bot

[!INCLUDE[cc-use-with-omnichannel](../../../includes/cc-use-with-omnichannel.md)]

> [!NOTE]
> For information on how to setup and run the sample code, see the [README](https://github.com/microsoft/Dynamics365-Apps-Samples/blob/master/customer-service/omnichannel/smart-assist-bot/README.md) file. You can make changes to this sample code to implement your custom scenario.

## Prerequisites

Read the topic [Build a smart assist bot](smart-assist-bot.md) for information on how to get started with building a custom smart assist bot. 

## Scenario: Similar case suggestion

Consider the scenario where a customer who is trying to troubleshoot his printer reaches out to customer support through chat channel. The chat request is accepted by an agent. The customer before initiating the chat browsed through the printer website and the customer support agent can see the articles that the customer has read. The smart assist bot should be able to suggest similar cases with open and close case action buttons. 

The customer service agent is presented with a list of similar cases as a recommendation. The agent clicks on the case that he finds most similar and relevant, and then goes to the case note and looks ar the resolution in note. The agent suggests the same resolution to the customer over chat.

## Implement similar case suggestion

### Generate intent to interpret the context of the conversation

You need to analyze the conversation and understand its context before recommending an action to the agent. Use [Language Understanding (LUIS)](https://luis.ai) to find the intent of the ongoing conversation. Here is an example on how you can create a LUIS app to find intent from a given text: [Quickstart: Use prebuilt Home automation app](/azure/cognitive-services/luis/luis-get-started-create-app).

You can create intents for each issue type or topic that you want to address for incoming requests from customers or the most common topics being discussed.  

For the example scenario of similar case recommendations for ‘printer noise’ issue, create an intent with the same name and add 10-15 examples like ‘printer noise, loud noise from printer, printer making grinding noise, loud clicking noise, loud sound’ etc. The LUIS app then needs to be trained for this intent.  

### Custom actions for implementing custom functionalities

Custom actions can help you implement custom functionalities in your smart assist bot. More information: [Calling macros and custom actions using adaptive cards](smart-assist-bot.md#bkmk_macro_customaction).

Similar cases can be fetched using the `GetSimilarRecords` function. But before you execute the Web API query with this function, make sure that you have set up similarity rules. More information: [Use advanced similarity rules to view similar case suggestions](../../../customer-service/suggest-similar-cases-for-a-case). Also, make sure to enable **Relevance Search** in the administrator section to ensure that similarity rules work in the expected manner. Also, in the **Match Field** section add a few criteria such as case title and case type.

**Request**

```http
GET [Organization URI]/api/data/v9.1/GetSimilarRecords(Id=@Id,Filter=@Filter,ReturnFields=@ReturnFields)?@Id={"@odata.id":"incidents(<incident id>)"}&@Filter=null&@ReturnFields={"AllColumns":false,"Columns":["title","description"]}
Accept: application/json  
OData-MaxVersion: 4.0  
OData-Version: 4.0 
```

Replace the `incident id` in the Web API request above with the unique identifier of the case for which you want to find similar cases.

**Response**

```json
{
    "@odata.context": "[Organization URI]/api/data/v9.1/$metadata#incidents",
    "value": [
        {
            "@odata.type": "#Microsoft.Dynamics.CRM.incident",
            "@odata.etag": "W/\"1571835\"",
            "title": "Product question re warranty",
            "modifiedon": "2019-03-03T12:58:25Z",
            "incidentid": "f69e62a8-90df-e311-9565-a45d36fc5fe8"
        },
        {
            "@odata.type": "#Microsoft.Dynamics.CRM.incident",
            "@odata.etag": "W/\"1572750\"",
            "title": "Shipment question re order",
            "modifiedon": "2019-03-03T12:58:27Z",
            "incidentid": "129f62a8-90df-e311-9565-a45d36fc5fe8"
        }
    ]
}
```

The custom actions required for implementing similar case suggestions include the following:

1. Open any entity form using the [openForm](/powerapps/developer/model-driven-apps/clientapi/reference/xrm-navigation/openform) client API.
2. Copy to Conversation Control.
3. Open th URL in App tab.

## See also

[Build a smart assist bot](smart-assist-bot.md)<br />
[Sample code: Smart Assist for Bots](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/customer-service/omnichannel/smart-assist-bot)<br />
[Smart assist for agents](../../administrator/smart-assist.md)