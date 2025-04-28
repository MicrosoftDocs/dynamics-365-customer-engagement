---
title: Enable Copilot to generate related record summaries 
description: Learn how to modify the default attributes that Copilot uses to generate more accurate summaries. 
author: gandhamm 
ms.author: mgandham 
ms.reviewer: mgandham
ms.topic: how-to 
ms.collection: bap-ai-copilot
ms.date: 05/02/2025
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/13/2023
---

# Enable Copilot to generate related record summaries 

You can enhance your case management system by including summaries of related records within case summaries and custom record summaries. Customer support representatives get comprehensive context navigating to multiple records individually, saving time and improving efficiency.

## Configure related record summaries

In Copilot Service admin center, perform the following steps to configure related record summaries:

1. Use one of the following navigation options:
    - **Agent Experience** > **Productivity** > **Summaries**
    - **Operations** > **Insights** > **Summaries**
1. In **Summaries**, for **Case summaries**, select **Manage data**. For **Custom record summaries**, select  **Add nre summary** or **Edit** an existing summary.
1. Select **Next** to reach the **Include related record summary** pane.
1. Select the **Include related records as part of the summarization output** checkbox to enable Copilot to generate related record summaries.
1. Specify the following information: 
    - **Select related record**: Select the the related record type you want to include in the summary such as case, account.
    - **Select related record field that references the parent**: Specify the field on the related record that establishes the relationship with the base entity. This field typically contains a reference to the base record. 
    - **Select a summary configuration to use**:  Select which pre-configured custom record summary Copilot must use to generate the related record summary. You can specify an existing summary record with different data configurations, formatting options, and summary lengths or select the **Go to custom record summary section** to create a new summary record to use.
    - **Prioritize related record by**: Select a field to determine the display order of related records. This is usually a date or time field such as "Modified Date". Related record summaries are ordered based on the field with the most recent record displayed first.
    - **Select the field of related record to display on summary**: Select the field to be displayed as the header for each related record such as record title, record ID, or other identifying information.
1. Select **Save** to save your changes.

## Example

For example, if you want your service representatives to see the related work orders with the linked to a case, you can configure the following details:

- **Select related record**: Work Order
- **Select related record field that references the parent**: Parent Case (the field on Work Order that links the work order to the case)
- **Prioritize related record by**: Modified Date
- **Select the field of related record to display on summary**: Work Order Number


Service representatives see the work order number as the header for each work order in the case summary. The work orders are ordered by the modified date, with the most recent work order displayed first.