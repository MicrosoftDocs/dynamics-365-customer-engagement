---
title: Create business functions with Business Function Builder (preview)
description: Use Business Function Builder to create a business function in Sales Research Agent. Confirm tables and relationships, then validate the results before sharing.
ms.date: 10/30/2026
ms.topic: how-to
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ai-usage: ai-assisted
---

# Create business functions with Business Function Builder (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Business functions help Sales Research Agent understand your organization's business context, data structure, and requirements. Business Function Builder is a guided experience: you describe what you want, the builder discovers your data and drafts the business function, and you review and refine it. You don't need to write code or fill in fields first.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Prerequisites

Before you start, ensure that you:

- [Sales Research Agent](configure-sales-research-agent.md) is enabled for your Dynamics 365 Sales environment.
- Admin [grants you access to Sales Research Agent](configure-sales-research-agent.md#grant-access-to-the-sales-research-agent) in Sales Hub and permission to manage business functions.
- Have access to the Dynamics 365 Sales environment that contains the data you want the business function to use.
- Understand the use case you want to support, such as account planning or pipeline review.

## Open Business Function Builder

1. In Sales Hub, open **Sales Research Agent**.
2. Select **Manage business functions**.

The **Manage business functions** pane lists the business functions in your environment and opens the compose box, where you describe a new one.

:::image type="content" source="media/business-function-builder-compose.png" alt-text="Screenshot of the Manage business functions pane with the compose box and the list of business functions.":::

## Step 1: Describe the business function

In the compose box, describe what you want the business function to help users do: the business area, the audience, the data that matters, and the outcomes users expect.

Provide intent in either of these ways:

- Type a description in natural language. For example, "I want to help my account executives analyze their top 20 accounts to identify upsell and cross-sell opportunities. Focus on account revenue, product adoption, support tickets, and interaction history over the last 12 months."

- Select a suggested scenario, such as **Sales Pipeline**, **Account Management**, or **Territory Planning**, and then update the prompt to fit your organization.

> [!NOTE]
> Don't submit an empty prompt. Provide intent, such as a description or referenced tables, so the builder has something to work from.

### Add reference content

Reference content can help the builder understand how your organization works. Examples include sales playbooks, methodology documents, KPI definitions, implementation notes, onboarding guides, or process documentation.

Use the supported file types shown in the upload experience.

Submit the description to start the build. The left pane shows progress as the builder scans your data, designs the business function, writes instructions, and generates evaluation test cases.

## Step 2: Answer clarification questions

The builder asks clarification questions when it needs your judgment, for example which process should anchor the exploration. Select the option that matches how your organization works, or select **Other** and describe it.

:::image type="content" source="media/business-function-builder-clarification-question.png" alt-text="Screenshot of a clarification question in Business Function Builder, with quota attainment against account plans selected.":::

If you'd rather let the builder decide, select **Skip all**. The builder uses its own judgment, and you can correct the result later.

## Step 3: Confirm the tables to explore

The builder proposes the tables most relevant to your description. Each table shows its schema name and a short reason why it was included.

The tables the builder finds first are the *anchor tables*. Anchor tables aren't the only tables the business function uses. The builder uses them as grounding and then expands from there to find related tables, columns, and relationships as needed.

Review the proposed anchor tables and make changes as needed:

- Keep tables that are central to the use case.
- Select **Add tables** to search for and add tables the builder missed, including custom tables.
- Remove tables that your organization doesn't use.
- Review table and column descriptions if the agent appears to misunderstand the schema.

When the list looks right, confirm it.

:::image type="content" source="media/business-function-builder-confirm-tables.png" alt-text="Screenshot of the Confirm tables to explore step, with proposed tables, their reasons, and a table added by the user.":::

> [!TIP]
> Custom tables and columns work best when they have clear descriptions. If descriptions are missing or ambiguous, add natural-language data instructions to the business function after it's drafted.

## Step 4: Review the table relationships

The builder explores how the confirmed tables connect and shows them as a relationship map. These relationships let the agent answer questions that span several tables, for example attainment by account plan and territory, instead of guessing at joins.

:::image type="content" source="media/business-function-builder-table-relationships.png" alt-text="Screenshot of the Exploring table relationships map, with connected tables highlighted.":::

## Step 5: Review and save the business function

When the build finishes, the business function opens in the editor. The editor has four tabs:

| Tab | What it contains |
|---|---|
| **Overview** | The description and the instructions: purpose and scope, core entities and roles, business rules and status logic, process and lifecycle, metrics and measures, analytics guidance, and caveats. |
| **Tables and columns** | The tables, columns, and relationships the business function uses. |
| **Evaluation** | Generated test questions and evaluation results. See [Validate the business function](#validate-the-business-function). |
| **Starter prompts** | The prompts users see, and their default blueprints. |

:::image type="content" source="media/business-function-builder-overview.png" alt-text="Screenshot of the Overview tab of a drafted business function, showing the description and the instructions in preview mode.":::

Review the instructions carefully. They're written in plain language so you can verify them, and they're what the agent follows when it answers. Pay special attention to:

- How metrics are calculated, for example whether attainment sums targets and actuals or averages a percentage.
- Stage, status, and forecast definitions, such as which statuses count as active.
- Custom tables and activity tables.

To change the instructions, select **Edit markdown**, or describe the change in the refine box in the left pane ("Tell me what to refine"). Select **Save** to save the business function.

The saved business function becomes available in Sales Research Agent, subject to your environment and permissions.

## Validate the business function

When the build finishes, the business function opens in the editor. The editor has four tabs:

| Tab | What it contains |
|---|---|
| **Overview** | The description and the instructions: purpose and scope, core entities and roles, business rules and status logic, process and lifecycle, metrics and measures, analytics guidance, and caveats. |
| **Tables and columns** | The tables, columns, and relationships the business function uses. |
| **Evaluation** | Generated test questions and evaluation results. See [Evaluate a business function](sales-research-agent-business-function-builder-evaluate.md). |
| **Starter prompts** | The prompts users see, and their default blueprints. See [Create and manage starter prompts](sales-research-agent-starter-prompts.md). |

:::image type="content" source="media/business-function-builder-evaluation.png" alt-text="Screenshot of the evaluation experience in Business Function Builder.":::

Review the instructions carefully. They're written in plain language so you can verify them, and they're what the agent follows when it answers. Pay special attention to:

- How metrics are calculated, for example whether attainment sums targets and actuals or averages a percentage.
- Stage, status, and forecast definitions, such as which statuses count as active.
- Custom tables and activity tables.

To change the instructions, select **Edit markdown**, or describe the change in the refine box in the left pane (*"Tell me what to refine"*). Select **Save** to save the business function.

## Next steps

The left pane suggests three next steps when your business function is ready:

1. **Check the results hold up.** [Validate the business function](#validate-the-business-function) against your data.
2. **Help people get to answers faster.** Add starter prompts and create default blueprints in the **Starter prompts** tab.
3. **Share it with your team.** [Share the business function](sales-research-agent-business-function-builder-share.md).

## Related information

- [Business Function Builder overview](sales-research-agent-business-function-builder.md)
- [Share business functions in Business Function Builder](sales-research-agent-business-function-builder-share.md)
- [Sales Research Agent overview](sales-research-agent.md)
- [Analyze your sales performance using the Sales Research Agent](use-sales-research-agent.md)
- [Connect the Sales Research Agent to a different data source](sales-research-agent-connect-data.md)
- [Provide context to enhance the Sales Research Agent](sales-research-agent-provide-context.md)
