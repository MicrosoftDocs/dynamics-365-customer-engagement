---
title: View records processed by agent
description: Learn how to view the records processed by the Sales Close Agent - Engage type in Dynamics 365 Sales.
ms.date: 11/21/2025
ms.topic: how-to
ms.service: dynamics-365-sales
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-description
  - ai-seo-date:08/04/2025
author: udaykirang
ms.author: udag
ms.reviewer: udag
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# View records processed by agent

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

The supervisor view shows insights into the records processed by the Sales Close Agent—Engage type. Supervisors monitor the actions agents take on record types.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## View and understand the records processed by agent

>[!NOTE]
>
>- The records in this view are processed by the agent. Records still being processed don't appear in this view until processing is complete.  
>- The view is available for Accounts, Contacts, Leads, and Opportunities record types.

1. In the Sales Hub app, go to ***Record type***. For example, go to **Contacts**.  
1. In the command bar, select the ***Record type* from Sales Close Agent - Engage** view from the dropdown. For example, select **Contacts from Sales Close Agent - Engage**.  
    The view displays the list of records processed by the agent.

1. Select a record to view the details of actions taken by the agent.  
    The record form opens displaying the details of actions taken by the agent on the record.  

    :::image type="content" source="media/sca-engage-processed-records-view.png" alt-text="Screenshot of the Contacts from Sales Close Agent - Engage view showing records processed by the agent.":::

    - The Key insights section summarizes the actions taken by the agent on the record.  
    - The **Review escalated issue** section shows issues escalated to a seller when a customer requests human intervention during the engagement. Based on the summary, the seller can: 
        - Choose to further engage with the contact by selecting **Send email**.  
        - Choose **Action not relevant** if the insight isn't applicable.
    - The **What has happened to this contact** section provides a summary of the engagement with the contact up to that point.  
    - At the bottom, the record's activity email is provided for your reference. Select the email to open the email activity record and view more details.

## Related information

- [How the Sales Close Agent - Engage works](how-sales-close-agent-engage-mode-works.md)  
- [Overview of Sales Close Agent - Engage](sales-close-agent.md)