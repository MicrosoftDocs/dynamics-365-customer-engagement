---
title: "How to use conditional content (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to use conditional content features in Dynamics 365 Marketing."
ms.date: 10/10/2022
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

# How to use conditional content

Conditional content is an easy way to deliver effective and engaging personalized content. A simple example of conditional content is including different images based on a recipient’s profession, age group, address, interests, or other such factors. Creating this kind of personalized content in Dynamics 365 Marketing is straightforward, requiring no coding or scripting. Here is a short video that shows conditional content in action:

> [!VIDEO https://www.microsoft.com/videoplayer/embed/RE4Yb7B]

Conditional content, as the name implies, consists of two parts: condition and content. The combination of these two parts is called a “variation.” You can create as many variations as needed. At the time an email is sent, conditions are evaluated in the order they're present in the email. When a condition is satisfied, the corresponding content is included and the conditional evaluation stops. If none of the conditions are satisfied, the default content is used. If there's no default content, then no content is included.

> [!div class="mx-imgBorder"]
> ![Conditional content screenshot.](media/conditional-content-screenshot.png "Conditional content screenshot")

Conditional content can be a section or an image:

- A conditional section can include text, images, buttons, links, or any other element that is supported by the email editor.
- A conditional image only includes images.
- A conditional section can't include a conditional image.

> [!NOTE]
> A conditional image must have default content whereas default content is optional for a conditional section. This prevents delivering emails with misaligned layouts.

## When should you use conditional content?

Conditional content is a great way to personalize email content. Here are some ways you can use conditional content:

1. Include different images that match the recipient’s interests (for example, sports or hobbies).
1. Deliver different content based on the recipient’s demographic information (for example, city or state of residence, gender, or age).
1. Use different language content using the recipient’s preferred language or region/country.
1. A common usage is within footer where you may need to change some content (for example, social links or legal text) depending on the recipient’s information.

## Working with conditional content

This section explains how to create, delete, preview, and test conditional content.

### Create

> [!VIDEO https://www.microsoft.com/videoplayer/embed/RE4Yb7A]

1. In the email designer, select a section (or an image) and then select the conditional content button.

    > [!div class="mx-imgBorder"]
    > ![Screenshot of the conditional content button.](media/conditional-content-button.png "Screenshot of the conditional content button")

1. The section (or the image) frame changes color to indicate it's now a conditional section. The property pane on the right margin shows a new sub-tab called **Variation**. Select the **Variation** sub-tab.
1. Select **+ New Condition** in the property pane. Define the condition.
1. Add more conditions if needed. At this point, you have the same content associated with each condition.
1. Select **Default** on any condition for which you want to change the content.
1. Update the section (or image) in the designer.
1. Repeat the previous two steps to update all the content as needed.

### Delete

1. In the email designer, select a conditional section (or a conditional image) and then select the conditional content button
1. This will convert the conditional section (or the conditional image) into a normal section (or image) by deleting all conditions and associated content. The default content (or the first condition’s content if there's no default) is retained in the designer.

### Preview and test

> [!VIDEO https://www.microsoft.com/videoplayer/embed/RE4YmOM]

In the designer, you should always preview and test each variation to make sure there are no unexpected results. To preview and test, follow the steps below.

1. Select the **Preview and test** tab in the email designer and then select **Edit sample data**.
1. In the property pane, expand the **Conditional content** section.
1. **Email variation** lists all possible variations of the email. Select the variation you want to check. The main designer area will show the preview of that variation.
1. By default, variations are named using the names you gave to the conditions. If desired, you can rename the variation by updating its name in **Variation name** edit box.

## When to use conditional content vs conditions (advanced personalization)

As shown above, conditional content is a great way to deliver different images and content to better match a recipient’s interests and preferences. However, there are situations where you only want to change a few words or a sentence. For example, in many languages, initial greetings are different based on the recipient’s gender. In such situations, it is more efficient and convenient to use [conditions from advanced personalization](real-time-marketing-personalize-inline-conditions.md) than to create a complete duplicate section containing the same set of images and text only to change the greeting.

## Conditional content inside content blocks

Conditional content created at the section level can be saved as a [content block](content-blocks.md). This way, multiple conditions and their associated content are all saved inside a single content block for anyone to use. Creating conditions is easy, but does require some knowledge of customer data and, therefore, some users may find it harder to create conditions without errors. Saving conditional content as a content block is a great way to reduce errors and enable everyone on the team to use advanced conditions.

Using content blocks can also help drive consistency. For example, a “high-value customer” may require using multiple conditions. To make interactions more consistent, you can create a “starter” content block that has advanced conditions (tested and verified) with placeholder content. Anyone can then use the starter content block and update the content, so a standard and correct definition of “high value customer” is applied everywhere.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
