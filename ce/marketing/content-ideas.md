---
title: "Preview: Use AI to kickstart email creation with content ideas (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to use AI-powered content ideas to generate content in Dynamics 365 Marketing."
ms.date: 02/24/2023
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

# Preview: Use AI to kickstart email creation with content ideas

> [!IMPORTANT]
> A preview feature is a feature that is not complete, but is made available before it’s officially in a release so customers can get early access and provide feedback. Preview features aren’t meant for production use and may have limited or restricted functionality.
> 
> Microsoft doesn't provide support for this preview feature. Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions. Preview features aren’t meant for production use, especially to process personal data or other data that are subject to legal or regulatory compliance requirements.

> [!NOTE]
> The content ideas preview is currently only available in North America.

> [!Tip]
> Learn about using content ideas to create inspiring emails in our latest blog: [Make email creation fun and more efficient with AI-powered content ideas in Dynamics 365 Marketing](https://cloudblogs.microsoft.com/dynamics365/it/2022/11/30/engage-your-customers-faster-with-ai-powered-marketing-email-content/).

Content ideas helps you discover new ways to express your thoughts, helping you move from email concept to completion faster. This article explains how content ideas works and how you can start using it to kickstart your emails.

> [!VIDEO https://www.microsoft.com/videoplayer/embed/RWZDEE]

## What is content ideas?

The content ideas feature is like a brainstorming partner that can help inspire you while you’re writing an email. You provide a short list of initial thoughts (key points), and content ideas generates a range of longer content suggestions that you can build on. You can add these suggestions to your draft, use them as inspiration to write a new draft, or go in a different direction altogether.

## Enable content ideas

> [!NOTE]
> The content ideas feature is enabled by default and is visible in the email editor toolbox (in English environments only).

### Turn on or off the content ideas feature switch

1. Go to **Settings** > **Overview** > **Feature switches**.
1. Enable/disable the **Content ideas (preview)** feature switch toggle.

## How to use content ideas

1. Select the **Content ideas** button in the email editor toolbox to open the content ideas pane.
1. Add up to five key points that you want to get across in your email (a minimum of three words per key point is recommended).
You can also use pre-made examples (select the **See examples** link and then **Use this example** for a selected set of key points).
1. Select **Get ideas**.
1. Content ideas generates a set of text suggestions. It might take a short while to generate content (up to 15 seconds, depending on the usage).
1. Browse the generated ideas using the scrollbar in the content ideas pane.
1. Select **Get more ideas** to generate more ideas for the same key points.
    > [!NOTE]
    > Your feedback really matters! Please provide quick feedback if you find the generated ideas useful. You can do it by selecting the **Yes** or **No** link at the bottom of each idea. Your input helps improve the content ideas functionality.
1. If you like a content idea, select **Add to my draft** to copy the content into your email. You can also drag a generated idea and drop it directly onto the email canvas.
1. Once the content idea is added to your draft, make sure to review it and edit it according to your needs before sending the message.
    > [!NOTE]
    >  Content ideas are just suggestions. It is your responsibility to edit generated suggestions so that your final copy is accurate and appropriate.

## Generate ideas using your organization's emails

You can provide personalized context to the content ideas feature. Content ideas will analyze your organization’s ready-to-send/live marketing existing emails (minimum 20) in addition to a wide range of internet sources to increase the relevancy of generated ideas. The analysis is a one-time process that can take up to a few hours.

To begin the content ideas analysis:

1. Select the **Content ideas** button in the email editor toolbox to display the content ideas pane.
1. If there are enough ready-to-send/live marketing emails in your organization to start the analysis process (minimum 20) and you have read permission to access all the emails, select the **Enable** button.
1. You'll see a popup window stating that it's ready to analyze your emails. This is a one-time process that can take up to a few hours. Select **Enable** to proceed.
    > [!NOTE]
    > You will only be able to start the analysis process if you have read permission access to all the emails in your organization.
1. After the analysis of existing emails is complete, you'll be able to generate ideas using your organization’s emails.

    To generate ideas, add up to five key points that you want to get across in your email in the content ideas pane. Select the **Generate ideas using your organization’s emails** checkbox, then select the **Get ideas** button.

## How does the content ideas technology work?

Content ideas is built on a machine learning model called GPT-3. Trained on a vast number of text samples from the internet, GPT-3 generates new text in English that looks and sounds similar to text that was written by a human. Content ideas uses GPT-3 as a foundation, then considers your organization’s recent (English) ready-to-send emails and the key messaging points that you share for each new email draft. Content ideas masks any personal data in generated ideas and shows only the results that are long enough and unique enough to be useful.

## What data does content ideas collect?

If you grant permission, content ideas will automatically review your organization’s recent (English) ready-to-send emails without any human review. The only time a human reviews the content of generated ideas is if you report it to Microsoft (using a quick feedback survey built into the content ideas feature).

## What if I'm not satisfied with the generated content?

Content ideas uses the key points you add to generate suggestions for your email. Make sure to provide good key points that touch on the top themes you want to get across to your audience. Include two to five key points. Use a group of words or a full sentence for each key point.
 
If you aren't satisfied with the generated ideas, try one or more of the following:

1. Continue browsing through generated ideas to make sure you’ve reviewed all of them.
1. Get more ideas based on the already provided key points.
1. Rephrase or add more key points to get new ideas.

Content ideas generates original content, but it isn’t always factual. In addition, because the underlying technology behind content ideas uses AI that has been trained on a wide range of internet sources, some text suggestions may include questionable or inappropriate content. It's your responsibility to edit generated suggestions so that your final copy is accurate and appropriate.

> [!IMPORTANT]
> If you encounter inappropriate content being generated, report it to Microsoft using this feedback form: [Report abuse](https://msrc.microsoft.com/report/abuse?ThreatType=URL&IncidentType=Responsible%20AI&SourceUrl=https://dynamics.microsoft.com/marketing/overview/). It will help improve the functionality moving forward.
>
> Microsoft may disable the content ideas feature for selected customers if abuse of the functionality is detected.

[!INCLUDE[footer-include](../includes/footer-banner.md)]