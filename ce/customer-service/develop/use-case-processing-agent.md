---
title: Use msdyn_invokeCaseProcessingAgent to invoke Case Management Agent
description: Learn how to use msdyn_invokeCaseProcessingAgent to invoke Case Management Agent in Dynamics 365 Customer Service.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to 
ms.collection: bap-ai-copilot 
ms.date: 11/06/2026
ms.update-cycle: 180-days
ms.custom: bap-template
ai-usage: ai-assisted
---

# Use msdyn_invokeCaseProcessingAgent to invoke Case Management Agent

Use the `msdyn_invokeCaseProcessingAgent` business event to trigger Case Management Agent to do the following:

 - extract information from a source entity such as an email and update the case with relevant details. 
 - resolve a specific case. 

You can use this to extend case automation beyond the default triggers. For example, you can invoke Case Management Agent when a customer creates a case from an external portal, or when a CRUD event occurs on a custom table, such as new receipts added to a case.  

## Prerequisites

- Case Management Agent is configured.
- Make sure [`Microsoft.CrmSdk.CoreAssemblies`](https://www.nuget.org/packages/Microsoft.CrmSdk.CoreAssemblies/), [`Newtonsoft.Json`](https://www.nuget.org/packages/Newtonsoft.Json), and [`Microsoft.Xrm.Tooling.Connector.dll`from [Microsoft.CrmSdk.CoreTools](https://www.nuget.org/packages/Microsoft.CrmSdk.CoreTools) are installed.

## HTTP request

```http
POST [Organization URI]/api/data/v9.2/msdyn_invokeCaseProcessingAgent
```

## Request body

| Property                | Type                    | Required | Description |
|-------------------------|-------------------------|----------|-------------|
| **msdyn_incidentId**    | String             | Yes      | The ID of the case (incident) on which Case Management Agent should run.<br>Example: `"3895d023-a353-f011-877b-6045bd062e87"` |
| **msdyn_actions**       |JSON array serialized as a string | Yes      | Defines which Case Management Agent actions and capabilities to perform. See details in the following section. |
| `msdyn_extraParams` | JSON object serialized as a string| No | Provides additional context and invocation options. See [Additional parameters](#additional-parameters). |

Pass `msdyn_actions` and `msdyn_extraParams` as JSON stored in strings, not as JSON arrays or objects in the request body.

### msdyn_actions array object

| Property                | Type   | Required | Description |
|-------------------------|--------|----------|-------------|
| **action**              | String  | Yes | Defines the case processing action to run.<br>Values: <ul><li>**resolve**: Resolve the case using the resolution capabilities of Case Management Agent.</li><li> **enrich**: Extracts information from a source entity, such as an email, and updates the case with relevant details.<br> The source entity must be accessible and contain relevant case information</li></ul> |
| **automationLevel** | String | No | For normal invocations, Case Management Agent uses the automation mode configured by the administrator, not the `Full` or `Semi` value supplied here. If `msdyn_extraParams.requestProcessed` is `true`, the action payload is used as supplied instead of being updated from the configured settings. |
| **sourceContextEntity** | String | Yes | This is a required value for case enrichment and optional for case resolution. The source entity, such as an email or a conversation that must be used to update the case.<br>Example: `"emails(0e20cf92-f663-f011-bec1-000d3a3622ba)"` |
| `customAgentOutput` | JSON object serialized as a string | No | For `resolve`, supplies the output of a custom agent in an asynchronous callback. The object uses the [custom-agent output contract](case-management-agent-integration.md#output-contract), including `responseType`, `message`, `handlingOptions`, `customAgentName`, and `templateId`. |

### Additional parameters

The `msdyn_extraParams` object supports the following properties.

| Property | Type | Required | Description |
|----------|------|----------|-------------|
| `additionalInformation` | Array of objects | No | Provides information from an external system for intent detection. Each object contains a `key` to identify the information, a `value` with the content, and a `keyDescription` that explains what the content represents. All three properties are strings. |
| `triggerReason` | String | No | Identifies why the agent is invoked. For example, use `customAgentCallback` when a custom agent calls back into Case Management Agent. |
| `refreshIntentFamily` | Boolean | No | When `true`, determines the intent family again by using the rule engine instead of the cached `msdyn_intententity` record. Applies only when the `RefreshIntentFamilyInCMAFlow` feature switch is enabled. |

### Sample request

```json
{
  "msdyn_incidentId": "5ad2ac2c-6363-f011-bec2-6045bd026457",
  "msdyn_actions": "[{\"action\":\"enrich\",\"sourceContextEntity\":\"emails(0e20cf92-f663-f011-bec1-000d3a3622ba)\"},{\"action\":\"resolve\",\"automationLevel\":\"Full\"}]"
}
```

## Response

- **Success**: Returns HTTP `204 No Content` with an empty body.  
- **Failure**: Standard OData error response.  

---

## Sample code

In the following example, you invoke Case Management Agent from Dataverse plugins or custom code by running the `msdyn_invokeCaseProcessingAgent` organization request. The agent updates the case by using a related email entity, and then it processes case resolution by using the administrator-configured automation mode.


### Example 1

```C#
CrmServiceClient GetService()
{
    string orgUrl = "";
    string username = "";
    string connectionString = $"AuthType=OAuth;Username={username};Url={orgUrl};AppId=51f81489-12ee-4a9e-aaae-a2591f45987d;RedirectUri=http://localhost;LoginPrompt=Auto";
    CrmServiceClient svc = new CrmServiceClient(connectionString);
    return svc;
}

public class InvokeCaseProcessingAgentRequest
{
    [JsonProperty("msdyn_incidentId")]
    public string incidentid { get; set; }

    [JsonProperty("msdyn_actions")]
    public List<AgentAction> actions { get; set; }
}

public class AgentAction
{
    [JsonProperty("action")]
    public AgentActionType action { get; set; }

    [JsonProperty("sourceContextEntity")]
    public string sourceContextEntity { get; set; }

    [JsonProperty("automationLevel")]
    public AutomationLevel? automationLevel { get; set; }
}

[JsonConverter(typeof(StringEnumConverter))]
public enum AgentActionType
{
    [EnumMember(Value = "enrich")]
    Enrich,
    [EnumMember(Value = "resolve")]
    Resolve
}

[JsonConverter(typeof(StringEnumConverter))]
public enum AutomationLevel
{
    [EnumMember(Value = "Full")]
    Full,
    [EnumMember(Value = "Semi")]
    Semi
}

void Main()
{
    var service = GetService();
    var actions = new List<AgentAction>()
    {
        new AgentAction()
        {
            action = AgentActionType.Enrich,
            sourceContextEntity = "emails(0e20cf92-f663-f011-bec1-000d3a3622ba)"
        },
        new AgentAction()
        {
            action = AgentActionType.Resolve,
            automationLevel = AutomationLevel.Full
        },
    };
    var req = new OrganizationRequest("msdyn_invokeCaseProcessingAgent")
    {
        ["msdyn_incidentId"] = new Guid("8f2db50d-0c64-f011-bec2-000d3a3b776a"),
        ["msdyn_actions"] = JsonConvert.SerializeObject(actions)
    };
    service.Execute(req);
}
```


### Example 2

```JavaScript
function invokeCaseManagementAgent() {
  var data = JSON.stringify({
    "msdyn_incidentId": "020edf2f-7d3f-4a69-bd26-030736604eeb",
    "msdyn_actions": "[{\"action\":\"enrich\",\"sourceContextEntity\":\"emails(0e20cf92-f663-f011-bec1-000d3a3622ba)\"},{\"action\":\"resolve\",\"automationLevel\":\"Full\"}]"
  });
  var xhr = new XMLHttpRequest();
  xhr.withCredentials = true;
  xhr.addEventListener("readystatechange", function() {
    if(this.readyState === 4) {
      console.log(this.responseText);
    }
  });
  xhr.open("POST", Xrm.Utility.getGlobalContext().getClientUrl()+"/api/data/v9.2/msdyn_invokeCaseProcessingAgent");
  xhr.setRequestHeader("Cache-Control", "no-cache");
  xhr.setRequestHeader("Accept", "*/*");
  xhr.setRequestHeader("Content-Type", "application/json");
  xhr.send(data);
}

invokeCaseManagementAgent();
```

### Provide extra information from an external system

Use `additionalInformation` to give context, such as attachment content or warranty status, for intent detection. This Web API request sends both parameters as stringified JSON.

```json
{ 

  "msdyn_incidentId": "00000000-0000-0000-0000-000000000000", 
  "msdyn_actions": [ 
    { "action": "resolve", "sourceContextEntity": "emails(<email-guid>)" } 
  ], 
  "msdyn_extraParams": { 
    "triggerReason": "customAgentCallback", 
    "additionalInformation": [ 
      { "key": "attachmentContent", "value": "This is my attachment content", 
        "keyDescription": "File attachment content in natural language" }, 
      { "key": "warrantyStatus", "value": "Fulfilled", 
       "keyDescription": "Current warranty fulfillment status" } 
    ] 
  } 
} 
```

### Return an asynchronous custom-agent result

When a custom agent returns `Wait`, Case Management Agent becomes idle while the custom agent does asynchronous work. To continue processing, call `msdyn_invokeCaseProcessingAgent` with a `resolve` action and a `customAgentOutput` value whose `responseType` isn't `Wait`. For the integration workflow, see [How the integration works](case-management-agent-integration.md#how-the-integration-works).

The following Web API request sends `customAgentOutput` as a JSON string inside the stringified `msdyn_actions` array. Replace the case ID, agent schema name, and template ID with values from your environment.

```json
{ 

  "msdyn_incidentId": "<case-guid>", 
  "msdyn_actions": [ { 
    "action": "resolve", 
    "customAgentOutput": { "responseType": "Resolved", "message": "<message>", 
      "handlingOptions": { "needsReview": "true" }, 
      "customAgentName": "<agent schema name>", "templateId": "<template-guid>" } 
  } ] 
} 
```
