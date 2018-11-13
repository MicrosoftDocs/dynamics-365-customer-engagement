---
title: "Instagram business account search rules | Microsoft Docs"
description: "Learn more about the changes to Instagram data acquisition and search rules."
keywords: "Instagram, data acquisition, search rules"
ms.date: 12/07/2018
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

# Instagram Account search and Instagram keyword search deprecation

On December 11, 2018, two changes are introduced in Microsoft Social Engagement regarding Instagram as a data source. We're adding search rules for owned Instagram Business Accounts search and the deprecation of the Instagram keyword search. 

## Instagram keyword search deprecation
Keyword searches are retired by Instagram on December 11, 2018. Due to this change we are also removing the keyword searches functionality in Microsoft Social Engagement. 

## How Instagram keyword search rules work after December 11, 2018?

Since the functionality of Instagram keyword searches is deprecated starting December 11th, no new keyword search queries for Instagram can be setup. 
Existing keyword search rules containing Instagram as a source will continue to exist as is, and the data acquired for these rules is preserved, as long as the rules are not changed.
If the user changes such a rule, Instagram needs to be removed as a source to be able to save the edited search rule.
In case you want to preserve your Instagram data acquired to date, we recommend that you setup a separate rule with the changes, and keep the rule with Instagram as is. 

## Introduction of Instagram Business Account search

With December 11th a new functionality for Instagram is available in Microsoft Social Engagement. Users will now be able to acquire posts and comments from their own Instagram Business accounts. To be able to acquire data from owned Instagram accounts, those accounts need to be Instagram Business accounts and need to be connected to the corresponding Facebook page. Find more information on how to connect an Instagram Business account with a Facebook page. 
The acquisition of posts and comments from owned Instagram accounts is done through the Facebook GRAPH API. 
To be able to acquire Instagram posts and comments the user needs to re-authenticate (or authenticate in case of new users) his Facebook Acquisition accounts in Social Profiles in Microsoft Social Engagement. The Facebook Acquisition profile in Social Profiles has been renamed to Facebook and Instagram Acquisition. Users need to be Administrator of the Facebook Page where their Instagram Business Account is linked to, to be able to authenticate within Microsoft Social Engagement. To be able to acquire the posts and identify the Instagram accounts linked to the Facebook page, we are requesting the following two permissions: Instagram_Basic and Manage_Pages. During the authentication the user has the choice to disallow the use of those permissions, but will not be able to use the Instagram functionality in Microsoft Social Engagement by doing so. 
To acquire posts and comments, you also will need to setup Instagram account rules in Search Setup. The Instagram accounts linked to your Facebook pages are listed in the Instagram account rules setup and can be simply chosen with a click for the setup. 
In case you are not interested in using the Instagram functionality you don’t have to re-authenticate your Facebook Acquisition accounts immediately. 

### See also