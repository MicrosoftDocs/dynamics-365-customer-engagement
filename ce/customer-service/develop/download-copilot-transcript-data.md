---
title: Download Copilot transcripts
description: Download Copilot transcripts to review agent interactions and responses. 
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to 
ms.collection: bap-ai-copilot
ms.date: 01/28/2025
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:04/02/2024
---

# Download Copilot transcripts and interaction data

When agents use Copilot, agent interactions with Copilot such as copying summaries, using a suggested reply, feedback, and chat transcripts are stored in the [Copilot Interaction (msdyn_copilotinteraction)](../../developer/reference/entities/msdyn_copilotinteraction.md), [Copilot Interaction Data (msdyn_copilotinteractiondata)](../../developer/reference/entities/msdyn_copilotinteractiondata.md), [Copilot Transcript (msdyn_copilottranscript)](../../developer/reference/entities/msdyn_copilottranscript.md), and [Copilot Transcript Data (msdyn_copilottranscriptdata)](../../developer/reference/entities/msdyn_copilottranscriptdata.md) tables in Dataverse. You can download the transcripts and interaction data using Dataverse [Web API](/power-apps/developer/data-platform/webapi/overview) or [SDK for .NET](/power-apps/developer/data-platform/org-service/overview).

## Prerequisites

- Make sure that the **Agent experience data** checkbox is selected in [**Copilot help pane**](), so that the transaction and interaction data is stored by the system in Dataverse.
- Make sure you're logged in with the Administrator or Supervisor role.
- [Get the interaction id](#get-interaction-id).


## Retrieve conversation summary

When an agent uses Copilot to generate a conversation summary, the summary is stored in the [`msdyn_copilotinsights`](../../developer/reference/entities/msdyn_conversationinsight.md) table in Dataverse. A record is created in the table with a unique conversation id that's stored in the `msdyn_conversationid` field. The summary text is stored in the `msdyn_copilotsummary` field.

For example, after wrapping up a conversation with a customer, an agent uses Copilot to generate a conversation summary. The conversation summary is stored in the `msdyn_copilotinsights` table with the following values.

| Attribute             | Sample Value                                                                                     |
|-----------------------|--------------------------------------------------------------------------------------------------|
| msdyn_conversationid  | 70b76ab52-120b-49e6-9dce-53f235125a01                                                            |
| Conversation summary | “Issue: Trouble with the brew valve on the coffee machine. Troubleshooting steps: Customer reported the issue. Outcome: Issue reported for further assistance.” |

You can retrieve the conversation summary as follows:

1. Identify the conversation's unique conversation ID in `msdyn_conversationid` from the `msdyn_copilotinsights` table. In our example, this value is 70b76ab52-120b-49e6-9dce-53f235125a01.
1. Filter the msdyn_conversationinsights table with the required conversation ID to get the summary. Use the following Web API request to filter the data by conversation ID.

   ```http
 
    [Organization URI]/api/data/v9.0/msdyn_conversationinsights $filter=msdyn_conversationid_value eq '<conversation-ID>'

   ```

   In our example, the Web API request is as follows.

   ```http
    https://<yourorg>.crm.dynamics.com/api/data/v9.0/msdyn_conversationinsights?$filter=_msdyn_conversationid_value eq '70b76ab52-120b-496e-9dce-53f235125a01'
   ```
The sample response for our example is as follows:

```json
{
"status": { "code": 20000, "message": "Successfully fetched summary from insights" },
"summary": "Issue: Trouble with the brew valve on the coffee machine.\nTroubleshooting steps: \n- Customer reported the issue.\nOutcome: Issue reported for further assistance."
}
```


## Download chat transcripts

When an agent [asks Copilot a question](../administer/copilot-enable-help-pane.md#enable-ask-a-question), the chat is saved as a transcript encoded in the base64 encoded format in the `msdyn_transcriptdata` table in Dataverse. You can download the transcripts to review the conversation and responses provided by Copilot.

For example, while working on a case, the agent asks Copilot "How can I book a trip?". Copilot generates a response based on a knowledge base article. If you want to download the chat transcript, perform the following steps:

1. Use the web API call to [get the interaction id](#get-interaction-id).
1. Filter the msdyn_copilotinteractions table with the required interaction ID to get to the DataID. Use the following Web API request to filter the data by interaction ID.

   ```http
 
      [Organization URI]/api/data/v9.1/msdyn_copilotinteractions(<msdyn_copilotinteractionid>)
      Accept: application/json  
      OData-MaxVersion: 4.0  
      OData-Version: 4.0  
   ```

   The key attributes from the record are as follows.

   | Attribute                     | Definition                                                                                                                                                                                                 | Value for our scenario                          |
|-------------------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|-------------------------------------------------|
| msdyn_copilotinteractionid    |                                                                                                                                                                                                            | F0970641-C1E7-EE11-904C-000D3A3BB867            |
| msdyn_scenariorequestid       | Groups multiple related Copilot interactions. <br> For example: an agent asks Copilot a question and then marks the response received with thumbs up. These are considered as two interactions, but are part of the same scenario. | 93893746-e203-e9b6-18b9-887d68d18daf            |
| msdyn_scenariotype            |  Refers to the feature used by agent.                                                                                                                                             | Ask a question                                  |
| msdyn_interactiontypename     | Refers to the specific agent interaction with Copilot.                                                                                                                                    | Generated                                       |
| msdyn_interactionforid        |  The case or conversation from which the agent interacted with Copilot                                                                                                        | 1cd6023d-d326-ee11-9966-000d3a3411cf (case from which the interaction was initiated) |
| msdyn_interactioncontext      | Additional context such as reference to transcripts.                                                                                                                                   |     |
| msdyn_interactiondataid       | Refers to msdyn_copilotinteractiondata entity that contains interaction data                                                                                                                           |                                                 |


   Copy the value of the **DataId** from the `msdyn_interactioncontext`. Here's a sample JSON context.

     ```json
  
          { 
           "ResponseStatusCode": 20000, 
           "Plugins": { 
            }, 
            "Transcript": { 
            "Id": "c477c6dd-d877-c6d1-9337-31e5b54e4a1b", 
            "DataId": "0a7a438f-c2a5-58d7-e03d-c932812b3095"  
            }, 
            "Filters": { 
             "AgentContextFilters": [ 
             ], 
             "DynamicFilters": { 
               "IsApplied": false 
            } 
         } 
       }

     ```

   In our example, this value is 0a7a438f-c2a5-58d7-e03d-c932812b3095. 

3. The following Web API request retrieves the transcript in the base64 encoded transcript.

   ```http
    [Organization URI]/api/data/v9.1/msdyn_copilottranscriptdatas(<Trascript:DataID>)/msdyn_transcriptdata)
    Accept: application/json  
    OData-MaxVersion: 4.0  
    OData-Version: 4.0  
   ```
   In our example, the Web API request is as follows.

   ```http
    [Organization URI]/api/data/v9.1/msdyn_copilottranscriptdatas(0a7a438f-c2a5-58d7-e03d-c932812b3095)/msdyn_transcriptdata
   ```
 
4. Decode the base64 encoded data to get the transcript. You can use an online base64 decoder tool to decode the data. For our example, the decoded transcript is displayed as follows.<br>

   ```json

   {
     "messages": [
       {
         "id": "283c2269-b131-dac2-3aed-847bd99402e7",
         "requestId": "93893746-e203-e9b6-18b9-887d68d18daf",
         "message": "How can I book a trip?",
         "sequence": 0,
         "user": "user",
         "timestamp": 1711052758750,
         "isActivityError": false,
         "context": {}
       },
       {
         "id": "eba9e9d5-71e2-9502-0bca-9387246fb094",
         "requestId": "93893746-e203-e9b6-18b9-887d68d18daf",
         "message": "To book a trip, follow these steps:\n\n1. Go to the travel portal.\n2. Click on \"Travel\" and then select \"Book a Trip\".\n3. Fill in your name, contact information, and the dates of your trip.\n4. Choose your destination from the drop-down menu. Here's the data you'll be working with:\n\n```json\n{\n    \"id\": \"11bb11bb-cc22-dd33-ee44-55ff55ff55ff\",\n    \"title\": \"Booking Travel\",\n    \"source\": \"internal_kb\"\n}\n```\n\n5. Select a hotel from the drop-down menu and specify the check-in and check-out dates. If you don't want to book a hotel, you can check the \"I do not want to book a hotel\" box.\n6. Choose the type of rental car you want. If you don't want to rent a car, you can check the \"I do not want to rent a car\" box.\n7. Click \"Submit\".\n\nOnce you've submitted your booking request, you will receive a follow-up communication from an agent with a quote. You can also add any notes or additional information by clicking on the case from the My Bookings screen.",
         "sequence": 1,
         "user": "bot",
         "timestamp": 1711052776968,
         "isActivityError": false,
         "sources": [
           {
             "id": "11bb11bb-cc22-dd33-ee44-55ff55ff55ff",
             "title": "Booking Travel",
             "source": "internal_kb"
           }
         ],
         "context": {
           "customerIntent": "How to book a trip?"
         }
       }
     ],
     "context": {
       "chatId": "21b27e83-299d-a639-3e4a-8dcd6332e184",
       "sessionId": "session-id-2",
       "entityId": "11bb11bb-cc22-dd33-ee44-55ff55ff55ff",
       "entityName": "knowledgearticle"
     }
   } 

   ```



## Retrieve verbatim feedback

When an agent interacts with Copilot, they can provide feedback on the responses that Copilot provides. The feedback is stored in the `msdyn_copilotinteraction` table in Dataverse. 

For example, the Copilot's response isn't accurate and the agent selects the thumbs-down icon to provide feedback. The agent also provides verbatim feedback. The application creates a record in the `msdyn_copilotinteraction` table with the `msdyn_interactiontypename` set to ThumbsDown.

The key attributes for the record are as follows.

| Attribute                     | Sample data for our example                          |
|-------------------------------|-------------------------------------------------|
| msdyn_copilotinteractionid    | 817ff9e4-cbe7-ee11-904c-000d3a3bb867            |
| msdyn_scenariorequestid       | 93893746-e203-e9b6-18b9-887d68d18daf            |
| msdyn_scenariotype            | Ask a question                                  |
| msdyn_interactiontypename     | ThumbsDown                                      |
| msdyn_interactionforid        | 1cd6023d-d326-ee11-9966-000d3a3411cf            |
| msdyn_interactioncontext      |                                                 |
| msdyn_interactiondataid       | 807ff9e4-cbe7-ee11-904c-000d3a3bb867            |

You can get the verbatim feedback provided by the agent as follows.

1. Get the required`msdyn_interactiondataid`value from the `msdyn_copilotinteraction` table.
1. Run the following Web API request to retrieve the verbatim feedback in the base64 encoded format.

   ```http
 
      [Organization URI]/api/data/v9.1/msdyn_copilotinteractiondatas(<msdyn_copilotinteractiondataid>)
      Accept: application/json  
      OData-MaxVersion: 4.0  
      OData-Version: 4.0  
   ```

   In our example, the Web API request is as follows.

    ```http
    [Organization URI]/api/data/v9.1/msdyn_copilotinteractiondatas(807ff9e4-cbe7-ee11-904c-000d3a3bb867)
    ```

1. Decode the base64 encoded data to get the verbatim feedback. You can use an online base64 decoder tool to decode the data. For our example, the verbatim feedback is available in the `msdyn_verbatim` column.<br>

   ```json

     {
     "@odata.context": "https://ocrealtimeperftest001.crm.dynamics.com/api/data/v9.1/$metadata#msdyn_copilotinteractiondatas/$entity",
     "@odata.etag": "W/\"29538313\"",
     "_owningbusinessunit_value": "0e9ec0a2-eb6a-ed11-9561-000d3a336228",
     "statecode": 0,
     "statuscode": 1,
     "_createdby_value": "586cb7a8-eb6a-ed11-9561-000d3a336228",
     "msdyn_copilotinteractiondataid": "807ff9e4-cbe7-ee11-904c-000d3a3bb867",
     "_ownerid_value": "586cb7a8-eb6a-ed11-9561-000d3a336228",
     "modifiedon": "2024-03-21T21:42:21Z",
     "msdyn_verbatim": "Article is outdated",
     "_owninguser_value": "586cb7a8-eb6a-ed11-9561-000d3a336228",
     "_modifiedby_value": "586cb7a8-eb6a-ed11-9561-000d3a336228",
     "versionnumber": 29538313,
     "createdon": "2024-03-21T21:42:21Z",
     "msdyn_interactiondata_name": null,
     "overriddencreatedon": null,
      "importsequencenumber": null,
     "_modifiedonbehalfby_value": null,
     "msdyn_interactiondata": null,
     "utcconversiontimezonecode": null,
     "_createdonbehalfby_value": null,
     "msdyn_name": null,
     "_owningteam_value": null,
     "timezoneruleversionnumber": null
   }

   ```


## Download interaction data

For all other interactions between agents and Copilot, data is stored in the `msdyn_copilotinteractiondata` table in Dataverse. 

For example, an interaction can be an agent using Copilot to generate an email and a case summary. The key attributes for our example are as follows.

| Attribute                     | Value for our scenario                          |
|-------------------------------|-------------------------------------------------|
| msdyn_copilotinteractionid    | 0dd941e5-34e7-ee11-904c-000d3a3bb867            |
| msdyn_scenariorequestid       | 42ae7f8e-736f-1cea-035b-6bf970b48e9c            |
| msdyn_scenariotype            | Case summary                                    |
| msdyn_interactiontypename     | Generated                                       |
| msdyn_interactionforid        | 1cd6023d-d326-ee11-9966-000d3a3411cf            |
| msdyn_interactioncontext      |     ` {"Filters":{"AgentContextFilters":[],"DynamicFilters":{"IsApplied":false}}} `                                         |
| msdyn_interactiondataid       | f9d841e5-34e7-ee11-904c-000d3a3bb867            |


You can download the interaction data as follows.

1. Use the web API call to [get the interaction id](#get-interaction-id).
2. Run the following Web API request to retrieve the interactions data from the `msdyn_copilotinteraction` table in the base64 encoded format:

   ```http
    [Organization URI]/api/data/v9.1/msdyn_copilotinteractiondatas(<msdyn_interactiondataid>)/msdyn_copilotinteractiondata
    Accept: application/json  
    OData-MaxVersion: 4.0  
    OData-Version: 4.0  

   ```

   In our example, the Web API request is as follows.

    ```http
      [Organization URI]/api/data/v9.1/msdyn_copilotinteractiondatasf9d841e5-34e7-ee11-904c-000d3a3bb867)/msdyn_interactiondata
    
    ```

 3. Decode the base64 encoded data to get the transcript. You can use an online base64 decoder tool to decode the data. For our email example, the decoded interaction data is displayed as follows.

    :::image type="content" source="../media/copilot-interactions-mini.png" alt-text="Screenshot of the decoded interaction data." lightbox="../media/copilot-interactions.png":::


### Get interaction ID

Each agent interaction with Copilot is stored in the `msdyn_copilotinteraction` table with a unique interaction ID. You can use the following Web API call to obtain the interaction ID in the `msdyn_copilotinteractionid` field.

```http
[Organization URI]/api/data/v9.1/msdyn_copilotinteractions
Accept: application/json  
OData-MaxVersion: 4.0  
OData-Version: 4.0  
```

The interactions are displayed in the response as follows.

  ```json
  
