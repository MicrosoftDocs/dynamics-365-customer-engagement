---
title: "Create insight cards using Microsoft Flow in Dynamics 365 for Customer Engagement | MicrosoftDocs"
description: "Create custom insight cards using Microsoft Flow in assistant"
keywords: "AI for sales, assistant, custom cards, insight cards"
ms.date: 03/22/2019
ms.service: crm-online
ms.custom: 
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: e59e67ad-3646-4929-a6f8-c97ab2c5f6e2
author: udaykirang
ms.author: udag
manager: shujoshi
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 01
topic-status: Drafting
---

# Preview: Create custom insight cards

Applies to [!INCLUDE[pn-crm-online](../includes/pn-crm-online.md)] version 9.1.0.

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
> [!INCLUDE[cc_preview_features_definition](../includes/cc-preview-features-definition.md)] 

As an administrator or sales manager, you can create your own suggested actions that are more relevant to your organization through the assistant management feature. By using events and conditions you can customize the circumstances on when to create suggestions and push information into the seller’s workflow. This helps the sellers to close deals faster. The following illustrates a high-level flow of insight card creation:

> [!div class="mx-imgBorder"]
> ![Open assistant tab](media/cc-create-card.png "Open assistant tab")

In this procedure, we will show as an example how to create an insight to act when a property is updated. Let’s create the **When property is updated, create an insight to act** card.

1. Sign in to **[!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)]** and go to **Settings** > **Sales AI**.
2. Select **Configure** on the **Assistant** section or select the **Assistant** tab.
    
    ![Open assistant tab](media/cc-open-assistant.png "Open assistant tab")
    
    A template selection page opens. 
    
    > [!NOTE]
    > We recommend you use templates to create insight cards.

3. Select a template to create the card.

    > [!NOTE]
    > If you want to create insight cards from an empty flow, select **Create from blank**. To learn more, see [Create a flow in Microsoft Flow](/flow/get-started-logic-flow).
    
    In this example, we selected the **Due date is coming up** template to create the custom card.
    
    ![Select insight card creation template](media/cc-insight-card-template-selection.png "Select insight card creation template")
    
    A new tab opens with the flow selections options.
        
    ![Account validation in flow](media/cc-account-validation-flow.png "Account validation in flow")
    
    The flow validates your accounts of the applications that the flow is going to connect. In this example, the flow is connecting to Dynamics 365 and Dynamics 365 AI for Sales. Once you are successfully signed in, you can continue creating the card.

    If any of the account is not valid, the **Continue** button is grayed out and you cannot proceed further. Select the **More options** icon (…) and choose the options **+ add new connection** or **Update** accordingly to sign in.

4. Select **Continue**.

    The predefined flow is displayed. In this example, we are creating an insight when a due date is coming up for an opportunity. There are three steps associated with the predefined flow with the prepopulated data. 
    - **Step 1**: Create schedule
    - **Step 2**: Define operation
    - **Step 3**: Define control
    
    You can edit the steps according to your requirements.
    
    ![Edit flow template](media/cc-edit-template.png "Edit flow template")

5. In step 1, a schedule when you want to display the card is defined. In this example, the frequency is set to daily and you can add other parameters such as time zone. 

    ![Create card schedule](media/cc-card-schedule-step.png "Create card schedule")

    If you want to change the flow, select the + icon on the connector that is linking to the next step and select **Add an action** as per your organizational requirements. To learn more, see [Add multiple actions and advanced options to a flow](/flow/multi-step-logic-flow).
6. In step 2, an operation is defined to get records from an organization to the selected entity. In this example, we have selected the entity as task and the organization. 

    Select **Show advanced options** to further update the step by configuring the parameters **Filter Query**, **Order By**, **Top Count**, and **Expand Query**.

    ![Define card operations](media/cc-card-operation-step.png "Define card operations")
7. In step 3, an **apply to each** control is selected and enter the necessary information.

    a. The **Value** token is added to the **Select an output from previous steps** box. This value is obtained from the previous step where we defined the entity.
     
      ![Select output from previous step](media/cc-add-information-condition-value.png "Select output from previous step")  
  
    b. The condition step is defined to match the date of the task that is defined in step 2 to the current date to trigger the condition. Here, we are defining the value as **formatDateTime(item()?['scheduledend'],'yyyy-MM-dd')**, the condition as **is equal to**, and the threshold value as **formatDateTime(utcNow(),'yyyy-MM-dd')**.
    
      ![Add a condition](media/cc-add-condition.png "Add a condition")
    
      To learn more about conditions, see [Add a condition to a flow](/flow/add-condition).

    c. The **If yes** section defines the properties of the card and actions you can take. Here we have selected an action to **Create a card for the assistant**. Enter the following information:

      -  **Organization Name**: The name of the organization for which you want to trigger the card.
      - **Card Name**: Name of the card to refer to in the list of available cards in the **Manage insight cards** tab of **Dynamics 365 AI for Sales**.
      - **Description**: The summary or the basic information of the card that is to be displayed.
      - **Action**: The convenient links that will help you complete whatever type of action the card is recommending. The number (up to two) and types of links provided here vary by card type.
      - **Action Parameter**: The ID of the created action.
      - Optionally, you can configure the advanced options for the condition. Select **Show advanced options** and update the parameters **Title**, **Start Date**, **End Date**, **Display to**, **Reasons**, **Regarding Object ID**, **Action Parameter Entity ID Type**, and **Regarding Object Type**.
        
      When you select a text box, the dynamic content pane appears. You can select and add the relevant fields. These dynamic content field variables and values displayed by these fields change according to the information passed.

      ![Add condition information](media/cc-add-condition-information-yes.png "Add condition information")

    To learn more about expression conditions, see [Use expressions in conditions to check multiple values](/flow/use-expressions-in-conditions).

8. Save the flow.

    > [!NOTE]
    > - If any errors occur, the **Flow Checker** displays the errors and warnings that you can resolve. You must resolve these errors and save the flow.
    > - If you want to execute and ensure the flow is working properly before using it in the organization, select **Test**. This runs and validates each step in the flow. If any error occurs on a step, the step highlights and resolve the error to proceed.
    > In this example, you see that the step **Look at all tasks in Dynamics 365** has failed the test. Select the step and more information on the error is displayed. You must resolve the error to proceed.
    > ![Test flow of card](media/cc-test-run-flow.png "Test flow of card")

    When the card is saved, the **Manage insight cards** list gets updated and the **Due date coming up** card displays. Now you can edit the card to set priority and assign to different security roles.


### See also

- [Manage custom insight cards using Microsoft Flow](manage-custom-cards-flow.md)
- [Edit insight cards](edit-insight-cards.md)
- [Optimize ranking of insight cards](optimize-ranking-insight-cards.md)
