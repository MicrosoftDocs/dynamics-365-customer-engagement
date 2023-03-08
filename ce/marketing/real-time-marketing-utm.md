---
title: "Preview: Measure marketing effectiveness using UTM codes (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to add Urchin Tracking Module (UTM) codes to URLs for improved link tracking in real-time marketing."
ms.date: 02/21/2023
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Preview: Measure marketing effectiveness using UTM codes

> [!IMPORTANT]
> A preview feature is a feature that is not complete, but is made available before it’s officially in a release so customers can get early access and provide feedback. Preview features aren’t meant for production use and may have limited or restricted functionality.
> 
> Microsoft doesn't provide support for this preview feature. Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions. Preview features aren’t meant for production use, especially to process personal data or other data that are subject to legal or regulatory compliance requirements.

UTM (Urchin Tracking Module) codes are an essential tool for marketers as they allow them to track the effectiveness of their digital marketing. By adding UTM parameters to URLs, marketers can track the specific source, medium, and journey name that generated website visitors. Using UTM codes makes it easier to understand which journeys are driving the most traffic and conversions. The traffic and conversion information can then be used to optimize marketing strategies and allocate budget more effectively.

UTM codes also provide valuable insights into customer behavior. UTM codes can help identify which channels are most effective in generating traffic for your websites and landing pages, which enables you to attribute conversions to the right source.

## Enable UTM codes

To use UTM codes, an administrator needs to enable the UTM codes feature switch. To enable the switch:

1. Go to **Settings** > **Overview** > **Feature switches**.
1. Enable the **UTM tracking** feature switch toggle, then select **Save** in the upper right.

When enable UTM tracking, you'll see the default values for each UTM parameter. These are the values that will be added to all URLs that you add to your emails or text messages.

> [!div class="mx-imgBorder"]
> ![Enable UTM codes screen.](media/real-time-marketing-utm-enable.png "Enable UTM codes screen")

> [!NOTE]
> It may take up to five minutes after enabling the feature switch toggle before the UTM settings are propagated across the channels.

## Use UTM codes in a journey

Imagine an abandoned cart scenario in which website visitors add items to their carts but leave your website without completing their purchases. By using UTM codes in your retargetting journey, you can reach out to the abandoned cart visitors and track the campaign (journey name), medium (channel), and content that results in customers returning to complete their purchases.

### Here’s how you would use UTM codes in an abandoned cart journey

First, create a journey that [targets visitors that abandoned their cart](real-time-marketing-trigger-based-journey.md). After the journey trigger, you'll add a reminder email that nudges visitors to complete the purchases. Because completing the purchase is the purpose of the journey, you can also [set a goal](real-time-marketing-business-goals.md) that measures success whenever a visitor completes a purchase.

> [!div class="mx-imgBorder"]
> ![Create an abandoned cart journey.](media/real-time-marketing-utm-abandoned.png "Create an abandoned cart journey")

To use UTM codes in the reminder email, go to **Emails** and select the email you plan to use in your abandoned cart journey. Add a URL to the email that directs your customers back to your website. In the **Add a link** window, you'll see the default values that will automatically be appended to every URL in your message, including unsubscribe.

> [!div class="mx-imgBorder"]
> ![UTM parameters and values.](media/real-time-marketing-utm-values.png "UTM parameters and values")

In this case, the source value Dynamics 365 Marketing, the campaign value is the name of the abandoned cart journey, the medium is channel that you're using which is email, and the content is the name of the email.

Once your journey is live and customers start using your links, you'll be able to review insights including how many people clicked your link and how many successfully completed a purchase.

> [!div class="mx-imgBorder"]
> ![Journey goal success.](media/real-time-marketing-utm-goal.png "Journey goal success")

You can also use Google Analytics to determine how successful the email you sent was in driving traffic to your website.

> [!div class="mx-imgBorder"]
> ![View results in Google Analytics.](media/real-time-marketing-utm-google.png "View results in Google Analytics")

## Learn more

Here are some advanced resources for this topic:

- [Extracting Marketing Interactions in Dynamics 365 Marketing](https://community.dynamics.com/365/dynamics-365-fasttrack/b/dynamics-365-fasttrack-blog/posts/extracting-marketing-interactions-in-dynamics-365-marketing)