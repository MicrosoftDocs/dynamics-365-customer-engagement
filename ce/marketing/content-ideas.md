---
title: "Preview: Use AI to kickstart email creation with Content ideas (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to use AI-powered Content ideas to generate content in Dynamics 365 Marketing."
ms.date: 10/13/2021
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

# Preview: Use AI to kickstart email creation with Content ideas

> [!IMPORTANT]
> A preview feature is a feature that is not complete, but is made available before it’s officially in a release so customers can get early access and provide feedback. Preview features aren’t meant for production use and may have limited or restricted functionality.
> 
> Microsoft doesn't provide support for this preview feature. Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions. Preview features aren’t meant for production use, especially to process personal data or other data that are subject to legal or regulatory compliance requirements.

> [!NOTE]
> The Content ideas preview is currently only available in the North American marketing and is limited to the outbound marketing email editor.

Content ideas helps you discover new ways to express your thoughts, helping you move from email concept to completion faster. This article explains how Content ideas works and how you can start using it to kickstart your emails.

## What is Content ideas?

The Content ideas feature is like a brainstorming partner that can help inspire you while you’re writing an email. You provide a short list of initial thoughts (key points), and content ideas generates a range of longer content suggestions that you can build on. You can add these suggestions to your draft, use them as inspiration to write a new draft, or go in a different direction altogether.

## Enable Content ideas

> [!NOTE]
> The Content ideas button is visible in the email editor (in English environments only) even if it hasn’t been enabled by and administrator.

### Turn on the Content ideas feature switch

1. Go to **Settings** > **Feature switches**.
1. Enable the **Content ideas** feature switch toggle.
1. Agree to analyze your organization's recent ready-to-send emails by selecting the **I agree** button.

### Provide context to the Content ideas feature

Content ideas analyzes the last ready-to-send marketing emails in your organization (minimum 20) to increase the relevancy of generated ideas. The analysis is a one-time process that can take up to a few hours.

To begin the Content ideas analysis:

1. Go to the outbound marketing email editor. Select the **Content ideas** button is the top-right corner to display the Content ideas pane.
1. If there are enough emails in your organization to start the analysis process (minimum 20) and you have read permission to access all the emails, you will see a message in the Content ideas pane stating that it is ready to analyze your emails. Select **Continue** to proceed.
    > [!NOTE]
    > You will only be able to start the analysis process if you have read permission access to all the emails in your organization.
1. After the analysis of existing emails is complete, the Content ideas feature will be enabled in the email editor.

## How to use Content ideas

1. Select the **Content ideas** button in the outbound marketing email editor to open the Content ideas pane.
1. Add up to five key points (two minimum) that you want to get across in your email.
1. Select **Get ideas**.
1. Content ideas generates a set of text suggestions. It might take a short while to generate content (up to 15 seconds, depending on the usage).
1. Browse the generated ideas using the left and right arrows at the top of the Content ideas pane.
    > [!NOTE]
    > Your feedback really matters! Please provide quick feedback if you find the generated ideas useful. You can do it by selecting the **Yes** or **No** link at the bottom of each idea. Your input helps improve the Content ideas functionality.
1. If you like a content idea, select **Add to my draft** to copy the content into your email. You can also drag a generated idea and drop it directly onto the email canvas.
1. Once the content idea is added to your draft, make sure to review it and edit it according to your needs before sending the message.
    > [!NOTE]
    >  Content ideas are just suggestions. It is your responsibility to edit generated suggestions so that your final copy is accurate and appropriate.

## How does the Content ideas technology work?

Content ideas is built on a machine learning model called GPT-3. Trained on a vast number of text samples from the internet, GPT-3 generates new text in English that looks and sounds similar to text that was written by a human. Content ideas uses GPT-3 as a foundation, then considers your organization’s recent (English) ready-to-send emails and the key messaging points that you share for each new email draft. Content ideas masks any personal data in generated ideas and shows only the results that are long enough and unique enough to be useful.

## What data does Content ideas collect?

If you grant permission, Content ideas will automatically review your organization’s recent (English) ready-to-send emails without any human review. The only time a human reviews the content of generated ideas is if you report it to Microsoft (using a quick feedback survey built into the Content ideas feature).

## What if I'm not satisfied with the generated content?

Content ideas uses the key points you add to generate suggestions for your email. Make sure to provide good key points that touch on the top themes you want to get across to your audience. Include two to five key points. Use a group of words or a full sentence for each key point.
 
If you are not satisfied with the generated ideas, try one or more of the following:

1. Continue browsing through generated ideas to make sure you’ve reviewed all of them.
1. Get more ideas based on the already provided key points.
1. Rephrase or add more key points to get new ideas.

Content ideas generates original content, but it isn’t always factual. In addition, because the underlying technology behind content ideas uses AI that has been trained on a wide range of internet sources, some text suggestions may include questionable or inappropriate content. It's your responsibility to edit generated suggestions so that your final copy is accurate and appropriate.

> [!IMPORTANT]
> If you encounter inappropriate content being generated, report it to Microsoft using this feedback form: [Report abuse](https://msrc.microsoft.com/report/abuse?ThreatType=URL&IncidentType=Responsible%20AI&SourceUrl=https://dynamics.microsoft.com/en-us/marketing/overview/). It will help improve the functionality moving forward.
>
> Microsoft may disable the Content ideas feature for selected customers if abuse of the functionality is detected.
