---
title: Quick start guide:Connect a custom agent to Recommended Actions
description: Connect a custom agent to Recommended Actions in Dynamics 365 Sales, enable its target table, and send prioritized seller suggestions through Dataverse MCP.
ms.date: 11/12/2026
ms.update-cycle: 180-days
ms.topic: how-to
ms.service: dynamics-365-sales
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.custom: bap-template
ai-usage: ai-assisted
---

# Quick start guide: Connect a custom agent to Recommended Actions


The Recommended Actions Agent in Dynamics 365 Sales shows sellers prioritized suggestions on their list pages and on **Sales home**. You can connect your own agent so that its suggestions are ranked and shown alongside the Microsoft-provided suggestions.

This quick start guide helps you quickly connect your custom agent to Recommended Actions Agent.

For the detailed guide, see the following resources:

- [Custom agent onboarding for Recommended Actions: Detailed guide](custom-agent-onboarding-recommended-actions-detailed-guide.md): Learn about ranking signals, custom tables, Power Automate flows, and code samples.
- [Connect to Dataverse with model context protocol in Microsoft Copilot Studio](/power-apps/maker/data-platform/data-platform-mcp-copilot-studio): Learn how to connect your agent to Dataverse by using the Model Context Protocol (MCP).

This article describes three steps:

1. Register your agent as a source.
1. Enable related tables (only for tables other than Opportunity, Lead, and Contact).
1. Connect your agent by using the Dataverse MCP Server in Copilot Studio.

