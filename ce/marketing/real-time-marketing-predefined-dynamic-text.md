---
title: "Personalize content using pre-defined dynamic text (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to personalize content using pre-defined dynamic text in Dynamics 365 Marketing."
ms.date: 12/06/2022
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

# Personalize content using pre-defined dynamic text

Personalized messages help marketers drive engagement. A common way to personalize content is to use dynamic text (also known as placeholder text) that is automatically replaced with recipients' personal details when the message is sent. For example, rather than using a generic greeting like “Dear customer,” you can use dynamic text (“Dear ``{{FirstName}}``”) that is replaced with the customer name (“Dear John”) upon sending the message.

An instance of placeholder text such as ``{{Firstname}}`` is called pre-defined dynamic text. Before you can use dynamic text, you need to define three pieces of information:

1. **Data binding**: Where the replacement data for the dynamic text will come from (for example, the “firstname” attribute of a “Contact” table).
1. **Label**: How the dynamic text is referred to within the message text (for example, ``{{Firstname}}``).
1. **Default value**: What text to use if the source data is empty.

Defining data binding requires some understanding of the [Dataverse data model](/powerapps/maker/data-platform/data-platform-intro) to correctly connect the dynamic text to the right data source.

Pre-defined dynamic text is text that has already been defined by someone else and is ready to be used. Marketing ships with a set of commonly used pieces of pre-defined dynamic text. More can be added by you or your teammates (see [Creating and sharing pre-defined dynamic text](real-time-marketing-predefined-dynamic-text.md#creating-and-sharing-pre-defined-dynamic-text)).

## Using pre-defined dynamic text

Select **Personalize** in the email or text message editor to see a list of pre-defined dynamic text fragments. Next, select some pre-defined dynamic text from the list to insert it into the message:

**Email editor**:

> [!div class="mx-imgBorder"]
> ![Screenshot of adding pre-defined dynamic text to an email message.](media/real-time-marketing-predefined-tokens-email.png "Screenshot of adding pre-defined dynamic text to an email message")

**Text message editor**:

> [!div class="mx-imgBorder"]
> ![Screenshot of adding pre-defined dynamic text to a text message.](media/real-time-marketing-predefined-tokens-text.png "Screenshot of adding pre-defined dynamic text to a text message")

The pre-defined dynamic text list may be different than shown here because it's dynamic. As your admin and other users create and share additional pre-defined dynamic text, the fragments will be added to the list. The top 10 items on the list are sorted by org-wide usage. If there are more than 10 items in the list, you'll see the remaining items sorted by alphabetical order after the top 10 items.

> [!div class="mx-imgBorder"]
> ![Screenshot of the pre-defined dynamic text list.](media/real-time-marketing-predefined-tokens-list.png "Screenshot of the pre-defined dynamic text list")

You can hover on dynamic text in the pre-defined list to see its details. Alternatively, you can select the vertical ellipses next to the dynamic text's name and then select **More info**.

### Changing the default value for the current message

Most of the time you should be able to use pre-defined dynamic text as-is, but sometimes you may need to change a default value. For example, the default value “Customer” may not work if your email is to non-customers. In this case, you can change the default value by selecting the pre-defined dynamic text in the editor canvas and then selecting the **Personalization** menu. After changing the default value, make sure to save it. This will save an updated version of the pre-defined dynamic text, *but only for the current message*.

### Changing the default value globally

If the default value provided isn't appropriate for your situation (for example, you may refer to your customers as “clients” or “guests” rather than “customer”), you can change the default value for everyone. To change the global default value, select the vertical ellipses next to the pre-defined dynamic text's name and then select **Update pre-defined dynamic text**. This will update the pre-defined dynamic text for the current message and globally for future usage of the dynamic text in new messages (existing messages aren't affected).

> [!div class="mx-imgBorder"]
> ![Screenshot of updating a default value globally.](media/real-time-marketing-predefined-tokens-update.png "Screenshot of updating a default value globally")

> [!IMPORTANT]
> The **Update pre-defined dynamic text** command only applies to the current message and future messages. It does not retroactively change previous uses of the dynamic text.

## Creating and sharing pre-defined dynamic text

You aren't limited to the pre-defined dynamic text that is included with the Marketing app. Any user can create new pre-defined dynamic text fragments and share them with their team by adding them to the pre-defined dynamic text list.

To define and share new pre-defined dynamic text, follow these steps:

1. Place your cursor in an empty space in the text box and then select **Personalization** from the menu bar that pops up. This opens the pre-defined personalization list.
1. Select **New dynamic text** at the bottom of the pre-defined dynamic text menu and complete steps to define the new dynamic text.

    > [!div class="mx-imgBorder"]
    > ![Screenshot of creating new pre-defined dynamic text.](media/real-time-marketing-predefined-tokens-steps2.png "Screenshot of creating new pre-defined dynamic text")

1. Select the down-facing carat next to the **Save** button and choose the **Save & add to pre-defined list** option.

    > [!div class="mx-imgBorder"]
    > ![Screenshot of saving and adding new pre-defined dynamic text.](media/real-time-marketing-predefined-tokens-save.png "Screenshot of saving and adding new pre-defined dynamic text")

## Removing pre-defined dynamic text

To remove pre-defined dynamic text:

1. Place your cursor in an empty space in the text box and then select **Personalization** from the menu bar that pops up.
1. Select the vertical ellipses next to the dynamic text name.
1. Select **Remove pre-defined dynamic text** from the menu.

    > [!div class="mx-imgBorder"]
    > ![Screenshot of removing pre-defined dynamic text.](media/real-time-marketing-predefined-tokens-remove.png "Screenshot of removing pre-defined dynamic text")

## Clearly communicate date and time using variety of formats

### Date and time formats

When working with multiple geographies and languages, communicating date and time clearly and unambiguously requires one to use the right format to match recipient's expectations. Real time marketing makes it easy to achieve this as it supports a variety of date and time formats. 

Whenever a dynamic text is defined using a datetime type attribute, an additional set of options becomes available to select a datetime format that is readable and consistent with the locale (language and region) of the audience. If desired, the locale and time zone can also be changed to match the audience. Marketing will automatically convert the stored date/time into the selected time zone.

Available format options include three ways to present information - date and time, date only, and time only. Withing each way, there are multiple options to cover various use cases (Note: If the attribute is of type Date only, you will not see date and time and time only options).

> [!div class="mx-imgBorder"]
> ![date and time format](media/real-time-marketing-date-and-time-format.png "date and time format")

When you select a specific display option, it is applied to that specific dynamic text only. Marketing does remember the last format used (and selects it automatically for the next dynamic text to help drive consistency) but it can be changed easily so flexibility of presenting date and time in different formats within the same email is still possible. 

If needed, you can also change the language and region setting along with time zone by clicking on the “Edit” option. When language and region is changed, Marketing will automatically convert the stored date and time into the selected time zone (note: this may result in a date change).

> [!div class="mx-imgBorder"]
> ![locale and time zone](media/real-time-marketing-locale-and-time-zone.png "locale and time zone")

> [!TIP]
> Removing dynamic text only removes it from the pre-defined list, it does not remove it from the messages that are already using it.

> [!NOTE]
> The pre-defined dynamic text feature has a few known issues. To learn more, refer to [Known issues in real-time marketing](real-time-marketing-known-issues.md#personalization).