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

# Download Copilot transcripts

When an agent asks the Copilot a question, the interactions between the agent and Copilot  are saved as a transcript in base64 encoded format in the msdyn_transcriptdata table in Microsoft Dataverse. You can download the transcripts to review the conversation and the responses provided by Copilot. 

## Prerequisites

Make sure that the **Agent experience data** checkbox is selected in **Copilot help pane**, for the transaction and interaction data to be stored in the Dataverse.

## Download transcripts

Perform the following steps: 

1. Sign in to the Customer Service workspace app with Administrator or Supervisor role.
1. Open a new browser window and run `https://<dynamics org url>api/data/v9.1/msdyn_copilotinteractions`. The msdyn_copilotinteractions table lists all the transactions between the agent and Copilot. For the required transaction, copy the `msdyn_copilotinteractionid`. 
1. Filter the table data by the msdyn_copilotinteractionid to see the specific transaction. In thebrowser, run `https://<dynamics org url>api/data/v9.1/msdyn_copilotinteractions(<msdyn_copilotinteractionid>)`to display the required transaction with the JSON context. Copy the value of the **DataId**. Here's a sample JSON context:

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

4. In the browser, run `https://<dynamics org url>api/data/v9.1/msdyn_copilottranscriptdatas(<Trascript: DataID>)/msdyn_transcriptdata)`. The transcript data is displayed in base64 encoded format. 
5. Decode the base64 encoded data to get the transcript. You can use an online base64 decoder tool to decode the data.




