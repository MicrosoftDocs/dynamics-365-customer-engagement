---
title: "Personalize content using pre-defined dynamic text (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to personalize content using pre-defined dynamic text in Dynamics 365 Marketing."
ms.date: 04/10/2023
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

# Personalize content using pre-defined dynamic text

Personalized messages help marketers drive engagement. A common way to personalize content is to use dynamic text (also known as placeholder text) that is automatically replaced with recipients' personal details when the message is sent. For example, rather than using a generic greeting like “Dear customer,” you can use dynamic text (“Dear ``{{FirstName}}``”) that is replaced with the customer name (“Dear John”) upon sending the message.

An instance of placeholder text such as ``{{Firstname}}`` is called pre-defined dynamic text. Before you can use dynamic text, you need to define three pieces of information:

1. **Data binding**: Where the replacement data for the dynamic text come from (for example, the “firstname” attribute of a “Contact” table).
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

The pre-defined dynamic text list may be different than shown here because it's dynamic. As your admin and other users create and share more pre-defined dynamic text, the fragments are added to the list. The top 10 items on the list are sorted by org-wide usage. If there are more than 10 items in the list, you'll see the remaining items sorted by alphabetical order after the top 10 items.

> [!div class="mx-imgBorder"]
> ![Screenshot of the pre-defined dynamic text list.](media/real-time-marketing-predefined-tokens-list.png "Screenshot of the pre-defined dynamic text list")

You can hover on dynamic text in the pre-defined list to see its details. Alternatively, you can select the vertical ellipses next to the dynamic text's name and then select **More info**.

### Changing the default value for the current message

Most of the time you should be able to use pre-defined dynamic text as-is, but sometimes you may need to change a default value. For example, the default value “Customer” may not work if your email is to non-customers. In this case, you can change the default value by selecting the pre-defined dynamic text in the editor canvas and then selecting the **Personalization** menu. After changing the default value, make sure to save it. An updated version of the pre-defined dynamic text will be saved, *but only for the current message*.

### Changing the default value globally

> [!NOTE]
> You can update the default value of a pre-defined text. Only the default value can be changed if you want to change its definition, you must remove the current pre-defined text and add a new one.

“Update” is shown only when default value is changed (otherwise it is not shown) and that default value is the only thing that can be changed for a pre-defined dynamic text. To change the global default value, select the vertical ellipses next to the pre-defined dynamic text's name and then select **Update pre-defined dynamic text**. The pre-defined dynamic text will be updated for the current message and globally for future usage of the dynamic text in new messages (existing messages aren't affected).

  > [!div class="mx-imgBorder"]
  > ![Screenshot of updating pre-defined dynamic text.](media/real-time-marketing-update-predefined-tokens.png "Screenshot of updating pre-defined dynamic text")

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

> [!NOTE]
> The **Update** option is only available for pre-defined text if the default value changed.

## Removing pre-defined dynamic text

To remove pre-defined dynamic text:

1. Place your cursor in an empty space in the text box and then select **Personalization** from the menu bar that pops up.
1. Select the vertical ellipses next to the dynamic text name.
1. Select **Remove pre-defined dynamic text** from the menu.

    > [!div class="mx-imgBorder"]
    > ![Screenshot of removing pre-defined dynamic text.](media/real-time-marketing-predefined-tokens-remove.png "Screenshot of removing pre-defined dynamic text")

## Communicate dates and times in various formats

When you work with multiple geographies and languages, communicating dates and times clearly requires using the right format to match the recipient's expectations. To ensure your communications are clear for all recipients, real-time marketing supports many date and time formats.

Whenever dynamic text is defined using a *datetime* type attribute, another set of options becomes available to select a date/time format that is readable and consistent with the locale (language and region) of the audience. If desired, you can also change the locale and time zone to match the audience. The Marketing app also automatically converts the stored date/time into the selected time zone.

Available formatting options offer three ways to present information: date and time, date only, and time only. Within each format, there are multiple options to cover various use cases.

> [!Note]
> If the attribute is of type *Date* only, you won't see date-and-time-only options.

> [!div class="mx-imgBorder"]
> ![Date and time format](media/real-time-marketing-date-and-time-format.png "Date and time format")

When you select a specific display option, it's applied to that specific dynamic text only. Marketing remembers the last format used (and selects it automatically for the next dynamic text to help drive consistency). You can also change the format, allowing you the flexibility to present the date and time in different formats within the same email.

If needed, you can change the language and region setting along with time zone by selecting the **Edit** option. When the language and region are changed, Marketing automatically converts the stored date and time into the selected time zone.

> [!Note]
> The automatic time zone conversion may result in a date change.

> [!div class="mx-imgBorder"]
> ![locale and time zone](media/real-time-marketing-locale-and-time-zone.png "locale and time zone")

### Using data that is reached by traversing a 1-to-many relation

> [!TIP]
> How to enable the preview for more data for personalization
>
> If you don’t see this feature in your app, contact your admin who can activate it by going to **Settings > Overview > Feature switches**, scrolling to **Personalization** area, enabling the **One-to-many-relation for Dynamic text** feature switch, and saving the setting by selecting on **Save** on the top right corner.

