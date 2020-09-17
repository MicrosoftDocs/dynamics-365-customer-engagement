---
title: "Integrate Customer Voice with Dynamics 365 Marketing| Microsoft Docs  "
description: "Learn how to create surveys in Dynamics 365 Marketing using Microsoft Customer Voice."
keywords: Customer Voice; survey
ms.date: 09/17/2020
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
ms.assetid: dbc6f586-d4ba-4cdb-aa93-c1f92d61b262
author: alfergus
ms.author: alfergus
manager: shellyha
ms.reviewer:
topic-status: 
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Customer Voice integration with Dynamics 365 Marketing

Surveys are a critical feedback component for customer-obsessed organizations. Dynamics 365 Marketing with [Customer Voice](https://docs.microsoft.com/dynamics365/customer-voice) integration brings a rich set of capabilities for asking for feedback about your customers' needs. These survey capabilities help you make data-driven decisions and apply your findings to your marketing initiatives. Marketers can automate survey experiences and use data generated from surveys for advanced segmentation and customer profiling.

> [!NOTE]
> You will need your administrator to [turn on the feature switch](admin-feature-switches.md) for the "Customer Voice Marketing integration" functionality before you are able to access it.

## Create your survey in Customer Voice

All surveys that you [create in a Customer Voice environment](https://docs.microsoft.com/dynamics365/customer-voice/create-survey) are ready to use in Marketing. All survey data are available in CDS for segmentation.

## Customer Voice segmentation options

You can segment based on previous Customer Voice surveys, which allows you to act based on feedback from your customers. Your entire Customer Voice dataset is available for your marketing scenarios. With Customer Voice data, you can segment based on surveys, survey responses, specific questions answered, etc.

To use Customer Voice survey data in segments:

1. Go to **Customers** > **Segments** in the left navigation bar.
1. Create a new [dynamic segment](segmentation-lists-subscriptions.md#create-and-go-live-with-a-new-segment) by clicking **New** > **New Dynamic Segment** in the top menu.
1. You can choose from Customer Voice data options depending on whether you create an [interaction based or a profile based segment](segmentation-lists-subscriptions.md#segments-in-dynamics-365-marketing).

    Interaction-based segment Customer Voice options:

    ![Interaction-based segment Customer Voice](media/forms-pro-interaction.png "Interaction based segment Customer Voice")

    Profile-based segment Customer Voice options:

    ![Profile-based segment Customer Voice](media/forms-pro-profile.png "Profile based segment Customer Voice")

## Customer Voice survey links in email messages

To add a Customer Voice survey to an email message, go to the[email content designer](email-design.md). Then go to **Toolbox** > **Advanced elements** > **Customer Voice**. Drag and drop the **Customer Voice** element into your email.

![Drag and drop Customer Voice into an email](media/forms-pro-email-drag.png "Drag and drop Customer Voice into an email")

In the **Properties** tab, choose the survey you would like to use.

![Choose an email survey](media/forms-pro-choose-survey.png "Choose an email survey")

After you choose a survey, you can customize the email styling just as you would with any other email message.

## Customer Voice automation in customer journeys

Marketing gives you the option to automate customer journey actions based on Customer Voice survey data.

To add a Customer Voice survey to customer journey:
1. Go to the [customer journey designer](customer-journeys-create-automated-campaigns.md#design-your-journey). Then go to **Toolbox** > **Content** > **Customer Voice survey**. Drag and drop the **Customer Voice survey** tile onto your marketing email tile.

![Drag and drop Customer Voice into a customer journey](media/forms-pro-customer-journey-survey.png "Drag and drop Customer Voice into a customer journey")

2. In the **Properties** tab, choose the survey you would like to use.

![Choose a customer journey survey](media/forms-pro-customer-journey-pick-survey.png "Choose a customer journey survey")

3. In the **Properties** tab, check the **is anonymous** box if you do not want to distribute a named survey.

4. You can add a trigger to further understand how contacts engage with the survey.

![Choose a customer journey survey](media/forms-pro-trigger.png "Choose a customer journey survey")

You can use following trigger options:
- Trigger based on source (email or survey)
- Trigger based on a specific question
- Trigger based on an answer

> [!IMPORTANT]
> Entity names related to Forms Pro have changed to "Customer Voice." For example, if you are using [Advanced Find](https://docs.microsoft.com/dynamics365/customerengagement/on-premises/basics/save-advanced-find-search) to search entities related to your surveys, you will need to search for Customer Voice, not Forms Pro.
> 
> The entities associated with Customer Voice surveys are listed below:
>
> - Customer Voice localized survey email templates
> - Customer Voice projects
> - Customer Voice satisfaction metrics
> - Customer Voice survey questions
> - Customer Voice survey activities
> - Customer Voice email templates
> - Customer Voice survey invites
> - Customer Voice survey question responses
> - Customer Voice survey responses
> - Customer Voice surveys
> - Customer Voice unsubscribed recipients

### See also

[Create marketing forms](marketing-forms.md)