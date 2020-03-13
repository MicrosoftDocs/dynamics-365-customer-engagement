---
title: "Implement a custom scenario for smart assist bot | MicrosoftDocs"
description: ""
author: susikka
ms.author: susikka
manager: shujoshi
ms.date: 02/27/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---
# Implement a custom scenario for smart assist bot

[!INCLUDE[cc-use-with-omnichannel](../../../includes/cc-use-with-omnichannel.md)]

> [!NOTE]
> See the entire code sample for building a smart assist bot here: [Smart Assist for Bots](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/customer-service/omnichannel/smart-assist-bot). You will find information on how to setup and run the sample in the sample [README](https://github.com/microsoft/Dynamics365-Apps-Samples/blob/master/customer-service/omnichannel/smart-assist-bot/README.md) file. You can make changes to this sample code to implement your custom scenario.

## Prerequisites

Read the topic [Build a custom smart assist bot](smart-assist-bot.md) for information on how to get started with building a custom smart assist bot. 

## Scenario: Similar case suggestion

Consider the scenario where a customer who is trying to troubleshoot his printer reaches out to customer support through chat channel. The chat request is accepted by an agent. The customer before initiating the chat browsed through the printer website and the customer support agent can see the articles that the customer has read. The smart assist bot should be able to suggest similar cases with open and close case action buttons. 

The customer service agent greets the customer with the following message. 

```
Welcome to Contoso Ltd. I'm happy to assist you today. You were trying to troubleshoot your printer. Is this the same issue?
```

Customer responds with the following message.

```
Yes, that is right. My printer is making loud noise. I tried restarting it but that did not help.
```

The customer service agent is presented with a list of similar cases as a recommendation. The agent clicks on the case that he finds most similar and relevant, and then goes to the case note and looks ar the resolution in note. The agent suggests the same resolution to the customer over chat.

## Implement similar case suggestion

Macros and custom actions can help you implement custom functionalities in your smart assist bot. More information: [Calling macros and custom actions using adaptive cards](smart-assist-bot.md#bkmk_macro_customaction).

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

[Build a custom smart assist bot](smart-assist-bot.md)<br />
[Smart assist for agents](../../administrator/smart-assist.md)<br />
[Sample code: Smart Assist for Bots](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/customer-service/omnichannel/smart-assist-bot)