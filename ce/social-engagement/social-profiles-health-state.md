---
title: "Check the health state of your social profiles in Social Engagement | Microsoft Docs"
description: "Learn how to keep the tokens of your social profiles in a healthy state."
keywords: "token, health state"
ms.date: 01/30/2018
ms.service: mse
ms.topic: article
applies_to:
  - "Social Engagement"
ms.assetid: 4d0153a1-4d21-4a73-8685-2ce2e6c55e9f
author: m-hartmann
ms.author: mhart
manager: sakudes
topic-status: Drafting
---

# Check the health state of your social profiles
[!INCLUDE[pn_netbreeze_long](../includes/pn-social-engagement-long.md)] provides health state checks for tokens of social profiles for data acquisition and interaction so you can make sure they are always active. Checking health states is important so you don't miss out on any posts because of expired tokens. [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] will notify you through email and in the application when your critical acquisition [tokens are about to expire](manage-access-tokens.md).  
  
 socialengagement@microsoft.com will send email notifications for the following scenarios:  
  
-   Your token has been active for 30 days and will expire soon. Reauthenticate your token or add an additional token.  
  
-   Your token has been active for 45 days and will expire soon. Reauthenticate your token or add an additional token.  
  
-   Yellow health state: Only one token is currently valid.  
  
-   Red helath state: No tokens are currently valid and you can't work with them until new tokens are authenticated.  


> [!NOTE]
> While adding or reauthenticating a social profile for [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] data acquisition, [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] might encounter an error due to rate limits on our [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] connector app. Please wait about 15 minutes before trying to add or reauthenticate your profile again.
  
## Social profile ownership  
 To claim ownership of an account, go to **Settings** > **Social Profiles**. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Manage social profiles](manage-social-profiles.md)  
  
||||  
|-|-|-|  
|**Health State**|**Symbol**|**Action you can perform**|  
|Valid|No symbol displayed|No action needed. The token is valid.|  
|Valid, but your token is not valid|![At least one token is not valid symbol](media/token-not-valid-icon.png "At least one token is not valid symbol")|Re-authorize this account or delete it.|  
|The account isn’t valid; if the user has a token, it also isn’t valid|![No valid token symbol](media/token-missing-icon.png "No valid token symbol")|Re-authorize the social profile if you are the owner, or claim ownership or contact one of the owners if this profile is shared with you.|  
|No owner; invalid without any owner|![No Ownership symbol](media/no-ownership-icon.png "No Ownership symbol")|Claim ownership if you want to use this account. To claim ownership of an account, go to **Settings** > **Social Profiles**. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Manage social profiles](manage-social-profiles.md)|  
  
## Acquisition symbols  
 The symbols below indicate whether your search acquisition or private message acquisition is valid. You can find these symbols under the Acquisitions column in your lists of owned profiles and profiles without owners.  
  
> [!NOTE]
>  These symbols will be dimmed if acquisition is inactive.  
  
|||  
|-|-|  
|**Symbol**|**Condition**|  
|![Search button](media/magnifier-icon.png "Search button")|Acquisition is allowed but no search rule has been set up.|  
|![Keywords symbol](media/keywords-search-rule-icon.png "Keywords symbol")|Acquisition is allowed and a search rule is in use.|  
|![Private messages symbol](media/private-message-icon.png "Private messages symbol")|Acquisition of private messages has been allowed and a private message rule is in use.|  
  
## Acquisition token status overview  
 Social Engagement displays symbols to let you know if social profile data acquisition and private messages are running.  
  
||||  
|-|-|-|  
|**State**|**Symbol**|**Condition**|  
|Running|![Indicates that data acquisition and private messages are running for this social profile](media/valid-token-icon.png "Indicates that data acquisition and private messages are running for this social profile")|At least one token is valid and used for acquisition.|  
|Allowed|![Acquisition Allowed symbol](media/acquition-allowed-icon.png "Acquisition Allowed symbol")|The social profile allows acquisition but no search rule has been added.|  
|Expired|![No valid token symbol](media/token-missing-icon.png "No valid token symbol")|The social profile token is expired. You need to [reauthenticate your token](manage-access-tokens.md#reauthenticate-a-token).|  
  
### See Also  
 [Manage social profiles](manage-social-profiles.md)   
 [Manage access tokens](manage-access-tokens.md)