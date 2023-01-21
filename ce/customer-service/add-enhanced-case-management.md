---
title: "Configure the enhanced case management experience | MicrosoftDocs"
description: "Use this article to learn how to configure enhanced case management "
ms.date: 02/01/2023
ms.topic: article
author: gandhamm
ms.author: mgandham
manager: shujoshi
searchScope:
- D365-App-customerservicehub
- D365-Entity-queueitem
- D365-UI-*
- Customer Engagement
- Dynamics 365
- Customer Service
---

# Use Powerapps to customize the case management experience

This article discusses how to configure the redirection link in the Resolve case dialog, add recent cases and customer details to the case form, and how to configure the default standard resolve cases dialog.

## Specify tab to redirect users for closing open activities for a case

You can configure what tab user must be redirected to when users select the open activities link on the  **Resolve Case** dialog box. You can set this at an environment level or for a specified app.

1. In [Power Apps](https://make.preview.powerapps.com/), select the environment that contains your solution.
2. Select **Solutions**, and then select the solution in which you want to set the link for the case resolution dialog box.
4. Select **Add Existing** > **More** > **Setting**.
1. On the **Add existing Setting Definition** pane, select the **Redirect user to the specified tab to close open activities** option and then select **Next**.
1. Select **Add** on the **Selected Setting Definition** to add the **Redirect user to the specified tab to close open activities** option to your solution. 
1.  Go to **Add Existing** > **App** > **Model-driven app**> **Add existing model-driven apps** pane.
1. Select the **Redirect user to the specified tab to close open activities** option. The **Redirect user to the specified tab to close open activities** pane appears.
1. Set the **Setting environment value** option to the required tab. You can find the tab's name in the **Display options** > **Name** field of the corresponding form. 
1. In the **Setting app value** section, the Customer Service Hub and workspace apps are displayed. 
1. Select **New app value** for the app, and specify the activity tab that the user must be redirected to for the respective apps.
1. Select **Publish All Customizations**.


## Disable the minimal case resolution dialog

You can choose to display the standard case resolution dialog box that appears when an agent selects **Resolve case**. Perfom the following steps:

1. In [Power Apps](https://make.preview.powerapps.com/), select the environment the environment that contains your solution.
2. Select **Solutions**, and then select the solution in which you want to turn off the minimal case resolution dialog.
4. Select **Add Existing** > **More** > **Setting**.
1. On the **Add existing Setting Definition** pane, select the **Enable the minimal case resolution dialog** option and then select **Next**.
1. Select **Add** on the **Selected Setting Definition** to add the **Enable the minimal case resolution dialog** option to your solution. 
1.  Go to **Add Existing** > **App** > **Model-driven app**> **Add existing model-driven apps** pane.
1. Select the **Enable the minimal case resolution dialog** option. The **Enable the minimal case resolution dialog** pane appears.
1. Set the **Setting environment value** option to **Yes**.
1. In the **Setting app value** section, the Customer Service Hub and workspace apps are displayed. 
1. Select **New app value** for the app, and set the value to **Yes** for the respective apps.
1. Select **Publish All Customizations**.

## Add the Customer360 and Recent Records components to a case form

For the application to display the Customer details and related cases on the case form on the Customer Service Workspace, perform the following steps to add the Customer360 and Recent Records components:

1. 1. In [Power Apps](https://make.preview.powerapps.com/), select the environment the environment that contains your solution.
1. Select **Tables**, select Case, and then select the **Forms** area.
1. Select the required entity.
1. In the form designer, select **Components** from the left navigation, and then scroll down to the following: 
   - **Customer 360**: Drag and drop it into a section on the form. On the **Properties** panel: 
        - Select the attributes from the table that must be displayed as fields on the form to the agent. You can select up to seven columns and three composite attributes. 
        - Specify if the users can edit the fields in the card in the **Enable Editing** drop down. This field is set to **Yes** by default. 
   - **Recent records**: Drag and drop it into a section on the form. On the **Properties** panel: 
        - Specify the **Table** from which the records must be displayed. 
        - You can allow users to change the view or chart by selecting the **Allow users to change view** or **Allow users to change chart** checkbox.
        - Specify the Maximum number of rows to be displayed on the card, once the card loads. The minimum number of rows displayed 4.

> [!NOTE]
> Select **Get more components** if you can't see these options in **Components**.

## Add the Recent cases subgrid to the Conversation form

To retrieve the related cases for a customer to be displayed on  the customer summary form in Customer Service Workspace, perform the following steps:

1. On the Accounts or Contacts form, add new form. Add a new sub grid component with the Recent Cases component. More information: [Add a subgrid component](/power-apps/maker/model-driven-apps/form-designer-add-configure-subgrid#add-a-subgrid-component)
1.  On the Conversation form, add the Form Component Control. More information: [Add the form component to a table main form](/power-apps/maker/model-driven-apps/form-component-control#add-the-form-component-to-a-table-main-form). 
1. Specify the **Customer** in the **Lookup column**.
1. On the **Related forms** select the newly created forms on step 1 for Account or the Contact table.

## Configure the prior recent cases view in the Conversation table

You can choose to go back to the default Recent Cases display experience in the Conversation Summary form of the Customer Service workspace. To revert back to the default experience, perform the following steps:

1. In [Power Apps](https://make.preview.powerapps.com/), select the environment the environment that contains your solution.
1. Select **Tables**, select the Conversation table, and then select the **Forms** area.
1. Select the required entity.
1. Select **Components** and then select **1- column section** in **Popular**. Drag and drop it into a section on the form.
1. Select **Quick view** and add it to the previously added 1- column section on the form. Specify the following details:
    - Lookup: Customer
    - Account: Cases for Customer
    - Contact: Cases for Customer
1. Select **Save** and **Publish**.
