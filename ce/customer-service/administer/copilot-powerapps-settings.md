---
title: Configure copilot features for custom case forms and custom apps
description: Learn how to enable Copilot features for custom case forms and custom apps.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to
ms.date: 11/28/2024 
ms.custom: bap-template 
ms.collection: bap-ai-copilot
---

# Configure copilot features for custom case forms and custom apps 

You can configure the Copilot case summary on custom case forms and enable the Copilot features for custom apps.

## Display Copilot case summary on custom case forms

When you enable the Copilot case summary feature, agents can see the case summary by default on out-of-the-box case forms. You can perform the following steps for the application to display the Copilot case summary on your custom case forms.

1. In [Power Apps](https://make.powerapps.com/), add the **msdyn_CopilotCaseSummaryLibrary.js** web resource to your solution. For more information, see: [Add a web resource to a solution](/power-apps/maker/model-driven-apps/create-edit-web-resources#add-a-web-resource-to-a-solution).
1. Select **Add existing** > **More** > **Developer** > **Custom Control**.
1. Search for and add the **mscrmcontrols.csintelligence.copilotcasesummarycontrol** custom control.
1. Select **Tables**, select **Case**, and then select **Forms**.
1. Create a new form or use an existing form. More information: [Create, edit, or configure forms using the model-driven form designer](/power-apps/maker/model-driven-apps/create-and-edit-forms).
1. In the form designer, select **Components** from the left navigation, select **CopilotCaseSummaryControl** and drag it on to the form.
1. Set the values of the following fields as:
   - **CC_CaseSummary**: Any unused string column. Copy the unique name of the specified column.
   - **CC_IncidentId**: **Case (Text)**
 
   :::image type="content" source="../media/powerapps-copilot-case-summary.png" alt-text="Screenshot of the Power Apps copilotcasesummarycontrol component." :::

1. Save and publish the customizations.

You must also configure the following settings to make sure that copilot summary doesn't load on the custom case form when the Copilot case summary feature isn't enabled or the agent experience profile linked to the agent doesn't have **Copilot** option enabled:

1. In Power Apps, add the event handler function for the On Change event. More information: [Add or remove event handler function to event using UI](/power-apps/developer/model-driven-apps/clientapi/events-forms-grids?tabs=add-event-handlers-unified-interface#add-or-remove-event-handler-function-to-event-using-ui).
1. Specify the following details in **Configure Event**:
     - Set the **Event Type** to **On load**.
     - Set the **Library** to **msdyn_CopilotCaseSummaryLibrary.js**
     - Specify **Mscrm.CSIntelligence.CopilotCaseSummary.setVisibilityOfCaseSummary** in **Function**.
     - Select **Pass execution context as first parameter** and specify the unique name of the table column value that you provided in **CC_CaseSummary**, enclosed in quotations.
     
     :::image type="content" source="../media/powerapps-event-handler.png" alt-text="Screenshot of the Power Apps event handler." :::

1. Save and publish the changes.

## Enable Copilot features for custom apps

You can enable the Copilot features for custom apps in your organization. Perform the following steps to enable the Copilot features for a specific app: 

1. In [Power Apps](https://make.powerapps.com/), add the **Customer Service Copilot Enabled** setting definition. Learn more at [add an existing setting definition](/power-apps/maker/data-platform/create-edit-configure-settings#adding-an-existing-setting-definition).
1. In the **Edit Customer Service Copilot Enabled** pane, in the **Setting app values** section, for a required app, set the  **New app value** to **Yes**. More information: [Update a setting definition](/power-apps/maker/data-platform/create-edit-configure-settings#updating-a-setting-definition).

   :::image type="content" source="../media/powerapps-setting-definition-copilot.png" alt-text="Screenshot of the Power Apps setting defintiion." :::

### Next steps

[Use Copilot to solve customer issues](../use/use-copilot-features.md)