---
title: Create a default blueprint for a starter prompt (preview)
description: Create a default blueprint for a starter prompt. Learn to arrange blocks, add charts and web research, and configure the summary for every user.
ms.date: 11/02/2026
ms.topic: how-to
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ai-usage: ai-assisted
---

# Create a default blueprint for a starter prompt (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

This article shows how to create a default blueprint for a starter prompt and shape it into the answer you want every user to get. To learn what default blueprints are, see [Default blueprints overview](sales-research-agent-default-blueprints.md).

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Prerequisites

- You have permission to edit the business function.
- The business function has at least one [starter prompt](sales-research-agent-starter-prompts.md).

## Create a default blueprint

1. Open the business function and select the **Starter prompts** tab.
2. Next to the starter prompt, select **Create default blueprint**.

   The agent runs deep research on the question against your data and drafts a layout. This process can take a few minutes. To cancel, select **Stop generating**.

   :::image type="content" source="media/default-blueprint-generating.png" alt-text="Screenshot of the Starter prompts tab while a default blueprint is being generated for a starter prompt.":::

3. When the draft is ready, select **Show default blueprint** to preview it below the starter prompt, or **Edit blueprint** to open it in the editor.

## The default blueprint editor

The editor shows the starter prompt and the blueprint as users see it, with your data.

- **Add block** adds a chart, web research, or summary block.
- **Save blueprint** saves your changes.
- **Back to starter prompts** returns you to the **Starter prompts** tab.
- The left pane has two tabs. **Build with AI** lets you describe what you want in plain language. **Configure** shows the settings of the selected block.
- Hover over a block to see its controls. To change a block, select **Edit block** (the pencil). The block opens on its own, and **Build with AI** and **Configure** apply to that block. Select **Back to blueprint** to return to the full layout.
- Chart blocks also show **Show work**, **Expand**, **Delete**, and **More actions** (chart settings, download as image, and copy). Summary blocks show **Show work**, **Expand**, **Copy**, and **Delete**. Web research blocks show **Show details**, **Expand**, **Copy**, and **Delete**.
- Drag the handle in a block's lower-right corner to resize it. To move a block, drag it to a new position.

> [!IMPORTANT]
> If you don't open a block with **Edit block**, a request in **Build with AI** rebuilds the whole blueprint and replaces the current one. To change a single block, open it with **Edit block** first.

> [!NOTE]
> A chart block's title in **Configure** is also its prompt, so it can differ from the heading shown on the chart. Changing it regenerates the block.

:::image type="content" source="media/default-blueprint-editor.png" alt-text="Screenshot of the Edit default blueprint page with the Build with AI pane, key metrics, analysis, and charts.":::

## Resize and arrange blocks

Drag the resize handle in a block's lower-right corner to make it wider or taller, for example so a comparison chart has room for every label. Remove blocks you don't need with **Delete**. Deleting a block takes effect immediately and can't be undone.

## Add a chart block

1. Select **Add block** > **Chart block**.

   :::image type="content" source="media/default-blueprint-add-block.png" alt-text="Screenshot of the Add block menu with Chart block, Web research, and Summary options.":::

2. In the **Build with AI** pane, describe the chart in plain language. For example: *"Show top 5 deals closing the next 6 months."* The chip below the box shows the data source the query runs against.
3. Submit. The agent writes the query through the business function, so the chart follows the same rules and definitions as the rest of the blueprint. It confirms what it did, for example *"Analyzed 5 rows from opportunity. Created a bar chart."*

:::image type="content" source="media/default-blueprint-chart-block.png" alt-text="Screenshot of the default blueprint with a bar chart of the top five upcoming deals and the agent's confirmation in the Build with AI pane.":::

## Configure the summary

The summary block holds the headline metrics, the analysis, and optional recommendations. Select **Edit block** on the summary, and then select the **Configure** tab.

| Setting | What it does |
|---|---|
| **Instructions** | Optional guidance for how the summary is written. |
| **Tone / Style** | **Executive Summary**, **Detailed Technical**, **Concise Bullets**, **Narrative Story**, **Data Focused**, **Formal Report**, or **Casual Friendly**. |
| **Maximum Characters** | The maximum length of the summary. |
| **Include recommendations and action items** | Adds a recommendations section. |
| **Blocks to Include in Summary** | The blocks the summary reads from. Include new blocks, such as a chart you just added, so the summary reflects them. |

:::image type="content" source="media/default-blueprint-summary-tone.png" alt-text="Screenshot of the summary block's Configure tab with the Tone / Style list open.":::

Select **Apply**. The summary regenerates with the new settings. For example, with **Concise Bullets** and recommendations turned on, the analysis becomes a few short lines, followed by recommendations that draw on every included block.

:::image type="content" source="media/default-blueprint-summary-regenerated.png" alt-text="Screenshot of the regenerated summary in concise bullets, with recommendations and its configuration in the left pane.":::

## Add a web research block

Not every answer lives in your CRM. A web research block adds research from the web to the blueprint.

1. Select **Add block** > **Web research**.
2. Describe what to research in the **Build with AI** pane, or enter it as the **Research topic** on the **Configure** tab. Be specific. For example: *"Research general buying sentiment for our key segments in the southwest and call out any recent developments or campaigns that our competitors are running."*
3. On the **Configure** tab, set how far the research reaches:

   | Setting | What it does |
   |---|---|
   | **Approved websites** | Limits research to the websites you add with **Add**. If you don't add any, research can use the entire web. |
   | **Include source citations** | Adds citations to the sources the research used. |
   | **Max websites to crawl** | The maximum number of websites the research reads. |
   | **Max report characters** | The maximum length of the research report. |

   :::image type="content" source="media/default-blueprint-web-research-settings.png" alt-text="Screenshot of the web research block's Configure tab with research topic, approved websites, citations, and limits.":::

4. Submit or select **Apply**. The block shows its progress while it researches, and then shows the report.

:::image type="content" source="media/default-blueprint-web-research-result.png" alt-text="Screenshot of a web research block with an executive summary of regional buying sentiment and competitive activity.":::

Read the result. When the research can't find reliable evidence, it says so. For example, it reports that state-level data isn't available, or declines to attribute campaigns to specific competitors without sources. If a block consistently comes back thin, make the research topic more specific or add approved websites that cover the topic.

## Save the default blueprint

Select **Save blueprint**. The starter prompt now uses this default blueprint for every user who runs it. To change it later, open the **Starter prompts** tab and select **Edit blueprint**. To stop using it, select **Remove blueprint**.

> [!NOTE]
> Saving the blueprint saves its structure and block settings, not the results. Users always get content generated from their own data at run time.

## Related information

- [Default blueprints overview (preview)](sales-research-agent-default-blueprints.md)
- [Create and manage starter prompts (preview)](sales-research-agent-starter-prompts.md)
- [Run a starter prompt with a default blueprint (preview)](sales-research-agent-default-blueprints-use.md)
- [Evaluate a business function (preview)](sales-research-agent-business-function-builder-evaluate.md)
