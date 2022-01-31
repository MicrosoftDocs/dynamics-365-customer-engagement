---
title: "Digital selling | MicrosoftDocs"
description: "Enable digital selling capabilities with the Dynamics 365 Sales Enterprise license."
ms.date: 01/28/2022
ms.topic: article
ms.service: dynamics-365-sales
author: sbmjais
ms.author: shjais
manager: shujoshi
---

# Digital selling capabilities in Sales Enterprise

Use selected Dynamics 365 Sales Premium features (sales accelerator, conversation intelligence, and predictive scoring) with the Dynamics 365 Sales Enterprise license.

> [!NOTE]
> These capabilities are being rolled out in phases and will be available in all geographical regions by January 31, 2022.

## License and role requirements

| &nbsp; | &nbsp; |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security Role** | System Administrator <br>  Go to [Predefined security roles for Sales](security-roles-for-sales.md)|
|||

## Overview

Dynamics 365 digital selling capabilities spearhead the digital transformation of sales organizations and constitute the data and productivity first revolution. You can enhance your digital selling programs with Sales Premium features such as the sales accelerator, conversation intelligence, and predictive scoring that are available with the Dynamics 365 Sales Enterprise license. The premium features are available with a limited monthly capacity. If you'd like access to all the [premium features](overview.md#dynamics-365-sales-premium), upgrade to Dynamics 365 Sales Premium.

To use digital selling capabilities, you must have Sales Hub installed. If you don't have the Sales Hub app, you can install it by following the steps described in [Install the Sales solution](set-up-dynamics-365-sales.md#install-the-sales-solution). After the Sales Hub app is installed, you can set up digital selling capabilities from the **Get started with digital sales** page under **App Settings**.

> [!NOTE]
> If you have a Dynamics 365 Sales Premium license, you can still use this page to quickly set up the features. The only difference would be that there will be no monthly capacity limit.

<br>

