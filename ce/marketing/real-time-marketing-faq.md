---
title: "Troubleshoot real-time marketing (Dynamics 365 Marketing) | Microsoft Docs"
description: "Troubleshooting and frequently asked questions for real-time marketing in Dynamics 365 Marketing."
ms.date: 04/30/2021
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

# Troubleshoot real-time marketing

> [!IMPORTANT]
> A preview feature is a feature that is not complete, but is made available before it’s officially in a release so customers can get early access and provide feedback. Preview features aren’t meant for production use and may have limited or restricted functionality.
> 
> Microsoft doesn't provide support for this preview feature. Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions. Preview features aren’t meant for production use, especially to process personal data or other data that are subject to legal or regulatory compliance requirements.

### Channel A/B Testing
- How come the audience split is not exactly the same as when I was authoring the a/b test?
- If your audience is set up to be 50-50 across your audience, we will do our best to respect this distribution but the split will not always be exact. We do this to improve the performance of the a/b test and the overall results of determining a winner variant are not affected.
- I see that the inflow before the a/b test is 85 but the splt accross version A and B are 63 and 16 accordingly, what happened to the rest of the audience?
- Some viewers may not have the right consent permissions to recieve the message through the channel indicated in the a/b test. Other problems aside from consent permissions include system failures. 

## Chanel optimization
- How is channel optimization related to goal? 
- Setting a journey goal is a pre-requisite for using channel optimization; the goal metric used to define your journey's success is what the AI model will use to optimize in channel optimization. It is important to use an accurate goal metric so that you can attain the best results with channel optimization. 
- How does the channel optimization leverage AI to determine the best channel?
- When enabled, channel optimization uses each customer’s individual interaction data (e.g unique clicks, opens, etc.) and the journey goal to calculate the likely best channel for that customer to interact with. The AI model only collects historical data like email opens, clicks, and unsubscribes to determine the level of that person’s engagement with a specific channel. The model will not collect transactional or any other data from your customers.
- What does the default channel do?
- The default channel acts as a 'control group' where 10% of your audience will be funnel through the default channel without having any AI applied. This will help you compare the performance of the audience who go through the control group versus the audience that has been recommended with AI applied in the analytics. This comparison is based off of which group achieved the journey goal. 
- How are the engagement rate determined in channel optimization?
- Push notification: Number of unique people that open or clicked a link divided by total number of push notifications sent
- email: Number of unique people that open or clicked a link divided by total number of emails sent
- sms: Number of unique people that clicked a link divided by total number of sms sent
