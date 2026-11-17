---
title: Insights overview (preview)
description: Learn how insights use Dynamics 365 tables and business knowledge to power relevant insights and actions on canvases.
ms.date: 11/17/2026
ms.update-cycle: 180-days
ms.topic: overview
ms.service: dynamics-365-sales
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ai-usage: ai-assisted
---

# Insights overview (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Insights give Copilot and agents the business context they need to surface relevant customer, sales, and service information from Dynamics 365. They combine your Dataverse data with plain-language instructions about your processes and terminology, helping canvases and agents deliver more useful insights and actions.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

Insights settings have organization-wide scope. Configure them once to provide shared business context to supported canvases and agents. 

Insights aren't tied to one page. They appear on account and contact canvases and in agents such as Service agent and Sales agent. Copilot Cowork can also use them when your request needs customer context. Learn more in [Account and contact insights in Copilot and agents](insights-in-agents.md).


## How insights work

Insights bring together the following elements:

- **Business data:** A semantic model identifies the Dataverse tables that Copilot can use. Microsoft includes the tables required by its predefined experiences, and you can add standard or custom tables.
- **Business knowledge:** Business skills describe your processes, policies, terminology, and table relationships in plain language.
- **Customer context settings:** Settings can help Copilot account for duplicate customer records and interpret activity sentiment.
- **Insights, canvases, and agents:** Supported canvases and agents use the configured context to present record-specific insights and actions.

The semantic model and business skills don't change your Dataverse records. They provide context that Copilot uses when it generates or refreshes supported insights. Learn more about how to set up and configure insights in [Set up and configure insights](set-up-configure-insights.md).

## How tables contribute context

Insights can combine information from multiple related tables. The exact data available on a canvas depends on the tables you include, their relationships, the canvas design, and the user's permissions.

| Table | Example context for a canvas |
|---|---|
| Account | Customer profile, open opportunities, contacts, cases, recent engagement, and account-level risks. |
| Contact | Role, account relationship, recent activities, meeting cadence, and outreach history. |
| Opportunity | Deal value, stage, close date, stakeholders, competitor involvement, and recent activity. |
| Lead | Source, qualification status, engagement history, related account or contact, and next steps. |
| Case (`incident`) | Priority, status, age, service-level agreement information, recurring issues, and customer impact. |
| Email | Conversation history, inbound and outbound engagement, response recency, and sentiment signals for related records. |

Email commonly contributes activity context to account, contact, opportunity, lead, and case canvases. A default canvas might not be available for every table. Canvas availability depends on your organization's configuration. Learn more in [Create and Publish a Canvas in CRM Canvas Designer (Preview)](configure-canvas.md).

You can also add custom tables. For example, a manufacturer might add an **Installed asset** table so an account canvas can consider product ownership and maintenance history.

## Business skills

A business skill explains how your organization uses its data. It can define:

- How tables and fields relate to a business process.
- The meaning of organization-specific terms.
- Which calculations or time periods to use.
- How Copilot should interpret a status, tier, risk, or policy.

For example, create a business skill that explains:

> A strategic account is an active account with an annual revenue greater than 10 million USD or an Account tier value of Tier 1. Use the organization's fiscal quarters, which start on July 1.

With this instruction, insights can apply your definition consistently instead of relying on a generic interpretation of *strategic account* or *quarter*.

## Example: Prepare for an account renewal

Consider a seller preparing for a renewal meeting with Alpine Ski House. A context-aware account canvas can bring together:

- The account's segment and annual revenue.
- Contacts involved in the renewal and their recent engagement.
- An opportunity scheduled to close this quarter.
- Two high-priority cases opened during the past month.
- Recent email exchanges that show slower customer responses.

The canvas can use this combined context to highlight the open service issues, declining engagement, and approaching close date. The seller gets a more complete view than they would from the account table alone.

## What you can configure

Use the **Insights management settings** to manage:

- **Your business data:** Choose the standard and custom tables Copilot can read. In Power Apps, this configuration is the semantic model.
- **How your business works:** Select or create business skills that apply your organization's terminology and processes.
- **Insights:** Turn supported insights on or off for your organization.
- **Duplicate detection:** Define how insights should account for duplicate account or contact records without merging or changing the records.
- **Activity sentiment:** Configure how supported experiences interpret sentiment from activities such as emails.

Learn more in [Set up and configure insights](set-up-configure-insights.md).

## Planning recommendations

- Start with a focused set of tables that answer important business questions.
- Add table and column descriptions so Copilot can understand their purpose.
- Verify that the required table relationships exist and accurately represent your business.
- Write business skills as if you're briefing a new employee. Include definitions, steps, exceptions, and time periods.
- Test insights with representative records and users who have different security roles.
- Review table additions for Dataverse search and storage impact.

## Copilot credits

Insights use your organization's Copilot credits:

- Calculating insights, including Microsoft-provided insights and the custom insights you create, uses credits.
- Creating or changing a custom insight uses credits.
- Viewing an insight doesn't use credits.
- Turning on the default canvases and customizing them doesn't use credits.

If your organization's credits run out, canvases keep working. Insights keep their last result and stop updating until more credits are available.

## Security and data considerations

- Users see only data that they have permission to access in Dataverse.
- Adding a table doesn't grant users access to its records.
- The semantic model uses Dataverse search to index configured data and can use Dataverse storage capacity.
- Initial semantic-model synchronization can take up to two hours.
- Changes to organization-wide context can affect every supported insight that uses that context.
- If an insight can't access required data, it might provide a partial result or explain the limitation.

## Related information

- [Set up and configure insights](set-up-configure-insights.md)
- [Create and manage custom insights](create-manage-custom-insights.md)
- [Account and contact insights in Copilot and agents](insights-in-agents.md)
- [Use context-aware canvases](context-aware-canvases-overview.md)
- [Fine-tune semantic model signals](/power-apps/maker/data-platform/fine-tune-semantic-model-signals)
- [Create and use business skills](/power-apps/maker/data-platform/data-platform-business-skills)
- [Manage participation in Work IQ](/power-platform/admin/business-applications-work-iq/manage-participation)
