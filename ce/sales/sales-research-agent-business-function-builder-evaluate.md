---
title: Evaluate a business function (preview)
description: Learn how to evaluate a business function with test questions, graded results, and feedback. Run an evaluation to improve answers on your data.
ms.date: 10/21/2026
ms.topic: how-to
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ai-usage: ai-assisted
---

# Evaluate a business function (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Evaluate a business function against your data before users rely on its answers. Built-in evaluation runs a set of test questions against your environment, grades every answer, and explains each grade, so you can find and fix problems before they reach users.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Prerequisites

- You [created a business function](sales-research-agent-business-function-builder-create.md) and have permission to edit it.

## Review the test questions

1. Open the business function and select the **Evaluation** tab.
2. Review the generated test questions. Each question is grounded in the discovered schema and data, and shows:
   - The tables it uses.
   - **Why this was suggested**: the expected output, for example *a ranked list of account plans with attainment ratio categories* or *a time-series trend*.
3. Adjust the set:
   - Select the edit icon to reword a question.
   - Select the delete icon to remove a question.
   - Select **Add questions** to add your own.
   - Select **Regenerate questions** to generate a new set.

While you review, you can also star the questions your users will ask most to make them starter prompts. See [Create and manage starter prompts](sales-research-agent-starter-prompts.md).

:::image type="content" source="media/bfb-test-questions-starter.png" alt-text="Screenshot of the Evaluation tab with test questions, suggested reasons, and starred questions.":::

## Run the evaluation

Select **Evaluate**. The evaluation captures a response for every test question and then grades each response. A progress bar shows the stage and the estimated remaining time. Depending on the number of questions and the size of your data, evaluation can take several minutes.

## Review the results

When the evaluation completes, the summary shows the overall score and the number of passed and failed checks. Each response is graded on three criteria:

| Criterion | What it checks |
|---|---|
| **SQL Relevance** | Whether the query the agent generated fits the question that was asked. |
| **Business Function Alignment** | Whether the answer follows the instructions, rules, and definitions in the business function. |
| **Schema Contract Accuracy** | Whether the query used the tables, columns, joins, and aggregations the way the business function's schema contract requires. |

:::image type="content" source="media/bfb-eval-results.png" alt-text="Screenshot of business function evaluation results with a 90 percent score, pass and fail counts, and per-question grades.":::

Use the filters, such as **Fail any** and **Needs your input**, to focus on the responses that need attention.

### Understand a failed check

Expand a question to see the response overview and the **Reasoning** for each criterion. The reasoning explains exactly what the agent did and how it differs from what the business function requires.

For example, a question about attainment trends by territory might pass **Business Function Alignment** but fail **SQL Relevance**, because the query averaged a precalculated attainment percentage when the business function's rule says to sum the targets and the actual values. A mistake like this produces a plausible but wrong number, which is why it's worth catching before users see it.

:::image type="content" source="media/bfb-eval-reasoning.png" alt-text="Screenshot of a failed question with reasoning for SQL relevance, business function alignment, and schema contract accuracy.":::

## Give feedback and refine

Evaluation shows you where to look. Your judgment decides what to change.

1. In an expanded response, use the thumbs up or thumbs down next to **Is this section as expected?**
2. If it isn't, describe what's wrong and what should happen instead in **How can this be improved?** Be specific, for example *"Sum the target and attained values instead of averaging the attainment percentage."* Feedback can be up to 500 characters.
3. Select **Flag for improvement**.

   :::image type="content" source="media/bfb-eval-flag.png" alt-text="Screenshot of the feedback dialog with guidance to sum targets and actual values and a Flag for improvement button.":::

4. When you review the responses you care about, select **Suggest updates**. The builder proposes changes to the business function based on your feedback.
5. Review the proposed changes, save the business function, and run the evaluation again.

You can also refine the business function directly in the left pane by describing the change in plain language.

## Best practices

- Don't aim for a perfect score at the expense of realistic questions. Keep questions that reflect what users actually ask.
- Read the reasoning on passed questions too, especially for metrics that drive decisions.
- Reevaluate after you change the instructions, the tables, or your schema.

## Related information

- [Business function overview](sales-research-agent-business-function-builder.md)
- [Create business functions with Business Function Builder (preview)](sales-research-agent-business-function-builder-create.md)
- [Create and manage starter prompts (preview)](sales-research-agent-starter-prompts.md)
