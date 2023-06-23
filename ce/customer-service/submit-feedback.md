---
title: Submit ratings and feedback for knowledge articles
description: Learn how you can submit feedback about knowledge articles in Dynamics 365 Customer Service.
ms.date: 06/23/2023
ms.topic: article
author: Soumyasd27
ms.author: sdas
search.audienceType: 
  - admin
  - customizer
  - enduser
ms.custom: 
  - dyn365-customerservice
  - bap-template
---

# Submit ratings and feedback for knowledge articles

You can easily provide feedback on knowledge articles with the help of knowledge article rating. Knowledge managers can capture and review the feedback on the articles to improve and maintain a relevant knowledge base.

In Customer Service workspace, when you open an article from the **Knowledge** tab, you can select either the **Thumbs up** or the **Thumbs down** option to state whether the article was helpful. If you select the **Thumbs down** option, you'll see a **Comments** box, where you can also enter your feedback for an article.

However, note that the **Thumbs up** icon at the top of an article doesn't represent the total number of likes for an article. The number that you see might range from 0-5 and can include decimals such as 0.75. This is because the **Thumbs up** icon indicates the average rating of the article based on the feedback and the number of ratings received. The **knowledgearticle.rating** field is a rollup field defined as Aggregate(Average(feedback.normalizedrating)).

> [!NOTE]
> - Rating and view count numbers are rollup fields that are not updated instantly. For more details, see [Define rollup fields](../customerengagement/on-premises/customize/define-rollup-fields.md).> 
> - Ensure that the knowledge article entity is enabled for feedback. To learn more, see [Enable an entity for feedback/ratings](/dynamics365/customer-engagement/customize/enable-entity-feedback).
> - Customer service agents and customer service managers can create, or view feedbacks based on their role and privileges on the feedback entity. Out of the box, customer service agents can create, view, or edit their own feedback only. Customer service managers or knowledge managers can view feedback submitted by all agents.

## Submit ratings and feedback

1. On the Customer Service workspace site map, select **Knowledge Search**.

1. From the **Search** tab, select and open an article from the search results.

1. Select **Thumbs up** if the article was helpful to you, or select **Thumbs down**, if it wasn't. You can also submit your feedback in the **Comments** box.

    ![Provide comments.](media/ka-rating-feedback-provide-comments.png "Provide comments")

### See also

[Set up knowledge management](set-up-knowledge-management-embedded-knowledge-search.md#set-up-knowledge-management)

[Search knowledge articles](search-knowledge-articles-csh.md#search-knowledge-articles)

[Create and manage knowledge articles](customer-service-hub-user-guide-knowledge-article.md)
 
[Understand knowledge base search mechanisms](knowledge-base-search-methods.md) 

[Add the Knowledge Base Search control to forms](add-knowledge-base-search-control-forms.md#add-the-knowledge-base-search-control-to-forms)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
