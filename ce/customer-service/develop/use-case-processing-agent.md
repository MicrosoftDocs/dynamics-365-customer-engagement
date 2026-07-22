---
title: Use msdyn_invokeCaseProcessingAgent to invoke Case Management Agent
description: Learn how to use msdyn_invokeCaseProcessingAgent to invoke Case Management Agent in Dynamics 365 Customer Service.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to 
ms.collection: bap-ai-copilot 
ms.date: 09/15/2025
ms.update-cycle: 180-days
ms.custom: bap-template
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
| **msdyn_actions**       | Stringified JSON array  | Yes      | Defines which Case Management Agent actions/capabilities to perform. See details below. |

### msdyn_actions array object

| Property                | Type   | Required | Description |
|-------------------------|--------|----------|-------------|
| **action**              | String  | Yes | Defines the case processing action to run.<br>Values: <ul><li>**resolve**: Resolve the case using the resolution capabilities of Case Management Agent.</li><li> **enrich**: Extracts information from a source entity, such as an email, and updates the case with relevant details.<br> The source entity must be accessible and contain relevant case information</li></ul> |
| **automationLevel**      | String | No | Defines automation mode for the action. This applies to case resolution only. If this value isn't provided, the agent uses the mode configured by the administrator.<br>Values: <ul><li>**Full**: AI agent resolves the case automatically without customer service representative (service representative or representative) intervention.</li>, <li>**Semi**: AI agent drafts resolution emails but requires service representative's review and approval</li></ul> |
| **sourceContextEntity** | String | Yes | This is a required value for case enrichment and optional for case resolution. The source entity, such as an email or a conversation that must be used to update the case.<br>Example: `"emails(0e20cf92-f663-f011-bec1-000d3a3622ba)"` |


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

In the example below, you can invoke Case Management Agent from Dataverse plugins or custom code by executing the `msdyn_invokeCaseProcessingAgent` organization request. The agent is used to update the case using a related email entity and then resolve the case with full automation.


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
    "msdyn_actions": "[{\"action\":\"enrich\",\"sourceContextEntity\":\"emails(0e20cf92-f663-f011-bec1-000d3a3622ba)\"},{\"action\":\"resolve\",\"automationMode\":\"Full\"}]"
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
