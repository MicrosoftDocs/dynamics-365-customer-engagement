---
title: "Digital selling | MicrosoftDocs"
description: "Enable digital selling capabilities with the Dynamics 365 Sales Enterprise license."
ms.date: 01/07/2022
ms.topic: article
ms.service: dynamics-365-sales
author: sbmjais
ms.author: shjais
manager: shujoshi
---

# Digital selling capabilities in Sales Enterprise

Use selected Dynamics 365 Sales Premium features (Sales accelerator, conversation intelligence, and predictive scoring) with the Dynamics 365 Sales Enterprise license.

## License and role requirements

| &nbsp; | &nbsp; |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security Role** | System Administrator <br>  See [Predefined security roles for Sales](security-roles-for-sales.md)|
|||

## Overview

Dynamics 365 digital selling capabilities spearhead the digital transformation of sales organizations and constitute the data and productivity first revolution. You can enhance your digital selling programs with Sales Premium features such as Sales accelerator, conversation intelligence, and predictive scoring that are available with the Dynamics 365 Sales Enterprise license. The premium features are available with a limited monthly capacity. If you would like to avail all the benefits of premium features, you can purchase a license for Dynamics 365 Sales Premium.

To use digital selling capabilities, you must have Sales Hub app installed. If you don't have the Sales Hub app, you can install it by following the steps mentioned at: [Install the Sales solution](set-up-dynamics-365-sales.md#install-the-sales-solution). Once the Sales Hub app is installed, digital selling capabilities can be set up from the **Get started with digital sales** page under **App Settings**.

> [!NOTE]
> If you have a Dynamics 365 Sales Premium license, you can still use this page to quickly set up the features. The only difference would be that there will be no monthly capacity limit.

## Set up digital sales

1. In lower-left corner of the screen, select **Change area** ![Icon to change the work area.](media/change-area-icon.png "Icon to change the work area") and then select **App Settings**.

    The **Get started with digital sales** page is displayed.

    :::image type="content" source="media/ds-get-started.png" alt-text="Get started page for setting up digital sales":::

