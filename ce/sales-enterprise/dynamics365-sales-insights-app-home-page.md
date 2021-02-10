---
title: View overall insights of your sales and sellers in conversation intelligence | MicrosoftDocs"
description: "View high-level information on sales and sellers with AI-driven insights readily available for conversation intelligence "
keywords: ""
ms.date: 06/18/2020
ms.service: crm-online
ms.custom: 
ms.topic: article
ms.assetid: 9affa7f1-5fed-4ca1-9bb5-5090aaab359e
author: udaykirang
ms.author: udag
manager: shujoshi
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 01
topic-status: Drafting
---

# View and understand home page

When you sign in to conversation intelligence as a sales manager, you’ll see the home page. This page provides high-level information on the status of your current sales period and insights on what your customers are talking about, behaviors of your top sellers, and the team’s sales pipeline for the selected time period.

Typically, the home page is divided into the following sections:

-	[Time period filter](#time-period-filter)

-	[Base KPIs](#base-kpis)

-	[What are customers talking about?](#what-are-customers-talking-about)

-	[What characterizes top sellers?](#what-characterizes-top-sellers)

-	[Call recording KPIs](#call-recording-kpis)

## Time period filter

You can filter the information on the home page based on a time period, such as last 24 hours, last 7 days, this month, all time, or a custom time period. For example, to view the information of the current month, select **This month**, and the information is filtered to display the current month's status in the **Base KPIs**, **What are customers talking about?**, **What characterizes top sellers?**, and **Are my team’s deals on track?** sections.

> [!div class="mx-imgBorder"]
> ![Time period filter](media/si-app-time-period.png "Time period filter")

> [!NOTE]
> By default, the information displayed is from the day the application is configured for your organization.

## Base KPIs

The base KPIs provide information on the status of your current sales period. By viewing these KPIs, you’ll know:

-	The time left in the current period to achieve your sales target.

-	The sum of actual revenue of all won opportunities.

-	The total estimated revenues of all open opportunities.

-	The total deals that you won in this period.

-	The percentage of deals that you won against available opportunities in this period.

-	The average revenue generated through each deal in this period.

The following image is an example of how the base KPIs are displayed:

> [!div class="mx-imgBorder"]
> ![Base KPIs](media/si-app-base-kpis.png "Base KPIs")

## What are customers talking about?

The **What are customers talking about** section helps you to understand what’s happening in sales calls and what customers are talking about. These insights can provide you with possible ideas for coaching scenarios for your sales team, helping them improve their performance during the sales calls. 

This also helps in driving strategic motion by looking at the keywords, brands, and competitors mentioned during the call. For example, "3D printer" is trending more during customer calls, but the 3D printer sales are not reaching targets. You can coach the sales team on how to sell the 3D printers more effectively to customers.

The following insights are available for you to understand what customers are talking about:

-	[Customer sentiment](#customer-sentiment)

-	[Tracked keywords](#tracked-keywords)

-	[Tracked competitors](#tracked-competitors)

-	[Other brands and organizations](#other-brands-and-organizations)

### Customer sentiment

This insight shows the number of calls where the negative customer sentiments are more than average. Using this insight, you can analyze:

- Pain points that customers express during the call and coach your sellers on how to handle customer conversations well. 
- Why customers are expressing these pain points and identify selling opportunities by addressing the gaps that are causing pain points. 

The following image is an example of how the "customer sentiment" insight is displayed:

> [!div class="mx-imgBorder"]
> ![Customer sentiment](media/si-app-customer-sentiment.png "Customer sentiment")

In this example, you can see that 200 calls are analyzed and 27% of calls have higher than the average negative customer sentiment. The doughnut chart shows the percentage of calls that are positive, neutral, and negative.

Select **Show details** to view more details on how the customer sentiment is trending over time and the list of calls that contributed to this analysis. Further, you can select each call and view the summary. To learn more about call summary, see [View and understand call summary](view-and-understand-call-summary.md).  

> [!div class="mx-imgBorder"]
> ![Customer sentiment more details page](media/si-app-customer-sentiment-details.png "Customer sentiment more details page")

### Tracked keywords

This insight shows the tracked keywords that are defined in the application and that customers use the most during the sales calls. Conversation intelligence highlights these tracked keywords in this insight. Using these tracked keywords, you can identify new sales opportunities that are related to them. 

The following image is an example of how the "tracked keywords" insight is displayed:

> [!div class="mx-imgBorder"]
> ![Most tracked keywords](media/si-app-tracked-keywords.png "Most tracked keywords")

In this example, you can see that STL (+32%), Jewelers (+26%), and Fabrication (+23%) are the keywords that are trending the highest, so you could, theoretically, define a sales strategy related to these keywords. The bubbles show the top 20 tracked keywords and the number of times that these keywords were mentioned in calls. 

You can define what keywords you want to track during the sales call. To learn more, see [Configure keywords and competitors to track](configure-keywords-competitors.md).

Select **Show details** to view more details on top trending keywords. The details include how many times each keyword is mentioned in the total number of calls, trend of each keyword over time, and the list of calls that are contributing to the keyword analysis. Further, you can select each call and view the summary. To learn more about call summary, see [View and understand call summary](view-and-understand-call-summary.md).

> [!div class="mx-imgBorder"]
> ![Most tracked keywords more details page](media/si-app-tracked-keywords-details.png "Most tracked keywords more details page")

### Tracked competitors

This insight shows the defined competitors' names that customers use most and are trending upwards during the sales calls. Conversation intelligence highlights these competitors in this section. Using these competitors, you can identify new sales opportunities that are related to them.

The following image is an example of how the "competitors mentioned" insight is displayed:

> [!div class="mx-imgBorder"]
> ![Competitors mentioned](media/si-app-competitors-mentioned.png "Competitors mentioned")

In this example, you can see that Contoso 360 (+31%), Relecloud (+26%), and Protosystem (+22%) are the most trending competitors, and you can define a sales strategy related to these competitors. The bubbles show the top 20 competitors and the number of times that these competitors were mentioned in the calls. 

You can define which competitors you want to track during the sales call. To learn more, see [Configure keywords and competitors to track](configure-keywords-competitors.md).

Select **Show details** to view more details on top trending competitors. The details include how many times each competitor is mentioned in the total number of calls, trend of each competitor over time, and the list of calls that are contributing in analyzing the competitors. Further, you can select each call and view the summary. To learn more about call summary, see [View and understand call summary](view-and-understand-call-summary.md).

> [!div class="mx-imgBorder"]
> ![Competitors mentioned more details page](media/si-app-competitors-mentioned-details.png "Competitors mentioned more details page")


### Other brands and organizations

This insight helps to discover new products, brands, and organizations that customers are speaking about in sales calls, which they never spoke of in previous calls. These products, brands, and organizations are not defined in the application (tracked keywords and competitors), and the application uses Microsoft Bing's knowledge repository to identify the products, brands, and organizations to display. Using this insight, you can identify whether any competitor brands and organizations are mentioned on the sales calls and update your sales strategies accordingly.

The following image is an example of how the "brands and organizations detected" insight is displayed:

> [!div class="mx-imgBorder"]
> ![New brands detected](media/si-app-brands-detected.png "New brands detected")

In this example, you can see that three brands and organizations (Da Vinci 3D, MakerHouse, and Northwind 3D) are trending most in the sales calls. You can update the sales strategies to coach your sales teams to minimize the mention of these brands in the calls. The bubbles show the 20 brands that are used most and the number of times that these brands and organizations were mentioned in the calls. 

Select **Show details** to view more details on top brands and organizations. The details include how many times each brand and organization is mentioned in the total number of calls, trend of each brand and organization over time, and the list of calls that are contributing in analyzing the brands and organizations. Further, you can select each call and view the summary. To learn more about call summary, see [View and understand call summary](view-and-understand-call-summary.md).

> [!div class="mx-imgBorder"]
> ![New brands detected more details page](media/si-app-brands-detected-details.png "New brands detected more details page")

## What characterizes top sellers?

The **What characterizes top sellers** section helps you understand the conversational behavior of your top sellers. The insights are generated based on the revenue that the top sellers generate. For example, Bart and John are sellers, and they generate more than average revenue on your team. The insights in this section are generated based on the conversational behavior of Bart and John.

By analyzing these insights, you can understand what makes the top sellers most effective in generating revenue, and you can apply this knowledge to coach other sellers on how to generate revenue more effectively. 

The following insights are available for you to understand what characterizes top sellers:

-	[Average talk to listen ratio](#average-talk-to-listen-ratio)

-	[Best practice keywords](#best-practice-keywords)

-	[Customer sentiment](#customer-sentiment)

-	[Switch rate](#switch-rate)

-	[Engagement with customers](#engagement-with-customers)

### Average talk-to-listen ratio

This insight shows the average time top sellers spend talking instead of listening to customers compared to the rest of the sales team. By analyzing this insight, you can understand what works for top sellers to close deals and generate revenue.

The following image is an example of how the "talk-to-listen ratio" insight is displayed:

> [!div class="mx-imgBorder"]
> ![Comparison of talk-to-listen ratio](media/si-app-talk-to-listen-ratio.png "Comparison of talk-to-listen ratio")

In this example, you can observe that the top sellers talk (59%) more than listen (41%) to customers compared to the team’s average of talk (61%) to listen (39%). Through this insight, you can learn that talking more is helping the top seller generate revenue, and you can make it as a best practice for other sellers to follow.

Select **Show details** and the [Teams overview](../sales/conversation-intelligence-team-overview.md) page opens with details on each seller's talk-to-listen ratio with customers.

### Best practice keywords

This insight shows the keywords that the top sellers use more frequently in conversations with customers. By analyzing this insight, you can understand what words the top sellers use that help them to close deals and generate revenue.

The following image is an example of how the "what are they talking about" insight is displayed:

> [!div class="mx-imgBorder"]
> ![Keywords top sellers are talking about](media/si-app-what-they-are-talking-about.png "Keywords top sellers are talking about")

In this example, you can see that **Discount**, **VIP**, and **Fabrication** are the top words mentioned by your top sellers. The bubbles show the top 20 keywords that are trending and the number of times that these keywords were mentioned in the calls. 

Select **Show details** to view more details on top best practice keywords. The details include how many times each best practice keyword is mentioned in the total number of calls, trend of each best practice keyword over time, and the list of calls that are contributing in analyzing the keywords. Further, you can select each call and view the summary. To learn more about call summary, see [View and understand call summary](view-and-understand-call-summary.md).

> [!div class="mx-imgBorder"]
> ![Keywords that top sellers are talking about more details page](media/si-app-what-they-are-talking-about-details.png "Keywords that top sellers are talking about more details page")

### Customer sentiment

This insight shows how top sellers are doing when compared to the team in terms of positive, neutral, and negative customer sentiments during sales calls. Using this insight, you can analyze what makes the top sellers more efficient in addressing the customer's pain points during the call and how you can coach your other sellers to increase their sentient levels.

The following image is an example of how the "customer sentiment" insight is displayed:

> [!div class="mx-imgBorder"]
> ![Comparison of customer sentiment](media/si-app-customer-sentiment-top-sellers.png "Comparison of customer sentiment")

In this example, you can see that top sellers (28%) are driving more negative customer sentiment compared to that of your team (26%). This indicates that top sellers may be asking more questions to identify the customer's pain points in order to resolve them to key out selling opportunities.

Select **Show details** and the [Teams overview](../sales/conversation-intelligence-team-overview.md) page opens with details on customer sentiment.

### Switch rate

This insight shows the rate of which top sellers are talking and listening in conversations with customers, and this indicates a sign of engagement during conversations. Using this insight, you can understand the switch rate of top sellers per hour and identify coaching opportunities for other sellers to improve on switch rate.

The following image is an example of how the "switch rate" insight is displayed:

> [!div class="mx-imgBorder"]
> ![Switch rate of talk to listen](media/si-app-switch-rate.png "Switch rate of talk to listen")

In this example, you can see that top sellers (33 per hour) are switching less during the conversation with customers than the team average (34 per hour). Through this, you can identify coaching opportunities for the other sellers to improve on switch rates during customer conversations.

Select **Show details** and the [Teams overview](../sales/conversation-intelligence-team-overview.md) page opens with details on each seller's switch rates with customers compared to the team's average.

### Engagement with customers

This insight helps you understand what type of communication mode top sellers spend their time in engaging with customers. Using this insight, you can identify coaching opportunities for other sellers on communication mode for engaging with customers.

The following image is an example of how the "engagement with customers" insight is displayed:

> [!div class="mx-imgBorder"]
> ![Top sellers communication mode](media/si-app-engagement-with-customer.png "Top sellers communication mode")

In this example, you can see that top sellers are spending more time on meetings (6 hours) than on phone calls (1 hours) and on emails (23 hours) while engaging with customers. By analyzing this, top sellers are engaging customers through meetings and phone calls, so you can plan to coach around these communication modes for other sellers to improve.

## Call recording KPIs

The call recording KPIs provide an understanding of how calls are trending month over month. By viewing these KPIs, you’ll know the total number of:

-	Calls that are recorded and how they are trending.

-	Recorded hours and how they are trending.

-	Calls with defined trackers mentioned and how they are trending.

-	Calls with defined brands mentioned and how they are trending.

The following image is an example of how the call recording KPIs are displayed.

> [!div class="mx-imgBorder"]
> ![Call recording KPIs](media/si-app-call-recording-kpis.png "Call recording KPIs")

### See also

[Administer conversation intelligence](intro-admin-guide-sales-insights.md#administer-conversation-intelligence)

[Improve seller coaching and sales potential with conversation intelligence](dynamics365-sales-insights-app.md) 
