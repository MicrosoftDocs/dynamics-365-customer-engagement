---
title: Review and approve suggestions from Data Enrichment
description: Learn how to review and approve suggestions made by the Data Enrichment Agent and revert automatic updates if necessary.
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.date: 01/19/2026
ms.topic: how-to
ms.service: dynamics-365-sales
ms.collection: bap-ai-copilot
---

# Review and approve suggestions from Data Enrichment 

As a seller, you can review the suggestions made by Data Enrichment for your opportunity records and choose to accept or reject them. If your admin has configured Data Enrichment to automatically update fields, you can still review the changes made and revert them if necessary.

## Provide consent for Data Enrichment to read your emails

When you open an opportunity record for the first time after Data Enrichment is enabled, you'll see a prompt asking for your consent to allow the agent to read your emails. Select **Allow** to provide consent. After you provide consent, the agent takes about 4 hours to analyze your emails and generate suggestions for the opportunity record. Consent is mandatory for both automatic updates and manual updates.

## Review and approve suggestions manually

If your admin has configured the agent for manual updates, you need to manually review and approve the suggestions made.

1. Open your opportunity record in the Sales Hub app.
   If Data Enrichment has suggestions for the record, you'll see a notification banner at the top of the form indicating that new suggestions are available.

1. Select **See suggestions** in the notification banner to open the **Data Enrichment** pane.
1. In the **Suggestions** tab, hover over the information icon next to each suggestion to see details about the source of the suggestion. Review the suggestions and perform one of the following actions:
   - To accept or reject all the suggestions, select **Apply all** or **Reject all** at the bottom of the pane.
   - To accept or reject individual suggestions, hover over each suggestion and select the **Accept** icon (check mark) or the **Reject** icon (cross mark).
     > [!NOTE]
     >- If you reject a suggestion for an opportunity, you won't see that suggestion again for that opportunity record. There's no option to undo or recover rejected suggestions.
     >- To view the changes you have accepted, select the **History** tab in the Data Enrichment pane. Learn more in [View change history](#view-change-history).

    The changes are applied to the opportunity record immediately after you accept the suggestions. If you aren't sure about a suggestion, you can leave it without taking any action. The suggestion remains in the pane until you accept or reject it.

## Review and revert automatic updates

If your admin has configured Data Enrichment to automatically update fields in your opportunity records, you can review the changes made and revert them if necessary.

1. Open your opportunity record in the Sales Hub app.
   If Data Enrichment has updated the record, you'll see a notification banner at the top of the form indicating that new suggestions are available.

1. Select **See suggestions** in the notification banner to open the **Data Enrichment** pane.
1. In the **Updates** tab, hover over the information icon next to each suggestion to see details about the source of the suggestion. Review the suggestions and do one of the following:
   - To keep or revert all the changes, select **Keep all** or **Undo all** respectively at the bottom of the pane.
   - To accept or reject individual updates, hover over each suggestion and select the **Keep** icon (check mark) or the **Undo** icon (cross mark) respectively.

     > [!NOTE]
     > If you undo an update, the change is tracked in the **History** tab along with the name of the user who reverted it. Learn more in [View change history](#view-change-history).

## View emails associated by Data Enrichment

The AI-powered Data Enrichment feature associates emails with an opportunity based on several criteria to ensure relevance and context. The key criteria include:

- **Email participants**: The email involves the seller assigned to the opportunity and at least one contact associated with the opportunity.
- **Relevance**: The email content should contain keywords or phrases that indicate relevance to the opportunity, such as mentions of products, services, or deal terms.

**To view the associated emails:**

1. Open your opportunity record in the Sales Hub app.  

1. In the **Timeline** section, look for emails with the agent icon (:::image type="icon" source="media/dea-agent-icon.png" border="false":::).   
   This icon indicates that the email is associated with the opportunity by Data Enrichment.

1. Depending on whether your admin has configured manual or automatic updates, you can take the following actions:
   - **Manual updates:** The email is appears as **Untracked email**. Perform *ONE* of the following actions:
    - Select **Track** to accept the association. 
    - Select **Not related?** to dismiss the suggestion.
   :::image type="content" source="media/dea-untracked-email.png" alt-text="Screenshot showing an untracked email associated by Data Enrichment." border="false":::
   - **Automatic updates:** The email appears as a regular tracked email with the agent icon. If you believe the email is not related to the opportunity, select **Not related?**. You can then select whether you want to remove the email from the current opportunity or reassign it to another opportunity.

## View change history

Changes made by the agent for Data Enrichment are tracked separately in the Data Enrichment change history. 
 
The information shown depends on how Data Enrichment is configured:

- **Automatic updates**: Shows updates made by the agent and any changes you have reverted.
- **Manual updates**: Shows the changes that you have accepted from the suggestions.

**To view the change history:**

1. Open your opportunity record in the Sales Hub app.
1. Select **See suggestions** in the notification banner to open the **Data Enrichment** pane.
1. Select the **History** tab to view the list of changes made to the opportunity record based on Data Enrichment suggestions. 