---
title: "Preview: Use natural language to create segments (Dynamics 365 Marketing) | Microsoft Docs"
description: "Use natural language assist to create segments in the real-time marketing area of Dynamics 365 Marketing."
ms.date: 11/09/2022
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

# Preview: Use natural language to create segments

> [!IMPORTANT]
> A preview feature is a feature that is not complete, but is made available before it’s officially in a release so customers can get early access and provide feedback. Preview features aren’t meant for production use and may have limited or restricted functionality.
> 
> Microsoft doesn't provide support for this preview feature. Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions. Preview features aren’t meant for production use, especially to process personal data or other data that are subject to legal or regulatory compliance requirements.

> [!VIDEO https://www.microsoft.com/videoplayer/embed/RE5csiL]

Segment creation traditionally required extensive knowledge of the complex data structures defined by your business. To simplify creating segments in real-time marketing, you can use natural language to describe the segment definition in simple English. Natural language segment creation lets you add the results query onto the segment builder at any level of the query logic, either as a new group or as an additional condition in your existing logic. You can even improve the natural language engine by giving feedback, helping you achieve more detailed results in the future.

To create a segment using natural language assist, select the **Segments** tab under the **Audience**. Enter the segment name and select the target audience (Contact or Lead) and enter a description for your segment. The more precise you make your description; the more accurate the natural language assist segment suggestions will be.

> [!div class="mx-imgBorder"]
> ![create a new segment](media/real-time-marketing-create-a-new-segment.png "create a new segment")

On the right side of the next screen, you'll see a **Query Assist** panel. The Query assist function uses the description you entered when creating your segment to suggest a data structure for the segment. If the suggested segment information is accurate, you can select the **Use** button to apply the suggested result to your new segment.

> [!div class="mx-imgBorder"]
> ![use a suggested result to a segment](media/real-time-marketing-add-a-suggested-result-to-a-segment.png "add a suggested result to a segment")

You can provide feedback on the suggested segment query by selecting the thumbs up or thumbs down button next to the result in the **Query Assist** pane. 

You can add further details to your segment by entering additional natural language searches into the Query assist pane. If you select the dropdown menu on the right side of the **Find contacts who…** search box, you can see previous searches and suggested searches.

If you select a new search, you'll notice that the **Use** button now has a dropdown option. If you select the dropdown option on the **Use** button, you can choose to replace a group, add the new query to an existing group, or add the new query as a new group.

> [!div class="mx-imgBorder"]
> ![provide your feedback](media/real-time-marketing-provide-feedback.png "provide your feedback")

[!INCLUDE[footer-include](../includes/footer-banner.md)]