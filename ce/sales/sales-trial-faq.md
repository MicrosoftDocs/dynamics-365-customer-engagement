---  
title: Sales Trial FAQ
description: Solutions to common questions related to Dynamics 365 Sales trial sign up and management. Learn how to resolve platform and app-specific issues.
author: lavanyakr01
ms.author: lavanyakr
ms.date: 11/11/2022
ms.topic: conceptual
ms.custom: 
  - template-trial-faq
  - bap-template
ms.reviewer: shujoshi
---
# Dynamics 365 Sales trial FAQ 

The Sales trial offers a straightforward experience for sign-up, login, and usage. However, if you're stuck or have questions about the trial, check out this page for answers.

To sign up for the trial, go to the [Sales overview page](https://dynamics.microsoft.com/sales/overview/) and select **Try for free**.

[!INCLUDE[trial-faq-platform](../shared/trials/trial-faq-platform.md)]

### Can I convert the trial to a paid license?

Yes, you can purchase licenses through direct, credit card purchase at admin.microsoft.com. Or, you can work with sales to establish a volume licensing or enterprise agreement. Visit our [Pricing page](https://dynamics.microsoft.com/pricing/) for more information on pricing and purchasing.

To purchase the license using an existing account, work with the administrator of the account to apply for licenses.

After you have applied for the license to your tenant, you can publish your environment to production. You can remove the sample data. However, you have to manually reset the configuration and remove any test data that you've added. We recommend that you create a fresh environment to use for your production environment and add the configurations you’d like to move forward with.

### What are the trial limits and quotas?

The following limitations apply for the trial:

- The trial is available to you for 30 days. After that, you can request for an extension for another 30 days, buy a paid license, or sign up for a new trial.  
- You can have only one active trial per app at a time. You can sign up again after your current trial for the app ends.

## Dynamics 365 Sales-specific questions

This section contains answers to the following questions:
- [How do I start using the trial?](#how-do-i-start-using-the-trial)
- [What features are available in the trial?](#what-features-are-available-in-the-trial)
- [Why am I not able to use conversation intelligence features?](#why-am-i-not-able-to-use-conversation-intelligence-features)
- [Why can't I find the features and options mentioned in the documentation?](#why-cant-i-find-the-features-and-options-mentioned-in-the-documentation)
- [What should I do if I don't see any apps in the mobile app](#what-should-i-do-if-i-dont-see-any-apps-in-the-mobile-app)
- [Why is the sample data not available to all trial users?](#why-is-the-sample-data-not-available-to-all-trial-users)
- [How do I remove sample data from the trial?](#how-do-i-remove-sample-data-from-the-trial)
- [How do I add or restore sample data?](#how-do-i-add-or-restore-sample-data)
- [Is the Sales trial available in all geographical regions?](#is-the-sales-trial-available-in-all-geographical-regions)

### How do I start using the trial?

When the trial is ready, you can get started with the following resources:

**Explore product tours and videos for key capabilities**

The trial comes with product walkthroughs and videos, highlighting the important scenarios that you could try in the app and get the maximum value in minimal time. Select **Take a tour** at the lower-right corner to follow a guided  tour that gets you started quickly on the salient features.  

Once you understand how different entities are connected to offer value, try the scenarios with sample data or with your own data. 

**Play around with the mobile app**

Install the Sales mobile app and explore the functionalities that you can access on the move. Open the **Resources** page and scroll down to the **Explore the mobile app** section to download the app. For more information on using the app, see [Use the Dynamics 365 Sales mobile app](sales-mobile/use-sales-mobile-app.md). If you run into issues, see [What should I do if I don't see any apps in the mobile app](#what-should-i-do-if-i-dont-see-any-apps-in-the-mobile-app). 

**Deep dive into more scenarios**

If you want to test scenarios beyond the ones covered in the product tour, go ahead and take a plunge. To browse through other capabilities, select the **Sales trial** link at the top of your trial app and select **Sales Hub** from the list of apps. Visit the [Help Hub](help-hub.yml) for more information on all the capabilities.

### What features are available in the trial?

Your trial includes a simplified Trial app with a few important capabilities to get you started quickly. However, you can access the fully functional, Dynamics 365 Sales Premium environment. Select the **Sales trial** link at the top of your trial app and select **Sales Hub** from the list of apps.

The following licenses and capabilities pre-installed in the trial app:

**Dynamics 365 Sales Premium**

- Manage sales pipeline using leads and opportunities

- Forecast sales
- Use sales insights features (Sales accelerator, conversation intelligence, and predictive scoring) with limited monthly capacity. More information: [Digital selling capabilities in Sales Enterprise](digital-selling.md)
    - Sell smartly using Sales accelerator that builds a strong and prioritized pipeline, offers context, and surfaces automated recommendations.

    - Improve seller coaching and sales potential with conversation intelligence.
        > [!NOTE]
        > Conversation intelligence is only supported for work accounts.
    - Get the AI-powered assistant to stay on top of your activities.
    - Prioritize leads and opportunities using predictive scoring.
    - Analyze revenue outcome by using predictive forecasting.

To get started with the Sales Insights functionalities, see [Sales Insights Add-in for Dynamics 365 Sales Help & Training](/dynamics365/sales/help-hub). To enable Sales Insights, see [Enable and configure standard Sales Insights features](/dynamics365/sales/intro-admin-guide-sales-insights#enable-and-configure-standard-sales-insights-features).

> [!NOTE]
> Sales Insights functionalities are restricted to specific regions. For information on supported regions, see [In which region is Sales Insights available?](/dynamics365/sales/faqs-sales-insights#general). If you are not in a supported region, you can only  access the Sales Enterprise functionalities.  

**Microsoft Power Platform**
- Administer and customize the Power Platform environment that hosts Dynamics 365 Sales to fit your needs.

### Why am I not able to use conversation intelligence features? 

Conversation intelligence is only supported for work accounts with a Microsoft tenant. For other accounts, conversation intelligence options in the app will display a message as shown in the following screenshot:

:::image type="content" source="media/ci-trial-unsupported.png" alt-text="A screenshot of message shown in the conversation intelligence pages for non-work accounts.":::

### Why can't I find the features and options mentioned in the documentation?

The trial is designed to give you the optimum experience. Though the Trial includes a premium license, the Sales trial app includes only a few important features. If you would like to explore other features, select the **Sales trial** link at the top of your trial app and select **Sales Hub** from the list of apps. Also, the Trial app sitemap is organized differently than the production apps. Hence, the navigation mentioned in the documentation will not match for the Trial app.  

### What should I do if I don't see any apps in the mobile app

When you log into the Dynamics 365 mobile app for the first time, you might encounter the following message:

```You currently have no apps```

**To view your trial apps,**

1. Select your avatar on the mobile app and select **Settings**.  

1. Enable the **Show non-production apps** option.  
    You can now see all the apps that you've access to. 
1. Select **Sales trial** to log into your trial. 
 
### Why is the sample data not available to all trial users?

Sample data related to forecasting and Sales accelerator are only available to the user who signed up for the trial. 

**To give access to other trial users**: 

1. Select **Leads** in the sitemap (left pane).  
1. Select the sample data and select **Assign** in the command bar. 
1. In the **Assign to** field, select **User or Team** and then pick the user or team name. 
   If you haven't created the team yet, you can select **New Record** in the **User or Team** drop-down to create a team and add the trial users. You can then come back and perform steps 1 to 3.

### How do I remove sample data from the trial?

Sample data resembles real life data and helps you learn how the product works if it was deployed in an organization. In some cases, you may want to remove sample data. For example, the sample data is interfering with the scenarios you want to try out.

**To remove sample data:**

1. In the Sales sitemap, select the **Resources** page.
  
1. Scroll down to the **More resources** section and select **Add or remove sample data**.
1. Select **Remove sample data**.
     After you confirm, it takes a few seconds to remove the sample data.
    > [!NOTE]
    > This action doesn't delete the data that you have added in the trial app.

### How do I add or restore sample data?

If you have modified the sample data and want to restore it back to original, then remove the existing sample data and add the fresh dataset.

**To restore the sample data:**

1. To remove the existing sample data, see [How do I remove sample data from the trial?](#how-do-i-remove-sample-data-from-the-trial)  
  
    After the sample data is removed completely, you'll see the **Add sample data** button.
  
1. Select **Add sample data** to add the fresh sample data.

### Is the Sales trial available in all geographical regions?

Though you can sign up for the trial from any region, the Sales Insights functionalities are restricted to specific regions. For information on supported regions, see [In which region is Sales Insights available?](faqs-sales-insights.md#general). If you are not in a supported region, you can only access the Sales core functionalities.  

### See also
- [Sign up for a free trial](sign-up-for-sales-trial.md)
