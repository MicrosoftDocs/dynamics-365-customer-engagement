---
title: Manage case and custom record summary
description: Learn how to create and edit case and custom summary records. 
author: gandhamm 
ms.author: mgandham 
ms.reviewer: mgandham
ms.topic: how-to 
ms.collection: bap-ai-copilot
ms.date: 01/19/2026
ms.update-cycle: 180-days
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/13/2023
---

# Manage case and custom record summary

You can create tailored summaries for cases and custom records to help your representatives quickly access essential information. Summaries streamline workflows and improve customer service efficiency. 

You can customize case and custom record summaries as follows:

- Select existing record types (for example, accounts, work orders, tickets) for summaries.
- Define record types in natural language for better summary generation.
- Choose specific data fields for including and describing them in natural language.
- Allow representatives to access summaries on demand from relevant forms for the latest status updates.
- Incorporate data from related records and customize how summaries appear to your service representatives.

## Configure case and custom record summaries

In Copilot Service admin center, perform the following steps to select your preferred format:

1. Use one of the following navigation options:
    - **Agent Experience** > **Productivity** > **Summaries**
    - **Operations** > **Insights** > **Summaries**

1. You can access the configuration wizard using one of the following options:
     - Select **Manage data** link in **Case summaries**, to edit the default case summary record.
     - Select **Add new summary** in **Custom record summaries** to create a new summary record. You can also select **Edit** to modify an existing summary record. 

1. The configuration wizard has the following panes. Specify the required information in each pane and select **Next** to navigate to the next pane to complete the configuration.

    - Specify record type
    - Specify data
    - Include related record summary
    - Manage summary format

## Specify record type

The first pane that appears in the configuration wizard. Specify the record type to summarize and provide information to help representatives and Copilot understand the record type of the summary. 

- **Summary name**: Enter a name for the summary that's used for identifying it in the summaries list.
- **Record type**: Select the record type to summarize. 
- **Description of record type**: Specify the record description in natural language. The description helps Copilot understand the record type and generate a more accurate summary. 
- **Choose summary verbosity**: Select **Medium**, **Large**, or **Small** to indicate how comprehensive the generated summary can be.

> [!NOTE]
> You can modify the **Description of record type** and **Choose summary verbosity** fields only when you edit the default case summary record.
Select **Next** to go to the next pane. 

## Specify data

The second pane that appears in the configuration wizard. Specify the fields that Copilot must use to generate the summary. 

1. Select **Add data** and enter the following details. Repeat the steps to add as many rows as required. By default, the rows you add are considered for summarization. Clear the **Include** checkbox for rows you don’t want to be considered. 
   1. **Data type**:
      - **1-to-1** To map with the record. You can map up to 10 selections.
      - **1-to-many** to map relationships for related activities or entities. For the **1-to-1** attribute, you can have a maximum of 10 selections. For the **1-to-many** attribute, you can have a maximum of six selections and up to three related entities.
   1. **Record type or activity**: Select the record type or activity.
   1. **Data field**: Select the data field from the record type or activity.
1. Select **Next** to go to the next field.

> [!NOTE]
> Make sure to add at least one **1-to-1** data type for case summaries.

   :::image type="content" source="../media/copilot-data-attributes-mini.png" alt-text="Screenshot of the data attributes that copilot uses" lightbox="../media/copilot-data-attributes.png":::

### Manage fields Copilot uses for case summaries 

 Copilot uses the following fields to generate case summaries, for the default case summary record. When you're modifying the default fields, make sure that at least one of the fields among the first seven must remain enabled.

- Customer
- Case Title
- Case Type
- Subject
- Case Description
- Product
- Priority
- Case Notes
- Email Content
- Conversation Summary

### Things to consider

- For Copilot to generate a summary, make sure that the Customer Service Representative or custom role has the read permission configured for the related entities.
- Agents must have the `prvReadProduct` privilege to generate a summary that contains the **Product** field.
- You can set Case Notes to a custom entity that is related to the **Case** table.
- You can't modify the **Email Content**  and **Conversation Summary** values that Copilot uses to generate case summaries. 

## Include related record summary

The third pane that appears in the configuration wizard and is an optional configuration. You can enhance your case management system by including summaries of related records within case summaries and custom record summaries. Customer support representatives get comprehensive context navigating to multiple records individually, saving time, and improving efficiency.

Perform the following steps to configure related record summaries:

1. In the **Include related record summary** pane, select the **Include related records as part of the summarization output** checkbox to enable Copilot to generate related record summaries.
1. Specify the following information: 
    - **Select related record**: Select the related record type you want to include in the summary such as case, account.
    - **Select related record field that references the parent**: Specify the field on the related record that establishes the relationship with the base entity. The field contains a reference to the base record. 
    - **Select a summary configuration to use**:  Select which pre-configured custom record summary Copilot must use to generate the related record summary. You can specify an existing summary record with different data configurations, formatting options, and summary lengths or select the **Go to custom record summary section** to create a new summary record to use.
    - **Prioritize related record by**: Select a field to determine the display order of related records. This is usually a date or time field such as "Modified Date". Related record summaries are ordered based on the field with the most recent record displayed first.
    - **Select the field of related record to display on summary**: Select the field to be displayed as the header for each related record such as record title, record ID, or other identifying information.
1. Select **Next** to go to the next pane.

### Example

For example, if you want your service representatives to see the related work orders linked to a case, you can configure the following details:

- **Select related record**: Work Order
- **Select related record field that references the parent**: Parent Case (the field on Work Order that links the work order to the case)
- **Prioritize related record by**: Modified Date
- **Select the field of related record to display on summary**: Work Order Number

Service representatives see the work order number as the header for each work order in the case summary. The Copilot summary displays work orders in order of their modified date, showing the most recent work order first.

   :::image type="content" source="../media/related-case-summary-mini.png" alt-text="Screenshot of Copilot related record summary." lightbox="../media/related-case-summary.png":::


## Manage summary format

You can customize the format of case and custom record summaries using two formatting options. Perform the following steps:

1. Select the format you want to use for case summaries:
   - **Paragraph**: Presents the summary in a single paragraph.
   - **Structured**: Presents the summary in a structured manner, with each field appearing in a separate line. Structured format is more readable and helps service representatives quickly find the information they need.
1. When you select the **Structured** format, you can also specify up to five custom headers to organize summary information. By default, the headers are **Issue**, **Troubleshooting steps**, **Outcome**, **Error code**, and **Root cause**. You can perform the following actions:

   - Select **Edit** to modify the header title and the information to be summarized by Copilot.
   - Select **Delete** to remove the header.
   - Select the arrows to change the order in which the headers appear in the summary.
   - Clear the checkbox to remove the header from the summary without deleting the header.
   - Select **Add new info** to add a new header. 
   - Select **Reset to default info** to restore the default headers.

1. Turn on the **Remove information from the summary that can't be found** toggle to exclude information that isn't available in the record. This option prevents placeholder text or empty sections from appearing in your summaries when the corresponding data is missing.

1. Select **Save and close** to save your changes and close the configuration wizard.

   :::image type="content" source="../media/format-case-summary.png" alt-text="Screenshot of Copilot case summary.":::

### Related information

[Enable case summaries](copilot-enable-summary.md#enable-case-summaries)  