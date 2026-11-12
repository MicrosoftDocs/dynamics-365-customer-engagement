---
title: Custom agent onboarding for Recommended Actions
description: Learn how to configure ranking signals, enable custom tables, call APIs, and synchronize custom agents with Recommended Actions in Dynamics 365 Sales.
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.date: 11/12/2026
ms.service: dynamics-365-sales
ms.topic: how-to
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Custom agent onboarding for Recommended Actions

This article explains how to integrate a custom agent with Recommended Actions in Dynamics 365 Sales. It includes architecture, ranking-signal configuration, custom-table enablement, Power Automate and API options, authentication, and two-way synchronization.

For the basic onboarding steps, see [Connect a custom agent to Recommended Actions](connect-custom-agent-recommended-actions.md).

## Integration architecture

Your agent decides what a seller should do. Recommended Actions decides whether and when to show the suggestion and ranks it alongside suggestions that Microsoft provides. The integration runs in your Dataverse environment.

1. Your agent, Power Automate flow, or service identifies a follow-up action for a record.
1. The agent calls `msdyn_PushActionDataToRecommendedActionAgent` with its registered Source ID.
1. The intake process validates the Source ID and target table and stores the suggestion in `msdyn_rawactioncatalogue`.
1. Ranking runs on a schedule, approximately every four hours. It reads signals from the record, applies exclusion rules, judges impact and urgency, and scores the suggestion against other suggestions. It then uses the Recommended Actions ranking settings to determine the final priority of the suggestion.
1. The ranked list is stored in `msdyn_prioritizedactioncatalogue` along with the score and whether it's shown or filtered out.
1. Sellers see eligible suggestions in **Recommended actions** on the table's list page and on **Sales home**.
1. Your agent can update or remove its suggestions. Recommended Actions can also notify your agent when a seller marks a suggestion as done or dismisses it. For more information, see [Synchronize suggestions and status](#synchronize-suggestions-and-status).

| Component | Purpose | Where it resides |
|---|---|---|
| Your agent, flow, or service | Finds an action that a seller should take and sends the suggestion. | Copilot Studio, Power Automate, Azure AI Foundry, a partner platform, or your application. |
| Registered source | Identifies your agent and allows intake to accept its suggestions. | Recommended Actions configuration in Dataverse. |
| Push API | Receives a suggestion from your agent. | Dataverse custom API `msdyn_PushActionDataToRecommendedActionAgent`. |
| Raw-action intake | Validates and stores suggestions before ranking. | Dataverse in the customer's environment. |
| Ranking | Scores impact and urgency, applies exclusion rules, and selects eligible suggestions. | Recommended Actions processing in the customer's environment. |
| Prioritized-action storage | Stores ranked suggestions for the seller experience. | Dataverse in the customer's environment. |
| Recommended Actions UI | Displays cards to sellers. | Table list pages and **Sales home** in Dynamics 365 Sales. |
| Synchronization API | Exchanges updates, removals, completions, and dismissals. | Dataverse APIs and an optional custom API that your agent provides. |

The onboarding steps configure the following components:

| Onboarding step | What it configures | Where the configuration resides |
|---|---|---|
| Register your agent | Creates the source and Source ID that intake uses to accept suggestions. | Recommended Actions settings under **Dynamics 365 AI hub** > **Recommended Actions Agent** > **Sources**. |
| Import the table solution | Adds two lookup relationships that let suggestions reference the table's records. It also turns on the seller experience by adding the insight card and skill. | Solution components in Dataverse. |
| Add ranking signals | Identifies the table columns that represent record value and urgency. | Ranking-settings JSON. |
| Connect your agent | Establishes the call from your agent to the push API. | Your Copilot Studio tool, Power Automate flow, or application code. |

Keep the following considerations in mind:

- **Identity:** The API call runs as the account that your agent uses to connect. That account needs access to Recommended Actions.
- **Timing:** Ranking runs on a schedule. New ranking settings normally take effect within an hour, and a new suggestion might take up to four hours to appear.
- **Eligibility:** A suggestion can be received and ranked but filtered out because it isn't important or urgent enough. The ranked row records the reason.
- **Display limit:** Sellers typically see one highest-ranked suggestion for a record. If the record already has a higher-ranked suggestion, a newer one might not appear.
- **Environment scope:** Registration, table configuration, ranking settings, and suggestions are specific to the Dataverse environment. 

## Configure ranking signals

Before a suggestion reaches sellers, Recommended Actions scores it by using signals, which are columns read from the target record. Two questions determine most of the result:

- **Impact:** Is the suggestion important? A currency or numeric value usually indicates impact.
- **Urgency:** Is the suggestion time-sensitive? A due date usually indicates urgency.

Opportunity, Lead, Contact, and Account include ranking signals. Other tables don't include signals until you configure them.

### Understand the settings for a new table

The ranking-signals tools configure the following items for a new table.

| Setting | What it reads | How ranking uses it |
|---|---|---|
| Signal `record_state` | The record's `statecode` value. | Determines whether the record is still open. |
| Signal `record_value` | The selected value column. | Measures impact. Higher values have greater impact. |
| Signal `due_date_days` | The number of days until the selected date. | Measures urgency. Negative values indicate overdue records, a few days indicates deadline pressure, and more than 30 days indicates low urgency. |
| Exclusion rule `F-RAA-STATE` | The record's status. | Excludes inactive records. For activity tables, it also excludes canceled records. |
| Exclusion rule `F-RAA-VALUE` | The selected value. | Excludes records with a value of 0 or less. |
| Benchmark `<table>_estimated_value` | Values from active records created during the previous 365 days. | Establishes whether a record value is high or low for the organization. With fewer than 10 records, it uses fixed levels of 5,000, 50,000, 250,000, and 1,000,000. |

The tools add the value signal, value exclusion rule, and benchmark only when you specify a value column. They add the urgency signal only when you specify a date column.

All ranking settings are stored in one shared Recommended Actions configuration in the environment, with a section for each table. The configuration isn't a solution component, so use the ranking-signals tools instead of a solution import to change it. Ranking caches this configuration, and changes normally take effect within an hour.

### Review the default columns

The browser tool suggests the following columns for the provided tables. You can select different columns.

| Table | Value column | Due-date column |
|---|---|---|
| Quote (`quote`) | `totalamount` | `effectiveto` |
| Order (`salesorder`) | `totalamount` | `requestdeliveryby` |
| Invoice (`invoice`) | `totalamount` | `duedate` |
| Case (`incident`) | None | `followupby` |
| Email (`email`) | None | `scheduledend` |
| Appointment (`appointment`) | None | `scheduledend` |
| Task (`task`) | None | `scheduledend` |
| Phone Call (`phonecall`) | None | `scheduledend` |

You can choose different columns when you run the tool.

### Use the browser signals tool

Use `Set-Table-Signals.js` from the [scripts folder](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/sales/CustomAgentOnboarding/scripts). The tool:

- Validates the table and column logical names.
- Verifies that you're running the tool on a Dynamics 365 page and determines whether the table is an activity table.
- Verifies that the value column is a Currency, Decimal, Floating Point Number, or Whole Number column and that the due-date column is a Date and Time column. The tool stops and displays a message if a column type isn't supported.
- Suggests default columns for the provided tables.
- Shows a preview of the signals, rules, and benchmark that it will add or update.
- Asks for confirmation before it replaces an existing section for the table.
- Downloads a backup of the current ranking settings.
- Uses a concurrency check to avoid overwriting a simultaneous change.
- Saves the settings and reads them back to verify the update.
- Changes only Recommended Actions ranking settings. It doesn't create or modify business records.

A System Administrator normally runs the tool.

1. Open Sales Hub in the target environment, and sign in as a System Administrator.
1. Press **F12** to open the browser developer tools. Alternatively, right-click the page, and then select **Inspect**.
1. Select **Console**.
1. Paste the contents of `Set-Table-Signals.js`, and then press **Enter**.
   The first time you paste a script, Microsoft Edge or Google Chrome might ask you to type `allow pasting` and press **Enter**. Complete this standard browser safety check, and then paste the script again.
1. Enter the table's logical name.
1. Enter a currency or numeric value column, or leave the value blank if the table has no meaningful value column.
1. Enter a date column, or leave the date blank if the table has no meaningful due date.
1. Review the preview, and then select **OK** to save.

The tool downloads `raa-settings-backup-<date>.json`, saves the changes, and displays **Saved and verified**. Ranking uses the settings within an hour.

The following examples show common configurations:

| Scenario | Table | Value column | Due-date column |
|---|---|---|---|
| Prioritize high-value quotes that expire soon. | `quote` | `totalamount` | `effectiveto` |
| Prioritize overdue invoices by outstanding value. | `invoice` | `totalamount` | `duedate` |
| Prioritize cases that need follow-up soon. | `incident` | Leave blank. | `followupby` |
| Prioritize scheduled tasks by due date. | `task` | Leave blank. | `scheduledend` |
| Prioritize custom projects by budget and target date. | `cr123_project` | `cr123_budget` | `cr123_targetdate` |
| Prioritize custom projects by contract value and go-live date. | `cr123_project` | `cr123_contractvalue` | `cr123_golivedate` |
| Add a custom contract-end date as an urgency signal for opportunities. | `opportunity` | Leave blank. | `cr123_contractend` |

Logical names are lowercase and differ from display names. Tables and columns that your organization creates normally have a publisher prefix, such as `cr123_`. To find the logical names, use the steps in the following section.


### Find table and column logical names

Use logical names, not display names, when you configure ranking signals.

1. Go to [Power Apps](https://make.powerapps.com), and select the environment.
1. Select **Tables**, and then open the table.
1. Select **Properties**, and copy the value in **Logical name**.
1. Select **Columns**, and then open the value or date column.
1. Copy the value in **Logical name**.

For example, the Quote table's logical name is `quote`, its **Total Amount** column is `totalamount`, and its **Effective To** column is `effectiveto`.

### Adjust signals for supported Sales tables

If your organization tracks value or urgency in a different column on Opportunity, Lead, Contact, or Account, use the same browser tool to add that column.

1. Run `Set-Table-Signals.js`.
2. Enter the following values in the tool:
   - Table: opportunity, lead, contact, or account.
   - Value column: your extra value field, or leave empty.
   - Due-date column: your extra date field, or leave empty.

In this mode, the tool only adds or updates two signals, custom_value (strong impact) and custom_due_date (strong urgency). It never removes or changes the shipped signals, exclusion rules, or benchmarks. Running it again replaces only those two signals.

> [!CAUTION]
> Ranking settings apply to all suggestions for the table, including suggestions that Microsoft provides. Test changes in a test environment, keep the downloaded backup, and verify the resulting seller experience before you apply the settings in production.

### Restore ranking settings

Every successful save from the browser tool downloads a backup file named `raa-settings-backup-<date>.json`.

To restore a backup:

1. Open Sales Hub in the environment whose settings you want to restore.
1. Press **F12**, and select **Console**.
1. Paste the contents of `Restore-Signals-Backup.js` from the [scripts folder](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/sales/CustomAgentOnboarding/scripts), and then press **Enter**.
1. Restore the backup in one of the following ways:
   - If the browser tab is still open from the earlier change, confirm that you want to restore the backup held in that tab.
   - Otherwise, open the `raa-settings-backup-*.json` file in a text editor, copy its full contents, paste them in the restore box, and then select **Restore**.

The tool uses the same version check as the save operation and verifies that the restored settings exactly match the backup. Ranking uses the restored settings within an hour.

## Enable a custom table

To enable a table that your organization created, use the package generator. It runs locally in the browser and doesn't upload the table information.

1. Open `Get-Your-Package.html` from the `tools` folder in the [custom agent onboarding package](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/sales/CustomAgentOnboarding/).
1. For **Table**, select **Another table (including your own)**, and enter the table's logical name, such as `cr123_project`.
1. Select **Download package**. The generator creates `RecommendedActions_<table>.zip` with the two relationships, skill, and active insight card that the table needs.
1. Go to [Power Apps](https://make.powerapps.com), select your development environment, and then select **Solutions** > **Import solution**.
1. Import the generated solution.
1. Configure ranking signals for the table by using its value and due-date columns.
1. In Power Apps, open the model-driven app that sellers use.
1. Select **Edit**, add the custom table to the app navigation, and make sure that its list page is available.
1. Select **Save**, and then select **Publish**.
1. Open the custom table's list page in the app, and verify that the **Recommended actions** panel appears.
1. Export the solution from the development environment as a managed solution.
1. Import the managed solution into the test and production environments.
1. Configure ranking signals separately in each target environment.

> [!NOTE]
> The package generator creates an unmanaged solution. Import the generated solution only into a development environment. Distribute a managed solution to test and production environments.

The table solution enables the Recommended Actions relationship and seller experience. It doesn't add records, generate suggestions, or add ranking signals.

For example, you can enable a Custom Deal table named `cr123_customdeal`, use `cr123_amount` as its value column, and use `cr123_duedate` as its due-date column.

## Send suggestions without Copilot Studio

You can send suggestions from Power Automate, another agent platform, or an application that calls the Dataverse API.

### Use Power Automate

You can call the push API directly or use the optional helper flow.

#### Call the Dataverse action directly

1. Create a cloud flow in the target environment.
1. Add the Microsoft Dataverse action **Perform an unbound action**.
1. For **Action name**, select `msdyn_PushActionDataToRecommendedActionAgent`.
1. Provide the seven string values described in [Review the push API parameters](#review-the-push-api-parameters).
1. Build `msdyn_ActionUIPayload` and `msdyn_ActionPrioritizationData` as serialized JSON strings.
1. Add explicit handling for failed calls so that the flow doesn't report success when the API fails.
1. Save and test the flow with an existing test record.

#### Use the helper child flow

The [custom agent onboarding package](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/sales/CustomAgentOnboarding/) includes `RecommendedActions_SendSuggestion.zip` in the `solutions` folder.

1. In Power Apps, select the environment, and then select **Solutions** > **Import solution**.
1. Import `RecommendedActions_SendSuggestion.zip`.
1. When prompted during import, enter the registered Source ID.
1. Create or open a solution that contains your parent flow.
1. Add the **Run a child flow** action.
1. Select **Send suggestion to Recommended Actions (for flows)**.
1. Pass the table, record ID, title, and reason. The helper flow builds the remaining API values.
1. Save and test the parent flow.

The parent flow must be in a solution to call a child flow.

The helper flow builds its action ID as `<table>_<record ID>_<UTC date>`. A second call for the same record on the same day replaces the first suggestion. Review this behavior before you send several different suggestions for one record.

### Use another agent platform

Agents built in Azure AI Foundry, partner platforms, or custom frameworks can use either of these approaches:

- Connect to the Dataverse MCP server at `https://<organization>.crm.dynamics.com/api/mcp`, and use the `invoke_api` tool. Follow the instructions in [Connect your agent by using the Dataverse MCP Server](connect-custom-agent-recommended-actions.md#step-3-connect-your-agent-by-using-the-dataverse-mcp-server).
- Call the Dataverse Web API directly with an OAuth access token.
- Use the Dataverse SDK from a .NET service.

Your administrator must allow the MCP client for the environment. The Dataverse identity used by the agent must have access to Recommended Actions and to the relevant records.

Dataverse MCP usage from outside Copilot Studio might incur charges. For licensing and usage information, see [Use Dataverse Model Context Protocol](/power-apps/maker/data-platform/data-platform-mcp).

## Call the API from code

`msdyn_PushActionDataToRecommendedActionAgent` is an unbound Dataverse custom API. Call it through the Dataverse Web API or SDK.

Before you call the API, register the agent and enable its target table as described in the first two sections of [Connect a custom agent to Recommended Actions](connect-custom-agent-recommended-actions.md).

Choose the execution location based on how your agent runs:

| Situation | Where to run the code |
|---|---|
| Your agent already runs as a service, such as Azure AI Foundry, Semantic Kernel, a bot, or an API. | Run it in that service when the agent decides that a seller should act. |
| You don't have a hosted service. | Use a small Azure Function or Logic App that the agent calls or that runs on a schedule. |
| You're testing the integration. | Use PowerShell, Postman, or the Visual Studio Code REST Client extension on your computer, signed in with your account. |

Don't put client secrets in browser code, source control, or agent instructions. For unattended applications, use a Microsoft Entra application and store credentials in Azure Key Vault.

### Review the push API parameters

The onboarding flow uses the following seven string values.

| Parameter | Description |
|---|---|
| `msdyn_SourceAgentId` | Source ID that you registered in Recommended Actions. Don't use the agent's display name or the source configuration row ID. |
| `msdyn_ActionId` | Stable, unique ID for the suggestion. Sending the same ID again replaces the earlier version. |
| `msdyn_TargetEntityTypeName` | Logical name of the target table, such as `opportunity`. |
| `msdyn_TargetEntityId` | Target record ID in lowercase, without braces. |
| `msdyn_ActionReason` | One sentence that explains what the seller should do, why, and by when. |
| `msdyn_ActionUIPayload` | Card definition as serialized JSON text. |
| `msdyn_ActionPrioritizationData` | Title and reason used for ranking as serialized JSON text. |


### Configure authentication for a service

1. In Microsoft Entra ID, register an application.
1. Create a certificate or client secret, and store it in Azure Key Vault.
1. In the Power Platform admin center, select the environment, and then select **Settings** > **Users + permissions** > **Application users** > **New app user**.
1. Assign a security role that includes the following privileges, and read access to the target records:
 
   | Table | Privileges | Access level |
   |---|---|---|
   | Raw action catalogue (`msdyn_rawactioncatalogue`) | Read, Write, Append, Append To | Organization |
   | Prioritized action catalogue (`msdyn_prioritizedactioncatalogue`) | Read, Write, Append, Append To | Organization |
   | Recommended action source agent config (`msdyn_recommendedactionsourceagentconfig`) | Read | Organization |
   | Sales agent profile (`msdyn_salesagentprofile`) | Read | Organization |
 
   The same privileges apply to any account that sends suggestions, including the connection used by the Dataverse MCP Server in Copilot Studio.
1. Request an access token for the Dataverse scope `https://<organization>.crm.dynamics.com/.default`.

For .NET applications, `ServiceClient` in the `Microsoft.PowerPlatform.Dataverse.Client` package can authenticate and create the Dataverse connection.

### Use the Web API

```http
POST https://<organization>.crm.dynamics.com/api/data/v9.2/msdyn_PushActionDataToRecommendedActionAgent
Authorization: Bearer <access-token>
Content-Type: application/json

{
  "msdyn_SourceAgentId": "renewal-agent",
  "msdyn_ActionId": "renewal_<record-id>_1",
  "msdyn_TargetEntityTypeName": "opportunity",
  "msdyn_TargetEntityId": "<record-id>",
  "msdyn_ActionReason": "The close date passed. Contact the customer today.",
  "msdyn_ActionUIPayload": "{\"version\":\"1.0\",\"payload\":{\"header\":\"Follow up on the overdue opportunity\",\"description\":\"The close date passed. Contact the customer today.\",\"oncardClickActionType\":\"Navigate\",\"oncardClickActionTypeParameters\":\"{etn=\\\"opportunity\\\", id=\\\"<record-id>\\\", pagetype=\\\"entityrecord\\\"}\"}}",
  "msdyn_ActionPrioritizationData": "[{\"actionHeader\":\"Follow up on the overdue opportunity\"},{\"actionDescription\":\"The close date passed. Contact the customer today.\"}]"
}
```

A successful call returns HTTP status `204 No Content`.

### Use the Dataverse SDK

```csharp
var card = JsonSerializer.Serialize(new
{
    version = "1.0",
    payload = new
    {
        header = title,
        description = reason,
        oncardClickActionType = "Navigate",
        oncardClickActionTypeParameters =
            $"{{etn=\"{table}\", id=\"{id}\", pagetype=\"entityrecord\"}}"
    }
});

var ranking = JsonSerializer.Serialize(new object[]
{
    new { actionHeader = title },
    new { actionDescription = reason }
});

var request = new OrganizationRequest(
    "msdyn_PushActionDataToRecommendedActionAgent");
request["msdyn_SourceAgentId"] = "renewal-agent";
request["msdyn_ActionId"] = $"renewal_{id}_1";
request["msdyn_TargetEntityTypeName"] = table;
request["msdyn_TargetEntityId"] = id.ToString("D");
request["msdyn_ActionReason"] = reason;
request["msdyn_ActionUIPayload"] = card;
request["msdyn_ActionPrioritizationData"] = ranking;

service.Execute(request);
```

### Follow payload rules

Apply these rules to every call:

- Send every API input as a string.
- Send `msdyn_ActionUIPayload` and `msdyn_ActionPrioritizationData` as serialized JSON text, not nested JSON objects.
- Use the table's logical name in `msdyn_TargetEntityTypeName`.
- Format the target record ID in lowercase and without braces.
- Use a deterministic `msdyn_ActionId` when repeated calls should update the same suggestion.
- Create a new `msdyn_ActionId` when the action is a different suggestion.
- Keep the title short and make the reason specific, actionable, and time-bound.
- Make the card's target table and record ID match the target parameters.
- Surface API failures in your agent, flow, logs, or monitoring. Don't return a success response when the API fails.

If the API returns "Creating Entity with an invalid parent," the target table isn't enabled. Complete the steps in connecting your agent by using the Dataverse MCP server, specifically [Step 2: Enable related tables](connect-custom-agent-recommended-actions.md#step-2-enable-related-tables), and then retry the call.

## Synchronize suggestions and status

Two-way synchronization keeps the source agent and Recommended Actions aligned.

### Send changes from your agent

| Scenario | API | Parameters and behavior |
|---|---|---|
| Create a suggestion | `msdyn_PushActionDataToRecommendedActionAgent` | Send the seven values described in [Review the push API parameters](#review-the-push-api-parameters). |
| Update a suggestion | `msdyn_PushActionDataToRecommendedActionAgent` | Send the same `msdyn_ActionId` with updated values. The new version replaces the old version after the next ranking run. |
| Remove a suggestion | `msdyn_RAAgent_RemoveActionsV2` | Send `ActionId`, `TargetId`, and `SourceAgentConfigId`, which is the row ID of the registered source. |
| Mark a suggestion as done | `msdyn_SyncActionExecutionStateFromAgent` | Send `msdyn_ActionId`, `msdyn_ActionState` value `2`, `msdyn_TargetEntityId`, and `msdyn_TargetEntityTypeName`. |
| Mark a suggestion as dismissed | `msdyn_SyncActionExecutionStateFromAgent` | Send `msdyn_ActionId`, `msdyn_ActionState` value `3`, `msdyn_TargetEntityId`, and `msdyn_TargetEntityTypeName`. |

Use the same action ID and target identity throughout the suggestion lifecycle.

### Receive seller actions in your agent

Recommended Actions can call a Dataverse custom API that you provide when a seller marks a suggestion as done or gives it a thumbs down.

1. Create a Dataverse custom API.
1. Add the following string inputs:

   | Input | Value |
   |---|---|
   | `ActionId` | ID of the suggestion. |
   | `Action` | `markAsDone` or `thumbsDown`. |
   | `TargetEntityTypeName` | Logical name of the target table. |
   | `TargetEntityId` | ID of the target record. |

1. Implement the API so that it updates your agent's state and prevents the agent from resending an action that the seller completed or dismissed.
1. In the registered source configuration, set **Sync action execution state API config** to:

   ```json
   {
     "syncactionuistatusapiname": "<your-custom-api-unique-name>"
   }
   ```

1. Test both actions and verify that your agent updates its records.
1. Log failed callbacks and retry them according to your service's reliability policy.

## Verify your integration
 
Use these checks to confirm that a suggestion was received and ranked. Replace `<organization>` and `<action-id>` with your values.
 
1. **Confirm that the suggestion was received.** A row with your action ID exists in the raw action table:
 
   ```http
   GET https://<organization>.crm.dynamics.com/api/data/v9.2/msdyn_rawactioncatalogues?$filter=msdyn_actionid eq '<action-id>'&$select=msdyn_actionid,statecode,statuscode,createdon
   ```
 
   If no row exists, check the API response and the [payload rules](#follow-payload-rules).
 
1. **Run ranking now (optional).** Ranking runs after every four hours. To run it immediately, call:
 
   ```http
   POST https://<organization>.crm.dynamics.com/api/data/v9.2/msdyn_RAAgent_TriggerRecommendedActionsAgentOrchestration
   Content-Type: application/json
 
   { "InputData": "{}", "msdyn_RequestJson": "{}" }
   ```
 
   Wait for a few minutes before you continue.
 
1. **Confirm that the suggestion was ranked.** Query the prioritized action table:
 
   ```http
   GET https://<organization>.crm.dynamics.com/api/data/v9.2/msdyn_prioritizedactioncatalogues?$filter=msdyn_actionid eq '<action-id>'&$select=msdyn_actionid,msdyn_actionscore,msdyn_hascrossedfloor,msdyn_actionuistatus,msdyn_scoredetails
   ```
 
   | Column | Expected value | If not |
   |---|---|---|
   | `msdyn_actionscore` | A value from 0 to 10 | Ranking didn't process the suggestion yet. Wait or run ranking again. |
   | `msdyn_hascrossedfloor` | `false` | The suggestion was filtered out. `msdyn_scoredetails` explains why, for example no value or an inactive record. |
   | `msdyn_actionuistatus` | `1` (Active) | The suggestion was marked done or dismissed. |
 
1. **Confirm what sellers see.** Open the table's list page in Sales Hub, and check **Recommended actions**. Sellers typically see one top-ranked suggestion per record.

### Developer reference

| Goal | API or configuration |
|---|---|
| Update a suggestion. | Call `msdyn_PushActionDataToRecommendedActionAgent` again with the same `msdyn_ActionId`. The newest version replaces the earlier version after the next ranking run. |
| Remove a suggestion. | Call `msdyn_RAAgent_RemoveActionsV2` with `ActionId`, `TargetId`, and `SourceAgentConfigId`. Use the source configuration row ID, not the Source ID. |
| Mark a suggestion as done or dismissed. | Call `msdyn_SyncActionExecutionStateFromAgent` with `msdyn_ActionId`, `msdyn_ActionState`, `msdyn_TargetEntityId`, and `msdyn_TargetEntityTypeName`. Use state `2` for done and state `3` for dismissed. |
| Receive seller actions. | Provide a custom API that accepts `ActionId`, `Action`, `TargetEntityTypeName`, and `TargetEntityId`. Add its unique name to **Sync action execution state API config**. |

## Related information

- [Connect a custom agent to Recommended Actions](connect-custom-agent-recommended-actions.md)
- [Configure Recommended Actions Agent](configure-recommended-actions.md)
- [Use Dataverse Model Context Protocol](/power-apps/maker/data-platform/data-platform-mcp)
