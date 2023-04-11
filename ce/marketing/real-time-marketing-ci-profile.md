---
title: "Use Customer Insights profiles and segments in real-time marketing (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to use Customer Insights profiles and segments in real-time marketing."
ms.date: 03/21/2022
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
search.audienceType: 
  - admin
  - customizer
  - enduser
---

# Use Customer Insights profiles and segments in real-time marketing

Real-time marketing enables you to deeply personalize your customer engagement using transactional, behavioral, and demographic data from [Dynamics 365 Customer Insights](/dynamics365/customer-insights). With Customer Insights data, you can:
- Target unified Customer Insights customer profiles and segments. This enables you to engage every customer, regardless of whether the customer's data is in Marketing or Customer Insights.
- Base dynamic content (such as personalized dynamic text) in emails, text messages, and push notifications on measures such as loyalty status, subscription renewal date, parent account, or any other measure you have captured in the unified customer profile.

For example, let's say you have an e-commerce website. You capture information about the visitors and shoppers on the website as customer profiles in Customer Insights. You decide you want to target visitors who have abandoned their carts while shopping.

To target visitors with abandoned carts, you first need to define a [custom trigger](real-time-marketing-custom-triggers.md) for any shopper who abandons a cart. You'll need to set the **Data type** field for the trigger's **Customer Data** property to **Profile (Customer Insights)**. You'll then need to set up a [trigger-based journey](real-time-marketing-trigger-based-journey.md) using the abandoned cart trigger.

> [!div class="mx-imgBorder"]
> ![Cart custom event screenshot.](media/real-time-marketing-ci-profile-cart-event.png)

Alternately, you can create a scheduled journey targeting the customers in an abandoned cart segment. When creating your journey, you'll be able to see segments from both Marketing and Customer Insights in the **Audience** dropdown list.

## Set up your Customer Insights environment for real-time marketing

To set up your Customer Insights data for real-time marketing customer journeys, complete the following steps:

1. Ensure that the Customer Insights environment is set up in a [region where real-time marketing is available](real-time-marketing-install.md). If your current environment is not in a region where real-time marketing is available, you can create a new Customer Insights environment using a copy of the previous environment.
1. Enable data sharing between your Customer Insights environment and the Microsoft Dataverse organization where Dynamics 365 Marketing is or will be installed. This can be done in the Advanced settings of the [Customer Insights environment configuration](/dynamics365/customer-insights/audience-insights/manage-environments#create-an-environment-in-an-existing-organization).
1. Set up **Map**, **Match**, and **Merge** rules in Customer Insights to unify customer data and create unified customer profiles. Be careful while setting up the unification rules. Any future changes to the rule can impact or break live customer journeys.
1. Create at least one segment.

## Set up your Dynamics 365 Marketing environment to automatically discover Customer Insights data

Marketing can automatically discover Customer Insights data and make it available for real-time marketing. To ensure automatic discovery, complete the following steps:

1. If you haven't [enabled real-time marketing](real-time-marketing-install.md) or are yet to install the Dynamics 365 Marketing application in a Dataverse org, complete the steps [in the section above](real-time-marketing-ci-profile.md#set-up-your-customer-insights-environment-for-real-time-marketing) to first set up your Customer Insights environment. If you complete these steps before real-time marketing is installed in the Dataverse org, the Marketing app will automatically discover the Customer Insights environment. You can verify whether Marketing has discovered the Customer Insights environment by going to **Settings** > **Data management** > **Customer Insights connector**.
1. If you’ve already enabled real-time marketing in the Marketing app prior to setting up Customer Insights as described above, the automatic discovery won't take place. In this case, **Settings** > **Data management** > **Customer Insights connector** shows the following screen:

> [!div class="mx-imgBorder"]
> ![Customer Insights setup screenshot.](media/real-time-marketing-ci-setup.png)

  - To retry Customer Insights discovery, complete the [above-listed steps](real-time-marketing-ci-profile.md#set-up-your-customer-insights-environment-for-real-time-marketing) in your Customer Insights environment, and then return to **Settings** > **Data management** > **Customer Insights connector** and select **Connect**.
  - If the setup is correct, Marketing will be able to discover Customer Insights and you should see the success indicator.

> [!div class="mx-imgBorder"]
> ![Customer Insights setup success screenshot.](media/real-time-marketing-ci-profile-success2.png)

## Set up default properties for unified customer profiles

When using Customer Insights customer profiles in real-time customer journeys, you'll be required to specify which attributes in the profile correspond to the customer’s preferred email and phone number. To eliminate the need for specifying this information every time, you can create default settings that customer journeys will automatically use from that point on.

Learn more: [Audience configuration](real-time-marketing-audience-data.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]