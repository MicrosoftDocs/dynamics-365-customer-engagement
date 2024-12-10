---
title: Configure custom record summaries for service representatives
description: Learn how to set up a custom record summary in Dynamics 365 Customer Service.
author: lalexms 
ms.author: laalexan
ms.reviewer: shujoshi
ms.topic: how-to 
ms.date: 12/06/2024
ms.custom: bap-template 
---

# Configure custom record summaries for service representatives

The custom record summary feature introduces AI-generated summaries for any custom record type in Dynamics 365 Customer Service. Custom record summaries can help your service representatives quickly gain insight into important records, such as custom case record types or other out-of-the-box record types, like account and contact information. Summaries also help improve service representative response times with their customers by providing them with an easily accessed, quick synopsis of an account.

You can configure the custom record summary feature to create summaries for work orders, part orders, or any other custom tables that exist in your customer service environment. You can customize summaries in the following ways:
- Select from a list of existing record types, including account, work orders, and tickets, to generate summaries.
- Define in natural language what the record type is so that AI can leverage the information to create better summaries.
- Select specific data fields to include in the summary and also describe these fields in natural language.
- Allow service representatives to access these summaries on demand from the relevant form to help ensure accuracy and relevancy in their communications.

## Configure the custom record summary

1. On the site map in Customer Service workspace, select **Productivity** > **Summaries**.
1. In the **Custom record summaries** section, select the summary you want to edit, and then select **Edit**.
1. You can optionally rename the summary and change the description of the record type. Such edits can be helpful for uncommon record types, such as work orders or part orders.
1. Select **Next**.
1. On the **Specify data** page, set up the field mappings by selecting **1-to-1** or **1-to-many**. You can map fields one-to-one with the record or set up one-to-many relationships for related activities or entities. In the **Include** column, uncheck any rows you don’t want to be considered from the data summarization. Include only the essential rows to ensure the most succinct summaries.
1. To add a row, select **Add data**, and then choose the corresponding **Data type**, **Record type or activity**, **Data field**, and **Description** entries from the dropdown menus.
   > [!Note]
   > For the **1-to-1** attribute, you can have a maximum of 10 selections. For the **1-to-many** attribute, you can have a maximum of six selections.
1. Select **Save and close**.

## Configure the summary control on the custom entity form

By default, if you enable the Copilot custom record summary feature, service representatives don't see it on their record types until you customize it. Complete the following steps to configure the application so that it displays the custom record summary on your forms.

1. In [Power Apps](https://make.powerapps.com/), add the **msdyn_CopilotCaseSummaryLibrary.js** web resource to your solution. For more information, refer to [Add a web resource to a solution](). 
1. Select **Add existing** > **More** > **Developer** > **Custom Control**. 
1. Search for and add the **mscrmcontrols.csintelligence.copilotcasesummarycontrol** custom control. 
1. Select **Tables**, and then select the record type where you want to configure the custom record summary, and then select **Forms**. 
1. Create a new form or use an existing form. For more information, refer to [Create, edit, or configure forms using the model-driven form designer]{../power-apps/maker/model-driven-apps/create-and-edit-forms). 
1. In the form designer, select **Components** from the site map, and then select **CopilotCaseSummaryControl** and drag it on to the form.
1. Set the values of the fields as follows:
   - CC_CaseSummary: Any unused string column. Copy the unique name of the specified column.
   - CC_IndentID: Case (text)
1. Save and publish the customizations.

You must also configure the following settings to maek sure that the Copilot summary doesn't load on the form when the custom record summary isn't enabled or the agent experience profile linked to the service representative doesn't have Copilot enabled.

1. In Power Apps, add the event handler function for the **On Change** event. For more information, refer to [Add or remove event handler function to even using UI]().
1. Specify the following details in **Configure Event**:
   - Set the **Event Type** to **On load**.
   - Set the **Library** to **msdyn_CopilotCaseSummaryLibrary.js**.
   - In **Function**, specify **Mscrm.CSIntelligence.CopilotCaseSummary.setVisibilityOfCaseSummary**.
   - Select **Pass execution content as first parameter** and specify the unique name of the table column value that you provided in **CC_CaseSummary**, enclosed in quotations.
   - Add a comma, and provide the **Developer Summary ID** that was generated when the custom record summary was set up in Customer Service admin center.


