---
title: Create insight cards
description: Create your own suggested actions through custom insight cards using Microsoft Power Automate in Assistant in Dynamics 365 Sales.
ms.date: 07/02/2024
ms.custom: bap-template
ms.topic: how-to
author: udaykirang
ms.author: udag
ms.reviewer: udag
---

# Create custom insight cards 

As a system administrator or sales manager, you can create your own suggested actions that are more relevant to your organization through the assistant management feature. By using events and conditions, you can customize the circumstances on when to create suggestions and push information into the seller’s workflow. This helps the sellers to close deals faster.  

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator or Sales Manager <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## Create a custom insight card  

>[!NOTE]
>
>- Effective August 1, 2024, templates to create new assistant cards won't be available. You can continue to use the Microsoft Power Automate flow to create your custom cards.
>- To create custom insight cards with the assistant studio, ensure that Microsoft Power Automate is installed.
>- The custom insight card is displayed in the list of insight cards in **Assistant studio** only after a card is generated based on the defined flow. For example, you defined a flow to display a card when an opportunity is created with an estimated value above $5,000. When an opportunity is created for the first time in the organization with the estimated value of $6,000, the card is generated and will be available in the list of insight cards in **Assistant studio**.

1. In the Sales Hub app, go to **Change area** in the lower-left corner of the page and select **Sales Insights settings**.

1. On the site map, under **Assistant**, select **Home** to go to the **Assistant Studio** page.

    > [!TIP]
    > Alternatively, on the **Sales Insights settings** page, select **Manage** from the **Assistant (full capabilities)** section to go to the **Assistant Studio** page.

1. On the **Assistant Studio** page, select **+ New insight card**.  

1. Select **+ Create from blank** and create a flow in Power Automate to define the conditions and actions for the card.

    To learn more about creating a flow, see [Create a flow in Power Automate](/power-automate/get-started-logic-flow).

1. Use **Flow Checker** to verify errors and warnings in the flow. 

    Errors and warnings in the flow cause performance or reliability issues. Ensure that the flow is free of errors and warnings. The checker is always active, appearing in the command bar in the designer. The checker shows a red dot when it finds one or more errors in your flow.

    When you select **Flow Checker**, the corresponding error is displayed with more details. In this example, the error specifies that the **Card Name** is not entered. Resolve the error to continue.

    > [!NOTE]
    > You must resolve all errors and warnings to save the flow.

1. (Optional) Select the **Test** button to test your flow. 

    Ensure that all the configured steps are working as required. The test feature runs and validates each step in the flow and highlights any error that occurs on a step. You must resolve the error to proceed.

1. Save the flow.

The card is created. You can further edit the card to set priority and assign to different security roles.

## View your saved flows

After you create a flow, a card must be generated based on the created flow to access the flow in the designer. Sometimes, cards may not be generated immediately and you may not find the created flow to update or view. 

To access the saved flows, follow these steps:

1. Go to [Microsoft Power Automate](https://flow.microsoft.com) and sign in with your Dynamics 365 Sales credentials.

    > [!NOTE]
    > By default, your organization is selected based on your latest association. If you have multiple organizations associated with you, select the proper organization from your profile settings. 

2. Select **Solutions** and then select **Default Solution**.

    > [!div class="mx-imgBorder"]
    > ![Select Default Solution option](media/si-admin-view-flows-solution-selection.png "Select Default Solution option")

    All default solutions are listed.

3. On the tool bar, go to Search and search for the flow that you want update or view.

    > [!div class="mx-imgBorder"]
    > ![Search for your solution](media/si-admin-view-flows-search-solution.png "Search for your solution")

## Add actions to cards

You can add actions that a user can do on a card. To select an action, follow these steps:

1. In the **Search connectors and actions** box, enter **Sales Insights**.

2. Select the **Create card for assistant V2 (preview)** connector.

    > [!div class="mx-imgBorder"]
    > ![Select action for card](media/insight-cards-select-action.png "Select action for card")

3. In **Button type**, select one of the following actions:

    - **Custom action (CRM process)**: Perform the steps in [Custom action (CRM process)](#custom-action-crm-process) to invoke a custom action that is defined in Dynamics 365 Sales for an entity. 

    - **Open record**

    - **Open URL**

    - **REST**: Perform the steps in [REST](#rest) to invoke a REST API with the custom action.

    > [!div class="mx-imgBorder"]
    > ![List of supported actions for card](media/insight-card-button-types.png "List of supported actions for card")


### Custom action (CRM process)

Use the **Custom action (CRM process)** option to invoke a custom action that is defined in Dynamics 365 Sales for an entity. To learn more, see [Use Web API actions](/powerapps/developer/common-data-service/webapi/use-web-api-actions).

To add a custom action, follow these steps:

1. In the **Search connectors and actions** box, enter **Sales Insights**.

2. Select the **Choose custom action (CRM process) for insight card (preview)** connector.

    > [!div class="mx-imgBorder"]
    > ![Select action for card](media/insight-cards-select-action.png "Select action for card")

    A step to choose a custom action appears.

    > [!div class="mx-imgBorder"]
    > ![Step to add custom action](media/insight-card-custom-action.png "Step to add custom action")

3. In the **Choose custom action (CRM process) for insight card** step, enter the required information.

    | Parameter | Description |
    |-----------|-------------|
    | Environment (org)| Select your organization name. |
    | Filter by entity | Choose the entity that is associated with the action. |
    | Custom action (CRM process)| Select the custom action that you want to perform on the card. |
    | Status | This is a dynamic field and the values that are displayed here are based on the selected custom action. | 

4. Define the card by using the chosen custom action. In the **Create card for assistant V2** step, enter the required information.

    | Parameter | Description |
    |-----------|-------------|
    | Environment (org)| Select your organization name. |
    | Card name | Enter a name for the card. |
    | Card header| Enter a name to appear on the header of the card.  |
    | Card text | Enter a message to appear in the body of the card. |
    | Button text | Enter a name for the button that should appear on the card. |
    | Button type | Select the button type as **Custom action (CRM process)**. |
    | Custom action for insight card | Select the box. The custom action that is defined in the previous step is added automatically. This option appears only for the **Custom action (CRM process)** button type. | 

    > [!div class="mx-imgBorder"]
    > ![Create card for the custom action](media/insight-card-custom-action-define-card.png "Create card for the custom action")

### REST

Use the **REST** option to invoke REST API.  

1. On the **Create card for assistant V2 (preview)** step, select the **Button type** as **REST**.

2. Enter the information as required.

    | Parameter | Description |
    |-----------|-------------|
    | Environment (org)| Select your organization name. |
    | Card name | Enter a name for the card. |
    | Card header| Enter a name to appear on the header of the card.  |
    | Card text | Enter a message to appear in the body of the card. |
    | Button text | Enter a name for the button that should appear on the card. |
    | Button type | Select the button type as **REST**. |
    | Endpoint | Enter the URL of the corresponding API to call. This option appears only for the **REST** button type. |
    | HTTP method | Choose an HTTP method for the API to call. This option appears only for the **REST** button type. |
    | Body| Enter request parameters for the REST API. This option appears only for the **REST** button type.| 

    > [!div class="mx-imgBorder"]
    > ![Create a card for playbook](media/insight-card-rest-api.png "Create a card for playbook")

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]    

### See also

[Configure and manage insight cards for the premium assistant](configure-assistant.md#premium-assistant)  
[Edit insight cards](edit-insight-cards.md)  
[Optimize ranking of insight cards](optimize-ranking-insight-cards.md)



[!INCLUDE[footer-include](../includes/footer-banner.md)]
