---
title: "Configure and authenticate social media accounts  (Dynamics 365 Marketing) | Microsoft Docs"
description: "Configure and authenticate each social media account where you'd like to author, schedule, and post updates in Dynamics 365 Marketing."
ms.date: 10/04/2019
ms.service: dynamics-365-marketing
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

# Configure your social media accounts

Social posting enables Dynamics 365 Marketing users to author, schedule, and publish posts to a variety of social media channels and accounts. You must configure and authenticate each channel and account that you'd like to make available for use with this feature. In the current version, you can configure accounts for Twitter, LinkedIn, and Facebook.

To add and authenticate a social media account:

1. Go to **Settings** > **Advanced Settings** > **Marketing settings** > **Social configuration**. A list view opens showing your existing social media accounts (if any).
1. Select **Create configuration** on the command bar.
1. A quick-create flyout slides in from the side of the screen. Make the following settings:
    - **Name**: Enter a name that you and others will easily recognize. Choose a name that gives a good idea what type of channel it is what type of content should be posted there, such as "Contoso Electronics LinkedIn."
    - **Social channel**: Choose the social-media site you want to connect to (such as LinkedIn or Facebook).
1. After you've selected a channel, links for the **Privacy policy** and **Terms of service** of your selected channel are provided. It's important that you read and understand these terms before you begin using this feature.
1. Provided you agree with the privacy policy and terms of service, select **Create** to continue.
1. Follow the instructions on your screen to sign in to your social media account and allow Dynamics 365 Marketing to post through this account.
    > [!IMPORTANT]
    > If you are setting up a Facebook account that has more than one Facebook page associated with it, then pay extra attention to the settings offered while you are setting up the connection. One of the setup pages will ask you which of your Facebook pages you want to use&mdash;be sure to choose **All pages** first (to make all pages available) and then choose the specific page later on. Otherwise, Facebook will choose an arbitrary page from among those you have set up on the site. If you miss the **All pages** setting, then you must reauthorize the connection (as described in the following procedure) and try again.

If your sign-in times out, or if the password changes on one of your accounts, you can update an account by doing the following:

1. Go to **Settings** > **Advanced Settings** > **Marketing settings** > **Social configuration**.
1. Select a social media configuration from the list.
1. Select **Reauthorize** on the command bar.
1. Follow the instructions on your screen to update your sign-in details.

You can delete a social configuration at any time to prevent Dynamics 365 Marketing from posting through that account from now on. Use the **Delete** button on the command bar to delete the currently shown or selected configuration.

### See also

[Open the advanced settings](open-advanced-settings.md)  
[Schedule and post messages on social media](social-posting.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]