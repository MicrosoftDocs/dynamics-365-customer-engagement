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

When an agents use Copilot, agent actions such as copying summary presented, using a suggested reply from Copilot, agent feedback, and transcripts from when agents chat with Copilot are stored in the [**msdyn_copilotinteraction**](../develop/msdyn_copilotinteraction.md), [**msdyn_copilotinteractiondata**](../develop/msdyn_copilotinteractiondata.md), [**msdyn_copilottranscript**](../develop/msdyn_copilottranscript.md), and [**msdyn_copilottranscriptdata**](../develop/msdyn_copilottranscriptdata.md) tables in Dataverse. You can download the transcripts and interaction data using Web API requests.

## Prerequisites

- Make sure that the **Agent experience data** checkbox is selected in **Copilot help pane**, for the transaction and interaction data to be stored in the Dataverse.
- Make sure you are logged in with the Administrator or Supervisor role.

## Get interaction id

When the agent interacts with the Copilot, the interaction is stored in the `msdyn_copilotinteraction` table with a unique interaction ID. You can get the interaction ID by using the following Web API call:

```http
[Organization URI]/api/data/v9.1/msdyn_copilotinteractions
Accept: application/json  
OData-MaxVersion: 4.0  
OData-Version: 4.0  
```

Copy the `msdyn_copilotinteractionid` for the required interaction.

## Download chat transcripts

When an agent asks the Copilot a question, the interactions between the agent and Copilot are saved as a transcript in base64 encoded format in the `msdyn_transcriptdata` table in Microsoft Dataverse. You can download the transcripts to review the conversation and the responses provided by Copilot.

For example, an agent asks the Copilot “How can I book a trip?” while working on a case. Copilot generates a response based on a KB article. If you want to download that chat transcript, perform the following steps:

1. Get the interaction ID by using the Web API call mentioned in the previous section. 
1. Filter the msdyn_copilotinteractions with the required interaction ID to get to the DataID. Use the following Web API request to filter the data by interaction id:

```http
[Organization URI]/api/data/v9.1/'msdyn_copilotinteractions(<msdyn_copilotinteractionid>)'
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
3. The following Web API request retrieves the transcript in the base64 encoded transcript:

```http
[Organization URI]/api/data/v9.1/'msdyn_copilottranscriptdatas(<Trascript: DataID>)/msdyn_transcriptdata)'
Accept: application/json  
OData-MaxVersion: 4.0  
OData-Version: 4.0  
```

Decode the base64 encoded data to get the transcript. You can use an online base64 decoder tool to decode the data. For our example, the decoded transcript is displayed as follows:


   :::image type="content" source="../media/copilot-transcript-mini.png" alt-text="Screenshot of the decoded transcript data." lightbox="../media/copilot-transcript.png":::



## Download interaction data

When an agent interacts with the Copilot, the interaction data is stored in the `msdyn_copilotinteractiondata` table in Microsoft Dataverse. 

For example, an interaction can be an agent using the Copilot to generate an email or a case summary. You can download the data from this interaction as follows:

1. Get the interaction ID by using the Web API call mentioned in the previous section.
1. The following Web API request retrieves the interactions data from the msdyn_interaction table in the base64 encoded format:

```http
[Organization URI]/api/data/v9.1/'msdyn_copilotinteractiondatas(<msdyn_interactiondataid>)/ msdyn_interactiondata'
Accept: application/json  
OData-MaxVersion: 4.0  
OData-Version: 4.0  
```
 Decode the base64 encoded data to get the transcript. You can use an online base64 decoder tool to decode the data. For our email example, the decoded interaction data is displayed as follows:

   :::image type="content" source="../media/copilot-interactions-mini.png" alt-text="Screenshot of the decoded interaction data." lightbox="../media/copilot-interactions.png":::

If you want to download the feedback provided by the agent, follow the same steps. If an agent has provided verbatim feedback, you'll find it in the `msdyn_verbatim` attribute in `msdyn_interactiondata`.

