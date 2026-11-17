---
title: Account and contact insights in Copilot and agents (preview)
description: Learn how account and contact insights answer customer questions in Copilot and agents for Dynamics 365. Explore insight cards and verify answers.
ms.date: 11/17/2026
ms.update-cycle: 180-days
ms.topic: overview
ms.service: dynamics-365-sales
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ms.custom: ignite-2026
author: udaykirang
ms.author: udag
ms.reviewer: eboocock
ai-usage: ai-assisted
search.audienceType:
  - admin
  - enduser
---

# Account and contact insights in Copilot and agents (preview)


Insights aren't tied to one page. The same account and contact insights that appear on account and contact canvases also help agents and other AI experiences answer questions. Ask about an account or contact to get consistent answers wherever you work.

This article describes where the insights appear, what an insight card shows, how the insights stay consistent and secure, and what admins need to know.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Prerequisites

- Your admin sets up insights in Canvas Studio. When setup finishes, Microsoft insights for account and contact turn on. For more information, see [Set up and configure insights](set-up-configure-insights.md).
- Copilot credits are set up for your environment.
- Your organization uses an agent that shows the insights, such as Service agent, Sales agent, or Copilot Cowork.

## Where account and contact insights appear

| Agent | What you see |
|---|---|
| Canvas | [Account](use-account-canvas.md) and [contact](use-contact-canvas.md) insights as part of the canvas, with the insight card. |
| Service agent | Account and contact insights as part of the agent's answer, as text or with the insight card. |
| Sales agent | Account and contact insights as part of the agent's answer. |
| Copilot Cowork | Account and contact insights when Cowork decides your request needs them. Cowork can use Dynamics 365 skills, agents, and tools, so it doesn't include insights in every answer. |

In this preview, agents don't show the full canvas, and CRM Canvas Designer isn't available inside Copilot. To see every insight, component, and related record for a customer, open the account or contact canvas.

## How agents use customer insights

When your request needs customer context, such as an account overview, the agent retrieves the account or contact record and its insights from Dynamics 365. It then answers in its own words, with or without the insight card.

For example, while working on a case, you ask Service agent, "Give me an account overview." The agent finds the customer's account, retrieves its insights, and includes them in its answer. You see the same insights that a seller sees on the account canvas without leaving the conversation.

## What an insight card shows

An *insight* is a card that tells you what's important now about an account or a contact, with the evidence. On account or contact, insight cards appear in **What's important now**. In an agent, the same insight can appear in the agent's answer as text or as an insight card.

Each insight card shows:

- What the insight found, such as a number of days or a list of deals, often with a chart.
- An information button that explains what the insight measures.
- When it was calculated, such as *As of 21 Oct 2026*.
- For some insights, an action in the card's footer.

Insights are calculated from your organization's own Dynamics 365 data. They show only what you have access to.

### Default insights

The following table lists the default insights for account and contact. These insights turn on automatically after your admin sets up insights. Your admin can turn off individual insights and add custom insights created by your organization.

| Insight | Record type | What it tells you |
|---|---|---|
| Account Engagement Recency | Account | Whether anyone at the account engaged in the last 14 days. |
| Account Momentum | Account | Whether the account is speeding up, steady, or slowing. |
| Competitor Risk | Account | The competitor active on open opportunities, and the deals it affects. |
| Deal Risk Signals | Account | Open deals at risk, the champion's status, and where a competitor is present. |
| Deal Stage Distribution | Account | Open deals by sales stage. |
| Engagement Concentration | Account | Whether communication depends on one contact instead of the wider buying group. |
| Open Issues Risk | Account | Risk from the number, priority, and age of open support cases. |
| Service Health Summary | Account | Open cases, the most urgent ones, and cases that keep coming back. |
| Stakeholder Change Alerts | Account | People joining, leaving, or changing roles at the account. |
| Win Rate | Account | The account's win rate over 12 months, compared with your organization's average. |
| Executive Engagement Tracker | Contact | Senior stakeholders by how recently each engaged back, and executive roles with no relationship. |
| Contact Two-Way Engagement Recency | Contact | Days since the contact last engaged back. |
| Contact Outbound Outreach Recency | Contact | Days since your team last reached out, whether or not the contact replied. |
| Meeting Cadence | Contact | Whether meetings with the contact are rising, steady, or falling: the last 30 days compared with the 30 days before. |

### How insights stay consistent across agents and canvases

The insights that an agent gets are the ones already calculated for the record. They have the same values and the same *As of* time as the cards in **What's important now** on the canvas. An insight means the same thing in an agent as it does on the canvas, because both use the tables and business instructions configured for insights.

Agents use the insights that are turned on in **Manage insights**. Insights are turned on or off for the whole organization, so if your admin turns an insight off, agents don't get it either.

### Data access

An agent can access only the Dynamics 365 data that you can already read. Insights respect your Dataverse security settings, and insights don't grant additional access to data:

- Insights exclude related data that you can't access.
- Insights might differ for users with access to different records.
- If you can't read a record, the agent doesn't show its insights or reveal whether the record exists.

### Answers you can verify

Each answer that uses an insight identifies its source, states when it was calculated, and links to the full account or contact canvas. When there isn't enough data for an insight, the agent says so instead of guessing.

## Shared conversations

An agent retrieves insights for the user making the request.

An insight card appears only when everyone in the conversation has the required license and can read the record. Insight cards don't appear in shared conversations, such as a Microsoft Teams group chat. Instead, the agent responds with text and includes a link to the record.

## Manage insights for agents

Admins manage the insights that agents use in **Manage insights**. There's no separate list of insights for agents.

- **Turn insights on or off.** In Canvas Studio, select **Manage insights**, and then use the switch on an insight card in the insights library. To turn every insight off or on together, use **Disable all** or **Enable all**. For more information, see [Create and manage custom insights](create-manage-custom-insights.md).
- **Define the context for insights.** The tables in **Your business data** and the instructions in **How your business works** apply to insights wherever they appear, including in agents. Changes to this organization-wide context can affect every insight that uses it.
- **Agents continue to respond.** If the account or contact canvas isn't turned on for your organization, the agent answers as it did before, without an error.
- **Copilot credits.** Viewing an insight or an insight card doesn't use Copilot credits. Calculating insights uses your organization's Copilot credits. If credits run out, insights keep their last result and *As of* date until you add capacity.

## Unable to see insights in an agent

If an agent doesn't show account or contact insights, check the following conditions:

- Check whether you can open the account or contact record directly in Dynamics 365.
- Check whether the insight appears on the record's account or contact canvas. 
- Ask your admin whether the insight is turned on and whether you have the required license.

If the agent responds with text and a link instead of an insight card, you might be in a shared conversation. Insight cards don't appear in shared conversations. Open the link to view the insight on the record's canvas.  
Insights might not immediately reflect new data because insights refresh information periodically. Initial synchronization can take up to two hours after insights setup.

## Related information

- [Insights overview for administrators](insights-overview.md)
- [Set up and configure insights](set-up-configure-insights.md)
- [Create and manage custom insights](create-manage-custom-insights.md)
- [Use context-aware canvases](context-aware-canvases-overview.md)
- [Overview of CRM Canvas Designer](canvas-overview.md)
- [Use the canvas experience for accounts](use-account-canvas.md)
- [Use the canvas experience for contacts](use-contact-canvas.md)
