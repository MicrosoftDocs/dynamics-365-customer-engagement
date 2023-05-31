---
title: "Target the right customers using the query assist copilot (Dynamics 365 Marketing) | Microsoft Docs"
description: "Target the right customers using the query assist copilot in the real-time marketing area of Dynamics 365 Marketing."
ms.date: 05/31/2023
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

# Target the right customers using the query assist copilot

> [!VIDEO https://www.microsoft.com/videoplayer/embed/RE5csiL]

Segment creation traditionally required extensive knowledge of the complex data structures defined by your business. To simplify creating segments in real-time marketing, you can use query assist copilot to describe the segment definition in simple English. Query assist copilot lets you add the results query onto the segment builder at any level of the query logic, either as a new group or as an additional condition in your existing logic. You can even improve the copilot by giving feedback, helping you achieve more detailed results in the future.

Let’s imagine you want to create a segment that targets people who have attended one of your past events. To create a segment using query assist copilot, select the **Segments** tab under the **Audience**. Enter the segment name and select the target audience (Contact or Lead) and enter a description for your segment. Copilot understands different syntaxes – from conversational language to formal. In this example, we're using “People who attended the Contoso Coffee tasting event and recently opened an email”. Then select **Create**.

> [!div class="mx-imgBorder"]
> ![create a new segment using copilot](media/real-time-marketing-create-a-new-segment-using-copilot.png "create a new segment using copilot")

On the right side of the next screen, you'll see a **Query Assist** panel. The Query assist copilot uses the description you entered when creating your segment to suggest a data structure for the segment. If the suggested segment information is accurate, you can select the button to apply the suggested result to your new segment.

> [!div class="mx-imgBorder"]
> ![Query assist helps in building the responses](media/real-time-marketing-add-a-suggested-result-using-query-assist.png "Query assist helps in building the responses")

Once you select **Use**, notice the copilot built the relationship for you in the canvas. 

> [!div class="mx-imgBorder"]
> ![provide additional details](media/real-time-marketing-provide-additional-details-using-query-assist.png "provide additional details")

You can provide feedback on the segment query by selecting the thumbs up or thumbs down button next to the result in the **Query Assist** pane.

You can add further details to your segment by entering additional searches into the query assist pane. If you select **See more examples**, you can find more suggestions to help you get started. 

If you select a new search, you'll notice that by clicking the Use button it will always add the result as a new group at the bottom of what is already on the canvas. 

> [!div class="mx-imgBorder"]
> ![Fill in the attributes in the canvas built by copilot](media/real-time-marketing-use-canvas-built-by-copilot.png "Fill in the attributes in the canvas built by copilot")

[!INCLUDE[footer-include](../includes/footer-banner.md)]