---
title: "Stay up to date with alerts in Social Engagement | Microsoft Docs"
description: "Learn how to set up post alerts and trend alerts to stay on top of what's happening in social media."
keywords: "alerts, notification, emails"
ms.date: 11/01/2017
ms.service: mse
ms.topic: article
applies_to:
  - "Social Engagement"
ms.assetid: f2b7a251-39bf-4bb9-b963-0a98020e7f23
author: m-hartmann
ms.author: mhart
manager: sakudes
topic-status: Drafting
---

# Stay up to date with alerts

[comment]: <> (Made first sentence active voice. Also moved the info about managing alerts to a later paragraph where it flows and fits the topic better.) 
You can create email notifications to automatically send to a group of recipients when triggered. Alerts are user-specific, and every user role can create them. There are two types of alerts, which are based on filters and search topics:

- **Post alert:** An email notification is delivered to all specified email addresses within a few hours if any new posts match the selected filters. A summary email is delivered to your email account. 

- **Trend alert:** An email notification is delivered to all specified email addresses within a few hours if the volume of posts for any source exceeds the statistical expectation. A trend alert notifies you only if there are significant changes in post volumes that match the filters that you defined for an alert.

[comment]: <> (Moved the bit about the message center here.) 
Configure and manage your alerts in the **Message Center**. Your alerts configuration is visible only to you. Recipients of the alert won't be able to see or edit your alert configuration. However, an admin can remove email addresses from all alerts they are mapped to. 

Alert emails contain a link to the data set that matches the posts that triggered the alert. Choose this link to open and review the content in [!include[](../includes/pn-social-engagement-short.md)].

> [!VIDEO https://www.youtube.com/embed/lQKzwulgnmM]

## View your alerts list

To review your alerts, go to **Message Center** > **Alert Configuration**.  The information that you'll see about each alert is explained in the following table.

|List entry / symbol|What it means|
|--------------------------|-------------------|
|Alert symbol|Indicates whether the alert is enabled or paused. A gray symbol means that the alert is inactive. An orange symbol means that the alert is active.|
|Alert name|Name you provided while setting up the alert.|
|Alert type|Type of alert you set up.|
|Delete button ![Delete button](media/trashbin-icon.png "Delete button")|Delete an existing alert from the list if you no longer need it.|

## Create an alert

A simple way to create an alert is directly from your analysis. Filters and parameters that you defined for the current view will be filled in for you. You can create an alert from every section in Analytics. You can also go to the **Message Center** and create an alert. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Explore more options with your data set](more-options-with-data-set.md)

1.  Go to **Message Center** > **Alert Configuration**.

2.  In the **Alerts** pane, click the **Add** button ![Add button](media/add-icon.png "Add button").

3.  In the alert configuration dialog box, enter a name (up to 128 characters) for your alert.

4.  Select the status of your alert. If you want to be notified right away, select **Active**. If you prepare the alert for a specific event in the future and plan to activate it later, select **Inactive**.

5.  Select the alert type to create:

    - **Post Alert** to receive an alert if a post matches your filters. For post alerts, select the **No duplicates** check box if you don't want to be informed when the same content appears in multiple sources.

    - **Trend Alert** to receive an alert if the post volume exceeds the statistical expectation for your filters. For [trend alerts](#set-a-trend-alerts-sensitivity), select the **sensitivity** of your alert by selecting from the options.

6.  Or, edit the data set or add more recipients for your alert.

7.  Click **Save**.

## Change or delete an alert

You can [edit](#change-an-alert) or [delete](#delete-an-alert) any alerts that you created in the **Message Center**. Any changes in the alert configuration are applied immediately.

> [!TIP]
> You can't change the alert type after you create a new alert. However, you can always edit and update the data set, recipients, and name for an existing alert.
>
> You can set an alert status to **inactive**, or you can **reactivate** an inactive alert at any time. Recipients of an inactive or deleted alert will no longer receive the notification from this alert.
> 
> If the alert configuration gets updated after an alert email was sent, all links in the alert email will match the updated configuration.

### Change an alert

1.  Go to **Message Center** > **Alert Configuration**.

2.  Select the alert that you want to edit.

3.  In the **Alert Details** pane, edit the values that you want to change.

4.  To save your changes, click **Save**.


### Delete an alert

1.  Go to **Message Center** > **Alert Configuration**.

2.  In the **Alerts** pane, find the alert that you want to delete, and then click the **Delete** button ![Delete button](media/trashbin-icon.png "Delete button").

3.  Confirm the deletion.

> [!NOTE]
> If an alert has been deleted, links in the alert email will redirect to **Analytics** > **Overview** with your default time frame selected. 

## Manage alert recipients as administrator

In an administrator role, you can look up email addresses and remove them from alerts that were configured by other users in your organization. You can also export the list of alerts that go to a specific email address. 

1. Go to **Message Center** > **Manage Recipients**.

2. Enter the email address you want to search for.

3. Select **Remove recipient** to remove the email address from the matching alerts. Optionally, you can select **Export** to download a list of the alerts that contain this recipient.

## Set a trend alert's sensitivity

After you create a trend alert, you may find that you receive too many (or too few) notifications. You can adjust the sensitivity to trigger the level of alerts more precisely.

Trend alert triggers are based on the number of posts and the average number of posts from the past five similar time frames. The average number of posts has a standard deviation. Sensitivity defines how many times the standard deviation is stacked on top of the average number of posts to trigger an alert.

When you work with a trend alert, you can select from five sensitivity settings:

|Sensitivity|Condition to trigger a trend alert|
|-----------------|----------------------------------------|
|Very low|Post volume &gt; (**4** &times; the standard deviation) &plus; average number of posts.|
|Low|Post volume &gt; (**2.5** &times; the standard deviation) &plus; average number of posts.|
|Balanced|Post volume &gt; (**1.66** &times; the standard deviation) &plus; average number of posts.|
|High|Post volume &gt; (**1.25** &times; the standard deviation) &plus; average number of posts.|
|Very high|Post volume &gt; standard deviation &plus; average number of posts.|

### See also

 [Get started with Social Engagement](get-started.md)   
 [Use filters to see relevant data](use-filters.md)   
 [Explore more options with your data set](more-options-with-data-set.md)
