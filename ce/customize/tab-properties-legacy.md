---
title: Tab properties for forms in PowerApps | MicrosoftDocs
description: Understand the tab properties for main forms 
Keywords: Tab properties; Dynamics 365; Main forms
author: matp
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
  - "powerapps"
ms.author: Mattp123
manager: kvivek
ms.date: 04/24/2018
ms.service: crm-online
ms.topic: article
ms.assetid: e0790865-c5a4-4e86-bce2-584af2b8ed93
---
# Tab properties overview

[!INCLUDE [cc-applies-to-powerapps-and-update-9-0-0](../includes/cc-applies-to-powerapps-and-update-9-0-0.md)]

 In the body of a form, tabs provide horizontal separation. Tabs have a label that can be displayed. If the label is displayed, tabs can be expanded or collapsed to show or hide their content by choosing the label.  

 Tabs contain up to three columns and the width of each column can be set to a percentage of the total width. When you create a new tab, each column is pre-populated with a section.  

You can access **Tab properties** in solution explorer. Under **Components**, expand **Entities**, expand the entity you want, and then select **Forms**. In the list of forms, open the form of type **Main**. Then double-click inside one of the tabs on the form canvas to view tab properties.

![tab-properties](media/tab-properties.png)

 The following table shows properties that may be set for tabs on the form:


|      Tab       |                  Property                  |                                                                                                                       Description                                                                                                                        |
|----------------|--------------------------------------------|----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|  **Display**   |                  **Name**                  |                                                **Required**: The unique name for the tab that is used when referencing it in scripts. The name can contain only alphanumeric characters and underscores.                                                 |
|                |                 **Label**                  |                                                                                            **Required**: The localizable label for the tab visible to users.                                                                                             |
|                | **Show the label of this tab on the Form** |                                                     When the label is displayed people can select it to toggle whether the tab is expanded or collapsed. Choose whether you want to show the label.                                                      |
|                |       **Expand this tab by default**       |                                                    The tab state can toggle between expanded or collapsed using form scripts or by people selecting the label. Choose the default state for the tab.                                                     |
|                |           **Visible by default**           |     Showing the tab is optional and can be controlled using scripts. Choose whether to make the tab visible. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Visibility options](../customize/visibility-options-legacy.md)     |
|                |              **Availability**              |                                                                                                 Choose if you want the tab to be available on the phone.                                                                                                 |
| **Formatting** |                 **Layout**                 |                                                         Tabs may have up to three columns. Use these options to set the number of tabs and what percentage of the total width they should fill.                                                          |
|   **Events**   |             **Form Libraries**             |                                                Specify any [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] web resources that will be used in the tab `TabStateChange` event handler.<br /><br />                                                |
|                |             **Event Handlers**             | Configure the functions from the libraries that should be called for the tab `TabStateChange` event. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Configure Event Handlers](../customize/configure-event-handlers-legacy.md) |

## See also

[Use the Main form and its components](../customize/use-main-form-and-components.md)
