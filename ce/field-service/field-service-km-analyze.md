---
title: Review knowledge article analytics
description: Learn how to manage new versions of knowledge articles in Dynamics 365 Field Service. 
author: jshotts
ms.author: jasonshotts
ms.topic: how-to
ms.date: 10/15/2024
ms.custom: bap-template
---

# Review knowledge article analytics

Tracking knowledge article analytics helps you assess the value your articles provide to your customers. Knowing and understanding when, where, and how many times an article was viewed, tells you how much your customers rely on the information that it contains. This data is extremely useful when creating future content curation plans and can help you decide what content you will deliver in the future, as well as how you deliver it, where you deploy it, and what style or structure you use to write it.

1. In Field Service, go to **Settings** > **Knowledge management** > **Knowledge articles**.  
1. Open the article you want to analyze.
1. Select the **Analytics** tab.
   :::image type="content" source="media/knowledge-article-analyze.png" alt-text="Screenshot of a Field Service knowledge article, showing the Publish pane.":::
1. Review the statistics about the article.

   - **Views**: Shows you the total number of times the article has been viewed. The **View by day and location** section shows the article views on a particular day.

    To maintain uniformity among users who see the article views across different time zones, the views are calculated based on the Coordinated Universal Time (UTC) time zone, aggregated, and then displayed according to the user's local time zone. So, if you are in the UTC-3 time zone, you’ll see the time and consequently the day as UTC-3. For example, 23rd Jun, 12:00 AM UTC time translates to 22nd Jun, 9:00 PM Brazil (UTC-3) time.

    The total number of views remains constant. You can sort by **Day**, **Knowledge Article Views**, or **Location**.

   - **Feedback**: Captures all the feedback and ratings on the knowledge articles.  

     The **Rating** field calculates the average rating of the article based on the amount of feedback and number of ratings received.

    > [!NOTE]
    > Rating and view count numbers are rollup fields that are not updated instantly.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