2. Use the **Quick setup** button to quickly set up the features as described in the following sections:

    - [Sales accelerator](#sales-accelerator)
    - [Microsoft Teams collaboration](#microsoft-teams-collaboration)
    - [Microsoft Teams calls with conversation intelligence](#microsoft-teams-calls-with-conversation-intelligence)
    - [Lead and opportunity scoring](#lead-and-opportunity-scoring)

    After you've set up the features, the **Quick setup** button changes to **Edit settings**. Select **Edit settings** to update the settings as required.

    :::image type="content" source="media/ds-all-setup.png" alt-text="All features enabled in digital sales":::

    > [!NOTE]
    > If advanced configurations are required, you can to go to the advanced settings page for each of the Sales Premium features. The settings you update at one place, are synced in both quick setup and advanced settings.

## Sales accelerator

Sales accelerator in Dynamics 365 provides a tailored experience for sellers by minimizing the time they spend on their search for the best next customer to reach out to. It gathers information from multiple sources and lets sellers focus on how to best approach their customers. It helps sellers to sell smartly, by building a strong and prioritized pipeline, offering context, and surfacing automated recommendations throughout a sales sequence that helps to speed the sales process. More information: [What is the Sales accelerator?](sales-accelerator-intro.md)

When you setup sales accelerator with the Dynamics 365 Sales Enterprise license, you get only 1500 sequence-connected records per month. If you require more capacity, you must purchase a license for Dynamics 365 Sales Premium.

### Set up sales accelerator

1. On the **Get started with digital sales** page, under **Sales accelerator**, select **Quick setup**.

    The **Sales accelerator quick setup** panel is displayed.

    :::image type="content" source="media/ds-sa-setup.png" alt-text="Sales accelerator quick setup panel":::

2. In the **Enable for** section, choose one of the following options to grant permissions to use sales accelerator features.

    - **All security roles**: Select this option to give access to view the Sales Hub app to all the security roles in your organization.
    - **Specific security roles**: Select this option to specify security roles to give access to view the Sales Hub app to just a few users. Use the lookup box to add the security roles.

3. To add sample data for exploring the feature, select **Add sample data**. Installing the sample data is relevant only for your sandbox or trial environments. Adding the sample data might take a few minutes. However, you can choose to ignore the sample data installation and add it later when required.

4. In the **Content and layout** section, select the record types and their corresponding related forms that are used in your organization, as required.
    1. To add more records, select **Add record type**, and then select a record from the drop down list.
    2. Select a form for the selected record.

5. To publish the changes, select **Publish**.

Once the settings are published, you can open the seller's interface for sales accelerator by selecting **Go to seller experience** under **Sales accelerator** on the **Get started with digital sales** page.

> [!NOTE]
> If you want to make advanced configurations for sales accelerator, select **Go to advanced sales accelerator settings** at the top of the quick setup panel. For information on advanced configurations, see [Configure the sales accelerator for Sales Premium](enable-configure-sales-accelerator.md)

### Turn off sales accelerator

If you want to turn off sales accelerator, you do it from the advanced settings.

1. Select **Go to advanced sales accelerator settings** at the top of the quick setup panel.

2. On the **Sales accelerator setup** page, select **Unpublish**.

3. In the confirmation dialog box, select **Unpublish**.

## Microsoft Teams collaboration

Connect Dynamics 365 and Microsoft Teams so your sales teams can collaborate seamlessly on deals from wherever they work. Dynamics 365 and Microsoft Teams integration allows you to speed up the flow of work, enabling anyone in an organization to view and collaborate on Dynamics 365 records, from within the flow of work with Teams—at no additional cost. More information: [Overview of Microsoft Teams integration](../teams-integration/teams-integration.md)

### Set up Teams collaboration

1. On the **Get started with digital sales** page, under **Microsoft Teams collaboration**, select **Quick setup**.

    The **Teams collaboration quick setup** panel is displayed.

    :::image type="content" source="media/ds-teams-collab-setup.png" alt-text="Teams collaboration quick setup panel":::

2. Turn on the **Chat and collaborate from Dynamics 365 (preview)** toggle to enable the [embedded Teams chat](../teams-integration/using-teams-chat-in-dynamics.md) capability.

3. Turn on the **Connect records to channels in Microsoft Teams** toggle to enable [basic Teams integration](../teams-integration/teams-collaboration.md).

4. Select **Apply**.

Once the settings are enabled, your sellers can use Teams in Dynamics 365 and link chats to records to collaborate on deals. They can also pin records and views to Teams channels so they can collaborate on deals directly from Microsoft Teams.

> [!NOTE]
> If you want to make advanced configurations for Teams collaboration, select **Go to advanced Teams collaboration settings** at the top of the quick setup panel. For information on advanced configurations, see [Install and set up Microsoft Teams integration](../teams-integration/teams-install-app.md)

### Turn off Teams collaboration

1. Select **Go to advanced Teams collaboration settings** at the top of the quick setup panel.

2. Turn off **Chat and collaborate from Dynamics 365 (preview)** and **Connect records to channels in Microsoft Teams** toggles.

3. Select **Apply**.

## Microsoft Teams calls with conversation intelligence

Microsoft Teams dialer helps sellers to be more productive and get work done more effectively by calling customers directly from within Dynamics 365 Sales Hub app. More information: [Call using Microsoft Teams](call-using-microsoft-teams.md)

Conversation intelligence uses analytics and data science to gather data from sellers' call recordings and Dynamics 365 Sales. Conversation intelligence analyzes the data to provide you with the information and insights to intelligently manage your sales team and proactively coach sellers. More information: [Overview of Conversation Intelligence](dynamics365-sales-insights-app.md)

When you setup Microsoft Teams calls with conversation intelligence with the Dynamics 365 Sales Enterprise license, you get only 3 hours of conversation intelligence per month. If you require more capacity, you must purchase a license for Dynamics 365 Sales Premium. There's no capacity limit on Teams calls.

### Set up Microsoft Teams calls with conversation intelligence

1. On the **Get started with digital sales** page, under **Microsoft Teams calls with conversation intelligence**, select **Quick setup**.

    The **Teams calls + conversation intelligence quick setup** panel is displayed.

    :::image type="content" source="media/ds-ci-setup.png" alt-text="Teams calls + conversation intelligence quick setup panel":::

2. Turn on the **Teams calls (preview)** toggle to enable Teams dialer and allow sellers to make calls directly from within Dynamics 365 Sales Hub app.

    - In the **Enable for** section, select one of the following options to provide permissions to users to view Microsoft Teams dialer:
        - **All security roles**: Select this option to provide access to view Microsoft Teams dialer to users in all the security roles in your organization.
        - **Specific security roles**: Select this option to specify security roles when you want to give access to view Microsoft Teams dialer to specific users.

3. Turn on the **Recording with real-time transcription and insights (preview)** toggle to allow sellers to record calls by using the Teams dialer and get the most out of every call with advanced conversation intelligence capabilities such as AI-powered insights, rich call summaries, and more.

    - In the **Enable for** section, select one of the following options to provide permissions to users to record calls:
        - **All security roles**: Select this option to allow call recording by all the security roles in your organization.
        - **Specific security roles**: Select this option to allow call recording only by specify security roles.
    
    > [!TIP]
    > - To implement the call recording capability in your entire organization, select **All security roles**.
    > - For a phased implementation in your organization, create different security roles for each group of users and then assign the security role accordingly.

4. Select **Update**.

Once settings are enabled, sellers can make calls to their customer from within Dynamics 365 Sales Hub app. They can also record the calls and apply conversation intelligence capabilities to get the most out of every call.

> [!NOTE]
> If you want to make advanced configurations for Teams calls + conversation intelligence settings, select **Go to advanced conversation intelligence settings** at the top of the quick setup panel. For information on advanced configurations, see [First-run setup experience of Microsoft Teams for conversation intelligence](fre-setup-ci-sales-app.md)

### Turn off Teams calls + conversation intelligence

1. Select **Go to advanced conversation intelligence settings** at the top of the quick setup panel.

2. Turn off **Teams calls (preview)** and **Recording with real-time transcription and insights (preview)** toggles.

3. Select **Update**.


## Lead and opportunity scoring

Predictive lead scoring allows you to prioritize your leads based on scores and achieve higher lead qualification rates.
It provides a scoring model to generate scores for leads that are available for you in your pipeline. More information: [Prioritize leads through scores](work-predictive-lead-scoring.md)

Predictive opportunity scoring allows you to prioritize your opportunities based on scores and achieve higher opportunity qualification rates. It provides a scoring model to generate scores for opportunities in your pipeline. More information: [Prioritize leads through scores](work-predictive-lead-scoring.md)

When you setup lead and opportunity scoring with the Dynamics 365 Sales Enterprise license, you get only 1500 scored records per month. If you require more capacity, you must purchase a license for Dynamics 365 Sales Premium.

### Set up lead and opportunity scoring

1. On the **Get started with digital sales** page, under **Lead and opportunity scoring**, select **Quick setup**.

    The **Lead and opportunity scoring quick setup** panel is displayed.

    :::image type="content" source="media/ds-scoring-setup.png" alt-text="Lead and opportunity scoring quick setup panel":::

2. To enable predictive lead scoring, select **Create and publish** in the **Predictive lead scores** section.

    > [!NOTE]
    > A minimum of 40 qualified and 40 disqualified leads are required that were created in the past 2 years.

    The application starts generating a model, and a notification for training the model is displayed. Standard attributes are used to generate the model. Once the model is generated, it is published automatically.

3. To enable predictive opportunity scoring, select **Create and publish** in the **Predictive opportunity scores** section.

    > [!NOTE]
    > A minimum of 40 won and 40 lost opportunities are required that were created in the past 2 years.

    The application starts generating a model, and a notification for training the model is displayed. Standard attributes are used to generate the model. Once the model is generated, it is published automatically.

Once the models are trained and published, the **Lead score** and **Opportunity score** widgets are added to the Lead and Opportunity forms respectively.

> [!NOTE]
> If you want to make advanced configurations for lead and opportunity scoring settings, select **Go to advanced lead score settings** and **Go to advanced opportunity score settings** in their respective sections. For information on advanced configurations, see [Configure predictive lead scoring](configure-predictive-lead-scoring.md) and [Configure predictive opportunity scoring](configure-predictive-opportunity-scoring.md)

### Turn off lead and opportunity scoring

If you want to turn off lead and opportunity scoring, you do it from their respective advanced settings.

**To turn off lead scoring**:

1. Select **Go to advanced lead score settings**.

2. On the **Predictive lead scoring** page, select **Delete model**.

3. In the confirmation dialog box, select **Delete**.

**To turn off opportunity scoring**:

1. Select **Go to advanced opportunity score settings**.

2. On the **Predictive opportunity scoring** page, select **Delete model**.

3. In the confirmation dialog box, select **Delete**.

### Add lead and opportunity scoring widgets to a custom form

By default, the lead and opportunity scoring widgets are available only in the out-of-the-box **Sales Insights** form. If you're using customized forms for leads and opportunities, you can add the scoring widgets to your custom forms. For information about adding scoring widgets to a custom form, see [Add the lead scoring widget to a form](configure-predictive-lead-scoring.md#add-the-lead-scoring-widget-to-a-form) and [Add the opportunity scoring widget to a form](configure-predictive-opportunity-scoring.md#add-the-opportunity-scoring-widget-to-a-form).

### See also

[Configure the sales accelerator for Sales Premium](enable-configure-sales-accelerator.md)   
[Install and set up Microsoft Teams integration](../teams-integration/teams-install-app.md)  
[First-run setup experience of Microsoft Teams for conversation intelligence](fre-setup-ci-sales-app.md)   
[Configure predictive lead scoring](configure-predictive-lead-scoring.md)   
[Configure predictive opportunity scoring](configure-predictive-opportunity-scoring.md)