{
  "@odata.context": "https://copilotchatorg260224.crm10.dynamics.com/api/data/v9.1/$metadata#msdyn_copilotinteractions",
  "value": [
    {
      "_createdby_value": "78866530-afd0-ee11-904d-6045bdff74d5",
      "createdon": "2024-03-06T06:30:58Z",
      "_createdonbehalfby_value": null,
      "importsequencenumber": null,
      "_modifiedby_value": "78866530-afd0-ee11-904d-6045bdff74d5",
      "modifiedon": "2024-03-06T06:30:58Z",
      "_modifiedonbehalfby_value": null,
      "msdyn_clienttimestamp": "2024-03-06T06:30:51Z",
      "msdyn_copilotinteractionid": "1be35d14-83db-ee11-904c-000d3a100664",
      "msdyn_interactioncontext": "{}",
      "_msdyn_interactiondataid_value": null,
      "msdyn_interactionforid": "78866530-afd0-ee11-904d-6045bdff74d5",
      "msdyn_interactionforlogicalname": "systemuser",
      "msdyn_interactiontype": 100230309,
      "msdyn_name": null,
      "msdyn_scenariorequestid": null,
      "msdyn_scenariotype": 100230201,
      "_organizationid_value": "11bb11bb-cc22-dd33-ee44-55ff55ff55ff",
      "overriddencreatedon": null,
      "statecode": 0,
      "statuscode": 1,
      "timezoneruleversionnumber": 4,
      "utcconversiontimezonecode": 92,
      "versionnumber": 7002510,
      "@odata.etag": "W/\"7002510\""
    },
    {
      "_createdby_value": "f691f2d2-6fd4-ee11-904c-6045bdd8b8c9",
      "createdon": "2024-03-11T04:45:40Z",
      "_createdonbehalfby_value": null,
      "importsequencenumber": null,
      "_modifiedby_value": "f691f2d2-6fd4-ee11-904c-6045bdd8b8c9",
      "modifiedon": "2024-03-11T04:45:40Z",
      "_modifiedonbehalfby_value": null,
      "msdyn_clienttimestamp": "2024-03-11T04:45:38Z",
      "msdyn_copilotinteractionid": "d44ad235-62df-ee11-904c-000d3a100664",
      "msdyn_interactioncontext": "{}",
      "_msdyn_interactiondataid_value": null,
      "msdyn_interactionforid": "f691f2d2-6fd4-ee11-904c-6045bdd8b8c9",
      "msdyn_interactionforlogicalname": "systemuser",
      "msdyn_interactiontype": 100230309,
      "msdyn_name": null,
      "msdyn_scenariorequestid": null,
      "msdyn_scenariotype": 100230201,
      "_organizationid_value": "11bb11bb-cc22-dd33-ee44-55ff55ff55ff",
      "overriddencreatedon": null,
      "statecode": 0,
      "statuscode": 1,
      "timezoneruleversionnumber": 4,
      "utcconversiontimezonecode": 92,
      "versionnumber": 7310986,
      "@odata.etag": "W/\"7310986\""
    },

  ```

### Related information

[Use Copilot to solve customer issues](../use/use-copilot-features.md)  
[View copilot analytics report](../use/copilot-analytics-report.md)
