---
title: "Instagram business account search rules | Microsoft Docs"
description: "Learn more about the changes to Instagram data acquisition and search rules."
keywords: "Instagram, data acquisition, search rules"
ms.date: 12/05/2018
ms.service: dynamics-365-marketing
ms.topic: article
ms.assetid: 967a4c6c-38de-4714-a65e-13832668c696
author: m-hartmann
ms.author: mhart
manager: shellyha
ms.custom: 
  - dyn365-socialengagement
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365SE
---

# [!INCLUDE [tn-instagram](../includes/tn-instagram.md)] Account search and [!INCLUDE [tn-instagram](../includes/tn-instagram.md)] keyword search removal

On December 11, 2018, two changes will be introduced in [!INCLUDE [pn-social-engagement-short](../includes/pn-social-engagement-short.md)] regarding [!INCLUDE [tn-instagram](../includes/tn-instagram.md)] as a data source. We're adding search rules for owned [!INCLUDE [tn-instagram](../includes/tn-instagram.md)] business accounts and are removing the [!INCLUDE [tn-instagram](../includes/tn-instagram.md)] keyword search functionality. 

## [!INCLUDE [tn-instagram](../includes/tn-instagram.md)] keyword search removal
Keyword searches will be retired by [!INCLUDE [tn-instagram](../includes/tn-instagram.md)] on December 11, 2018. Due to this change, we will also be removing the keyword search functionality in [!INCLUDE [pn-social-engagement-short](../includes/pn-social-engagement-short.md)]. 

## How will [!INCLUDE [tn-instagram](../includes/tn-instagram.md)] keyword search rules work after December 11, 2018?

Since the functionality of [!INCLUDE [tn-instagram](../includes/tn-instagram.md)] keyword searches will be removed on December 11th, no new keyword search queries for [!INCLUDE [tn-instagram](../includes/tn-instagram.md)] can be set up. 

Existing keyword search rules containing [!INCLUDE [tn-instagram](../includes/tn-instagram.md)] as a source will continue to exist as is, and the data acquired for these rules will be preserved, as long as the rules are not changed.
If the user changes such a rule, [!INCLUDE [tn-instagram](../includes/tn-instagram.md)] needs to be removed as a source to be able to save the edited search rule.

If you want to preserve your [!INCLUDE [tn-instagram](../includes/tn-instagram.md)] data acquired to date, we recommend that you set up a separate rule with the changes, and keep the rule with [!INCLUDE [tn-instagram](../includes/tn-instagram.md)] as is. 

## [!INCLUDE [tn-instagram](../includes/tn-instagram.md)] Business Account search

On December 11th, a new functionality for [!INCLUDE [tn-instagram](../includes/tn-instagram.md)] is available in [!INCLUDE [pn-social-engagement-short](../includes/pn-social-engagement-short.md)]. Users will now be able to acquire posts and comments from their own [!INCLUDE [tn-instagram](../includes/tn-instagram.md)] business accounts. To be able to acquire data from owned [!INCLUDE [tn-instagram](../includes/tn-instagram.md)] accounts, those accounts need to be [!INCLUDE [tn-instagram](../includes/tn-instagram.md)] business accounts and need to be connected to the corresponding [!INCLUDE [tn-facebook](../includes/tn-facebook.md)] page. [Find more information on how to connect an Instagram Business account with a Facebook page.](https://help.instagram.com/356902681064399)

The acquisition of posts and comments from owned [!INCLUDE [tn-instagram](../includes/tn-instagram.md)] accounts is done through the [!INCLUDE [tn-facebook](../includes/tn-facebook.md)] Graph API using a user token and thus relies on individual user permissions. All [!INCLUDE [tn-instagram](../includes/tn-instagram.md)] tokens must have admin permissions on all [!INCLUDE [tn-facebook](../includes/tn-facebook.md)] pages and linked [!INCLUDE [tn-instagram](../includes/tn-instagram.md)] business accounts used in Social Engagement.

To be able to acquire [!INCLUDE [tn-instagram](../includes/tn-instagram.md)] posts and comments, users need to reauthenticate (or authenticate, in the case of new users) their [!INCLUDE [tn-facebook](../includes/tn-facebook.md)] and [!INCLUDE [tn-instagram](../includes/tn-instagram.md)] acquisition accounts in Social Profiles in [!INCLUDE [pn-social-engagement-short](../includes/pn-social-engagement-short.md)]. The [!INCLUDE [tn-facebook](../includes/tn-facebook.md)] Acquisition profile in Social Profiles has been renamed to [!INCLUDE [tn-facebook](../includes/tn-facebook.md)] and [!INCLUDE [tn-instagram](../includes/tn-instagram.md)] Acquisition. To be able to authenticate within [!INCLUDE [pn-social-engagement-short](../includes/pn-social-engagement-short.md)], users need to be the administrator of the [!INCLUDE [tn-facebook](../includes/tn-facebook.md)] page that their [!INCLUDE [tn-instagram](../includes/tn-instagram.md)] business account is linked to. 

For users who want to be able to acquire posts and identify the [!INCLUDE [tn-instagram](../includes/tn-instagram.md)] accounts linked to the [!INCLUDE [tn-facebook](../includes/tn-facebook.md)] page, we are requesting the *Instagram_Basic* and *Pages_show_list* permissions, along with the permissions to acquire data from [!INCLUDE [tn-facebook](../includes/tn-facebook.md)] pages. During the authentication, the user has the choice to disallow the use of those permissions but will not be able to use the [!INCLUDE [tn-instagram](../includes/tn-instagram.md)] functionality in [!INCLUDE [pn-social-engagement-short](../includes/pn-social-engagement-short.md)] by doing so. 

![Add a social profile for Facebook and Instagram acquisition](media/instagram-acquisition-profile.png)

To acquire posts and comments, you will also need to set up [!INCLUDE [tn-instagram](../includes/tn-instagram.md)] account rules in Search Setup. The [!INCLUDE [tn-instagram](../includes/tn-instagram.md)] accounts linked to your [!INCLUDE [tn-facebook](../includes/tn-facebook.md)] pages are listed in the [!INCLUDE [tn-instagram](../includes/tn-instagram.md)] account rules setup, where they can be selected. 

If you are not interested in using the [!INCLUDE [tn-instagram](../includes/tn-instagram.md)] functionality, you don’t have to reauthenticate your [!INCLUDE [tn-facebook](../includes/tn-facebook.md)] Acquisition accounts immediately. 

### See also
[Set up searches to listen to social media conversations](set-up-searches.md)    
[Acquire data from Facebook pages](facebook-pages-data-acquisition.md)