> [!VIDEO https://www.microsoft.com/en-us/videoplayer/embed/RWQCj0]

## Set up digital sales

1. In the lower-left corner of the screen, select **Change area** ![Icon to change the work area.](media/change-area-icon.png "Icon to change the work area") and then select **App Settings**.

    The **Get started with digital sales** page is displayed.

    :::image type="content" source="media/ds-get-started.png" alt-text="Get started page for setting up digital sales.":::

2. Use the **Quick setup** button to quickly set up the features as described in the following sections:

    - [Sales accelerator](#sales-accelerator)
    - [Microsoft Teams collaboration](#microsoft-teams-collaboration)
    - [Microsoft Teams calls with conversation intelligence](#microsoft-teams-calls-with-conversation-intelligence)
    - [Lead and opportunity scoring](#lead-and-opportunity-scoring)

    After you've set up the features, the **Quick setup** button changes to **Edit settings**. Select **Edit settings** to update the settings as required.

    :::image type="content" source="media/ds-all-setup.png" alt-text="All features enabled in digital sales":::

    > [!NOTE]
    > If you need to make advanced configurations, you can go to the advanced settings page for each of the Sales Premium features. The settings you update in one place will be reflected in both quick setup and advanced settings.

## Sales accelerator

The sales accelerator is an engagement platform that helps you understand your customers' needs and respond in meaningful ways. It allows your sellers to engage with your customers by using multiple channels within one workspace. The sales accelerator in Dynamics 365 provides a tailored experience for sellers by minimizing the time they spend on their search for the best next customer to reach out to. It gathers information from multiple sources and lets sellers focus on how to best approach their customers. It helps sellers to sell smartly, by building a strong and prioritized pipeline, offering context, and surfacing automated recommendations throughout a sales sequence that helps to speed the sales process. More information: [What is the sales accelerator?](sales-accelerator-intro.md)

> [!VIDEO https://www.microsoft.com/en-us/videoplayer/embed/RWQCjf]

### Licensing options

When you set up the sales accelerator with the Dynamics 365 Sales Enterprise license, you get 1,500 sequence-connected records per month. If you need more than 1,500 sequence-connected records per month, upgrade to Dynamics 365 Sales Premium.

### Set up the sales accelerator<a name="set-up-sales-accelerator"></a>

1. On the **Get started with digital sales** page, under **Sales accelerator**, select **Quick setup**.

    The **Sales accelerator quick setup** panel is displayed.

    :::image type="content" source="media/ds-sa-setup.png" alt-text="Sales accelerator quick setup panel.":::

2. In the **Enable for** section, choose one of the following options to grant permissions to use sales accelerator features:

    - **All security roles**: Select this option to give access to view the sales accelerator in the Sales Hub app to all the security roles in your organization.
    - **Specific security roles**: Select this option to specify security roles to give access to view the sales accelerator in the Sales Hub app to just a few users. Use the lookup box to add the security roles.

3. To add sample data for exploring the feature, select **Add sample data**.

    > [!NOTE]
    > The capability to install sample data is available only in your sandbox or trial environments. When you add sample data, you'll also see predictive lead and opportunity scoring on the **Sales Insights** form. Adding the sample data might take a few minutes. If you choose to ignore sample data installation at this point, you can add it later when you need it.

4. In the **Content and layout** section, select the record types and their corresponding related forms that are required in your organization.

    1. To add more record types, select **Add record type**, and then select a record from the dropdown list. The selected record type will display the **Sequence (up next)** widget. You can select out-of-the-box tables—such as **Accounts**, **Contacts**, **Leads**, and **Opportunities**—or custom tables.

       > [!NOTE]
       > - Ensure that the record types you select are the ones that activities are usually connected to. Sales managers use the record types to configure the sequence that will be assigned to records to be displayed in the app.
       > - To view the custom record types in the list, go to **Settings** > **Customizations** > **Customize the System** > **Components** > **Entities**. Under **Communication & Collaboration**, enable the options **Activities**, **Connections**, and **Sending email (If an email field does not exist, one will be created)**.
       > - To add the **Up next** widget to your custom entity form, go to [Add the Up next widget to an entity form](add-upnext-widget-form.md). 

    2. Select a form for the selected record.

       > [!NOTE]
       > - You can remove the record types that no longer need to have automated activities associated with them. Select the **X** icon next to the record type to remove it from the list. Note that if the records in the deleted record type are associated with a sequence, these records will continue to be associated with the sequence.   
       > - To know how records are populated in the work list, go to [View my records by using the work list](prioritize-sales-pipeline-through-work-list.md#view-my-records-through-work-list).

5. To publish the changes, select **Publish**.

After the settings are published, you can open the seller's interface for the sales accelerator by selecting **Go to seller experience** under **Sales accelerator** on the **Get started with digital sales** page. Sellers can immediately use the sales accelerator for manually created activities. However, you can also guide your sellers by creating sequences. For information about creating sequences, go to [Manage sequences](create-manage-sequences.md).

### Advanced settings

If you want to make advanced configurations for sales accelerator, select **Go to advanced sales accelerator settings** at the top of the quick setup panel. For information about advanced configurations, go to [Configure the sales accelerator for Sales Premium](enable-configure-sales-accelerator.md).

:::image type="content" source="media/ds-sa-advanced_setup.png" alt-text="Advanced settings link in quick setup panel for sales accelerator.":::

### Add the sales accelerator to a custom app

If you've created a custom app, you can add the sales accelerator to it from the app designer. More information: [How to add work list site map to your custom app](faqs-sales-insights.md#how-to-add-work-list-site-map-to-your-custom-app)

### Turn off the sales accelerator

If you want to turn off the sales accelerator, you can do it from the advanced settings.

1. Select **Go to advanced sales accelerator settings** at the top of the quick setup panel.

2. On the **Sales accelerator setup** page, select **Unpublish**.

    :::image type="content" source="media/ds-sa-turn-off.png" alt-text="Turn off sales accelerator.":::

3. In the confirmation dialog, select **Unpublish**.

### Add the sequence (Up next) widget to a custom form

By default, the **Up next** widget is available only in the out-of-the-box Sales Insights, lead, and opportunity forms. If you're using customized forms, you can display the Up next widget on your custom forms. For information about adding the **Up next** widget to a custom form, go to [Add the Up next widget to a custom form](add-upnext-widget-form.md) For information about using the **Up next** widget, go to [Connect with customers through a record or the Up next widget](connect-with-customers.md).

## Microsoft Teams collaboration

Connect Dynamics 365 and Microsoft Teams so your sales teams can collaborate seamlessly on deals from wherever they work. Dynamics 365 and Microsoft Teams integration allows you to speed up the flow of work, enabling anyone in an organization to view and collaborate on Dynamics 365 records, from within the flow of work with Teams—at no additional cost. More information: [Overview of Microsoft Teams integration](../teams-integration/teams-integration.md)

> [!VIDEO https://www.microsoft.com/en-us/videoplayer/embed/RWQEPI]

### Set up Teams collaboration

1. On the **Get started with digital sales** page, under **Microsoft Teams collaboration**, select **Quick setup**.

    The **Teams collaboration quick setup** panel is displayed.

    :::image type="content" source="media/ds-teams-collab-setup.png" alt-text="Teams collaboration quick setup panel.":::

2. Turn on the **Chat and collaborate from Dynamics 365 (preview)** toggle to enable the [embedded Teams chat](../teams-integration/using-teams-chat-in-dynamics.md) capability.

3. Turn on the **Connect records to channels in Microsoft Teams** toggle to enable [basic Teams integration](../teams-integration/teams-collaboration.md).

4. Select **Apply**.

After the settings are enabled, your sellers can use Teams in Dynamics 365 and link chats to records to collaborate on deals. They can also pin records and views to Teams channels so they can collaborate on deals directly from Microsoft Teams.

### Advanced settings

If you want to make advanced configurations for Teams collaboration, select **Go to advanced Teams collaboration settings** at the top of the quick setup panel. For information about advanced configurations, go to [Install and set up Microsoft Teams integration](../teams-integration/teams-install-app.md).

:::image type="content" source="media/ds-teams-collab-advanced-setup.png" alt-text="Advanced settings link in quick setup panel for Teams collaboration.":::

### Turn off Teams collaboration

1. Select **Go to advanced Teams collaboration settings** at the top of the quick setup panel.

2. Turn off the **Chat and collaborate from Dynamics 365 (preview)** and **Connect records to channels in Microsoft Teams** toggles.

3. Select **Apply**.

## Microsoft Teams calls with conversation intelligence

Microsoft Teams dialer helps sellers to be more productive and get work done more effectively by calling customers directly from within the Dynamics 365 Sales Hub app. More information: [Call using Microsoft Teams](call-using-microsoft-teams.md)

Conversation intelligence uses analytics and data science to gather data from sellers' call recordings and Dynamics 365 Sales. Conversation intelligence analyzes the data to provide you with the information and insights to intelligently manage your sales team and proactively coach sellers. More information: [Overview of Conversation Intelligence](dynamics365-sales-insights-app.md)

> [!VIDEO https://www.microsoft.com/en-us/videoplayer/embed/RWQzQl]

### Licensing options

When you set up Microsoft Teams calls with conversation intelligence with the Dynamics 365 Sales Enterprise license, there's no limit on the number of calls made through Microsoft Teams. However, you get three hours of conversation intelligence per month. If you need more than three hours of conversation intelligence per month, upgrade to Dynamics 365 Sales Premium. Note that three hours of conversation intelligence refers to recording and processing time.

### Set up Microsoft Teams calls with conversation intelligence

1. On the **Get started with digital sales** page, under **Microsoft Teams calls with conversation intelligence**, select **Quick setup**.

    The **Teams calls + conversation intelligence quick setup** panel is displayed.

    :::image type="content" source="media/ds-ci-setup.png" alt-text="Teams calls + conversation intelligence quick setup panel.":::

    > [!NOTE]
    > To use Teams calls, sellers will need valid licenses for Microsoft Teams, Phone System, and Calling Plan or Direct Routing, in addition to assigned phone numbers. [Learn more](https://go.microsoft.com/fwlink/?linkid=2180901)

2. Turn on the **Teams calls (preview)** toggle to enable Teams dialer and allow sellers to make calls directly from within the Dynamics 365 Sales Hub app.

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

After settings are enabled, sellers can make calls to their customers from within the Dynamics 365 Sales Hub app. They can also record the calls and apply conversation intelligence capabilities to get the most out of every call.

> [!NOTE]
> You can also enable Teams calling for other apps from the **Advanced settings** option on the **Microsoft Teams calls** setup page. More information: [Configure Microsoft Teams dialer](configure-microsoft-teams-dialer.md)

### Advanced settings

If you want to make advanced configurations for Teams calls and conversation intelligence settings, select **Go to advanced conversation intelligence settings** at the top of the quick setup panel. For information about advanced configurations, go to [First-run setup experience of Microsoft Teams for conversation intelligence](fre-setup-ci-sales-app.md).

:::image type="content" source="media/ds-ci-advanced-setup.png" alt-text="Advanced settings link in quick setup panel for Teams calls + conversation intelligence.":::

### Turn off Teams calls and conversation intelligence

1. Select **Go to advanced conversation intelligence settings** at the top of the quick setup panel.

2. Turn off the **Teams calls (preview)** and **Recording with real-time transcription and insights (preview)** toggles.

    > [!NOTE]
    > If you turn off **Teams calls (preview)**, **Recording with real-time transcription and insights (preview)** will also be turned off. However, you can turn off only conversation intelligence (call recording) and leave the Teams calling option on.

3. Select **Update**.


## Lead and opportunity scoring

Predictive lead scoring allows you to prioritize your leads based on scores and achieve higher lead qualification rates.
It provides a scoring model to generate scores for leads that are available for you in your pipeline. More information: [Prioritize leads through scores](work-predictive-lead-scoring.md)

Predictive opportunity scoring allows you to prioritize your opportunities based on scores and achieve higher opportunity win, close, or convert rates. It provides a scoring model to generate scores for opportunities in your pipeline. More information: [Prioritize opportunities through scores](work-predictive-opportunity-scoring.md)

> [!VIDEO https://www.microsoft.com/en-us/videoplayer/embed/RWQjwl]

### Licensing options

When you set up lead and opportunity scoring with the Dynamics 365 Sales Enterprise license, you get 1,500 scored records per month. If you need to score more than 1,500 records per month, upgrade to Dynamics 365 Sales Premium.

### Set up lead and opportunity scoring

1. On the **Get started with digital sales** page, under **Lead and opportunity scoring**, select **Quick setup**.

    The **Lead and opportunity scoring quick setup** panel is displayed.

    :::image type="content" source="media/ds-scoring-setup.png" alt-text="Lead and opportunity scoring quick setup panel.":::

2. To enable predictive lead scoring, select **Create and publish** in the **Predictive lead scores** section.

    > [!NOTE]
    > This feature requires a minimum of 40 qualified leads and 40 disqualified leads, all of which have been created in the past two years.

    The application starts generating a model, and a notification for training the model is displayed. The model is generated by automatically selecting the attributes that can define the probability of a lead qualification or disqualification. After the model is generated, it's published automatically.

3. To enable predictive opportunity scoring, select **Create and publish** in the **Predictive opportunity scores** section.

    > [!NOTE]
    > This feature requires a minimum of 40 won opportunities and 40 lost opportunities, all of which have been created in the past two years.

    The application starts generating a model, and a notification for training the model is displayed. The model is generated by automatically selecting the attributes that can define the probability of an opportunity being closed as won or lost. After the model is generated, it's published automatically.

After the models are trained and published, the **Lead score** and **Opportunity score** widgets are added to the **Sales Insights** form of Lead and Opportunity records, respectively.

> [!NOTE]
> If you want to explore predictive scoring with sample data, you can publish sales accelerator with sample data.

### Advanced settings

You may want to modify the lead and opportunity scoring configurations, for example, to ensure the model is trained on fields that are most relevant to your organization or to add a separate model for a different line of business. To do so, go to the advanced configurations for lead and opportunity scoring settings, by selecting **Go to advanced lead score settings** and **Go to advanced opportunity score settings** in their respective sections. For information about advanced configurations, go to [Configure predictive lead scoring](configure-predictive-lead-scoring.md) and [Configure predictive opportunity scoring](configure-predictive-opportunity-scoring.md).

:::image type="content" source="media/ds-scoring-advanced-setup.png" alt-text="Advanced settings link in quick setup panel for Lead and opportunity scoring.":::

### Turn off lead and opportunity scoring

If you want to turn off lead and opportunity scoring, you can do it from their respective advanced settings.

**To turn off lead scoring**

1. Select **Go to advanced lead score settings**.

2. On the **Predictive lead scoring** page, select **Delete model**.

3. In the confirmation dialog, select **Delete**.

**To turn off opportunity scoring**

1. Select **Go to advanced opportunity score settings**.

2. On the **Predictive opportunity scoring** page, select **Delete model**.

3. In the confirmation dialog, select **Delete**.

### Add lead and opportunity scoring widgets to a custom form

By default, the lead and opportunity scoring widgets are available only in the out-of-the-box **Sales Insights** form. If you're using a form other than the **Sales Insights** form (for example, customized form) for leads and opportunities, you can add the scoring widgets to your custom forms. For information about adding scoring widgets to a custom form, go to [Add the lead scoring widget to a form](configure-predictive-lead-scoring.md#add-the-lead-scoring-widget-to-a-form) and [Add the opportunity scoring widget to a form](configure-predictive-opportunity-scoring.md#add-the-opportunity-scoring-widget-to-a-form).

### See also

[Configure the sales accelerator for Sales Premium](enable-configure-sales-accelerator.md)   
[Install and set up Microsoft Teams integration](../teams-integration/teams-install-app.md)  
[First-run setup experience of Microsoft Teams for conversation intelligence](fre-setup-ci-sales-app.md)   
[Configure predictive lead scoring](configure-predictive-lead-scoring.md)   
[Configure predictive opportunity scoring](configure-predictive-opportunity-scoring.md)