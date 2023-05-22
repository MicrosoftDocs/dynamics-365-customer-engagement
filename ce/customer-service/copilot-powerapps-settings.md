---
title: Configure Copilot settings for custom case forms and custom apps  
description: Learn how to enable advanced Copilot settings.
author: gandhamm
ms.author: mgandham
ms.reviewer: neeranelli
ms.topic: how-to
ms.date: 05/19/2023 
ms.custom: bap-template 
ms.collection: 
---

# Configure Copilot settings for custom case forms and custom apps

> [!IMPORTANT]
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]

You can configure the Copilot case summary on custom case forms and enable the Copilot features for custom apps.

## Display Copilot case summary on custom case forms

When you enable the Copilot case summary feature, agents can see the case summary by default on out-of-the-box case forms. You can perform the following steps for the application to display the Copilot case summary on your custom case forms:

1. In [Power Apps](https://make.powerapps.com/), add the **msdyn_CopilotCaseSummaryLibrary.js** web resource to your solution. For more information, see: [Add a web resource to a solution](/power-apps/maker/model-driven-apps/create-edit-web-resources#add-a-web-resource-to-a-solution).
1. Select **Add existing** > **More** > **Developer** > **Custom Control**. Search for and add the **mscrmcontrols.csintelligence.copilotcasesummarycontrol** custom control.
1. Select **Tables**, select **Case**, and then select **Forms**.
1.  Create a new form or use an existing form. More information: [Create, edit, or configure forms using the model-driven form designer](/power-apps/maker/model-driven-apps/create-and-edit-forms).
1.  In the form designer, select **Components** from the left navigation, select **CopilotCaseSummaryControl** and drag it on to the form.
1. Set the values of the following fields as:
   - **CC_CaseSummary**: Any table column. Copy the unique name of the specified column.
   - **CC_IncidentId**: **Case (Text)**
1. Set the **Show hidden** toggle to **On**.
1. Save and publish the customizations.
1. To ensure that the case summary doesn't load on the form when the Copilot case summary capability isn't enabled, perform the following steps:
  1. In Power Apps, you must add the event handler function for the On Change event. More information: [Add or remove event handler function to event using UI](/power-apps/developer/model-driven-apps/clientapi/events-forms-grids?tabs=add-event-handlers-unified-interface#add-or-remove-event-handler-function-to-event-using-ui). 
  1. Specify the following details in **Configure Event**:
     - **Event Type**: **On Change**
     - Set the **Event Type** to **On load**.
     - Specify **Mscrm.CSIntelligence.CopilotCaseSummary.setVisibilityOfCaseSummary** in **Function**.
     - Select **Pass execution context as first parameter** and specify the unique name of the table column value specified in **CC_CaseSummary**.
1. Save and publish the changes.

## Enable Copilot capabilities for custom apps

You can enable the Copilot capabilities for custom apps in your organization. Perform the following steps to add and configure the setting definition in Power Apps to enable the Copilot capabilities for a specific app. 

1. In [Power Apps](https://make.powerapps.com/), add the **Customer Service Copilot Enabled** setting definition. More information: [Add an existing setting definition](/power-apps/maker/data-platform/create-edit-configure-settings#adding-an-existing-setting-definition).
1. In the **Edit Customer Service Copilot Enabled** pane, in set the **Setting app values** section, for a required app, set the  **New app value** to **Yes**. More information: [Update a setting definition](/power-apps/maker/data-platform/create-edit-configure-settings#updating-a-setting-definition).


## Next steps

[Use Copilot capabilities](use-copilot-capabilities.md)