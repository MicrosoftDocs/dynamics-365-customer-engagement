---
title: Review and approve suggestions from Data Enrichment
description: Learn how to review and approve suggestions made by the Data Enrichment Agent.
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.date: 01/19/2026
ms.topic: how-to
ms.service: dynamics-365-sales
ms.collection: bap-ai-copilot
---

# Review and approve suggestions from Data Enrichment 

As a seller, you can review the suggestions made by Data Enrichment for your opportunity records and choose to apply them. If your admin has configured Data Enrichment to automatically update fields, you can still review the changes made and revert them if necessary.

## Provide consent for Data Enrichment to read your emails

When you open an opportunity record for the first time after Data Enrichment is enabled, you will see a prompt asking for your consent to allow the agent to read your emails. Select **Allow** to provide consent. After you provide consent, the agent takes about 4 hours to analyze your emails and generate suggestions for the opportunity record. Consent is mandatory for both automatic updates and manual updates.

## Review and approve suggestions manually

If your admin has configured the agent for manual updates, you need to manually review and approve the suggestions made.

1. Open your opportunity record in the Sales Hub app.
   If Data Enrichment has suggestions for the record, you will see a notification banner at the top of the form indicating that there are new suggestions available.

1. Select **See suggestions** in the notification banner to open the **Data Enrichment** pane.
1. In the **Suggestions** tab, hover over the information icon next to each suggestion to see details about the source of the suggestion. Review the suggestions and do one of the following:
   - To accept or reject all the suggestions, select **Apply all** or **Reject all** at the bottom of the pane.
   - To accept or reject individual suggestions, hover over each suggestion and select the **Accept** icon (check mark) or the **Reject** icon (cross mark).
     > [!NOTE]
     >- If you reject a suggestion for an opportunity, Data Enrichment will not show that suggestion again for that opportunity record. There's no option to undo or recover rejected suggestions.
     >- To view the changes you have accepted, select the **History** tab in the Data Enrichment pane. 

    The changes are applied to the opportunity record immediately after you accept the suggestions. If you are not sure about a suggestion, you can leave it without taking any action. The suggestion will remain in the pane until you accept or reject it.
1. In the **Timeline** section of the opportunity record, look for **Untracked email** with the agent icon next to it. This indicates that Data Enrichment has found relevant emails that can be associated with the opportunity. Do *ONE* of the following:
    - Select **Track** to accept the association. 
    - Select **Not relevant?** to dismiss the suggestion.

## Review and revert automatic updates

If your admin has configured Data Enrichment to automatically update fields in your opportunity records, you can review the changes made and revert them if necessary.

1. Open your opportunity record in the Sales Hub app.
   If Data Enrichment has updated the record, you will see a notification banner at the top of the form indicating that new suggestions are available.

1. Select **See suggestions** in the notification banner to open the **Data Enrichment** pane.
1. In the **Updates** tab, hover over the information icon next to each suggestion to see details about the source of the suggestion. Review the suggestions and do one of the following:
   - To keep or revert all the changes, select **Keep all** or **Undo all** respectively at the bottom of the pane .
   - To accept or reject individual updates, hover over each suggestion and select the **Keep** icon (check mark) or the **Undo** icon (cross mark) respectively.

     > [!NOTE]
     > If you undo an update, the change is tracked in the **History** tab along with the name of the user who reverted it.
1. In the **Timeline** section of the opportunity record, look for emails with the agent icon. This indicates that Data Enrichment has associated relevant emails with the opportunity. If it's not relevant, select **Not relevant?** to remove the association.

## View change history

Changes made by the agent for Data Enrichment are tracked separately in the Data Enrichment change history. 
 
The information shown depends on how Data Enrichment is configured:

- **Automatic updates**: Shows updates made by the agent and any changes you have reverted.
- **Manual updates**: Shows the changes that you have accepted from the suggestions.

**To view the change history:**

1. Open your opportunity record in the Sales Hub app.
1. Select **See suggestions** in the notification banner to open the **Data Enrichment** pane.
1. Select the **History** tab to view the list of changes made to the opportunity record, along with the date and time of each change.