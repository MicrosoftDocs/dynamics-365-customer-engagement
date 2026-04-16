---
title: Review and approve suggestions from Data Enrichment
description: Learn how to review and approve suggestions made by the Data Enrichment Agent and revert automatic updates if necessary.
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.date: 02/16/2026
ms.topic: how-to
ms.service: dynamics-365-sales
ms.collection: bap-ai-copilot
---

# Review and approve Data Enrichment suggestions

As a seller, you can review the suggestions made by Data Enrichment for opportunity records that you own and choose to accept or reject them. If your admin has configured Data Enrichment to automatically update fields, you can still review the changes and revert them if necessary.

> [!NOTE]
> Data Enrichment suggestions are available only for opportunity records that individual users own. Team-owned opportunity records aren't supported.

## Prerequisites

Ensure that your admin has set up and configured the AI-powered Data Enrichment feature. Learn more in [Set up and configure AI-powered Data Enrichment](data-enrichment-agent-configure.md).


## Provide consent for Data Enrichment to read your emails

When you open an opportunity record for the first time after Data Enrichment is enabled, you see a prompt asking for your consent to allow the agent to read your emails in Dataverse. Select **Allow** to provide consent. After you provide consent, the agent takes about four hours to analyze your emails and generate suggestions for your opportunity records and link relevant emails. You must provide consent for both automatic updates and manual updates.

> [!NOTE]
> The agent only reads emails that are relevant to opportunities that you own.

## Review and approve suggestions manually

If your admin has configured the agent for manual updates, you need to manually review and approve the suggestions.

1. Open your opportunity record in the Sales Hub app.
   If Data Enrichment has suggestions for the record, you see a notification banner at the top of the form indicating that new suggestions are available.

1. Select **Data Enrichment suggestions** in the notification banner. 
   The **Data Enrichment** pane opens. 
1. In the **Suggestions** tab, hover over the information icon next to each suggestion to see details about the source of the suggestion. Review the suggestions and perform one of the following actions:
   - To accept or reject all the suggestions, select **Accept all** or **Reject all** at the bottom of the pane.
   - To accept or reject individual suggestions, hover over each suggestion and select the **Accept** icon (check mark) or the **Reject** icon (cross mark).
     > [!NOTE]
     >- If you reject a suggestion for an opportunity, you won't see that suggestion again for that opportunity record. There's no option to undo or recover rejected suggestions.
     >- To view the changes you have accepted, select the **History** tab in the Data Enrichment pane. Learn more in [View change history](#view-change-history).

    The changes are applied to the opportunity record immediately after you accept the suggestions. If you're not sure about a suggestion, you can leave it without taking any action. The suggestion remains in the pane until you accept or reject it. However, suggestions are periodically refreshed based on new email interactions, and some suggestions might be removed if they become irrelevant based on updated context.

## Review and revert automatic updates

If your admin has configured Data Enrichment to automatically update fields in your opportunity records, you can review the changes and revert them if necessary.

1. Open your opportunity record in the Sales Hub app.
   If Data Enrichment has updated the record, you'll see a notification banner at the top of the form indicating that new suggestions are available.

1. Select **Data Enrichment suggestions** in the notification banner. 
   The **Data Enrichment** pane opens. 
1. In the **Updates** tab, hover over the information icon next to each suggestion to see details about the source of the suggestion. Review the suggestions and do one of the following:
   - To keep or revert all the changes, select **Keep all** or **Undo all** respectively at the bottom of the pane.
   - To keep or revert individual updates, hover over each suggestion and select the **Keep** icon (check mark) or the **Undo** icon (cross mark) respectively.
   - To keep a few changes and revert the rest, select **Keep** for the changes you want to retain. Then, select **Undo all** at the bottom of the pane to revert the remaining changes; this works both ways.
     If you undo an update, the change is tracked in the **History** tab along with the name of the user who reverted it. Learn more in [View change history](#view-change-history). 

## View emails associated by Data Enrichment

The AI-powered Data Enrichment feature associates emails with an opportunity based on several criteria to ensure relevance and context. The key criteria include:

- **Email participants**: The email involves the seller assigned to the opportunity and at least one contact associated with the opportunity.
- **Relevance**: The email content contains keywords or phrases that indicate relevance to the opportunity, such as mentions of products, services, or deal terms.

**To view the associated emails:**

1. Open your opportunity record in the Sales Hub app.  

1. In the **Timeline** section, look for emails with the agent icon (:::image type="icon" source="media/dea-agent-icon.png" border="false":::). Depending on how your admin has configured the agent, one of the following scenarios applies:

    1. If Microsoft 365 services are enabled for the agent, you would see the related emails from your mailbox. These emails are not tracked by default and are visible only in your timeline. Select **Track** on the email to track it in the opportunity record and make it visible to other users.   
    2. Emails from Dataverse are tracked by default and visible to all users with access to the opportunity record.

1. Select **Not related?** if you believe the email isn't related to the opportunity. You can then select whether you want to remove the email from the current opportunity or reassign it to another opportunity.

## View stakeholder suggestions

When an existing Dynamics 365 contact is added to an email thread related to an opportunity, the AI-powered Data Enrichment feature identifies the contact as a potential stakeholder for the opportunity and suggests adding them as a stakeholder in the opportunity record.

To view the stakeholder suggestions:

1. Open your opportunity record in the Sales Hub app.
1. Select **Data Enrichment suggestions** in the notification banner. 
1. In the Data Enrichment pane, select the **Related records** tab to view the list of suggested stakeholders based on recent email interactions. 
1. Hover over the stakeholder suggestion and select the **Information** icon to view the source of the suggestion.
1. (Manual update) Hover over the suggestion and select the **Accept** icon (check mark) to add the stakeholder to the opportunity record or the **Reject** icon (cross mark) to dismiss the suggestion. 
1. (Automatic update) The stakeholder is added to the opportunity record automatically. Hover over the suggestion and select the **Undo** icon (cross mark) to remove the stakeholder from the opportunity record if you think the suggestion is incorrect.
   To change the stakeholder's role, follow the instructions in [Add stakeholders and decision makers for the opportunity](add-stakeholder.md#add-stakeholders-and-decision-makers-for-the-opportunity).


## View change history

Changes made by the agent for Data Enrichment are tracked separately in the Data Enrichment change history. 
 
The information that you see depends on how Data Enrichment is configured:

- **Automatic updates**: Shows updates made by the agent and any changes you have reverted.
- **Manual updates**: Shows the changes that you have accepted from the suggestions.

**To view the change history:**

1. Open your opportunity record in the Sales Hub app.
1. Select **Data Enrichment suggestions** in the notification banner. 
   The **Data Enrichment** pane opens. 
1. Select the **History** tab to view the list of changes made to the opportunity record based on Data Enrichment suggestions. 