Personalized messages drive engagement that helps deliver desired business outcomes. [Dynamic text](real-time-marketing-predefined-dynamic-text.md) in real-time marketing makes it easy to include personalized information for each recipient. Previously, dynamic text was limited to data that could be reached by 1-to-1 or many-to-1 relations. Now, you can use data that requires traversing 1-to-many or many-to-many relations, unlocking even more data for personalization. 

Watch this video to learn more:

> [!VIDEO https://www.microsoft.com/videoplayer/embed/RW10ZeH]

Consider a university alumni donation campaign where you would want to include name of the college attended by each alum to drive maximum engagement. An alum might have attended multiple colleges in that university, resulting in a "1-to-many" relationship between student and college records. Dynamic text can now be defined for such data.

#### Define dynamic text that uses 1-to-many or many-to-many relations

When defining 1-to-many dynamic text, the system needs to know which one out of many related records should be used for data retrieval. You can use the default condition (the first record after sorting by "Created on") or define your own condition, as appropriate. In the example below, dynamic text is being defined to include the owning team's name for service cases for the recipient. As there can be multiple cases for a recipient, you can define a condition to pick the high priority case. However, sometimes that may not be sufficient (there can be multiple high priority cases), and for such cases the system always has a default condition (most recently created record) that will be used as tiebreaker if and when needed.

> [!div class="mx-imgBorder"]
> ![1-to-many example screenshot](media/real-time-marketing-one-to-many.png "1-to-many example screenshot")

### Access even more data for personalization

You can access any Dataverse table to include information in your communications, not just tables that are directly related to an Audience or Triggers.

> [!Note]
> This feature is available only in real-time marketing.

#### Using data from additional tables in dynamic text

Most of the time, Dynamic text is used to personalize messages using data from an Audience (for example, Contact or Lead) or Triggers. Dynamic text can also use data from Dataverse tables that can be reached through relationships with an Audience or Triggers. However, there are times when you need to use data from tables that don't have an established or usable relationship with the Audience or Triggers. For example, you may want to include information about a company building available in the Dataverse table “Building" that has no direct or usable relationship with a Contact or Lead. In such case, your starting point for defining dynamic text will be in the “Other tables” dropdown in the **Create dynamic text** menu.

> [!div class="mx-imgBorder"]
> ![Create dynamic text](media/real-time-marketing-create-dynamic-text.png "Create dynamic text")

The “Other tables” area includes some of the most commonly used Dataverse tables (for example, event-planning-related tables). When you search for attributes, the search includes these tables. You can define dynamic text using the other tables just like you do with Audience or Triggers. Use an attribute directly or follow relationships from these tables to other related tables until you find the needed attribute.

There's one notable difference when you define dynamic text starting with “Other tables”: before the message can be made “ready to send”, you must select a specific record from the selected table. If there's an Audience or Trigger, the specific record is provided by the journey context (that is, the Contact that is actually going through the journey). With the "other tables", you need to provide the specific record information when you're designing the personalized text because the text doesn't have a direct relationship with an Audience or Triggers. For example, if you select an attribute from the Events table, you're asked to select a specific event.

> [!div class="mx-imgBorder"]
> ![Select a record](media/real-time-marketing-select-a-record.png "select a record")

#### Using data from additional tables in advanced personalization

Similar to dynamic text, data from additional tables can also be used to define conditions and lists in advanced personalization.

> [!div class="mx-imgBorder"]
> ![select a condition](media/real-time-marketing-select-a-condition.png "select a condition")

> [!div class="mx-imgBorder"]
> ![enter details](media/real-time-marketing-enter-details.png "enter details")

#### Validating and finalizing

Though you can decide not to select a specific record right away, the specific record selection must be done before the message can be made “ready to send”. Leaving the record selection for later can be a useful approach to separate the content design phase from the content use (and reuse) phase. This is also how templates can be created. For example, a generic event invitation message like below can be created where all of the event-related dynamic text doesn't have an event selected.

> [!div class="mx-imgBorder"]
> ![enter personalization details](media/real-time-marketing-enter-personalization-details.png "enter personalization details")

The event selection step can then be completed when the message created from this template is ready to be used in a journey.  If you try to make the message “Ready to send” without completing this step, the validation gives an error message. Even without running the validation step, you can see what needs to be done in the personalization tab.

> [!div class="mx-imgBorder"]
> ![select a record to personalize](media/real-time-marketing-select-a-record-to-personalize.png "select a record to personalize")

#### Managing additional tables for personalization

The pick list contains up to 50 tables at any given time. To change the pick list tables, select a piece of dynamic text, expand the "Other tables (Needs record selection)" category, then select **Manage list**.

Use the pre-defined filters next to the search bar in the **Manage list** window to quickly filter the tables list to all tables, tables selected by default, tables that you've selected, or tables that are actually in use in the current message.

Select the tables you want to add or remove, then select **Save**.

  > [!div class="mx-imgBorder"]
  > ![Change the pick list](media/specific-record-manage-list.png "Change the pick list")

> [!NOTE]
> Removing dynamic text only removes it from the pre-defined list, it does not remove it from the messages that are already using it.

> The pre-defined dynamic text feature has a few known issues. Learn more: [Known issues in real-time marketing](real-time-marketing-known-issues.md#personalization).

[!INCLUDE[footer-include](../includes/footer-banner.md)]