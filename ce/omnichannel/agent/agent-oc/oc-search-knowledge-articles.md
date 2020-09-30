---
title: "Search for and share knowledge articles in Omnichannel for Customer Service | MicrosoftDocs"
description: "Learn how to set your presence status in Omnichannel for Customer Service."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 10/09/2020
ms.service: 
  "dynamics-365-customerservice"
ms.topic: article
---

# Search for and share knowledge articles

[!INCLUDE[cc-use-with-omnichannel](../../../includes/cc-use-with-omnichannel.md)]

## Search knowledge articles

Knowledge management plays an important part in the customer service process, and access to accurate and up-to-date information can help you reduce the average handling time to provide quick and accurate answers to your customers.

Omnichannel for Customer Service enables you to use the rich knowledge base so you can quickly search for relevant information while working on a case and provide accurate answers to customers without having to switch applications.

You can launch KB Search in the following ways:

- Productivity pane.
- Application tab menu.
- Communication panel.

## Knowledge tab on productivity pane

### Prerequisites

The productivity pane and knowledge base search must be enabled in app profile manager. 

### Use the knowledge pane to search for articles

In Omnichannel for Customer Service, when you are engaged in a conversation with a customer, you can use the **Knowledge** pane to search for knowledge articles and refer to them.

By default, the full text search displays 10 results and relevance search displays 50 results.

![Knowledge tab in productivity pane](../../media/oc-productivity-knowledge-tab.png "Knowledge tab in productivity pane")

  |Label|Description|
  |-----|-----------|
  |1.| Knowledge tab|
  |2.| Lets you link or unlink the article to the entity, such as the case.|
  |3.| Text appears when the article is linked to the entity.|
  |4.| Number of times the article has been viewed.|
  |||

On the **Knowledge** pane, you can perform the following actions:

- Select the article title to open it in an application tab.
- Use the search box to enter keywords and search for articles.
- Select the filter icon to display the options based on which the articles can be filtered.
- Select sort icon to display the options based on which results can be displayed.
- Select the ellipses to display the following actions that can be performed:
  - Copy URL
  - Email URL
  - Email Content

    These actions can be performed for only published or expired articles.

### View the knowledge article in the application tab

Select an article title to view it in an application tab.  You can view up to 10 articles in the application tab.

You can perform the following actions for the knowledge article:

- Copy URL to copy the external URL of the article so you can share it with your customers over channels like chat or email.
- Provide feedback by selecting the thumbs up or thumbs down icon.
  - Make sure that the knowledge article entity is enabled for feedback. To learn more, see [Enable an entity for feedback/ratings](/dynamics365/customer-engagement/customize/enable-entity-feedback).
  - Customer service agents and customer service managers can create, or view feedbacks based on their role and privileges on feedback entity. Out of the box, customer service agents can create, view, or edit their own feedback only. Customer service managers or knowledge managers can view feedback submitted by all agents.
- When you select thumbs down, the **Comments** box to provide feedback appears. Optionally, provide additional information and reasons for the feedback.

### Filter knowledge articles

With the help of text and visual filters, you can filter the knowledge articles. To see knowledge articles in specific states, use the **Status** filter. You can filter search results to see all draft, published, or approved articles. See articles that are categorized as internal and external. You can also filter the articles based on date and language.

When you select the filter icon, you can see the **Filter by** menu where you can filter the items based on the following categories.

  | Category | Sub-category |
  |-----------------------|-----------------------|
  | Status | <ul> <li> Draft </li> <li> Approved </li> <li> Published </li> </ul> |
  | Visibility | <ul> <li> Internal </li> <li> External </li> <li> All </li> </ul> |
  | Modified Date | <ul> <li> Last 7 days </li> <li> Last 30 days </li> <li> Last 6 months </li> <li> Last year </li> <li> All </li> </ul> |
  | Language | <ul> <li> List of languages </li> </ul> **Note:** The language list is based on the articles that are present in the those languages. For example, there are a total of 50 articles in five different languages such as French, English, Japanese, Spanish, and Danish. The language filter will show only these five languages. |
  |||

### Sort knowledge articles

The knowledge base search control provides sort the knowledge articles interactions. Select the up-arrow icon to view the sorting options and select one of the options from the following: 

- Relevance
- Number of views
- Last modified date (newest first) 
- Last modified date (oldest first)

### Link and unlink the knowledge article to a record

When configured, you can link an article to case. You can associate and dissociate the knowledge article with a record.

- By default the articles are not linked to the case.
- When you select to link the article to the case, the link icon changes, and **Linked to Case** is displayed for the article.

### Email options

Use the following options to share the knowledge article link or knowledge article content through mail:

- **Email URL:** The new email form opens with the link to the article in the mail box.
- **Email Content:** The article content is populated in the mail body. The fields are automatically populated based on the case and customer details.

Add other information as needed, and then on the command bar, select **Send**.

## Launch the KB Search from the application tab menu

When working on a session, you can use the **+** button on the application table panel to launch **KB Search**. You can search for a KB article using the **KB Search** tab, and then view the article and use the **Send Link** option to share the link with the customer.

1. Select the + button in the application tab panel.
2. From the menu, select **KB Search**. The KB Search opens as a new tab in the application tab panel.
3. Search for the KB articles and view.
4. Select **Send Link** to share the KB article with the customer.

![Search Knowledge articles](../../media/oceh-oc-knowledge-articles-search.png "Search Knowledge articles")

## Launch the KB Search from the communication panel

When you interact with a customer in the conversation control, you can use the **Knowledge articles** option to launch the **KB Search** tab. Then you can search and share the KB articles.

1. Select the KB Search option in the communication panel. The KB Search tab opens in the application tab panel.
2. Search for the KB articles and view.
3. Select **Send Link**. The link is displayed in the message area of the communication panel.
4. Select **Send** in the communication panel.

![Search knowledge articles using the option from conversation control](../../media/oceh-oc-search-knowledge-articles-cc.png "Search knowledge articles using the option from conversation control")

### See also

- [Take notes specific to conversation](oc-take-notes.md)
- [View communication panel](oc-conversation-control.md)
- [Monitor real-time customer sentiment](oc-monitor-real-time-customer-sentiment-sessions.md)
- [View conversation and session activity types in the model-driven apps](oc-view-activity-types.md)
- [View customer summary](oc-customer-summary.md)