For more information, see [Add custom agents for recommended actions](configure-recommended-actions.md#add-custom-agents-for-recommended-actions).

## Prerequisites

- You have the System Administrator role in the environment. Try the steps in a test environment first.
- You have the licenses that Recommended Actions requires. For applicable commercial licensing terms and use rights, see the [Dynamics 365 licensing guide](https://go.microsoft.com/fwlink/?LinkId=866544).
- In **Dynamics 365 AI hub** > **Create and manage agents** > **Prerequisites**, every item shows **Done**. If an item doesn't, select **Set up** next to it. Recommended Actions uses Copilot credits.
- The account that your agent uses to connect to Dataverse has access to Recommended Actions.

## Step 1: Register your agent

Register your agent as a recommendation source. Its **Source ID** identifies the source of each suggestion.

1. From lower-left corner of the Sales Hub app, select **Change Area** > **App Settings**.
1. Select **Dynamics 365 AI hub** > **Create and manage agents**.
1. Open **Recommended Actions**. If it isn't listed, select **Create** > **Recommended Actions** > **Choose**, enter a name, and select **Save**.
1. Select **Sources** > **New custom source**, and enter the following values:

   | Field | Notes | Example |
   |---|---|---|
   | Source name | A descriptive name for your agent | Renewal Agent |
   | Source ID | Short, with no spaces. You need this value in Step 3. | `renewal-agent` |
   | Description | Optionally, provide a description for your agent | Suggests renewal follow-ups |

1. Select **Add**, then **Save** and **Start agent**. If the agent is already on, select **Apply changes**.

Your agent appears under **Custom sources**, and Recommended Actions shows **On**.

If your agent only sends suggestions for opportunities, leads, or contacts, go to [Step 3](#step-3-connect-your-agent-by-using-the-dataverse-mcp-server).

## Step 2: Enable related tables

By default, Recommended Actions supports the Opportunities, Leads, and Contacts tables. If you want to enable suggestions for other tables, import the corresponding solution and add ranking signals. This process has two parts:

- **Import a solution**, which lets suggestions point to the table's records and turns on the suggestions panel.
- **Add ranking signals**, which tell Recommended Actions which columns show how valuable and how urgent a record is.

Neither part creates records or suggestions.

> [!NOTE]
> Recommended Actions already supports accounts as targets and includes ranking signals for them. Import the Account solution only if the Recommended Actions panel doesn't appear on the Accounts list.

### Part 1: Import the solution for your table

1. From the **solutions** folder of the [custom agent onboarding package](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/sales/CustomAgentOnboarding/), get the managed solution for your table:

   | Table | Solution file |
   |---|---|
   | Account | `RecommendedActions_Account_account_managed.zip` |
   | Case | `RecommendedActions_Case_incident_managed.zip` |
   | Email | `RecommendedActions_Email_email_managed.zip` |
   | Appointment | `RecommendedActions_Appointment_appointment_managed.zip` |
   | Task | `RecommendedActions_Task_task_managed.zip` |
   | Phone Call | `RecommendedActions_PhoneCall_phonecall_managed.zip` |
   | Quote | `RecommendedActions_Quote_quote_managed.zip` |
   | Order | `RecommendedActions_Order_salesorder_managed.zip` |
   | Invoice | `RecommendedActions_Invoice_invoice_managed.zip` |

1. Go to [Power Apps](https://make.powerapps.com), import the solution file for your table, and complete the import process. To learn more, see [Import a solution](/power-apps/maker/data-platform/import-update-export-solutions).

To remove a table solution later, go to **Solutions** in Power Apps, select the solution, and then select **Delete**.

For a table that your organization created, see [Enable a custom table](custom-agent-onboarding-recommended-actions-detailed-guide.md#enable-a-custom-table).

### Part 2: Add ranking signals

Recommended Actions shows only suggestions that it ranks as important and time-sensitive. For a newly enabled table, you specify which columns indicate value and urgency. This part isn't needed for Opportunity, Lead, Contact, or Account.

1. Open **Sales Hub** in the same environment and sign in as a System Administrator.
1. Press **F12**, select the **Console** tab, paste the contents of `Set-Table-Signals.js` from the [scripts folder](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/sales/CustomAgentOnboarding/scripts), and press **Enter**. The first time you paste into the console, the browser asks you to type `allow pasting` and press **Enter**. Do this, and then paste the script again. For more details about ranking signals, see [Configure ranking signals](custom-agent-onboarding-recommended-actions-detailed-guide.md#configure-ranking-signals).
1. Enter the details in the following dialog boxes:

   | Dialog box | What to enter | Why | Where to find it |
   |---|---|---|---|
   | **Table** | The table's logical name, for example `quote` or `cr123_project` | Identifies the table whose suggestions are ranked | Power Apps > **Tables** > your table > Properties > *Logical name* |
   | **Value column** | A currency or number column, for example `totalamount` | Tells ranking how **important** a record is. Higher values get higher priority, and records with no value are excluded. | Your table > **Columns** > the column > *Logical name*. Leave the box empty if the table has no value column. |
   | **Due-date column** | A date column, for example `effectiveto` | Tells ranking how **urgent** a record is. Overdue records and records that are due soon get higher priority. | Your table > **Columns**. Leave the box empty if the table has no due-date column. |

   For the provided tables (Quote, Order, Invoice, Case, Email, Appointment, Task, and Phone Call), the columns are entered for you. The following screenshot shows an example of the dialog box for the Value column:

   :::image type="content" source="media/script-value-column.png" alt-text="Screenshot of the Value column dialog box.":::
   > [!NOTE]
   > If you select **Cancel** in any dialog box, the script stops and makes no changes. If a table or column name isn't valid, a dialog box describes the problem (for example, "Column name is String; expected Money / Decimal…"), and nothing is saved. If the table already has ranking settings, a dialog box asks whether to replace them.

1. Review the preview, and select **OK** to save. A backup file of the current settings downloads first. You can use this file to restore previous settings if needed.

The script displays **Saved and verified**. Ranking uses the new settings within an hour.


## Step 3: Connect your agent by using the Dataverse MCP Server

Your agent sends each suggestion by calling the Recommended Actions API `msdyn_PushActionDataToRecommendedActionAgent`. In Copilot Studio, the **Microsoft Dataverse MCP Server** tool can call this API through its **Invoke api** tool.

1. Make sure that the Copilot Studio MCP client is allowed for the environment. In the Power Platform admin center, select the environment, and then go to **Settings** > **Product** > **Features** > **Dataverse Model Context Protocol**.
1. In Copilot Studio, open your agent, and then select **Tools** > **Add a tool** > **Model Context Protocol** > **Microsoft Dataverse MCP Server**. Choose a Dataverse connection, and then select **Add to agent**.

   :::image type="content" source="media/recommended-actions-add-dataverse-mcp-tool.png" alt-text="Screenshot of adding the Microsoft Dataverse MCP Server tool in Copilot Studio.":::

1. Paste the following instruction into the agent's **Instructions**. Replace `renewal-agent` with your Source ID from Step 1, and then select **Save**.

   ```text
   When you find something a seller should do on a Dynamics 365 record, send it to Recommended Actions with the Dataverse MCP tool "Invoke api". Use apiUniqueName "msdyn_PushActionDataToRecommendedActionAgent" and these apiInputs. Every value is a string:
   - msdyn_SourceAgentId: "renewal-agent"
   - msdyn_ActionId: "<table>_<record id>_<today as yyyyMMdd>"
   - msdyn_TargetEntityTypeName: the table's logical name, for example "opportunity"
   - msdyn_TargetEntityId: the record id, lowercase, no braces
   - msdyn_ActionReason: one sentence saying what to do, why, and by when
   - msdyn_ActionUIPayload: this JSON, as a string: {"version":"1.0","payload":{"header":"<short title>","description":"<the reason>","oncardClickActionType":"Navigate","oncardClickActionTypeParameters":"{etn=\"<table>\", id=\"<record id>\", pagetype=\"entityrecord\"}"}}
   - msdyn_ActionPrioritizationData: this JSON array, as a string: [{"actionHeader":"<short title>"},{"actionDescription":"<the reason>"}]
   If the call succeeds, reply "Suggestion sent." If it fails, show the error. Never change the record itself.
   ```
   Under **Model**, select a specific model instead of **Auto**, and then select **Save**. With **Auto**, the test chat might reply "The model returned no content because the response was blocked by content filtering."

    **Values the agent determines for each suggestion**
    
    | Value | Where it comes from | Example |
    |---|---|---|
    | Table | The table's logical name. In Power Apps, go to **Tables** > your table > **Properties**. | `opportunity` |
    | Record ID | The record's ID. Open the record and copy the `id=` value from the browser address bar. | `3aeb00ba-…` |
    | Title | A short heading that sellers see on the suggestion card. | Rescue the overdue deal |
    | Reason | One sentence that explains what to do, why, and by when. | The close date passed on October 21, so call the customer today. |
    
    The instruction converts these values into the seven values that the API requires. To find your Source ID, go to **Sales Hub** > **Recommended Actions** > **Sources**.

1. To verify the connection, in the agent's test chat, ask the agent to send a suggestion for an existing test record. The first time, approve the **invoke_api** request. The agent replies **Suggestion sent**. Your agent still needs its own logic or trigger to determine when to send a suggestion.
   > [!NOTE]
   > The Dataverse MCP Server runs with the connection that you choose when you add the tool. By default, this connection uses the signed-in user's account. Ensure that the signed-in user's account has access to Recommended Actions.

After ranking, eligible suggestions appear on the table's list page. Suggestions might not appear immediately.

> [!NOTE]
>- **Invoke api** can call any Dataverse API that the account can access. Keep the agent's instruction specific, as shown in the example.
>- If you don't have Copilot Studio, you can still send suggestions by using Power Automate flows, other agents, or code samples as described in the [detailed guide](custom-agent-onboarding-recommended-actions-detailed-guide.md).


## What sellers see

Eligible suggestions can appear in **Recommended actions** at the top of the table's list page and on **Sales home**. Selecting a card opens the record.

:::image type="content" source="media/recommended-actions-custom-agent-result.png" alt-text="Screenshot of a Send the proposal suggestion shown above a list of records.":::

## Troubleshooting

| Message or symptom | Resolution |
|---|---|
| "No source agent configuration found" | Ensure that the Source ID in your agent's instruction exactly matches the Source ID from Step 1. |
| "Creating Entity with an invalid parent" | The table isn't enabled yet. Complete Step 2. |
| No suggestions appear after a few hours | Check that the suggestion was received, how it was ranked, and that the table's panel is turned on. Ensure that the table's value and due-date signals are set. |
| "You do not have permission" on the table's list | Ensure that the table is included in the published app, and that the seller has access to the table, its records, and the app. |
| "Access denied" when sending | The account or connection that runs the agent needs access to Recommended Actions. |

## Related information

- [Custom agent onboarding for Recommended Actions: Detailed guide](custom-agent-onboarding-recommended-actions-detailed-guide.md)
- [Configure Recommended Actions agent](configure-recommended-actions.md)
