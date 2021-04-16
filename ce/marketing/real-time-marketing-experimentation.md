---
title: "Experiment and refine real-time marketing journeys (Dynamics 365 Marketing) | Microsoft Docs"
description: "Experiment and refine real-time marketing journeys in Dynamics 365 Marketing."
ms.date: 04/01/2021
ms.service: dynamics-365-marketing
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

# Experiment and refine real-time marketing journeys

> [!IMPORTANT]
> A preview feature is a feature that is not complete, but is made available before it’s officially in a release so customers can get early access and provide feedback. Preview features aren’t meant for production use and may have limited or restricted functionality.
> 
> Microsoft doesn't provide support for this preview feature. Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions. Preview features aren’t meant for production use, especially to process personal data or other data that is subject to legal or regulatory compliance requirements.

Dynamics 365 Marketing real-time marketing uses powerful AI to test your event based customer journeys, allowing you to gain insights into how best to reach your customers.

A/B tests allow you measure which channel or content messaging strategy leads to higher success. Each test compares a control group of users (version A) against a variant (version B). The control group will receive a default experience, and the variant group will receive a different experience or message, so you can determine which is the most effective. 

The journey will usually run the entire test automatically. It starts by sending version A and B to a small part of your audience as they funnel through the journey and then analyze the interaction results and choose a winner based on your selected criteria (click through, open rate or journey goal). The journey then sends the winning version to the rest of your audience automatically. 

## Creating and adding an A/B test:

1. Create your initial content as usual as described in email editor. Perfect the content as much as possible and be sure to check it for errors to make sure it can go live.
1. When your content is ready, go to your list of journeys and do the following:
    - Pick the “Add an A/B test” element in the dialog. 
    - Choose which channel you wish to test in version A and version B and click “Create test” 

    [INSTER IMAGE HERE]

1. Once the side pane is open, do the following:
    - Enter a name for your test to identify your test. This name is displayed in the A/B test panel and in the customer journey analytics when you are looking at which tests are running. Once the journey is live, you may not rename your test.  
    - Pick the content for your channel you prepared in step 1. You can do this through a drop down by either clicking on the child tiles in the journey builder or on the side panel 
1. Pick the audience distribution you would like. The slider is automatically on 50-50 but you can set the slider to your desired distribution. The minimum a version can receive is 10% and the maximum is 90%. Remember that traditionally, version A is your control group and version B is your variant.

[INSERT IMAGE HERE]

## Preparing to execute your test:  

1. Winning metric: You can determine what the winning condition will be for your test by picking a wining metric; the version with the most journey goal event hit, most clicks or most opens.  

1. Test duration: You can also choose between ending the test automatically or by a specific date and time. For best results, it’s recommended to let the test determine a winner automatically when the results reach statistical significance. Once a clear winner is determined, the system will send the winning version to the rest of your audience and the losing version is discarded.  

1. Default version : Lastly, choose a default version should the test not end successfully. In cases where a winner has not been determined by the deadline specified through date/time, then the default version is automatically sent.  

1. Finish setting up your journey as usual and then go live.

> [!NOTE]
> You can add up to 5 tests per journey by repeating the steps above. You can test similar channels (email A vs email B) or test different channels (Email vs Text message).

## Monitor the lifecycle of your A/B tests 

- **Draft**: These tests have not ran yet, so you can still edit the settings. 
- **In progress**: These tests are currently being run. The settings are locked and you can’t make big changes.  
- **Stopped**: Theses tests are on pause and can be resumed by the marketer. 
- **Ended**: These are tests are completed by finding a winner via statistical significance or timed out when scheduled to end through a date and time.  They cannot be reused. 

## Understand your results

There are three possible A/B test result outcomes:

1. **Test concluded with a clear winner**: The test concluded that one version is performing significantly better than the other. The winning version has a “winner” badge and is distributed to any new customers that funnel through the journey.
1. **Test was not conclusive**: The test concluded that recipients are as likely to engage with version A as they would engage with version B. In this case, the default version is sent to any new customers that funnel through the journey.
1. **The test was stopped**: This means that you or one of your coworkers stopped the test before it could conclude. In this case, the version specified by you or your coworker is sent to any new customers that funnel through the journey.
