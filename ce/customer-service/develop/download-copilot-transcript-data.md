---
title: Download Copilot transcripts
description: Download Copilot transcripts to review agent interactions and responses. 
author: gandhamm
ms.author: mgandham
ms.topic: how-to 
ms.collection: get-started 
ms.date: 04/02/2024
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:04/02/2024
---

# Download Copilot transcripts and interaction data

When an agents use Copilot, agent actions such as copying summary presented, using a suggested reply from Copilot, agent feedback, and transcripts from when agents chat with Copilot are stored in the **msdyn_copilotinteraction**, **msdyn_copilotinteractiondata**, **msdyn_copilottranscript**, and **msdyn_copilottranscriptdata** tables in Dataverse. You can download the transcripts and interaction data using Web API requests.

## Prerequisites

- Make sure that the **Agent experience data** checkbox is selected in **Copilot help pane**, for the transaction and interaction data to be stored in the Dataverse.
- You are logged in with the Administrator or Supervisor role.

## Download chat transcripts

When an agent asks the Copilot a question, the interactions between the agent and Copilot are saved as a transcript in base64 encoded format in the msdyn_transcriptdata table in Microsoft Dataverse. You can download the transcripts to review the conversation and the responses provided by Copilot by performing the following steps:

The following Web API request retrieves all the transactions between the agent and Copilot:

```http
GET [Organization URI]/api/data/v9.1/annotations?$filter=objecttypecode eq 'msdyn_copilotinteractions'
Accept: application/json  
OData-MaxVersion: 4.0  
OData-Version: 4.0  
```

 For the required transaction, copy the `msdyn_copilotinteractionid`.

The following Web API request retrieves the required transaction with the JSON context:

```http
GET [Organization URI]/api/data/v9.1/annotations?$filter=objecttypecode eq 'msdyn_copilotinteractions(<msdyn_copilotinteractionid>)'
Accept: application/json  
OData-MaxVersion: 4.0  
OData-Version: 4.0  
```
Copy the value of the **DataId**. Here's a sample JSON context:

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
The following Web API request retrieves the base64 encoded transcript:

```http
GET [Organization URI]/api/data/v9.1/annotations?$filter=objecttypecode eq 'msdyn_copilottranscriptdatas(<Trascript: DataID>)/msdyn_transcriptdata)'
Accept: application/json  
OData-MaxVersion: 4.0  
OData-Version: 4.0  
```

Decode the base64 encoded data to get the transcript. You can use an online base64 decoder tool to decode the data.


## Download  request/response details of interactions

Perform the following steps: 


The following Web API request retrieves all the interactions between the agent and Copilot:

```http
GET [Organization URI]/api/data/v9.1/annotations?$filter=objecttypecode eq 'msdyn_copilottranscripts'
Accept: application/json  
OData-MaxVersion: 4.0  
OData-Version: 4.0  
```

 For the required interaction, copy the `msdyn_copilotinteractionid`.

The following Web API request retrieves the required transaction with the JSON context:

```http
GET [Organization URI]/api/data/v9.1/annotations?$filter=objecttypecode eq 'msdyn_copilottranscripts(<msdyn_copilotinteractionid>)'
Accept: application/json  
OData-MaxVersion: 4.0  
OData-Version: 4.0  
```
Copy the value of the **msdyn_interactiondataid**. 

The following Web API request retrieves the interactions:

```http
GET [Organization URI]/api/data/v9.1/annotations?$filter=objecttypecode eq 'msdyn_copilotinteractiondatas(<interactiondataid>)/ msdyn_interactiondata'
Accept: application/json  
OData-MaxVersion: 4.0  
OData-Version: 4.0  
```
 Decode the base64 encoded data to get the transcript. You can use an online base64 decoder tool to decode the data.

