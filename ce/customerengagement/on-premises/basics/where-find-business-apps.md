---
title: "Where to find your business apps (Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
ms.custom: 
ms.date: 05/05/2020
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
  - Dynamics 365 Customer Engagement (on-premises) (on-premises)
author: shubhadaj
ms.assetid: 03968b0d-5505-45d0-90ff-4bacefbf3559
caps.latest.revision: 15
author: mduelae
ms.author: mkaur
search.audienceType: 
  - enduser

---
# Where to find your business apps

::: moniker range=">= op-9-1"

[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Use model-driven apps in Power Apps](/powerapps/user/use-model-driven-apps)


Business apps are available to users based on their security roles. If your system administrator has created any new apps, they will be visible to you if your security role has been given access to those apps. 

With version 9.1 your system administrator has the option to enabled the new Unified Interface for your apps. Unified Interface provides a consistent and accessible user experience across devices—whether on a desktop, laptop, tablet, or phone. The apps scale by reflowing the components on the screen. The responsive design adapts to your environment based on screen size, so the more available space that you have, the more information can be displayed.

The easiest way to tell whether you're using Unified Interface or the Legacy Web Client is to look at the site map. In Unified Interface the site map is on the left.

> [!div class="mx-imgBorder"]
> ![Unified interface for on-prim](media/uci-onprem-interface.png "Unified interface for on-prem")


The site map for the Legacy Web Client is at the top.

> [!div class="mx-imgBorder"]
> ![Web client interface](media/web-client-interface.png "Web client interface")


## Find apps in Unifited Interface

Use the app-selector menu to switch between apps.

1. Select the current app name.

   > [!div class="mx-imgBorder"]
   > ![Select the current app name](media/access-site-map.png "Select the current app name")

2. On the **Apps** page select an app. You will only see apps for your organization.

   > [!div class="mx-imgBorder"]
   > ![Select an app to use](media/access-site-map-1.png "Select an app to use")

## Find apps in the Legacy Web Client 

1. Sign in to Dynamics 365 Customer Engagement (on-premises).  
  
2. Go to **Settings** > **My Apps**.  
  
    The page shows all published Customer Engagement (on-premises) based on your organization's licensing options, and your security role.  
  
    You can also directly open the My Apps page by entering the following URL in your browser:  https://\<server name>/\<orgName>/apps.  
  
    The My Apps page has two views: Published Apps and Apps Being Edited. All draft apps are available in the **Apps Being Edited** view. All published apps are available in the **Published Apps** view.  
  
3. In the **Published Apps** view, click the app that you want to use.  
  
   > [!NOTE]
   >  If you are a system administrator, a customizer or a user with equivalent privileges, you'll see apps in published as well as draft states.  
  
When you use an app, you'll see only those entities in the site map  and other places in the app that your system administrator has added while designing the app.  
  
> [!NOTE]
> - The Quick Create menu, Global Search, and Recent Records within the app aren't filtered. These show and can be searched on all entities instead of only the entities that are added to the app.  
>   -   When you search using Advanced Find, it searches all entities and not just the entities added to the app.  

::: moniker-end

::: moniker range="< op-9-0"

[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Use model-driven apps in Power Apps](/powerapps/user/use-model-driven-apps)

Business apps are available to users based on their security roles. If your system administrator has created any new apps, they will be visible to you if your security role has been given access to those apps. 
  
1. Sign in to Dynamics 365 Customer Engagement (on-premises).  
  
2. Go to **Settings** > **My Apps**.  
  
    The page shows all published Customer Engagement (on-premises) based on your organization's licensing options, and your security role.  
  
    You can also directly open the My Apps page by entering the following URL in your browser:  https://\<server name>/\<orgName>/apps.  
  
    The My Apps page has two views: Published Apps and Apps Being Edited. All draft apps are available in the **Apps Being Edited** view. All published apps are available in the **Published Apps** view.  
  
3. In the **Published Apps** view, click the app that you want to use.  
  
   > [!NOTE]
   >  If you are a system administrator, a customizer or a user with equivalent privileges, you'll see apps in published as well as draft states.  
  
When you use an app, you'll see only those entities in the site map  and other places in the app that your system administrator has added while designing the app.  
  
> [!NOTE]
> - The Quick Create menu, Global Search, and Recent Records within the app aren't filtered. These show and can be searched on all entities instead of only the entities that are added to the app.  
>   -   When you search using Advanced Find, it searches all entities and not just the entities added to the app.  

::: moniker-end



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
